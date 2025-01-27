Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.UI.Tab
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Assembly

Public Class usrAdmAviso

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrAdmAviso As New clsUsrAdmAviso
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()


    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: AVISO :::"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            'Carrega Grid
            Call LoadGrid()

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

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula clicada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "aceitar" : Call Aceitar(grdListagem.GetValue("codigo"), grdListagem.GetValue("usuario_aceite"))
                Case "cancelar" : Call Cancelar(grdListagem.GetValue("codigo"))
                Case "direcionar_operacao" : Call DirecionarOperacao(grdListagem.GetValue("user_control"),
                                                                     grdListagem.GetValue("descricao_formulario"),
                                                                     grdListagem.GetValue("codigo_operacao"))

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(sender As Object, e As SizingColumnEventArgs) Handles grdListagem.SizingColumn
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_ColumnMoved(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.ColumnMoved
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub



#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario


            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

            Call LoadGrid()

            'Ativa o Timer, 30seg 
            Timer1.Enabled = True

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: AVISOS :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Carrega Grid
            Call oClsUsrAdmAviso.LoadGridAviso(grdListagem)

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Aceitar(lcodigo As Long,
                        sUsuarioAceite As String)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If sUsuarioAceite <> "" Then
                MessageBox.Show("O Registro Selecionado já foi aceito, para efetuar alterações é necessário cancelar a aceitação anterior.")
                Exit Sub
            End If

            'Carrega Grid
            Call oClsUsrAdmAviso.UpdateAceitarAviso(lcodigo)

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar(lcodigo As Long)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Carrega Grid
            Call oClsUsrAdmAviso.UpdateCancelarAceite(lcodigo)

            'Carrega Grid
            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DirecionarOperacao(sUserControl As String,
                                   sDescricaoFormulario As String,
                                   lCodigoOperacao As Long)

        Try

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()


            If sUserControl = "" Or sDescricaoFormulario = "" Or lCodigoOperacao = 0 Then
                MessageBox.Show("Registro invalido, Não foi possível o direcionamento para Operação")
                Exit Sub
            End If

            'Abre o form, usando os valores presente no grid de listagem 
            oUserControl = oAssembly.CreateInstance("INTERACTI." & sUserControl)
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(lCodigoOperacao)

            frmMain.LoadPage(sDescricaoFormulario, sDescricaoFormulario, oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

#End Region


#End Region


End Class
