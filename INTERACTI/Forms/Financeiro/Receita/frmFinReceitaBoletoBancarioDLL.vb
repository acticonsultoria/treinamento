Imports Janus.Windows.GridEX
Imports BoletoNet
Imports System.Text
Imports System.IO
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Threading
Imports System.Net.Mail
Imports System.Net.Mime
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports ImagePDF
Imports CrystalDecisions.CrystalReports.Engine
'Imports Pdfizer
Public Class frmFinReceitaBoletoBancarioDLL

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sNumeroDocumento As String
    Private sCliente As String
    Private lCodigoTituloCapa As Long
    Private iNumeroParcela As Integer
    Private oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
    Private sArquivo As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return sCliente
        End Get
        Set(ByVal value As String)
            sCliente = value
        End Set
    End Property

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinReceitaGerarBoleto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor
                    Select Case sender.Name
                        Case "cboContaBancaria" : Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
                    End Select
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.Name
                        Case "cboContaBancaria" : Call btnCadastrarContaBancaria_Click(btnCadastrarContaBancaria, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFinReceitaGerarBoleto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnCadastrarContaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaBancaria.Click

        Try

             'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadBancoConta")

            'Carrega Combo            
            LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaBancaria.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboContaBancariaFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboContaBancaria.SelectedIndexChanged

        Try

            'Carrega Grid de Boleto Bancário
            Call LoadGridBoletoBancario()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnGerarBoletoBancario_Click(sender As Object, e As EventArgs) Handles btnGerarBoletoBancario.Click
    
        Try

            'Valida Formulário
            If Validacao() = True Then

                'Imprime Boleto Bancário
                Call GerarBoletoBancario()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnVisualizarBoletoBancario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarBoletoBancario.Click

        Try
            VisualizarBoletoBancario()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try



            'Imprime Conteúdo do WebBrowser
            webBrowser.ShowPrintDialog()

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


    Private Sub btnExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPDF.Click
        Try

            If bSistemaPerforma = True Then
                ExportarBoletoBancarioCrystal()
            Else
                ExportarPDF()
            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
        Try
            EnviarEmailBoleto()
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

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFinReceitaGerarBoleto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Controle
            txtNumeroDocumento.Text = sNumeroDocumento
            txtCliente.Text = sCliente
            txtValorTotal.Text = FormatNumber(oClsFrmFinReceitaBoletoBancario.LoadValorTotal(lCodigoTituloCapa, iNumeroParcela), 2)

            'Carrega Combo
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, True)

            If grdBoletoBancario.RecordCount > 0 Then
                grdBoletoBancario.CheckAllRecords()
                VisualizarBoletoBancario()
                btnImprimir.Enabled = True
            End If

            'Desabilita Controle
            btnImprimir.Enabled = False

            If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
                btnVisualizarBoletoBancario.Visible = False
                btnGerarBoletoBancario.Location = btnVisualizarBoletoBancario.Location
            End If


            If bSistemaPerforma = True Then

                webBrowser.Visible = False
                crvViewer.Visible = True

            Else

                webBrowser.Visible = True
                crvViewer.Visible = False

            End If

            'Seta Focu
            cboContaBancaria.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGridBoletoBancario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa / Desativa Controles
            webBrowser.Navigate("")
            btnImprimir.Enabled = False

            'Verifica se foi Selecionado Algum Registro
            If cboContaBancaria.SelectedIndex = -1 Then

                'Limpa Grid
                grdBoletoBancario.DataSource = Nothing

            Else

                'Carrega Grid
                oClsFrmFinReceitaBoletoBancario.LoadGridParcela(grdBoletoBancario, _
                                                                lCodigoTituloCapa, _
                                                                iNumeroParcela, _
                                                                cboContaBancaria.SelectedValue)

                'Carrega Combo - Grid
                Call LoadComboGrid(grdBoletoBancario, _
                                   "carteira", _
                                   "sp_select_combo_cadastro_basico_banco_carteira " & cboContaBancaria.SelectedValue & ", " & goUsuario.iEmpresa, _
                                   "parcela")

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub LoadCrystal(ByVal lCodigoTituloCapa As Long)
        Try
            Dim iCodigoBanco As Integer = CInt(LoadCodigo("sp_select_cadastro_basico_codigo_banco_conta " & cboContaBancaria.SelectedValue & ", " & goUsuario.iEmpresa))
            Dim sReport As String = ""

            If iCodigoBanco = 237 Then sReport = "rptBoletoBradesco.rpt"
            If iCodigoBanco = 33 Then sReport = "rptBoletoSantander.rpt"
            If iCodigoBanco = 341 Then sReport = "rptBoletoItau.rpt"


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros

            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_titulo_capa"
            goCrystalReport.sReportParameter(0).sValue = lCodigoTituloCapa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport


            'Abre o relatório
            rptDocument.Load(goCrystalReport.sReport, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'Atualiza Relatório
            rptDocument.Refresh()

            'Desabilita o Cache
            rptDocument.ReportOptions.EnableSaveDataWithReport = False

            'Envia parametros para o Relatório
            For i As Integer = 0 To UBound(goCrystalReport.sReportParameter)
                If CStr(goCrystalReport.sReportParameter(i).sValue) = "NULL" Then
                    rptDocument.SetParameterValue(goCrystalReport.sReportParameter(i).sParamenter, DBNull.Value)
                Else
                    rptDocument.SetParameterValue(goCrystalReport.sReportParameter(i).sParamenter, goCrystalReport.sReportParameter(i).sValue)
                End If
            Next

            'Abre Conexão com o Banco de Dados        
            For i = 0 To rptDocument.DataSourceConnections.Count - 1
                rptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)

            Next i

            crvViewer.Show()
            crvViewer.ShowPrintButton = True
            crvViewer.ReportSource = rptDocument
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub VisualizarBoletoBancario()
        Try

            'Váriaveis Locais
            Dim sArquivoBoleto As String = ""

            Dim iParcela As Integer = -1


            If bSistemaPerforma = False Then

                iParcela = grdBoletoBancario.GetCheckedRows(0).Cells.Item("parcela").Value

            End If

            'Gera Arquivo
            oClsFrmFinReceitaBoletoBancario.LoadArquivoBoleto(lCodigoTituloCapa, sNumeroDocumento, sArquivoBoleto, iParcela)

            ''Carrega Arquivo
            'If sArquivoBoleto <> "" Then
            '    webBrowser.Navigate(sArquivoBoleto)
            'Else
            '    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi gerado Boleto Bancário para este Título.")
            'End If

            If bSistemaPerforma = True Then

                LoadCrystal(lCodigoTituloCapa)

            Else
                'Carrega Arquivo
                If sArquivoBoleto <> "" Then
                    webBrowser.Navigate(sArquivoBoleto)
                Else
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi gerado Boleto Bancário para este Título.")
                End If
            End If


            ''Tste
            'Dim oFileRead As New StreamReader(sArquivoBoleto, System.Text.Encoding.Default)
            'Dim sHTML As String = oFileRead.ReadToEnd
            'oFileRead.Close()
            'Dim oFileStream As New FileStream("e:\teste.pdf", FileMode.OpenOrCreate)
            'Dim oObject As New Pdfizer.HtmlToPdfConverter
            'oObject.Open(oFileStream)
            'oObject.Run(sHTML)
            'oObject.Close()


            'Habilita Controle
            btnImprimir.Enabled = VerificaDireito(Formulario.FinanceiroReceitaBoletoBancario, gcPrint)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GerarBoletoBancario()

        'Váriaveis Locais
        Dim oBoletoBancario As BoletoBancario
        Dim oInstrucao1 As Instrucao
        Dim oInstrucao2 As Instrucao
        Dim oCedente As Cedente
        Dim sNumeroParcela As String = ""
        Dim sCarteira As String = ""
        Dim oRow As GridEXRow
        Dim iCodigoBanco As Integer
        Dim sAgencia As String = ""
        Dim sConta As String = ""
        Dim sConvenio As String = ""
        Dim sDigitoConta As String = ""
        Dim sNossoNumero As String = ""
        Dim sCNPJSacado As String = ""
        Dim sRazaoSocialSacado As String = ""
        Dim sBairroSacado As String = ""
        Dim sCidadeSacado As String = ""
        Dim sCEPSacado As String = ""
        Dim sUFSacado As String = ""
        Dim sLogradouroSacado As String = ""
        Dim sNumeroSacado As String = ""
        Dim sComplementoSacado As String = ""
        Dim sCodigoInstrucao1 As String = ""
        Dim sCodigoInstrucao2 As String = ""
        Dim sCodigoInstrucao3 As String = ""
        Dim sInstrucao1 As String = ""
        Dim sInstrucao2 As String = ""
        Dim sInstrucao3 As String = ""
        Dim iNumeroDias1 As Integer = 0
        Dim iNumeroDias2 As Integer = 0
        Dim iNumeroDias3 As Integer = 0

        Try

            'Carrega Daods do Emitente
            Call LoadDadosEmitente()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim lBoleto As New List(Of BoletoBancario)

            For Each oRow In gSelecaoRow

                'Verifica se já foi Gerado o Arquivo
                If oRow.Cells("gerado_arquivo").Value = True Then
                    If MsgBox("Já foi gerado arquivo de remessa para a Parcela: " & oRow.Cells("parcela").Value & ". Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        GoTo Proximo
                    End If
                End If

                'Seta Váriavel 
                oBoletoBancario = New BoletoBancario

                'Insere Registro - Boleto Bancário
                oClsFrmFinReceitaBoletoBancario.InsertBoletoBancario(lCodigoTituloCapa, _
                                                                     oRow.Cells("parcela").Value, _
                                                                     oRow.Cells("data_vencimento").Value, _
                                                                     oRow.Cells("valor").Value, _
                                                                     cboContaBancaria.SelectedValue, _
                                                                     oRow.Cells("carteira").Value, _
                                                                     False, _
                                                                     IIf(IsNumeric(oRow.Cells("juros").Value), oRow.Cells("juros").Value, 0), _
                                                                     IIf(IsNumeric(oRow.Cells("multa").Value), oRow.Cells("multa").Value, 0), _
                                                                     iCodigoBanco, _
                                                                     sAgencia, _
                                                                     sConta, _
                                                                     sDigitoConta, _
                                                                     sNossoNumero, _
                                                                     sCNPJSacado, _
                                                                     sRazaoSocialSacado, _
                                                                     sBairroSacado, _
                                                                     sCidadeSacado, _
                                                                     sCEPSacado, _
                                                                     sUFSacado, _
                                                                     sLogradouroSacado, _
                                                                     sNumeroSacado, _
                                                                     sComplementoSacado, _
                                                                     sCodigoInstrucao1, _
                                                                     sCodigoInstrucao2, _
                                                                     sCodigoInstrucao3, _
                                                                     sInstrucao1, _
                                                                     sInstrucao2, _
                                                                     sInstrucao3, _
                                                                     iNumeroDias1, _
                                                                     iNumeroDias2, _
                                                                     iNumeroDias3, _
                                                                     sConvenio)


                'Seta Codigo do Banco
                oBoletoBancario.CodigoBanco = iCodigoBanco

                If sDigitoConta = "" Then
                    oCedente = New Cedente(goEmitente.sCNPJ, goEmitente.sRazaoSocial & "<br>" & goEmitente.sLogradouro & ", " & goEmitente.sNumero & " - " & goEmitente.sBairro, sAgencia, sConta)
                Else
                    oCedente = New Cedente(goEmitente.sCNPJ, goEmitente.sRazaoSocial & "<br>" & goEmitente.sLogradouro & ", " & goEmitente.sNumero & " - " & goEmitente.sBairro, sAgencia, sConta, sDigitoConta)
                End If

                oCedente.Convenio = sConvenio

                If iCodigoBanco = 33 Then
                    oCedente.Codigo = sConvenio
                ElseIf iCodigoBanco = 104 Then
                    oCedente.Codigo = sConvenio
                End If

                Dim iEspecie As Integer = 1

                If iCodigoBanco = 104 Then

                    iEspecie = 2

                End If


                Dim oBoleto As New Boleto(oRow.Cells("data_vencimento").Value, oRow.Cells("valor").Value, oRow.Cells("carteira").Value, sNossoNumero, oCedente, New EspecieDocumento(iCodigoBanco, iEspecie))
                Dim sNotaFiscal As String = sNossoNumero
                If sNossoNumero.Length = 17 Then
                    oBoleto.NumeroDocumento = Strings.Right(sNossoNumero, 10)
                    sNotaFiscal = Replace(txtNumeroDocumento.Text, "/", "_")
                ElseIf oBoletoBancario.CodigoBanco = "748" Then
                    oBoleto.NossoNumero = Format(oRow.Cells("data_emissao").Value, "yy") + "2" + txtNumeroDocumento.Text.PadLeft(4, "0") + CStr(oRow.Cells.Item("parcela").Value)
                    oBoleto.NumeroDocumento = txtNumeroDocumento.Text + "-" + CStr(oRow.Cells.Item("parcela").Value)
                    oCedente.ContaBancaria.OperacaConta = sConta + sDigitoConta

                Else
                    oBoleto.NumeroDocumento = sNumeroDocumento

                End If



                oBoleto.Sacado = New Sacado(sCNPJSacado, sRazaoSocialSacado)
                oBoleto.Sacado.Endereco.End = sLogradouroSacado & ", " & sNumeroSacado & IIf(sComplementoSacado = "", "", " - " & sComplementoSacado)
                oBoleto.Sacado.Endereco.Bairro = sBairroSacado
                oBoleto.Sacado.Endereco.Cidade = sCidadeSacado
                oBoleto.Sacado.Endereco.CEP = sCEPSacado
                oBoleto.Sacado.Endereco.UF = sUFSacado
                oBoleto.Sacado.Endereco.Logradouro = sLogradouroSacado
                oBoleto.Sacado.Endereco.Numero = sNumeroSacado
                oBoleto.Sacado.Endereco.Complemento = sComplementoSacado
                If oBoletoBancario.CodigoBanco = "1" Then
                    oBoleto.EspecieDocumento.Sigla = "DM"
                ElseIf oBoletoBancario.CodigoBanco = "748" Then
                    oBoleto.EspecieDocumento.Sigla = "DMI"
                End If
                If sCodigoInstrucao1 <> "" Then
                    oInstrucao1 = New Instrucao(iCodigoBanco)
                    oInstrucao1.Codigo = sCodigoInstrucao1
                    If iNumeroDias1 > -1 Then oInstrucao1.QuantidadeDias = iNumeroDias1
                    oInstrucao1.Descricao = sInstrucao1
                    oBoleto.Instrucoes.Add(oInstrucao1)
                End If

                If sCodigoInstrucao2 <> "" Then
                    oInstrucao2 = New Instrucao(iCodigoBanco)
                    oInstrucao2.Codigo = sCodigoInstrucao2
                    If iNumeroDias2 > -2 Then oInstrucao2.QuantidadeDias = iNumeroDias2
                    oInstrucao2.Descricao = sInstrucao2
                    oBoleto.Instrucoes.Add(oInstrucao2)
                End If

                oBoletoBancario.Boleto = oBoleto
                oBoletoBancario.Boleto.Valida()

                If bSistemaPerforma = True Then

                    oBoleto.NumeroDocumento = txtNumeroDocumento.Text + "-" + oRow.Cells.Item("parcela").Value.ToString.PadLeft(2, "0")
                    ExecuteQuery("sp_update_financeiro_titulo_boleto " & CStr(goUsuario.iEmpresa) & "," & _
                                                                         CStr(lCodigoTituloCapa) & "," & _
                                                                         oRow.Cells.Item("parcela").Value & ",'" & _
                                                                         oBoletoBancario.Boleto.NossoNumero & "','" & _
                                                                         oBoletoBancario.Boleto.CodigoBarra.LinhaDigitavel & "','" & _
                                                                         oBoletoBancario.Boleto.CodigoBarra.Codigo & "'", goDatabase.sConnection)
                End If


                If oBoleto.Banco.Codigo <> "748" And bSistemaPerforma = False Then
                    oBoletoBancario.Boleto.NumeroDocumento = sNotaFiscal
                End If
                'Formatação específica do sicredi
                If oBoleto.Banco.Codigo = "748" Then

                    oBoletoBancario.Boleto.NossoNumero = Microsoft.VisualBasic.Strings.Left(oBoletoBancario.Boleto.NossoNumero, 2) + _
                                                        "/" + _
                                                        Mid(oBoletoBancario.Boleto.NossoNumero, 3, 6) + _
                                                        "-" + _
                                                        Microsoft.VisualBasic.Strings.Right(oBoletoBancario.Boleto.NossoNumero, 1)


                End If

                lBoleto.Add(oBoletoBancario)

Proximo:

            Next


            If bSistemaPerforma = True Then

                LoadCrystal(lCodigoTituloCapa)



            Else

                If lBoleto.Count = 0 Then
                    sArquivo = ""
                    webBrowser.Navigate("")
                Else
                    'Gera Boleto
                    Call GeraLayoutBoletoBancario(Replace(sNumeroDocumento, "/", "_"), lBoleto, sArquivo)
                    'Carrega Boleto
                    webBrowser.Navigate(sArquivo)
                End If

            End If


            'Habilita Controle
            btnImprimir.Enabled = VerificaDireito(Formulario.FinanceiroReceitaBoletoBancario, gcPrint)

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Conta Bancaria
            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado Algum Boleto
            If VerificaSelecaoRow(grdBoletoBancario) = False Then
                'Informa o Usuário que é necessário Selecionar o Boleto Bancário
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

            'Verifica se todas as Linhas selecionadas são válidas
            For Each oRow As GridEXRow In gSelecaoRow
                If IsDBNull(oRow.Cells("carteira").Value) Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi selecionado a Carteira para a Parcela: " & oRow.Cells("parcela").Value & ".")
                    Exit Function
                End If
            Next

            'Verifica se o Valor das Parcelas é igual ao Valor Total
            If grdBoletoBancario.GetTotalRow.Cells("valor").Value < CDbl(txtValorTotal.Text) Then
                If MsgBox("A Soma dos Valores do Boleto é menor que o Valor Total do Título. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Function

    Private Sub ExportarBoletoBancarioCrystal()
        Dim sErro As String = ""
        Try
            Dim sNumeroParcela As String = ""
            Dim iCodigoBanco As Integer = -1
            Dim sArquivoBoleto As String = ""

            LoadConfiguracaoNFe()

            'Percorrendo os codigos ativos
            For Each oRow In grdBoletoBancario.GetCheckedRows

                'Se já tiver algum código, adiciona o delimitador
                If sNumeroParcela <> "" Then
                    sNumeroParcela += ","
                End If

                'Concatenando o código
                sNumeroParcela += CStr(oRow.Cells.Item("parcela").Value)



            Next
            iCodigoBanco = CInt(LoadCodigo("sp_select_cadastro_basico_codigo_banco_conta " & cboContaBancaria.SelectedValue & ", " & goUsuario.iEmpresa))

            'Instancia para gerar os boletos
            Dim oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario

            'Vetor para verificar todos os boletos
            Dim oVetor() As String = sNumeroParcela.Split(",")

            'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
            Dim sDiretorio As String = goConfiguracaoNFe.sPastaImpressao + "boleto\" + Format(Now, "yyMMdd_HHmmss") + "\"

            'Exclui o diretório se existir
            If System.IO.Directory.Exists(sDiretorio) Then
                System.IO.Directory.Delete(sDiretorio)
            End If
            'Cria  a pasta
            System.IO.Directory.CreateDirectory(sDiretorio)
            'Para um dos boleto, gerar um pdf
            For i As Integer = 0 To oVetor.Count - 1
                'Gera Arquivo
                oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLoteCrystalParcela(lCodigoTituloCapa, oVetor(i), sDiretorio, sArquivoBoleto, iCodigoBanco)

            Next



            Dim sArquivo As String
            Dim sReport As String = ""
            If iCodigoBanco = 237 Then sReport = "rptBoletoBradesco.rpt"
            If iCodigoBanco = 33 Then sReport = "rptBoletoSantander.rpt"
            If iCodigoBanco = 341 Then sReport = "rptBoletoItau.rpt"
            'Váriaveis - Relatório

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oRptDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            oRptDocument.Load(goCrystalReport.sPath & sReport, CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Adicionando o parâmetro
            oRptDocument.SetParameterValue("@codigo_titulo_capa", lCodigoTituloCapa)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            Dim sArquivoPDF As String = goConfiguracaoNFe.sPastaImpressao + txtNumeroDocumento.Text + Format(Now, "yyMMdd_HHmmss")

            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoPDF)

            oRptDocument.Close()

            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = sArquivoPDF
            Process.Start(psi)
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default






            If sErro <> "" Then
                MsgBox("Erros:" + sErro, vbExclamation)
            End If

            Cursor.Current = Cursors.Default



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExportarPDF()
        Try

            Dim sArquivoBoleto As String = ""
            Dim sCaminhoBoleto As String = ""

            'Gera o boleto
            'oClsFrmFinReceitaBoletoBancario.LoadArquivoBoleto(lCodigoTituloCapa, txtNumeroDocumento.Text.Replace("\", "_"), sArquivoBoleto)
            'sCaminhoBoleto = ExportarBoletoPDF(sArquivoBoleto, "1", txtNumeroDocumento.Text.Replace("\", "_"))
            oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoPDF2(lCodigoTituloCapa, goUsuario.iEmpresa, txtNumeroDocumento.Text.Replace("\", "_"), sCaminhoBoleto, -1)

            Dim oSaveFileDialog As New SaveFileDialog
            oSaveFileDialog.FileName = sCaminhoBoleto
            oSaveFileDialog.DefaultExt = "pdf"

            If oSaveFileDialog.ShowDialog <> vbOK Then Exit Sub

            System.IO.File.Move(sCaminhoBoleto, oSaveFileDialog.FileName)

            Process.Start(oSaveFileDialog.FileName)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EnviarEmailBoleto()
        Try
            Dim sArquivoBoleto As String = ""
            Dim sCaminhoBoleto As String = ""


            'Gera o boleto
            ' oClsFrmFinReceitaBoletoBancario.LoadArquivoBoleto(lCodigoTituloCapa, txtNumeroDocumento.Text.Replace("\", "_"), sArquivoBoleto)
            'sCaminhoBoleto = ExportarBoletoPDF(sArquivoBoleto, "1", txtNumeroDocumento.Text.Replace("\", "_"))
            oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoPDF2(lCodigoTituloCapa, goUsuario.iEmpresa, txtNumeroDocumento.Text.Replace("\", "_"), sCaminhoBoleto, -1)

            EnviarEmail("", _
                        "", _
                        sCaminhoBoleto, _
                        sCaminhoBoleto, _
                        "", _
                        -1)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region


End Class