Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common

Public Class usrCadParceiroNegocioRelacionamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadParceiroNegocioRelacionamento As New clsUsrCadParceiroNegocioRelacionamento

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadParceiroNegocioRelacionamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.Name
                        Case "cboParceiroNegocioFiltro" : Call btnProcurarParceiroNegocio_Click(btnProcurarParceiroNegocio, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboPais" : Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboParceiroNegocioFiltro" : Call LoadCombo(cboParceiroNegocioFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
                        Case "cboVendedor" : Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
                        Case "cboVendedorInterno" : Call LoadCombo(cboVendedorInterno, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboPais" : Call btnCadastrarPais_Click(btnCadastrarPais, System.EventArgs.Empty)
                        Case "cboVendedor" : Call btnCadastrarVendedor_Click(btnCadastrarVendedor, System.EventArgs.Empty)
                        Case "cboVendedorInterno" : Call btnCadastrarVendedorInterno_Click(btnCadastrarVendedorInterno, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadParceiroNegocioRelacionamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PARCEIRO DE NEGÓCIO :::"

    Private Sub btnProcurarParceiroNegocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarParceiroNegocio.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            oComboBoxFind = cboParceiroNegocioFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboParceiroNegocioFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Parceiro de Negócio
            If ValidaCampo(cboParceiroNegocioFiltro, lblParceiroNegocioFiltro) = False Then
                Exit Sub
            End If

            'Abre Mapa
            Call Mapa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPais.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPais.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarVendedor.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadVendedor")

            'Carrega Combo
            Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, )
            'Seta Focu
            cboVendedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarVendedorInterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarVendedorInterno.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadVendedor")

            'Carrega Combo
            Call LoadCombo(cboVendedorInterno, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, )
            'Seta Focu
            cboVendedorInterno.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub cboPersonalidade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPersonalidade.SelectedIndexChanged

        Try

            'Váriaveis Locais
            Dim sCNPJ As String
            Dim sInscricaoEstadual As String

            sCNPJ = txtCnpjCpf.Text.Trim
            sInscricaoEstadual = txtInscricaoEstadual.Text.Trim

            'Variaveis Locais
            Dim oSuperTipSettings As New SuperTipSettings

            If cboPersonalidade.SelectedIndex = -1 Then

                Exit Sub

            ElseIf cboPersonalidade.SelectedValue = Personalidade.fisica Then

                oSuperTipSettings.HeaderText = "RG"
                oSuperTipSettings.Text = "Preencher RG (somente  números)."

                lblCnpjCpf.Text = "CPF:"
                txtCnpjCpf.Text = ""
                txtCnpjCpf.Mask = "000,000,000-00"
                txtInscricaoEstadual.Enabled = True
                lblInscricaoEstadual.Text = "RG:"
                txtInscricaoEstadual.Text = ""
                txtInscricaoEstadualSubstitutoTriburario.Text = "" : txtInscricaoEstadualSubstitutoTriburario.Enabled = False
                txtInscricaoMunicipal.Text = "" : txtInscricaoMunicipal.Enabled = False
                txtInscricaoSuframa.Text = "" : txtInscricaoSuframa.Enabled = False
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            ElseIf cboPersonalidade.SelectedValue = Personalidade.juridica Then

                oSuperTipSettings.HeaderText = "Inscrição Estadual"
                oSuperTipSettings.Text = "Preencher Inscrição Estadual (somente  números) caso contribuinte do ICMS." & vbCrLf & _
                                         "Preencher com ISENTO caso contribuinte do ICMS, mas não estiver obrigado a inscrição no cadastro de contribuintes." & vbCrLf & _
                                         "Não preencher caso não for contribuinte do ICMS."

                lblCnpjCpf.Text = "CNPJ:"
                txtCnpjCpf.Text = ""
                txtCnpjCpf.Mask = "00,000,000/0000-00"
                txtInscricaoEstadualSubstitutoTriburario.Enabled = True
                lblInscricaoEstadual.Text = "Inscrição Estadual:"
                txtInscricaoEstadual.Text = ""
                txtInscricaoMunicipal.Enabled = True
                txtInscricaoSuframa.Enabled = True
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            Else

                oSuperTipSettings.HeaderText = "Inscrição Estadual"
                oSuperTipSettings.Text = "Preencher Inscrição Estadual (somente  números) caso contribuinte do ICMS." & vbCrLf & _
                                         "Preencher com ISENTO caso contribuinte do ICMS, mas não estiver obrigado a inscrição no cadastro de contribuintes." & vbCrLf & _
                                         "Não preencher caso não for contribuinte do ICMS."

                lblCnpjCpf.Text = "CNPJ / CPF:"
                txtCnpjCpf.Text = ""
                txtCnpjCpf.Mask = ""
                lblInscricaoEstadual.Text = "Inscrição Estadual:"
                txtInscricaoEstadual.Text = ""
                txtInscricaoEstadualSubstitutoTriburario.Text = "" : txtInscricaoEstadualSubstitutoTriburario.Enabled = False
                txtInscricaoMunicipal.Text = "" : txtInscricaoMunicipal.Enabled = False
                txtInscricaoSuframa.Text = "" : txtInscricaoSuframa.Enabled = False
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            End If

            txtCnpjCpf.Text = sCNPJ
            txtInscricaoEstadual.Text = sInscricaoEstadual

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPais.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPais.SelectedIndex = -1 Then
                cboUF.DataSource = Nothing
                cboUF.Text = ""
                cboMunicipio.DataSource = Nothing
                cboMunicipio.Text = ""
            Else
                Call LoadCombo(cboUF, "sp_select_combo_static_estado_pais " & cboPais.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUF.SelectedIndex = -1 Then
                cboMunicipio.DataSource = Nothing
                cboMunicipio.Text = ""
            Else
                Call LoadCombo(cboMunicipio, "sp_select_combo_static_municipio '" & cboUF.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboParceiroNegocioFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboParceiroNegocioFiltro.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub tabDados_Resize(sender As Object, e As EventArgs) Handles tabDados.Resize

        Try

            'Váriaveis Locais
            Dim dHeight As Integer = 407
            Dim dHeightGrid1 As Integer = 179
            Dim dHeightGrid2 As Integer = 178
            Dim dFator As Double = tabDados.Height - dHeight

            'Ajusta Histórico Financeiro
            grdContasAberto.Height = dHeightGrid1 + System.Math.Ceiling(dFator / 2)
            grdContasRecebidas.Height = dHeightGrid2 + System.Math.Floor(dFator / 2)
            grdContasAberto.Top = grdContasRecebidas.Top + grdContasRecebidas.Height + 9

            'Seta Váriavel
            dHeightGrid1 = 153
            dHeightGrid2 = 178

            'Ajusta Pedido de Venda
            grdPedidoVendaProduto.Height = grdContasAberto.Height
            grdPedidoVenda.Height = grdContasRecebidas.Height
            grdPedidoVendaProduto.Top = grdContasAberto.Top
            grdNotaFiscal.Top = grdContasAberto.Top
            'Ajusta Orçamento
            grdOrcamentoProduto.Height = grdContasAberto.Height
            grdOrcamento.Height = grdContasRecebidas.Height
            grdOrcamentoProduto.Top = grdContasAberto.Top
            grdNotaFiscalProduto.Top = grdContasAberto.ToString

            'Seta Top - Histórico Financeiro
            btnConfigurarGridContasRecebidas.Top = grdContasRecebidas.Top + grdContasRecebidas.Height - btnConfigurarGridContasRecebidas.Height - 2
            btnAgruparGridContasRecebidas.Top = btnConfigurarGridContasRecebidas.Top
            btnExcelGridContasRecebidas.Top = btnConfigurarGridContasRecebidas.Top
            'Seta Top - Pedido de Venda
            btnConfigurarGridPedidoVendaProduto.Top = btnConfigurarGridContasRecebidas.Top
            btnAgruparGridPedidoVendaProduto.Top = btnConfigurarGridContasRecebidas.Top
            btnExcelGridPedidoVendaProduto.Top = btnConfigurarGridContasRecebidas.Top
            'Seta Top - Orçamento
            btnConfigurarGridOrcamentoProduto.Top = btnConfigurarGridContasRecebidas.Top
            btnAgruparGridOrcamentoProduto.Top = btnConfigurarGridContasRecebidas.Top
            btnExcelGridOrcamentoProduto.Top = btnConfigurarGridContasRecebidas.Top

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            Select Case e.Page.Key

                Case "pagDadosGerais" : btnSalvar.Visible = True
                Case Else : btnSalvar.Visible = False

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: TÍTULOS :::"

    Private Sub btnAgruparGridTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridContasRecebidas.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContasRecebidas.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContasRecebidas.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContasRecebidas.GroupByBoxVisible = True
                grdContasRecebidas.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridContasRecebidas.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContasRecebidas
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocioRelacionamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContasRecebidas, Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContasRecebidas.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdContasRecebidas)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdTitulo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContasRecebidas.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContasRecebidas, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdTitulo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContasRecebidas.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContasRecebidas.Name, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdTitulo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdContasRecebidas.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContasRecebidas.Name, _
                                          Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTATO :::"

    Private Sub btnAgruparGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridContato.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContato.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContato.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContato.GroupByBoxVisible = True
                grdContato.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridContato.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContato
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocioRelacionamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContato.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdContato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato.Name, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContato.Name, _
                                          Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ENDEREÇO :::"

    Private Sub btnAgruparGridEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridEndereco.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdEndereco.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdEndereco.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdEndereco.GroupByBoxVisible = True
                grdEndereco.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridEndereco.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEndereco
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocioRelacionamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEndereco, Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridEndereco.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdEndereco)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEndereco.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEndereco, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEndereco.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEndereco.Name, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdEndereco.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdEndereco.Name, _
                                          Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub btnConfigurarGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridOrcamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOrcamento
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocioRelacionamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdOrcamento, Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridOrcamento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOrcamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdOrcamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdOrcamento.GroupByBoxVisible = True
                grdOrcamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridOrcamento.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridOrcamentoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridOrcamentoProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOrcamentoProduto
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocioRelacionamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdOrcamentoProduto, Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridOrcamentoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridOrcamentoProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOrcamentoProduto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdOrcamentoProduto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdOrcamentoProduto.GroupByBoxVisible = True
                grdOrcamentoProduto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridOrcamentoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridOrcamentoProduto.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdOrcamentoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_SelectionChanged(sender As Object, e As EventArgs) Handles grdOrcamento.SelectionChanged

        Try

            Me.Select()

            'Verifica se foi Selecionado algum Registro
            If IsNothing(grdOrcamento.CurrentRow) = False Then

                'Váriavel - Classe
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Grid - Produtos Similares
                Call oClsCadParceiroNegocioRelacionamento.LoadGridHistoricoOrcamentoProduto(grdOrcamentoProduto, _
                                                                                            grdOrcamento.CurrentRow.Cells("codigo_orcamento").Value)

            Else

                'Limpa Controle
                grdOrcamento.DataSource = Nothing

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamento.Name, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamento, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamento.Name, _
                                          Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamentoProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoProduto.Name, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamentoProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoProduto, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamentoProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamentoProduto.Name, _
                                          Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO DE VENDA :::"

    Private Sub btnConfigurarGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPedido.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedidoVenda
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocioRelacionamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdPedidoVenda, Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPedido.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoVenda.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPedidoVenda.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPedidoVenda.GroupByBoxVisible = True
                grdPedidoVenda.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPedido.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridPedidoVendaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPedidoVendaProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedidoVendaProduto
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocioRelacionamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdPedidoVendaProduto, Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridPedidoVendaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPedidoVendaProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoVendaProduto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPedidoVendaProduto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPedidoVendaProduto.GroupByBoxVisible = True
                grdPedidoVendaProduto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPedidoVendaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPedidoVendaProduto.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdPedidoVendaProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_SelectionChanged(sender As Object, e As EventArgs) Handles grdPedidoVenda.SelectionChanged

        Try

            Me.Select()

            'Verifica se foi Selecionado algum Registro
            If IsNothing(grdPedidoVenda.CurrentRow) = False Then

                'Váriavel - Classe
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Grid - Produtos Similares
                Call oClsCadParceiroNegocioRelacionamento.LoadGridHistoricoVendaProduto(grdPedidoVendaProduto, _
                                                                                        grdPedidoVenda.CurrentRow.Cells("codigo_pedido").Value)

            Else

                'Limpa Controle
                grdPedidoVenda.DataSource = Nothing

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoVenda.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVenda.Name, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoVenda.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVenda, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoVenda.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoVenda.Name, _
                                          Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVendaProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoVendaProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVendaProduto.Name, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVendaProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoVendaProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVendaProduto, _
                                     Formulario.CadastroBasicoParceiroNegocioRelacionamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVendaProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoVendaProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoVendaProduto.Name, _
                                          Formulario.CadastroBasicoParceiroNegocioRelacionamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadParceiroNegocioRelacionamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadCombo(cboParceiroNegocioFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Dim oComboBox(1) As UiComboBox
            oComboBox(0) = cboVendedorInterno : oComboBox(1) = cboVendedor
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadCombo(cboPersonalidade, "sp_select_combo_static_personalidade")
            Call LoadCombo(cboTipoInscricaoEstadual, "sp_select_combo_static_tipo_inscricao_estadual")

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocioRelacionamento)
            Call ConfiguraGrid(grdEndereco, Formulario.CadastroBasicoParceiroNegocioRelacionamento)
            Call ConfiguraGrid(grdContasRecebidas, Formulario.CadastroBasicoParceiroNegocioRelacionamento)
            Call ConfiguraGrid(grdContasAberto, Formulario.CadastroBasicoParceiroNegocioRelacionamento)
            Call ConfiguraGrid(grdOrcamento, Formulario.CadastroBasicoParceiroNegocioRelacionamento)
            Call ConfiguraGrid(grdOrcamentoProduto, Formulario.CadastroBasicoParceiroNegocioRelacionamento)
            Call ConfiguraGrid(grdPedidoVenda, Formulario.CadastroBasicoParceiroNegocioRelacionamento)
            Call ConfiguraGrid(grdPedidoVendaProduto, Formulario.CadastroBasicoParceiroNegocioRelacionamento)

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioRelacionamento, gcInsert)
            btnCadastrarPais.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarVendedor.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)
            btnCadastrarVendedorInterno.Enabled = btnCadastrarVendedor.Enabled

            'Seta Datetime
            dtpDataInicioPedidoVenda.Value = DateAdd(DateInterval.Year, -1, Now.Date)
            dtpDataTerminoPedidoVenda.Value = Now.Date
            dtpDataInicioOrcamento.Value = DateAdd(DateInterval.Year, -1, Now.Date)
            dtpDataTerminoOrcamento.Value = Now.Date

            'Adiciona Evento
            AddHandler dtpDataInicioPedidoVenda.ValueChanged, AddressOf LoadGridPedidoVenda
            AddHandler dtpDataTerminoPedidoVenda.ValueChanged, AddressOf LoadGridPedidoVenda
            AddHandler dtpDataInicioOrcamento.ValueChanged, AddressOf LoadGridOrcamento
            AddHandler dtpDataTerminoOrcamento.ValueChanged, AddressOf LoadGridOrcamento

            'Oculta Controle
            btnSalvar.Visible = False

            'Seta Focu
            cboParceiroNegocioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Mapa()

        Try

            'Váriaveis Locais - Formulário Mapa
            Dim oForm As New frmActMaps
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            Dim sEndereco As String = ""
            Dim sCEP As String = ""
            Dim sMunicipio As String = ""

            Call LoadDadosParceiroNegocioEndereco(cboParceiroNegocioFiltro.SelectedValue, _
                                                  sEndereco, _
                                                  sCEP, _
                                                  sMunicipio)

            'Seta Parâmetros do Formulário
            oForm.EnderecoDestino = sEndereco
            oForm.CepDestino = sCEP
            oForm.MunicipioDestino = sMunicipio

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboParceiroNegocioFiltro.SelectedIndex = -1 Then

                'Limpa Grid
                grdContasRecebidas.DataSource = Nothing
                grdContasAberto.DataSource = Nothing
                grdContato.DataSource = Nothing
                grdEndereco.DataSource = Nothing
                grdPedidoVenda.DataSource = Nothing
                grdOrcamento.DataSource = Nothing

                'Limpa Controles
                cboPersonalidade.Text = ""
                txtCEP.Text = ""
                cboPais.Text = ""
                cboUF.Text = ""
                cboMunicipio.Text = ""
                txtLogradouro.Text = ""
                txtNumero.Text = ""
                txtBairro.Text = ""
                txtComplemento.Text = ""
                txtCnpjCpf.Text = ""
                cboTipoInscricaoEstadual.Text = ""
                txtInscricaoEstadual.Text = ""
                txtInscricaoEstadualSubstitutoTriburario.Text = ""
                txtInscricaoMunicipal.Text = ""
                txtInscricaoSuframa.Text = ""
                cboVendedorInterno.Text = ""
                cboVendedor.Text = ""
                txtObservacao.Text = ""
                txtTelefone1.Text = ""
                txtTelefone2.Text = ""
                txtTelefoneRecado.Text = ""
                txtFax.Text = ""
                txtEmail.Text = ""
                dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
                dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False

            Else

                'Carrega Grid
                oClsCadParceiroNegocioRelacionamento.LoadGridTitulo(grdContasRecebidas, cboParceiroNegocioFiltro.SelectedValue, "BAIXADO")
                oClsCadParceiroNegocioRelacionamento.LoadGridTitulo(grdContasAberto, cboParceiroNegocioFiltro.SelectedValue, "ABERTO")
                oClsCadParceiroNegocioRelacionamento.LoadGridContato(grdContato, cboParceiroNegocioFiltro.SelectedValue)
                oClsCadParceiroNegocioRelacionamento.LoadGridEndereco(grdEndereco, cboParceiroNegocioFiltro.SelectedValue)
                oClsCadParceiroNegocioRelacionamento.LoadGridHistoricoOrcamento(grdOrcamento, _
                                                                                cboParceiroNegocioFiltro.SelectedValue, _
                                                                                dtpDataInicioPedidoVenda.Value, _
                                                                                dtpDataTerminoPedidoVenda.Value)
                oClsCadParceiroNegocioRelacionamento.LoadGridHistoricoVenda(grdPedidoVenda, _
                                                                            cboParceiroNegocioFiltro.SelectedValue, _
                                                                            dtpDataInicioPedidoVenda.Value, _
                                                                            dtpDataTerminoPedidoVenda.Value)

                'Carrega Controles
                oClsCadParceiroNegocioRelacionamento.LoadControles(cboParceiroNegocioFiltro.SelectedValue, _
                                                                   cboPersonalidade, _
                                                                   txtCnpjCpf, _
                                                                   cboTipoInscricaoEstadual, _
                                                                   txtInscricaoEstadual, _
                                                                   txtInscricaoEstadualSubstitutoTriburario, _
                                                                   txtInscricaoMunicipal, _
                                                                   txtInscricaoSuframa, _
                                                                   txtLogradouro, _
                                                                   txtNumero, _
                                                                   txtBairro, _
                                                                   cboMunicipio, _
                                                                   cboPais, _
                                                                   cboUF, _
                                                                   txtComplemento, _
                                                                   txtCEP, _
                                                                   cboVendedorInterno, _
                                                                   cboVendedor, _
                                                                   txtObservacao, _
                                                                   txtTelefone1, _
                                                                   txtTelefone2, _
                                                                   txtTelefoneRecado, _
                                                                   txtFax, _
                                                                   txtEmail, _
                                                                   dtpDataFundacao, _
                                                                   dtpDataCadastro)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPedidoVenda()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboParceiroNegocioFiltro.SelectedIndex <> -1 Then

                'Carrega Grid
                oClsCadParceiroNegocioRelacionamento.LoadGridHistoricoVenda(grdPedidoVenda, _
                                                                            cboParceiroNegocioFiltro.SelectedValue, _
                                                                            dtpDataInicioPedidoVenda.Value, _
                                                                            dtpDataTerminoPedidoVenda.Value)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridOrcamento()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboParceiroNegocioFiltro.SelectedIndex <> -1 Then

                'Carrega Grid
                oClsCadParceiroNegocioRelacionamento.LoadGridHistoricoOrcamento(grdOrcamento, _
                                                                                cboParceiroNegocioFiltro.SelectedValue, _
                                                                                dtpDataInicioPedidoVenda.Value, _
                                                                                dtpDataTerminoPedidoVenda.Value)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Atualiza Registro
            Call oClsCadParceiroNegocioRelacionamento.Update(cboParceiroNegocioFiltro.SelectedValue, _
                                                             cboPersonalidade.SelectedValue, _
                                                             txtCEP.Text.Trim, _
                                                             cboPais.SelectedValue, _
                                                             cboUF.SelectedValue, _
                                                             cboMunicipio.SelectedValue, _
                                                             txtLogradouro.Text.Trim, _
                                                             txtNumero.Text.Trim, _
                                                             txtBairro.Text.Trim, _
                                                             txtComplemento.Text.Trim, _
                                                             txtCnpjCpf.Text.Trim, _
                                                             cboTipoInscricaoEstadual.SelectedValue, _
                                                             txtInscricaoEstadual.Text.Trim, _
                                                             txtInscricaoEstadualSubstitutoTriburario.Text.Trim, _
                                                             txtInscricaoMunicipal.Text.Trim, _
                                                             txtInscricaoSuframa.Text.Trim, _
                                                             txtEmail.Text.Trim, _
                                                             txtTelefone1.Text.Trim, _
                                                             txtTelefone2.Text.Trim, _
                                                             txtFax.Text.Trim, _
                                                             txtTelefoneRecado.Text.Trim, _
                                                             IIf(cboVendedorInterno.SelectedIndex = -1, -1, cboVendedorInterno.SelectedValue), _
                                                             IIf(cboVendedor.SelectedIndex = -1, -1, cboVendedor.SelectedValue), _
                                                             txtObservacao.Text.Trim, _
                                                             IIf(dtpDataFundacao.Checked = False, "", dtpDataFundacao.Value), _
                                                             IIf(dtpDataCadastro.Checked = False, "", dtpDataCadastro.Value))

            'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Personalidade
            If ValidaCampo(cboParceiroNegocioFiltro, lblParceiroNegocioFiltro) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboParceiroNegocioFiltro.Focus() : Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Personalidade
            If ValidaCampo(cboPersonalidade, lblPersonalidade) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboPersonalidade.Focus() : Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CEP
            If ValidaCampo(txtCEP, lblCEP, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosGerais : txtCEP.Focus() : Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPais, lblPais) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboPais.Focus() : Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUF, lblUF) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboUF.Focus() : Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If cboUF.SelectedValue <> gcUFExterior Then
                If ValidaCampo(cboMunicipio, lblMunicipio) = False Then
                    tabDados.SelectedTab = pagDadosGerais : cboMunicipio.Focus() : Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouro, lblLogradouro, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosGerais : txtLogradouro.Focus() : Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumero, lblNumero, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosGerais : txtNumero.Focus() : Exit Function
            End If

            'Verifica se foi Preenchido Corretamente o Campo - Email
            If txtEmail.Text.Trim <> "" Then
                If ValidaCampo(txtEmail, lblEmail, TipoCampo.email) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtEmail.Focus() : Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - CNPJ / CPF
            If ((cboPersonalidade.SelectedValue <> Personalidade.OrgaoPublico And cboPersonalidade.SelectedValue <> Personalidade.Outros) And txtCnpjCpf.Text.Trim <> "" And cboUF.SelectedValue <> "EX") Then

                ' Verifica se o CNPJ / CPF é válido
                If cboPersonalidade.SelectedValue = Personalidade.Fisica And txtCnpjCpf.Text <> "" Then
                    If ValidaCPF(txtCnpjCpf.Text.Trim) = False Then
                        frmMain.errInfo.SetError(lblCnpjCpf, "Este CPF não é válido!")
                        txtCnpjCpf.Focus()
                        Exit Function
                    End If
                End If

                If cboPersonalidade.SelectedValue = Personalidade.Juridica And txtCnpjCpf.Text <> "" Then
                    If ValidaCNPJ(txtCnpjCpf.Text.Trim) = False Then
                        frmMain.errInfo.SetError(lblCnpjCpf, "Este CNPJ não é válido!")
                        txtCnpjCpf.Focus()
                        Exit Function
                    End If
                End If

                'Váriaveis Locais
                Dim oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio

                'Passa Parametros
                If oClsCadParceiroNegocio.ValidaCnpjCpf(cboParceiroNegocioFiltro.SelectedValue, _
                                                        txtCnpjCpf.Text.Trim) = False Then
                    frmMain.errInfo.SetError(lblCnpjCpf, "Este " & IIf(cboPersonalidade.SelectedValue = Personalidade.Juridica, "CNPJ", "CPF") & ": " & txtCnpjCpf.Text & " já está associado a outro Registro.")
                    txtCnpjCpf.Focus()
                    Exit Function
                End If

            End If

            'Valida Campo - Tipo de Inscrição Estadual
            If ValidaCampo(cboTipoInscricaoEstadual, lblTipoInscricaoEstadual) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboTipoInscricaoEstadual.Focus() : Exit Function
            End If

            'Verifica se foi Preenchido o Campo - IE
            If txtInscricaoEstadual.Text.Trim <> "" Then

                If ValidaCampo(txtInscricaoEstadual, lblInscricaoEstadual, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtInscricaoEstadual.Focus() : Exit Function
                End If

                'Verifica se a IE é válida
                If cboPersonalidade.SelectedValue = Personalidade.Juridica Then
                    If ValidaIE(cboUF.SelectedValue, txtInscricaoEstadual.Text.Trim) = False Then
                        frmMain.errInfo.SetError(lblInscricaoEstadual, "Esta Inscrição Estadual não é válido!")
                        tabDados.SelectedTab = pagDadosGerais : txtInscricaoEstadual.Focus() : Exit Function
                    End If
                End If

            End If

            
            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
