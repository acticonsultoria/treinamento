Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinFluxoCaixa

#Region "::: VARIAVEIS :::"

    Private iContaBancaria As Integer
    Private iTipoDocumentoPagamento As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property ContaBancaria() As Integer
        Get
            Return iContaBancaria
        End Get
        Set(ByVal value As Integer)
            iContaBancaria = value
        End Set
    End Property

    Public Property TipoDocumentoPagamento() As Integer
        Get
            Return iTipoDocumentoPagamento
        End Get
        Set(ByVal value As Integer)
            iTipoDocumentoPagamento = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: FLUXO DE CAIXA :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal oGridMensal As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iCodigoContaBancaria As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_fluxo_caixa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)
            Call ConfigurarDataMemberGrid(oGridMensal)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("data"), oDataSet.Tables(1).Columns("data"))

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

            oGridMensal.DataSource = oDataSet.DefaultViewManager
            oGridMensal.DataMember = oDataSet.Tables(2).TableName : oGridMensal.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PAGAMENTO :::"

    Public Sub LoadDadosChequeTerceiro(ByVal lCodigo As Long, _
                                       ByVal lCodigoReceitaCapa As Long, _
                                       ByVal txtBanco As MaskedEditBox, _
                                       ByVal txtAgencia As MaskedEditBox, _
                                       ByVal txtConta As MaskedEditBox, _
                                       ByVal txtRecebidoEm As MaskedEditBox, _
                                       ByVal txtDataPreDatado As MaskedEditBox, _
                                       ByVal txtValor As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Receita Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_receita_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoReceitaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_receita_dados_pagamento", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Seta Valores da Célula
                    txtBanco.Text = oSqlDataReader.Item("banco")
                    txtAgencia.Text = oSqlDataReader.Item("agencia_cheque")
                    txtConta.Text = oSqlDataReader.Item("conta_cheque")
                    txtRecebidoEm.Text = oSqlDataReader.Item("data_pagamento")
                    txtDataPreDatado.Text = IIf(IsDBNull(oSqlDataReader.Item("data_pre_datado")), "", oSqlDataReader.Item("data_pre_datado"))
                    txtValor.Value = oSqlDataReader.Item("valor")

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateParcela(ByVal oGrid As GridEX, _
                             ByVal iTipo As Integer)

        'Variaveis Locais
        Dim i, j As Integer
        Dim oRow() As GridEXRow
        Dim oSqlParameter(8) As SqlParameter

        Try

            oRow = oGrid.GetDataRows

            For j = 0 To UBound(oRow)

                i = 0

                'Seta Parametros - Código Despesa Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow(j).Cells("codigo_titulo_capa").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow(j).Cells("numero_parcela").Value : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow(j).Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor Pago
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_pago"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow(j).Cells("valor_pago").Value : i += 1

                'Seta Parametros - Valor Devido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_devido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow(j).Cells("valor_devido").Value : i += 1

                'Seta Parametros - Desconto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "desconto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow(j).Cells("desconto").Value : i += 1

                'Seta Parametros - Juros
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "juros"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow(j).Cells("juros").Value : i += 1

                'Seta Parametros - Tipo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iTipo

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_parcela", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPagamento(ByVal grdParcela As GridEX, _
                               ByVal grdPagamento As GridEX)

        'Variaveis Locais
        Dim i, j, k As Integer
        Dim dValorParcela As Double
        Dim dValorPagamento As Double
        Dim oRowParcela() As GridEXRow = grdParcela.GetDataRows
        Dim oRowPagamento() As GridEXRow = grdPagamento.GetDataRows
        Dim oSqlParameter(16) As SqlParameter

        Try

            For j = 0 To UBound(oRowParcela)

                dValorParcela = oRowParcela(j).Cells("valor_pago").Value

                For k = 0 To UBound(oRowPagamento)

                    dValorPagamento = (oRowPagamento(k).Cells("valor").Value - oRowPagamento(k).Cells("valor_associado").Value)

                    If dValorPagamento > 0 Then

                        i = 0

                        'Seta Parametros - Código Despesa Capa
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                        oSqlParameter(i).Value = oRowParcela(j).Cells("codigo_titulo_capa").Value : i += 1

                        'Seta Parametros - Código Empresa
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_empresa"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                        'Seta Parametros - Número Parcela
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "numero_parcela"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                        oSqlParameter(i).Value = oRowParcela(j).Cells("numero_parcela").Value : i += 1

                        'Seta Parametros - Código Banco Conta
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_banco_conta"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Int
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("codigo_banco_conta").Value : i += 1

                        'Seta Parametros - Código Tipo Documento Pagamento
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("codigo_tipo_documento_pagamento").Value : i += 1

                        'Seta Parametros - Número do Documento
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "numero_documento"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 100
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("numero_documento").Value : i += 1

                        'Seta Parametros - Data Pagamento
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "data_pagamento"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("data_pagamento").Value : i += 1

                        'Seta Parametros - Valor
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "valor"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Float
                        oSqlParameter(i).Value = IIf(dValorParcela > dValorPagamento, dValorPagamento, dValorParcela) : i += 1

                        'Seta Parametros - Banco
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "banco"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 100
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("banco").Value : i += 1

                        'Seta Parametros - Favorecido
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "favorecido"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 100
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("favorecido").Value : i += 1

                        'Seta Parametros - Pré Datado
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "pre_datado"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Bit
                        If IsDBNull(oRowPagamento(k).Cells("pre_datado").Value) Then
                            oSqlParameter(i).Value = DBNull.Value : i += 1
                        Else
                            oSqlParameter(i).Value = IIf(oRowPagamento(k).Cells("pre_datado").Value = "1", True, False) : i += 1
                        End If

                        'Seta Parametros - Data Pré Datado
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "data_pre_datado"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("data_pre_datado").Value : i += 1

                        'Seta Parametros - Código Titulo Capa Receita
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_titulo_capa_receita"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("codigo_titulo_capa_receita").Value : i += 1

                        'Seta Parametros - Código Título Parcela Pagamento Receita
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento_receita"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("codigo_titulo_parcela_pagamento_receita").Value : i += 1

                        'Seta Parametros - Numero Parcela Receita
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "numero_parcela_receita"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("numero_parcela_receita").Value : i += 1

                        'Seta Parametros - Status
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "status"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento(k).Cells("status").Value : i += 1

                        'Seta Parametros - Código Usuário
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_usuario"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Int
                        oSqlParameter(i).Value = goUsuario.iUsuario

                        'Executa Query
                        ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_pagamento", oSqlParameter)

                        grdPagamento.Row = oRowPagamento(k).RowIndex
                        'Seta Valor
                        grdPagamento.SetValue("valor_associado", grdPagamento.GetValue("valor_associado") + IIf(dValorParcela > dValorPagamento, dValorPagamento, dValorParcela))
                        dValorParcela -= IIf(dValorParcela > dValorPagamento, dValorPagamento, dValorParcela)

                        If dValorParcela = 0 Then Exit For

                    End If

                Next

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateParcelaIndividual(ByVal lCodigoTituloCapa As Long, _
                                       ByVal iNumeroParcela As Integer, _
                                       ByVal sDataVencimento As String, _
                                       ByVal dValorPago As Double, _
                                       ByVal dValorDevido As Double, _
                                       ByVal dDesconto As Double, _
                                       ByVal dJuros As Double, _
                                       ByVal iTipo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Despesa Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataVencimento : i += 1

            'Seta Parametros - Valor Pago
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pago"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPago : i += 1

            'Seta Parametros - Valor Devido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_devido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDevido : i += 1

            'Seta Parametros - Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float : i += 1
            oSqlParameter(i).Value = dDesconto

            'Seta Parametros - Juros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dJuros : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_parcela", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPagamentoIndividual(ByVal lCodigoTituloCapa As Long, _
                                         ByVal iNumeroParcela As Integer, _
                                         ByVal grdPagamento As GridEX)

        'Variaveis Locais
        Dim i, j As Integer
        Dim oRowPagamento() As GridEXRow = grdPagamento.GetDataRows
        Dim oSqlParameter(16) As SqlParameter

        Try

            For j = 0 To UBound(oRowPagamento)

                i = 0

                'Seta Parametros - Código Despesa Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iNumeroParcela : i += 1

                'Seta Parametros - Código Banco Conta
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_banco_conta"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRowPagamento(j).Cells("codigo_banco_conta").Value : i += 1

                'Seta Parametros - Código Tipo Documento Pagamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRowPagamento(j).Cells("codigo_tipo_documento_pagamento").Value : i += 1

                'Seta Parametros - Número do Documento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRowPagamento(j).Cells("numero_documento").Value : i += 1

                'Seta Parametros - Data Pagamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_pagamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRowPagamento(j).Cells("data_pagamento").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRowPagamento(j).Cells("valor").Value : i += 1

                'Seta Parametros - Banco
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "banco"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRowPagamento(j).Cells("banco").Value : i += 1

                'Seta Parametros - Favorecido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "favorecido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRowPagamento(j).Cells("favorecido").Value : i += 1

                'Seta Parametros - Pré Datado
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "pre_datado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                If IsDBNull(oRowPagamento(j).Cells("pre_datado").Value) Then
                    oSqlParameter(i).Value = DBNull.Value : i += 1
                Else
                    oSqlParameter(i).Value = IIf(oRowPagamento(j).Cells("pre_datado").Value = "1", True, False) : i += 1
                End If

                'Seta Parametros - Data Pré Datado
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_pre_datado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRowPagamento(j).Cells("data_pre_datado").Value : i += 1

                'Seta Parametros - Código Titulo Capa Receita
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa_receita"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRowPagamento(j).Cells("codigo_titulo_capa_receita").Value : i += 1

                'Seta Parametros - Código Título Parcela Pagamento Receita
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento_receita"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRowPagamento(j).Cells("codigo_titulo_parcela_pagamento_receita").Value : i += 1

                'Seta Parametros - Numero Parcela Receita
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela_receita"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRowPagamento(j).Cells("numero_parcela_receita").Value : i += 1

                'Seta Parametros - Status
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRowPagamento(j).Cells("status").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_pagamento", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FLUXO FINANCEIRO - PEDIDO DE COMPRA :::"

    Public Sub LoadGridFluxoFinanceiroAprovacaoPedidoCompra(ByVal oGrid As GridEX, _
                                                            ByVal lCodigoCotacao As Long, _
                                                            ByVal iCodigoCotacaoFornecedor As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_fluxo_financeiro_aprovacao_pedido_compra", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
