Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.IO

Public Class usrCstControle

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCstControle As New clsUsrCstControle
    Private lCodigo As Long

#End Region

#Region "::: CONTROLES :::"

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Try
            Call LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

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

    Private Sub usr_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoMaquinaEquipamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoMaquinaEquipamento)

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
            'Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)



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

                Case "visualizar" : Visualizar(grdListagem.GetValue("codigo"))
                Case "finalizar" : Finalizar(grdListagem.GetValue("codigo"))
                Case "bloquear" : Bloquear(grdListagem.GetValue("codigo"))
                Case "desbloquear" : Desbloquear(grdListagem.GetValue("codigo"))
                Case "email" : Email()
                Case "custeio_horas_mensais" : CusteioHorasMensais()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn, _
                                                                                                                        grdMovimentacao.SizingColumn, _
                                                                                                                        grdEstoque.SizingColumn


        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender.Name, _
                                     Formulario.CadastroBasicoMaquinaEquipamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved, _
                                                                                                                        grdMovimentacao.ColumnMoved, _
                                                                                                                        grdEstoque.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(CType(sender, GridEX), _
                                     Formulario.CadastroBasicoMaquinaEquipamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging, _
                                                                                                                grdMovimentacao.GroupsChanging, _
                                                                                                                grdEstoque.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(sender.name, _
                                          Formulario.CadastroBasicoMaquinaEquipamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel2_Click(sender As Object, e As EventArgs) Handles btnExcel2.Click
        Try
            If tabDados.SelectedTab.Key = pagEstoque.Key Then
                ExportExcel(grdEstoque)
            ElseIf tabDados.SelectedTab.Key = pagMovimentacao.Key Then
                ExportExcel(grdMovimentacao)
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString.ToString)
        End Try
    End Sub

    Private Sub grdMovimentacao_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdMovimentacao.CellUpdated

        Try

            Cursor.Current = Cursors.WaitCursor

            Select Case e.Column.Key

                Case "data_movimentacao"

                    If ValidacaoDataCusteio(grdMovimentacao.CurrentRow.Cells("data_movimentacao").Value) = False Then
                        Exit Select
                    End If

                    Call oClsUsrCstControle.UpdateDataMovimentacao(lCodigoMovimentacao:=grdMovimentacao.CurrentRow.Cells("codigo_movimentacao").Value, _
                                                                   sDataMovimentacao:=grdMovimentacao.CurrentRow.Cells("data_movimentacao").Value)

                Case "observacao"

                    Call oClsUsrCstControle.UpdateEstoqueObservacao(lCodigoMovimentacao:=grdMovimentacao.CurrentRow.Cells("codigo_movimentacao").Value, _
                                                                   sObservacao:=grdMovimentacao.CurrentRow.Cells("observacao").Value)


            End Select

            Call oClsUsrCstControle.LoadDadosCenario(grdEstoque, _
                                                     grdMovimentacao, _
                                                     lCodigo, _
                                                     0)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            btnExcelGrid.Enabled = VerificaDireito(Formulario.ApontamentoCusto, gcPrint)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoMaquinaEquipamento)
            Call ConfiguraGrid(grdEstoque, Formulario.CadastroBasicoMaquinaEquipamento)
            Call ConfiguraGrid(grdMovimentacao, Formulario.CadastroBasicoMaquinaEquipamento)


            'Carrega os dados
            LoadGrid()


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Bloquear(ByVal lCodigo As Long)
        Try

            'Verifica se está bloqueado
            If IsDBNull(grdListagem.GetValue("data_bloqueio")) = False Then

                frmMain.Informacao("Não é possível bloquear pois o custeio encontra-se bloqueado!", Color.Red)
                Exit Sub

            End If

            'Verifica se está finalizado
            If IsDBNull(grdListagem.GetValue("data_finalizacao")) = True Then

                frmMain.Informacao("Para bloquear um custeio, é necessário finalizá-lo antes!", Color.Red)
                Exit Sub
            End If

            'Questiona o usuário
            If MsgBox("Deseja bloquear o custeio? Qualquer ação neste mês será bloqueada (apontamentos, pagamentos de material, entrada de NF). Deseja continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Validar bloqueio") = vbNo Then Exit Sub

            'Executa a query
            ExecuteQuery("sp_update_custo_bloqueio " & lCodigo & "," & goUsuario.iEmpresa & "," & goUsuario.iUsuario)

            'Carrega a grid
            LoadGrid()

            'Informa o usuário
            frmMain.Informacao("Custeio bloqueado com sucesso!", Color.Blue)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Finalizar(ByVal lCodigo As Long)
        Try

            'Só pode processar se ainda estiver desbloqueado
            If IsDBNull(grdListagem.GetValue("data_bloqueio")) Then


                'Questiona o usuário
                If MsgBox("Deseja finalizar o custeio? os dados do mês atual serão reprocessados!", vbQuestion + MsgBoxStyle.YesNo) = vbNo Then Exit Sub

                Cursor.Current = Cursors.WaitCursor

                'Executa o reprocessamento
                ExecuteQuery("sp_insert_custo_finalizar " & goUsuario.iEmpresa & "," & lCodigo)

                'Carrega os dados novamente
                LoadGrid()

                Cursor.Current = Cursors.Default

                'Informa o usuário
                frmMain.Informacao("Custeio reprocessado com sucesso!", Color.Blue)

            Else
                frmMain.Informacao("Não é possível reprocessar o custeio pois ele está bloqueado!", Color.Red)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Desbloquear(ByVal lCodigo As Long)
        Try

            'Verifica se está bloqueado
            If IsDBNull(grdListagem.GetValue("data_bloqueio")) = True Then

                frmMain.Informacao("Não é possível desbloquear pois o custeio ainda está aberto!", Color.Red)
                Exit Sub

            End If


            'Questiona o usuário
            If MsgBox("Deseja desbloquear o custeio? Se algum valor for alterado, será necessário reenviar para a contabilidade os novos estoques.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Validar bloqueio") = vbNo Then Exit Sub

            'Executa a query
            ExecuteQuery("sp_update_custo_desbloqueio " & lCodigo & "," & goUsuario.iEmpresa & "," & goUsuario.iUsuario)

            'Carrega a grid
            LoadGrid()

            'Informa o usuário
            frmMain.Informacao("Custeio desbloqueado com sucesso!", Color.Blue)



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Visualizar(ByVal lCodigoCenario As Long)

        Try

            Cursor.Current = Cursors.WaitCursor

            lCodigo = lCodigoCenario

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoMaquinaEquipamento, gcUpdate) = True Then

                oClsUsrCstControle.LoadDadosCenario(grdEstoque, _
                                                   grdMovimentacao, _
                                                   lCodigo, _
                                                   1)


                'Seta Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)



            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
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
            Call oClsUsrCstControle.LoadGrid(grdListagem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Email()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCstControle.LoadEmail(grdListagem.CurrentRow.Cells("estoque_mp").Value, _
                                         grdListagem.CurrentRow.Cells("estoque_elaboracao").Value, _
                                         grdListagem.CurrentRow.Cells("estoque_acabados").Value, _
                                         grdListagem.CurrentRow.Cells("data").Value)

            EnviarEmail(oClsUsrCstControle.Assunto, _
                        oClsUsrCstControle.Destinatario, _
                        "", _
                        "", _
                        oClsUsrCstControle.Cabecalho, _
                        -1)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CusteioHorasMensais()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oForm As New frmCstCusteioHorasMensais

            oForm.Codigo = grdListagem.CurrentRow.Cells("codigo").Value
            oForm.Data = grdListagem.CurrentRow.Cells("data").Value

            oForm.ShowDialog(Me)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
