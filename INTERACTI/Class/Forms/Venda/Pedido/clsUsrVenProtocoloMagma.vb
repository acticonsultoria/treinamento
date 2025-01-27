Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrVenProtocoloMagma

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroProtocolo As String
    Private sData As String
    Private sSemanaNF As String
    Private sCodigoRevendedor As String
    Private sNomeRevendedor As String
    Private iRota As Integer
    Private sGrupo As String
    Private sNotaFiscal As String
    Private sCodigoProduto As String
    Private sNomeProduto As String
    Private sQuantidade As String
    Private sMotivo As String
    Private sObservacao As String
    Private sRecebida As String
    Private sEnviadaFabrica As String
    Private sDistribuicao As String
    Private sPertenceDistribuicao As String
    Private sCancelada As String
    Private sFaturada As String
    Private sEntregue As String
    Private sMotivoCancelamento As String
    Private sLote As String
    Private iCodigoStatus As Integer
    Private lCodigoProtocolo As Long
    Private sNumeroPedido As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoProtocolo() As Long
        Get
            Return lCodigoProtocolo
        End Get
        Set(ByVal value As Long)
            lCodigoProtocolo = value
        End Set
    End Property

    Public Property NumeroProtocolo() As String
        Get
            Return sNumeroProtocolo
        End Get
        Set(ByVal value As String)
            sNumeroProtocolo = value
        End Set
    End Property

    Public Property Data() As String
        Get
            Return sData
        End Get
        Set(ByVal value As String)
            sData = value
        End Set
    End Property

    Public Property SemanaNF() As String
        Get
            Return sSemanaNF
        End Get
        Set(ByVal value As String)
            sSemanaNF = value
        End Set
    End Property

    Public Property CodigoRevendedor() As String
        Get
            Return sCodigoRevendedor
        End Get
        Set(ByVal value As String)
            sCodigoRevendedor = value
        End Set
    End Property

    Public Property NomeRevendedor() As String
        Get
            Return sNomeRevendedor
        End Get
        Set(ByVal value As String)
            sNomeRevendedor = value
        End Set
    End Property

    Public Property Rota() As Integer
        Get
            Return iRota
        End Get
        Set(ByVal value As Integer)
            iRota = value
        End Set
    End Property

    Public Property Grupo() As String
        Get
            Return sGrupo
        End Get
        Set(ByVal value As String)
            sGrupo = value
        End Set
    End Property

    Public Property NotaFiscal() As String
        Get
            Return sNotaFiscal
        End Get
        Set(ByVal value As String)
            sNotaFiscal = value
        End Set
    End Property

    Public Property CodigoProduto() As String
        Get
            Return sCodigoProduto
        End Get
        Set(ByVal value As String)
            sCodigoProduto = value
        End Set
    End Property

    Public Property NomeProduto() As String
        Get
            Return sNomeProduto
        End Get
        Set(ByVal value As String)
            sNomeProduto = value
        End Set
    End Property

    Public Property Quantidade() As String
        Get
            Return sQuantidade
        End Get
        Set(ByVal value As String)
            sQuantidade = value
        End Set
    End Property

    Public Property Motivo() As String
        Get
            Return sMotivo
        End Get
        Set(ByVal value As String)
            sMotivo = value
        End Set
    End Property

    Public Property Observacao() As String
        Get
            Return sObservacao
        End Get
        Set(ByVal value As String)
            sObservacao = value
        End Set
    End Property

    Public Property Recebida() As String
        Get
            Return sRecebida
        End Get
        Set(ByVal value As String)
            sRecebida = value
        End Set
    End Property

    Public Property EnviadaFabrica() As String
        Get
            Return sEnviadaFabrica
        End Get
        Set(ByVal value As String)
            sEnviadaFabrica = value
        End Set
    End Property

    Public Property Distribuicao() As String
        Get
            Return sDistribuicao
        End Get
        Set(ByVal value As String)
            sDistribuicao = value
        End Set
    End Property

    Public Property PertenceDistribuicao() As String
        Get
            Return sPertenceDistribuicao
        End Get
        Set(ByVal value As String)
            sPertenceDistribuicao = value
        End Set
    End Property

    Public Property Cancelada() As String
        Get
            Return sCancelada
        End Get
        Set(ByVal value As String)
            sCancelada = value
        End Set
    End Property

    Public Property Faturada() As String
        Get
            Return sFaturada
        End Get
        Set(ByVal value As String)
            sFaturada = value
        End Set
    End Property

    Public Property Entregue() As String
        Get
            Return sEntregue
        End Get
        Set(ByVal value As String)
            sEntregue = value
        End Set
    End Property

    Public Property MotivoCancelamento() As String
        Get
            Return sMotivoCancelamento
        End Get
        Set(ByVal value As String)
            sMotivoCancelamento = value
        End Set
    End Property

    Public Property CodigoStatus() As Integer
        Get
            Return iCodigoStatus
        End Get
        Set(ByVal value As Integer)
            iCodigoStatus = value
        End Set
    End Property

    Public Property Lote() As String
        Get
            Return sLote
        End Get
        Set(ByVal value As String)
            sLote = value
        End Set
    End Property

    Public Property NumeroPedido() As String
        Get
            Return sNumeroPedido
        End Get
        Set(ByVal value As String)
            sNumeroPedido = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function ValidarEstoque(ByVal sCodigo As String) As String

        'Variaveis Locais
        Dim sRetorno As String
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            sRetorno = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_ocorrencia_validar_estoque", oSqlParameter)

            Return sRetorno

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_ocorrencia", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Salvar(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oRow As GridEXRow
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow In oGrid.GetDataRows

                'Seta Váriavel 
                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_protocolo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("protocolo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "semana_nf"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = IIf(IsDBNull(oRow.Cells("semana_nf").Value) = True, DBNull.Value, oRow.Cells("semana_nf").Value) : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_revendedor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = IIf(IsDBNull(oRow.Cells("codigo_revendedor").Value) = True, DBNull.Value, oRow.Cells("codigo_revendedor").Value) : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_revendor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("revendedor").Value.ToString.Trim : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nota_fiscal"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("numero_nf").Value.ToString.Trim : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("codigo_produto").Value.ToString.Trim : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_produto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("produto").Value.ToString.Trim : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "quantidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("quantidade_ocorrencia").Value.ToString.Trim : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "motivo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("motivo_ocorrencia").Value.ToString.Trim : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "observacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("observacao").Value.ToString.Trim : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_status"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_status").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt

                'Executa Query  
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_ocorrencia", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(23) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_protocolo"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = sNumeroProtocolo

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.DateTime
            oSqlParameter(2).Value = sData

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "semana_nf"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sSemanaNF

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_revendedor"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sCodigoRevendedor

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "nome_revendor"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Value = sNomeRevendedor

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "nota_fiscal"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Value = sNotaFiscal

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_produto"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Value = sCodigoProduto

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "nome_produto"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Value = sNomeProduto

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "quantidade"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.VarChar
            oSqlParameter(9).Value = sQuantidade

            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "motivo"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.VarChar
            oSqlParameter(10).Value = sMotivo

            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "observacao"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.VarChar
            oSqlParameter(11).Value = sObservacao

            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "recebida"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.DateTime
            oSqlParameter(12).Value = IIf(sRecebida = "", DBNull.Value, sRecebida)

            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "enviada_fabrica"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.DateTime
            oSqlParameter(13).Value = IIf(sEnviadaFabrica = "", DBNull.Value, sEnviadaFabrica)

            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "distribuicao"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.DateTime
            oSqlParameter(14).Value = IIf(sDistribuicao = "", DBNull.Value, sDistribuicao)

            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "pertence_distribuicao"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.DateTime
            oSqlParameter(15).Value = IIf(sPertenceDistribuicao = "", DBNull.Value, sPertenceDistribuicao)

            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "cancelada"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.DateTime
            oSqlParameter(16).Value = IIf(sCancelada = "", DBNull.Value, sCancelada)

            oSqlParameter(17) = New SqlParameter
            oSqlParameter(17).ParameterName = "faturada"
            oSqlParameter(17).Direction = ParameterDirection.Input
            oSqlParameter(17).SqlDbType = SqlDbType.DateTime
            oSqlParameter(17).Value = IIf(sFaturada = "", DBNull.Value, sFaturada)

            oSqlParameter(18) = New SqlParameter
            oSqlParameter(18).ParameterName = "entregue"
            oSqlParameter(18).Direction = ParameterDirection.Input
            oSqlParameter(18).SqlDbType = SqlDbType.DateTime
            oSqlParameter(18).Value = IIf(sEntregue = "", DBNull.Value, sEntregue)

            oSqlParameter(19) = New SqlParameter
            oSqlParameter(19).ParameterName = "motivo_cancelamento"
            oSqlParameter(19).Direction = ParameterDirection.Input
            oSqlParameter(19).SqlDbType = SqlDbType.VarChar
            oSqlParameter(19).Value = IIf(sMotivoCancelamento = "", DBNull.Value, sMotivoCancelamento)

            oSqlParameter(20) = New SqlParameter
            oSqlParameter(20).ParameterName = "codigo_status"
            oSqlParameter(20).Direction = ParameterDirection.Input
            oSqlParameter(20).SqlDbType = SqlDbType.Int
            oSqlParameter(20).Value = iCodigoStatus

            oSqlParameter(21) = New SqlParameter
            oSqlParameter(21).ParameterName = "lote"
            oSqlParameter(21).Direction = ParameterDirection.Input
            oSqlParameter(21).SqlDbType = SqlDbType.VarChar
            oSqlParameter(21).Value = sLote

            oSqlParameter(22) = New SqlParameter
            oSqlParameter(22).ParameterName = "numero_pedido"
            oSqlParameter(22).Direction = ParameterDirection.Input
            oSqlParameter(22).SqlDbType = SqlDbType.VarChar
            oSqlParameter(22).Value = sNumeroPedido

            'Seta Parametros - Código
            oSqlParameter(23) = New SqlParameter
            oSqlParameter(23).ParameterName = "codigo"
            oSqlParameter(23).Direction = ParameterDirection.Input
            oSqlParameter(23).SqlDbType = SqlDbType.BigInt
            oSqlParameter(23).Value = lCodigoProtocolo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_ocorrencia", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal txtNumeroProtocolo As MaskedEditBox, _
                             ByVal dtpDataProtocolo As CalendarCombo, _
                             ByVal txtSemana As MaskedEditBox, _
                             ByVal txtCodigoRevendedor As MaskedEditBox, _
                             ByVal txtNomeRevendedor As MaskedEditBox, _
                             ByVal txtNotaFiscal As MaskedEditBox, _
                             ByVal txtCodigoProduto As MaskedEditBox, _
                             ByVal txtProduto As MaskedEditBox, _
                             ByVal txtQuantidade As MaskedEditBox, _
                             ByVal txtMotivo As MaskedEditBox, _
                             ByVal txtObservacao As MaskedEditBox, _
                             ByVal cboStatus As UIComboBox, _
                             ByVal dtpDataOcorrenciaRecebida As CalendarCombo, _
                             ByVal dtpDataOcorrenciaEnviadaFabrica As CalendarCombo, _
                             ByVal dtpDataOcorrenciaDistribuicao As CalendarCombo, _
                             ByVal dtpOcorrenciaPertenceDistribuicao As CalendarCombo, _
                             ByVal dtpOcorrenciaCancelada As CalendarCombo, _
                             ByVal txtMotivoCancelamento As MaskedEditBox, _
                             ByVal dtpDataOcorrenciaFaturada As CalendarCombo, _
                             ByVal dtpDataOcorrenciaEntregue As CalendarCombo, _
                             ByVal txtLote As MaskedEditBox, _
                             ByVal txtNumeroPedido As MaskedEditBox)

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
            oSqlParameter(i).Value = lCodigoProtocolo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_ocorrencia_dados", oSqlParameter)

            'Verifica se encontrou algum Registro
            If oSqlDataReader.HasRows Then

                'Seta Controles
                While oSqlDataReader.Read

                    txtNumeroProtocolo.Text = oSqlDataReader.Item("numero_protocolo")
                    dtpDataProtocolo.Value = oSqlDataReader.Item("data_ocorrencia")
                    txtSemana.Text = oSqlDataReader.Item("semana_nf")
                    txtCodigoRevendedor.Text = oSqlDataReader.Item("codigo_revendedor")
                    txtNomeRevendedor.Text = oSqlDataReader.Item("nome_revendedor")
                    txtNotaFiscal.Text = oSqlDataReader.Item("nota_fiscal")
                    txtCodigoProduto.Text = oSqlDataReader.Item("codigo_produto")
                    txtProduto.Text = oSqlDataReader.Item("nome_produto")
                    txtQuantidade.Text = oSqlDataReader.Item("quantidade")
                    txtMotivo.Text = oSqlDataReader.Item("motivo")
                    txtObservacao.Text = oSqlDataReader.Item("observacao")
                    dtpDataOcorrenciaRecebida.Value = oSqlDataReader.Item("data_recebida")
                    dtpDataOcorrenciaEnviadaFabrica.Value = oSqlDataReader.Item("data_enviada_fabrica")
                    dtpDataOcorrenciaDistribuicao.Value = oSqlDataReader.Item("data_distribuicao")
                    dtpOcorrenciaPertenceDistribuicao.Value = oSqlDataReader.Item("data_pertence_distribuicao")
                    dtpOcorrenciaCancelada.Value = oSqlDataReader.Item("data_cancelada")
                    dtpDataOcorrenciaFaturada.Value = oSqlDataReader.Item("data_faturada")
                    dtpDataOcorrenciaEntregue.Value = oSqlDataReader.Item("data_entregue")
                    cboStatus.SelectedValue = oSqlDataReader.Item("status")
                    txtLote.Text = oSqlDataReader.Item("lote")
                    txtMotivoCancelamento.Text = oSqlDataReader.Item("motivo_cancelamento")
                    txtNumeroPedido.Text = oSqlDataReader.Item("numero_pedido")

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

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroProtocolo As String, _
                        ByVal sDataOcorrenciaInicio As String, _
                        ByVal sDataOcorrenciaTermino As String, _
                        ByVal sProduto As String, _
                        ByVal sNotaFiscal As String, _
                        ByVal sRevendedor As String, _
                        ByVal sStatus As String, _
                        ByVal sSemana As String, _
                        ByVal sLote As String, _
                        ByVal sNumeroPedido As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroProtocolo = "", DBNull.Value, sNumeroProtocolo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataOcorrenciaInicio = "", DBNull.Value, sDataOcorrenciaInicio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataOcorrenciaTermino = "", DBNull.Value, sDataOcorrenciaTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sProduto = "", DBNull.Value, sProduto) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNotaFiscal = "", DBNull.Value, sNotaFiscal) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sRevendedor = "", DBNull.Value, sRevendedor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatus : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroPedido = "", DBNull.Value, sNumeroPedido) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "semana"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sSemana = "", DBNull.Value, sSemana)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_ocorrencia", oSqlParameter)

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
    Public Sub LoadGridRelatorioTempo(ByVal oGrid As GridEX, _
                                       ByVal sNumeroProtocolo As String, _
                                       ByVal sDataOcorrenciaInicio As String, _
                                       ByVal sDataOcorrenciaTermino As String, _
                                       ByVal sProduto As String, _
                                       ByVal sNotaFiscal As String, _
                                       ByVal sRevendedor As String, _
                                       ByVal sStatus As String, _
                                       ByVal sSemana As String, _
                                       ByVal sLote As String, _
                                       ByVal sNumeroPedido As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroProtocolo = "", DBNull.Value, sNumeroProtocolo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataOcorrenciaInicio = "", DBNull.Value, sDataOcorrenciaInicio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataOcorrenciaTermino = "", DBNull.Value, sDataOcorrenciaTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sProduto = "", DBNull.Value, sProduto) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNotaFiscal = "", DBNull.Value, sNotaFiscal) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sRevendedor = "", DBNull.Value, sRevendedor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatus : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroPedido = "", DBNull.Value, sNumeroPedido) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "semana"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sSemana = "", DBNull.Value, sSemana)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_ocorrencia_relatorio_tempo", oSqlParameter)

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

    Public Sub AtualizarStatus(ByVal iStatus As Integer, _
                             ByVal sEnviadaFabrica As String, _
                             ByVal sDistribuicao As String, _
                             ByVal sPertenceDistribuicao As String, _
                             ByVal sFaturada As String, _
                             ByVal sEntregue As String)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.varchar
                oSqlParameter(i).Value = sNumeroPedido : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "enviada_fabrica"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = IIf(sEnviadaFabrica = "", DBNull.Value, sEnviadaFabrica) : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "distribuicao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = IIf(sDistribuicao = "", DBNull.Value, sDistribuicao) : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "faturada"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = IIf(sFaturada = "", DBNull.Value, sFaturada) : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entregue"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = IIf(sEntregue = "", DBNull.Value, sEntregue) : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "pertence_distribuicao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = IIf(sPertenceDistribuicao = "", DBNull.Value, sPertenceDistribuicao) : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_status"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iStatus

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_ocorrencia_status", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarNFe(ByVal sCodigo As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código usuario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Host name
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = System.Net.Dns.GetHostName


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_venda_ocorrencia", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarNFeEstoque(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código usuario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Host name
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = System.Net.Dns.GetHostName


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_venda_ocorrencia_estoque", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidacaoGerarNFe(ByVal sCodigo As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer
        Dim sReturn As String = ""

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1




            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_venda_ocorrencia", oSqlParameter)

            If sReturn <> "" Then

                MsgBox(sReturn, MsgBoxStyle.Exclamation, "Validação")
                ValidacaoGerarNFe = False

            Else
            ValidacaoGerarNFe = True
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidacaoGerarNFeEstoque(ByVal iCodigo As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer
        Dim sReturn As String = ""

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1




            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_venda_ocorrencia_estoque", oSqlParameter)

            If sReturn = "EXISTE ESSE PRODUTO NO ESTOQUE" Then
                ValidacaoGerarNFeEstoque = True
            Else
                If sReturn <> "" Then
                    MsgBox(sReturn, MsgBoxStyle.Exclamation, "Validação")
                    ValidacaoGerarNFeEstoque = False
                Else
                    MsgBox("ESSE PRODUTO NÃO SE ENCONTRA EM ESTOQUE", MsgBoxStyle.Exclamation, "Validação")
                    ValidacaoGerarNFeEstoque = False
                End If
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub InserirLote(ByVal sLote As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "lote"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = sLote : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_ocorrencia_lote", oSqlParameter)

            

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InserirPedido(ByVal sPedido As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = spedido : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_ocorrencia_pedido", oSqlParameter)

            
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CancelarOcorrencia(ByVal sMotivoCancelar As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "motivo_cancelamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = sMotivoCancelar : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_ocorrencia_cancelar", oSqlParameter)

             

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridOcorrenciaEntrada(ByVal oGrid As GridEX, _
                                         ByVal sNumeroPedido As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroPedido : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_ocorrencia_vinculo", oSqlParameter)

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

    Public Sub LoadGridNotaFiscalEntrada(ByVal oGrid As GridEX, _
                                       ByVal sNumeroPedido As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroPedido : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_ocorrencia_nota_fiscal_vinculo", oSqlParameter)

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

    Public Sub LoadGridNotaFiscalVinculo(ByVal oGrid As GridEX, _
                                         ByVal sNumeroPedido As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroPedido : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_ocorrencia_vinculo_nota_fiscal", oSqlParameter)

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

    Public Sub UpdateVinculoNF(ByVal lCodigoOcorrencia As Long, _
                               ByVal sCodigoEntradaCapa As String, _
                               ByVal iQuantidade As Integer)

        'Variaveis Locais
        Dim oSqlParameter(23) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_ocorrencia"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoOcorrencia

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_entrada_capa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.varchar
            oSqlParameter(2).Value = sCodigoEntradaCapa

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "quantidade"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iquantidade


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_ocorrencia_nota_fiscal_vinculo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVinculoNF(ByVal lCodigoOcorrencia As Long, _
                               ByVal lCodigoEntradaCapa As Long, _
                               ByVal lCodigoEntradaItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(23) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_ocorrencia"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoOcorrencia

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_entrada_capa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = lCodigoEntradaCapa

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_entrada_item"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = lCodigoEntradaItem


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_ocorrencia_nota_fiscal_vinculo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridLista(ByVal oGrid As GridEX, _
                        ByVal sCodigoConsultor As String, _
                        ByVal sNomeConsultor As String, _
                        ByVal sSetor As String, _
                        ByVal sConsulta As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_consultor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCodigoConsultor = "", DBNull.Value, sCodigoConsultor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_consultor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNomeConsultor = "", DBNull.Value, sNomeConsultor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "setor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sSetor = "", DBNull.Value, sSetor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consulta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sConsulta 

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_comercial_ocorrencia_lista_negra", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

