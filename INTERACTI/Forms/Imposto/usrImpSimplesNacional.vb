Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class usrImpSimplesNacional

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsImpSimplesNacional As New clsUsrImpSimplesNacional

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrImpSimplesNacional_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ImpostoSimplesNacional
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoSimplesNacional)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

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
                Call Salvar()
                'Prepara Formulário
                Call Novo()
                'Carrega Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoEmpresa.SelectedIndexChanged

        Try

            'Limpa Grid
            grdListagem.DataSource = Nothing

            'Verifica se foi Selecionado Algum Registro
            If cboTipoEmpresa.SelectedIndex > -1 Then

                'Carrega Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna Selecionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ImpostoSimplesNacional)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ImpostoSimplesNacional, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ImpostoSimplesNacional, gcDelete)
            btnInserir.Enabled = VerificaDireito(Formulario.ImpostoSimplesNacional, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ImpostoSimplesNacional, gcPrint)

            'Carrega Combo
            Call LoadCombo(cboTipoEmpresa, "sp_select_combo_static_tipo_empresa_simples_nacional")

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoSimplesNacional)

            'Seta Focu
            cboTipoEmpresa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsImpSimplesNacional.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtReceitaBrutaInicio.Value = 0
            txtReceitaBrutaFinal.Value = 0
            txtAliquota.Value = 0
            txtIRPJ.Value = 0
            txtCSLL.Value = 0
            txtCOFINS.Value = 0
            txtPIS.Value = 0
            txtCPP.Value = 0
            txtICMS.Value = 0
            txtISS.Value = 0
            chkFaixaAtiva.Checked = False
            btnInserir.Tag = ""

            'Seta Focu
            txtReceitaBrutaInicio.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsImpSimplesNacional.Codigo = IIf(IsNumeric(btnInserir.Tag), btnInserir.Tag, -1)
            oClsImpSimplesNacional.TipoEmpresa = cboTipoEmpresa.SelectedValue
            oClsImpSimplesNacional.ReceitaBrutaInicio = txtReceitaBrutaInicio.Value
            oClsImpSimplesNacional.ReceitaBrutaFinal = txtReceitaBrutaFinal.Value
            oClsImpSimplesNacional.Aliquota = txtAliquota.Value
            oClsImpSimplesNacional.IRPJ = txtIRPJ.Value
            oClsImpSimplesNacional.CSLL = txtCSLL.Value
            oClsImpSimplesNacional.COFINS = txtCOFINS.Value
            oClsImpSimplesNacional.PIS = txtPIS.Value
            oClsImpSimplesNacional.CPP = txtCPP.Value
            oClsImpSimplesNacional.ICMS = txtICMS.Value
            oClsImpSimplesNacional.ISS = txtISS.Value
            oClsImpSimplesNacional.FaixaAtiva = chkFaixaAtiva.Checked

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) = True Then
                oClsImpSimplesNacional.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsImpSimplesNacional.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ImpostoSimplesNacional, gcUpdate) = True Then

                'Carrega Controles
                txtReceitaBrutaInicio.Value = grdListagem.CurrentRow.Cells("receita_bruta_inicio").Value
                txtReceitaBrutaFinal.Value = grdListagem.CurrentRow.Cells("receita_bruta_final").Value
                txtAliquota.Value = grdListagem.CurrentRow.Cells("aliquota").Value
                txtIRPJ.Value = grdListagem.CurrentRow.Cells("irpj").Value
                txtCSLL.Value = grdListagem.CurrentRow.Cells("csll").Value
                txtCOFINS.Value = grdListagem.CurrentRow.Cells("cofins").Value
                txtPIS.Value = grdListagem.CurrentRow.Cells("pis").Value
                txtCPP.Value = grdListagem.CurrentRow.Cells("cpp").Value
                txtICMS.Value = grdListagem.CurrentRow.Cells("icms").Value
                txtISS.Value = grdListagem.CurrentRow.Cells("iss").Value
                chkFaixaAtiva.Checked = grdListagem.CurrentRow.Cells("faixa_ativa").Value
                btnInserir.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Seta Focu
                txtReceitaBrutaInicio.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsImpSimplesNacional.LoadGrid(grdListagem, _
                                            cboTipoEmpresa.SelectedValue)

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

            'Verifica se foi Selecionado o Campo - Tipo de Empresa - Simples Nacional
            If ValidaCampo(cboTipoEmpresa, lblTipoEmpresa) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Receita Bruta Inicial > Receita Bruta Final
            If txtReceitaBrutaInicio.Value > txtReceitaBrutaFinal.Value Then
                frmMain.errInfo.SetError(lblReceitaBruta, "A Receita Bruta Inicial não pode ser maior que a Receita Bruta Final.")
                txtReceitaBrutaInicio.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
