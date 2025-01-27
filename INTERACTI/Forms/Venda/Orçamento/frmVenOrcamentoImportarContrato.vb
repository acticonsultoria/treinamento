Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmVenOrcamentoImportarContrato

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private lCodigoOrcamento As Long
    Private iCodigoOrcamentoItem As Integer
    Private iFormulario As Integer
    Private iCodigoContrato As Integer
    Private bSucesso As Boolean = False

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoOrcamento() As Long
        Get
            Return lCodigoOrcamento
        End Get
        Set(ByVal value As Long)
            lCodigoOrcamento = value
        End Set
    End Property

    Public Property CodigoOrcamentoItem() As Integer
        Get
            Return iCodigoOrcamentoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoOrcamentoItem = value
        End Set
    End Property

    Public Property Formulario() As Integer
        Get
            Return iFormulario
        End Get
        Set(ByVal value As Integer)
            iFormulario = value
        End Set
    End Property

    Public Property CodigoContrato() As Integer
        Get
            Return iCodigoContrato
        End Get
        Set(ByVal value As Integer)
            iCodigoContrato = value
        End Set
    End Property

    Public Property Sucesso() As Boolean
        Get
            Return bSucesso
        End Get
        Set(ByVal value As Boolean)
            bSucesso = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            If Validacao() = False Then Exit Sub

            ImportarProcessoProdutivo()
            ImportarServicoTerceiros()

            bSucesso = True

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            ConfiguraGrid(grdProcessoProdutivoContrato, iFormulario)
            ConfiguraGrid(grdServicoTerceirosContrato, iFormulario)

            LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadGridContratoImportacao(grdProcessoProdutivoContrato, _
                                                                 grdServicoTerceirosContrato, _
                                                                 iCodigoContrato)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarProcessoProdutivo()

        Try

            If grdProcessoProdutivoContrato.GetCheckedRows.Count > 0 Then

                Dim i As Integer = LoadCodigo("sp_validate_venda_orcamento_item_grupo_contrato " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa & ", 3")

                If i > 0 Then
                    If MsgBox("Já existe um grupo de processo produtivo vinculado a um contrato para esse item. Os dados do grupo anterior serão sobrescritos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If

                Dim iCodigoOrcamentoItemGrupo As Integer

                oClsUsrVenOrcamentoLegado.InsertGrupoContrato(lCodigoOrcamento, _
                                                              iCodigoOrcamentoItem, _
                                                              iCodigoOrcamentoItemGrupo, _
                                                              3)

                For Each oRow As GridEXRow In grdProcessoProdutivoContrato.GetCheckedRows

                    oClsUsrVenOrcamentoLegado.InsertProcessoProdutivoContrato(lCodigoOrcamento, _
                                                                              iCodigoOrcamentoItem, _
                                                                              iCodigoOrcamentoItemGrupo, _
                                                                              iCodigoContrato, _
                                                                              oRow.Cells("codigo").Value, _
                                                                              oRow.Cells("horas_importacao").Value)

                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub ImportarServicoTerceiros()

        Try

            If grdServicoTerceirosContrato.GetCheckedRows.Count > 0 Then

                Dim i As Integer = LoadCodigo("sp_validate_venda_orcamento_item_grupo_contrato " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa & ", 4")

                If i > 0 Then
                    If MsgBox("Já existe um grupo de serviço de terceiros vinculado a um contrato para esse item. Os dados do grupo anterior serão sobrescritos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If

                Dim iCodigoOrcamentoItemGrupo As Integer

                oClsUsrVenOrcamentoLegado.InsertGrupoContrato(lCodigoOrcamento, _
                                                              iCodigoOrcamentoItem, _
                                                              iCodigoOrcamentoItemGrupo, _
                                                              4)

                For Each oRow As GridEXRow In grdServicoTerceirosContrato.GetCheckedRows

                    oClsUsrVenOrcamentoLegado.InsertServicoTerceirosContrato(lCodigoOrcamento, _
                                                                             iCodigoOrcamentoItem, _
                                                                             iCodigoOrcamentoItemGrupo, _
                                                                             iCodigoContrato, _
                                                                             oRow.Cells("codigo").Value)

                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If grdProcessoProdutivoContrato.GetDataRows.Count <= 0 And grdServicoTerceirosContrato.GetDataRows.Count <= 0 Then
                MsgBox("Selecione algum registro!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            For Each oRow As GridEXRow In grdProcessoProdutivoContrato.GetCheckedRows

                If oRow.Cells("horas_importacao").Value <= 0 Then
                    MsgBox("Digite uma quantidade de horas para a operação " & oRow.Cells("operacao").Value, MsgBoxStyle.Exclamation, "Validação")
                    Return False
                End If

                If oRow.Cells("horas_importacao").Value > oRow.Cells("horas_disponiveis").Value Then
                    MsgBox("A quantidade de horas está excedendo as horas disponíveis para a operação " & oRow.Cells("operacao").Value, MsgBoxStyle.Exclamation, "Validação")
                    Return False
                End If

            Next

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class