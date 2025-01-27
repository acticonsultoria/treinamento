Imports Janus.Windows.GridEX

Public Class frmFatEmissaoMDFeDocumentos

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmFatEmissaoMDFeUnidadeTransporte As New clsFrmFatEmissaoMDFeUnidadeTransporte
    Private lCodigoEmissaoCapa As Long
    Private sChaveAcesso As String
    Private iTipo As Integer
    Private sUF As String
    Private iCodigoMunicipio As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return iTipo
        End Get
        Set(ByVal value As Integer)
            iTipo = value
        End Set
    End Property

    Public Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
    End Property

    Public Property UF() As String
        Get
            Return sUF
        End Get
        Set(ByVal value As String)
            sUF = value
        End Set
    End Property

    Public Property CodigoMunicipio() As Integer
        Get
            Return iCodigoMunicipio
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipio = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmFatEmissaoMDFeUnidadeTransporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoMDFeUnidadeTransporte_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFatEmissaoMDFeUnidadeTransporte_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: UNIDADE TRANSPORTE :::"

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserirNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirUnidadeCarga.Click
        Try

            If ValidaCampo(cboChaveAcesso, lblChaveAcesso) = False Then
                Exit Sub
            End If

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoMDFeUnidadeCarga

            oForm.CodigoEmissaoCapa = lCodigoEmissaoCapa
            oForm.ChaveAcesso = cboChaveAcesso.SelectedValue
            oForm.Tipo = iTipo

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'carrega grid
            Call oClsFrmFatEmissaoMDFeUnidadeTransporte.LoadGridNotaFiscalDocumentos(grdUnidadeCarga, _
                                                                                     lCodigoEmissaoCapa, _
                                                                                     iTipo, _
                                                                                     cboChaveAcesso.SelectedValue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnExcelGridUnidadeCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridUnidadeCarga.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdUnidadeCarga)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridUnidadeCarga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgruparGridUnidadeCarga.Click
        Try

            'Verifica se o Grupo está Habilitado
            If grdUnidadeCarga.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdUnidadeCarga.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdUnidadeCarga.GroupByBoxVisible = True
                grdUnidadeCarga.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGridUnidadeCarga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfigurarGridUnidadeCarga.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdUnidadeCarga
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdUnidadeCarga, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdUnidadeCarga_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdUnidadeCarga.ColumnMoved
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdUnidadeCarga, _
                                     Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdUnidadeCarga_GroupsChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GroupsChangingEventArgs) Handles grdUnidadeCarga.GroupsChanging
        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdUnidadeCarga.Name, _
                                          Formulario.FaturamentoEmissaoMDFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdUnidadeCarga_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdUnidadeCarga.RowDoubleClick
        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdUnidadeCarga.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdUnidadeCarga.CurrentColumn.Key

                Case "editar" : Call EditarUnidadeCarga()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdUnidadeCarga_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdUnidadeCarga.SizingColumn
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdUnidadeCarga.Name, _
                                     Formulario.FaturamentoEmissaoMDFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirUnidadeCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirUnidadeCarga.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Produto
            Call ExcluirUnidadeCarga()

            'Preapara Formulário para Inserção de um Novo Produto
            'Call NovoCondutor()

            'carrega a grid
            Call oClsFrmFatEmissaoMDFeUnidadeTransporte.LoadGridNotaFiscalDocumentos(grdUnidadeCarga, _
                                                                                     lCodigoEmissaoCapa, _
                                                                                     iTipo, _
                                                                                     cboChaveAcesso.SelectedValue)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call SalvarDocumentosNota()

                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoMDFeUnidadeTransporte_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboTipo, "sp_select_combo_static_tipo_unidade_transporte_mdfe")
            Call LoadCombo(cboChaveAcesso, "sp_select_combo_faturamento_emissao_mdfe_chave_acesso " & goUsuario.iEmpresa, False)

            'carrega grid
            Call oClsFrmFatEmissaoMDFeUnidadeTransporte.LoadGridNotaFiscalDocumentos(grdUnidadeCarga, _
                                                                                     lCodigoEmissaoCapa, _
                                                                                     iTipo, _
                                                                                     cboChaveAcesso.SelectedValue)

            'Seta Focu
            cboTipo.Focus()

            sChaveAcesso = cboChaveAcesso.SelectedValue

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: UNIDADE TRANSPORTE :::"

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Cliente
            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If

            If ValidaCampo(cboChaveAcesso, lblChaveAcesso) = False Then
                Exit Function
            End If

            If ValidaCampo(txtQuantidadeRateada, lblQuantidadeRateada, TipoCampo.numero) = False Then
                Exit Function
            End If

            If ValidaCampo(txtNumeroLacres, lblNumeroLacres, TipoCampo.numero) = False Then
                Exit Function
            End If
            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ExcluirUnidadeCarga()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdUnidadeCarga) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                'If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro
                Call oClsFrmFatEmissaoMDFeUnidadeTransporte.DeleteUnidadeCarga(grdUnidadeCarga.CurrentRow.Cells.Item("codigo").Value, _
                                                                               lCodigoEmissaoCapa)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroExcluido)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
                'End If
            Else
            'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
            MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SalvarDocumentosNota()

        Try
            If IsNumeric(btnInserir.Tag) Then
                oClsFrmFatEmissaoMDFeUnidadeTransporte.UpdateDocumentos(lCodigoEmissaoCapa, _
                                                                    IIf(cboChaveAcesso.SelectedIndex = -1, -1, cboChaveAcesso.SelectedValue), _
                                                                    IIf(cboTipo.SelectedIndex = -1, -1, cboTipo.SelectedValue), _
                                                                    txtQuantidadeRateada.Value, _
                                                                    txtNumeroLacres.Value, _
                                                                    iTipo, _
                                                                    btnInserir.Tag, _
                                                                    sChaveAcesso, _
                                                                    sUF, _
                                                                    iCodigoMunicipio)
            Else
                oClsFrmFatEmissaoMDFeUnidadeTransporte.InsertDocumentos(lCodigoEmissaoCapa, _
                                                                    IIf(cboChaveAcesso.SelectedIndex = -1, -1, cboChaveAcesso.SelectedValue), _
                                                                    IIf(cboTipo.SelectedIndex = -1, -1, cboTipo.SelectedValue), _
                                                                    txtQuantidadeRateada.Value, _
                                                                    txtNumeroLacres.Value, _
                                                                    iTipo, _
                                                                    sUF, _
                                                                    iCodigoMunicipio)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarUnidadeCarga()

        Try
            Dim oForm As New frmFatEmissaoMDFeUnidadeCarga

            'Carrega Controles
            With grdUnidadeCarga.CurrentRow
                oForm.txtIdentificacao.Text = .Cells("identificacao_unidade_carga").Value
                oForm.txtNumeroLacres.Value = .Cells("numero_lacre").Value
                oForm.txtQuantidadeRateada.Value = .Cells("quantidade_rateada").Value
                oForm.cboTipo.SelectedValue = .Cells("codigo_tipo_unidade_carga").Value
                oForm.btnSalvar.Tag = .Cells("codigo").Value
                oForm.ChaveAcesso = cboChaveAcesso.SelectedValue
                oForm.CodigoEmissaoCapa = lCodigoEmissaoCapa
                oForm.Tipo = iTipo

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                oClsFrmFatEmissaoMDFeUnidadeTransporte.LoadGridNotaFiscalDocumentos(grdUnidadeCarga, _
                                                                                    lCodigoEmissaoCapa, _
                                                                                    iTipo, _
                                                                                    cboChaveAcesso.SelectedValue)

            End With

            'Seta Focu
            oForm.cboTipo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region









End Class