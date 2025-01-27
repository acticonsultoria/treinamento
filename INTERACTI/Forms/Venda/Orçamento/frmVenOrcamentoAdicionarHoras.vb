Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoAdicionarHoras

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lCodigo As Long
    Private oClsVenOrcamento As New clsUsrVenOrcamento

#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenOrcamentoHistorico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenOrcamentoHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdHoras.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdHoras.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdHoras.GroupByBoxVisible = True
                grdHoras.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            Dim oForm As New frmCfgGrid

            oForm.Grid = grdHoras
            oForm.NomeFormulario = Formulario.ComercialOrcamento
            oForm.ShowDialog(Me)

            ConfiguraGrid(grdHoras, Formulario.ComercialOrcamento)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            ExportExcel(grdHoras)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHoras.ColumnMoved

        Try

            UpdateConfiguraGrid(grdHoras, _
                                Formulario.ComercialOrcamento)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHoras.SizingColumn

        Try

            UpdateConfiguraGrid(grdHoras.Name, _
                                Formulario.ComercialOrcamento, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdHistorico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdHoras.GroupsChanging

        Try

            UpdateConfiguraGridGrupo(grdHoras.Name, _
                                     Formulario.ComercialOrcamento, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Inserir()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try

            Excluir()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdHoras_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdHoras.RowDoubleClick

        Try

            If IsNothing(grdHoras.CurrentColumn) Then Exit Sub

            Select Case grdHoras.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
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
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenOrcamentoHistorico_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            'Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            ConfiguraGrid(grdHoras, Formulario.ComercialOrcamento)

            oClsVenOrcamento.LoadDadosHoras(lCodigo, _
                                            txtNumeroOrcamento, _
                                            txtDataOrcamento, _
                                            txtCliente)

            oClsVenOrcamento.LoadGridHoras(grdHoras, _
                                           lCodigo)

            dtpData.Value = Now

            dtpData.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If txtQuantidadeHoras.Value <= 0 Then
                frmMain.errInfo.SetError(lblQuantidadeHoras, "O Campo Quantidade Horas não pode ser menor ou igual a 0. Digite um valor para ele.")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Novo()

        Try

            dtpData.Value = Now
            txtQuantidadeHoras.Value = 0
            txtObservacao.Text = ""
            btnInserir.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Inserir()

        Try

            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnInserir.Tag) Then

                oClsVenOrcamento.UpdateHoras(lCodigo, _
                                             btnInserir.Tag, _
                                             dtpData.Value, _
                                             txtQuantidadeHoras.Value, _
                                             txtObservacao.Text.Trim)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsVenOrcamento.InsertHoras(lCodigo, _
                                             dtpData.Value, _
                                             txtQuantidadeHoras.Value, _
                                             txtObservacao.Text.Trim)

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            Novo()

            oClsVenOrcamento.LoadGridHoras(grdHoras, _
                                           lCodigo)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Excluir()

        Try

            If VerificaSelecaoRow(grdHoras) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    oClsVenOrcamento.DeleteHoras(lCodigo)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            Novo()

            With grdHoras.CurrentRow.Cells

                dtpData.Value = .Item("data").Value
                txtQuantidadeHoras.Value = .Item("quantidade_horas").Value
                txtObservacao.Text = .Item("observacao").Value
                btnInserir.Tag = .Item("codigo").Value

            End With

            dtpData.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class