Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrEstTransferenciaDeposito

#Region "::: FUNCTION / SUB :::"

    Public Sub Salvar(ByVal oGrid As GridEX, _
                      ByVal sNumeroDocumento As String, _
                      ByVal iDepositoOrigem As Integer, _
                      ByVal sObservacao As String)

        'Variaveis Locais        
        Dim i As Integer
        Dim oRow() As GridEXRow
        Dim oSqlParameter(10) As SqlParameter

        Try

            oRow = oGrid.GetDataRows

            For i = 0 To UBound(oRow)

                'Seta Parametros - Número do Documento
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "numero_documento"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.VarChar
                oSqlParameter(0).Size = 20
                oSqlParameter(0).Value = sNumeroDocumento

                'Seta Parametros - Código Depósito Origem
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_deposito_origem"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.Int
                oSqlParameter(1).Value = iDepositoOrigem

                'Seta Parametros - Código Item
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_item"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.BigInt
                oSqlParameter(2).Value = oRow(i).Cells("codigo").Value


                'Seta Parametros - Código Depósito Destino
                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "codigo_deposito_destino"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.Int
                oSqlParameter(4).Value = oRow(i).Cells("codigo_deposito").Value

                'Seta Parametros - Quantidade
                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "quantidade"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.Float
                oSqlParameter(5).Value = oRow(i).Cells("quantidade").Value

                'Seta Parametros - Observação
                oSqlParameter(6) = New SqlParameter
                oSqlParameter(6).ParameterName = "observacao"
                oSqlParameter(6).Direction = ParameterDirection.Input
                oSqlParameter(6).SqlDbType = SqlDbType.Text
                oSqlParameter(6).Value = sObservacao

                'Seta Parametros - Tipo Documento
                oSqlParameter(7) = New SqlParameter
                oSqlParameter(7).ParameterName = "tipo_documento"
                oSqlParameter(7).Direction = ParameterDirection.Input
                oSqlParameter(7).SqlDbType = SqlDbType.VarChar
                oSqlParameter(7).Size = 50
                oSqlParameter(7).Value = "TRANSFERÊNCIA DE DEPÓSITO"

                'Seta Parametros - Código Usuário
                oSqlParameter(8) = New SqlParameter
                oSqlParameter(8).ParameterName = "codigo_usuario"
                oSqlParameter(8).Direction = ParameterDirection.Input
                oSqlParameter(8).SqlDbType = SqlDbType.Int
                oSqlParameter(8).Value = goUsuario.iUsuario

                'Seta Parametros - Código Empresa
                oSqlParameter(9) = New SqlParameter
                oSqlParameter(9).ParameterName = "codigo_empresa"
                oSqlParameter(9).Direction = ParameterDirection.Input
                oSqlParameter(9).SqlDbType = SqlDbType.Int
                oSqlParameter(9).Value = goUsuario.iEmpresa

                oSqlParameter(10) = New SqlParameter
                oSqlParameter(10).ParameterName = "localizacao"
                oSqlParameter(10).Direction = ParameterDirection.Input
                oSqlParameter(10).SqlDbType = SqlDbType.VarChar
                oSqlParameter(10).Value = IIf(oRow(i).Cells("localizacao").Value = "", DBNull.Value, oRow(i).Cells("localizacao").Value)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_transferencia_deposito", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadNumeroDocumento() As String

        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim i As Integer = 0
            Dim sReturn As String

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número Inventário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = "TD" & Format(Now.Date, "yyyyMMdd")

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_movimentacao_numero_documento_transferencia", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadDescricaoItem(ByVal lCodigoItem As Long) As String

        Try

            'Variaveis Locais
            Dim oSqlParameter(0) As SqlParameter
            Dim sReturn As String

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_item"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoItem

            'Executa Query
            sReturn = CStr(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_descricao", oSqlParameter))

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadControles(ByVal lCodigoItem As Long, _
                             ByVal iCodigoDepositoOrigem As Integer, _
                             ByVal iCodigoDepositoDestino As Integer, _
                             ByVal txtSaldoOrigem As NumericEditBox, _
                             ByVal txtSaldoDestino As NumericEditBox, _
                             ByVal txtLocalizacao As MaskedEditBox)

        Try

            'Variaveis Locais
            Dim oSqlParameter(4) As SqlParameter
            Dim oSqlDataReader As SqlDataReader
            Dim sReturn As String
            Dim i As Integer = 0

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoDepositoOrigem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoDepositoDestino

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_transferencia_deposito_dados", oSqlParameter)

            While oSqlDataReader.Read
                txtLocalizacao.Text = oSqlDataReader.Item("localizacao")
                txtSaldoOrigem.Value = oSqlDataReader.Item("saldo_origem")
                txtSaldoDestino.Value = oSqlDataReader.Item("saldo_destino")
            End While

            oSqlDataReader.Close()
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesMAGMA(ByVal lCodigoItem As Long, _
                             ByVal iCodigoDepositoOrigem As Integer, _
                             ByVal iCodigoDepositoDestino As Integer, _
                             ByVal txtSaldoOrigem As NumericEditBox, _
                             ByVal txtSaldoDestino As NumericEditBox)

        Try

            'Variaveis Locais
            Dim oSqlParameter(4) As SqlParameter
            Dim oSqlDataReader As SqlDataReader
            Dim sReturn As String
            Dim i As Integer = 0

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoDepositoOrigem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoDepositoDestino

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_transferencia_deposito_dados", oSqlParameter)

            While oSqlDataReader.Read
                'cboLocalizacao.selectedvalue = oSqlDataReader.Item("localizacao")
                txtSaldoOrigem.Value = oSqlDataReader.Item("saldo_origem")
                txtSaldoDestino.Value = oSqlDataReader.Item("saldo_destino")
            End While

            oSqlDataReader.Close()
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesLocalizacaoMAGMA(ByVal lCodigoItem As Long, _
                            ByVal iCodigoDepositoOrigem As Integer, _
                            ByVal iCodigoDepositoDestino As Integer, _
                            ByVal sLocalizacao As String, _
                            ByVal txtSaldoOrigem As NumericEditBox, _
                            ByVal txtSaldoDestino As NumericEditBox)

        Try

            'Variaveis Locais
            Dim oSqlParameter(5) As SqlParameter
            Dim oSqlDataReader As SqlDataReader
            Dim sReturn As String
            Dim i As Integer = 0

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoDepositoOrigem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoDepositoDestino : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "localizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLocalizacao

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_transferencia_deposito_localizacao_dados", oSqlParameter)

            While oSqlDataReader.Read
                'cboLocalizacao.selectedvalue = oSqlDataReader.Item("localizacao")
                txtSaldoOrigem.Value = oSqlDataReader.Item("saldo_origem")
                txtSaldoDestino.Value = oSqlDataReader.Item("saldo_destino")
            End While

            oSqlDataReader.Close()
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadValorUnitarioItem(ByVal lCodigo As Long, _
                                          ByVal sLote As String, _
                                          ByVal iCodigoDepositoOrigem As Integer, _
                                          ByVal dQuantidade As Double) As Double

        Try

            'Variaveis Locais
            Dim oSqlParameter(3) As SqlParameter
            Dim dReturn As Double

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Lote
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "lote"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 50
            oSqlParameter(1).Value = sLote

            'Seta Parametros - Código Depósito Origem
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_deposito"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoDepositoOrigem

            'Seta Parametros - Quantidade
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "quantidade"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = dQuantidade

            'Executa Query
            dReturn = CDbl(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_valor_unitario", oSqlParameter))

            Return dReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadQuantidadeEstoque(ByVal lCodigoItem As Long, _
                                          ByVal sLote As String, _
                                          ByVal iCodigoDeposito As Integer) As Double

        Try

            'Variaveis Locais
            Dim oSqlParameter(3) As SqlParameter
            Dim dReturn As Double

            'Seta Parametros - Código Item
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_item"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoItem

            'Seta Parametros - Lote
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "lote"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 50
            oSqlParameter(1).Value = sLote

            'Seta Parametros - Código Depósito
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_deposito"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoDeposito

            'Seta Parametros - Código Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = goUsuario.iEmpresa

            'Executa Query
            dReturn = CDbl(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_item_saldo", oSqlParameter))

            Return dReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try


    End Function

#End Region

End Class
