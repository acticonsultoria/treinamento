Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.IO
Public Class usrAdmChamado

#Region "::: VARIAVEIS :::"

    Private oClsUsrAdmChamado As New clsUsrAdmChamado
    Private iFormulario As Integer = -1
    Private sCaminhoServidor As String
    Private sUsuario As String
    Private sSenha As String

#End Region

#Region "::: FORMATAÇÃO GRID :::"

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     iFormulario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            Call UpdateConfiguraGrid(grdListagem, _
                                     iFormulario)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          iFormulario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

        Try

            Dim oForm As New frmCfgGrid
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
            oForm.ShowDialog(Me)

            Call ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrAdmChamado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then
                        Call LoadGrid()
                    End If

            End Select

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrAdmChamado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call ConfigurarUserControl()

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            Call ExportExcel(grdListagem)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            Call LoadGrid()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            Call Novo()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            Call Novo()

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Remove(pagGrafico)
            tabMain.TabPages.Add(pagDados)

            cboTipo.Focus()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = True Then

                Call Salvar()

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            Me.Dispose()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair2.Click
        Try

            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            Me.Dispose()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            Call LoadGrid()

            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)
            tabMain.TabPages.Add(pagGrafico)
            tabMain.SelectedTab = pagLista

            txtCodigoFiltro.Focus()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            If IsNothing(e.Row) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "cancelar" : Call Cancelar()
                Case "autorizar_atividade" : Call AutorizarAtividade(grdListagem.GetValue("codigo_atividade"))

            End Select

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFinalizarChamado_Click(sender As Object, e As EventArgs) Handles btnFinalizarChamado.Click
        Try

            If MsgBox("Deseja concluir a atividade?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                Call oClsUsrAdmChamado.UpdateStatus(txtCodigo.Text, _
                                                    6) '6 = CONCLUÍDO

                frmMain.Informacao("Atividade concluída com sucesso!", Color.Blue)

                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If MsgBox("Deseja iniciar a atividade?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                Call oClsUsrAdmChamado.UpdateStatus(txtCodigo.Text, _
                                                    3) '3 = INICIADO

                frmMain.Informacao("Atividade iniciada com sucesso!", Color.Blue)

                Cursor.Current = Cursors.Default

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnAgCliente_Click(sender As Object, e As EventArgs) Handles btnAgCliente.Click
        Try
            If MsgBox("Deseja avisar que a atividade está aguardando o cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                Call oClsUsrAdmChamado.UpdateStatus(txtCodigo.Text,
                                                    9) '9 = AG CLIENTE

                frmMain.Informacao("Atividade AGUARDANDO CLIENTE com sucesso!", Color.Blue)

                Cursor.Current = Cursors.Default

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnAutorizarAtividade_Click(sender As Object, e As EventArgs) Handles btnAutorizarAtividade.Click
        Try

            If MsgBox("Deseja Autorizar essa atividade?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                AutorizarAtividade(txtCodigo.Text)

                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated
        Try


            If VerificaDireito(iFormulario, gcAdministrator) = True Then


                oClsUsrAdmChamado.UpdatePrazoResposta(grdListagem.CurrentRow.Cells.Item("codigo_atividade").Value,
                                                  grdListagem.CurrentRow.Cells.Item("data_prazo_resposta").Text)

                LoadGrid()

                frmMain.Informacao(Mensagem.RegistroAlterado)


            Else
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub


#End Region

#Region "::: ARQUIVOS :::"

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            frmMain.errInfo.Clear()

            If ValidacaoArquivo() = True Then

                Call Salvar()
                Call InserirArquivos()

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivos_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdArquivos.RowDoubleClick

        Try

            ' If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdArquivos.CurrentColumn.Key

                Case "excluir" : DeleteArquivo()
                Case "visualizar" : VisualizarArquivo()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: COMENTÁRIO:::"

    Private Sub btnInserirComentario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirComentario.Click
        Try

            Call InserirComentario()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdComentario_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdComentario.RowDoubleClick
        Try

            If IsNothing(e.Row) Then Exit Sub

            Select Case grdComentario.CurrentColumn.Key

                Case "visualizar" : Call VisualizarComentario()

            End Select

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub tabDadosChamado_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDadosChamado.SelectedTabChanged

        Try

            Select Case e.Page.Name

                Case "pagComentario"
                    Call LoadGridComentario()

            End Select

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrAdmChamado_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call LoadCombo(cboStatusFiltro, "sp_select_combo_administracao_chamado_status")
            Call LoadCombo(cboTipoAtividade, "sp_select_combo_administracao_chamado_atividade")
            Call LoadCombo(cboTipoAtividadeFiltro, "sp_select_combo_administracao_chamado_atividade")
            Call LoadCombo(cboPrioridade, "sp_select_combo_administracao_chamado_prioridade")

            oClsUsrAdmChamado.LoadDadosServidor(sCaminhoServidor, _
                                                sUsuario, _
                                                sSenha)

            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Remove(pagGrafico)

            Call ConfiguraGrid(grdListagem, iFormulario)

            dtpDataChamado.Value = Date.Now
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = True
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = True
            If goUsuario.iUsuario = 1 Then
                btnFinalizarChamado.Visible = True
            End If


            Dim oVetorItem(2) As String
            oVetorItem(0) = 1
            oVetorItem(1) = 3
            oVetorItem(2) = 9
            cboStatusFiltro.CheckedValues = oVetorItem

            If goUsuario.iUsuario = 1 Then
                cboStatusFiltro.Text = "ABERTO, INICIADO, ATIVIDADE AUTORIZADA"

            Else
                cboStatusFiltro.Text = "ABERTO, INICIADO, ATIVIDADE AUTORIZADA, AG CLIENTE"

            End If
            

            txtCodigoFiltro.Focus()

            'Editavel apenas pela ACTI
            If goUsuario.iUsuario <> 1 Then

                grdListagem.RootTable.Columns("data_prazo_resposta").SelectableCells = SelectableCells.FilterRowCells

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrAdmChamado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub Editar()

        Try

            Call Novo()

            With grdListagem.CurrentRow.Cells

                'Verifica se pode salvar: Só pode caso o usuário é o solicitante, ou ele é administrador do módulo, e o status não é cancelado ou concluído
                If (VerificaDireito(iFormulario, gcAdministrator) = False And .Item("solicitante").Value <> goUsuario.sNome) Or _
                    .Item("status").Value = "CANCELADO" Or .Item("status").Value = "CONCLUÍDO" Then
                    btnSalvar.Enabled = False
                End If

                If .Item("status").Value = "CANCELADO" Or .Item("status").Value = "CONCLUÍDO" Then
                    btnFinalizarChamado.Enabled = False
                End If

                txtCodigo.Text = .Item("codigo_atividade").Value
                dtpDataChamado.Text = .Item("data_criacao").Value
                txtSolicitante.Text = .Item("solicitante").Value
                cboTipoAtividade.SelectedValue = .Item("codigo_tipo_atividade").Value
                cboPrioridade.SelectedValue = .Item("codigo_prioridade").Value
                txtTitulo.Text = .Item("titulo").Value
                txtDescricao.Text = .Item("descricao").Value
                txtModulo.Text = .Item("modulo").Value
                txtTela.Text = .Item("tela").Value
                txtNumeroDocumento.Text = .Item("numero_documento").Value
                txtStatus.Text = .Item("status").Value

                txtDataAutorizacao.Text = .Item("data_autorizacao").Value
                txtPrazoResposta.Text = .Item("data_prazo_resposta").Value

                btnInserirComentario.Enabled = True

                Call LoadGridArquivo()
                Call LoadGridComentario()

            End With

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Remove(pagGrafico)
            tabMain.TabPages.Add(pagDados)

            cboTipo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se pode cancelar: Só pode caso o usuário é o solicitante, ou ele é administrador do módulo, e o status não é cancelado ou concluído
            If (VerificaDireito(iFormulario, gcAdministrator) = False And grdListagem.CurrentRow.Cells.Item("solicitante").Value <> goUsuario.sNome) Or _
                grdListagem.CurrentRow.Cells.Item("status").Value = "CANCELADO" Or grdListagem.CurrentRow.Cells.Item("status").Value = "CONCLUÍDO" Then
                frmMain.Informacao(Mensagem.DireitoAlteracao)
                Exit Sub
            End If

            If MsgBox("Deseja cancelar o registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                Call oClsUsrAdmChamado.UpdateStatus(grdListagem.CurrentRow.Cells.Item("codigo_atividade").Value,
                                                    14) '14 = CANCELADO

                frmMain.Informacao("Registro cancelado com sucesso!", Color.Blue)

                Call LoadGrid()

                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            frmMain.errInfo.Clear()

            txtCodigo.Text = ""
            btnSalvar.Enabled = True
            btnFinalizarChamado.Enabled = True
            dtpDataChamado.Value = Date.Now()
            txtSolicitante.Text = goUsuario.sUsuario
            cboTipoAtividade.SelectedIndex = -1
            cboPrioridade.SelectedIndex = -1
            txtTitulo.Text = ""
            txtDescricao.Text = ""
            txtModulo.Text = ""
            txtTela.Text = ""
            txtNumeroDocumento.Text = ""
            txtStatus.Text = "ABERTO"
            grdComentario.DataSource = Nothing
            grdArquivos.DataSource = Nothing
            txtDataAutorizacao.Text = ""
            txtPrazoResposta.Text = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(txtCodigo.Text) Then
                oClsUsrAdmChamado.Update(txtCodigo.Text, _
                                         cboTipoAtividade.SelectedValue, _
                                         cboPrioridade.SelectedValue, _
                                         txtTitulo.Text, _
                                         txtDescricao.Text, _
                                         txtModulo.Text, _
                                         txtTela.Text, _
                                         txtNumeroDocumento.Text)

                frmMain.Informacao("Registro alterado com sucesso!", Color.Blue)
            Else

                txtCodigo.Text = oClsUsrAdmChamado.Insert(dtpDataChamado.Text, _
                                                          txtSolicitante.Text, _
                                                          cboTipoAtividade.SelectedValue, _
                                                          cboPrioridade.SelectedValue, _
                                                          txtTitulo.Text, _
                                                          txtDescricao.Text, _
                                                          txtModulo.Text, _
                                                          txtTela.Text, _
                                                          txtNumeroDocumento.Text)

                btnInserirComentario.Enabled = True
                frmMain.Informacao("Registro inserido com sucesso!", Color.Blue)
            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim sStatus As String = ""
            Dim i As Integer

            If Not cboStatusFiltro.CheckedValues Is Nothing Then

                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            Call oClsUsrAdmChamado.LoadGrid(grdListagem, _
                                           IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                           IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                           txtCodigoFiltro.Text.Trim, _
                                           txtSolicitanteFiltro.Text.Trim, _
                                           IIf(cboTipoAtividadeFiltro.SelectedIndex = -1, -1, cboTipoAtividadeFiltro.SelectedValue), _
                                           sStatus, _
                                           txtTituloFiltro.Text.Trim, _
                                           txtDescricaoFiltro.Text.Trim)


            Call LoadComboEixoY()
            Call LoadComboSerie()
            Call LoadComboTipo()
            Call LoadComboIntervalo()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            Validacao = False

            If ValidaCampo(cboTipoAtividade, lblTipoChamado) = False Then Exit Function
            If ValidaCampo(cboPrioridade, lblPrioridade) = False Then Exit Function
            If ValidaCampo(txtTitulo, lblTitulo, TipoCampo.texto) = False Then Exit Function
            If cboTipoAtividade.SelectedValue = 3 Then 'ERRO
                If ValidaCampo(txtModulo, lblModulo, TipoCampo.texto) = False Then Exit Function
                If ValidaCampo(txtTela, lblTela, TipoCampo.texto) = False Then Exit Function

                If grdArquivos.RecordCount = 0 Then
                    tabDadosChamado.SelectedTab = pagArquivos
                    frmMain.Informacao(Mensagem.Erro, "É necessário inserir imagens do problema!")
                    Exit Function
                End If

            End If
            If ValidaCampo(txtDescricao, lblDefinicao, TipoCampo.texto) = False Then Exit Function

            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoArquivo() As Boolean

        Try

            ValidacaoArquivo = False

            If ValidaCampo(cboTipoAtividade, lblTipoChamado) = False Then Exit Function
            If ValidaCampo(cboPrioridade, lblPrioridade) = False Then Exit Function
            If ValidaCampo(txtTitulo, lblTitulo, TipoCampo.texto) = False Then Exit Function
            If cboTipoAtividade.SelectedValue = 3 Then 'ERRO
                If ValidaCampo(txtModulo, lblModulo, TipoCampo.texto) = False Then Exit Function
                If ValidaCampo(txtTela, lblTela, TipoCampo.texto) = False Then Exit Function

            End If
            If ValidaCampo(txtDescricao, lblDefinicao, TipoCampo.texto) = False Then Exit Function

            ValidacaoArquivo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub AutorizarAtividade(ByVal lCodigo As Long)

        Try

            Dim iFormularioAutorizar = LoadCodigo("sp_select_static_formulario_codigo_descricao 'ADMINISTRAÇÃO - CHAMADO INTERACTI - AUTORIZAR'")
            If VerificaDireito(iFormularioAutorizar, gcUpdate) = True Then


                Call oClsUsrAdmChamado.UpdateAutorizarAtividade(lCodigo)

                LoadGrid()

                frmMain.Informacao("Atividade AUTORIZADA com sucesso!", Color.Blue)


            Else
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVOS :::"

    Private Sub InserirArquivos()

        Try

            Dim sNomeArquivo As String
            Dim oSaveFileDialog As New OpenFileDialog
            oSaveFileDialog.Multiselect = True

            If oSaveFileDialog.ShowDialog = DialogResult.OK Then

                For Each sCaminho As String In oSaveFileDialog.FileNames

                    sNomeArquivo = RetirarAcento2(Path.GetFileName(sCaminho))

                    'Faz a conexão com o servidor FTP
                    Dim clsRequest As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(sCaminhoServidor + sNomeArquivo), System.Net.FtpWebRequest)
                    clsRequest.Credentials = New System.Net.NetworkCredential(sUsuario, sSenha)
                    clsRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

                    'Lê o arquivo
                    Dim bFile() As Byte = System.IO.File.ReadAllBytes(sCaminho)

                    'Upa o arquivo
                    Dim clsStream As System.IO.Stream = clsRequest.GetRequestStream()
                    clsStream.Write(bFile, 0, bFile.Length)
                    clsStream.Close()
                    clsStream.Dispose()

                    'Insere o arquivo no banco
                    Call oClsUsrAdmChamado.InsertArquivo(txtCodigo.Text, sNomeArquivo)

                Next

            End If

            Call oClsUsrAdmChamado.LoadGridArquivo(grdArquivos, txtCodigo.Text)
            Call oClsUsrAdmChamado.LoadGridComentario(grdComentario, txtCodigo.Text)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteArquivo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se pode excluir
            If (VerificaDireito(iFormulario, gcAdministrator) = False And txtSolicitante.Text <> goUsuario.sNome) Or _
                txtStatus.Text = "CANCELADO" Or txtStatus.Text = "CONCLUÍDO" Then
                frmMain.Informacao(Mensagem.DireitoAlteracao)
                Exit Sub
            End If

            If MsgBox("Você tem certeza de que deseja excluir este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Exclui Registro
                Call oClsUsrAdmChamado.DeleteArquivo(txtCodigo.Text,
                                                     grdArquivos.CurrentRow.Cells.Item("codigo").Value)

                'Faz a conexão com o servidor FTP
                Dim oRequest As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(sCaminhoServidor + grdArquivos.CurrentRow.Cells.Item("nome_arquivo").Value), System.Net.FtpWebRequest)
                oRequest.Credentials = New System.Net.NetworkCredential(sUsuario, sSenha)
                oRequest.Method = System.Net.WebRequestMethods.Ftp.DeleteFile

                'Executa o comando de delete
                Dim oResponse As System.Net.FtpWebResponse = oRequest.GetResponse
                oResponse.Close()

                Call oClsUsrAdmChamado.LoadGridArquivo(grdArquivos, txtCodigo.Text)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao("Registro excluído com sucesso!", Color.Blue)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarArquivo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
            Dim sCaminho As String = Path.Combine(Path.GetTempPath, grdArquivos.CurrentRow.Cells.Item("nome_arquivo").Value)

            'Faz a conexão com o servidor FTP
            Dim oRequest As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(sCaminhoServidor + grdArquivos.CurrentRow.Cells.Item("nome_arquivo").Value), System.Net.FtpWebRequest)
            oRequest.Credentials = New System.Net.NetworkCredential(sUsuario, sSenha)
            oRequest.Method = System.Net.WebRequestMethods.Ftp.DownloadFile

            'Escreve o arquivo
            Using oFTPStream As Stream = oRequest.GetResponse().GetResponseStream(),
                oFileStream As Stream = File.Create(sCaminho)
                oFTPStream.CopyTo(oFileStream)
            End Using

            'Abre o arquivo
            Process.Start(sCaminho)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridArquivo()

        Try

            Call oClsUsrAdmChamado.LoadGridArquivo(grdArquivos, txtCodigo.Text)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: COMENTÁRIO :::"

    Private Sub InserirComentario()
        Try

            Dim oForm As New frmAdmChamadoComentario
            oForm.txtTitulo.Text = txtTitulo.Text
            oForm.txtCodigoChamado.Text = txtCodigo.Text
            oForm.txtDataChamado.Text = dtpDataChamado.Value
            oForm.txtSolicitante.Text = txtSolicitante.Text

            oForm.ShowDialog()

            tabDadosChamado.SelectedTab = pagComentario
            Call oClsUsrAdmChamado.LoadGridComentario(grdComentario, txtCodigo.Text)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub VisualizarComentario()

        Try

            Dim oForm As New frmAdmChamadoComentario
            oForm.txtTitulo.Text = txtTitulo.Text
            oForm.txtCodigoChamado.Text = txtCodigo.Text
            oForm.txtDataChamado.Text = dtpDataChamado.Value
            oForm.txtSolicitante.Text = txtSolicitante.Text
            oForm.txtComentario.Text = grdComentario.CurrentRow.Cells.Item("comentario").Value
            oForm.txtComentario.ReadOnly = True : oForm.txtComentario.TabStop = False : oForm.txtComentario.BackColor = Color.WhiteSmoke

            oForm.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridComentario()

        Try

            If txtCodigo.Text <> "" Then
                Call oClsUsrAdmChamado.LoadGridComentario(grdComentario, txtCodigo.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: GRÁFICO :::"

    Private Sub cboSerie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSerie.SelectedIndexChanged
        Try
            If cboSerie.SelectedValue.ToString.ToUpper.Contains("DATA") = True Or cboSerie.Text.ToString.ToUpper.Contains("DATA") = True Then
                cboIntervalo.Visible = True
                lblIntervaloAgrupamento.Visible = True
            Else
                cboIntervalo.Visible = False
                lblIntervaloAgrupamento.Visible = False
                cboIntervalo.SelectedIndex = -1
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnGerarGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarGrafico.Click
        Try
            GerarGrafico()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub GerarGrafico()
        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboSerie, lblSerie) = False Then
                Exit Sub
            End If

            If ValidaCampo(cboEixoY, lblValorEixoY) = False Then
                Exit Sub
            End If
            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Sub
            End If

            'If cboEixoY2.SelectedIndex = -1 Then
            '    GerarGraficoDundas(chrGrafico, cboSerie.SelectedValue, cboSerie.Text, cboEixoY.SelectedValue, cboEixoY.Text, grdListagem, cboTipo.SelectedValue, cboTipo.Text, txtMeta.Value, IIf(cboIntervalo.SelectedIndex = -1, -1, cboIntervalo.SelectedValue), grpFiltro)
            'Else
            '    GerarGraficoDundasDuasSeries(chrGrafico, cboSerie.SelectedValue, cboSerie.Text, cboEixoY2.SelectedValue, cboEixoY2.Text, cboEixoY.SelectedValue, cboEixoY.Text, grdListagem, cboTipo.SelectedValue, cboTipo.Text, txtMeta.Value, IIf(cboIntervalo.SelectedIndex = -1, -1, cboIntervalo.SelectedValue), grpFiltro)
            'End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadComboIntervalo()
        Try

            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 1
            oDataRow(1) = "HORAS"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 2
            oDataRow(1) = "DIAS"


            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 3
            oDataRow(1) = "SEMANAS"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 4
            oDataRow(1) = "MESES"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 5
            oDataRow(1) = "ANOS"

            With cboIntervalo
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadComboEixoY()
        Try

            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            Dim bFlag As Boolean = False
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            If grdListagem.RecordCount = 0 Then Exit Sub

            For Each oColumn As Janus.Windows.GridEX.GridEXColumn In grdListagem.RootTable.Columns

                If oColumn.Visible = False Then Continue For

                If IsNumeric(grdListagem.GetRow(0).Cells.Item(oColumn.Key).Value) And oColumn.Caption <> "" Then

                    oDataRow = oDataSet.Tables(0).Rows.Add
                    oDataRow(0) = oColumn.Key
                    oDataRow(1) = oColumn.Caption

                End If
            Next

            With cboEixoY
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With

            Dim oDataSet2 As New DataSet
            oDataSet2 = oDataSet.Copy

            With cboEixoY2
                .DataSource = oDataSet2.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadComboSerie()
        Try

            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            For Each oColumn As Janus.Windows.GridEX.GridEXColumn In grdListagem.RootTable.Columns

                If Not IsNumeric(grdListagem.GetRow(0).Cells.Item(oColumn.Key).Value) And oColumn.Caption <> "" Then


                    oDataRow = oDataSet.Tables(0).Rows.Add
                    oDataRow(0) = oColumn.Key
                    oDataRow(1) = oColumn.Caption

                End If
            Next


            With cboSerie
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadComboTipo()
        Try

            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 1
            oDataRow(1) = "SOMA"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 2
            oDataRow(1) = "MÉDIA"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 3
            oDataRow(1) = "CONTAR"

            With cboTipo
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region


End Class
