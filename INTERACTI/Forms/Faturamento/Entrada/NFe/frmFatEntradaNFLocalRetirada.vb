Public Class frmFatEntradaNFLocalRetirada

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEntradaNFLocalRetirada As New clsFrmFatEntradaNFeLocalRetirada
    Private lCodigoEntradaCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFeLocalRetirada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                                 txtCNPJ.KeyUp


        Try

            Select Case e.KeyCode

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCNPJ" : Call btnProcurarParceiroNegocio_Click(btnProcurarParceiroNegocio, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEntradaNFeLocalRetirada_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFatEntradaNFeLocalRetirada_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnProcurarParceiroNegocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarParceiroNegocio.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            iCodigoTipoParceiroNegocioFind = -1
            sRetornoParceiroNegocio = "CNPJ"
            oMaskedEditBoxFind = txtCNPJ
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtCNPJ.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
                'Fecha o Formulário
                Me.Dispose()

            End If

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

    Private Sub cboUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUF.SelectedIndex = -1 Then
                cboMunicipio.DataSource = Nothing : cboMunicipio.Text = "" : cboMunicipio.Enabled = False
            Else
                'Carrega Combo
                cboMunicipio.Enabled = True
                Call LoadCombo(cboMunicipio, "sp_select_combo_static_municipio '" & cboUF.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub txtCNPJ_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.TextChanged

        Try

            'Carrega Dados do CNPJ
            If txtCNPJ.Text.Trim <> "" Then

                'Carrega Controles
                Call oClsFatEntradaNFLocalRetirada.LoadControlesCNPJ(txtCNPJ.Text.Trim, _
                                                                    txtLogradouro, _
                                                                    txtNumero, _
                                                                    txtComplemento, _
                                                                    txtBairro, _
                                                                    cboUF, _
                                                                    cboMunicipio)

            End If

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

            'Seta Focu
            txtCNPJ.Focus()

            'Carrega Combo de Pais
            Call LoadCombo(cboUF, "sp_select_combo_static_estado")

            'Carrega Controles
            Call LoadControles()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadControles()

        Try

            'Carrega Controles
            Call oClsFatEntradaNFLocalRetirada.LoadControles(lCodigoEntradaCapa, _
                                                            txtCNPJ, _
                                                            txtLogradouro, _
                                                            txtNumero, _
                                                            txtComplemento, _
                                                            txtBairro, _
                                                            cboUF, _
                                                            cboMunicipio)

            'Seta Focu
            txtCNPJ.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsFatEntradaNFLocalRetirada.CNPJ = txtCNPJ.Text.Trim
            oClsFatEntradaNFLocalRetirada.Logradouro = txtLogradouro.Text.Trim
            oClsFatEntradaNFLocalRetirada.Numero = txtNumero.Text.Trim
            oClsFatEntradaNFLocalRetirada.Complemento = txtComplemento.Text.Trim
            oClsFatEntradaNFLocalRetirada.Bairro = txtBairro.Text.Trim
            oClsFatEntradaNFLocalRetirada.UF = IIf(cboUF.SelectedIndex = -1, -1, cboUF.SelectedValue)
            oClsFatEntradaNFLocalRetirada.CodigoMunicipio = IIf(cboMunicipio.SelectedIndex = -1, -1, cboMunicipio.SelectedValue)
            oClsFatEntradaNFLocalRetirada.CodigoEntradaCapa = lCodigoEntradaCapa

            'Salva o Luga de Retirada
            oClsFatEntradaNFLocalRetirada.Salvar()
            frmMain.Informacao(Mensagem.RegistroSalvo)

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

            'Verifica se foi Preenchido o Campo - CNPJ
            If ValidaCampo(txtCNPJ, lblCNPJ, TipoCampo.texto) = False Then
                Exit Function
            ElseIf ValidaCNPJ(txtCNPJ.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCNPJ, "Este CNPJ: " & txtCNPJ.Text.Trim & " não é válido.")
                txtCNPJ.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouro, lblLogradouro, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumero, lblNumero, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Bairro
            If ValidaCampo(txtBairro, lblBairro, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUF, lblUF) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Municipio
            If ValidaCampo(cboMunicipio, lblMunicipio) = False Then
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
