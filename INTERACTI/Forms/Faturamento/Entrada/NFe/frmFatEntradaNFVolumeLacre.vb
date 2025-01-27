Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFVolumeLacre

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEntradaNF As New clsUsrFatEntradaNF

    Private lCodigoEntradaCapa As Long
    Private iCodigoEntradaTransporteVolume As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public WriteOnly Property CodigoEntradaTransporteVolume() As Integer
        Set(ByVal value As Integer)
            iCodigoEntradaTransporteVolume = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFVolumeLacre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEntradaNFVolumeLacre_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Limpa Formulário
                Call Novo()
                'Carrega Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Reboque
            Call Excluir()
            'Limpa Formulário
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdLacre_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLacre.DoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdLacre.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdLacre.CurrentColumn.Key

                Case "editar" : Call Editar()
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEntradaNFVolumeLacre_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Grid
            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Excluir()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdLacre) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEntradaNF.DeleteLacre(lCodigoEntradaCapa, iCodigoEntradaTransporteVolume)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Limpa Formulário
                    Call Novo()

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Carrega Grid
            Call oClsFatEntradaNF.LoadGridLacre(grdLacre, lCodigoEntradaCapa, iCodigoEntradaTransporteVolume)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtLacre.Text = ""
            btnInserir.Tag = ""

            'Seta Focu
            txtLacre.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Controles
            txtLacre.Text = grdLacre.CurrentRow.Cells("lacre").Value
            btnInserir.Tag = grdLacre.CurrentRow.RowIndex
            txtLacre.Focus()


            'Seta Focu
            txtLacre.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) = False Then

                'Insere Lacre
                oClsFatEntradaNF.InsertLacre(lCodigoEntradaCapa, iCodigoEntradaTransporteVolume, txtLacre.Text.Trim)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Atualiza Lacre
                oClsFatEntradaNF.UpdateLacre(lCodigoEntradaCapa, iCodigoEntradaTransporteVolume, txtLacre.Text.Trim, grdLacre.CurrentRow.Cells("lacre").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Número do Lacre
            If ValidaCampo(txtLacre, lblLacre, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o número do Lacre já foi preenchido
            Dim oRow() As GridEXRow = grdLacre.GetDataRows
            Dim i As Integer

            For i = 0 To UBound(oRow)
                If oRow(i).Cells("lacre").Value = txtLacre.Text.Trim And txtLacre.Text.Trim <> btnInserir.Tag.ToString Then
                    frmMain.errInfo.SetError(lblLacre, "Este Lacre: " & txtLacre.Text.Trim & " já está associado a outro registro.")
                    txtLacre.Focus()
                    Exit Function
                End If
            Next

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class