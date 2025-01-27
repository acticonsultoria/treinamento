Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFeVolumeLacre

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFeVolumeLacre As New clsFrmFatEmissaoNFeVolumeLacre
    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoTransporteVolume As Integer
    Private bAllowSave As Boolean

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

    Public Property CodigoEmissaoTransporteVolume() As Integer
        Get
            Return iCodigoEmissaoTransporteVolume
        End Get
        Set(ByVal value As Integer)
            iCodigoEmissaoTransporteVolume = value
        End Set
    End Property

    Public Property AllowSave() As Boolean
        Get
            Return bAllowSave
        End Get
        Set(ByVal value As Boolean)
            bAllowSave = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEmissaoNFeVolumeLacre_Load(sender As Object, e As EventArgs) Handles Me.Load

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

            'Seta Propriedade do Controle
            btnInserir.Enabled = bAllowSave
            btnExcluir.Enabled = bAllowSave

            'Carrega Grid
            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica Direito
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcUpdate) = True Then

                'Carrega Controles
                txtLacre.Text = grdLacre.CurrentRow.Cells("lacre").Value
                btnInserir.Tag = grdLacre.CurrentRow.RowIndex

                'Seta Focu
                txtLacre.Focus()

            Else
                'Informa o Usuário - Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
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
                    Call oClsFatEmissaoNFeVolumeLacre.Delete(lCodigoEmissaoCapa, _
                                                            iCodigoEmissaoTransporteVolume)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

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
            oClsFatEmissaoNFeVolumeLacre.LoadGrid(grdLacre, _
                                                 lCodigoEmissaoCapa, _
                                                 iCodigoEmissaoTransporteVolume)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Controles
            txtLacre.Text = ""
            btnInserir.Tag = ""

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
                oClsFatEmissaoNFeVolumeLacre.Insert(lCodigoEmissaoCapa, _
                                                   iCodigoEmissaoTransporteVolume, _
                                                   txtLacre.Text.Trim)

            Else

                'Atualiza Lacre
                oClsFatEmissaoNFeVolumeLacre.Update(lCodigoEmissaoCapa, _
                                                   iCodigoEmissaoTransporteVolume, _
                                                   txtLacre.Text.Trim, _
                                                   grdLacre.CurrentRow.Cells("lacre").Value)

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

            'Verifica se o Lote informado é Válido
            If IsNumeric(btnInserir.Tag) Then
                If VerificaExisteValorGrid(grdLacre, "lacre", txtLacre.Text.Trim, grdLacre.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblLacre, "Este Lacre: " & txtLacre.Text.Trim & " já está associado a outro registro.")
                    txtLacre.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdLacre, "lacre", txtLacre.Text.Trim) = True Then
                    frmMain.errInfo.SetError(lblLacre, "Este Lacre: " & txtLacre.Text.Trim & " já está associado a outro registro.")
                    txtLacre.Focus()
                    Exit Function
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