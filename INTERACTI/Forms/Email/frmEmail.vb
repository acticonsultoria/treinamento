Imports Janus.Windows.GridEX

Public Class frmEmail

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lCodigoParceiroNegocio As Long
    Private sTo As String
    Private sCc As String
    Private sBCc As String
    Private sSubject As String
    Private sAnexo As String
    Private sAnexoPath As String
    Private sBody As String
    Private lCodigoEmissaoCapa As Long
    Private lCodigoPedidoCompra As Long
    Private iCodigoTipoEmail As Integer = -1
    Private bEnvioDireto As Boolean = False

#End Region

#Region "::: PROPERTIE :::"
    Public Property EnvioDireto As Boolean
        Get
            Return bEnvioDireto
        End Get
        Set(ByVal value As Boolean)
            bEnvioDireto = value
        End Set
    End Property
    Public Property CodigoParceiroNegocio() As Long
        Get
            Return lCodigoParceiroNegocio
        End Get
        Set(ByVal value As Long)
            lCodigoParceiroNegocio = value
        End Set
    End Property

    Public Property Para() As String
        Get
            Return sTo
        End Get
        Set(ByVal value As String)
            sTo = value
        End Set
    End Property

    Public Property Cc() As String
        Get
            Return sCc
        End Get
        Set(ByVal value As String)
            sCc = value
        End Set
    End Property

    Public Property BCc() As String
        Get
            Return sBCc
        End Get
        Set(ByVal value As String)
            sBCc = value
        End Set
    End Property

    Public Property Subject() As String
        Get
            Return sSubject
        End Get
        Set(ByVal value As String)
            sSubject = value
        End Set
    End Property

    Public Property Body() As String
        Get
            Return sBody
        End Get
        Set(ByVal value As String)
            sBody = value
        End Set
    End Property

    Public Property Anexo() As String
        Get
            Return sAnexo
        End Get
        Set(ByVal value As String)
            sAnexo = value
        End Set
    End Property

    Public Property AnexoPath() As String
        Get
            Return sAnexoPath
        End Get
        Set(ByVal value As String)
            sAnexoPath = value
        End Set
    End Property

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property CodigoPedidoCompra() As Long
        Get
            Return lCodigoPedidoCompra
        End Get
        Set(ByVal value As Long)
            lCodigoPedidoCompra = value
        End Set
    End Property

    Public Property CodigoTipoEmail() As Integer
        Get
            Return iCodigoTipoEmail
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoEmail = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmEmail_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmEmail_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnCadastrarTextoEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTextoEmail.Click

        Try
            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTextoEmail")
           
            'Carrega Combo
            Call LoadCombo(cboEmail, "sp_select_combo_cadastro_basico_texto_email " & goUsuario.iEmpresa & ", " & iCodigoTipoEmail, False)

            'Seta Focu
            cboEmail.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click

        Try

            Enviar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPara.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmEmailContato

            'Seta Parâmetros
            oForm.CodigoParceiroNegocio = lCodigoParceiroNegocio
            oForm.Formulario = Me

            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCC.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmEmailContato

            'Seta Parâmetros
            oForm.CodigoParceiroNegocio = lCodigoParceiroNegocio
            oForm.Formulario = Me

            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnBcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBcc.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmEmailContato

            'Seta Parâmetros
            oForm.CodigoParceiroNegocio = lCodigoParceiroNegocio
            oForm.Formulario = Me

            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexo.Click

        Try

            'Variaveis Locais
            Dim oFile As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            oFile.InitialDirectory = "c:\\dados"
            oFile.Title = "Selecione o Arquivo"

            If oFile.ShowDialog() = DialogResult.OK Then
                txtAnexo.Text = txtAnexo.Text & IIf(txtAnexo.Text = "", "", "; ") & oFile.FileName
                txtAnexo.Tag = txtAnexo.Tag & IIf(txtAnexo.Tag = "", "", "; ") & oFile.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboEmail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmail.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum E-mail
            If cboEmail.SelectedIndex > -1 Then
                'Preenche Controle
                LoadDescricao(txtBody, "sp_select_cadastro_basico_texto_email_texto " & cboEmail.SelectedValue & ", " & goUsuario.iEmpresa & ",'" & goUsuario.sNome & "'," & lCodigoPedidoCompra & ", " & lCodigoEmissaoCapa)
                txtBcc.Text &= IIf(txtBcc.Text = "", "", IIf(txtBcc.Text.PadRight(1) = ";" Or txtBcc.Text.PadRight(1) = ",", "", ";"))
                txtBcc.Text &= LoadDescricao("sp_select_cadastro_basico_texto_email_copia_lista " & cboEmail.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"
    Private Sub Enviar()

        Try

        
        'Valida Dados do E-mail
        If Validacao() = True Then

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Obtem Parâmetros
            Dim sPara() As String = txtPara.Text.Replace(";", ",").Split(",")
            Dim sCc() As String = txtCC.Text.Replace(";", ",").Split(",")
            Dim sBCc() As String = txtBCc.Text.Replace(";", ",").Split(",")
            Dim sAnexo() As String = txtAnexo.Tag.Replace(";", ",").Split(",")

            'Envia E-mail
            Call SendEmail(sPara, _
                           sCc, _
                           sBCc, _
                           txtAssunto.Text, _
                           txtBody.Text, _
                           sAnexo)

            'Verifica se é uma Nota Fiscal Eletrônica
            If lCodigoEmissaoCapa <> -1 Then
                'Atauliza o Status - Faturamento
                Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe
                oClsFatEmissaoNFe.UpdateStatusNotaFiscal(lCodigoEmissaoCapa, _
                                                         StatusNotaFiscalEletronica.EnviadoDestinatario)
            End If

            If lCodigoPedidoCompra <> -1 Then
                'Atualiza Status do Pedido de Compra
                Dim oClsCmpPedido As New clsUsrCmpPedido
                oClsCmpPedido.Email(lCodigoPedidoCompra, _
                                    "E-MAIL COM O PEDIDO DE COMPRA ENVIADO PARA: " & txtPara.Text & "." & _
                                    IIf(txtCC.Text.Trim <> "", vbCrLf & "COM CÓPIA PARA: " & txtCC.Text & ".", "") & _
                                    IIf(txtBcc.Text.Trim <> "", vbCrLf & "COM CÓPIA OCULTA PARA: " & txtBcc.Text & ".", ""))
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha Formulário
            Me.Dispose()

        End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            If lCodigoPedidoCompra <> -1 Then
                iCodigoTipoEmail = TipoEmailDestino.PedidoCompra
            ElseIf lCodigoEmissaoCapa <> -1 Then
                iCodigoTipoEmail = TipoEmailDestino.EmissaoNotaFiscal
            End If

            'Carrega Combo
            Call LoadCombo(cboEmail, "sp_select_combo_cadastro_basico_texto_email " & goUsuario.iEmpresa & ", " & iCodigoTipoEmail, False)

            'Carrega Dados do E-mail
            txtPara.Text = sTo
            txtAssunto.Text = sSubject
            txtBody.Text = sBody
            txtCC.Text = sCc
            txtBcc.Text = sBCc
            txtAnexo.Text = sAnexo
            txtAnexo.Tag = sAnexoPath

            If bEnvioDireto = True Then
                Enviar()
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
                Me.Dispose()
            End If

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

            'Verifica se foi Preenchido o Campo - Para
            If ValidaCampo(txtPara, txtPara, TipoCampo.texto) = False Then
                Exit Function
            End If

            If bEnvioDireto = False Then
                'Carrega Configuração do E-mail
                Call LoadConfiguracaoEmail()
            End If
            'Verifica se o E-mail foi configurado
            If goEmail.sEmail = "" Then
                MsgBox("Você não possui E-mail configurado. Contate o Administrador do sistema.", vbInformation, Me.Text)
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