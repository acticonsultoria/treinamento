Imports System.Xml
Imports System.IO

Public Class frmAdmConfigXML

#Region "::: CONTROLES :::"

    Private Sub frmAdmConfigXML_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarXML.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call GerarArquivoXML()

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Fecha Tela
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnRelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorio.Click

        Try

            'Váriaveis Locais
            Dim oRelatorio As New FolderBrowserDialog

            'Verifica se foi Selecionado alguma Pasta
            If oRelatorio.ShowDialog = DialogResult.OK Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Seta Arquivo
                txtRelatorio.Text = oRelatorio.SelectedPath & "\"

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPreconfiguracao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPreconfiguracao.SelectedIndexChanged
        Try

            Try
                Dim oXMLDocument As New XmlDocument
                oXMLDocument.Load(ApplicationPath() & "XmlConfig\configuracao.xml")

             
                For Each oNode As XmlNode In oXMLDocument.GetElementsByTagName("ConfigDatabase")

                    If oNode("Nome").InnerText = cboPreconfiguracao.SelectedValue Then

                        txtNomeServidor.Text = oNode("DataSource").InnerText
                        txtBancoDados.Text = oNode("InitialCatalog").InnerText
                        txtUsuario.Text = oNode("UserID").InnerText
                        txtSenha.Text = oNode("Password").InnerText
                        Exit Sub
                    End If

                Next
             
            Catch ex As Exception

            End Try
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Carrega Controles
            txtRelatorio.Text = goCrystalReport.sPath
            txtNomeServidor.Text = goDatabase.sDataSource
            txtUsuario.Text = goDatabase.sUserID
            txtSenha.Text = goDatabase.sPassword
            txtBancoDados.Text = goDatabase.sInitialCatalog

            'Verifica Direito
            If Not goDatabase.sConnection Is Nothing And TesteConection(goDatabase.sConnection) = True Then
                btnGerarXML.Enabled = VerificaDireito(Formulario.AdministracaoConfiguracaoInteracti, gcInsert)
            End If

            Try
                Dim oXMLDocument As New XmlDocument
                oXMLDocument.Load(ApplicationPath() & "XmlConfig\configuracao.xml")

                Dim oDataSet As New DataSet
                oDataSet.Tables.Add("main")

                oDataSet.Tables(0).Columns.Add("codigo").DataType = "".GetType
                oDataSet.Tables(0).Columns.Add("descricao").DataType = "".GetType

                For Each oNode As XmlNode In oXMLDocument.GetElementsByTagName("ConfigDatabase")

                    Dim oDataRow As DataRow = oDataSet.Tables(0).Rows.Add
                    oDataRow("codigo") = oNode("Nome").InnerText
                    oDataRow("descricao") = oNode("Nome").InnerText

                Next
                'Carrega Grid
                With cboPreconfiguracao

                    .DataSource = oDataSet.Tables(0)
                    .ValueMember = "CODIGO"
                    .DisplayMember = "DESCRICAO"

                End With
            Catch ex As Exception

            End Try
            

            'Seta Focu
            btnRelatorio.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub GerarArquivoXML()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Arquivo Existe
            If File.Exists(ApplicationPath() & "XmlConfig\Config.xml") Then
                File.Delete(ApplicationPath() & "XmlConfig\Config.xml")
            End If

            'Verifica se a Pasta Existe
            If Directory.Exists(ApplicationPath() & "XmlConfig") = False Then
                Directory.CreateDirectory(ApplicationPath() & "XmlConfig")
            End If

            Dim oXmlTextWriter As New XmlTextWriter(ApplicationPath() & "XmlConfig\Config.xml", Nothing)

            'Inicia o Documento Xml
            oXmlTextWriter.WriteStartDocument()

            'Define a Indentação do Arquivo
            oXmlTextWriter.Formatting = Formatting.Indented

            'Escreve o Elmento Raiz - Interacti
            oXmlTextWriter.WriteStartElement("Interacti")

            'Escreve o Elmento Raiz - ConfigDatabase
            oXmlTextWriter.WriteStartElement("ConfigDatabase")

            'Escreve os Sub-Elementos
            oXmlTextWriter.WriteElementString("StringConnection", "Password=" & txtSenha.Text.Trim & ";" & _
                                                                  "Persist Security Info=True;" & _
                                                                  "User ID=" & txtUsuario.Text.Trim & ";" & _
                                                                  "Initial Catalog=" & txtBancoDados.Text.Trim & ";" & _
                                                                  "Data Source=" & txtNomeServidor.Text.Trim & ";" & _
                                                                  "Connect Timeout = 999;")
            oXmlTextWriter.WriteElementString("DataSource", txtNomeServidor.Text.Trim)
            oXmlTextWriter.WriteElementString("InitialCatalog", txtBancoDados.Text.Trim)
            oXmlTextWriter.WriteElementString("UserID", txtUsuario.Text.Trim)
            oXmlTextWriter.WriteElementString("Password", txtSenha.Text.Trim)

            'Encerra o Elemento Raiz = ConfigDatabase
            oXmlTextWriter.WriteEndElement()

            'Escreve o Elmento Raiz - Report
            oXmlTextWriter.WriteStartElement("Report")

            oXmlTextWriter.WriteElementString("Path", txtRelatorio.Text.Trim)

            'Encerra o Elemento Raiz = Report
            oXmlTextWriter.WriteEndElement()

            'Encerra o Elemento Raiz = Interacti
            oXmlTextWriter.WriteEndElement()

            'Escreve o XML para o arquivo e fecha o objeto escritor
            oXmlTextWriter.Close()

            'Seta Váriaveis
            goDatabase.sConnection = "Password=" & txtSenha.Text.Trim & ";" & _
                                     "Persist Security Info=True;" & _
                                     "User ID=" & txtUsuario.Text.Trim & ";" & _
                                     "Initial Catalog=" & txtBancoDados.Text.Trim & ";" & _
                                     "Data Source=" & txtNomeServidor.Text.Trim & ";" & _
                                     "Connect Timeout = 999;"
            goDatabase.sDataSource = txtNomeServidor.Text.Trim
            goDatabase.sUserID = txtUsuario.Text.Trim
            goDatabase.sPassword = txtSenha.Text.Trim
            goDatabase.sInitialCatalog = txtBancoDados.Text.Trim
            goCrystalReport.sPath = txtRelatorio.Text.Trim

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

            'Verifica se foi Preenchido o Campo - Relatório
            If ValidaCampo(txtRelatorio, lblRelatorio, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nome Servidor
            If ValidaCampo(txtNomeServidor, lblNomeServidor, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Usuário
            If ValidaCampo(txtUsuario, lblUsuario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Banco de Dados
            If ValidaCampo(txtBancoDados, lblBancoDados, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Testa Conexão
            If TesteConection("Password=" & txtSenha.Text.Trim & ";" & _
                              "Persist Security Info=True;" & _
                              "User ID=" & txtUsuario.Text.Trim & ";" & _
                              "Initial Catalog=" & txtBancoDados.Text.Trim & ";" & _
                              "Data Source=" & txtNomeServidor.Text.Trim & ";") = False Then
                'Abre Formulário de Configuração
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi possível conectar ao Banco de Dados informado.")
                txtBancoDados.Focus()
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
