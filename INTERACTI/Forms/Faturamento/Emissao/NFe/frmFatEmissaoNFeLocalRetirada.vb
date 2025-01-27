Public Class frmFatEmissaoNFeLocalRetirada

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEmissaoNFeLocalRetirada As New clsFrmFatEmissaoNFeLocalRetirada
    Private lCodigoEmissaoCapa As Long

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

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEmissaoNFeLocalRetirada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter : Call Control_Enter(sender)

                Case Keys.Escape : Me.Dispose()

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "txtCNPJ"
                            Call btnProcurarParceiroNegocio_Click(btnProcurarParceiroNegocio, System.EventArgs.Empty)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeLocalRetirada_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

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

        'Limpa Erro
        frmMain.errInfo.Clear()

        'Valida Dados do Formulário
        If Validacao() = True Then

            'Salva Dados do Registro
            Call Salvar()
            'Fecha o Formulário
            Me.Dispose()

        End If

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

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
                Call oClsFatEmissaoNFeLocalRetirada.LoadControlesCNPJ(txtCNPJ.Text.Trim, _
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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeLocalRetirada_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

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

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsFatEmissaoNFeLocalRetirada.CNPJ = txtCNPJ.Text.Trim
            oClsFatEmissaoNFeLocalRetirada.Logradouro = txtLogradouro.Text.Trim
            oClsFatEmissaoNFeLocalRetirada.Numero = txtNumero.Text.Trim
            oClsFatEmissaoNFeLocalRetirada.Complemento = txtComplemento.Text.Trim
            oClsFatEmissaoNFeLocalRetirada.Bairro = txtBairro.Text.Trim
            oClsFatEmissaoNFeLocalRetirada.UF = cboUF.SelectedValue
            oClsFatEmissaoNFeLocalRetirada.Municipio = cboMunicipio.SelectedValue
            oClsFatEmissaoNFeLocalRetirada.CodigoEmissaoCapa = lCodigoEmissaoCapa

            'Verifica o Tipo de Operação
            oClsFatEmissaoNFeLocalRetirada.Delete()
            oClsFatEmissaoNFeLocalRetirada.Insert()
            frmMain.Informacao(Mensagem.RegistroInserido)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

    Private Sub LoadControles()

        Try

            'Carrega Controles
            Call oClsFatEmissaoNFeLocalRetirada.LoadControles(lCodigoEmissaoCapa, _
                                                    txtCNPJ, _
                                                    txtLogradouro, _
                                                    txtNumero, _
                                                    txtComplemento, _
                                                    txtBairro, _
                                                    cboUF, _
                                                    cboMunicipio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
