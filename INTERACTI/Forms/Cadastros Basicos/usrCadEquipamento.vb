Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.IO

Public Class usrCadEquipamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadEquipamento As New clsUsrCadEquipamento
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

#End Region

#Region "::: EQUIPAMENTO :::"

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtCodigoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula clicada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn, _
                                                                                                                        grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved, _
                                                                                                                       grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging, _
                                                                                           grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário e do Pedido de Compras
            If Validacao() = False Or ValidacaoArquivo() = False Then Exit Sub

            Salvar()
            SalvarArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            DeleteArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            Select Case grdArquivo.CurrentColumn.Key

                Case "visualizar" : VisualizarArquivo(grdArquivo.GetValue("caminho_arquivo"))

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirArquivo.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnInserirArquivo.Enabled = VerificaDireito(iFormulario, gcInsert)

            LoadComboSimNao(cboAtivo)

            tabMain.TabPages.Remove(pagDados)

            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdArquivo, iFormulario)

            txtCodigoFiltro.Focus()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: EQUIPAMENTO :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Formulário
                Novo()

                btnSalvar.Tag = grdListagem.GetValue("codigo")

                oClsUsrCadEquipamento.LoadDados(btnSalvar.Tag, _
                                         txtCodigo, _
                                         txtDescricao, _
                                         txtCapacidade, _
                                         txtResolucao, _
                                         txtCriterioAceitacao, _
                                         txtFrequenciaCalibracao, _
                                         txtPontosCalibracao, _
                                         cboAtivo, _
                                         txtArea, _
                                         txtColaborador, _
                                         txtObservacao)

                LoadGridArquivo()

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                txtCodigo.Focus()

            Else
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            If VerificaSelecaoRow(grdListagem) = True Then

                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrCadEquipamento.Delete()

                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpLocalizacao)
            LimparCamposGroupBox(grpCalibracao)
            LimparCamposGroupBox(grpArquivo)

            btnSalvar.Tag = ""
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            txtCodigo.Focus()

            LoadCombo(cboFrequenciaCalibracao, "sp_select_static_tipo_frequencia_calibracao", True)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadEquipamento.Update(btnSalvar.Tag, _
                                      txtCodigo.Text.Trim, _
                                      txtDescricao.Text.Trim, _
                                      txtCapacidade.Text.Trim, _
                                      txtResolucao.Text.Trim, _
                                      txtCriterioAceitacao.Text.Trim, _
                                      txtFrequenciaCalibracao.Value, _
                                      cboFrequenciaCalibracao.Text.Trim, _
                                      txtPontosCalibracao.Text.Trim, _
                                      cboAtivo.SelectedValue, _
                                      txtArea.Text.Trim, _
                                      txtColaborador.Text.Trim, _
                                      txtObservacao.Text.Trim)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCadEquipamento.Insert(txtCodigo.Text.Trim, _
                                      txtDescricao.Text.Trim, _
                                      txtCapacidade.Text.Trim, _
                                      txtResolucao.Text.Trim, _
                                      txtCriterioAceitacao.Text.Trim, _
                                      txtFrequenciaCalibracao.Value, _
                                      cboFrequenciaCalibracao.Text.Trim, _
                                      txtPontosCalibracao.Text.Trim, _
                                      cboAtivo.SelectedValue, _
                                      txtArea.Text.Trim, _
                                      txtColaborador.Text.Trim, _
                                      txtObservacao.Text.Trim)

                btnSalvar.Tag = oClsUsrCadEquipamento.Codigo

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

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
            oClsUsrCadEquipamento.LoadGrid(grdListagem, _
                                    txtCodigoFiltro.Text.Trim, _
                                    txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then Return False

            If oClsUsrCadEquipamento.ValidaCodigo(txtCodigo.Text.Trim, _
                                           IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                txtCodigo.Focus()
                Return False
            End If

            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False
            If ValidaCampo(cboAtivo, lblAtivo) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Private Sub LoadGridArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadEquipamento.LoadGridArquivo(grdArquivo, _
                                           btnSalvar.Tag)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oFileInfo As New System.IO.FileInfo(txtArquivo.Text.Trim)
            Dim sCaminho As String = LoadCodigo("sp_load_pasta_arquivo_equipamento " & goUsuario.iEmpresa)
            Dim sFile As String = sCaminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

            System.IO.File.Copy(txtArquivo.Text.Trim, sFile)

            If Not IsNumeric(btnSalvar.Tag) Then Exit Sub

            oClsUsrCadEquipamento.InsertArquivo(btnSalvar.Tag, _
                                         txtTituloArquivo.Text.Trim, _
                                         sFile)

            frmMain.Informacao(Mensagem.RegistroInserido)



            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrCadEquipamento.ExcluirArquivo(btnSalvar.Tag)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = ""

            txtTituloArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            If ValidaCampo(txtTituloArquivo, lblTituloArquivo, TipoCampo.texto) = False Then Return False
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
