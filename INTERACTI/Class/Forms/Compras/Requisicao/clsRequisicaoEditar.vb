Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsRequisicaoEditar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sComplemento As String
    Private sMarca As String
    Private dQuantidade As Double
    Private iUnidadeMedida As Integer
    Private dLoteMinimo As Double
    Private sDataNecessidade As String
    Private sJustificativa As String
    Private lCodigo As Long
    Private iUtilizacaoItem As Integer

#End Region

#Region "::: PROPERTIE :::"
    Public Property UtilizacaoItem() As Integer
        Get
            Return iUtilizacaoItem
        End Get
        Set(ByVal value As Integer)
            iUtilizacaoItem = value
        End Set
    End Property
    Public Property Complemento() As String
        Get
            Return sComplemento
        End Get
        Set(ByVal value As String)
            sComplemento = value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return sMarca
        End Get
        Set(ByVal value As String)
            sMarca = value
        End Set
    End Property

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property UnidadeMedida() As Integer
        Get
            Return iUnidadeMedida
        End Get
        Set(ByVal value As Integer)
            iUnidadeMedida = value
        End Set
    End Property

    Public Property LoteMinimo() As Double
        Get
            Return dLoteMinimo
        End Get
        Set(ByVal value As Double)
            dLoteMinimo = value
        End Set
    End Property

    Public Property DataNecessidade() As String
        Get
            Return sDataNecessidade
        End Get
        Set(ByVal value As String)
            sDataNecessidade = value
        End Set
    End Property

    Public Property Justificativa() As String
        Get
            Return sJustificativa
        End Get
        Set(ByVal value As String)
            sJustificativa = value
        End Set
    End Property

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadRequisicao(ByVal lCodigo As Long, _
                              ByVal txtNumeroRequisicao As EditBox, _
                              ByVal txtTipoRequisicao As EditBox, _
                              ByVal txtCentroCusto As EditBox, _
                              ByVal txtAprovador As EditBox, _
                              ByVal txtGrupoItem As EditBox, _
                              ByVal txtItem As EditBox, _
                              ByVal txtUtilizacao As EditBox, _
                              ByVal txtComplemento As EditBox, _
                              ByVal txtMarca As EditBox, _
                              ByVal txtQuantidade As NumericEditBox, _
                              ByVal cboUnidadeMedida As UIComboBox, _
                              ByVal txtLoteMinimo As NumericEditBox, _
                              ByVal txtDataLeadTime As EditBox, _
                              ByVal dtpDataNecessidade As DateTimePicker, _
                              ByVal txtJustificativa As EditBox, _
                              ByVal lblGrupoItem As Label, _
                              ByVal lblItem As Label)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            'Seta Parametros - Complemento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_dados_requisicao", oSqlParameter)

            If oSqlDataReader.Read Then

                'Carrega Controles
                txtNumeroRequisicao.Text = "RQ" & Format(oSqlDataReader.Item("numero_requisicao"), "000000")
                txtNumeroRequisicao.Tag = lCodigo
                txtTipoRequisicao.Text = oSqlDataReader.Item("tipo_requisicao")
                txtTipoRequisicao.Tag = oSqlDataReader.Item("codigo_tipo_item")
                txtCentroCusto.Text = oSqlDataReader.Item("centro_custo")
                txtAprovador.Text = oSqlDataReader.Item("aprovador")
                txtGrupoItem.Text = oSqlDataReader.Item("grupo_item")
                txtItem.Text = oSqlDataReader.Item("item")
                txtItem.Tag = oSqlDataReader.Item("codigo_item")
                txtUtilizacao.Text = oSqlDataReader.Item("utilizacao")
                txtComplemento.Text = oSqlDataReader.Item("complemento")
                txtMarca.Text = oSqlDataReader.Item("marca")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade_requisicao")
                cboUnidadeMedida.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida")
                txtLoteMinimo.Value = oSqlDataReader.Item("lote_minimo")
                txtDataLeadTime.Text = Format(oSqlDataReader.Item("data_lead_time"), "dd/MM/yyyy")
                If IsDBNull(oSqlDataReader.Item("data_necessidade")) = False Then
                    dtpDataNecessidade.Value = Format(oSqlDataReader.Item("data_necessidade"), "dd/MM/yyyy")
                    dtpDataNecessidade.Checked = True
                Else
                    dtpDataNecessidade.Value = Format(Now.Date, "dd/MM/yyyy")
                    dtpDataNecessidade.Checked = False
                End If
                txtJustificativa.Text = oSqlDataReader.Item("justificativa")

                'Caso o Tipo do Item seja Serviço
                If oSqlDataReader.Item("codigo_tipo_item") = TipoItem.Servico Then
                    txtMarca.Text = "" : txtMarca.Enabled = False
                    lblGrupoItem.Text = "Grupo de Serviços:"
                    lblItem.Text = "Serviço:"
                Else
                    txtMarca.Enabled = True
                    lblGrupoItem.Text = "Grupo de Itens:"
                    lblItem.Text = "Item:"
                End If

            End If

            'Fecha Data Reader
            oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadRequisicao2(ByVal lCodigo As Long, _
                             ByVal txtNumeroRequisicao As EditBox, _
                             ByVal txtTipoRequisicao As EditBox, _
                             ByVal txtCentroCusto As EditBox, _
                             ByVal txtAprovador As EditBox, _
                             ByVal txtGrupoItem As EditBox, _
                             ByVal txtItem As EditBox, _
                             ByVal txtContaContabil As EditBox, _
                             ByVal cboUtilizacaoItem As UIComboBox, _
                             ByVal txtComplemento As EditBox, _
                             ByVal txtMarca As EditBox, _
                             ByVal txtQuantidade As NumericEditBox, _
                             ByVal cboUnidadeMedida As UIComboBox, _
                             ByVal txtLoteMinimo As NumericEditBox, _
                             ByVal txtDataLeadTime As EditBox, _
                             ByVal dtpDataNecessidade As DateTimePicker, _
                             ByVal txtJustificativa As EditBox, _
                             ByVal lblGrupoItem As Label, _
                             ByVal lblItem As Label)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            'Seta Parametros - Complemento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_dados_requisicao", oSqlParameter)

            If oSqlDataReader.Read Then

                Call LoadCombo(cboUtilizacaoItem, "sp_select_combo_cadastro_basico_utilizacao_item " & oSqlDataReader.Item("codigo_item"))
                cboUtilizacaoItem.Text = ""
                'Carrega Controles
                txtNumeroRequisicao.Text = "RQ" & Format(oSqlDataReader.Item("numero_requisicao"), "000000")
                txtNumeroRequisicao.Tag = lCodigo
                txtTipoRequisicao.Text = oSqlDataReader.Item("tipo_requisicao")
                txtTipoRequisicao.Tag = oSqlDataReader.Item("codigo_tipo_item")
                txtCentroCusto.Text = oSqlDataReader.Item("centro_custo")
                txtAprovador.Text = oSqlDataReader.Item("aprovador")
                txtGrupoItem.Text = oSqlDataReader.Item("grupo_item")
                txtItem.Text = oSqlDataReader.Item("item")
                txtContaContabil.Text = oSqlDataReader.Item("conta_contabil")
                txtItem.Tag = oSqlDataReader.Item("codigo_item")
                cboUtilizacaoItem.Text = oSqlDataReader.Item("utilizacao")
                txtComplemento.Text = oSqlDataReader.Item("complemento")
                txtMarca.Text = oSqlDataReader.Item("marca")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade_requisicao")
                cboUnidadeMedida.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida")
                txtLoteMinimo.Value = oSqlDataReader.Item("lote_minimo")
                txtDataLeadTime.Text = Format(oSqlDataReader.Item("data_lead_time"), "dd/MM/yyyy")
                If IsDBNull(oSqlDataReader.Item("data_necessidade")) = False Then
                    dtpDataNecessidade.Value = Format(oSqlDataReader.Item("data_necessidade"), "dd/MM/yyyy")
                    dtpDataNecessidade.Checked = True
                Else
                    dtpDataNecessidade.Value = Format(Now.Date, "dd/MM/yyyy")
                    dtpDataNecessidade.Checked = False
                End If
                txtJustificativa.Text = oSqlDataReader.Item("justificativa")

                'Caso o Tipo do Item seja Serviço
                If oSqlDataReader.Item("codigo_tipo_item") = TipoItem.Servico Then
                    txtMarca.Text = "" : txtMarca.Enabled = False
                    lblGrupoItem.Text = "Grupo de Serviços:"
                    lblItem.Text = "Serviço:"
                Else
                    txtMarca.Enabled = True
                    lblGrupoItem.Text = "Grupo de Itens:"
                    lblItem.Text = "Item:"
                End If

            End If

            'Fecha Data Reader
            oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter

        Try

            'Seta Parametros - Complemento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "complemento"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 100
            oSqlParameter(0).Value = sComplemento

            'Seta Parametros - Marca
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "marca"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 50
            oSqlParameter(1).Value = sMarca

            'Seta Parametros - Quantidade Requisição
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "quantidade_requisicao"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dQuantidade

            'Seta Parametros - Unidade de Medida
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_unidade_medida"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = IIf(iUnidadeMedida = -1, DBNull.Value, iUnidadeMedida)

            'Seta Parametros - Lote Mínimo
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "lote_minimo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Float
            oSqlParameter(4).Value = dLoteMinimo

            'Seta Parametros - Data Necessidade
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_necessidade"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Date
            If sDataNecessidade = "" Then
                oSqlParameter(5).Value = DBNull.Value
            Else
                oSqlParameter(5).Value = CDate(sDataNecessidade)
            End If

            'Seta Parametros - Código Usuário
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_usuario"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = goUsuario.iUsuario

            'Seta Parametros - Justificativa
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "justificativa"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Text
            oSqlParameter(7).Value = sJustificativa

            'Seta Parametros - Código
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.BigInt
            oSqlParameter(8).Value = lCodigo

            'Seta Parametros - Código Utilização Item
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo_utilizacao_item"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Int
            oSqlParameter(9).Value = iUtilizacaoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_requisicao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
