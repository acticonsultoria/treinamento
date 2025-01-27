Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.UI.Tab
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports System.Net.Mail
Imports System.Text
Imports System.IO
'Imports System.IO.Compression
Imports System.Security.Cryptography
Imports Ionic.Zip
Imports System.Security.Cryptography.X509Certificates
Imports System.Reflection
Imports System.Reflection.Assembly
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Net
Imports System.Text.RegularExpressions
Imports BoletoNet
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports ImagePDF
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Threading.Tasks
Imports System.Json
Imports Newtonsoft.Json

Module modFunction

#Region "::: SYSTEM FUNCTION :::"

    Declare Function ShellEx Lib "SHELL32.DLL" Alias "ShellExecuteA" (ByVal hwnd As Long,
                                                                      ByVal lpszOp As String,
                                                                      ByVal lpszFile As String,
                                                                      ByVal lpszParams As String,
                                                                      ByVal LpszDir As String,
                                                                      ByVal FsShowCmd As Long) As Long

#End Region

#Region "::: SUB :::"


    Public Function BuscaWSSintegra(ByVal sCNPJ As String, _
                               ByVal txtRazaoSocial As MaskedEditBox, _
                               ByVal txtInscricaoEstadual As MaskedEditBox, _
                               ByVal cboPais As UIComboBox, _
                               ByVal txtLogradouro As MaskedEditBox, _
                               ByVal txtNumero As MaskedEditBox, _
                               ByVal txtBairro As MaskedEditBox, _
                               ByVal txtCEP As MaskedEditBox, _
                               ByVal txtComplemento As MaskedEditBox, _
                               ByVal cboUF As UIComboBox, _
                               ByVal cboMunicipio As UIComboBox)

        Try


            'Client para trazer os dados da string
            Dim oClient As New WebClient
            oClient.Encoding = System.Text.Encoding.UTF8

            Dim sResponse As String
            sCNPJ = Replace(Replace(Replace(Replace(sCNPJ, ".", ""), "/", ""), ",", ""), "-", "")
            Dim sUrl As String = "https://publica.cnpj.ws/cnpj/" + sCNPJ
            'Seta o protocolo
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            'Faz o request
            sResponse = oClient.DownloadString(sUrl)

            'Quebra o JSON como serializer
            Dim oWSSintegra = JsonConvert.DeserializeObject(Of WSSIntegra.WSSintegra)(sResponse)

            txtRazaoSocial.Text = oWSSintegra.razao_social
            cboPais.SelectedValue = 0
            Application.DoEvents()
            Try
                txtInscricaoEstadual.Text = oWSSintegra.estabelecimento.inscricoes_estaduais(0).inscricao_estadual
            Catch ex As Exception

            End Try

            txtLogradouro.Text = oWSSintegra.estabelecimento.tipo_logradouro + " " + oWSSintegra.estabelecimento.logradouro
            txtNumero.Text = oWSSintegra.estabelecimento.numero
            txtComplemento.Text = oWSSintegra.estabelecimento.complemento
            txtBairro.Text = oWSSintegra.estabelecimento.bairro
            txtCEP.Text = oWSSintegra.estabelecimento.cep
            cboUF.SelectedValue = oWSSintegra.estabelecimento.estado.sigla
            cboMunicipio.SelectedValue = LoadCodigo("sp_select_static_municipio " & CStr(oWSSintegra.estabelecimento.cidade.ibge_id))

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function ValidacaoDataCusteio(ByVal dData As Date) As Boolean

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(1) As SqlParameter
        Dim sResult As String
        Try



            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dData : i += 1


            'Executa Query
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_custo_bloqueio", oSqlParameter)

            If sResult <> "" Then

                MsgBox(sResult, MsgBoxStyle.Exclamation, "Validação")
                Return False

            Else
                Return True

            End If


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub DisableTabStop(ByVal oControlParent As Control)

        Try

            'Váriavel - Controle
            Dim oControl As Control

            If TypeOf (oControlParent) Is UITab Or
                TypeOf (oControlParent) Is UITabPage Then
                oControlParent.TabStop = False
            End If

            For Each oControl In oControlParent.Controls
                If TypeOf (oControl) Is UITab Or
                    TypeOf (oControl) Is UITabPage Then
                    oControl.TabStop = False
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub InsertControleSMS(ByVal lCodigoEmissaoCapa As Long,
                                 ByVal sNumeroDocumento As String,
                                 ByVal sCliente As String,
                                 ByVal sDataEmissao As String,
                                      ByVal sTelefone As String,
                                      ByVal sMensagem As String,
                                      ByVal sMensagemRetorno As String,
                                      ByVal iNumeroControle As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEmissaoCapa = -1, DBNull.Value, lCodigoEmissaoCapa) : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDocumento : i += 1


            'Seta Parametros - Data Emissao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissao = "", DBNull.Value, sDataEmissao) : i += 1


            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTelefone : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMensagem : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_retorno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMensagemRetorno : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroControle


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_sms", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Function VerificaUserControlCliente(ByVal sUserControl As String) As String
        Try
            Dim sFormulario As String
            Select Case sUserControl

                Case "usrCadProduto"
                    'Carrega a configuração da empresa
                    sFormulario = LoadCodigo("sp_select_static_formulario_user_control " & Formulario.CadastroBasicoProduto)

                    'Se não foi configurado
                    If sFormulario = "" Then sFormulario = "usrCadProduto"

                    'Seta o retorno
                    VerificaUserControlCliente = sFormulario

                Case "usrCadParceiroNegocio"

                    'Carrega a configuração da empresa
                    sFormulario = LoadCodigo("sp_select_static_formulario_user_control " & Formulario.CadastroBasicoParceiroNegocio)

                    'Se não foi configurado
                    If sFormulario = "" Then sFormulario = "usrCadParceiroNegocio"

                    'Seta o retorno
                    VerificaUserControlCliente = sFormulario

                Case Else

                    'Sempre será padrão
                    VerificaUserControlCliente = sUserControl

            End Select

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GerarPDF(ByVal sArquivoSaida As String, ByVal oArquivos() As String) As String

        Dim oPdfWriter As iTextSharp.text.pdf.PdfWriter
        Dim oPdfDoc As iTextSharp.text.Document
        Try



            'Verifica se existe, para excluir
            If System.IO.File.Exists(sArquivoSaida) Then
                System.IO.File.Delete(sArquivoSaida)
            End If

            'Instancia um novo document para adicionar
            oPdfDoc = New iTextSharp.text.Document

            'Cria uma instancia para escrita em pdf
            oPdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(oPdfDoc, New FileStream(sArquivoSaida, FileMode.Create))

            'Abre o document
            oPdfDoc.Open()

            'Percorre o vetor
            For Each sArquivo As String In oArquivos
                If sArquivo = "" Then Continue For
                If New System.IO.FileInfo(sArquivo).Extension.ToUpper = ".PDF" Then
                    AddPdf(sArquivo, oPdfDoc, oPdfWriter)
                End If
            Next

            'Fecha o document
            oPdfDoc.Close()
            oPdfWriter.Close()

            'Retorna o caminho do arquivo criado
            Return sArquivoSaida

        Catch ex As Exception
            oPdfDoc.Close()
            oPdfWriter.Close()
            Throw ex
        End Try
    End Function
    Sub AddPdf(ByVal sInFilePath As String, ByRef oPdfDoc As iTextSharp.text.Document, ByRef oPdfWriter As iTextSharp.text.pdf.PdfWriter)



        Dim oDirectContent As iTextSharp.text.pdf.PdfContentByte = oPdfWriter.DirectContent
        Dim oPdfReader As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(sInFilePath)
        Dim iNumberOfPages As Integer = oPdfReader.NumberOfPages
        Dim iPage As Integer = 0

        Do While (iPage < iNumberOfPages)
            iPage += 1

            Dim iRotation As Integer = oPdfReader.GetPageRotation(iPage)
            Dim oPdfImportedPage As iTextSharp.text.pdf.PdfImportedPage = oPdfWriter.GetImportedPage(oPdfReader, iPage)


            oPdfDoc.SetPageSize(oPdfReader.GetPageSizeWithRotation(iPage))
            oPdfDoc.NewPage()

            If (iRotation = 90) Or (iRotation = 270) Then
                oDirectContent.AddTemplate(oPdfImportedPage, 0, -1.0F, 1.0F, 0, 0, oPdfReader.GetPageSizeWithRotation(iPage).Height)
            Else
                oDirectContent.AddTemplate(oPdfImportedPage, 1.0F, 0, 0, 1.0F, 0, 0)
            End If

        Loop

    End Sub

    Public Sub UpdateCotacaoBCB(ByVal iCodigoMoeda As Moeda)


        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_moeda"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = iCodigoMoeda

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cfg_cotacao", oSqlParameter)


            If oSqlDataReader.Read Then

                If oSqlDataReader.Item(0) = True Then

                    'Redimensiona o vetor para adicionar os outros parâmetros
                    ReDim Preserve oSqlParameter(3)

                    oSqlParameter(2) = New SqlParameter
                    oSqlParameter(2).ParameterName = "valor"
                    oSqlParameter(2).Direction = ParameterDirection.Input
                    oSqlParameter(2).SqlDbType = SqlDbType.Float
                    oSqlParameter(2).Value = IIf(iCodigoMoeda = Moeda.Euro, CotacaoEuro(), CotacaoDolar())

                    oSqlParameter(3) = New SqlParameter
                    oSqlParameter(3).ParameterName = "codigo_usuario"
                    oSqlParameter(3).Direction = ParameterDirection.Input
                    oSqlParameter(3).SqlDbType = SqlDbType.Int
                    oSqlParameter(3).Value = goUsuario.iUsuario

                    If oSqlParameter(2).Value > 0 Then
                        ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cfg_cotacao", oSqlParameter)

                    End If
                End If

            End If

            'Fechando o recordset
            oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Function CotacaoDolar() As Double
        Try

            Dim oWebService As New WebBCB.FachadaWSSGSService
            Dim oWSSerieVO As New WebBCB.WSSerieVO
            oWSSerieVO = oWebService.getUltimoValorVO(1) 'Dolar

            CotacaoDolar = Replace(oWSSerieVO.ultimoValor.svalor, ".", ",")

        Catch ex As Exception
            CotacaoDolar = 0
        End Try
    End Function
    Private Function CotacaoEuro() As Double
        Try

            Dim oWebService As New WebBCB.FachadaWSSGSService
            Dim oWSSerieVO As New WebBCB.WSSerieVO
            oWSSerieVO = oWebService.getUltimoValorVO(21619) 'Euro

            CotacaoEuro = Replace(oWSSerieVO.ultimoValor.svalor, ".", ",")

        Catch ex As Exception
            CotacaoEuro = 0
        End Try
    End Function
    Public Sub LoadGridCliente(ByVal oGrid As Janus.Windows.GridEX.GridEX,
                                    ByVal iCodigoEmpresa As Integer,
                                    ByVal bImprimirTodos As Boolean,
                                    Optional ByVal iAtivo As Integer = 1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try


            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigoEmpresa


            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "imprimir_todos"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Bit
            oSqlParameter(1).Value = bImprimirTodos


            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "ativo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Bit
            oSqlParameter(2).Value = IIf(iAtivo = -1, DBNull.Value, iAtivo)



            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sga_cadastro_basico_cliente_listagem", oSqlParameter)

            With oGrid

                ConfigurarDataMemberGrid(oGrid)

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub LoadUsrControlForm(ByVal oUsrControl As UserControl,
                                  ByVal sNewUserControl As String,
                                  Optional ByVal oFormularioCadastroBasico() As FormularioCadastroBasico = Nothing)
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico

            'Faz verificação para puxar o formulário específico do cliente
            oForm.UsrControl = VerificaUserControlCliente(sNewUserControl)
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = oUsrControl.Parent.Text
            If Not oFormularioCadastroBasico Is Nothing Then
                oForm.CadastroBasico = oFormularioCadastroBasico
            End If
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(oUsrControl)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LoadUsrControlForm(ByVal oFormParent As Form, ByVal sNewUserControl As String, Optional ByVal oFormularioCadastroBasico() As FormularioCadastroBasico = Nothing)

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            'Faz a verificação para abrir o formulário específico do cliente
            oForm.UsrControl = VerificaUserControlCliente(sNewUserControl)

            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = oFormParent.Text
            If Not oFormularioCadastroBasico Is Nothing Then
                oForm.CadastroBasico = oFormularioCadastroBasico
            End If
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(oFormParent)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadParceiroNegocio(ByVal iCodigo As Integer)

        Try

            'Váriavel
            Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico

            'Carrega Váriavel
            oFormularioCadastroBasico(0).oValor = "CODIGO:" & iCodigo : oFormularioCadastroBasico(0).sControle = "usrCadParceiroNegocio"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadParceiroNegocio"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.CadastroBasico = oFormularioCadastroBasico
            oForm.Titulo = "Parceiro de Negócio"
            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub UpdateGridFieldCadastroBasico(ByVal sNomeTabela As String, ByVal sNomeCampo As String, ByVal sValor As String, ByVal lCodigo As Long)
        Try
            Call ExecuteQuery("sp_update_interacti_table_field_cadastro_basico '" + sNomeTabela + "', '" + sNomeCampo + "', " & CStr(sValor) & "," & CStr(lCodigo) & "," & CStr(goUsuario.iEmpresa))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub EditarGrid(ByVal oGrid As GridEX,
                          ByVal sCampo() As String,
                          ByVal bEditar As Boolean)

        Try

            For i As Integer = 0 To UBound(sCampo)

                If bEditar = True Then

                    'Seta Coluna
                    oGrid.RootTable.Columns(sCampo(i)).SelectableCells = SelectableCells.FilterRowCells + SelectableCells.RowCells
                    oGrid.RootTable.Columns(sCampo(i)).CellStyle.BackColor = System.Drawing.SystemColors.Info

                Else

                    'Seta Coluna
                    oGrid.RootTable.Columns(sCampo(i)).SelectableCells = SelectableCells.FilterRowCells
                    oGrid.RootTable.Columns(sCampo(i)).CellStyle.BackColor = Nothing

                End If

            Next

            oGrid.Refresh()

            'Limpa Tag
            oGrid.Tag = IIf(bEditar = True, "E", "")

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Grid_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)

        Try

            If e.Button = MouseButtons.Right Then

                Dim oGrid As GridEX = sender

                oGrid.CurrentColumn = oGrid.ColumnFromPoint(e.X, e.Y)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AddLostFocusTextBox(ByVal sender As Object, ByVal e As EventArgs)

        Try

            PreenchimentoCaracteres(sender)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub Button_CommandClick(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs)

        Try

            'Váriavel
            Dim oUICommand As Janus.Windows.UI.CommandBars.UICommand = sender

            'Verifica o Tipo de Controle
            Select Case oUICommand.Key

                Case "definir"

                    'Carrega ColorDialog
                    Dim oColorDialog As New ColorDialog

                    oColorDialog.AnyColor = True

                    'Colore a Coluna da Grid
                    If oColorDialog.ShowDialog() = DialogResult.OK Then

                        Dim oGrid As GridEX = sender.Tag
                        oGrid.CurrentColumn.CellStyle.BackColor = oColorDialog.Color

                        'Limpa Controles
                        Dim oControl As Control = oGrid.Parent
                        While Not TypeOf (oControl) Is UserControl And Not TypeOf (oControl) Is Form
                            oControl = oControl.Parent
                        End While

                        'Atualiza Registro
                        Call UpdateConfiguraGridCor(oGrid.Name, oControl.Tag, oGrid.CurrentColumn.Key, oColorDialog.Color.R, oColorDialog.Color.G, oColorDialog.Color.B)

                    End If

                Case "grafico"

                    Dim oUsrControl As UserControl
                    Dim sText As String = "Gráfico"
                    Dim oAssembly As Assembly = GetExecutingAssembly()
                    oUsrControl = oAssembly.CreateInstance("INTERACTI.usrChartDinamico")
                    oUsrControl.Dock = DockStyle.Fill
                    CType(oUsrControl, usrChartDinamico).Grid = sender.tag
                    'Configura Mascara
                    Call ConfigureMaskEdit(oUsrControl) : Call LoadControlesTraducao(oUsrControl)

                    If frmMain.tabMain.TabPages.Contains("usrChartDinamico") Then
                        For Each oTabPages In frmMain.tabMain.TabPages
                            If oTabPages.key = "usrChartDinamico" Then
                                frmMain.tabMain.TabPages.Remove(oTabPages)
                                Exit For
                            End If
                        Next
                    End If

                    'Carrega Página
                    Call frmMain.LoadPage("usrChartDinamico", sText, oUsrControl)

                Case "limpar"

                    Dim oGrid As GridEX = sender.Tag
                    oGrid.CurrentColumn.CellStyle.BackColor = Nothing

                    'Limpa Controles
                    Dim oControl As Control = oGrid.Parent
                    While Not TypeOf (oControl) Is UserControl And Not TypeOf (oControl) Is Form
                        oControl = oControl.Parent
                    End While

                    'Atualiza Registro
                    Call UpdateConfiguraGridCor(oGrid.Name, oControl.Tag.ToString.Replace("FILTRAR", ""), oGrid.CurrentColumn.Key, -1, -1, -1)

                Case "limpar_filtros"

                    Dim oGrid As GridEX = sender.tag
                    oGrid.Row = -2
                    oGrid.RootTable.RemoveFilter()
                    oGrid.Refresh()

                Case "expandir_tudo"

                    Dim oGrid As GridEX = sender.tag
                    oGrid.ExpandRecords()

                Case "copiar"

                    Dim oGrid As GridEX = sender.Tag

                    If IsNothing(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key)) = False Then
                        Clipboard.SetDataObject(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key).Text)
                    End If

                Case "recolher_expansao"

                    Dim oGrid As GridEX = sender.tag
                    oGrid.CollapseRecords()

                Case "configurar_grid"

                    Dim oForm As New frmCfgGrid
                    Dim oGrid As GridEX = sender.Tag

                    'Seta Parametros
                    oForm.Grid = oGrid
                    oForm.NomeFormulario = iFormularioGrid
                    oForm.ShowDialog()

                    'Configura Grid
                    ConfiguraGrid(oGrid, iFormularioGrid)

                Case "exportar_excel"

                    If VerificaDireito(iFormularioGrid, gcPrint) = False Then Exit Sub

                    Dim oGrid As GridEX = sender.tag

                    'Exporta Grid para Excel
                    ExportExcel(oGrid)

                Case "agrupar_grid"

                    Dim oGrid As GridEX = sender.tag

                    If oGrid.GroupByBoxVisible = True Then

                        'Oculta Grupo
                        oGrid.GroupByBoxVisible = False

                    Else

                        'Exibe Grupo
                        oGrid.GroupByBoxVisible = True
                        oGrid.HideColumnsWhenGrouped = InheritableBoolean.True

                    End If

         
                Case "selecionar"

                    Dim oTreeView As TreeView = sender.Tag

                    oTreeView.Tag = oTreeView.SelectedNode.Name

          


                Case "limpar_selecao"

                    Dim oTreeView As TreeView = sender.Tag

                    For Each oNodes As TreeNode In oTreeView.Nodes
                        oNodes.Checked = False
                    Next

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Grid_RowCheckStateChanged(ByVal sender As Object, ByVal e As RowCheckStateChangeEventArgs)

        Dim oGrid As GridEX = sender

        oGrid.Refresh()

    End Sub

    Public Sub Control_GotFocus(ByVal sender As Object, ByVal e As EventArgs)

        Try

            'Verifica o Tipo de Controle
            If Not TypeOf (sender) Is UIButton And
                Not TypeOf (sender) Is Button And
                Not TypeOf (sender) Is GridEX And
                Not TypeOf (sender) Is UserControl And
                Not TypeOf (sender) Is UITab And
                Not TypeOf (sender) Is UICheckBox And
                Not TypeOf (sender) Is TreeView And
                Not TypeOf (sender) Is Label And
                Not TypeOf (sender) Is SplitContainer And
                sender.BackColor = System.Drawing.SystemColors.Window Then

                'Seta Cor do Controle
                sender.BackColor = System.Drawing.SystemColors.Info

                'Limpa Controle
                sControlValue = ""

                If TypeOf (sender) Is MaskedEditBox Then
                    sControlValue = CType(sender, MaskedEditBox).Text
                ElseIf TypeOf (sender) Is EditBox Then
                    sControlValue = CType(sender, EditBox).Text
                ElseIf TypeOf (sender) Is UICheckBox Then
                    sControlValue = CType(sender, UIComboBox).SelectedValue
                ElseIf TypeOf (sender) Is CalendarCombo Then
                    sControlValue = CType(sender, CalendarCombo).Value
                ElseIf TypeOf (sender) Is UICheckBox Then
                    sControlValue = CType(sender, UICheckBox).Checked
                End If

            ElseIf TypeOf (sender) Is UITab Then

                'Desabilita propriedades - Tab
                Dim oUITab As UITab = sender
                oUITab.TabStop = False
                oUITab.ShowFocusRectangle = False

            End If

            Select Case sender.Name
                Case "txtPaisReferencia" : sender.Text = IIf(sender.Text.Trim = "PAÍS", "", sender.Text)
                Case "txtMarcaReferencia" : sender.Text = IIf(sender.Text.Trim = "MARCA", "", sender.Text)
                Case "txtModeloReferencia" : sender.Text = IIf(sender.Text.Trim = "MODELO", "", sender.Text)
                Case "txtAnoModeloReferencia" : sender.Text = IIf(sender.Text.Trim = "ANO MODELO", "", sender.Text)
            End Select

            If IsNothing(sender.Tag) = False AndAlso sender.Tag.ToString.Length > 2 Then
                Select Case sender.Tag.ToString.Substring(0, 2)
                    Case "T:"
                        sender.Text = IIf(sender.Text.Trim = sender.Tag.ToString.Split(":")(1), "", sender.Text)
                        sender.ForeColor = System.Drawing.Color.Black
                End Select
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Control_LostFocus(ByVal sender As Object, ByVal e As EventArgs)

        Try

            'Verifica o Tipo de Controle
            If Not TypeOf (sender) Is UIButton And
                Not TypeOf (sender) Is Button And
                Not TypeOf (sender) Is GridEX And
                Not TypeOf (sender) Is UserControl And
                Not TypeOf (sender) Is UITab And
                Not TypeOf (sender) Is UICheckBox And
                Not TypeOf (sender) Is TreeView And
                Not TypeOf (sender) Is Label And
                Not TypeOf (sender) Is SplitContainer And
                sender.BackColor = System.Drawing.SystemColors.Info Then

                'Seta Cor do Controle
                sender.BackColor = System.Drawing.SystemColors.Window

                If TypeOf (sender) Is MaskedEditBox Then
                    bChangeControl = IIf(sControlValue = CType(sender, MaskedEditBox).Text And bChangeControl, False, True)
                ElseIf TypeOf (sender) Is EditBox Then
                    bChangeControl = IIf(sControlValue = CType(sender, EditBox).Text And bChangeControl, False, True)
                ElseIf TypeOf (sender) Is UICheckBox Then
                    bChangeControl = IIf(sControlValue = CType(sender, UIComboBox).SelectedValue And bChangeControl, False, True)
                ElseIf TypeOf (sender) Is CalendarCombo Then
                    bChangeControl = IIf(sControlValue = CType(sender, CalendarCombo).Value And bChangeControl, False, True)
                ElseIf TypeOf (sender) Is UICheckBox Then
                    bChangeControl = IIf(sControlValue = CType(sender, UICheckBox).Checked And bChangeControl, False, True)
                End If

            End If

            Select Case sender.Name
                Case "txtPaisReferencia" : sender.Text = IIf(sender.Text.Trim = "", "PAÍS", sender.Text)
                Case "txtMarcaReferencia" : sender.Text = IIf(sender.Text.Trim = "", "MARCA", sender.Text)
                Case "txtModeloReferencia" : sender.Text = IIf(sender.Text.Trim = "", "MODELO", sender.Text)
                Case "txtAnoModeloReferencia" : sender.Text = IIf(sender.Text.Trim = "", "ANO MODELO", sender.Text)
            End Select

            If IsNothing(sender.Tag) = False AndAlso sender.Tag.ToString.Length > 2 Then
                Select Case sender.Tag.ToString.Substring(0, 2)
                    Case "T:"
                        sender.Text = IIf(sender.Text.Trim = "", sender.Tag.ToString.Split(":")(1), sender.Text)
                        sender.ForeColor = System.Drawing.Color.DarkGray
                End Select
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Control_Enter(ByVal sender As Object)

        Try

            'Verifica o Tipo de Controle
            If Not TypeOf (sender) Is UIButton And
                Not TypeOf (sender) Is GridEX And
                Not TypeOf (sender) Is UserControl And
                Not TypeOf (sender) Is UITab And
                Not (TypeOf (sender) Is EditBox AndAlso CType(sender, EditBox).Multiline = True) And
                sender.name <> "" Then

                'Muda para o próximo Controle
                System.Windows.Forms.SendKeys.Send("{TAB}")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub btnVoltarClick(ByVal sender As Object, ByVal e As EventArgs)

        Try

            'Verifica o Tipo de Controle
            If bChangeControl = True Then

                'Verifica se o Usuário deseja Voltar
                If MsgBox("As informações preenchidas / alteradas serão perdidas. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "INTERACTI") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    bChangeControl = False
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddMouseClick(ByVal oControl As Control,
                             ByRef oDelegate As DelegateMouseClick)

        Try

            'Adiciona Evento
            AddHandler oControl.MouseClick, AddressOf oDelegate.Invoke

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddRowCheckStateChanged(ByVal oControl As GridEX,
                                       ByRef oDelegate As DelegateRowCheckStateChanged)

        Try

            'Adiciona Evento
            AddHandler oControl.RowCheckStateChanged, AddressOf oDelegate.Invoke

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddKeyDown(ByVal oControlParent As Control,
                          ByRef oDelegate As DelegateKeyDown)

        Try

            'Váriavel - Controle
            Dim oControl As Control
            Dim oFont As System.Drawing.Font
            Dim oFontStyle As FontStyle

            If goFonte.sFonte <> "" Then

                oFontStyle = New FontStyle

                If goFonte.bBold = True And goFonte.bItalic = True Then
                    oFontStyle = FontStyle.Bold + FontStyle.Italic
                ElseIf goFonte.bBold = True And goFonte.bItalic = False Then
                    oFontStyle = FontStyle.Bold
                ElseIf goFonte.bBold = False And goFonte.bItalic = True Then
                    oFontStyle = FontStyle.Italic
                Else
                    oFontStyle = FontStyle.Regular
                End If

                oFont = New System.Drawing.Font(goFonte.sFonte, goFonte.dSize, oFontStyle)

            End If

            For Each oControl In oControlParent.Controls

                'If Not TypeOf (oControl) Is UIGroupBox And _
                '    Not TypeOf (oControl) Is Button And _
                '    Not TypeOf (oControl) Is UIButton Then

                If TypeOf (oControl) Is UIComboBox Or
                    TypeOf (oControl) Is MaskedEditBox Or
                    TypeOf (oControl) Is NumericEditBox Or
                    TypeOf (oControl) Is DateTimePicker Or
                    TypeOf (oControl) Is CalendarCombo Or
                    TypeOf (oControl) Is EditBox Or
                    TypeOf (oControl) Is GridEX Then

                    'Adiciona Evento
                    AddHandler oControl.KeyDown, AddressOf oDelegate.Invoke

                End If

                'Verifica se existe Controles Internos
                If oControl.Controls.Count > 0 Then
                    AddKeyDown(oControl, oDelegate)
                End If

                If goFonte.sFonte <> "" Then
                    oControl.Font = oFont
                End If

                If TypeOf (oControl) Is GridEX And Not oControl.Name.Contains("grdOrcamento") Then

                    Dim oGrid As GridEX = oControl
                    oGrid.DynamicFiltering = True
                    oGrid.FilterMode = FilterMode.Automatic

                    ConfigurarBuiltInTextsGrid(oGrid)

                    Dim oUICommandManager As New Janus.Windows.UI.CommandBars.UICommandManager
                    Dim oUIContextMenu As New Janus.Windows.UI.CommandBars.UIContextMenu
                    Dim oUICommand As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandLimpar As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandCopiar As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandGrafico As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandLimparFiltros As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandExpandirTudo As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandRecolherExpansao As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandConfigurarGrid As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandExportarExcel As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandAgruparListagem As New Janus.Windows.UI.CommandBars.UICommand
                    oUICommand.Text = "Definir Cor da Coluna" : oUICommand.Key = "definir"
                    oUICommandLimpar.Text = "Limpa Cor da Coluna" : oUICommandLimpar.Key = "limpar"
                    oUICommandCopiar.Text = "Copiar Conteúdo da Célula" : oUICommandCopiar.Key = "copiar"
                    oUICommandGrafico.Text = "Gerar Gráfico" : oUICommandGrafico.Key = "grafico"
                    oUICommandLimparFiltros.Text = "Limpar Filtros da Listagem" : oUICommandLimparFiltros.Key = "limpar_filtros"
                    oUICommandExpandirTudo.Text = "Expandir Tudo" : oUICommandExpandirTudo.Key = "expandir_tudo"
                    oUICommandRecolherExpansao.Text = "Recolher Expansão" : oUICommandRecolherExpansao.Key = "recolher_expansao"
                    oUICommandConfigurarGrid.Text = "Configurar Listagem" : oUICommandConfigurarGrid.Key = "configurar_grid"
                    oUICommandExportarExcel.Text = "Exportar para Excel" : oUICommandExportarExcel.Key = "exportar_excel"
                    oUICommandAgruparListagem.Text = "Agrupar Listagem" : oUICommandAgruparListagem.Key = "agrupar_grid"

                    oUICommandManager.Commands.Add(oUICommand)
                    oUICommandManager.Commands.Add(oUICommandLimpar)
                    oUICommandManager.Commands.Add(oUICommandCopiar)
                    oUICommandManager.Commands.Add(oUICommandGrafico)
                    oUICommandManager.Commands.Add(oUICommandLimparFiltros)
                    oUICommandManager.Commands.Add(oUICommandExpandirTudo)
                    oUICommandManager.Commands.Add(oUICommandRecolherExpansao)
                    oUICommandManager.Commands.Add(oUICommandConfigurarGrid)
                    oUICommandManager.Commands.Add(oUICommandExportarExcel)
                    oUICommandManager.Commands.Add(oUICommandAgruparListagem)

                    oUIContextMenu.Commands.Add(oUICommandCopiar)
                    oUIContextMenu.Commands.Add(oUICommand)
                    oUIContextMenu.Commands.Add(oUICommandLimpar)
                    oUIContextMenu.Commands.Add(oUICommandGrafico)
                    oUIContextMenu.Commands.Add(oUICommandLimparFiltros)
                    oUIContextMenu.Commands.Add(oUICommandExpandirTudo)
                    oUIContextMenu.Commands.Add(oUICommandRecolherExpansao)
                    oUIContextMenu.Commands.Add(oUICommandConfigurarGrid)
                    oUIContextMenu.Commands.Add(oUICommandExportarExcel)
                    oUIContextMenu.Commands.Add(oUICommandAgruparListagem)
                    oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                    AddCommandClick(oUICommand, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandLimpar, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandCopiar, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandGrafico, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandLimparFiltros, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandExpandirTudo, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandRecolherExpansao, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandConfigurarGrid, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandExportarExcel, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClick(oUICommandAgruparListagem, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddMouseClick(oControl, New DelegateMouseClick(AddressOf Grid_MouseClick))
                    AddRowCheckStateChanged(oControl, New DelegateRowCheckStateChanged(AddressOf Grid_RowCheckStateChanged))

                End If

                If TypeOf (oControl) Is TreeView And oControl.Name <> "trvMainGrupo" Then

                    Dim oUICommandManager As New Janus.Windows.UI.CommandBars.UICommandManager
                    Dim oUIContextMenu As New Janus.Windows.UI.CommandBars.UIContextMenu
                    Dim oUICommandSelecionar As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandLimpar As New Janus.Windows.UI.CommandBars.UICommand
                    oUICommandSelecionar.Text = "Selecionar Todos os Registros" : oUICommandSelecionar.Key = "selecionar"
                    oUICommandLimpar.Text = "Limpa Seleção" : oUICommandLimpar.Key = "limpar_selecao"

                    oUICommandManager.Commands.Add(oUICommandSelecionar)
                    oUICommandManager.Commands.Add(oUICommandLimpar)

                    oUIContextMenu.Commands.Add(oUICommandSelecionar)
                    oUIContextMenu.Commands.Add(oUICommandLimpar)

                    oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                    AddCommandClickTreeView(oUICommandSelecionar, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)
                    AddCommandClickTreeView(oUICommandLimpar, New DelegateCommandClick(AddressOf Button_CommandClick), oControl)

                End If


                If TypeOf (oControl) Is MaskedEditBox Then

                    If DirectCast(oControl, MaskedEditBox).Mask.Contains(":") Then

                        AddCommandLostFocusTextBox(oControl, New DelegateLostFocusTextBox(AddressOf AddLostFocusTextBox))

                    End If

                End If


            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddGotFocus(ByVal oControlParent As Control,
                           ByRef oDelegate As DelegateGotFocus)

        Try

            'Váriavel - Controle
            Dim oControl As Control

            For Each oControl In oControlParent.Controls

                'Adiciona Evento ao Controle
                AddHandler oControl.GotFocus, AddressOf oDelegate.Invoke

                'Verifica se existe Controles Internos
                If oControl.Controls.Count > 0 Then
                    AddGotFocus(oControl, oDelegate)
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddButtonClick(ByVal oControlParent As Control,
                              ByRef oDelegate As DelegateButtonClick)

        Try

            'Váriavel - Controle
            Dim oControl As Control

            For Each oControl In oControlParent.Controls

                If TypeOf (oControl) Is UIButton AndAlso oControl.Name = "btnVoltar" Then

                    'Adiciona Evento ao Controle
                    AddHandler oControl.Click, AddressOf oDelegate.Invoke

                End If

                'Verifica se existe Controles Internos
                If oControl.Controls.Count > 0 Then
                    AddButtonClick(oControl, oDelegate)
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddLostFocus(ByVal oControlParent As Control,
                           ByRef oDelegate As DelegateLostFocus)

        Try

            'Váriavel - Controle
            Dim oControl As Control

            For Each oControl In oControlParent.Controls

                'Adiciona Evento ao Controle
                AddHandler oControl.LostFocus, AddressOf oDelegate.Invoke

                'Verifica se existe Controles Internos
                If oControl.Controls.Count > 0 Then
                    AddLostFocus(oControl, oDelegate)
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddValueChanged(ByVal oControlParent As Control,
                               ByRef oDelegate As DelegateValueChanged)

        Try

            'Váriavel - Controle
            Dim oControl As Control
            Dim oNumericEditBox As NumericEditBox

            For Each oControl In oControlParent.Controls

                If TypeOf (oControl) Is NumericEditBox Then

                    oNumericEditBox = oControl
                    'Adiciona Evento ao Controle
                    AddHandler oNumericEditBox.ValueChanged, AddressOf oDelegate.Invoke

                Else

                    'Verifica se existe Controles Internos
                    If oControl.Controls.Count > 0 Then
                        AddValueChanged(oControl, oDelegate)
                    End If

                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddCommandClick(ByVal oControl As Janus.Windows.UI.CommandBars.UICommand,
                               ByRef oDelegate As DelegateCommandClick,
                               ByRef oGrid As GridEX)

        Try

            'Seta Tag
            oControl.Tag = oGrid

            'Adiciona Evento ao Controle
            AddHandler oControl.Click, AddressOf oDelegate.Invoke

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddCommandClickTreeView(ByVal oControl As Janus.Windows.UI.CommandBars.UICommand,
                                       ByRef oDelegate As DelegateCommandClick,
                                       ByRef oTreeView As TreeView)

        Try

            'Seta Tag
            oControl.Tag = oTreeView

            'Adiciona Evento ao Controle
            AddHandler oControl.Click, AddressOf oDelegate.Invoke

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AddCommandLostFocusTextBox(ByVal oControl As Janus.Windows.GridEX.EditControls.MaskedEditBox,
                                          ByRef oDelegate As DelegateLostFocusTextBox)

        Try


            'Adiciona Evento ao Controle
            AddHandler oControl.LostFocus, AddressOf oDelegate.Invoke

        Catch ex As Exception
            Throw ex
        End Try

    End Sub



    Public Sub RemoveValueChanged(ByVal oControlParent As Control,
                                  ByRef oDelegate As DelegateValueChanged)

        Try

            'Váriavel - Controle
            Dim oControl As Control
            Dim oNumericEditBox As NumericEditBox

            For Each oControl In oControlParent.Controls

                If TypeOf (oControl) Is NumericEditBox Then

                    oNumericEditBox = oControl
                    RemoveHandler oNumericEditBox.ValueChanged, AddressOf oDelegate.Invoke

                Else

                    'Verifica se existe Controles Internos
                    If oControl.Controls.Count > 0 Then
                        RemoveValueChanged(oControl, oDelegate)
                    End If

                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ProcuraForm(ByVal sender As Object) As List(Of String)

        Try

            'Instanciando uma lista
            Dim oList As New List(Of String)

            'Percorrendo todos os objetos do projeto
            For Each oForm As Type In sender.GetType().Assembly.GetTypes()

                'Try necessário, pois existem objetos que não consegue pegar o name
                Try

                    'Se for FORM, adicionar na lista
                    If oForm.BaseType.ToString = "System.Windows.Forms.Form" Then
                        'Adicionando na lista
                        oList.Add(oForm.Name)
                    End If

                Catch ex As Exception
                    'Se der problema, passa para o próximo type
                End Try
            Next

            'Retornando a lista
            Return oList

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ProcuraUsrControl(ByVal sender As Object) As List(Of String)

        Try

            'Instanciando uma lista
            Dim oList As New List(Of String)

            'Percorrendo todos os objetos do projeto
            For Each oUsrControl As Type In sender.GetType().Assembly.GetTypes()

                'Try necessário, pois existem objetos que não consegue pegar o name
                Try

                    'Se for FORM, adicionar na lista
                    If oUsrControl.BaseType.ToString = "System.Windows.Forms.UserControl" Then
                        'Adicionando na lista
                        oList.Add(oUsrControl.Name)
                    End If

                Catch ex As Exception
                    'Se der problema, passa para o próximo type
                End Try
            Next

            'Retornando a lista
            Return oList

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub AddAlteracao(ByVal oControlParent As Control,
                            ByRef oDelegate As DelegateTextChanged)

        Try

            'Váriavel - Controle
            Dim oControl As Control

            For Each oControl In oControlParent.Controls

                If TypeOf (oControl) Is UIComboBox Or
                    TypeOf (oControl) Is MaskedEditBox Or
                    TypeOf (oControl) Is EditBox Or
                    TypeOf (oControl) Is NumericEditBox Then

                    AddHandler oControl.TextChanged, AddressOf oDelegate.Invoke

                    'Verifica se existe Controles Internos
                    If oControl.Controls.Count > 0 Then
                        AddAlteracao(oControl, oDelegate)
                    End If

                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ConfigurarEventoGotFocus(ByVal oControle As Control)

        Try

            'Percorrendo todos os controles do controle "pai" para adicionar o evento
            For Each oSubControle As Control In oControle.Controls

                'Adicionando o evento
                AddHandler oSubControle.GotFocus, AddressOf meGotFocus

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ConfigurarBuiltInTextsGrid(ByVal oGrid As GridEX)

        Try

            With oGrid

                .BuiltInTexts.Item(GridEXBuiltInText.CalendarNoneButton) = "Nenhum"
                .BuiltInTexts.Item(GridEXBuiltInText.CalendarTodayButton) = "Hoje"
                .BuiltInTexts.Item(GridEXBuiltInText.DropDownCancelButton) = "Cancelar"
                .BuiltInTexts.Item(GridEXBuiltInText.DropDownOkButton) = "OK"
                .BuiltInTexts.Item(GridEXBuiltInText.EmptyGridInfo) = ""
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionBeginsWith) = "Começa com"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionClear) = "Limpar"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionContains) = "Contêm"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionEndsWith) = "Termina com"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionEqual) = "Igual a"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionGreaterThan) = "Maior que"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionGreaterThanOrEqual) = "Maior ou Igual que"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionIsEmpty) = "{Vazio}"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionLessThan) = "Menor que"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionLessThanOrEqual) = "Menor ou Igual que"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionNotContains) = "Não contêm"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionNotEqual) = "Diferente de"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowConditionNotIsEmpty) = "{Não Vazio}"
                .BuiltInTexts.Item(GridEXBuiltInText.FilterRowInfoText) = "Digite o filtro:"
                .BuiltInTexts.Item(GridEXBuiltInText.GroupByBoxInfo) = "Arraste uma coluna para realizar o agrupamento"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateBeyondNextMonth) = "Depois do mês seguinte"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateEarlierThisMonth) = "Antes do mês atual"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateEmpty) = "Nenhum"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateLastMonth) = "Mês passado"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateNextMonth) = "Mês seguinte"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateOlder) = "Antigo"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateThreeWeeksAgo) = "Três semanas atrás"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateThreeWeeksAway) = "Três semanas para frente"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateToday) = "Hoje"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateTomorrow) = "Amanhã"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateTwoWeeksAgo) = "Duas semanas atrás"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateTwoWeeksAway) = "Duas semanas para frente"
                .BuiltInTexts.Item(GridEXBuiltInText.OutlookDateYesterday) = "Ontem"
                .BuiltInTexts.Item(GridEXBuiltInText.RecordNavigator) = "                         "
                .BuiltInTexts.Item(GridEXBuiltInText.RecordNavigatorError) = "Não é possível selecionar o registro"
                .FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown
                .FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.True
                .FilterRowFormatStyle.ForeColor = System.Drawing.Color.Blue
                .FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(252, 252, 255)
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub meGotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim oSqlDataReader As SqlDataReader

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "nome_formulario"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Value = sNomeFormulario

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "nome_componente"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = CType(sender, Control).Name

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sped_informacao", oSqlParameter)

            If oSqlDataReader.Read Then
                oTxtInformacaoSPED.Text = oSqlDataReader.Item("informacao")
            Else
                oTxtInformacaoSPED.Text = "Não encontrado"
            End If

            oSqlDataReader.Close()
        Catch ex As Exception

            Throw ex
        End Try

    End Sub

    Public Sub AddChildTables(ByVal oGrid As GridEX,
                              ByVal iNumeroTables As Integer)

        Try

            oGrid.RootTable.ChildTables.Clear()
            oGrid.AllowChildTableGroups = True

            If oGrid.Name.ToString.ToUpper.Contains("ORCAMENTO") = False Then
                oGrid.RootTable.Columns(0).Width = 100 + (iNumeroTables * 18)
            End If

            Dim oRefTable As GridEXTable = oGrid.Tables(0)

            For i = 1 To iNumeroTables - 1

                Dim oTableChild As New GridEXTable

                oTableChild.ColumnHeaders = InheritableBoolean.False

                oTableChild.TotalRow = InheritableBoolean.False

                'oGrid.
                Dim dFlag As Boolean = False

                For Each column As GridEXColumn In oRefTable.Columns

                    If column.Key.ToUpper <> "X" Then

                        Dim oColumn As New GridEXColumn

                        oColumn.CellStyle.BackColor = column.CellStyle.BackColor
                        oColumn.AllowDrag = column.AllowDrag
                        oColumn.AllowSize = column.AllowSize
                        oColumn.AllowSort = column.AllowSort
                        oColumn.SelectableCells = column.SelectableCells
                        oColumn.Caption = column.Caption
                        oColumn.ColumnType = column.ColumnType
                        oColumn.FormatString = column.FormatString
                        oColumn.HeaderAlignment = column.HeaderAlignment
                        oColumn.HeaderLineAlignment = column.HeaderAlignment
                        oColumn.Image = column.Image
                        oColumn.LineAlignment = column.LineAlignment
                        oColumn.TextAlignment = column.TextAlignment
                        oColumn.EditType = column.EditType
                        oColumn.Visible = column.Visible
                        oColumn.Width = column.Width
                        oColumn.CellToolTip = column.CellToolTip
                        oColumn.CellToolTipText = column.CellToolTipText
                        oColumn.Key = column.Key
                        oColumn.Tag = column.Tag
                        oColumn.DataMember = column.Key

                        If column.HasValueList = True Then

                            oColumn.HasValueList = True

                            For j As Integer = 0 To column.ValueList.Count - 1

                                oColumn.ValueList.Add(column.ValueList.Item(j).Value, column.ValueList.Item(j).Text)

                            Next

                        End If

                        If oGrid.Name.ToString.ToUpper.Contains("ORCAMENTO") = False Then
                            If dFlag = False Then
                                dFlag = True
                                oColumn.Width = oColumn.Width - (18)
                            End If
                        End If

                        oTableChild.Columns.Add(oColumn)

                    End If

                Next

                oRefTable.ChildTables.Add(oTableChild)

                If i < iNumeroTables Then
                    oRefTable = oRefTable.ChildTables(0)
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub MudarDataSetHierarquia(ByVal oGrid As GridEX,
                                       ByRef oDataSet As DataSet,
                                       ByVal sColumn As String,
                                       ByVal sParentColumn As String)


        Try


            If oDataSet.Tables(0).Rows.Count > 0 And oDataSet.Tables(0).Columns.Contains("nivel") Then

                'Define numero de childs tables e cria o conjunto de datatables
                Dim iNumeroNiveis As Integer = 0
                Dim listDataTable As List(Of Data.DataTable) = New List(Of Data.DataTable)

                For Each oRow As DataRow In oDataSet.Tables(0).Rows

                    If oRow.Item("nivel") > iNumeroNiveis Then

                        iNumeroNiveis = oRow.Item("nivel")
                        Dim newDataTable As Data.DataTable = oDataSet.Tables(0).Clone
                        newDataTable.TableName = newDataTable.TableName + oRow.Item("nivel").ToString
                        newDataTable.ImportRow(oRow)
                        listDataTable.Add(newDataTable)

                    Else

                        If listDataTable.Count = 0 Then

                            Dim newDataTable As Data.DataTable = oDataSet.Tables(0).Clone
                            newDataTable.TableName = newDataTable.TableName + oRow.Item("nivel").ToString
                            newDataTable.ImportRow(oRow)
                            listDataTable.Add(newDataTable)

                        End If

                        Dim oDataTable As Data.DataTable = listDataTable.Item(oRow.Item("nivel") - 1)
                        oDataTable.ImportRow(oRow)

                    End If

                Next


                For Each dt In listDataTable
                    oDataSet.Tables.Add(dt.Copy)
                Next

                For i = 1 To oDataSet.Tables.Count

                    If i + 1 = oDataSet.Tables.Count Then Exit For

                    oDataSet.Relations.Add(oDataSet.Tables(i + 1).TableName, oDataSet.Tables(i).Columns(sColumn), oDataSet.Tables(i + 1).Columns(sParentColumn))

                Next

                AddChildTables(oGrid, iNumeroNiveis)

                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(1).TableName : oGrid.MoveFirst()

                Dim refTable As GridEXTable = oGrid.RootTable

                For i = 1 To iNumeroNiveis

                    If i = iNumeroNiveis Then Exit For

                    refTable.ChildTables(0).DataMember = oDataSet.Tables(i + 1).TableName

                    If refTable.ChildTables.Count = 0 Then Exit For

                    refTable = refTable.ChildTables(0)

                Next

            Else

                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ConfigurarDataMemberGrid(ByVal oGrid As GridEX)

        Try

            With oGrid

                'Percorrendo as colunas
                For Each oCol As GridEXColumn In oGrid.RootTable.Columns
                    'Não atribuir o data member para a coluna de seleção
                    If oCol.Key <> "x" Then
                        'Atribuindo o datamember com o mesmo nome da coluna
                        .RootTable.Columns.Item(oCol.Key).DataMember = oCol.Key
                    End If
                Next

                For Each oChildTables As GridEXTable In oGrid.RootTable.ChildTables

                    For Each oCol As GridEXColumn In oChildTables.Columns

                        If oCol.Key <> "x" Then
                            oChildTables.Columns.Item(oCol.Key).DataMember = oCol.Key
                        End If

                        For Each oChildTables2 As GridEXTable In oChildTables.ChildTables

                            For Each oCol2 As GridEXColumn In oChildTables2.Columns

                                If oCol2.Key <> "x" Then
                                    oChildTables2.Columns.Item(oCol2.Key).DataMember = oCol2.Key
                                End If

                            Next

                            For Each oChildTables3 As GridEXTable In oChildTables2.ChildTables

                                For Each oCol3 As GridEXColumn In oChildTables3.Columns

                                    If oCol3.Key <> "x" Then
                                        oChildTables3.Columns.Item(oCol3.Key).DataMember = oCol3.Key
                                    End If

                                Next

                            Next

                        Next

                    Next
                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function FormataColuna(ByVal sString As String)

        Try

            'Função para formatar o nome da coluna.
            'Ex: sString = "Quantidade_6". Retorno será "Quantidade"

            Dim sReturn As String
            Dim iIndex As Integer = sString.IndexOf("_")

            If iIndex = -1 Then
                sReturn = sString
            Else
                sReturn = sString.Substring(0, iIndex)
            End If

            Return sReturn

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub AjustarChildTables(ByVal oGrid As GridEX,
                                  Optional ByVal eMoving As Janus.Windows.GridEX.ColumnActionEventArgs = Nothing,
                                  Optional ByVal eSizing As Janus.Windows.GridEX.SizingColumnEventArgs = Nothing,
                                  Optional ByVal iNiveis As Integer = 1)

        Try

            Dim oModelTable As GridEXTable = oGrid.RootTable

            Dim hasChild As Boolean = oGrid.RootTable.ChildTables.Count > 0
            Dim oTableParent As GridEXTable = oGrid.RootTable
            Dim iNivelAtual = 1

            While hasChild

                For Each oTable As GridEXTable In oTableParent.ChildTables

                    For Each oColumn As GridEXColumn In oTable.Columns

                        Try
                            If eSizing Is Nothing Then
                                If oColumn.Key <> "nivel" Then
                                    oColumn.Width = oModelTable.Columns(oColumn.Key).Width
                                Else
                                    oColumn.Width = oModelTable.Columns(oColumn.Key).Width + (18 * (iNiveis - iNivelAtual))
                                End If
                            Else
                                If oColumn.Key <> "nivel" And oColumn.Key = eSizing.Column.Key Then
                                    oColumn.Width = eSizing.ProposedWidth
                                Else
                                    If oColumn.Key = "nivel" And eSizing.Column.Key = "nivel" Then
                                        oColumn.Width = eSizing.ProposedWidth + (18 * (iNiveis - iNivelAtual))
                                    Else
                                        If oColumn.Key = "nivel" Then
                                            oColumn.Width = oModelTable.Columns(oColumn.Key).Width + (18 * (iNiveis - iNivelAtual))
                                        Else
                                            If oColumn.Key = eSizing.Column.Key Then
                                                oColumn.Width = eSizing.ProposedWidth
                                            Else
                                                oColumn.Width = oModelTable.Columns(oColumn.Key).Width
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                            'oColumn.Visible = IIf(oColumn.Key = "numero_item", False, oModelTable.Columns(oColumn.Key).Visible)
                            oColumn.Position = oModelTable.Columns(oColumn.Key).Position - 1

                        Catch ex As Exception

                        End Try

                    Next

                Next

                hasChild = oTableParent.ChildTables.Count > 0

                iNivelAtual += 1

                If hasChild Then oTableParent = oTableParent.ChildTables(0)

            End While

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function FormatString(ByVal sString As String)

        Try

            'Função para tratar a quantidade de casas decimais no format string da coluna.
            'Ex: sString = "Quantidade_6", o format string será #,#0.000000 - O _6 é o n° de casas decimais
            'Se não tiver valor direto da procedure, passa 4 casas como padrão.

            Dim sReturn As String = "#,#0." 'Seta o início do format string
            Dim sAux As String = "" 'Variável que irá receber os 0's da casa decimal
            Dim iIndex As Integer = sString.IndexOf("_") 'Procura a posição do underline
            Dim i As Integer = 1

            'Loop para adicionar os 0's na variável texto, conforme a número no nome da coluna
            While i <= IIf(iIndex = -1, -1, sString.Substring(iIndex + 1, 1))

                sAux += "0"

                i += 1

            End While

            'Adiciona as casas decimais
            sReturn += IIf(iIndex = -1, "0000", sAux)

            Return sReturn

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub ConfigurarColunas(ByVal oGrid As GridEX, _
                                 ByVal oDataSet As DataSet, _
                                 Optional ByVal iTable As Integer = 0, _
                                 Optional ByVal bChild As Boolean = False, _
                                 Optional ByVal iTableChild As Integer = 1)

        Try

            Dim bSumFormatString As Boolean
            Dim bVisible As Boolean
            Dim bEditavel As Boolean
            Dim sFormatString As String
            Dim sColuna As String
            Dim sTag As String
            Dim sColunas(0) As String
            Dim i As Integer = 0

            oGrid.FrozenColumns = 0

            'Armazena a coluna pra excluir depois
            For Each oColumn As GridEXColumn In oGrid.RootTable.Columns

                If oColumn.Tag <> "N" Then
                    ReDim Preserve sColunas(sColunas.Count)
                    sColunas(sColunas.Count - 1) = oColumn.Key
                End If

            Next

            'Exclui a coluna de fato
            While i < sColunas.Count

                oGrid.RootTable.Columns.Remove(sColunas(i))

                i += 1

            End While

            i = 0

            While i < oDataSet.Tables(iTable).Columns.Count

                sColuna = oDataSet.Tables(iTable).Columns(i).Caption
                sTag = IIf(sColuna.ToUpper.Contains("_N"), "N", "S")
                bVisible = IIf(sColuna.ToUpper.Contains("_N"), False, True)
                bEditavel = IIf(sColuna.ToUpper.Contains("_I"), True, False)
                bSumFormatString = False

                'Verifica o tipo da coluna, para adicionar a formatação caso necessário.
                If sColuna.ToUpper.Contains("VALOR") Or sColuna.ToUpper.Contains("QUANTIDADE") Or sColuna.ToUpper.Contains("CUSTO") Then
                    sFormatString = FormatString(sColuna)
                    bSumFormatString = IIf(sColuna.ToUpper.Contains("SUMFALSE"), False, True)
                ElseIf sColuna.ToUpper.Contains("DATA") Then
                    sFormatString = "dd/MM/yyyy"
                Else
                    sFormatString = ""
                End If

                Dim oColumn As New GridEXColumn
                oColumn.Caption = FormataColuna(sColuna)
                oColumn.Key = sColuna
                oColumn.Tag = sTag
                oColumn.Width = 100
                oColumn.Visible = bVisible
                oColumn.HideWhenGrouped = InheritableBoolean.False
                oColumn.TextAlignment = IIf(sColuna.ToUpper = "CAMPO", Janus.Windows.GridEX.TextAlignment.Empty, IIf(bSumFormatString = True, Janus.Windows.GridEX.TextAlignment.Far, Janus.Windows.GridEX.TextAlignment.Center))
                oColumn.HeaderAlignment = IIf(sColuna.ToUpper = "CAMPO", Janus.Windows.GridEX.TextAlignment.Empty, Janus.Windows.GridEX.TextAlignment.Center)
                oColumn.HeaderLineAlignment = IIf(sColuna.ToUpper = "CAMPO", Janus.Windows.GridEX.TextAlignment.Empty, Janus.Windows.GridEX.TextAlignment.Center)
                oColumn.LineAlignment = IIf(sColuna.ToUpper = "CAMPO", Janus.Windows.GridEX.TextAlignment.Empty, Janus.Windows.GridEX.TextAlignment.Center)
                oColumn.FilterRowComparison = ConditionOperator.Contains
                oColumn.CharacterCasing = CharacterCasing.Upper
                oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                oColumn.SelectableCells = IIf(bEditavel = False, SelectableCells.FilterRowCells, SelectableCells.All)
                oColumn.FormatString = sFormatString

                'Se a coluna for editável, muda o backcolor da coluna
                If bEditavel = True Then oColumn.CellStyle.BackColor = SystemColors.Info

                'Adiciona o sum das colunas de valor ou quantidade
                If bSumFormatString = True Then
                    oGrid.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
                    oColumn.AggregateFunction = AggregateFunction.Sum
                    oColumn.TotalFormatString = sFormatString
                End If

                'Adiciona Coluna
                oGrid.RootTable.Columns.Add(oColumn)

                i += 1

            End While

            i = 0

            If bChild = True Then

                Dim oTableChild As New GridEXTable
                oGrid.RootTable.ChildTables.Add(oTableChild)
                oGrid.RootTable.ChildTables(0).HeaderLines = 2

                For Each oColumn As GridEXColumn In oGrid.RootTable.ChildTables(0).Columns

                    If oColumn.Tag <> "N" Then
                        ReDim Preserve sColunas(sColunas.Count)
                        sColunas(sColunas.Count - 1) = oColumn.Key
                    End If

                Next

                While i < sColunas.Count

                    oGrid.RootTable.ChildTables(0).Columns.Remove(sColunas(i))

                    i += 1

                End While

                While i < oDataSet.Tables(iTableChild).Columns.Count

                    bSumFormatString = False

                    'Verifica o tipo da coluna, para adicionar a formatação caso necessário.
                    If oDataSet.Tables(iTableChild).Columns(i).Caption.ToUpper.Contains("VALOR") Or oDataSet.Tables(iTableChild).Columns(i).Caption.ToUpper.Contains("QUANTIDADE") Then
                        sFormatString = FormatString(oDataSet.Tables(iTable).Columns(i).Caption)
                        bSumFormatString = True
                    ElseIf oDataSet.Tables(iTableChild).Columns(i).Caption.ToUpper.Contains("DATA") Then
                        sFormatString = "dd/MM/yyyy"
                    Else
                        sFormatString = ""
                    End If

                    'Configura as colunas
                    Dim oColumn As New GridEXColumn
                    oColumn.Caption = FormataColuna(oDataSet.Tables(iTable).Columns(i).Caption)
                    oColumn.Key = oDataSet.Tables(iTableChild).Columns(i).Caption
                    oColumn.Tag = IIf(oDataSet.Tables(iTableChild).Columns(i).Caption.ToUpper.Contains("_N"), "N", "S")
                    oColumn.Width = 100
                    oColumn.Visible = IIf(oDataSet.Tables(iTableChild).Columns(i).Caption.ToUpper.Contains("_N"), False, True)
                    oColumn.HideWhenGrouped = InheritableBoolean.False
                    oColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    oColumn.HeaderLineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    oColumn.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    oColumn.FilterRowComparison = ConditionOperator.Contains
                    oColumn.CharacterCasing = CharacterCasing.Upper
                    oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                    oColumn.SelectableCells = SelectableCells.FilterRowCells
                    oColumn.FormatString = sFormatString

                    'Adiciona o sum das colunas de valor ou quantidade
                    If bSumFormatString = True Then
                        oColumn.AggregateFunction = AggregateFunction.Sum
                        oColumn.TotalFormatString = sFormatString
                    End If

                    'Adiciona Coluna na Child
                    oGrid.RootTable.ChildTables(0).Columns.Add(oColumn)

                    i += 1

                End While

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ConfigurarDataCheckedComboBox(ByVal oCheckedComboBox As CheckedComboBox)
        Try

            'Percorrendo as colunas
            For Each oCol As GridEXColumn In oCheckedComboBox.DropDownList.Columns
                'Não atribuir o data member para a coluna de seleção
                If oCol.Key <> "x" Then
                    'Atribuindo o datamember com o mesmo nome da coluna
                    oCheckedComboBox.DropDownList.Columns.Item(oCol.Key).DataMember = oCol.Key
                End If
            Next

            oCheckedComboBox.DropDownDisplayMember = "descricao"
            oCheckedComboBox.DropDownValueMember = "codigo"
            oCheckedComboBox.DropDownList.GridLineStyle = GridLineStyle.Solid
            oCheckedComboBox.DropDownList.SelectedFormatStyle.BackColor = Nothing
            oCheckedComboBox.DropDownList.SelectedFormatStyle.ForeColor = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LimparCamposGroupBox(ByVal oGroupBox As Janus.Windows.EditControls.UIGroupBox)

        Try
            For Each oControl As Object In oGroupBox.Controls

                If oControl.GetType.Name = "NumericEditBox" Then
                    oControl.value = 0
                ElseIf oControl.GetType.Name = "MaskedEditBox" Then
                    oControl.text = ""
                ElseIf oControl.GetType.Name = "MaskedEditBox" Then
                    oControl.text = ""
                ElseIf oControl.GetType.Name = "UIComboBox" Then
                    oControl.selectedindex = -1
                ElseIf oControl.GetType.Name = "DateTimePicker" Then
                    oControl.value = Now
                ElseIf oControl.GetType.Name = "CalendarCombo" Then
                    oControl.value = Now
                ElseIf oControl.GetType.Name = "EditBox" Then
                    oControl.text = ""
                ElseIf oControl.GetType.Name = "TextBox" Then
                    oControl.text = ""
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExportExcel(ByVal oGrid As GridEX)

        Try

            'Váriavel Local
            Dim oForm As New frmIntExportExcel
            'Seta Parâmetro
            oForm.Grid = oGrid
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub EnviarEmail(ByVal sSubject As String, _
                           ByVal sPara As String, _
                           ByVal sAnexo As String, _
                           ByVal sAnexoPath As String, _
                           ByVal sBody As String, _
                           ByVal iCodigoParceiroNegocio As Integer, _
                           Optional ByVal sBcc As String = "", _
                           Optional ByVal lCodigoEmissaoCapa As Long = -1, _
                           Optional ByVal lCodigoPedidoCompra As Long = -1, _
                           Optional ByVal iCodigoTipoEmail As TipoAutotextoEmail = TipoAutotextoEmail.Outros, _
                           Optional ByVal bDireto As Boolean = False, _
                           Optional ByVal sFrom As String = "")

        Try

            'Carrega Configuração do E-mail
            Call LoadConfiguracaoEmail()

            'Verifica a Forma de Envio do E.mail
            If goEmail.iCodigoFormaEnvio = -1 Then

                'Informa o usuário que não tem a configuração de E-mail
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Configuração de E-mail")

            ElseIf goEmail.iCodigoFormaEnvio = CInt(TipoEmail.Interacti) Then

                'Formulário de Envio de E-mail
                Dim oForm As New frmEmail

                'Seta Tamanho / Posição do Controle
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

                'Seta Parâmetros do Formulário
                oForm.Para = sPara
                oForm.Subject = sSubject
                oForm.Anexo = sAnexo
                oForm.Body = sBody
                oForm.BCc = sBcc
                oForm.AnexoPath = sAnexoPath
                oForm.CodigoParceiroNegocio = iCodigoParceiroNegocio
                oForm.CodigoEmissaoCapa = lCodigoEmissaoCapa
                oForm.CodigoPedidoCompra = lCodigoPedidoCompra
                oForm.CodigoTipoEmail = iCodigoTipoEmail
                oForm.EnvioDireto = bDireto

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog()

            ElseIf goEmail.iCodigoFormaEnvio = CInt(TipoEmail.Outlook) Then

                'Envia E-mail pelo Outlook
                Call SendEmailOutlook(sPara, _
                                      "", _
                                      sBcc, _
                                      sSubject, _
                                      sBody, _
                                      sAnexoPath, _
                                      bDireto, _
                                      sFrom)

                'Verifica se é uma Nota Fiscal Eletrônica
                If lCodigoEmissaoCapa <> 0 Then
                    'Atauliza o Status - Faturamento
                    Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe
                    oClsFatEmissaoNFe.UpdateStatusNotaFiscal(lCodigoEmissaoCapa, _
                                                             StatusNotaFiscalEletronica.EnviadoDestinatario)
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SendEmailOutlook(ByVal sTo As String, _
                                 ByVal sCc As String, _
                                 ByVal sBCc As String, _
                                 ByVal sSubject As String, _
                                 ByVal sBody As String, _
                                 ByVal sAnexo As String, _
                                 ByVal bDireto As Boolean, _
                                 ByVal sFrom As String)

        Try

            'Váriaveis Locais
            Dim oOutlookApplication As New Outlook.Application()
            Dim oMailItem As Outlook.MailItem
            Dim sAnexoPath As String()

            'Cria E-mail
            oMailItem = oOutlookApplication.CreateItem(Outlook.OlItemType.olMailItem)

            If sFrom <> "" Then
                For Each oAccount As Microsoft.Office.Interop.Outlook.Account In oOutlookApplication.Session.Accounts

                    If oAccount.SmtpAddress = sFrom Or oAccount.DisplayName = sFrom Then
                        oMailItem.SendUsingAccount = oAccount
                    End If

                Next

                'oMailItem.SentOnBehalfOfName = sFrom

            End If

            'Carrega Dados
            oMailItem.Subject = sSubject
            If sBody.ToUpper.Contains("<HTML>") Then
                oMailItem.HTMLBody = sBody
            Else
                oMailItem.Body = sBody
            End If
            If sTo <> "" Then oMailItem.To = sTo
            If sCc <> "" Then oMailItem.CC = sCc
            If sBCc <> "" Then oMailItem.BCC = sBCc
            sAnexoPath = sAnexo.Split(";")
            For i = 0 To UBound(sAnexoPath)
                If sAnexoPath(i) <> "" Then oMailItem.Attachments.Add(sAnexoPath(i).ToString.Trim)
            Next i

            'Abre Formulário
            If bDireto = False Then
                oMailItem.Display()
            Else
                oMailItem.Send()
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SendEmail(ByVal sTo() As String, _
                         ByVal sCc() As String, _
                         ByVal sBCc() As String, _
                         ByVal sSubject As String, _
                         ByVal sBody As String, _
                         ByVal sAnexo() As String)

        Try

            'Váriaveis Locais
            Dim i As Integer

            'Cria uma instância do objeto MailMessage
            Dim mMailMessage As New MailMessage()

            'Configura Dados do E-maiç
            mMailMessage.From = New MailAddress(goEmail.sEmail)

            For i = 0 To UBound(sTo)
                If sTo(i) <> "" Then mMailMessage.To.Add(New MailAddress(sTo(i)))
            Next i
            For i = 0 To UBound(sCc)
                If sCc(i) <> "" Then mMailMessage.CC.Add(New MailAddress(sCc(i)))
            Next i
            For i = 0 To UBound(sBCc)
                If sBCc(i) <> "" Then mMailMessage.Bcc.Add(New MailAddress(sBCc(i)))
            Next i
            For i = 0 To UBound(sAnexo)
                If sAnexo(i) <> "" Then mMailMessage.Attachments.Add(New Attachment(sAnexo(i)))
            Next i
            mMailMessage.Subject = sSubject
            mMailMessage.Priority = MailPriority.High
            mMailMessage.IsBodyHtml = True

            'Define o corpo da mensagem
            mMailMessage.Body = sBody

            'Cria uma instância de SmtpClient
            Dim mSmtpClient As New SmtpClient

            'Configuração do Servidor
            mSmtpClient.Host = goEmail.sServidor
            mSmtpClient.Port = goEmail.iPorta
            If Not goEmail.sSenha Is Nothing Then
                mSmtpClient.Credentials = New System.Net.NetworkCredential(goEmail.sUsuario, goEmail.sSenha)
                mSmtpClient.EnableSsl = goEmail.bSsl
            End If

            'Envia o email
            mSmtpClient.Send(mMailMessage)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SendEmail(ByVal sTo As String, _
                         ByVal sCc As String, _
                         ByVal sBCc As String, _
                         ByVal sSubject As String, _
                         ByVal sBody As String, _
                         ByVal sAnexo() As String)

        Try

            'Cria uma instância do objeto MailMessage
            Dim mMailMessage As New MailMessage()

            'Configura Dados do E-maiç
            mMailMessage.From = New MailAddress(goEmail.sEmail)

            If sTo <> "" Then mMailMessage.To.Add(New MailAddress(sTo))
            If sCc <> "" Then mMailMessage.CC.Add(New MailAddress(sCc))
            If sBCc <> "" Then mMailMessage.Bcc.Add(New MailAddress(sBCc))
            For i = 0 To UBound(sAnexo)
                If sAnexo(i) <> "" Then mMailMessage.Attachments.Add(New Attachment(sAnexo(i)))
            Next i
            mMailMessage.Subject = sSubject
            mMailMessage.Priority = MailPriority.High
            mMailMessage.IsBodyHtml = True

            'Define o corpo da mensagem
            mMailMessage.Body = sBody

            'Cria uma instância de SmtpClient
            Dim mSmtpClient As New SmtpClient

            'Configuração do Servidor
            mSmtpClient.Host = goEmail.sServidor
            mSmtpClient.Port = goEmail.iPorta
            If Not goEmail.sSenha Is Nothing Then
                mSmtpClient.Credentials = New System.Net.NetworkCredential(goEmail.sUsuario, goEmail.sSenha)
                mSmtpClient.EnableSsl = goEmail.bSsl
            End If

            'Envia o email
            mSmtpClient.Send(mMailMessage)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SendEmail(ByVal sTo As String, _
                         ByVal sCc As String, _
                         ByVal sBCc As String, _
                         ByVal sSubject As String, _
                         ByVal sBody As String, _
                         ByVal sAnexo As String, _
                         Optional ByVal sServidor As String = "", _
                         Optional ByVal iPorta As Integer = 0, _
                         Optional ByVal sSenha As String = "", _
                         Optional ByVal sUsuario As String = "", _
                         Optional ByVal bSSL As Boolean = False)

        Try

            'Carrega Dados do Email
            Call LoadConfiguracaoEmail()

            'Configura Servidor de E-mail
            If sServidor = "" Then
                sServidor = goEmail.sServidor
                sUsuario = goEmail.sUsuario
                sSenha = goEmail.sSenha
                iPorta = goEmail.iPorta
                bSSL = goEmail.bSsl
            End If

            'Cria uma instância do objeto MailMessage
            Dim mMailMessage As New MailMessage()

            'Configura Dados do E-maiç
            mMailMessage.From = New MailAddress(goEmail.sEmail)

            If sTo <> "" Then
                If sTo.Contains(";") Then
                    Dim sPara() As String = sTo.Split(";")
                    For i = 0 To UBound(sPara)
                        mMailMessage.To.Add(New MailAddress(sPara(i)))
                    Next
                Else
                    mMailMessage.To.Add(New MailAddress(sTo))
                End If
            End If
            If sCc <> "" Then
                If sCc.Contains(";") Then
                    Dim sCopia() As String = sCc.Split(";")
                    For i = 0 To UBound(sCopia)
                        mMailMessage.To.Add(New MailAddress(sCopia(i)))
                    Next
                Else
                    mMailMessage.To.Add(New MailAddress(sCc))
                End If
            End If
            If sBCc <> "" Then
                If sBCc.Contains(";") Then
                    Dim sCopiaOculta() As String = sBCc.Split(";")
                    For i = 0 To UBound(sCopiaOculta)
                        mMailMessage.To.Add(New MailAddress(sCopiaOculta(i)))
                    Next
                Else
                    mMailMessage.To.Add(New MailAddress(sBCc))
                End If
            End If
            If sAnexo <> "" Then
                If sAnexo.Contains(";") Then
                    Dim sArquivoAnexo() As String = sAnexo.Split(";")
                    For i = 0 To UBound(sArquivoAnexo)
                        mMailMessage.Attachments.Add(New Attachment(sArquivoAnexo(i)))
                    Next
                Else
                    mMailMessage.Attachments.Add(New Attachment(sAnexo))
                End If
            End If
            mMailMessage.Subject = sSubject
            mMailMessage.Priority = MailPriority.High
            mMailMessage.IsBodyHtml = True

            'Define o corpo da mensagem
            mMailMessage.Body = sBody

            'Cria uma instância de SmtpClient
            Dim mSmtpClient As New SmtpClient

            'Configuração do Servidor
            mSmtpClient.Host = sServidor
            mSmtpClient.Port = iPorta
            If Not sSenha Is Nothing Then
                mSmtpClient.Credentials = New System.Net.NetworkCredential(sUsuario, sSenha)
                mSmtpClient.EnableSsl = bSSL
            End If

            'Envia o email
            mSmtpClient.Send(mMailMessage)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ClearUnboundGrid(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim oRow As GridEXRow

            oGrid.Refresh()

            For Each oRow In oGrid.GetDataRows
                oRow.Delete()
                oGrid.Refresh()
            Next

        Catch ex As Exception
            'Throw ex
        End Try

    End Sub

    Public Sub LoadCombo(ByVal oComboBox As UIComboBox, _
                         ByVal sQuery As String, _
                         Optional ByVal sQuery2 As String = "", _
                         Optional ByVal TipoCombo As TipoComboBox() = Nothing)

        'Variaveis Locais
        Dim oDataSet As DataSet

        Try

            'Obtem o DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            With oComboBox

                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"

            End With

            'Verifica se tem a Query2
            If sQuery2 <> "" Then

                'Carrega DataReader
                Dim oSqlDataReader As SqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery2)

                While oSqlDataReader.Read

                    For Each oTipoCombo As TipoComboBox In TipoCombo
                        If oSqlDataReader.Item("tipo").ToString = oTipoCombo.sTipo Then
                            oComboBox.Items(oSqlDataReader.Item("codigo")).FormatStyle.ForeColor = oTipoCombo.oColor
                            Exit For
                        End If
                    Next

                End While

                'Fecha o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadCombo(ByVal oComboBox As CheckedComboBox, _
                         ByVal sQuery As String)

        'Variaveis Locais
        Dim oDataSet As DataSet

        Try

            'Obtem o DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            With oComboBox

                .DropDownDataSource = Nothing
                Call ConfigurarDataCheckedComboBox(oComboBox)
                .DropDownDataSource = oDataSet.Tables(0)
                .DropDownDataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadCombo(ByVal oComboBox As MTGCComboBox, _
                         ByVal sQuery As String, _
                         ByVal sColumn() As String)

        'Variaveis Locais
        Dim oDataSet As DataSet

        Try

            'Obtem o DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            With oComboBox

                .SelectedIndex = -1
                .Text = ""
                .Items.Clear()
                .LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
                .SourceDataString = sColumn
                .ValueMember = "codigo"
                .SourceDataTable = oDataSet.Tables(0)

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub VerificaComboCodigoExistente(ByVal oComboBox As UIComboBox, _
                                            ByVal iCodigo As Integer)

        Try

            If oComboBox.Items.Count <= 0 Then Exit Sub

            For i As Integer = 0 To oComboBox.Items.Count - 1

                If oComboBox.Items(i).Value = iCodigo Then
                    oComboBox.SelectedValue = iCodigo
                    Exit Sub
                Else
                    oComboBox.SelectedIndex = -1
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadCombo(ByVal oComboBox As UIComboBox, _
                         ByVal sQuery As String, _
                         ByVal bSeleciona As Boolean, _
                         Optional ByVal sQuery2 As String = "", _
                         Optional ByVal TipoCombo As TipoComboBox() = Nothing)

        'Variaveis Locais
        Dim oDataSet As DataSet

        Try

            'Obtem o DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            With oComboBox

                oComboBox.Text = ""
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"

                If oComboBox.Items.Count = 1 And bSeleciona = True Then
                    oComboBox.SelectedIndex = 0
                Else
                    .SelectedIndex = -1
                End If

            End With

            'Verifica se tem a Query2
            If sQuery2 <> "" Then

                'Carrega DataReader
                Dim oSqlDataReader As SqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery2)

                While oSqlDataReader.Read

                    For Each oTipoCombo As TipoComboBox In TipoCombo
                        If oSqlDataReader.Item("tipo").ToString = oTipoCombo.sTipo Then
                            oComboBox.Items(oSqlDataReader.Item("codigo")).FormatStyle.ForeColor = oTipoCombo.oColor
                            Exit For
                        End If
                    Next

                End While

                'Fecha o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadCombo(ByVal oComboBox As MultiColumnCombo, _
                         ByVal sQuery As String)

        'Variaveis Locais
        Dim oDataSet As DataSet

        Try

            'Obtem o DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            With oComboBox

                .DataSource = oDataSet.Tables(0)

                .ValueMember = "codigo"
                .DropDownList.Columns(0).DataMember = "codigo_item"
                .DropDownList.Columns(1).DataMember = "descricao"
                .DisplayMember = "descricao"

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboAno(ByVal oComboBox As UIComboBox, _
                            ByVal iAnoInicio As Integer, _
                            ByVal iNumeroAnos As Integer)

        Try

            'Váriaveis Locais
            Dim i As Integer

            'Carrega Grid
            With oComboBox

                'Limpa Combo
                .Items.Clear()

                'Adiciona Item a Combo
                For i = iAnoInicio To iAnoInicio + iNumeroAnos
                    .Items.Add(i, i)
                Next i

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboAno(ByVal oComboBox() As UIComboBox, _
                            ByVal iAnoInicio As Integer, _
                            ByVal iNumeroAnos As Integer)

        Try

            'Váriaveis Locais
            Dim i As Integer
            Dim j As Integer

            For i = 0 To UBound(oComboBox)

                'Limpa Combo
                oComboBox(i).Items.Clear()

                'Adiciona Item a Combo
                For j = iAnoInicio To (iAnoInicio + iNumeroAnos)
                    oComboBox(i).Items.Add(j, j)
                Next j

            Next i

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboMes(ByVal oComboBox As UIComboBox)

        Try

            'Limpa Combo
            oComboBox.Items.Clear()

            'Adiciona Item a Combo
            oComboBox.Items.Add("JANEIRO", 1)
            oComboBox.Items.Add("FEVEREIRO", 2)
            oComboBox.Items.Add("MARÇO", 3)
            oComboBox.Items.Add("ABRIL", 4)
            oComboBox.Items.Add("MAIO", 5)
            oComboBox.Items.Add("JUNHO", 6)
            oComboBox.Items.Add("JULHO", 7)
            oComboBox.Items.Add("AGOSTO", 8)
            oComboBox.Items.Add("SETEMBRO", 9)
            oComboBox.Items.Add("OUTUBRO", 10)
            oComboBox.Items.Add("NOVEMBRO", 11)
            oComboBox.Items.Add("DEZEMBRO", 12)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboDia(ByVal oComboBox As UIComboBox)

        Try

            'Váriaveis Locais
            Dim i As Integer

            'Carrega Grid
            With oComboBox

                'Limpa Combo
                .Items.Clear()

                'Adiciona Item a Combo
                For i = 1 To 31
                    .Items.Add(i, i)
                Next i

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboNumeroMes(ByVal oComboBox As UIComboBox)

        Try

            'Váriaveis Locais
            Dim i As Integer

            'Carrega Grid
            With oComboBox

                'Limpa Combo
                .Items.Clear()

                'Adiciona Item a Combo
                For i = 1 To 12
                    .Items.Add(i, i)
                Next i

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboDia(ByVal oComboBox() As UIComboBox)

        Try

            'Váriaveis Locais
            Dim i As Integer
            Dim j As Integer

            For i = 0 To UBound(oComboBox)

                'Limpa Combo
                oComboBox(i).Items.Clear()

                'Adiciona Item a Combo
                For j = 1 To 31
                    oComboBox(i).Items.Add(j, j)
                Next j

            Next i

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboSimNao(ByVal oComboBox As UIComboBox)

        Try

            'Carrega Grid
            With oComboBox

                'Limpa Combo
                .Items.Clear()

                If goUsuario.iIdioma = Idioma.Portugues Then
                    .Items.Add("SIM", True)
                    .Items.Add("NÃO", False)
                ElseIf goUsuario.iIdioma = Idioma.Ingles Then
                    .Items.Add("YES", True)
                    .Items.Add("NO", False)
                End If

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboColunasGrid(ByVal oComboBox As UIComboBox, _
                                    ByVal oGrid As GridEX)

        Try

            'Carrega Grid
            With oComboBox

                'Limpa Combo
                .Items.Clear() : .Text = ""

                For Each oColumn As GridEXColumn In oGrid.RootTable.Columns
                    If oColumn.Tag = "S" Then
                        .Items.Add(oColumn.Caption, oColumn.Position + 1)
                    End If
                Next

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadCombo(ByVal oComboBox() As UIComboBox, _
                         ByVal sQuery As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim i As Integer

        Try

            'Obtem o DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            For i = 0 To UBound(oComboBox)

                oComboBox(i).DataSource = oDataSet.Tables(0)
                oComboBox(i).ValueMember = "CODIGO"
                oComboBox(i).DisplayMember = "DESCRICAO"
                oComboBox(i).SelectedIndex = -1

                If InStr(oComboBox(i).Name, "Filtro", CompareMethod.Text) = 0 Then
                    If oComboBox(i).Items.Count = 1 Then
                        oComboBox(i).SelectedIndex = 0
                    End If
                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadCombo(ByVal oComboBox() As CheckedComboBox, _
                         ByVal sQuery As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim i As Integer

        Try

            'Obtem o DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            For i = 0 To UBound(oComboBox)

                oComboBox(i).DropDownList.Columns.Item("descricao").DataMember = "descricao"
                oComboBox(i).DropDownList.Columns.Item("codigo").DataMember = "codigo"
                oComboBox(i).DropDownDataSource = oDataSet.Tables(0)
                oComboBox(i).DropDownDisplayMember = "descricao"
                oComboBox(i).DropDownValueMember = "codigo"
                oComboBox(i).DropDownDataMember = oDataSet.Tables(0).TableName

            Next i

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadCombo(ByVal oComboBox() As UIComboBox, _
                         ByVal sQuery As String, _
                         ByVal bSeleciona As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim i As Integer

        Try

            'Obtem o DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            For i = 0 To UBound(oComboBox)

                oComboBox(i).DataSource = oDataSet.Tables(0)
                oComboBox(i).ValueMember = "CODIGO"
                oComboBox(i).DisplayMember = "DESCRICAO"
                oComboBox(i).SelectedIndex = -1

                If InStr(oComboBox(i).Name, "Filtro", CompareMethod.Text) = 0 And bSeleciona = True Then
                    oComboBox(i).SelectedIndex = 0
                Else
                    oComboBox(i).SelectedIndex = -1
                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboAZ(ByVal oComboBox() As UIComboBox)

        'Variaveis Locais
        Dim i As Integer
        Dim j As Integer

        Try

            'Carrega Grid
            For i = 0 To UBound(oComboBox)

                For j = 0 To 25
                    oComboBox(i).Items.Add(Chr(j + 65), Chr(j + 65))
                Next
                For j = 0 To 25
                    oComboBox(i).Items.Add("A" & Chr(j + 65), "A" & Chr(j + 65))
                Next

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sQuery As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, sQuery)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridLogAlteracao(ByVal oGrid As GridEX, _
                                    ByVal sTabela As String, _
                                    ByVal lCodigo As Long, _
                                    Optional ByVal iCodigo2 As Integer = -1, _
                                    Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo2 : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo3

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_log_alteracao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function NumeroToLetraExcel(ByVal iNumero As Integer) As String

        Try

            If iNumero > 26 Then
                Return "A" & Chr(iNumero - 26 + 64)
            Else
                Return Chr(iNumero + 64)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadComboGrid(ByVal oGrid As GridEX, _
                             ByVal sColumn As String, _
                             ByVal sQuery As String, _
                             Optional ByVal sColunaQuery As String = "")

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim iContador As Integer
        Dim oValor As Object

        Try

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            With oGrid.RootTable.Columns(sColumn).ValueList

                'Limpa Coluna - Grid
                .Clear()

                'Reseta Váriavel
                iContador = 0

                Do While oSqlDataReader.Read
                    .Add(oSqlDataReader.Item("codigo"), oSqlDataReader.Item("descricao"))
                    oValor = oSqlDataReader.Item("codigo")
                    iContador = iContador + 1
                Loop

                If iContador = 1 And sColunaQuery <> "" Then
                    For Each oRow As GridEXRow In oGrid.GetDataRows
                        UpdateRegistroGrid(oGrid, sColunaQuery & " = " & oRow.Cells("parcela").Value, sColumn, oValor)
                    Next
                End If

                'Fecha o DataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboGridDia(ByVal oGrid As GridEX, _
                                ByVal sColumn As String)

        'Variaveis Locais
        Dim i As Integer
        Dim oValor As Object

        Try

            'Carrega Grid
            With oGrid.RootTable.Columns(sColumn).ValueList

                'Limpa Coluna - Grid
                .Clear()

                For i = 1 To 31
                    .Add(i, i)
                Next i

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboGridMes(ByVal oGrid As GridEX, _
                                ByVal sColumn As String)

        'Variaveis Locais
        Dim i As Integer
        Dim oValor As Object

        Try

            'Carrega Grid
            With oGrid.RootTable.Columns(sColumn).ValueList

                'Limpa Coluna - Grid
                .Clear()

                For i = 1 To 12
                    .Add(i, i)
                Next i

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadComboGridChildren(ByVal oGrid As GridEX, _
                                     ByVal sColumn As String, _
                                     ByVal sQuery As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader

        Try

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            'Carrega Grid
            With oGrid.RootTable.ChildTables(0).Columns(sColumn).ValueList

                .Clear()

                Do While oSqlDataReader.Read
                    .Add(oSqlDataReader.Item("codigo"), oSqlDataReader.Item("descricao"))
                Loop

                'Fecha o DataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DescompactarArquivo(ByVal sArquivoOrigem As String, _
                                   ByVal sArquivoDestino As String)

        Try

            Using oZipFile As ZipFile = ZipFile.Read(sArquivoOrigem)
                Dim e As ZipEntry
                ' here, we extract every entry, but we could extract conditionally,
                ' based on entry name, size, date, checkbox status, etc.   
                For Each e In oZipFile
                    e.Extract(sArquivoDestino, ExtractExistingFileAction.OverwriteSilently)
                Next
            End Using

        Catch ex As Exception
            'Throw ex
        End Try

    End Sub

    Public Sub TratamentoErro(ByVal sErro As String, _
                              ByVal sFormulario As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        'Seta Parametros - Código Usuário
        oSqlParameter(0) = New SqlParameter
        oSqlParameter(0).ParameterName = "codigo_usuario"
        oSqlParameter(0).Direction = ParameterDirection.Input
        oSqlParameter(0).SqlDbType = SqlDbType.Int
        oSqlParameter(0).Value = goUsuario.iUsuario

        'Seta Parametros - Erro
        oSqlParameter(1) = New SqlParameter
        oSqlParameter(1).ParameterName = "erro"
        oSqlParameter(1).Direction = ParameterDirection.Input
        oSqlParameter(1).SqlDbType = SqlDbType.VarChar
        oSqlParameter(1).Size = 500
        oSqlParameter(1).Value = sErro.Trim

        'Seta Parametros - Formulário
        oSqlParameter(2) = New SqlParameter
        oSqlParameter(2).ParameterName = "formulario"
        oSqlParameter(2).Direction = ParameterDirection.Input
        oSqlParameter(2).SqlDbType = SqlDbType.VarChar
        oSqlParameter(2).Size = 50
        oSqlParameter(2).Value = sFormulario.Trim

        'Executa Query
        ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_log_erro", oSqlParameter)

        'If sErro.IndexOf("FK_") > 0 Then
        '    'Informa o Usuário sobre o Erro Ocorrido
        '    frmMain.Informacao(Mensagem.FK)
        'Else
        'Informa o Usuário sobre o Erro Ocorrido
        frmMain.Informacao(Mensagem.Erro, sErro)
        'End If

        'Seta Cursor do Mouse 
        Cursor.Current = Cursors.Default

    End Sub

    Public Sub ImprimirPedidoVendaMatricial(ByVal lCodigoPedido As Long)

        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim oSqlDataReader As SqlDataReader
            Dim i As Integer = 0

            'Váriaveis Locais - Arquivo
            Dim sDados() As String
            Dim iNumeroLinha As Integer = 31
            Dim iAux As Integer = 0
            Dim sPathArquivo As String
            Dim iNumeroRegistros As Integer = CType(LoadDescricao("sp_report_ven000000002_LPT1_01 " & lCodigoPedido & ", " & goUsuario.iEmpresa), Integer)
            Dim dValorFinal As Double

            'Seta Parametros - Codigo Orcamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            'oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_report_ven000000002_LPT1", oSqlParameter)

            'Inicializa Vetor
            ReDim sDados(0)

            While oSqlDataReader.Read

                'Verifica se o Vetor está carregado
                If sDados(UBound(sDados)) <> "" Then
                    ReDim Preserve sDados(UBound(sDados) + 1)
                End If

                If UBound(sDados) = iAux Then
                    ReDim Preserve sDados(UBound(sDados) + 10)
                    sDados(iAux + 0) = Chr(27) & Chr(64) & Chr(27) & Chr(54) & Chr(27) & Chr(116) & Chr(1) & Chr(27) & Chr(120) & Chr(48) & Chr(27) & Chr(33) & Chr(1) & Chr(27) & Chr(50) & Chr(27) & Chr(108) & Chr(1) & Chr(27) & Chr(67) & Chr(33)
                    sDados(iAux + 0) &= "D.A COUTINHO E CIA LTDA                  Fone: (12) 3951-1471            Pag.: " & Format((iAux / iNumeroLinha) + 1, "00")
                    sDados(iAux + 1) = "-------------------PRACA INDEPENDENCIA, 107-SAO JOAO-JACAREI/SP  12322-570-------------------"
                    sDados(iAux + 2) = "PEDIDO  : " + oSqlDataReader("numero_pedido").ToString + "                     " + "DATA PEDIDO : " + oSqlDataReader("data_pedido").ToString
                    sDados(iAux + 3) = "CLIENTE : " + oSqlDataReader("codigo_cliente").ToString + " - " + oSqlDataReader("cliente").ToString
                    sDados(iAux + 4) = "ENTREGA : " + oSqlDataReader("logradouro_cliente").ToString + ", " + oSqlDataReader("numero_cliente").ToString + oSqlDataReader("complemento_cliente").ToString
                    sDados(iAux + 5) = "BAIRRO : " + oSqlDataReader("bairro_cliente").ToString + "          " + "CIDADE : " + oSqlDataReader("municipio_cliente").ToString + "          " + "CEP : " + oSqlDataReader("cep_cliente").ToString
                    sDados(iAux + 6) = "FONE : " + oSqlDataReader("telefone_cliente").ToString + "          " + "CNPJ : " + oSqlDataReader("cnpj_cliente").ToString + "         " + "IE : " + oSqlDataReader("inscricao_estadual_cliente").ToString
                    sDados(iAux + 7) = "COND. PAGTO : " + oSqlDataReader("condicao_pagamento").ToString + "         " + "VENDEDOR : " + oSqlDataReader("vendedor").ToString + "           " + "CONTATO : " + oSqlDataReader("nome_contato").ToString
                    sDados(iAux + 8) = "============================================================================================="
                    sDados(iAux + 9) = "EQuant. Un Descricao do produto                               Marca        Unitario      TotalF"
                    iAux += iNumeroLinha
                End If

                sDados(UBound(sDados)) = oSqlDataReader("quantidade").ToString
                sDados(UBound(sDados)) &= oSqlDataReader("sigla").ToString
                sDados(UBound(sDados)) &= oSqlDataReader("descricao").ToString
                'sDados(UBound(sDados)) &= oSqlDataReader("codigo_ncm").ToString
                sDados(UBound(sDados)) &= oSqlDataReader("marca").ToString
                sDados(UBound(sDados)) &= Space(8 - oSqlDataReader("valor_unitario").ToString.Trim.Length) & oSqlDataReader("valor_unitario").ToString.Trim
                sDados(UBound(sDados)) &= Space(12 - oSqlDataReader("valor_total").ToString.Trim.Length) & oSqlDataReader("valor_total").ToString.Trim

                dValorFinal = oSqlDataReader.Item("valor_final")

            End While

            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = "............................................................................................."
            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Format(iNumeroRegistros, "000") & " Itens"
            sDados(UBound(sDados)) &= Space(65)
            sDados(UBound(sDados)) &= "Total =>"
            sDados(UBound(sDados)) &= Space(9 - dValorFinal.ToString.Trim.Length) & dValorFinal.ToString.Trim

            'Verifica se tem Necessidade de um novo Cabeçalho
            If UBound(sDados) = iAux Then
                ReDim Preserve sDados(UBound(sDados) + 9)
                sDados(iAux + 0) = Chr(27) & Chr(64) & Chr(27) & Chr(54) & Chr(27) & Chr(116) & Chr(1) & Chr(27) & Chr(120) & Chr(48) & Chr(27) & Chr(33) & Chr(1) & Chr(27) & Chr(50) & Chr(27) & Chr(108) & Chr(1) & Chr(27) & Chr(67) & Chr(33)
                sDados(iAux + 0) &= "D.A COUTINHO E CIA LTDA                  Fone: (12) 3951-1471            Pag.: " & Format((iAux / iNumeroLinha) + 1, "00")
                sDados(iAux + 1) = "-------------------PRACA INDEPENDENCIA, 107-SAO JOAO-JACAREI/SP  12322-570-------------------"
                sDados(iAux + 2) = "PEDIDO  : " + oSqlDataReader("numero_pedido").ToString + "                     " + "DATA PEDIDO : " + oSqlDataReader("data_pedido").ToString
                sDados(iAux + 3) = "CLIENTE : " + oSqlDataReader("codigo_cliente").ToString + " - " + oSqlDataReader("cliente").ToString
                sDados(iAux + 4) = "ENTREGA : " + oSqlDataReader("logradouro_cliente").ToString + ", " + oSqlDataReader("numero_cliente").ToString + oSqlDataReader("complemento_cliente").ToString
                sDados(iAux + 5) = "BAIRRO : " + oSqlDataReader("bairro_cliente").ToString + "          " + "CIDADE : " + oSqlDataReader("municipio_cliente").ToString + "          " + "CEP : " + oSqlDataReader("cep_cliente").ToString
                sDados(iAux + 6) = "FONE : " + oSqlDataReader("telefone_cliente").ToString + "          " + "CNPJ : " + oSqlDataReader("cnpj_cliente").ToString + "         " + "IE : " + oSqlDataReader("inscricao_estadual_cliente").ToString
                sDados(iAux + 7) = "COND. PAGTO : " + oSqlDataReader("condicao_pagamento").ToString + "         " + "VENDEDOR : " + oSqlDataReader("vendedor").ToString + "           " + "CONTATO : " + oSqlDataReader("nome_contato").ToString
                sDados(iAux + 8) = ""
                sDados(iAux + 9) = "QTDE" + "  " + "UN" + "  " + "DESCRICAO PRODUTO" + "                                 " + "  " + "NCM" + "  " + "MARCA " + "UNITARIO  " + "TOTAL"
                iAux += iNumeroLinha
            End If

            ReDim Preserve sDados(((iAux / iNumeroLinha) * iNumeroLinha) - 6)

            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Space(94)
            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = "E*** FAVOR CONFERIR A MERCADORIA NA ENTREGA, NAO ACEITAMOS RECLAMACOES POSTERIORES ***F"
            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Space(94)
            'ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Space(94)
            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = "Recebimento: ____/____/________ Assinatura: _________________________________________________"
            For i = 0 To 16
                ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Space(94)
            Next

            'Cria Arquivo
            sPathArquivo = System.IO.Path.GetTempFileName()

            Using oFileStream As New FileStream(sPathArquivo, FileMode.Create)
                Dim oStreamWriter As New StreamWriter(oFileStream, System.Text.Encoding.Default)
                For i = 0 To UBound(sDados)
                    If sDados(i) Is Nothing Then
                        oStreamWriter.WriteLine(Space(94))
                    Else
                        oStreamWriter.WriteLine(sDados(i).ToString)
                    End If
                Next
                oStreamWriter.Close()
                oFileStream.Close()
            End Using

            'Dim oProcess As New Process
            'oProcess.Start(sPathArquivo)
            'Imprime 
            File.Copy(sPathArquivo, "LPT1", True)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImprimirOrcamentoMatricial(ByVal lCodigoOrcamento As Long)

        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim oSqlDataReader As SqlDataReader
            Dim i As Integer = 0

            'Váriaveis Locais - Arquivo
            Dim sDados() As String
            Dim iNumeroLinha As Integer = 31
            Dim iAux As Integer = 0
            Dim sPathArquivo As String
            Dim iNumeroRegistros As Integer = CType(LoadDescricao("sp_report_ven000000001_LPT1_01 " & lCodigoOrcamento & ", " & goUsuario.iEmpresa), Integer)
            Dim dValorFinal As String = ""
            Dim iQuantidadeRegistro As Integer = 0
            Dim iContaCabecalho As Integer = 1

            'Seta Parametros - Codigo Orcamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "codigo_orcamento"
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrcamento : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_report_ven000000001_LPT1", oSqlParameter)

            'Inicializa Vetor
            ReDim sDados(0)

            While oSqlDataReader.Read

                'Verifica se o Vetor está carregado
                If sDados(UBound(sDados)) <> "" Then
                    ReDim Preserve sDados(UBound(sDados) + 1)
                End If

                If UBound(sDados) = iAux Then
                    ReDim Preserve sDados(UBound(sDados) + 10)
                    sDados(iAux + 0) = Chr(27) & Chr(64) & Chr(27) & Chr(54) & Chr(27) & Chr(116) & Chr(1) & Chr(27) & Chr(120) & Chr(48) & Chr(27) & Chr(33) & Chr(1) & Chr(27) & Chr(50) & Chr(27) & Chr(108) & Chr(1) & Chr(27) & Chr(67) & Chr(33)
                    sDados(iAux + 0) &= "D.A COUTINHO E CIA LTDA                  Fone: (12) 3951-1471            Pag.: " & Format((iAux / iNumeroLinha) + 1, "00")
                    sDados(iAux + 1) = "-------------------PRACA INDEPENDENCIA, 107-SAO JOAO-JACAREI/SP  12322-570-------------------"
                    sDados(iAux + 2) = "ORCAMENTO  : " + oSqlDataReader("numero_orcamento").ToString + "                     " + "DATA PEDIDO : " + oSqlDataReader("data_orcamento").ToString
                    sDados(iAux + 3) = "CLIENTE : " + oSqlDataReader("codigo_cliente").ToString + " - " + RetirarAcento2(oSqlDataReader("cliente").ToString)
                    sDados(iAux + 4) = "ENTREGA : " + oSqlDataReader("logradouro_cliente").ToString + ", " + oSqlDataReader("numero_cliente").ToString + oSqlDataReader("complemento_cliente").ToString
                    sDados(iAux + 5) = "BAIRRO : " + oSqlDataReader("bairro_cliente").ToString + "          " + "CIDADE : " + RetirarAcento2(oSqlDataReader("municipio_cliente").ToString) + "          " + "CEP : " + oSqlDataReader("cep_cliente").ToString
                    sDados(iAux + 6) = "FONE : " + oSqlDataReader("telefone_cliente").ToString + "          " + "CNPJ : " + oSqlDataReader("cnpj_cliente").ToString + "         " + "IE : " + oSqlDataReader("inscricao_estadual_cliente").ToString
                    sDados(iAux + 7) = "COND. PAGTO : " + oSqlDataReader("condicao_pagamento").ToString + "         " + "VENDEDOR : " + oSqlDataReader("vendedor").ToString + "           " + "CONTATO : " + oSqlDataReader("nome_contato").ToString
                    sDados(iAux + 8) = "============================================================================================="
                    sDados(iAux + 9) = "EQuant. Un Descricao do produto                               Marca        Unitario      TotalF"
                    iAux += iNumeroLinha


                End If


                sDados(UBound(sDados)) = oSqlDataReader("quantidade").ToString
                sDados(UBound(sDados)) &= oSqlDataReader("sigla").ToString
                sDados(UBound(sDados)) &= oSqlDataReader("descricao").ToString
                'sDados(UBound(sDados)) &= oSqlDataReader("codigo_ncm").ToString
                sDados(UBound(sDados)) &= oSqlDataReader("marca").ToString
                sDados(UBound(sDados)) &= Space(8 - oSqlDataReader("valor_unitario_desconto").ToString.Trim.Length) & oSqlDataReader("valor_unitario_desconto").ToString.Trim
                sDados(UBound(sDados)) &= Space(12 - oSqlDataReader("valor_total").ToString.Trim.Length) & oSqlDataReader("valor_total").ToString.Trim

                dValorFinal = oSqlDataReader.Item("valor_final").ToString
                iQuantidadeRegistro += 1

                'Verifica se tem Necessidade de um novo Cabeçalho
                If iQuantidadeRegistro > 14 And iContaCabecalho = 1 Then

                    ReDim Preserve sDados(UBound(sDados) + 17)
                    sDados(iAux + 0) = Chr(27) & Chr(64) & Chr(27) & Chr(54) & Chr(27) & Chr(116) & Chr(1) & Chr(27) & Chr(120) & Chr(48) & Chr(27) & Chr(33) & Chr(1) & Chr(27) & Chr(50) & Chr(27) & Chr(108) & Chr(1) & Chr(27) & Chr(67) & Chr(33)
                    sDados(iAux + 0) &= "D.A COUTINHO E CIA LTDA                  Fone: (12) 3951-1471            Pag.: " & Format((iAux / iNumeroLinha) + 1, "00")
                    sDados(iAux + 1) = "-------------------PRACA INDEPENDENCIA, 107-SAO JOAO-JACAREI/SP  12322-570-------------------"
                    sDados(iAux + 2) = "PEDIDO  : " + oSqlDataReader("numero_orcamento").ToString + "                     " + "DATA PEDIDO : " + oSqlDataReader("data_orcamento").ToString
                    sDados(iAux + 3) = "CLIENTE : " + oSqlDataReader("codigo_cliente").ToString + " - " + RetirarAcento2(oSqlDataReader("cliente").ToString)
                    sDados(iAux + 4) = "ENTREGA : " + oSqlDataReader("logradouro_cliente").ToString + ", " + oSqlDataReader("numero_cliente").ToString + oSqlDataReader("complemento_cliente").ToString
                    sDados(iAux + 5) = "BAIRRO : " + oSqlDataReader("bairro_cliente").ToString + "          " + "CIDADE : " + RetirarAcento2(oSqlDataReader("municipio_cliente").ToString) + "          " + "CEP : " + oSqlDataReader("cep_cliente").ToString
                    sDados(iAux + 6) = "FONE : " + oSqlDataReader("telefone_cliente").ToString + "          " + "CNPJ : " + oSqlDataReader("cnpj_cliente").ToString + "         " + "IE : " + oSqlDataReader("inscricao_estadual_cliente").ToString
                    sDados(iAux + 7) = "COND. PAGTO : " + oSqlDataReader("condicao_pagamento").ToString + "         " + "VENDEDOR : " + oSqlDataReader("vendedor").ToString + "           " + "CONTATO : " + oSqlDataReader("nome_contato").ToString
                    sDados(iAux + 8) = "============================================================================================="
                    sDados(iAux + 9) = "EQuant. Un Descricao do produto                               Marca        Unitario      TotalF"
                    'sDados(iAux + 9) = "QTDE" + "  " + "UN" + "  " + "DESCRICAO PRODUTO" + "                                 " + "  " + "NCM" + "  " + "MARCA " + "UNITARIO  " + "TOTAL"
                    iAux += iNumeroLinha
                    iContaCabecalho += 1

                End If

            End While

            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = "............................................................................................."
            'ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Format(iNumeroRegistros, "000") & " Itens"
            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Format(iQuantidadeRegistro, "000") & " Itens"
            sDados(UBound(sDados)) &= Space(65)
            sDados(UBound(sDados)) &= "Total =>"
            sDados(UBound(sDados)) &= Space(9 - dValorFinal.ToString.Trim.Length) & dValorFinal.ToString.Trim

            ''Verifica se tem Necessidade de um novo Cabeçalho
            'If UBound(sDados) = iAux Then

            '    ReDim Preserve sDados(UBound(sDados) + 9)
            '    sDados(iAux + 0) = Chr(27) & Chr(64) & Chr(27) & Chr(54) & Chr(27) & Chr(116) & Chr(1) & Chr(27) & Chr(120) & Chr(48) & Chr(27) & Chr(33) & Chr(1) & Chr(27) & Chr(50) & Chr(27) & Chr(108) & Chr(1) & Chr(27) & Chr(67) & Chr(33)
            '    sDados(iAux + 0) &= "D.A COUTINHO E CIA LTDA                  Fone: (12) 3951-1471            Pag.: " & Format((iAux / iNumeroLinha) + 1, "00")
            '    sDados(iAux + 1) = "-------------------PRACA INDEPENDENCIA, 107-SAO JOAO-JACAREI/SP  12322-570-------------------"
            '    sDados(iAux + 2) = "PEDIDO  : " + oSqlDataReader("numero_orcamento").ToString + "                     " + "DATA PEDIDO : " + oSqlDataReader("data_orcamento").ToString
            '    sDados(iAux + 3) = "CLIENTE : " + oSqlDataReader("codigo_cliente").ToString + " - " + RetirarAcento2(oSqlDataReader("cliente").ToString)
            '    sDados(iAux + 4) = "ENTREGA : " + oSqlDataReader("logradouro_cliente").ToString + ", " + oSqlDataReader("numero_cliente").ToString + oSqlDataReader("complemento_cliente").ToString
            '    sDados(iAux + 5) = "BAIRRO : " + oSqlDataReader("bairro_cliente").ToString + "          " + "CIDADE : " + RetirarAcento2(oSqlDataReader("municipio_cliente").ToString) + "          " + "CEP : " + oSqlDataReader("cep_cliente").ToString
            '    sDados(iAux + 6) = "FONE : " + oSqlDataReader("telefone_cliente").ToString + "          " + "CNPJ : " + oSqlDataReader("cnpj_cliente").ToString + "         " + "IE : " + oSqlDataReader("inscricao_estadual_cliente").ToString
            '    sDados(iAux + 7) = "COND. PAGTO : " + oSqlDataReader("condicao_pagamento").ToString + "         " + "VENDEDOR : " + oSqlDataReader("vendedor").ToString + "           " + "CONTATO : " + oSqlDataReader("nome_contato").ToString
            '    sDados(iAux + 8) = Space(94)
            '    sDados(iAux + 9) = "QTDE" + "  " + "UN" + "  " + "DESCRICAO PRODUTO" + "                                 " + "  " + "NCM" + "  " + "MARCA " + "UNITARIO  " + "TOTAL"
            '    iAux += iNumeroLinha
            'End If

            ReDim Preserve sDados(((iAux / iNumeroLinha) * iNumeroLinha) - 6)

            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Space(94)
            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = "E*** FAVOR CONFERIR A MERCADORIA NA ENTREGA, NAO ACEITAMOS RECLAMACOES POSTERIORES ***F"
            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Space(94)
            'ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Space(94)
            ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = "Recebimento: ____/____/________ Assinatura: _________________________________________________"
            For i = 0 To 16
                ReDim Preserve sDados(UBound(sDados) + 1) : sDados(UBound(sDados)) = Space(94)
            Next

            'Cria Arquivo
            sPathArquivo = System.IO.Path.GetTempFileName()

            Using oFileStream As New FileStream(sPathArquivo, FileMode.Create)
                Dim oStreamWriter As New StreamWriter(oFileStream, System.Text.Encoding.Default)
                For i = 0 To UBound(sDados)
                    If sDados(i) Is Nothing Then
                        oStreamWriter.WriteLine(Space(94))
                    Else
                        oStreamWriter.WriteLine(sDados(i).ToString)
                    End If
                Next
                oStreamWriter.Close()
                oFileStream.Close()
            End Using

            'Dim oProcess As New Process
            ' oProcess.Start(sPathArquivo)
            'Imprime 
            File.Copy(sPathArquivo, "LPT1", True)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRegistroGrid(ByVal oGrid As GridEX, _
                                  ByVal sQuery As String, _
                                  ByVal sCampo As String, _
                                  ByVal sValor As Object, _
                                  Optional ByVal iTable As Integer = 0)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(iTable)
            End If

            For Each oDataRow In oDataTable.Select(sQuery)
                oDataRow(sCampo) = IIf(sValor.ToString = "NULL", DBNull.Value, sValor)
            Next

            If iTable = 0 Then
                'Preenche Grid
                Call ConfigurarDataMemberGrid(oGrid)
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(iTable).TableName
            Else
                'Preenche Grid
                Call ConfigurarDataMemberGrid(oGrid)
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.RootTable.ChildTables(iTable - 1).DataMember = oDataSet.Tables(iTable).TableName
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRegistroGrid(ByVal oGrid As GridEX, _
                                  ByVal sQuery As String, _
                                  ByVal sCampo As String(), _
                                  ByVal oValor As Object(), _
                                  Optional ByVal iTable As Integer = 0)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim i As Integer = 0

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(iTable)
            End If

            For Each oDataRow In oDataTable.Select(sQuery)
                For i = 0 To UBound(oValor)
                    oDataRow(sCampo(i)) = IIf(oValor(i).ToString = "NULL", DBNull.Value, oValor(i))
                Next
            Next

            If iTable = 0 Then
                'Preenche Grid
                Call ConfigurarDataMemberGrid(oGrid)
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(iTable).TableName
            Else
                'Preenche Grid
                Call ConfigurarDataMemberGrid(oGrid)
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.RootTable.ChildTables(iTable - 1).DataMember = oDataSet.Tables(iTable).TableName
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesTraducao(ByVal oFormulario As Control)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim oControls As Control
        Dim i As Integer = 0

        Try

            'Seta Parametros - Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = oFormulario.Name : i += 1

            'Seta Parametros - Idioma
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_idioma"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iIdioma

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_traducao", oSqlParameter)

            While oSqlDataReader.Read

                If oFormulario.Controls.Find(oSqlDataReader.Item("controle"), True).Length > 0 Then
                    oControls = oFormulario.Controls.Find(oSqlDataReader.Item("controle"), True)(0)

                    If TypeOf oControls Is GridEX Then
                        Dim oGrid As GridEX
                        oGrid = oControls
                        oGrid.RootTable.Columns(oSqlDataReader.Item("coluna")).Caption = oSqlDataReader.Item("texto")
                    Else
                        oControls.Text = oSqlDataReader.Item("texto")
                    End If

                End If

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub WordSubstituir(ByVal oDocument As Object, _
                              ByVal sProcurar As String,
                              ByVal sSubstituir As String, _
                              Optional ByVal bForward As Boolean = True, _
                              Optional ByVal bFormat As Boolean = False, _
                              Optional ByVal bMatchCase As Boolean = False, _
                              Optional ByVal bMatchWholeWord As Boolean = False)

        Try

            oDocument.Selection.HomeKey(Word.WdUnits.wdStory, Word.WdMovementType.wdExtend)

            With oDocument.Selection.Find

                .Text = sProcurar
                .Replacement.text = sSubstituir
                .Execute(Replace:=Word.WdReplace.wdReplaceAll)

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub WordSubstituir2(ByVal oDocument As Object, _
                           ByVal sProcurar As String,
                           ByVal sSubstituir As String, _
                           Optional ByVal bForward As Boolean = True, _
                           Optional ByVal bFormat As Boolean = False, _
                           Optional ByVal bMatchCase As Boolean = False, _
                           Optional ByVal bMatchWholeWord As Boolean = False)

        Try

            oDocument.Selection.TypeText(sSubstituir)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub PreenchimentoCaracteres(ByVal oControl As MaskedEditBox,
                                       Optional ByVal sFormat As String = "hh:mm:ss")
        Try
            Dim inputParts As String() = oControl.Text.Split(":"c)
            Dim formatParts As String() = sFormat.Split(":"c)
            Dim result As String = ""

            ' Preenche cada parte do input até alcançar o número de partes do formato
            For i As Integer = 0 To formatParts.Length - 1

                If i < inputParts.Length Then

                    ' Se a parte do input já existe, usa-a e formata conforme necessário
                    Dim part As String = inputParts(i).PadLeft(formatParts(i).Length, "0"c)
                    result &= If(i = 0, "", ":") & part

                Else

                    ' Se a parte do input não existe, preenche com zeros
                    Dim zeros As String = New String("0"c, formatParts(i).Length)
                    result &= ":" & zeros

                End If

            Next

            ' Atualiza o texto do controle com o valor formatado
            oControl.Text = result

        Catch ex As Exception
            TratamentoErro(ex.Message, "PreenchimentoCaracteres")
        End Try

    End Sub

#End Region

#Region "::: FUNCTION :::"
    Public Function ImageToBase64(ByVal image As System.Drawing.Image) As String
        Using ms As New MemoryStream()
            ' Salva a imagem no MemoryStream
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

            ' Converte o MemoryStream em uma matriz de bytes
            Dim imageBytes As Byte() = ms.ToArray()

            ' Converte a matriz de bytes em uma string base64
            Dim base64String As String = Convert.ToBase64String(imageBytes)

            Return base64String
        End Using
    End Function

    Public Function LoadImageFromBase64(ByVal base64String As String)
        Try
            ' Converte a string base64 em uma matriz de bytes
            Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
            Dim image As System.Drawing.Image

            ' Cria um MemoryStream a partir da matriz de bytes
            Using ms As New MemoryStream(imageBytes)
                ' Cria um objeto de imagem a partir do MemoryStream
                image = image.FromStream(ms)

            End Using
            ' Atribui a imagem ao PictureBox
            Return image
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao carregar a imagem base64: " & ex.Message)
        End Try
    End Function
    Public Function EncryptAPI(ByVal sTexto As String, ByVal sPassword As String) As String

        ' ***************************************************************
        ' ****** Preparação das Variáveis                      
        ' ***************************************************************

        'Declara Gerenciador de Hash
        Dim mySHA256 As SHA256 = SHA256Managed.Create()
        'Declare KEY que recebe Hash do Password (Key + CNPJ_CPF)
        Dim key As Byte() = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(sPassword))
        'Declara o IV
        Dim iv As Byte() = New Byte(15) {&H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0}
        'Declara o Algoritmo 
        Dim encryptor As Aes = Aes.Create()
        encryptor.Mode = CipherMode.CBC
        Dim aesKey As Byte() = New Byte(31) {}

        'Seta Variáveis
        Array.Copy(key, 0, aesKey, 0, 32)
        encryptor.Key = aesKey
        encryptor.IV = iv

        'Declara Variaveis de memória e criptografia
        Dim memoryStream As MemoryStream = New MemoryStream()
        Dim aesEncryptor As ICryptoTransform = encryptor.CreateEncryptor()
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write)
        Dim plainBytes As Byte() = Encoding.ASCII.GetBytes(sTexto)

        ' ***************************************************************
        ' ****** Realizando a criptografia                   
        ' ***************************************************************

        Try
            'Realiza Criptografia
            cryptoStream.Write(plainBytes, 0, plainBytes.Length)
            cryptoStream.FlushFinalBlock()
            Dim cipherBytes As Byte() = memoryStream.ToArray()
            'Converte o texto para Base64
            Dim cipherText As String = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length)
            'Retorno Funçao
            Return cipherText

        Catch ex As Exception
            Throw ex
            'Retorno da Função
            Return ""
        Finally
            'Fecha serviços
            memoryStream.Close()
            cryptoStream.Close()
        End Try

    End Function

    Public Function DecryptAPI(ByVal sTextoCriptografado As String, ByVal sPassword As String) As String

        ' ***************************************************************
        ' ****** Preparação das Variáveis                      
        ' ***************************************************************

        'Declara Gerenciador de Hash
        Dim mySHA256 As SHA256 = SHA256Managed.Create()
        'Declare KEY que recebe Hash do Password (Key + CNPJ_CPF)
        Dim key As Byte() = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(sPassword))
        'Declara o IV
        Dim iv As Byte() = New Byte(15) {&H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0}
        'Declara o Algoritmo 
        Dim encryptor As Aes = Aes.Create()
        encryptor.Mode = CipherMode.CBC
        Dim aesKey As Byte() = New Byte(31) {}

        'Seta Variáveis
        Array.Copy(key, 0, aesKey, 0, 32)
        encryptor.Key = aesKey
        encryptor.IV = iv

        'Declara Variaveis de memória e criptografia
        Dim memoryStream As MemoryStream = New MemoryStream()
        Dim aesDecryptor As ICryptoTransform = encryptor.CreateDecryptor()
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write)
        Dim plainText As String = String.Empty

        ' ***************************************************************
        ' ****** Convertendo a criptografia                   
        ' ***************************************************************
        Try
            'Converte o texto que esta em Base64
            Dim cipherBytes As Byte() = Convert.FromBase64String(sTextoCriptografado)
            'Realiza a conversão da criptografia
            cryptoStream.Write(cipherBytes, 0, cipherBytes.Length)
            cryptoStream.FlushFinalBlock()
            'Seta o resultado
            Dim plainBytes As Byte() = memoryStream.ToArray()
            'Converte os dados em Bytes 
            plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length)
        Catch ex As Exception
            Throw ex
            'Retorno da Função
            Return ""
        Finally
            'Fecha serviços
            memoryStream.Close()
            cryptoStream.Close()
        End Try


        ' ***************************************************************
        ' ****** Retorna o texto convertido                
        ' ***************************************************************

        'Retorno Função
        Return plainText

    End Function

    Private Function PostDataAPI(ByVal uri As String, ByVal data As String) As String

        ' ***************************************************************
        ' ****** Configuração das variáveis e headers                 
        ' ***************************************************************

        'Variaveis
        'Dim httpClient = New HttpClient()
        'httpClient.DefaultRequestHeaders.Add("Authorization", "Authorization " + gcAuthorization)
        'Dim body As String = "{""cnpj_cpf"":""" & data & """}"

        ''Configura o Header para enviar e receber em Json
        'Dim content = New StringContent(body, Encoding.UTF8, "application/json")
        'content.Headers.ContentType = New MediaTypeHeaderValue("application/json")

        ' ***************************************************************
        ' ****** Realiza a consulta a API                  
        ' ***************************************************************

        Try
            'Realiza a request na API
            'Dim response = httpClient.PostAsync(uri, content).Result

            ''Recebe a resposta da API
            'Dim returnAPI = response.Content.ReadAsStringAsync()

            ''Transforma em JSON
            'Dim jsonObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(returnAPI.Result())

            ''Retorna a Licença obtida através da API
            'If jsonObject("result").ToString = "false" Then
            '    Return ""
            'Else
            '    Return jsonObject("data").ToString
            'End If


        Catch ex As Exception

            'Retorno da Função
            Return ""

        End Try

    End Function

    Public Function ConsultarLicencaAPI(ByVal sCNPJCPF As String) As Boolean

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Retorno
            ConsultarLicencaAPI = False

            'Preparação das Váriaveis
            sCNPJCPF = Replace(Replace(Replace(sCNPJCPF, ".", ""), "/", ""), "-", "")
            Dim sPassword As String = gcKeyAPI & sCNPJCPF

            'Consulta API
            Dim sResponseAPI As String = PostDataAPI(gcUrl & "obtem_licenca", sCNPJCPF)

            'Quebra resposta da API
            Dim sResult() As String = sResponseAPI.Split("|")

            'Verifica se retornou resultado
            If sResult.Length > 1 Then
                'Seta Controles
                goUsuario.sDataUltimoAcessoAPI = Now.Date
                goUsuario.sDataValidacaoAPI = DecryptAPI(sResult(0), sPassword)
                goUsuario.sDataValidadeAPI = DecryptAPI(sResult(1), sPassword)
                goUsuario.iNumeroLicencaAPI = DecryptAPI(sResult(2), sPassword)
                goUsuario.iToleranciaAPI = DecryptAPI(sResult(3), sPassword)

            Else
                'Sai da função
                Exit Function
            End If


            'Retorno 
            ConsultarLicencaAPI = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ExportarBoletoPDF(ByVal sArquivo As String, _
                                      ByVal sSerie As String, _
                              ByVal sNumeroDocumento As String, _
                              Optional ByVal sPasta As String = "") As String
        Try
            Try

                'Define o caminho para salvar o pdf
                Dim sBoletoPathPDF As String = IIf(sPasta = "", goConfiguracaoNFSe.sPastaImpressao, sPasta + "\") + "BOLETO_" + goUsuario.sSiglaEmpresa + "_" + sNumeroDocumento.Replace("/", "_") + ".pdf"

                Try
                    System.IO.File.Delete(sBoletoPathPDF)
                Catch ex As Exception

                End Try

                'Variáveis auxiliares (pode ser trocar depois por static´s. Define o tamnho da imagem)
                Dim iWidth As Integer = 680
                Dim iHeight As Integer = 1096
                Dim iWebBrowserWidth As Integer = 680
                Dim iWebBrowserHeight As Integer = 1096

                'Acessando a classe para fazer a imagem direto do html
                Dim oBmp As System.Drawing.Bitmap = WebsiteThumbnailImageGenerator.GetWebSiteThumbnail(sArquivo, iWebBrowserWidth, iWebBrowserHeight, iWidth, iHeight)

                'Recebendo um arquivo temporário como GIF, para depois converter para PDF
                Dim sBoletoPathBMP As String = System.IO.Path.Combine(System.IO.Path.GetTempPath, "Boleto.bmp")

                'Salvar o arquivo temporário
                oBmp.Save(sBoletoPathBMP)

                'Define um documento tipo doc para depois salvar como PDF
                Dim oDoc As iTextSharp.text.Document = New Document(PageSize.A4, 46, 0, 40, 0)
                'Instancia o documento para depois escrevê-lo como PDF
                PdfWriter.GetInstance(oDoc, New FileStream(sBoletoPathPDF, FileMode.Create))
                'Abre o DOC
                oDoc.Open()
                'Instancia um tipo imagem para salvar o documento
                ' Dim oGif As iTextSharp.text.Image = GetInstance(sBoletoPathBMP)
                Dim oGif As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(sBoletoPathBMP)
                'Define as dimensões
                oGif.ScaleAbsolute(494.0F, 785.0F)

                'Adiciona a imagem no documento
                oDoc.Add(oGif)
                'Fecha o do documento (e salva-o também)
                oDoc.Close()

                'Retornando oa rquivo 
                ExportarBoletoPDF = sBoletoPathPDF
            Catch ex As Exception
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub RemoveCaracterEspecialControle(ByVal oControle As Control)

        Try

            Dim sCharFrom As String = "ŠŒŽšœžŸ¥µÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýÿ"
            Dim sCharTo As String = "SOZsozYYuAAAAAAACEEEEIIIIDNOOOOOOUUUUYsaaaaaaaceeeeiiiionoooooouuuuyy"
            Dim sTexto As String = oControle.Text

            For i As Integer = 0 To sCharFrom.Length - 1
                sTexto = Replace(sTexto, sCharFrom(i), sCharTo(i))
            Next

            oControle.Text = sTexto

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function RemoveCaracterEspecial(ByRef sTexto As String) As String

        Try

            Dim sCharFrom As String = "ŠŒŽšœžŸ¥µÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýÿ"
            Dim sCharTo As String = "SOZsozYYuAAAAAAACEEEEIIIIDNOOOOOOUUUUYsaaaaaaaceeeeiiiionoooooouuuuyy"

            For i As Integer = 0 To sCharFrom.Length - 1
                sTexto = Replace(sTexto, sCharFrom(i), sCharTo(i))
            Next

            Return sTexto

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function FormatHoras(ByVal dMinuto As Double) As String

        Try

            Dim dSegundo As Double = 0
            Dim iHora As Integer = 0
            Dim sHora As String

            dSegundo = ((dMinuto - System.Math.Floor(dMinuto)) * 60)

            If dMinuto >= 60 Then
                iHora = dMinuto / 60
            End If

            dMinuto = System.Math.Floor(CType(dMinuto Mod 60, Integer))

            sHora = iHora & ":" & Format(dMinuto, "00") & ":" & Format(dSegundo, "00")

            Return sHora

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ColorGradientRedToBlue(ByVal index As Single) As System.Drawing.Color

        Try

            If index < 0 OrElse index > 1.0R Then
                Throw New ArgumentException("index must be between 0 and 1")
            End If

            Return System.Drawing.Color.FromArgb(CInt(((1.0R - index) * 255)), 0, CInt((index * 255)))

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function UpdateConfiguracaoNSU(ByVal sNSUInicial As String, _
                                      ByVal sUltimoNSU As String, _
                                      ByVal sStatus As String) As String

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nsu_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNSUInicial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ultimo_nsu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUltimoNSU : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatus : i += 1


            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_nfe_destinada_ultimo_nsu", oSqlParameter)

            'Seta Retorno
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function UpdateConfiguracaoNSUCTE(ByVal sNSUInicial As String, _
                                      ByVal sUltimoNSU As String, _
                                      ByVal sStatus As String) As String

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nsu_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNSUInicial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ultimo_nsu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUltimoNSU : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatus : i += 1


            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_nfe_destinada_ultimo_nsu_cte", oSqlParameter)

            'Seta Retorno
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Sub LogConsultaNFeDestinada()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_log_nfe_destinada", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidateConfiguracaoUltimoNSU() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim oDataReader As SqlDataReader

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            'Executa Query
            oDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_configuracao_nfe_destinada_ultimo_nsu", oSqlParameter)


            If oDataReader.Read Then

                'Se puder consultar, setar o retorno true
                If oDataReader("flag") = True Then
                    ValidateConfiguracaoUltimoNSU = True

                Else
                    If oDataReader("diferenca") < 0 Then
                        ValidateConfiguracaoUltimoNSU = True
                    Else
                        ValidateConfiguracaoUltimoNSU = False
                        MsgBox("Existe uma consulta feita às " & Format(oDataReader("data_consulta"), "HH:mm") & _
                               " com status de [ " & oDataReader("status") & " ]. É necessário aguardar " & _
                               CStr(CInt(oDataReader("diferenca"))) & " minutos para uma nova consulta!", MsgBoxStyle.Exclamation, "Validação")

                    End If
                End If





                'Fecha o datareader
                oDataReader.Close()
            End If



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function LoadUltimoNSU() As String

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfe_destinada_ultimo_nsu", oSqlParameter)

            'Seta Retorno
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadEnderecoApiDestinada() As String

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cfg_endereco_api_nfe_destinada", oSqlParameter)

            'Seta Retorno
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadEnderecoApiLicenca() As String

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_licenca_url", oSqlParameter)

            'Seta Retorno
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LoadUltimoNSUCTe() As String

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfe_destinada_ultimo_nsu_cte", oSqlParameter)

            'Seta Retorno
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function FindControl(ByVal oCtrContainer As Control, _
                                ByVal sName As String) As Control

        For Each oControl As Control In oCtrContainer.Controls

            If oControl.Name = sName Then
                Return oControl
            End If

            'Função Recursiva (Encontra os Controles Filhos)
            If oControl.HasChildren Then
                FindControl(oControl, _
                            sName)
            End If

        Next

        Return Nothing

    End Function

    Private Function FindControl2(ByVal CurrentControl As Control, _
                                  ByVal ControlName As String) As Control

        Dim ctr As Control
        For Each ctr In CurrentControl.Controls
            If ctr.Name = ControlName Then
                Return ctr
            Else
                ctr = FindControl2(ctr, ControlName)
                If Not ctr Is Nothing Then
                    Return ctr
                End If
            End If
        Next ctr

    End Function

    Public Function CalculaValorTotal(ByVal dQuantidade As Double, _
                                      ByVal dValorUnitario As Double, _
                                      ByVal bIPIIncluso As Boolean, _
                                      ByVal bICMSIncluso As Boolean, _
                                      ByVal dAliquotaIPI As Double, _
                                      ByVal dAliquotaICMS As Double, _
                                      ByVal dDescontoValor As Double, _
                                      ByVal dDescontoPercentual As Double) As Double

        Try

            'Váriaveis Locais
            Dim dValorOriginal As Double
            Dim dValorFinal As Double

            'Calcula Valor sem Desconto e Imposto
            dValorOriginal = dQuantidade * dValorUnitario
            dValorFinal = dQuantidade * dValorUnitario

            If dValorFinal = 0 Then
                Return 0
            End If

            'Desconto Valor
            dValorFinal -= dDescontoValor
            'Desconto Percentual
            dValorFinal -= (dValorOriginal * dDescontoPercentual / 100.0)
            'IPI
            If bIPIIncluso = False Then dValorFinal += (dValorFinal * dAliquotaIPI / 100.0)
            'ICMS
            If bICMSIncluso = False Then dValorFinal += (dValorFinal * dAliquotaICMS / 100.0)

            'Retorna Valor da Função
            Return dValorFinal

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, "FUNÇÃO")
        End Try

    End Function

    Public Function CalculaValorTotal(ByVal dQuantidade As Double, _
                                      ByVal dValorUnitario As Double, _
                                      ByVal iTipoDesconto As TipoCalculoDesconto, _
                                      ByVal dDesconto As Double) As Double

        Try

            'Váriaveis Locais
            Dim dValorOriginal As Double

            'Calcula Valor sem Desconto e Imposto
            dValorOriginal = dQuantidade * dValorUnitario

            If dValorOriginal = 0 Then
                Return 0
            End If

            'Calcula Desconto
            If iTipoDesconto = TipoCalculoDesconto.Porcentagem Then
                dValorOriginal = dValorOriginal - ((dDesconto * dValorOriginal) / 100)
            Else
                dValorOriginal = dValorOriginal - dDesconto
            End If

            'Retorna Valor da Função
            Return dValorOriginal

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, "FUNÇÃO")
        End Try

    End Function

    Function CalculoHorasParada(ByVal dTotalHoras As Date, _
                                ByVal dQtdParada As Date) As String

        Try

            'Váriaveis Locais
            Dim iMinutos As Integer
            Dim iHoras As Integer

            If dQtdParada >= dTotalHoras Then
                iMinutos = DatePart(DateInterval.Minute, dQtdParada)
                iMinutos += DatePart(DateInterval.Hour, dQtdParada) * 60
                iMinutos += 60 - DatePart(DateInterval.Minute, dTotalHoras)
                iMinutos += (23 - DatePart(DateInterval.Hour, dTotalHoras)) * 60
            Else
                iMinutos = DateDiff(DateInterval.Minute, dQtdParada, dTotalHoras)
            End If
            iMinutos = iMinutos
            iHoras = CInt(iMinutos / 60)
            iMinutos = iMinutos Mod 60

            'Retorno
            Return Format(iHoras, "00") & Format(iMinutos, "00")

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Function CalculoHoras(ByVal dDataInicio As Date, _
                          ByVal dDataTermino As Date) As String

        Try

            'Váriaveis Locais
            Dim iMinutos As Integer
            Dim iSegundos As Integer
            Dim iHoras As Integer


            If dDataInicio >= dDataTermino Then
                dDataTermino = DateAdd(DateInterval.Hour, 24, dDataTermino)
            End If

            iSegundos = DateDiff(DateInterval.Second, dDataInicio, dDataTermino)

            iMinutos = System.Math.Floor(iSegundos / 60.0)
            iHoras = System.Math.Floor(iMinutos / 60.0)
            iMinutos = iMinutos Mod 60
            iSegundos = iSegundos - ((iMinutos * 60) + (iHoras * 3600))

            'Retorno
            Return Format(iHoras, "00") & Format(iMinutos, "00") & Format(iSegundos, "00")

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Function CalculoHoras(ByVal dDataInicio As Date, _
                          ByVal dDataTermino As Date, _
                          ByVal dHoraParada As Date) As String

        Try

            'Váriaveis Locais
            Dim iMinutos As Integer
            Dim iHoras As Integer = 0
            Dim iSegundos As Integer = 0

            If dDataInicio >= dDataTermino Then
                dDataTermino = DateAdd(DateInterval.Hour, 24, dDataTermino)
            End If

            iSegundos = DateDiff(DateInterval.Second, dDataInicio, dDataTermino)
            iSegundos = iSegundos - DatePart(DateInterval.Second, dHoraParada) - (DatePart(DateInterval.Hour, dHoraParada) * 3600) - (DatePart(DateInterval.Minute, dHoraParada) * 60)
            iMinutos = System.Math.Floor(iSegundos / 60.0)
            iHoras = System.Math.Floor(iMinutos / 60.0)
            iMinutos = iMinutos Mod 60
            iSegundos = iSegundos - ((iMinutos * 60) + (iHoras * 3600))

            'Retorno
            Return Format(iHoras, "00") & Format(iMinutos, "00") & Format(iSegundos, "00")

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function NumeroToExtenso(ByVal dNumber As Decimal) As String

        'Variaveis Locais
        Dim iCentavos As Integer

        Try

            'Se for =0 retorna 0 reais
            If dNumber = 0 Then
                Return "Zero Reais"
            End If

            'Verifica a parte decimal, ou seja, os centavos
            iCentavos = Decimal.Round((dNumber - Int(dNumber)) * 100, MidpointRounding.ToEven)

            'Verifica apenas a parte inteira
            dNumber = Int(dNumber)

            'Caso existam Centavos
            If iCentavos > 0 Then
                'Caso seja 1 não coloca "Reais" mas sim "Real"
                If dNumber = 1 Then
                    Return "Um Real e " + GetDecimal(iCentavos) + "centavos"
                ElseIf dNumber = 0 Then
                    Return GetDecimal(iCentavos) + "centavos"
                Else
                    Return GetInteger(dNumber) + "Reais e " + GetDecimal(iCentavos) + "centavos"
                End If
            Else
                'Caso seja 1 não coloca "Reais" mas sim "Real"
                If dNumber = 1 Then
                    Return "Um Real"
                Else
                    Return GetInteger(dNumber) + "Reais"
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GetDecimal(ByVal bNumber As Byte) As String

        Try

            Select Case bNumber

                Case 0
                    Return ""

                Case 1 To 19
                    Dim strArray() As String = _
                       {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis", _
                        "Sete", "Oito", "Nove", "Dez", "Onze", _
                        "Doze", "Treze", "Quatorze", "Quinze", _
                        "Dezesseis", "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(bNumber - 1) + " "

                Case 20 To 99
                    Dim strArray() As String = _
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta", _
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (bNumber Mod 10) = 0 Then
                        Return strArray(bNumber \ 10 - 2) + " "
                    Else
                        Return strArray(bNumber \ 10 - 2) + " e " + GetDecimal(bNumber Mod 10) + " "
                    End If

                Case Else
                    Return ""

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GetInteger(ByVal dNumber As Decimal) As String

        Try

            dNumber = Int(dNumber)

            Select Case dNumber

                Case Is < 0
                    Return "-" & GetInteger(-dNumber)

                Case 0
                    Return ""

                Case 1 To 19
                    Dim strArray() As String = _
                        {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis", _
                        "Sete", "Oito", "Nove", "Dez", "Onze", "Doze", _
                        "Treze", "Quatorze", "Quinze", "Dezesseis", _
                        "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(dNumber - 1) + " "

                Case 20 To 99
                    Dim strArray() As String = _
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta", _
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (dNumber Mod 10) = 0 Then
                        Return strArray(dNumber \ 10 - 2)
                    Else
                        Return strArray(dNumber \ 10 - 2) + " e " + GetInteger(dNumber Mod 10)
                    End If

                Case 100
                    Return "Cem"

                Case 101 To 999
                    Dim strArray() As String = _
                           {"Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", _
                           "Seiscentos", "Setecentos", "Oitocentos", "Novecentos"}
                    If (dNumber Mod 100) = 0 Then
                        Return strArray(dNumber \ 100 - 1) + " "
                    Else
                        Return strArray(dNumber \ 100 - 1) + " e " + GetInteger(dNumber Mod 100)
                    End If

                Case 1000 To 1999
                    Select Case (dNumber Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return "Mil e " + GetInteger(dNumber Mod 1000)
                        Case Else
                            Return "Mil, " + GetInteger(dNumber Mod 1000)
                    End Select

                Case 2000 To 999999
                    Select Case (dNumber Mod 1000)
                        Case 0
                            Return GetInteger(dNumber \ 1000) & "Mil"
                        Case Is <= 100
                            Return GetInteger(dNumber \ 1000) & "Mil e " & GetInteger(dNumber Mod 1000)
                        Case Else
                            Return GetInteger(dNumber \ 1000) & "Mil, " & GetInteger(dNumber Mod 1000)
                    End Select

                Case 1000000 To 1999999
                    Select Case (dNumber Mod 1000000)
                        Case 0
                            Return "Um Milhão"
                        Case Is <= 100
                            Return GetInteger(dNumber \ 1000000) + "Milhão e " & GetInteger(dNumber Mod 1000000)
                        Case Else
                            Return GetInteger(dNumber \ 1000000) + "Milhão, " & GetInteger(dNumber Mod 1000000)
                    End Select

                Case 2000000 To 999999999
                    Select Case (dNumber Mod 1000000)
                        Case 0
                            Return GetInteger(dNumber \ 1000000) + " Milhões"
                        Case Is <= 100
                            Return GetInteger(dNumber \ 1000000) + "Milhões e " & GetInteger(dNumber Mod 1000000)
                        Case Else
                            Return GetInteger(dNumber \ 1000000) + "Milhões, " & GetInteger(dNumber Mod 1000000)
                    End Select

                Case 1000000000 To 1999999999
                    Select Case (dNumber Mod 1000000000)
                        Case 0
                            Return "Um Bilhão"
                        Case Is <= 100
                            Return GetInteger(dNumber \ 1000000000) + "Bilhão e " + GetInteger(dNumber Mod 1000000000)
                        Case Else
                            Return GetInteger(dNumber \ 1000000000) + "Bilhão, " + GetInteger(dNumber Mod 1000000000)
                    End Select

                Case Else
                    Select Case (dNumber Mod 1000000000)
                        Case 0
                            Return GetInteger(dNumber \ 1000000000) + " Bilhões"
                        Case Is <= 100
                            Return GetInteger(dNumber \ 1000000000) + "Bilhões e " + GetInteger(dNumber Mod 1000000000)
                        Case Else
                            Return GetInteger(dNumber \ 1000000000) + "Bilhões, " + GetInteger(dNumber Mod 1000000000)
                    End Select
            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GetControlByName(ByVal sName As String, _
                                     ByVal oCurrentUserControl As UserControl) As Control

        Try

            'Váriaveis Locais
            Dim oFieldInfo As FieldInfo = oCurrentUserControl.GetType().GetField("_" & sName, _
                                                                                 BindingFlags.NonPublic Or _
                                                                                 BindingFlags.Instance Or _
                                                                                 BindingFlags.Public Or _
                                                                                 BindingFlags.IgnoreCase)

            If oFieldInfo Is Nothing Then
                Return Nothing
            Else
                Return CType(oFieldInfo.GetValue(oCurrentUserControl), Control)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GetControlByName(ByVal sName As String, _
                                     ByVal oCurrentForm As Form) As Control

        Try

            'Váriaveis Locais
            Dim oFieldInfo As FieldInfo = oCurrentForm.GetType().GetField("_" & sName, _
                                                                          BindingFlags.NonPublic Or _
                                                                          BindingFlags.Instance Or _
                                                                          BindingFlags.Public Or _
                                                                          BindingFlags.IgnoreCase)

            If oFieldInfo Is Nothing Then
                Return Nothing
            Else
                Return CType(oFieldInfo.GetValue(oCurrentForm), Control)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Cripitografar(ByVal sTexto As String) As String

        Try

            'Variaveis Locais
            Dim sLetra As String
            Dim sTextoCriptografada As String = ""
            Dim i As Integer

            sTexto = Trim(sTexto)

            For i = 1 To Len(sTexto)
                sLetra = Asc(Mid(sTexto, i, 1))
                sLetra = Chr(Trim(Str(Val(sLetra) Xor (i * 2))))
                sTextoCriptografada = sTextoCriptografada & sLetra
            Next i

            Return sTextoCriptografada

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ApplicationPath() As String

        Return System.AppDomain.CurrentDomain.BaseDirectory()

    End Function

    Public Function LoadControl(ByVal oParent As Control, _
                                ByVal sName As String) As Control

        Try

            'Variaveis Locais 
            Dim oControl As Control

            For Each oControl In oParent.Controls
                If oControl.Name = sName Then
                    Return oControl
                End If
            Next

            Return Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oTextBox As EditBox, _
                                ByVal oControl As Control, _
                                ByVal eTipo As TipoCampo) As Boolean

        Try

            'Váriaveis
            Dim sCampo As String

            sCampo = Left(oControl.Text, oControl.Text.Length - 1).ToUpper

            'Seta Retorno da Função
            ValidaCampo = False

            'Verifica o Tipo do Campo
            Select Case eTipo

                Case TipoCampo.data, TipoCampo.hora

                    'Verifica se foi Preenchido algum valor e se é numérico
                    If oTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oTextBox.Focus()
                        Exit Function
                    ElseIf IsDate(oTextBox.Text) = False Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é do tipo Data. Digite um valor válido para ele.")
                        oTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.numero

                    'Verifica se foi Preenchido algum valor e se é numérico
                    If oTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oTextBox.Focus()
                        Exit Function
                    ElseIf IsNumeric(oTextBox.Text) = False Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é numérico. Digite um valor válido para ele.")
                        oTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.texto

                    'Verifica se foi Preenchido algum valor e se é numérico
                    If oTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oTextBox.Focus()
                        Exit Function
                    End If

            End Select

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oGrid As GridEX, ByVal oControl As Control) As Boolean

        Try

            'Seta Retorno da Função
            ValidaCampo = False

            'Verifica se foi Inserido algum Registro
            If oGrid.GetDataRows.Count = 0 Then
                frmMain.errInfo.SetError(oControl, "Primeiramente Insira um ou mais Registros na Grid")
                Exit Function
            End If

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oTextBox As NumericEditBox, _
                                ByVal oControl As Control, _
                                ByVal bMaiorZero As Boolean) As Boolean

        Try

            'Váriaveis
            Dim sCampo As String

            sCampo = Left(oControl.Text, oControl.Text.Length - 1).ToUpper

            'Seta Retorno da Função
            ValidaCampo = False

            'Verifica se foi Preenchido algum valor e se é numérico
            If oTextBox.Text.Length = 0 Then
                frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                oTextBox.Focus()
                Exit Function
            End If

            If bMaiorZero = True Then
                If CDbl(oTextBox.Value) <= 0 Then
                    frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] deve ser maior que 0 ""Zero"". Digite um valor válido para ele.")
                    oTextBox.Focus()
                    Exit Function
                End If
            Else
                If CDbl(oTextBox.Value) < 0 Then
                    frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] deve ser maior ou igual a 0 ""Zero"". Digite um valor válido para ele.")
                    oTextBox.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oTextBox As NumericEditBox, _
                                ByVal oControl As Control, _
                                ByVal sCampo As String, _
                                ByVal iTipoCampo As TipoCampo) As Boolean

        Try

            'Seta Retorno da Função
            ValidaCampo = False

            'Verifica se foi Preenchido algum valor
            If oTextBox.Text.Length = 0 Then
                frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                oTextBox.Focus()
                Exit Function
            End If

            Select Case iTipoCampo

                Case TipoCampo.hora

                    If oTextBox.Text > 23 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] Hora deve ser Menor que 24. Digite um valor válido para ele.")
                        oTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.minuto

                    If oTextBox.Text > 59 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] Minuto deve ser Menor que 60. Digite um valor válido para ele.")
                        oTextBox.Focus()
                        Exit Function
                    End If

            End Select

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oTextBox As NumericEditBox, _
                                ByVal oControl As Control, _
                                ByVal eTipoCampo As TipoCampo) As Boolean

        Try

            'Váriaveis
            Dim sCampo As String

            sCampo = Left(oControl.Text, oControl.Text.Length - 1).ToUpper

            'Seta Retorno da Função
            ValidaCampo = False

            'Verifica se foi Preenchido algum valor e se é numérico
            If oTextBox.Text.Length = 0 Then
                frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                oTextBox.Focus()
                Exit Function
            End If

            Select Case eTipoCampo

                Case TipoCampo.hora
                    If CDbl(oTextBox.Text) < 0 Or CDbl(oTextBox.Text) > 23 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] se refere a uma hora. Digite um valor válido para ele.")
                        oTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.minuto
                    If CDbl(oTextBox.Text) < 0 Or CDbl(oTextBox.Text) > 59 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] se refere a um minuto. Digite um valor válido para ele.")
                        oTextBox.Focus()
                        Exit Function
                    End If

            End Select

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oMaskTextBox As MaskedEditBox, _
                                ByVal oControl As Control, _
                                ByVal eTipo As TipoCampo) As Boolean

        Try

            'Váriaveis
            Dim sCampo As String
            Dim sEmail As String

            'Seta Váriaveis
            sCampo = Left(oControl.Text, oControl.Text.Length - 1).ToUpper
            sEmail = "^[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

            'Seta Retorno da Função
            ValidaCampo = False

            'Verifica o Tipo do Campo
            Select Case eTipo

                Case TipoCampo.data
                    'Verifica se foi Preenchido algum valor e se é numérico
                    If oMaskTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    ElseIf IsDate(oMaskTextBox.Text) = False Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é do tipo Data. Digite um valor válido para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.hora
                    'Verifica se foi Preenchido algum valor e se é numérico
                    If oMaskTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    ElseIf oMaskTextBox.Text.Length < 7 OrElse CInt(Right(oMaskTextBox.Text, 2)) >= 60 OrElse CInt(Left(Right(oMaskTextBox.Text, 5), 2)) >= 60 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é do tipo Hora. Digite um valor válido para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.minuto
                    'Verifica se foi Preenchido algum valor e se é numérico
                    If oMaskTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    ElseIf IsDate("00:" & oMaskTextBox.Text) = False Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é do tipo Data. Digite um valor válido para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.numero
                    'Verifica se foi Preenchido algum valor e se é numérico
                    If oMaskTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    ElseIf IsNumeric(oMaskTextBox.Text) = False Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é numérico. Digite um valor válido para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.texto
                    'Verifica se foi Preenchido algum valor
                    If oMaskTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    End If

                Case TipoCampo.email
                    'Verifica se foi Preenchido algum valor
                    If oMaskTextBox.Text.Length = 0 Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Digite um valor para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    ElseIf Regex.Match(oMaskTextBox.Text.Trim, sEmail).Success = False Then
                        frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é um e-mail. Digite um valor válido para ele.")
                        oMaskTextBox.Focus()
                        Exit Function
                    End If

            End Select

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oComboBox As UIComboBox, _
                                ByVal oControl As Control, _
                                Optional bValidaTexto As Boolean = False, _
                                Optional sLabel As String = "") As Boolean

        Try

            'Seta Retorno da Função
            ValidaCampo = False

            'Váriaveis
            Dim sCampo As String

            If sLabel = "" Then
                sCampo = Left(oControl.Text, oControl.Text.Length - 1).ToUpper
            Else
                sCampo = sLabel
            End If

            'Verifica se foi Selecionado algum valor
            If bValidaTexto = False Then
                If oComboBox.SelectedIndex = -1 Then
                    frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Selecione um valor para ele.")
                    oComboBox.Focus()
                    Exit Function
                End If
            Else
                If oComboBox.Text.Trim = "" Then
                    frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Preencha um valor para ele.")
                    oComboBox.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oComboBox As CheckedComboBox, _
                                ByVal oControl As Control) As Boolean

        Try

            'Seta Retorno da Função
            ValidaCampo = False

            'Váriaveis
            Dim sCampo As String

            sCampo = Left(oControl.Text, oControl.Text.Length - 1).ToUpper

            'Verifica se foi Selecionado algum valor
            If oComboBox.SelectionLength = 0 Then
                frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Selecione um valor para ele.")
                oComboBox.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oComboBox As MTGCComboBox, _
                                ByVal oControl As Control) As Boolean

        Try

            'Seta Retorno da Função
            ValidaCampo = False

            'Váriaveis
            Dim sCampo As String

            sCampo = Left(oControl.Text, oControl.Text.Length - 1).ToUpper

            'Verifica se foi Selecionado algum valor
            If oComboBox.SelectedIndex = -1 Then
                frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Selecione um valor para ele.")
                oComboBox.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oCell As GridEXCell, _
                                ByVal sCampo As String) As Boolean

        Try

            'Seta Retorno da Função
            ValidaCampo = False

            'Verifica se foi Selecionado algum valor
            If CStr(oCell.Value) = "" Then
                frmMain.Informacao(Mensagem.NaoFoiInformado, sCampo)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCampo(ByVal oComboBox As CalendarCombo, _
                                ByVal oControl As Control) As Boolean

        Try

            'Seta Retorno da Função
            ValidaCampo = False

            'Váriaveis
            Dim sCampo As String

            sCampo = Left(oControl.Text, oControl.Text.Length - 1).ToUpper

            'Verifica se foi Selecionado algum valor
            If oComboBox.Checked = False Then
                frmMain.errInfo.SetError(oControl, "O Campo [" & sCampo & "] é obrigatório. Selecione um valor para ele.")
                oComboBox.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidaCampo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRowChecked(ByVal oGrid As GridEX, _
                                              ByVal sColumn As String, _
                                              Optional ByVal sColumnStatus As String = "", _
                                              Optional ByVal sValor As String = "") As Boolean

        Try

            'Variáveis Loais
            Dim oRow() As GridEXRow = oGrid.GetDataRows
            Dim i As Integer

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowChecked = False

            With oGrid

                'Varrendo os itens selecionados
                For i = 0 To UBound(oRow)

                    'Verifica se a Linha foi Selecionada
                    If oRow(i).Cells(sColumn).Value = True Then

                        If sColumnStatus = "" Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowChecked = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow(i)

                        ElseIf oRow(i).Cells(sColumnStatus).Value = sValor Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowChecked = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow(i)

                        End If

                    End If

                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRowCheckedDiferente(ByVal oGrid As GridEX, _
                                                       ByVal sColumn As String, _
                                                       ByVal sColumn2 As String, _
                                                       ByVal sValor As String) As Boolean

        Try

            'Variáveis Loais
            Dim oRow() As GridEXRow = oGrid.GetDataRows
            Dim i As Integer

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowCheckedDiferente = False

            With oGrid

                'Varrendo os itens selecionados
                For i = 0 To UBound(oRow)

                    'Verifica se a Linha foi Selecionada
                    If ((oRow(i).Cells(sColumn).Value = True) And _
                       (oRow(i).Cells(sColumn2).Value = sValor Or sColumn2 = "")) Then

                        'Redimensiona Vetor caso necessário
                        If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                            ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                        End If

                        'Seta Retorno da Função
                        VerificaSelecaoRowCheckedDiferente = True

                        'Seta Valores
                        gSelecaoRow(UBound(gSelecaoRow)) = oRow(i)

                    End If

                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRowCheckedDiferente(ByVal oGrid As GridEX, _
                                                       ByVal sColumn As String) As Boolean

        Try

            'Variáveis Loais
            Dim oRow() As GridEXRow = oGrid.GetDataRows
            Dim i As Integer

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowCheckedDiferente = False

            With oGrid

                'Varrendo os itens selecionados
                For i = 0 To UBound(oRow)

                    'Verifica se a Linha foi Selecionada
                    If (oRow(i).Cells(sColumn).Value = True) Then

                        'Redimensiona Vetor caso necessário
                        If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                            ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                        End If

                        'Seta Retorno da Função
                        VerificaSelecaoRowCheckedDiferente = True

                        'Seta Valores
                        gSelecaoRow(UBound(gSelecaoRow)) = oRow(i)

                    End If

                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRow(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As GridEXRow
            Dim oRow As GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRow = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        'Redimensiona Vetor caso necessário
                        If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                            ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                        End If

                        'Seta Retorno da Função
                        VerificaSelecaoRow = True

                        'Seta Valores
                        gSelecaoRow(UBound(gSelecaoRow)) = oRow

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRow(ByVal oGrid As GridEX, sTable As String) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As GridEXRow
            Dim oRow As GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRow = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        If oRow.Table.Key.ToString = sTable Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRow = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRow(ByVal oGrid As GridEX, _
                                       ByVal sColumnStatus As String, _
                                       ByVal sStatus As String) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As Janus.Windows.GridEX.GridEXRow
            Dim oRow As Janus.Windows.GridEX.GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRow = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        If sStatus = "NULL" Then

                            'Verifica se foi Selecionado
                            If IsDBNull(oRow.Cells(sColumnStatus).Value) Then

                                'Redimensiona Vetor caso necessário
                                If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                    ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                                End If

                                'Seta Retorno da Função
                                VerificaSelecaoRow = True

                                'Seta Valores
                                gSelecaoRow(UBound(gSelecaoRow)) = oRow

                            End If

                        Else

                            'Verifica se foi Selecionado
                            If oRow.Cells(sColumnStatus).Value.ToString = sStatus Then

                                'Redimensiona Vetor caso necessário
                                If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                    ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                                End If

                                'Seta Retorno da Função
                                VerificaSelecaoRow = True

                                'Seta Valores
                                gSelecaoRow(UBound(gSelecaoRow)) = oRow

                            End If

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRow(ByVal oGrid As GridEX, _
                                       ByVal sColumnStatus As String, _
                                       ByVal sStatus As String, _
                                       ByVal sColumnAnd As String, _
                                       ByVal dValorAnd As Double) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As Janus.Windows.GridEX.GridEXRow
            Dim oRow As Janus.Windows.GridEX.GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRow = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        If sStatus = "NULL" Then

                            'Verifica se foi Selecionado
                            If IsDBNull(oRow.Cells(sColumnStatus).Value) AndAlso oRow.Cells(sColumnAnd).Value = dValorAnd Then

                                'Redimensiona Vetor caso necessário
                                If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                    ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                                End If

                                'Seta Retorno da Função
                                VerificaSelecaoRow = True

                                'Seta Valores
                                gSelecaoRow(UBound(gSelecaoRow)) = oRow

                            End If

                        Else

                            'Verifica se foi Selecionado
                            If oRow.Cells(sColumnStatus).Value.ToString = sStatus AndAlso oRow.Cells(sColumnAnd).Value = dValorAnd Then

                                'Redimensiona Vetor caso necessário
                                If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                    ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                                End If

                                'Seta Retorno da Função
                                VerificaSelecaoRow = True

                                'Seta Valores
                                gSelecaoRow(UBound(gSelecaoRow)) = oRow

                            End If

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRow(ByVal oGrid As GridEX, _
                                       ByVal sColumnStatus As String, _
                                       ByVal sStatus() As String, _
                                       Optional ByVal sColumnOr As String = "", _
                                       Optional ByVal oValueOr As Object = "", _
                                       Optional ByVal sColumnOr2 As String = "", _
                                       Optional ByVal oValueOr2 As Object = "") As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As Janus.Windows.GridEX.GridEXRow
            Dim oRow As Janus.Windows.GridEX.GridEXRow
            Dim i As Integer

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRow = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        For i = 0 To UBound(sStatus)

                            'Verifica se foi Selecionado
                            If oRow.Cells(sColumnStatus).Value.ToString = sStatus(i) Or _
                                (sColumnOr <> "" AndAlso oRow.Cells(sColumnOr).Value = oValueOr) Or _
                                (sColumnOr2 <> "" AndAlso IIf(IsDBNull(oRow.Cells(sColumnOr2).Value), "", oRow.Cells(sColumnOr2).Value) = oValueOr2) Then

                                'Redimensiona Vetor caso necessário
                                If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                    ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                                End If

                                'Seta Retorno da Função
                                VerificaSelecaoRow = True

                                'Seta Valores
                                gSelecaoRow(UBound(gSelecaoRow)) = oRow

                                Exit For

                            End If

                        Next

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRowDiferente(ByVal oGrid As GridEX, _
                                                ByVal sColumnStatus As String, _
                                                ByVal sStatus As String) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As Janus.Windows.GridEX.GridEXRow
            Dim oRow As Janus.Windows.GridEX.GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowDiferente = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        'Verifica se foi Selecionado
                        If oRow.Cells(sColumnStatus).Value <> sStatus Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowDiferente = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRowIgual(ByVal oGrid As GridEX, _
                                            ByVal sColumnStatus As String, _
                                            ByVal sStatus As String) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As Janus.Windows.GridEX.GridEXRow
            Dim oRow As Janus.Windows.GridEX.GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowIgual = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        'Verifica se foi Selecionado
                        If oRow.Cells(sColumnStatus).Value = sStatus Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowIgual = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoNode(ByVal oTree As TreeView) As Boolean

        Try

            'Redimensiona Vetor
            ReDim gSelecaoNode(0)

            For Each oNode As TreeNode In oTree.Nodes

                'Verifica se o Nó foi Selecionado
                If oNode.Checked = True Then

                    'Redimensiona Vetor caso necessário
                    If Not gSelecaoNode(UBound(gSelecaoNode)) Is Nothing Then
                        ReDim Preserve gSelecaoNode(UBound(gSelecaoNode) + 1)
                    End If

                    'Seta Valores
                    gSelecaoNode(UBound(gSelecaoNode)) = oNode

                End If

                Call VerificaSelecaoNodeFilho(oNode)

            Next

            If IsNothing(gSelecaoNode(UBound(gSelecaoNode))) Then
                VerificaSelecaoNode = False
            Else
                VerificaSelecaoNode = True
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoNodeDesmarcado(ByVal oTree As TreeView) As Boolean

        Try

            'Redimensiona Vetor
            ReDim gSelecaoNode(0)

            For Each oNode As TreeNode In oTree.Nodes

                'Verifica se o Nó foi Selecionado
                If oNode.Checked = False Then

                    'Redimensiona Vetor caso necessário
                    If Not gSelecaoNode(UBound(gSelecaoNode)) Is Nothing Then
                        ReDim Preserve gSelecaoNode(UBound(gSelecaoNode) + 1)
                    End If

                    'Seta Valores
                    gSelecaoNode(UBound(gSelecaoNode)) = oNode

                End If

                Call VerificaSelecaoNodeDesmarcadoFilho(oNode)

            Next

            If IsNothing(gSelecaoNode(UBound(gSelecaoNode))) Then
                VerificaSelecaoNodeDesmarcado = False
            Else
                VerificaSelecaoNodeDesmarcado = True
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub VerificaSelecaoNodeFilho(ByVal oNodes As TreeNode)

        Try

            For Each oNode As TreeNode In oNodes.Nodes

                'Verifica se o Nó foi Selecionado
                If oNode.Checked = True Then

                    'Redimensiona Vetor caso necessário
                    If Not gSelecaoNode(UBound(gSelecaoNode)) Is Nothing Then
                        ReDim Preserve gSelecaoNode(UBound(gSelecaoNode) + 1)
                    End If

                    'Seta Valores
                    gSelecaoNode(UBound(gSelecaoNode)) = oNode

                End If

                Call VerificaSelecaoNodeFilho(oNode)

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub VerificaSelecaoNodeDesmarcadoFilho(ByVal oNodes As TreeNode)

        Try

            For Each oNode As TreeNode In oNodes.Nodes

                'Verifica se o Nó foi Selecionado
                If oNode.Checked = False Then

                    'Redimensiona Vetor caso necessário
                    If Not gSelecaoNode(UBound(gSelecaoNode)) Is Nothing Then
                        ReDim Preserve gSelecaoNode(UBound(gSelecaoNode) + 1)
                    End If

                    'Seta Valores
                    gSelecaoNode(UBound(gSelecaoNode)) = oNode

                End If

                Call VerificaSelecaoNodeDesmarcadoFilho(oNode)

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Criptografar16(ByVal vstrTextToBeEncrypted As String, ByVal vstrEncryptionKey As String) As String

        Dim bytValue() As Byte
        Dim bytKey() As Byte
        Dim bytEncoded() As Byte
        Dim bytIV() As Byte = {121, 241, 10, 1, 132, 74, 11, 39, 255, 91, 45, 78, 14, 211, 22, 62}
        Dim intLength As Integer
        Dim intRemaining As Integer
        Dim objMemoryStream As New MemoryStream
        Dim objCryptoStream As CryptoStream
        Dim objRijndaelManaged As RijndaelManaged


        ' ***************************************************************
        ' ****** Descarta todos os caracteres nulos da palavra a ser cifrada              
        ' ***************************************************************

        vstrTextToBeEncrypted = RetirarCaracteresNulos(vstrTextToBeEncrypted)

        ' ***************************************************************
        ' ****** O valor deve estar dentro da tabela ASCII (i.e., no DBCS chars)    
        ' ***************************************************************

        bytValue = Encoding.ASCII.GetBytes(vstrTextToBeEncrypted.ToCharArray)

        intLength = Len(vstrEncryptionKey)

        ' ****************************************************************
        ' ****** A chave cifrada será de 256 bits long (32 bytes)                             
        ' ****** Se for maior que 32 bytes então será truncado.                               
        ' ****** Se for menor que 32 bytes será alocado.                                        
        ' ****** Usando upper-case Xs.                                                                  
        ' ****************************************************************

        If intLength >= 32 Then
            vstrEncryptionKey = Strings.Left(vstrEncryptionKey, 32)
        Else
            intLength = Len(vstrEncryptionKey)
            intRemaining = 32 - intLength
            vstrEncryptionKey = vstrEncryptionKey & Strings.StrDup(intRemaining, "X")
        End If

        bytKey = Encoding.ASCII.GetBytes(vstrEncryptionKey.ToCharArray)

        objRijndaelManaged = New RijndaelManaged

        ' **************************************************************
        ' ****** Cria o valor a ser crifrado e depois escreve                                  
        ' ****** Convertido em uma disposição do byte                                       
        ' **************************************************************

        Try

            objCryptoStream = New CryptoStream(objMemoryStream, objRijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
            objCryptoStream.Write(bytValue, 0, bytValue.Length)

            objCryptoStream.FlushFinalBlock()

            bytEncoded = objMemoryStream.ToArray
            objMemoryStream.Close()
            objCryptoStream.Close()
        Catch

        End Try

        ' **************************************************************
        ' ****** Retorna o valor cifrado (convertido de byte para base64)           
        ' **************************************************************

        Return Convert.ToBase64String(bytEncoded)

    End Function

    Public Function Descriptografar16(ByVal vstrStringToBeDecrypted As String, ByVal vstrDecryptionKey As String) As String

        Dim bytDataToBeDecrypted() As Byte
        Dim bytTemp() As Byte
        Dim bytIV() As Byte = {121, 241, 10, 1, 132, 74, 11, 39, 255, 91, 45, 78, 14, 211, 22, 62}
        Dim objRijndaelManaged As New RijndaelManaged
        Dim objMemoryStream As MemoryStream
        Dim objCryptoStream As CryptoStream
        Dim bytDecryptionKey() As Byte

        Dim intLength As Integer
        Dim intRemaining As Integer
        Dim strReturnString As String = String.Empty

        ' ***************************************************************
        ' ****** Convert base64 cifrada para byte array                                
        ' ****** Convert base64 cifrada para byte array                                
        ' ***************************************************************

        bytDataToBeDecrypted = Convert.FromBase64String(vstrStringToBeDecrypted)

        ' ***************************************************************
        ' ****** A chave cifrada sera de 256 bits long (32 bytes)                           
        ' ****** Se for maior que 32 bytes então será truncado.                              
        ' ****** Se for menor que 32 bytes será alocado.                                       
        ' ****** Usando upper-case Xs.                                                              
        ' ***************************************************************

        intLength = Len(vstrDecryptionKey)

        If intLength >= 32 Then
            vstrDecryptionKey = Strings.Left(vstrDecryptionKey, 32)
        Else
            intLength = Len(vstrDecryptionKey)
            intRemaining = 32 - intLength
            vstrDecryptionKey = vstrDecryptionKey & Strings.StrDup(intRemaining, "X")
        End If

        bytDecryptionKey = Encoding.ASCII.GetBytes(vstrDecryptionKey.ToCharArray)

        ReDim bytTemp(bytDataToBeDecrypted.Length)

        objMemoryStream = New MemoryStream(bytDataToBeDecrypted)

        ' ***************************************************************
        ' ****** Escrever o valor decifrado depois que é convertido                      
        ' ***************************************************************

        Try

            objCryptoStream = New CryptoStream(objMemoryStream, _
            objRijndaelManaged.CreateDecryptor(bytDecryptionKey, bytIV), _
            CryptoStreamMode.Read)

            objCryptoStream.Read(bytTemp, 0, bytTemp.Length)

            objCryptoStream.FlushFinalBlock()
            objMemoryStream.Close()
            objCryptoStream.Close()

        Catch

        End Try

        ' ***************************************************************
        ' ****** Retorna o valor decifrado                                    
        ' ***************************************************************
        Return RetirarCaracteresNulos(Encoding.ASCII.GetString(bytTemp))

    End Function

    Public Function RetirarCaracteresNulos(ByVal vstrStringWithNulls As String) As String

        Dim intPosition As Integer
        Dim strStringWithOutNulls As String

        intPosition = 1
        strStringWithOutNulls = vstrStringWithNulls

        Do While intPosition > 0
            intPosition = InStr(intPosition, vstrStringWithNulls, vbNullChar)

            If intPosition > 0 Then
                strStringWithOutNulls = Left$(strStringWithOutNulls, intPosition - 1) & _
                Right$(strStringWithOutNulls, Len(strStringWithOutNulls) - intPosition)
            End If

            If intPosition > strStringWithOutNulls.Length Then
                Exit Do
            End If
        Loop

        Return strStringWithOutNulls

    End Function

    Public Function RetirarAcento(ByVal sValue As String)

        Try

            'Váriavel Local
            Dim sResultado As String = sValue

            sResultado = Replace(sResultado, "´", "")
            sResultado = Replace(sResultado, "~", "")
            sResultado = Replace(sResultado, "`", "")
            sResultado = Replace(sResultado, "^", "")
            sResultado = Replace(sResultado, "º", "")
            sResultado = Replace(sResultado, "ª", "")
            sResultado = Replace(sResultado, "§", "")
            sResultado = Replace(sResultado, "¢", "")
            sResultado = Replace(sResultado, "¬", "")
            sResultado = Replace(sResultado, "$", "")
            sResultado = Replace(sResultado, "#", "")
            sResultado = Replace(sResultado, "'", "")
            sResultado = Replace(sResultado, "–", "-")
            sResultado = Replace(sResultado, """", "")

            sResultado = Replace(sResultado, "Á", "A")
            sResultado = Replace(sResultado, "É", "E")
            sResultado = Replace(sResultado, "Í", "I")
            sResultado = Replace(sResultado, "Ó", "O")
            sResultado = Replace(sResultado, "Ú", "U")

            sResultado = Replace(sResultado, "á", "a")
            sResultado = Replace(sResultado, "é", "e")
            sResultado = Replace(sResultado, "é", "i")
            sResultado = Replace(sResultado, "ó", "o")
            sResultado = Replace(sResultado, "ú", "u")

            sResultado = Replace(sResultado, "Â", "A")
            sResultado = Replace(sResultado, "Ê", "E")
            sResultado = Replace(sResultado, "Ô", "I")

            sResultado = Replace(sResultado, "â", "a")
            sResultado = Replace(sResultado, "ê", "e")
            sResultado = Replace(sResultado, "ô", "i")

            sResultado = Replace(sResultado, "Ã", "A")
            sResultado = Replace(sResultado, "Õ", "O")
            sResultado = Replace(sResultado, "ã", "a")
            sResultado = Replace(sResultado, "õ", "o")

            sResultado = Replace(sResultado, "Ç", "C")
            sResultado = Replace(sResultado, "ç", "ç")

            sResultado = Replace(sResultado, "À", "A")
            sResultado = Replace(sResultado, "à", "a")
            sResultado = Replace(sResultado, vbCrLf, " ")

            Return sResultado.Trim

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function RetirarAcento2(ByVal sValue As String)

        Try

            'Váriavel Local
            Dim sResultado As String = sValue
            sResultado = Replace(sResultado, "M&amp;#", "")
            sResultado = Replace(sResultado, "³", "")
            sResultado = Replace(sResultado, "´", "")
            sResultado = Replace(sResultado, "~", "")
            sResultado = Replace(sResultado, "'", "")
            sResultado = Replace(sResultado, "'", "")
            sResultado = Replace(sResultado, "`", "")
            sResultado = Replace(sResultado, "^", "")
            sResultado = Replace(sResultado, "º", "")
            sResultado = Replace(sResultado, "ª", "")
            sResultado = Replace(sResultado, "§", "")
            sResultado = Replace(sResultado, "¢", "")
            sResultado = Replace(sResultado, "¬", "")
            sResultado = Replace(sResultado, "$", "")
            sResultado = Replace(sResultado, "#", "")
            sResultado = Replace(sResultado, "°", "")
            'sResultado = Replace(sResultado, "", "")
            'sResultado = Replace(sResultado, "", "")
            'sResultado = Replace(sResultado, " ", "")
            sResultado = Replace(sResultado, "¨", "")

            sResultado = Replace(sResultado, "Á", "A")
            sResultado = Replace(sResultado, "É", "E")
            sResultado = Replace(sResultado, "Í", "I")
            sResultado = Replace(sResultado, "Ó", "O")
            sResultado = Replace(sResultado, "Ú", "U")

            sResultado = Replace(sResultado, "á", "a")
            sResultado = Replace(sResultado, "é", "e")
            sResultado = Replace(sResultado, "í", "i")
            sResultado = Replace(sResultado, "ó", "o")
            sResultado = Replace(sResultado, "ú", "u")

            sResultado = Replace(sResultado, "Â", "A")
            sResultado = Replace(sResultado, "Ê", "E")
            sResultado = Replace(sResultado, "Ô", "I")

            sResultado = Replace(sResultado, "â", "a")
            sResultado = Replace(sResultado, "ê", "e")
            sResultado = Replace(sResultado, "ô", "i")
            sResultado = Replace(sResultado, "Æ", "")

            sResultado = Replace(sResultado, "Ã", "A")
            sResultado = Replace(sResultado, "Õ", "O")
            sResultado = Replace(sResultado, "ã", "a")
            sResultado = Replace(sResultado, "õ", "o")

            sResultado = Replace(sResultado, "Ç", "C")
            sResultado = Replace(sResultado, "ç", "c")

            sResultado = Replace(sResultado, "À", "A")
            sResultado = Replace(sResultado, "à", "a")
            sResultado = Replace(sResultado, vbCrLf, " ")

            sResultado = Replace(sResultado, "&Aacute;", "A")
            sResultado = Replace(sResultado, "&aacute;", "A")
            sResultado = Replace(sResultado, "&Acirc;", "A")
            sResultado = Replace(sResultado, "&acirc;", "A")
            sResultado = Replace(sResultado, "&Agrave;", "A")
            sResultado = Replace(sResultado, "&agrave;", "A")
            sResultado = Replace(sResultado, "&Aring;", "A")
            sResultado = Replace(sResultado, "&aring;", "A")
            sResultado = Replace(sResultado, "&Atilde;", "A")
            sResultado = Replace(sResultado, "&atilde;", "A")
            sResultado = Replace(sResultado, "&Auml;", "A")
            sResultado = Replace(sResultado, "&auml;", "A")
            sResultado = Replace(sResultado, "&AElig;", "A")
            sResultado = Replace(sResultado, "&aelig;", "A")

            sResultado = Replace(sResultado, "&Eacute;", "E")
            sResultado = Replace(sResultado, "&eacute;", "E")
            sResultado = Replace(sResultado, "&Ecirc;", "E")
            sResultado = Replace(sResultado, "&ecirc;", "E")
            sResultado = Replace(sResultado, "&Egrave;", "E")
            sResultado = Replace(sResultado, "&egrave;", "E")
            sResultado = Replace(sResultado, "&Euml;", "E")
            sResultado = Replace(sResultado, "&euml;", "E")
            sResultado = Replace(sResultado, "&ETH;", "E")
            sResultado = Replace(sResultado, "&eth;", "E")

            sResultado = Replace(sResultado, "&Iacute;", "I")
            sResultado = Replace(sResultado, "&iacute;", "I")
            sResultado = Replace(sResultado, "&Icirc;", "I")
            sResultado = Replace(sResultado, "&icirc;", "I")
            sResultado = Replace(sResultado, "&Igrave;", "I")
            sResultado = Replace(sResultado, "&igrave;", "I")
            sResultado = Replace(sResultado, "&Iuml;", "I")
            sResultado = Replace(sResultado, "&iuml;", "I")

            sResultado = Replace(sResultado, "&Oacute;", "O")
            sResultado = Replace(sResultado, "&oacute;", "O")
            sResultado = Replace(sResultado, "&Ocirc;", "O")
            sResultado = Replace(sResultado, "&ocirc;", "O")
            sResultado = Replace(sResultado, "&Ograve;", "O")
            sResultado = Replace(sResultado, "&ograve;", "O")
            sResultado = Replace(sResultado, "&Oslash;", "O")
            sResultado = Replace(sResultado, "&oslash;", "O")
            sResultado = Replace(sResultado, "&Otilde;", "O")
            sResultado = Replace(sResultado, "&otilde;", "O")
            sResultado = Replace(sResultado, "&Ouml;", "O")
            sResultado = Replace(sResultado, "&ouml;", "O")

            sResultado = Replace(sResultado, "&Uacute;", "U")
            sResultado = Replace(sResultado, "&uacute;", "U")
            sResultado = Replace(sResultado, "&Ucirc;", "U")
            sResultado = Replace(sResultado, "&ucirc;", "U")
            sResultado = Replace(sResultado, "&Ugrave;", "U")
            sResultado = Replace(sResultado, "&ugrave;", "U")
            sResultado = Replace(sResultado, "&Uuml;", "U")
            sResultado = Replace(sResultado, "&uuml;", "U")

            sResultado = Replace(sResultado, "&Ccedil;", "C")
            sResultado = Replace(sResultado, "&ccedil;", "C")

            sResultado = Replace(sResultado, "&Ntilde;", "N")
            sResultado = Replace(sResultado, "&ntilde;", "N")

            sResultado = Replace(sResultado, "&lt;", "")
            sResultado = Replace(sResultado, "&gt;", "")
            sResultado = Replace(sResultado, "&amp;", "")
            sResultado = Replace(sResultado, "&quot;", "")
            sResultado = Replace(sResultado, "&reg;", "")
            sResultado = Replace(sResultado, "&copy;", "")
            sResultado = Replace(sResultado, "&THORN;", "")
            sResultado = Replace(sResultado, "&thorn;", "")
            sResultado = Replace(sResultado, "&szlig;", "")
            sResultado = Replace(sResultado, "&39;", "")

            sResultado = Replace(sResultado, "&Yacute;", "Y")
            sResultado = Replace(sResultado, "&yacute;", "Y")

            sResultado = Replace(sResultado, "·", "")
            sResultado = Replace(sResultado, "ø", "")
            sResultado = Replace(sResultado, "²", "")
            sResultado = Replace(sResultado, "Ø", "")
            sResultado = Replace(sResultado, "#", "")
            sResultado = Replace(sResultado, "'", """")
            sResultado = Replace(sResultado, " ", " ")
            sResultado = Replace(sResultado, "!", "")
            sResultado = Replace(sResultado, "", "")
            sResultado = Replace(sResultado, "", "")
            sResultado = Replace(sResultado, "", "")

            sResultado = Replace(sResultado, "&xC3;", "A") 'Ã'
            sResultado = Replace(sResultado, "&xC7;", "C") 'Ç'
            sResultado = Replace(sResultado, "&xC9;", "E") 'É'
            sResultado = Replace(sResultado, "&xE3;", "a") 'ã'
            sResultado = Replace(sResultado, "&xE7;", "c") 'ç'
            sResultado = Replace(sResultado, "&xE9;", "e") 'é'

            Return sResultado.Trim

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GetCertificado(ByVal sNome As String) As X509Certificate2

        Try

            'Váriaveis Locais
            Dim oX509Certificate2 As New X509Certificate2
            Dim oX509Store As X509Store = New X509Store("MY", StoreLocation.CurrentUser)

            oX509Store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)

            Dim oX509Certificate2Collection As X509Certificate2Collection = oX509Store.Certificates
            Dim oX509Certificate2Collection1 As X509Certificate2Collection = oX509Certificate2Collection.Find(X509FindType.FindByTimeValid, DateTime.Now, False)
            Dim oX509Certificate2Collection2 As X509Certificate2Collection = oX509Certificate2Collection.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, False)

            If (sNome = "") Then
                Dim oX509Certificate2Collection3 As X509Certificate2Collection = X509Certificate2UI.SelectFromCollection(oX509Certificate2Collection2, "Certificado(s) Digital(is) disponível(is)", "Selecione o Certificado Digital para uso no aplicativo", X509SelectionFlag.SingleSelection)
                If (oX509Certificate2Collection3.Count = 0) Then
                    oX509Certificate2.Reset()
                    'Informa o Usuário que não econtrou nenhum certificado
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Certificado Digital")
                Else
                    oX509Certificate2 = oX509Certificate2Collection3(0)
                End If
            Else
                Dim oX509Certificate2Collection3 As X509Certificate2Collection = oX509Certificate2Collection2.Find(X509FindType.FindBySubjectDistinguishedName, sNome, False)
                If (oX509Certificate2Collection3.Count = 0) Then
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Certificado Digital: " & sNome)
                    oX509Certificate2.Reset()
                Else
                    oX509Certificate2 = oX509Certificate2Collection3(0)
                End If
            End If

            'Fecha X509Store
            oX509Store.Close()

            'Retorna Resultado
            Return oX509Certificate2

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaExisteValorGrid(ByVal oGrid As GridEX, _
                                            ByVal sQuery As String) As Boolean

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
            Else
                Return False
            End If

            If oDataTable.Select(sQuery).Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaExisteValorGrid(ByVal oGrid As GridEX, _
                                            ByVal sColumn As String, _
                                            ByVal sValor As String) As Boolean

        Try

            'Variáveis Loais
            Dim i As Integer
            Dim oRow() As GridEXRow = oGrid.GetDataRows

            'Varre Grid
            For i = 0 To UBound(oRow)
                If oRow(i).Cells(sColumn).Value = sValor Then
                    'Seta Retorno da Função
                    Return True
                End If
            Next

            'Seta Retorno da Função
            Return False

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaExisteValorGrid(ByVal oGrid As GridEX, _
                                            ByVal sColumn As String, _
                                            ByVal sValor As String, _
                                            ByVal iRowExcessao As Integer) As Boolean

        Try

            'Varre Grid
            For Each oRow As GridEXRow In oGrid.GetDataRows
                If IsDBNull(oRow.Cells(sColumn).Value) = False Then
                    If oRow.Cells(sColumn).Value = sValor And oRow.RowIndex <> iRowExcessao Then
                        'Seta Retorno da Função
                        Return True
                    End If
                Else
                    'Seta Retorno da Função
                    Return False
                End If
            Next

            'Seta Retorno da Função
            Return False

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function SomaValorGrid(ByVal oGrid As GridEX, _
                                  ByVal sColumn As String, _
                                  ByVal iRowExcessao As Integer) As Double

        Try

            'Variáveis Loais
            Dim i As Integer
            Dim dReturn As Double = 0
            Dim oRow() As GridEXRow = oGrid.GetDataRows

            'Varre Grid
            For i = 0 To UBound(oRow)
                If oRow(i).RowIndex <> iRowExcessao Then
                    'Seta Retorno da Função
                    dReturn += oRow(i).Cells(sColumn).Value
                End If
            Next

            'Seta Retorno da Função
            Return dReturn

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function FindValueGrid(ByVal oRow() As GridEXRow, _
                                  ByVal sColuna As String, _
                                  ByVal sValor As String, _
                                  ByVal sColunaValor As String) As Double

        Try

            'Váriaveis Locais
            Dim i As Integer
            Dim dValor As Double = 0

            For i = 0 To UBound(oRow)

                If oRow(i).Cells(sColuna).Value = sValor Then
                    dValor = CDbl(oRow(i).Cells(sColunaValor).Value)
                    Exit For
                End If

            Next

            Return dValor

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaIE(ByVal sUF As String, ByVal sInscricaoEstadual As String) As Boolean

        Try

            'Return IIf(ConsisteInscricaoEstadual(sInscricaoEstadual, sUF) = 0, True, False)

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'Public Function ValidaIE(ByVal sUF As String, ByVal sInscricaoEstadual As String) As Boolean

    '    'Váriaveis Locais
    '    Dim sBase1 As String
    '    Dim sBase2 As String
    '    Dim sOrigem As String
    '    Dim sDigito1 As String
    '    Dim sDigito2 As String
    '    Dim iPosicao As Integer
    '    Dim iValor As Integer
    '    Dim iSoma As Integer
    '    Dim iResto As Integer
    '    Dim iNumero As Integer
    '    Dim iPeso As Integer
    '    Dim iDigito As Integer

    '    Try

    '        sInscricaoEstadual = sInscricaoEstadual.Replace(".", "")

    '        'Seta Retorno da Função
    '        ValidaIE = False

    '        sBase1 = ""
    '        sBase2 = ""
    '        sOrigem = ""

    '        'Verifica se a Inscrição Estadual é Isento
    '        If sInscricaoEstadual.Trim = "ISENTO" Then
    '            ValidaIE = True
    '            Exit Function
    '        End If

    '        If sUF = "EX" Then
    '            If sInscricaoEstadual.Trim <> "ISENTO" Then
    '                ValidaIE = False
    '                Exit Function
    '            Else
    '                ValidaIE = True
    '                Exit Function
    '            End If
    '        End If

    '        For iPosicao = 1 To Len(Trim(sInscricaoEstadual))
    '            If InStr(1, "0123456789P", Mid$(sInscricaoEstadual, iPosicao, 1), vbTextCompare) > 0 Then
    '                sOrigem = sOrigem & Mid$(sInscricaoEstadual, iPosicao, 1)
    '            End If
    '        Next

    '        Select Case sUF

    '            Case "AC"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                If Left(sBase1, 2) = "01" And Mid$(sBase1, 3, 2) <> "00" Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "AL"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                If Left(sBase1, 2) = "24" Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iSoma = iSoma * 10
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto = 10, "0", Str(iResto)), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "AM"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                iSoma = 0
    '                For iPosicao = 1 To 8
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * (10 - iPosicao)
    '                    iSoma = iSoma + iValor
    '                Next
    '                If iSoma < 11 Then
    '                    sDigito1 = Right(Str(11 - iSoma), 1)
    '                Else
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                End If
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "AP"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                iPeso = 0
    '                iDigito = 0
    '                If Left(sBase1, 2) = "03" Then
    '                    iNumero = Val(Left(sBase1, 8))
    '                    If iNumero >= 3000001 And _
    '                       iNumero <= 3017000 Then
    '                        iPeso = 5
    '                        iDigito = 0
    '                    ElseIf iNumero >= 3017001 And _
    '                           iNumero <= 3019022 Then
    '                        iPeso = 9
    '                        iDigito = 1
    '                    ElseIf iNumero >= 3019023 Then
    '                        iPeso = 0
    '                        iDigito = 0
    '                    End If
    '                    iSoma = iPeso
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    iValor = 11 - iResto
    '                    If iValor = 10 Then
    '                        iValor = 0
    '                    ElseIf iValor = 11 Then
    '                        iValor = iDigito
    '                    End If
    '                    sDigito1 = Right(Str(iValor), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "BA"
    '                sBase1 = Left(Trim(sOrigem) & "00000000", 8)
    '                If InStr(1, "0123458", Left(sBase1, 1), vbTextCompare) > 0 Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 6
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (8 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 10
    '                    sDigito2 = Right(IIf(iResto = 0, "0", Str(10 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 6) & sDigito2
    '                    iSoma = 0
    '                    For iPosicao = 1 To 7
    '                        iValor = Val(Mid$(sBase2, iPosicao, 1))
    '                        iValor = iValor * (9 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 10
    '                    sDigito1 = Right(IIf(iResto = 0, "0", Str(10 - iResto)), 1)
    '                Else
    '                    iSoma = 0
    '                    For iPosicao = 1 To 6
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (8 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito2 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 6) & sDigito2
    '                    iSoma = 0
    '                    For iPosicao = 1 To 7
    '                        iValor = Val(Mid$(sBase2, iPosicao, 1))
    '                        iValor = iValor * (9 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                End If
    '                sBase2 = Left(sBase1, 6) & sDigito1 & sDigito2
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "CE"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                iSoma = 0
    '                For iPosicao = 1 To 8
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * (10 - iPosicao)
    '                    iSoma = iSoma + iValor
    '                Next
    '                iResto = iSoma Mod 11
    '                iValor = 11 - iResto
    '                If iValor > 9 Then
    '                    iValor = 0
    '                End If
    '                sDigito1 = Right(Str(iValor), 1)
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "DF"
    '                sBase1 = Left(Trim(sOrigem) & "0000000000000", 13)
    '                If Left(sBase1, 3) = "073" Then
    '                    iSoma = 0
    '                    iPeso = 2
    '                    For iPosicao = 11 To 1 Step -1
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * iPeso
    '                        iSoma = iSoma + iValor
    '                        iPeso = iPeso + 1
    '                        If iPeso > 9 Then
    '                            iPeso = 2
    '                        End If
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 11) & sDigito1
    '                    iSoma = 0
    '                    iPeso = 2
    '                    For iPosicao = 12 To 1 Step -1
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * iPeso
    '                        iSoma = iSoma + iValor
    '                        iPeso = iPeso + 1
    '                        If iPeso > 9 Then
    '                            iPeso = 2
    '                        End If
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito2 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 12) & sDigito2
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "ES"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                iSoma = 0
    '                For iPosicao = 1 To 8
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * (10 - iPosicao)
    '                    iSoma = iSoma + iValor
    '                Next
    '                iResto = iSoma Mod 11
    '                sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "GO"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                If InStr(1, "10,11,15", Left(sBase1, 2), vbTextCompare) > 0 Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    If iResto = 0 Then
    '                        sDigito1 = "0"
    '                    ElseIf iResto = 1 Then
    '                        iNumero = Val(Left(sBase1, 8))
    '                        sDigito1 = Right(IIf(iNumero >= 10103105 And iNumero <= 10119997, "1", "0"), 1)
    '                    Else
    '                        sDigito1 = Right(Str(11 - iResto), 1)
    '                    End If
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "MA"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                If Left(sBase1, 2) = "12" Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "MT"
    '                Dim aux1, aux2 As Double
    '                While Len(sOrigem) < 11
    '                    sOrigem = "0" & sOrigem
    '                End While
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 11)
    '                iSoma = 3 * CInt(Mid(sBase1, 1, 1)) + 2 * CInt(Mid(sBase1, 2, 1)) + _
    '                        9 * CInt(Mid(sBase1, 3, 1)) + 8 * CInt(Mid(sBase1, 4, 1)) + _
    '                        7 * CInt(Mid(sBase1, 5, 1)) + 6 * CInt(Mid(sBase1, 6, 1)) + _
    '                        5 * CInt(Mid(sBase1, 7, 1)) + 4 * CInt(Mid(sBase1, 8, 1)) + _
    '                        3 * CInt(Mid(sBase1, 9, 1)) + 2 * CInt(Mid(sBase1, 10, 1))
    '                aux1 = Fix(iSoma / 11)
    '                aux1 = aux1 * 11
    '                aux2 = iSoma - aux1
    '                If aux2 = 0 Or aux2 = 1 Then
    '                    sDigito1 = 0
    '                Else
    '                    sDigito1 = 11 - aux2
    '                End If
    '                If Mid(sBase1, 11, 1) = sDigito1 Then
    '                    ValidaIE = True
    '                End If

    '            Case "MS"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                If Left(sBase1, 2) = "28" Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "MG"
    '                sBase1 = Left(Trim(sOrigem) & "0000000000000", 13)
    '                sBase2 = Left(sBase1, 3) & "0" & Mid$(sBase1, 4, 8)
    '                iNumero = 2
    '                For iPosicao = 1 To 12
    '                    iValor = Val(Mid$(sBase2, iPosicao, 1))
    '                    iNumero = IIf(iNumero = 2, 1, 2)
    '                    iValor = iValor * iNumero
    '                    If iValor > 9 Then
    '                        sDigito1 = Format(iValor, "00")
    '                        iValor = Val(Left(sDigito1, 1)) + _
    '                                   Val(Right(sDigito1, 1))
    '                    End If
    '                    iSoma = iSoma + iValor
    '                Next
    '                iValor = iSoma
    '                While Right(Format(iValor, "000"), 1) <> "0"
    '                    iValor = iValor + 1
    '                End While
    '                sDigito1 = Right(Format(iValor - iSoma, "00"), 1)
    '                sBase2 = Left(sBase1, 11) & sDigito1
    '                iSoma = 0
    '                iPeso = 2
    '                For iPosicao = 12 To 1 Step -1
    '                    iValor = Val(Mid$(sBase2, iPosicao, 1))
    '                    iValor = iValor * iPeso
    '                    iSoma = iSoma + iValor
    '                    iPeso = iPeso + 1
    '                    If iPeso > 11 Then
    '                        iPeso = 2
    '                    End If
    '                Next
    '                iResto = iSoma Mod 11
    '                sDigito2 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                sBase2 = sBase2 & sDigito2
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "PA"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                If Left(sBase1, 2) = "15" Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "PB"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                iSoma = 0
    '                For iPosicao = 1 To 8
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * (10 - iPosicao)
    '                    iSoma = iSoma + iValor
    '                Next
    '                iResto = iSoma Mod 11
    '                iValor = 11 - iResto
    '                If iValor > 9 Then
    '                    iValor = 0
    '                End If
    '                sDigito1 = Right(Str(iValor), 1)
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "PE"
    '                If Len(sOrigem) = 14 Then
    '                    sBase1 = Left(Trim(sOrigem) & "00000000000000", 14)
    '                    iSoma = 0
    '                    iPeso = 2
    '                    For iPosicao = 13 To 1 Step -1
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * iPeso
    '                        iSoma = iSoma + iValor
    '                        iPeso = iPeso + 1
    '                        If iPeso > 9 Then
    '                            iPeso = 2
    '                        End If
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    iValor = 11 - iResto
    '                    If iValor > 9 Then
    '                        iValor = iValor - 10
    '                    End If
    '                    sDigito1 = Right(Str(iValor), 1)
    '                    sBase2 = Left(sBase1, 13) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                Else
    '                    sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                    iSoma = 0
    '                    iValor = 0
    '                    For iPosicao = 1 To 7
    '                        iValor = CInt(Val(Mid$(sBase1, iPosicao, 1)))
    '                        iValor = iValor * (9 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    If iResto = 0 Or iResto = 1 Then
    '                        sDigito1 = "0"
    '                    Else
    '                        sDigito1 = (11 - iResto).ToString
    '                    End If
    '                    iSoma = CInt(CDbl(sDigito1) * 2)
    '                    iValor = 0
    '                    For iPosicao = 1 To 7
    '                        iValor = CInt(Val(Mid$(sBase1, iPosicao, 1)))
    '                        iValor = iValor * (9 - (iPosicao - 1))
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    If iResto = 0 Or iResto = 1 Then
    '                        sDigito2 = "0"
    '                    Else
    '                        sDigito2 = (11 - iResto).ToString
    '                    End If
    '                    sBase2 = Strings.Left(sBase1, 7) & sDigito1 & sDigito2

    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "PI"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                iSoma = 0
    '                For iPosicao = 1 To 8
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * (10 - iPosicao)
    '                    iSoma = iSoma + iValor
    '                Next
    '                iResto = iSoma Mod 11
    '                sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "PR"
    '                sBase1 = Left(Trim(sOrigem) & "0000000000", 10)
    '                iSoma = 0
    '                iPeso = 2
    '                For iPosicao = 8 To 1 Step -1
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * iPeso
    '                    iSoma = iSoma + iValor
    '                    iPeso = iPeso + 1
    '                    If iPeso > 7 Then
    '                        iPeso = 2
    '                    End If
    '                Next
    '                iResto = iSoma Mod 11
    '                sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                iSoma = 0
    '                iPeso = 2
    '                For iPosicao = 9 To 1 Step -1
    '                    iValor = Val(Mid$(sBase2, iPosicao, 1))
    '                    iValor = iValor * iPeso
    '                    iSoma = iSoma + iValor
    '                    iPeso = iPeso + 1
    '                    If iPeso > 7 Then
    '                        iPeso = 2
    '                    End If
    '                Next
    '                iResto = iSoma Mod 11
    '                sDigito2 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                sBase2 = sBase2 & sDigito2
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "RJ"
    '                sBase1 = Left(Trim(sOrigem) & "00000000", 8)
    '                iSoma = 0
    '                iPeso = 2
    '                For iPosicao = 7 To 1 Step -1
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * iPeso
    '                    iSoma = iSoma + iValor
    '                    iPeso = iPeso + 1
    '                    If iPeso > 7 Then
    '                        iPeso = 2
    '                    End If
    '                Next
    '                iResto = iSoma Mod 11
    '                sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                sBase2 = Left(sBase1, 7) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "RN"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                If Left(sBase1, 2) = "20" Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iSoma = iSoma * 10
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto > 9, "0", Str(iResto)), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "RO"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                sBase2 = Mid$(sBase1, 4, 5)
    '                iSoma = 0
    '                For iPosicao = 1 To 5
    '                    iValor = Val(Mid$(sBase2, iPosicao, 1))
    '                    iValor = iValor * (7 - iPosicao)
    '                    iSoma = iSoma + iValor
    '                Next
    '                iResto = iSoma Mod 11
    '                iValor = 11 - iResto
    '                If iValor > 9 Then
    '                    iValor = iValor - 10
    '                End If
    '                sDigito1 = Right(Str(iValor), 1)
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "RR"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                If Left(sBase1, 2) = "24" Then
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 9
    '                    sDigito1 = Right(Str(iResto), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "RS"
    '                sBase1 = Left(Trim(sOrigem) & "0000000000", 10)
    '                iNumero = Val(Left(sBase1, 3))
    '                If iNumero > 0 And iNumero < 468 Then
    '                    iSoma = 0
    '                    iPeso = 2
    '                    For iPosicao = 9 To 1 Step -1
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * iPeso
    '                        iSoma = iSoma + iValor
    '                        iPeso = iPeso + 1
    '                        If iPeso > 9 Then
    '                            iPeso = 2
    '                        End If
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    iValor = 11 - iResto
    '                    If iValor > 9 Then
    '                        iValor = 0
    '                    End If
    '                    sDigito1 = Right(Str(iValor), 1)
    '                    sBase2 = Left(sBase1, 9) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '            Case "SC"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                iSoma = 0
    '                For iPosicao = 1 To 8
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * (10 - iPosicao)
    '                    iSoma = iSoma + iValor
    '                Next
    '                iResto = iSoma Mod 11
    '                sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "SE"
    '                sBase1 = Left(Trim(sOrigem) & "000000000", 9)
    '                iSoma = 0
    '                For iPosicao = 1 To 8
    '                    iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                    iValor = iValor * (10 - iPosicao)
    '                    iSoma = iSoma + iValor
    '                Next
    '                iResto = iSoma Mod 11
    '                iValor = 11 - iResto
    '                If iValor > 9 Then
    '                    iValor = 0
    '                End If
    '                sDigito1 = Right(Str(iValor), 1)
    '                sBase2 = Left(sBase1, 8) & sDigito1
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "SP"
    '                If Left(sOrigem, 1) = "P" Then
    '                    sBase1 = Left(Trim(sOrigem) & "0000000000000", 13)
    '                    sBase2 = Mid$(sBase1, 2, 8)
    '                    iSoma = 0
    '                    iPeso = 1
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * iPeso
    '                        iSoma = iSoma + iValor
    '                        iPeso = iPeso + 1
    '                        If iPeso = 2 Then
    '                            iPeso = 3
    '                        End If
    '                        If iPeso = 9 Then
    '                            iPeso = 10
    '                        End If
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(Str(iResto), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1 & Mid$(sBase1, 11, 3)
    '                Else
    '                    sBase1 = Left(Trim(sOrigem) & "000000000000", 12)
    '                    iSoma = 0
    '                    iPeso = 1
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * iPeso
    '                        iSoma = iSoma + iValor
    '                        iPeso = iPeso + 1
    '                        If iPeso = 2 Then
    '                            iPeso = 3
    '                        End If
    '                        If iPeso = 9 Then
    '                            iPeso = 10
    '                        End If
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(Str(iResto), 1)
    '                    sBase2 = Left(sBase1, 8) & sDigito1 & Mid$(sBase1, 10, 2)
    '                    iSoma = 0
    '                    iPeso = 2
    '                    For iPosicao = 11 To 1 Step -1
    '                        iValor = Val(Mid$(sBase1, iPosicao, 1))
    '                        iValor = iValor * iPeso
    '                        iSoma = iSoma + iValor
    '                        iPeso = iPeso + 1
    '                        If iPeso > 10 Then
    '                            iPeso = 2
    '                        End If
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito2 = Right(Str(iResto), 1)
    '                    sBase2 = sBase2 & sDigito2
    '                End If
    '                If sBase2 = sOrigem Then
    '                    ValidaIE = True
    '                End If

    '            Case "TO"
    '                sBase1 = Left(Trim(sOrigem) & "00000000000", 11)
    '                If InStr(1, "01,02,03,99", Mid$(sBase1, 3, 2), vbTextCompare) > 0 Then
    '                    sBase2 = Left(sBase1, 2) & Mid$(sBase1, 5, 6)
    '                    iSoma = 0
    '                    For iPosicao = 1 To 8
    '                        iValor = Val(Mid$(sBase2, iPosicao, 1))
    '                        iValor = iValor * (10 - iPosicao)
    '                        iSoma = iSoma + iValor
    '                    Next
    '                    iResto = iSoma Mod 11
    '                    sDigito1 = Right(IIf(iResto < 2, "0", Str(11 - iResto)), 1)
    '                    sBase2 = Left(sBase1, 10) & sDigito1
    '                    If sBase2 = sOrigem Then
    '                        ValidaIE = True
    '                    End If
    '                End If

    '        End Select

    '        'Retorno da Função
    '        Return ValidaIE

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function

    Public Function LoadValueEnum(ByVal oEnum As Type, ByVal oObject As Object) As String
        Try
            LoadValueEnum = ""
            For Each objFI As System.Reflection.FieldInfo In oEnum.GetFields(System.Reflection.BindingFlags.Public Or System.Reflection.BindingFlags.Static)
                Dim objCustomAtts() As Object = objFI.GetCustomAttributes(True)
                If objFI.Name <> oObject.ToString Then Continue For
                If objCustomAtts.Length > 0 Then
                    Dim xAtt As System.Xml.Serialization.XmlEnumAttribute = DirectCast(objCustomAtts(0), System.Xml.Serialization.XmlEnumAttribute)
                    LoadValueEnum = xAtt.Name
                    Exit Function
                End If

            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCNPJ(ByVal sCNPJ As String) As Boolean

        'Váriaveis Locais
        Dim iNumero(14) As Integer
        Dim dSoma As Double
        Dim iResultado1 As Integer
        Dim iResultado2 As Integer

        Try

            sCNPJ = sCNPJ.Replace("/", "").Replace(".", "").Replace("-", "")

            'Verifica se o CNPJ é inválido
            If Len(sCNPJ) <> 14 OrElse _
               sCNPJ = "00000000000000" OrElse _
               sCNPJ = "11111111111111" OrElse _
               sCNPJ = "22222222222222" OrElse _
               sCNPJ = "33333333333333" OrElse _
               sCNPJ = "44444444444444" OrElse _
               sCNPJ = "55555555555555" OrElse _
               sCNPJ = "66666666666666" OrElse _
               sCNPJ = "77777777777777" OrElse _
               sCNPJ = "88888888888888" OrElse _
               sCNPJ = "99999999999999" Then
                Return False
            End If

            iNumero(1) = CInt(Mid(sCNPJ, 1, 1))
            iNumero(2) = CInt(Mid(sCNPJ, 2, 1))
            iNumero(3) = CInt(Mid(sCNPJ, 3, 1))
            iNumero(4) = CInt(Mid(sCNPJ, 4, 1))
            iNumero(5) = CInt(Mid(sCNPJ, 5, 1))
            iNumero(6) = CInt(Mid(sCNPJ, 6, 1))
            iNumero(7) = CInt(Mid(sCNPJ, 7, 1))
            iNumero(8) = CInt(Mid(sCNPJ, 8, 1))
            iNumero(9) = CInt(Mid(sCNPJ, 9, 1))
            iNumero(10) = CInt(Mid(sCNPJ, 10, 1))
            iNumero(11) = CInt(Mid(sCNPJ, 11, 1))
            iNumero(12) = CInt(Mid(sCNPJ, 12, 1))
            iNumero(13) = CInt(Mid(sCNPJ, 13, 1))
            iNumero(14) = CInt(Mid(sCNPJ, 14, 1))

            dSoma = iNumero(1) * 5 + iNumero(2) * 4 + iNumero(3) * 3 + iNumero(4) * 2 + iNumero(5) * 9 + iNumero(6) * 8 + iNumero(7) * 7 + iNumero(8) * 6 + iNumero(9) * 5 + iNumero(10) * 4 + iNumero(11) * 3 + iNumero(12) * 2
            dSoma = dSoma - (11 * (Int(dSoma / 11)))

            If dSoma = 0 Or dSoma = 1 Then
                iResultado1 = 0
            Else
                iResultado1 = 11 - dSoma
            End If

            If iResultado1 = iNumero(13) Then
                dSoma = iNumero(1) * 6 + iNumero(2) * 5 + iNumero(3) * 4 + iNumero(4) * 3 + iNumero(5) * 2 + iNumero(6) * 9 + iNumero(7) * 8 + iNumero(8) * 7 + iNumero(9) * 6 + iNumero(10) * 5 + iNumero(11) * 4 + iNumero(12) * 3 + iNumero(13) * 2
                dSoma = dSoma - (11 * (Int(dSoma / 11)))
                If dSoma = 0 Or dSoma = 1 Then
                    iResultado2 = 0
                Else
                    iResultado2 = 11 - dSoma
                End If
                If iResultado2 = iNumero(14) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            ValidaCNPJ = False
            Throw ex
        End Try

    End Function

    Public Function ValidaCPF(ByVal sCPF As String) As Boolean

        'Váriaveis Locais
        Dim i As Integer
        Dim j As Integer
        Dim iNumero1 As Integer
        Dim iNumero2 As Integer

        'Verifica erro no CPF
        If sCPF.Trim = "" OrElse _
            Len(sCPF) <> 14 OrElse _
            sCPF = "111.111.111-11" OrElse _
            sCPF = "222.222.222-22" OrElse _
            sCPF = "333.333.333-33" OrElse _
            sCPF = "444.444.444-44" OrElse _
            sCPF = "555.555.555-55" OrElse _
            sCPF = "666.666.666-66" OrElse _
            sCPF = "777.777.777-77" OrElse _
            sCPF = "888.888.888-88" OrElse _
            sCPF = "999.999.999-99" Then
            Return False
        End If

        'remove maskara
        sCPF = Mid(sCPF, 1, 3) & Mid(sCPF, 5, 3) & Mid(sCPF, 9, 3) & Mid(sCPF, 13)

        For j = 0 To 1
            iNumero1 = 0
            For i = 1 To 9 + j
                iNumero1 = iNumero1 + Val(Mid(sCPF, i, 1)) * (11 + j - i)
            Next
            iNumero2 = 11 - (iNumero1 - (Int(iNumero1 / 11) * 11))
            If iNumero2 = 10 Or iNumero2 = 11 Then iNumero2 = 0
            If iNumero2 <> Val(Mid(sCPF, 10 + j, 1)) Then
                Return False
            End If
        Next
        Return True

    End Function

    Public Function DefineEnum(ByVal sValue As String, _
                           ByVal oType As Type) As [Enum]

        Dim oField As FieldInfo

        For Each oField In oType.GetFields()

            Dim oXmlEnumAttribute As XmlEnumAttribute

            For Each oXmlEnumAttribute In oField.GetCustomAttributes(GetType(XmlEnumAttribute), False)
                If (oXmlEnumAttribute.Name = sValue) Then
                    Return oField.GetValue(oXmlEnumAttribute)
                End If
            Next
        Next

        Return Nothing

    End Function

    Public Function DefineUF(ByVal sUF As String) As NFe.RecepcaoLote_V4.TUf

        Try

            Return NFe.RecepcaoLote_V4.TUf.Parse(GetType(NFe.RecepcaoLote_V4.TUf), sUF)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function HTMLtoText(ByVal sTexto As String) As String

        Try

            sTexto.Replace("&#33;", "!")
            sTexto.Replace("&#34;", """")
            sTexto.Replace("&#35;", "#")
            sTexto.Replace("&#36;", "$")
            sTexto.Replace("&#37;", "%")
            sTexto.Replace("&#38;", "&")
            sTexto.Replace("&#39;", "'")
            sTexto.Replace("&#40;", "(")
            sTexto.Replace("&#41;", ")")
            sTexto.Replace("&#42;", "*")
            sTexto.Replace("&#43;", "+")
            sTexto.Replace("&#44;", ",")
            sTexto.Replace("&#45;", "-")
            sTexto.Replace("&#46;", ".")
            sTexto.Replace("&#47;", "/")
            sTexto.Replace("&#48;", "0")
            sTexto.Replace("&#49;", "1")
            sTexto.Replace("&#50;", "2")
            sTexto.Replace("&#51;", "3")
            sTexto.Replace("&#52;", "4")
            sTexto.Replace("&#53;", "5")
            sTexto.Replace("&#54;", "6")
            sTexto.Replace("&#55;", "7")
            sTexto.Replace("&#56;", "8")
            sTexto.Replace("&#57;", "9")
            sTexto.Replace("&#58;", ":")
            sTexto.Replace("&#59;", ";")
            sTexto.Replace("&#60;", "<")
            sTexto.Replace("&#61;", "=")
            sTexto.Replace("&#62;", ">")
            sTexto.Replace("&#63;", "?")
            sTexto.Replace("&#64;", "@")
            sTexto.Replace("&#65;", "A")
            sTexto.Replace("&#66;", "B")
            sTexto.Replace("&#67;", "C")
            sTexto.Replace("&#68;", "D")
            sTexto.Replace("&#69;", "E")
            sTexto.Replace("&#70;", "F")
            sTexto.Replace("&#71;", "G")
            sTexto.Replace("&#72;", "H")
            sTexto.Replace("&#73;", "I")
            sTexto.Replace("&#74;", "J")
            sTexto.Replace("&#75;", "K")
            sTexto.Replace("&#76;", "L")
            sTexto.Replace("&#77;", "M")
            sTexto.Replace("&#78;", "N")
            sTexto.Replace("&#79;", "O")
            sTexto.Replace("&#80;", "P")
            sTexto.Replace("&#81;", "Q")
            sTexto.Replace("&#82;", "R")
            sTexto.Replace("&#83;", "S")
            sTexto.Replace("&#84;", "T")
            sTexto.Replace("&#85;", "U")
            sTexto.Replace("&#86;", "V")
            sTexto.Replace("&#87;", "W")
            sTexto.Replace("&#88;", "X")
            sTexto.Replace("&#89;", "Y")
            sTexto.Replace("&#90;", "Z")
            sTexto.Replace("&#91;", "[")
            sTexto.Replace("&#92;", "\")
            sTexto.Replace("&#93;", "]")
            sTexto.Replace("&#94;", "^")
            sTexto.Replace("&#95;", "_")
            sTexto.Replace("&#96;", "`")
            sTexto.Replace("&#97;", "a")
            sTexto.Replace("&#98;", "b")
            sTexto.Replace("&#99;", "c")
            sTexto.Replace("&#100;", "d")
            sTexto.Replace("&#101;", "e")
            sTexto.Replace("&#102;", "f")
            sTexto.Replace("&#103;", "g")
            sTexto.Replace("&#104;", "h")
            sTexto.Replace("&#105;", "i")
            sTexto.Replace("&#106;", "j")
            sTexto.Replace("&#107;", "k")
            sTexto.Replace("&#108;", "l")
            sTexto.Replace("&#109;", "m")
            sTexto.Replace("&#110;", "n")
            sTexto.Replace("&#111;", "o")
            sTexto.Replace("&#112;", "p")
            sTexto.Replace("&#113;", "q")
            sTexto.Replace("&#114;", "r")
            sTexto.Replace("&#115;", "s")
            sTexto.Replace("&#116;", "t")
            sTexto.Replace("&#117;", "u")
            sTexto.Replace("&#118;", "v")
            sTexto.Replace("&#119;", "w")
            sTexto.Replace("&#120;", "x")
            sTexto.Replace("&#121;", "y")
            sTexto.Replace("&#122;", "z")
            sTexto.Replace("&#123;", "{")
            sTexto.Replace("&#124;", "|")
            sTexto.Replace("&#125;", "}")
            sTexto.Replace("&#126;", "~")
            sTexto.Replace("&#161;", "¡")
            sTexto.Replace("&#162;", "¢")
            sTexto.Replace("&#163;", "£")
            sTexto.Replace("&#164;", "¤")
            sTexto.Replace("&#165;", "¥")
            sTexto.Replace("&#166;", "¦")
            sTexto.Replace("&#167;", "§")
            sTexto.Replace("&#168;", "¨")
            sTexto.Replace("&#169;", "©")
            sTexto.Replace("&#170;", "ª")
            sTexto.Replace("&#171;", "«")
            sTexto.Replace("&#172;", "¬")
            sTexto.Replace("&#173;", "")
            sTexto.Replace("&#174;", "®")
            sTexto.Replace("&#175;", "¯")
            sTexto.Replace("&#176;", "°")
            sTexto.Replace("&#177;", "±")
            sTexto.Replace("&#178;", "²")
            sTexto.Replace("&#179;", "³")
            sTexto.Replace("&#180;", "´")
            sTexto.Replace("&#181;", "µ")
            sTexto.Replace("&#182;", "¶")
            sTexto.Replace("&#183;", "·")
            sTexto.Replace("&#184;", "¸")
            sTexto.Replace("&#185;", "¹")
            sTexto.Replace("&#186;", "º")
            sTexto.Replace("&#187;", "»")
            sTexto.Replace("&#188;", "¼")
            sTexto.Replace("&#189;", "½")
            sTexto.Replace("&#190;", "¾")
            sTexto.Replace("&#191;", "¿")
            sTexto.Replace("&#192;", "À")
            sTexto.Replace("&#193;", "Á")
            sTexto.Replace("&#194;", "Â")
            sTexto.Replace("&#195;", "Ã")
            sTexto.Replace("&#196;", "Ä")
            sTexto.Replace("&#197;", "Å")
            sTexto.Replace("&#198;", "Æ")
            sTexto.Replace("&#199;", "Ç")
            sTexto.Replace("&#200;", "È")
            sTexto.Replace("&#201;", "É")
            sTexto.Replace("&#202;", "Ê")
            sTexto.Replace("&#203;", "Ë")
            sTexto.Replace("&#204;", "Ì")
            sTexto.Replace("&#205;", "Í")
            sTexto.Replace("&#206;", "Î")
            sTexto.Replace("&#207;", "Ï")
            sTexto.Replace("&#208;", "Ð")
            sTexto.Replace("&#209;", "Ñ")
            sTexto.Replace("&#210;", "Ò")
            sTexto.Replace("&#211;", "Ó")
            sTexto.Replace("&#212;", "Ô")
            sTexto.Replace("&#213;", "Õ")
            sTexto.Replace("&#214;", "Ö")
            sTexto.Replace("&#215;", "×")
            sTexto.Replace("&#216;", "Ø")
            sTexto.Replace("&#217;", "Ù")
            sTexto.Replace("&#218;", "Ú")
            sTexto.Replace("&#219;", "Û")
            sTexto.Replace("&#220;", "Ü")
            sTexto.Replace("&#221;", "Ý")
            sTexto.Replace("&#222;", "Þ")
            sTexto.Replace("&#223;", "ß")
            sTexto.Replace("&#224;", "à")
            sTexto.Replace("&#225;", "á")
            sTexto.Replace("&#226;", "â")
            sTexto.Replace("&#227;", "ã")
            sTexto.Replace("&#228;", "ä")
            sTexto.Replace("&#229;", "å")
            sTexto.Replace("&#230;", "æ")
            sTexto.Replace("&#231;", "ç")
            sTexto.Replace("&#232;", "è")
            sTexto.Replace("&#233;", "é")
            sTexto.Replace("&#234;", "ê")
            sTexto.Replace("&#235;", "ë")
            sTexto.Replace("&#236;", "ì")
            sTexto.Replace("&#237;", "í")
            sTexto.Replace("&#238;", "î")
            sTexto.Replace("&#239;", "ï")
            sTexto.Replace("&#240;", "ð")
            sTexto.Replace("&#241;", "ñ")
            sTexto.Replace("&#242;", "ò")
            sTexto.Replace("&#243;", "ó")
            sTexto.Replace("&#244;", "ô")
            sTexto.Replace("&#245;", "õ")
            sTexto.Replace("&#246;", "ö")
            sTexto.Replace("&#247;", "÷")
            sTexto.Replace("&#248;", "ø")
            sTexto.Replace("&#249;", "ù")
            sTexto.Replace("&#250;", "ú")
            sTexto.Replace("&#251;", "û")
            sTexto.Replace("&#252;", "ü")
            sTexto.Replace("&#253;", "ý")
            sTexto.Replace("&#254;", "þ")
            sTexto.Replace("&#255;", "ÿ")
            sTexto.Replace("&#256;", "Ā")

            Return sTexto

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function IsInternetConnAvailable() As Boolean

        'Váriavel Local
        Dim oUrl As New Uri("http://www.uol.com.br/")
        Dim oWebRequest = WebRequest.Create(oUrl)

        oWebRequest.Credentials = CredentialCache.DefaultCredentials

        Dim oWebResponse As WebResponse = Nothing

        Try
            oWebResponse = oWebRequest.GetResponse

            If oWebResponse.ContentLength > 0 Then
                If Not (oWebResponse Is Nothing) Then oWebResponse.Close()
                oWebRequest = Nothing
                Return True
            Else
                If Not (oWebResponse Is Nothing) Then oWebResponse.Close()
                oWebRequest = Nothing
                Return False
            End If

        Catch ex As Exception
            If Not (oWebResponse Is Nothing) Then oWebResponse.Close()
            oWebRequest = Nothing
            Return False
        End Try

    End Function

#Region "::: GRÁFICO :::"

    'Public Sub ChartSerieAdicionar(ByRef oChart As Dundas.Charting.WinControl.Chart, _
    '                               ByRef sKey As String, _
    '                               Optional ByVal oColor As Color = Nothing, _
    '                               Optional ByVal oChartType As Dundas.Charting.WinControl.SeriesChartType = Nothing)

    '    Try

    '        With oChart

    '            .Series.Add(sKey)
    '            If oChartType <> Nothing Then
    '                .Series(sKey).Type = oChartType
    '            Else
    '                .Series(sKey).Type = Dundas.Charting.WinControl.SeriesChartType.Column
    '            End If

    '            .Series(sKey).ShowLabelAsValue = True
    '            .Series(sKey).BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
    '            .Series(sKey).BorderColor = Color.Black
    '            .Series(sKey).ShadowColor = Color.DarkGray
    '            .Series(sKey).ShadowOffset = 3
    '            If oColor <> Nothing Then
    '                .Series(sKey).Color = oColor
    '            End If

    '            oChart.ChartAreas(0).AxisX.LabelStyle.FontAngle = 45

    '        End With

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Public Sub GerarGraficoDundasDuasSeries(ByVal oChart As Dundas.Charting.WinControl.Chart, _
    '                                        ByVal sKeyCampoSerie As String, _
    '                                        ByVal sNomeCampoSerie As String, _
    '                                        ByVal sEixoY As String, _
    '                                        ByVal sNomeEixoY As String, _
    '                                        ByVal sEixoY2 As String, _
    '                                        ByVal sNomeEixoY2 As String, _
    '                                        ByVal oGridDados As Janus.Windows.GridEX.GridEX, _
    '                                        ByVal iTipo As Integer, _
    '                                        ByVal sTipo As String, _
    '                                        ByVal iMeta As Integer, _
    '                                        ByVal iIntervalo As Integer, _
    '                                        Optional ByVal oGroupBox As UIGroupBox = Nothing)



    '    Try

    '        'Variável auxiliar
    '        Dim oStructGrafico(0) As Grafico

    '        'Variável auxiliar
    '        Dim bFlag As Boolean = True

    '        'Limpando a ordenação
    '        oGridDados.RootTable.Groups.Clear()

    '        oGridDados.RootTable.SortKeys.Clear()

    '        If iIntervalo <> -1 Then
    '            oGridDados.RootTable.SortKeys.Add(oGridDados.RootTable.Columns(sKeyCampoSerie), Janus.Windows.GridEX.SortOrder.Ascending)
    '        End If

    '        'Definindo o formato da data de acordo com o intervalo
    '        Dim sFormatoData As String = ""
    '        Select Case iIntervalo
    '            Case TipoIntervalo.Horas : sFormatoData = "dd-hh"
    '            Case TipoIntervalo.Dias : sFormatoData = "yyyy-MMM-dd"
    '            Case TipoIntervalo.Semanas : sFormatoData = "yyyy-"
    '            Case TipoIntervalo.Meses : sFormatoData = "yyyy-MMM"
    '            Case TipoIntervalo.Anos : sFormatoData = "yyyy"
    '        End Select

    '        'Atribuindo o nome ao gráfico
    '        oChart.Titles(0).Text = "GRÁFICO DE " & sNomeCampoSerie & vbNewLine & vbNewLine & "FILTROS: " & vbNewLine
    '        oChart.Titles(0).Text += LoadTituloDundas(oGridDados, oGroupBox)

    '        'Limpando as séries
    '        oChart.Series.Clear()

    '        'Formatando o eixo X de acordo com o valor escolhido
    '        oChart.ChartAreas(0).AxisY.Title = sTipo & " - " & sNomeEixoY & " / " & sNomeEixoY2

    '        'Adicionandoo campo de série
    '        ChartSerieAdicionar(oChart, sNomeEixoY)
    '        ChartSerieAdicionar(oChart, sNomeEixoY2)

    '        If iMeta > 0 Then
    '            oChart.UnusedColor = Color.Green
    '            ChartSerieAdicionar(oChart, "META")
    '            oChart.Series("META").Type = Dundas.Charting.WinControl.SeriesChartType.Line
    '            oChart.Series("META").ShowLabelAsValue = False
    '            oChart.Series("META").MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Square
    '            oChart.Series("META").MarkerSize = 8
    '            oChart.Series("META").BorderWidth = 6
    '            oChart.Series("META").Color = Color.Green
    '        End If

    '        Dim oHashMeta As New Hashtable

    '        'Percorrendo todas linha da grid
    '        For Each oRow In oGridDados.GetRows

    '            'Zerando a variável
    '            bFlag = False

    '            If IsDBNull(oRow.Cells.Item(sEixoY).Value) = False Then

    '                'Verificando a meta
    '                If iMeta > 0 Then

    '                    If iIntervalo = -1 Then
    '                        If Not oHashMeta.Contains(oRow.Cells.Item(sKeyCampoSerie).Text) Then
    '                            oHashMeta.Add(oRow.Cells.Item(sKeyCampoSerie).Text, 0)
    '                            oChart.Series("META").Points.AddXY(oRow.Cells.Item(sKeyCampoSerie).Text, iMeta)
    '                        End If
    '                    Else
    '                        If Not oHashMeta.Contains(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "")) Then
    '                            oHashMeta.Add(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), ""), 0)
    '                            oChart.Series("META").Points.AddXY(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), ""), iMeta)
    '                        End If
    '                    End If

    '                End If

    '                'Verificando se já existe a chava
    '                For iCont As Integer = 1 To oStructGrafico.Count - 1

    '                    'Verificando se já existe a serie com a data
    '                    If (oStructGrafico(iCont).sEixoX = oRow.Cells.Item(sKeyCampoSerie).Text) Then

    '                        'Adicionando o valor
    '                        oStructGrafico(iCont).dQuantidade += 1
    '                        oStructGrafico(iCont).dValor += IIf(IsDBNull(oRow.Cells.Item(sEixoY).Value), 0, oRow.Cells.Item(sEixoY).Value) * IIf(sEixoY = "eficiencia", 100, 1)
    '                        oStructGrafico(iCont).dValor2 += IIf(IsDBNull(oRow.Cells.Item(sEixoY2).Value), 0, oRow.Cells.Item(sEixoY2).Value) * IIf(sEixoY2 = "eficiencia", 100, 1)

    '                        'Saindo do laço
    '                        bFlag = True
    '                        Exit For

    '                    ElseIf iIntervalo <> -1 Then

    '                        If oStructGrafico(iCont).sEixoX = Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "") Then
    '                            'Adicionando o valor
    '                            oStructGrafico(iCont).dQuantidade += 1
    '                            oStructGrafico(iCont).dValor += IIf(IsDBNull(oRow.Cells.Item(sEixoY).Value), 0, oRow.Cells.Item(sEixoY).Value) * IIf(sEixoY = "eficiencia", 100, 1)
    '                            oStructGrafico(iCont).dValor2 += IIf(IsDBNull(oRow.Cells.Item(sEixoY2).Value), 0, oRow.Cells.Item(sEixoY2).Value) * IIf(sEixoY2 = "eficiencia", 100, 1)

    '                            'Saindo do laço
    '                            bFlag = True
    '                            Exit For
    '                        End If

    '                    End If

    '                Next

    '                'Se ele não encontrou a chave, adicioná-la 
    '                If bFlag = False Then

    '                    'Redimensionando o vetor da estrutura
    '                    ReDim Preserve oStructGrafico(oStructGrafico.Count)

    '                    'Atribuindo os valores
    '                    oStructGrafico(oStructGrafico.Count - 1).sSerie = sNomeCampoSerie
    '                    If iIntervalo = -1 Then
    '                        oStructGrafico(oStructGrafico.Count - 1).sEixoX = oRow.Cells.Item(sKeyCampoSerie).Text
    '                    Else
    '                        oStructGrafico(oStructGrafico.Count - 1).sEixoX = Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "")
    '                    End If
    '                    oStructGrafico(oStructGrafico.Count - 1).dQuantidade = 1
    '                    oStructGrafico(oStructGrafico.Count - 1).dValor = IIf(IsDBNull(oRow.Cells.Item(sEixoY).Value), 0, oRow.Cells.Item(sEixoY).Value) * IIf(sEixoY = "eficiencia", 100, 1)
    '                    oStructGrafico(oStructGrafico.Count - 1).dValor2 = IIf(IsDBNull(oRow.Cells.Item(sEixoY2).Value), 0, oRow.Cells.Item(sEixoY2).Value) * IIf(sEixoY2 = "eficiencia", 100, 1)

    '                End If

    '            End If

    '        Next

    '        'Depois de montada a estrutura, o gráfico irá ser montado a partir das informações

    '        'Crinado uma hash table para auxiliar
    '        Dim oHashSerie As New Hashtable

    '        'Percorrendo os dados da estrutura
    '        For iCont As Integer = 1 To oStructGrafico.Count - 1


    '            With oStructGrafico(iCont)

    '                If iTipo = 1 Then 'Soma
    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeEixoY).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dValor, 2)))

    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeEixoY2).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dValor2, 2)))
    '                ElseIf iTipo = 2 Then 'MÉDIA



    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeEixoY).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dValor / .dQuantidade, 2)))

    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeEixoY2).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dValor2 / .dQuantidade, 2)))

    '                ElseIf iTipo = 3 Then 'CONTAR



    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeEixoY).Points.AddXY( _
    '                                    .sEixoX, _
    '                                   .dQuantidade)

    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeEixoY2).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    .dQuantidade)

    '                End If
    '            End With
    '        Next

    '        oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
    '        oChart.ChartAreas(0).AxisX.Interval = 1
    '        oChart.ChartAreas(0).ReCalc()

    '    Catch SqlEx As OleDb.OleDbException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Public Sub GerarGraficoDundasData(ByVal oChart As Dundas.Charting.WinControl.Chart, _
    '                                  ByVal sKeyCampoSerie As String, _
    '                                  ByVal sNomeCampoSerie As String, _
    '                                  ByVal sEixoY As String, _
    '                                  ByVal sNomeEixoY As String, _
    '                                  ByVal oGridDados As Janus.Windows.GridEX.GridEX, _
    '                                  ByVal iTipo As Integer, _
    '                                  ByVal sTipo As String, _
    '                                  ByVal iMeta As Integer, _
    '                                  ByVal iIntervalo As Integer, _
    '                                  ByVal sCampoData As String, _
    '                                  Optional ByVal oGroupBox As UIGroupBox = Nothing, _
    '                                  Optional ByVal txtTotal As NumericEditBox = Nothing)

    '    Try

    '        'Variável auxiliar
    '        Dim oStructGrafico(0) As Grafico
    '        Dim dValorTotal As Double = 0


    '        'Variável auxiliar
    '        Dim bFlag As Boolean = True

    '        'Limpando a ordenação
    '        oGridDados.RootTable.Groups.Clear()

    '        oGridDados.RootTable.SortKeys.Clear()

    '        If iIntervalo <> -1 Then
    '            oGridDados.RootTable.SortKeys.Add(oGridDados.RootTable.Columns(sKeyCampoSerie), Janus.Windows.GridEX.SortOrder.Ascending)
    '        End If

    '        'Definindo o formato da data de acordo com o intervalo
    '        Dim sFormatoData As String = ""
    '        Select Case iIntervalo
    '            Case TipoIntervalo.Horas : sFormatoData = "dd-hh"
    '            Case TipoIntervalo.Dias : sFormatoData = "yyyy-MMM-dd"
    '            Case TipoIntervalo.Semanas : sFormatoData = "yyyy-"
    '            Case TipoIntervalo.Meses : sFormatoData = "yyyy-MMM"
    '            Case TipoIntervalo.Anos : sFormatoData = "yyyy"
    '        End Select

    '        'Atribuindo o nome ao gráfico
    '        oChart.Titles(0).Text = "GRÁFICO DE " & sNomeCampoSerie

    '        'Limpando as séries
    '        oChart.Series.Clear()

    '        'Atribuindo o nome ao gráfico
    '        oChart.Titles(0).Text = "GRÁFICO DE " & sNomeCampoSerie & vbNewLine & vbNewLine & "FILTROS: " & vbNewLine
    '        oChart.Titles(0).Text += LoadTituloDundas(oGridDados, oGroupBox)
    '        oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Table

    '        Dim oHashMeta As New Hashtable

    '        'Percorrendo todas linha da grid
    '        For Each oRow In oGridDados.GetRows

    '            'Zerando a variável
    '            bFlag = False

    '            If IsDBNull(oRow.Cells.Item(sEixoY).Value) = False Then

    '                'Verificando se já existe a chava
    '                For iCont As Integer = 1 To oStructGrafico.Count - 1

    '                    'Verificando se já existe a serie com a data
    '                    If (oStructGrafico(iCont).sSerie = oRow.Cells.Item(sKeyCampoSerie).Text) And _
    '                        (oStructGrafico(iCont).sEixoX = Format(CDate(oRow.Cells.Item(sCampoData).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sCampoData).Value)), "")) Then

    '                        'Adicionando o valor
    '                        oStructGrafico(iCont).dQuantidade += 1
    '                        oStructGrafico(iCont).dValor += oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

    '                        'Saindo do laço
    '                        bFlag = True
    '                        Exit For

    '                    End If

    '                Next

    '                'Se ele não encontrou a chave, adicioná-la 
    '                If bFlag = False Then

    '                    'Redimensionando o vetor da estrutura
    '                    ReDim Preserve oStructGrafico(oStructGrafico.Count)

    '                    'Atribuindo os valores
    '                    oStructGrafico(oStructGrafico.Count - 1).sSerie = oRow.Cells.Item(sKeyCampoSerie).Text
    '                    oStructGrafico(oStructGrafico.Count - 1).sEixoX = Format(CDate(oRow.Cells.Item(sCampoData).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sCampoData).Value)), "")
    '                    oStructGrafico(oStructGrafico.Count - 1).dQuantidade = 1
    '                    oStructGrafico(oStructGrafico.Count - 1).dValor = oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

    '                End If

    '            End If
    '        Next

    '        'Depois de montada a estrutura, o gráfico irá ser montado a partir das informações
    '        For iCont As Integer = 1 To oStructGrafico.Count - 1

    '            Dim bExiste As Boolean = False

    '            For iSerie As Integer = 0 To oChart.Series.Count - 1

    '                If oChart.Series(iSerie).Name = oStructGrafico(iCont).sSerie Then
    '                    bExiste = True
    '                    Exit For
    '                End If

    '            Next

    '            If bExiste = False Then
    '                'Adicionandoo campo de série
    '                ChartSerieAdicionar(oChart, oStructGrafico(iCont).sSerie, Nothing, WinControl.SeriesChartType.StackedColumn)
    '            End If

    '        Next

    '        'Percorrendo os dados da estrutura
    '        For iCont As Integer = 1 To oStructGrafico.Count - 1

    '            With oStructGrafico(iCont)

    '                If iTipo = 1 Then 'Soma
    '                    'Adicionando os pontos
    '                    oChart.Series(oStructGrafico(iCont).sSerie).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dValor, 2)))
    '                ElseIf iTipo = 2 Then 'MÉDIA


    '                    'Adicionando os pontos
    '                    oChart.Series(oStructGrafico(iCont).sSerie).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dValor / .dQuantidade, 2)))
    '                Else 'CONTAR
    '                    'Adicionando os pontos
    '                    oChart.Series(oStructGrafico(iCont).sSerie).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dQuantidade, 2)))
    '                End If
    '                dValorTotal += .dValor
    '            End With

    '        Next

    '        oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
    '        oChart.ChartAreas(0).AxisX.Interval = 1
    '        oChart.ChartAreas(0).ReCalc()

    '        If Not txtTotal Is Nothing Then
    '            txtTotal.Value = dValorTotal
    '        End If

    '    Catch SqlEx As OleDb.OleDbException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Private Function LoadTituloDundas(ByVal oGridDados As GridEX, _
    '                                  ByVal oGroupBox As UIGroupBox) As String

    '    Try

    '        'Váriaveis Locais
    '        Dim sTitulo As String = ""

    '        If Not oGroupBox Is Nothing Then

    '            Dim sName As String
    '            Dim sValor As String
    '            Dim sLabel As String
    '            Dim bFlag2 As Boolean = False

    '            For Each oObject In oGroupBox.Controls

    '                sName = oObject.Name
    '                sValor = ""

    '                If oObject.GetType.Name = "EditBox" Or oObject.GetType.Name = "UIComboBox" Then

    '                    If oObject.Text <> "" Then
    '                        sValor = oObject.Text
    '                        sLabel = oObject.name.ToString.Replace("txt", "").Replace("cbo", "").Replace("Filtro", "")
    '                    End If

    '                End If

    '                If oObject.GetType.Name = "DateTimePicker" Then

    '                    If CType(oObject, DateTimePicker).Checked = True Or CType(oObject, DateTimePicker).ShowCheckBox = False Then
    '                        sValor = oObject.Text
    '                        sLabel = oObject.name.ToString.Replace("dtp", "").Replace("Filtro", "")
    '                    End If

    '                End If

    '                If sValor <> "" Then
    '                    If bFlag2 = True Then
    '                        sTitulo += " | "
    '                    End If
    '                    sTitulo += SepararMaiuscula(sLabel) + ": " + sValor
    '                    bFlag2 = True
    '                End If

    '            Next

    '        End If

    '        If Not oGridDados.RootTable.FilterApplied Is Nothing Then

    '            Dim sFilterGrid As String = oGridDados.RootTable.FilterApplied.ToString

    '            sFilterGrid = Replace(sFilterGrid, "_", " ").Replace("{", "").Replace("}", "").Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "").Replace("And", " | ").Replace("null", "")

    '            sFilterGrid = Replace(sFilterGrid, "BeginsWith ", "Começa Com: ")
    '            sFilterGrid = Replace(sFilterGrid, "Contains ", "Contêm: ")
    '            sFilterGrid = Replace(sFilterGrid, "Is empty ", "É Vazio ")
    '            sFilterGrid = Replace(sFilterGrid, "Isn't empty ", "Não é Vazio ")
    '            sFilterGrid = Replace(sFilterGrid, "EndsWith ", "Termina Com: ")

    '            sTitulo += vbNewLine + sFilterGrid

    '        End If

    '        Return sTitulo

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function

    'Public Sub GerarGraficoDundas(ByVal oChart As Dundas.Charting.WinControl.Chart, _
    '                              ByVal sKeyCampoSerie As String, _
    '                              ByVal sNomeCampoSerie As String, _
    '                              ByVal sEixoY As String, _
    '                              ByVal sNomeEixoY As String, _
    '                              ByVal oGridDados As Janus.Windows.GridEX.GridEX, _
    '                              ByVal iTipo As Integer, _
    '                              ByVal sTipo As String, _
    '                              ByVal iMeta As Integer, _
    '                              ByVal iIntervalo As Integer, _
    '                              Optional ByVal oGroupBox As UIGroupBox = Nothing, _
    '                              Optional ByVal txtTotal As NumericEditBox = Nothing)

    '    Try

    '        'Variável auxiliar
    '        Dim oStructGrafico(0) As Grafico
    '        Dim dValorTotal As Double = 0
    '        Dim oRow As GridEXRow
    '        'Variável auxiliar
    '        Dim bFlag As Boolean = True

    '        'Limpando a ordenação
    '        oGridDados.RootTable.Groups.Clear()

    '        oGridDados.RootTable.SortKeys.Clear()

    '        If iIntervalo <> -1 Then
    '            oGridDados.RootTable.SortKeys.Add(oGridDados.RootTable.Columns(sKeyCampoSerie), Janus.Windows.GridEX.SortOrder.Ascending)
    '        End If

    '        'Definindo o formato da data de acordo com o intervalo
    '        Dim sFormatoData As String = ""
    '        Select Case iIntervalo
    '            Case TipoIntervalo.Horas : sFormatoData = "dd-hh"
    '            Case TipoIntervalo.Dias : sFormatoData = "yyyy-MMM-dd"
    '            Case TipoIntervalo.Semanas : sFormatoData = "yyyy-"
    '            Case TipoIntervalo.Meses : sFormatoData = "yyyy-MMM"
    '            Case TipoIntervalo.Anos : sFormatoData = "yyyy"
    '        End Select

    '        'Atribuindo o nome ao gráfico
    '        oChart.Titles(0).Text = "GRÁFICO DE " & sNomeCampoSerie & vbNewLine & vbNewLine & "FILTROS: " & vbNewLine
    '        oChart.Titles(0).Text += LoadTituloDundas(oGridDados, oGroupBox)
    '        oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Table

    '        'Limpando as séries
    '        oChart.Series.Clear()

    '        'Formatando o eixo X de acordo com o valor escolhido
    '        oChart.ChartAreas(0).AxisX.Title = "GRÁFICO - " & sNomeEixoY & " / " & sNomeCampoSerie
    '        oChart.ChartAreas(0).AxisY.Title = sTipo & " - " & sNomeEixoY

    '        'Adicionandoo campo de série
    '        ChartSerieAdicionar(oChart, sNomeCampoSerie)

    '        If iMeta > 0 Then
    '            oChart.UnusedColor = Color.Green
    '            ChartSerieAdicionar(oChart, "META")
    '            oChart.Series("META").Type = Dundas.Charting.WinControl.SeriesChartType.Line
    '            oChart.Series("META").ShowLabelAsValue = False
    '            oChart.Series("META").MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Square
    '            oChart.Series("META").MarkerSize = 8
    '            oChart.Series("META").BorderWidth = 6
    '            oChart.Series("META").Color = Color.Green

    '        End If

    '        Dim oHashMeta As New Hashtable

    '        'Percorrendo todas linha da grid
    '        For Each oRow In oGridDados.GetRows

    '            'Zerando a variável
    '            bFlag = False

    '            If IsDBNull(oRow.Cells.Item(sEixoY).Value) = False Then

    '                'Verificando a meta
    '                If iMeta > 0 Then

    '                    If iIntervalo = -1 Then
    '                        If Not oHashMeta.Contains(oRow.Cells.Item(sKeyCampoSerie).Text) Then
    '                            oHashMeta.Add(oRow.Cells.Item(sKeyCampoSerie).Text, 0)
    '                            oChart.Series("META").Points.AddXY(oRow.Cells.Item(sKeyCampoSerie).Text, iMeta)
    '                        End If
    '                    Else
    '                        If Not oHashMeta.Contains(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "")) Then
    '                            oHashMeta.Add(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), ""), 0)
    '                            oChart.Series("META").Points.AddXY(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), ""), iMeta)
    '                        End If
    '                    End If

    '                End If

    '                'Verificando se já existe a chava
    '                For iCont As Integer = 1 To oStructGrafico.Count - 1

    '                    If IsDBNull(oRow.Cells.Item(sKeyCampoSerie).Text) Then
    '                        Continue For
    '                    End If
    '                    If (oRow.Cells.Item(sKeyCampoSerie).Text) = "" Then
    '                        Continue For
    '                    End If

    '                    'Verificando se já existe a serie com a data
    '                    If (oStructGrafico(iCont).sEixoX = oRow.Cells.Item(sKeyCampoSerie).Text) Then

    '                        'Adicionando o valor
    '                        oStructGrafico(iCont).dQuantidade += 1
    '                        oStructGrafico(iCont).dValor += oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

    '                        'Saindo do laço
    '                        bFlag = True
    '                        Exit For

    '                    ElseIf iIntervalo <> -1 Then

    '                        If oStructGrafico(iCont).sEixoX = Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "") Then
    '                            'Adicionando o valor
    '                            oStructGrafico(iCont).dQuantidade += 1
    '                            oStructGrafico(iCont).dValor += oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

    '                            'Saindo do laço
    '                            bFlag = True

    '                            Exit For

    '                        End If

    '                    End If

    '                Next

    '                'Se ele não encontrou a chave, adicioná-la 
    '                If bFlag = False Then

    '                    If IsDBNull(oRow.Cells.Item(sKeyCampoSerie).Text) Then
    '                        Continue For
    '                    End If
    '                    If (oRow.Cells.Item(sKeyCampoSerie).Text) = "" Then
    '                        Continue For
    '                    End If

    '                    'Redimensionando o vetor da estrutura
    '                    ReDim Preserve oStructGrafico(oStructGrafico.Count)

    '                    'Atribuindo os valores
    '                    oStructGrafico(oStructGrafico.Count - 1).sSerie = sNomeCampoSerie
    '                    If iIntervalo = -1 Then
    '                        oStructGrafico(oStructGrafico.Count - 1).sEixoX = oRow.Cells.Item(sKeyCampoSerie).Text
    '                    Else
    '                        oStructGrafico(oStructGrafico.Count - 1).sEixoX = Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "")
    '                    End If
    '                    oStructGrafico(oStructGrafico.Count - 1).dQuantidade = 1
    '                    oStructGrafico(oStructGrafico.Count - 1).dValor = oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

    '                End If

    '            End If
    '        Next

    '        'Crinado uma hash table para auxiliar
    '        Dim oHashSerie As New Hashtable

    '        'Percorrendo os dados da estrutura
    '        For iCont As Integer = 1 To oStructGrafico.Count - 1

    '            With oStructGrafico(iCont)

    '                If iTipo = 1 Then 'Soma
    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeCampoSerie).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dValor, 2)))
    '                ElseIf iTipo = 2 Then 'MÉDIA


    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeCampoSerie).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dValor / .dQuantidade, 2)))
    '                Else 'CONTAR
    '                    'Adicionando os pontos
    '                    oChart.Series(sNomeCampoSerie).Points.AddXY( _
    '                                    .sEixoX, _
    '                                    CDbl(FormatNumber(.dQuantidade, 2)))
    '                End If
    '                dValorTotal += .dValor
    '            End With
    '        Next

    '        oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
    '        oChart.ChartAreas(0).AxisX.Interval = 1
    '        oChart.ChartAreas(0).ReCalc()

    '        If Not txtTotal Is Nothing Then
    '            txtTotal.Value = dValorTotal
    '        End If

    '    Catch SqlEx As OleDb.OleDbException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Private Function SepararMaiuscula(ByVal sValor As String) As String

    '    Try

    '        For i As Integer = 65 To 90
    '            sValor = Replace(sValor, Chr(i), " " + Chr(i))
    '        Next

    '        Return sValor

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function

#End Region

#End Region

#Region "::: BANCO DE DADOS :::"

#Region "::: ARQUIVO :::"

    Public Sub ListaArquivo(ByVal sTabela As String, _
                            ByVal lCodigo As Long, _
                            Optional ByVal iCodigo2 As Integer = -1)


        Try

            'Váriavel - Formulário
            Dim oForm As New frmArqListagem

            'Seta Parâmetros
            oForm.Table = sTabela
            oForm.Codigo = lCodigo
            oForm.Codigo2 = iCodigo2

            'Seta Tamanho / Posição do Controle
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Abre Formulário
            oForm.ShowDialog()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertArquivo(ByVal oGrid As GridEX, _
                             ByVal sTabela As String, _
                             ByVal lCodigo As Long, _
                             Optional ByVal sSigla As String = "", _
                             Optional ByVal iCodigo2 As Integer = -1, _
                             Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0
        Dim sArquivoInteracti As String

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Tabela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tabela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = sTabela : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigo : i += 1

                'Seta Parametros - Código2
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo2"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

                'Seta Parametros - Descrição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("descricao").Value : i += 1

                'Seta Parametros - Código Tipo do Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_tipo_arquivo").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "arquivo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 500
                oSqlParameter(i).Value = oRow.Cells("arquivo").Value : i += 1

                'Seta Destino                            
                sArquivoInteracti = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)
                sArquivoInteracti &= sTabela & "_" & Format(lCodigo, "000000000") & "_" & oRow.Cells("descricao").Value & oRow.Cells("arquivo_interacti").Value.ToString.Substring(oRow.Cells("arquivo_interacti").Value.ToString.IndexOf("."))

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "arquivo_interacti"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 500
                oSqlParameter(i).Value = sArquivoInteracti : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_usuario").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_arquivo", oSqlParameter)

                'Copia Arquivo para a Pasta Desejada                
                If sArquivoInteracti <> "" And sArquivoInteracti.ToUpper <> oRow.Cells("arquivo_interacti").Value Then
                    If System.IO.File.Exists(sArquivoInteracti) Then
                        System.IO.File.Delete(sArquivoInteracti)
                    End If
                    System.IO.File.Copy(oRow.Cells("arquivo_interacti").Value, sArquivoInteracti)
                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertArquivo(ByVal sTabela As String, _
                             ByVal sDescricao As String, _
                             ByVal iCodigoTipoArquivo As Integer, _
                             ByVal sArquivoInteracti As String, _
                             ByVal sArquivo As String, _
                             ByVal lCodigo As Long, _
                             Optional ByVal sSigla As String = "", _
                             Optional ByVal iCodigo2 As Integer = -1, _
                             Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo3 = -1, DBNull.Value, iCodigo3) : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoArquivo : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Destino                            
            If sArquivoInteracti <> "" Then
                sArquivoInteracti &= sTabela & "_" & Format(lCodigo, "000000000") & "_" & sDescricao & sArquivo.Substring(sArquivo.LastIndexOf("."))
            End If

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_interacti"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoInteracti : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_arquivo", oSqlParameter)

            'Copia Arquivo para a Pasta Desejada                
            If sArquivoInteracti <> "" And sArquivoInteracti.ToUpper <> sArquivo.ToUpper Then
                If System.IO.File.Exists(sArquivoInteracti) Then
                    System.IO.File.Delete(sArquivoInteracti)
                End If
                System.IO.File.Copy(sArquivo, sArquivoInteracti)
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateArquivo(ByVal sTabela As String, _
                             ByVal sDescricao As String, _
                             ByVal iCodigoTipoArquivo As Integer, _
                             ByVal sArquivoInteracti As String, _
                             ByVal sArquivo As String, _
                             ByVal sArquivoAntigo As String, _
                             ByVal lCodigo As Long, _
                             Optional ByVal sSigla As String = "", _
                             Optional ByVal iCodigo2 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoArquivo : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Destino                
            If sArquivoInteracti <> "" Then
                sArquivoInteracti &= sTabela & "_" & Format(lCodigo, "000000000") & "_" & sDescricao & sArquivo.Substring(sArquivo.LastIndexOf("."))
            End If

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_interacti"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoInteracti : i += 1

            'Seta Parametros - Arquivo Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoAntigo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_arquivo", oSqlParameter)

            'Copia Arquivo para a Pasta Desejada                
            If sArquivoInteracti <> "" And sArquivoInteracti.ToUpper <> sArquivo.ToUpper Then
                If System.IO.File.Exists(sArquivoInteracti) = True And sArquivoInteracti <> sArquivoAntigo Then
                    System.IO.File.Delete(sArquivoInteracti)
                End If
                System.IO.File.Copy(sArquivo, sArquivoInteracti)
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteArquivo(ByVal sTabela As String, _
                             ByVal lCodigo As Long, _
                             Optional ByVal iCodigo2 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo2 : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_arquivo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteArquivo(ByVal sTabela As String, _
                             ByVal lCodigo As Long, _
                             ByVal sArquivo As String, _
                             Optional ByVal iCodigo2 As Integer = -1, _
                             Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo2 : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo3 = -1, DBNull.Value, iCodigo3) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_arquivo_registro", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridArquivo(ByVal oGrid As GridEX, _
                               ByVal sTabela As String, _
                               ByVal lCodigo As Long, _
                               Optional ByVal iCodigo2 As Integer = -1, _
                               Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo2 : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo3 : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_arquivo", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName: oGrid.MoveFirst

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub VisualizarDocumento(ByVal sArquivo As String)

        Try

            'Verifica se foi Informado o Arquivo
            If sArquivo = "" Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

            Else

                'Verifica se o Arquivo Existe
                If File.Exists(sArquivo) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(sArquivo)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub VisualizarDocumento(ByVal sArquivo As String, _
                                   ByVal sArquivoNovo As String)

        Try

            'Verifica se foi Informado o Arquivo
            If sArquivo = "" Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

            Else

                If Directory.Exists(ApplicationPath() & "File") = False Then
                    Directory.CreateDirectory(ApplicationPath() & "File")
                End If

                If File.Exists(ApplicationPath() & "File\" & sArquivoNovo) = True Then
                    File.Delete(ApplicationPath() & "File\" & sArquivoNovo)
                End If

                File.Copy(sArquivo, ApplicationPath() & "File\" & sArquivoNovo)

                'Abre o Arquivo
                Dim oProcess As New Process
                oProcess.Start(ApplicationPath() & "File\" & sArquivoNovo)
                
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: JUSTIFICATIVA :::"

    Public Sub InsertJustificativa(ByVal sJustificativa As String, _
                                   ByVal sMotivo As String, _
                                   ByVal sTabela As String, _
                                   ByVal sTipo As String, _
                                   ByVal lCodigo As Long, _
                                   Optional ByVal iCodigo2 As Integer = -1, _
                                   Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo3 = -1, DBNull.Value, iCodigo3) : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sJustificativa : i += 1

            'Seta Parametros - Motivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "motivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sMotivo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_justificativa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: LIBERAÇÃO :::"

    Public Sub InsertLiberacao(ByVal iCodigoUsuario As Integer, _
                               ByVal sDescricao As String, _
                               ByVal sTabela As String, _
                               ByVal lCodigo As Long, _
                               Optional ByVal iCodigo2 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_administracao_liberacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CONTROLES :::"

    Public Sub AdicionarControles(ByVal sFormulario As String, _
                                  ByVal sControle As String, _
                                  ByVal iCodigoControle As Integer, _
                                  ByVal iPosicaoX As Integer, _
                                  ByVal iPosicaoY As Integer, _
                                  ByVal iLargura As Integer, _
                                  Optional ByVal lCodigo As Long = -1)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFormulario : i += 1

            'Seta Parametros - Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sControle : i += 1

            'Seta Parametros - Código Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoControle : i += 1

            'Seta Parametros - Posição X
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "posicao_x"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPosicaoX : i += 1

            'Seta Parametros - Posição Y
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "posicao_y"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPosicaoY : i += 1

            'Seta Parametros - Largura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iLargura : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigo = -1, DBNull.Value, lCodigo) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_controle", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CarregaControles(ByVal oControle As Control, _
                                ByVal sTabela As String, _
                                ByVal lCodigo As Long, _
                                ByVal lCodigoRegistro As Long)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = oControle.Name : i += 1

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Registro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRegistro : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_controle", oSqlParameter)

            'Seta Váriavel
            i = 0

            While oSqlDataReader.Read

                Dim oControl As Control = oControle.Controls.Find(oSqlDataReader.Item("controle"), True)(0)

                'Label
                Dim oLabel As New Label
                oLabel.Name = "lbl" & oSqlDataReader.Item("codigo")
                oLabel.Text = Strings.StrConv(oSqlDataReader.Item("label").ToString, VbStrConv.ProperCase) & ":"
                oLabel.Location = New System.Drawing.Point(oSqlDataReader.Item("posicao_x") - 2, oSqlDataReader.Item("posicao_y") - 17)
                oLabel.AutoSize = True
                oControl.Controls.Add(oLabel)

                Select Case CType(oSqlDataReader.Item("codigo_tipo_campo"), TipoCampoControle)

                    Case TipoCampoControle.Texto
                        Dim oMaskedEditBox As New MaskedEditBox
                        oMaskedEditBox.MaxLength = oSqlDataReader.Item("numero_caracteres")
                        oMaskedEditBox.Location = New System.Drawing.Point(oSqlDataReader.Item("posicao_x"), oSqlDataReader.Item("posicao_y"))
                        oMaskedEditBox.Size = New System.Drawing.Size(oSqlDataReader.Item("largura"), 20)
                        oMaskedEditBox.Name = oSqlDataReader.Item("codigo")
                        oMaskedEditBox.Tag = oSqlDataReader.Item("codigo")
                        oMaskedEditBox.Text = IIf(IsDBNull(oSqlDataReader.Item("valor")), "", oSqlDataReader.Item("valor"))
                        oControl.Controls.Add(oMaskedEditBox)
                        MakeDraggable(oMaskedEditBox)
                        oMaskedEditBox.TabIndex = i

                    Case TipoCampoControle.Numerico
                        Dim oNumericEditBox As New NumericEditBox
                        oNumericEditBox.MaxLength = oSqlDataReader.Item("numero_caracteres")
                        oNumericEditBox.DecimalDigits = oSqlDataReader.Item("numero_casas_decimais")
                        oNumericEditBox.Location = New System.Drawing.Point(oSqlDataReader.Item("posicao_x"), oSqlDataReader.Item("posicao_y"))
                        oNumericEditBox.Size = New System.Drawing.Size(oSqlDataReader.Item("largura"), 20)
                        oNumericEditBox.Name = oSqlDataReader.Item("codigo")
                        oNumericEditBox.Tag = oSqlDataReader.Item("codigo")
                        oNumericEditBox.Value = IIf(IsDBNull(oSqlDataReader.Item("valor")), 0, oSqlDataReader.Item("valor"))
                        oControl.Controls.Add(oNumericEditBox)
                        MakeDraggable(oNumericEditBox)
                        oNumericEditBox.TabIndex = i

                    Case TipoCampoControle.Cadastro
                        Dim oUIComboBox As New UIComboBox
                        oUIComboBox.Location = New System.Drawing.Point(oSqlDataReader.Item("posicao_x"), oSqlDataReader.Item("posicao_y"))
                        oUIComboBox.Size = New System.Drawing.Size(oSqlDataReader.Item("largura"), 20)
                        oUIComboBox.Name = oSqlDataReader.Item("codigo")
                        oUIComboBox.Tag = oSqlDataReader.Item("codigo")
                        oControl.Controls.Add(oUIComboBox)
                        Call LoadCombo(oUIComboBox, "sp_select_combo_cadastro_basico_dados_controle " & oSqlDataReader.Item("codigo") & ", " & goUsuario.iEmpresa)
                        MakeDraggable(oUIComboBox)
                        AddHandler oUIComboBox.SelectedIndexChanged, Sub(sender As Object, e As EventArgs) cboCombo_SelectedIndexChanged(oUIComboBox, System.EventArgs.Empty)
                        oUIComboBox.TabIndex = i
                        If IsDBNull(oSqlDataReader.Item("valor")) = False Then oUIComboBox.SelectedValue = oSqlDataReader.Item("valor")

                    Case TipoCampoControle.CadastroCorrelacionado
                        Dim oUIComboBox As New UIComboBox
                        oUIComboBox.Location = New System.Drawing.Point(oSqlDataReader.Item("posicao_x"), oSqlDataReader.Item("posicao_y"))
                        oUIComboBox.Size = New System.Drawing.Size(oSqlDataReader.Item("largura"), 20)
                        oUIComboBox.Name = oSqlDataReader.Item("codigo")
                        oUIComboBox.Tag = oSqlDataReader.Item("codigo")
                        oControl.Controls.Add(oUIComboBox)
                        MakeDraggable(oUIComboBox)
                        AddHandler oUIComboBox.SelectedIndexChanged, Sub(sender As Object, e As EventArgs) cboCombo_SelectedIndexChanged(oUIComboBox, System.EventArgs.Empty)
                        oUIComboBox.TabIndex = i
                        If IsDBNull(oSqlDataReader.Item("valor")) = False Then oUIComboBox.SelectedValue = oSqlDataReader.Item("valor")

                    Case TipoCampoControle.SimNao
                        Dim oUIComboBox As New UIComboBox
                        oUIComboBox.Location = New System.Drawing.Point(oSqlDataReader.Item("posicao_x"), oSqlDataReader.Item("posicao_y"))
                        oUIComboBox.Size = New System.Drawing.Size(oSqlDataReader.Item("largura"), 20)
                        oUIComboBox.Name = oSqlDataReader.Item("codigo")
                        oUIComboBox.Tag = oSqlDataReader.Item("codigo")
                        oControl.Controls.Add(oUIComboBox)
                        MakeDraggable(oUIComboBox)
                        Call LoadComboSimNao(oUIComboBox)
                        oUIComboBox.TabIndex = i
                        If IsDBNull(oSqlDataReader.Item("valor")) = False Then oUIComboBox.SelectedValue = oSqlDataReader.Item("valor")

                End Select

                i += 1

            End While

            'Fecha SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletaDadosControle(ByVal sTabela As String, _
                                   ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_tabela_controle", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosControle(ByVal sTabela As String, _
                                 ByVal lCodigo As Long, _
                                 ByVal oMaskedEditBox As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim sValor As String
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = oMaskedEditBox.Name

            'Executa Query
            sValor = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_tabela_controle", oSqlParameter)

            oMaskedEditBox.Text = sValor

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosControle(ByVal sTabela As String, _
                                 ByVal lCodigo As Long, _
                                 ByVal oUiComboBox As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim sValor As String
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = oUiComboBox.Name

            'Executa Query
            sValor = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_tabela_controle", oSqlParameter)

            oUiComboBox.SelectedValue = sValor

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosControle(ByVal sTabela As String, _
                                 ByVal lCodigo As Long, _
                                 ByVal oNumericEditBox As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim sValor As String
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = oNumericEditBox.Name

            'Executa Query
            sValor = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_tabela_controle", oSqlParameter)

            oNumericEditBox.Value = sValor

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvaDadosControle(ByVal sTabela As String, _
                                  ByVal lCodigo As Long, _
                                  ByVal iCodigoControle As Integer, _
                                  ByVal sValor As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoControle : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.NVarChar
            oSqlParameter(i).Value = sValor

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_tabela_controle", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdatePosicaoControle(ByVal sFormulario As String, _
                                     ByVal sControle As String, _
                                     ByVal iCodigoControle As Integer, _
                                     ByVal iPosicaoX As Integer, _
                                     ByVal iPosicaoY As Integer, _
                                     ByVal iLargura As Integer)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFormulario : i += 1

            'Seta Parametros - Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sControle : i += 1

            'Seta Parametros - Código Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoControle : i += 1

            'Seta Parametros - Posição X
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "posicao_x"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPosicaoX : i += 1

            'Seta Parametros - Posição Y
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "posicao_y"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPosicaoY : i += 1

            'Seta Parametros - Largura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iLargura : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_controle", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub cboCombo_SelectedIndexChanged(oControl As UIComboBox, e As EventArgs)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        If oControl.SelectedIndex > -1 Then

            For Each oControle As Control In oControl.Parent.Controls

                If TypeOf (oControle) Is UIComboBox AndAlso oControle.Name <> oControl.Name Then

                    If CType(LoadDescricao("sp_validate_controle_correlacionado " & oControle.Name & ", " & oControl.Name & ", " & goUsuario.iEmpresa), Integer) > 0 AndAlso oControl.SelectedIndex > -1 Then

                        oControle.Text = ""
                        Call LoadCombo(CType(oControle, UIComboBox), "sp_select_combo_cadastro_basico_dados_controle_correlacionado " & oControle.Name & ", " & oControl.Name & ", " & oControl.SelectedValue & ", " & goUsuario.iEmpresa)

                    End If

                End If

            Next

        Else

            For Each oControle As Control In oControl.Parent.Controls

                If TypeOf (oControle) Is UIComboBox Then

                    If CType(LoadDescricao("sp_validate_controle_correlacionado " & oControle.Name & ", " & oControl.Name & ", " & goUsuario.iEmpresa), Integer) > 0 Then

                        CType(oControle, UIComboBox).DataSource = Nothing
                        CType(oControle, UIComboBox).Text = ""

                    End If

                End If

            Next

        End If


    End Sub

    Public Sub MakeDraggable(ByVal Control As Control)

        AddHandler Control.MouseDown, Sub(sender As Object, e As MouseEventArgs) StartDrag(Control)
        AddHandler Control.MouseMove, Sub(sender As Object, e As MouseEventArgs) Drag(Control)
        AddHandler Control.MouseUp, Sub(sender As Object, e As MouseEventArgs) StopDrag(Control)

    End Sub

    Public Sub MakeDraggable2(ByVal Control As Control)

        AddHandler Control.MouseDown, Sub(sender As Object, e As MouseEventArgs) StartDrag(Control)
        AddHandler Control.MouseMove, Sub(sender As Object, e As MouseEventArgs) Drag2(Control)
        AddHandler Control.MouseUp, Sub(sender As Object, e As MouseEventArgs) StopDrag2(Control)

    End Sub

    Public Sub StartDrag(ByVal oControl As Control)

        oControl.Tag = New clsDragInfo(Form.MousePosition, oControl.Location)

    End Sub

    Public Sub Drag(ByVal oControl As Control)

        If oControl.Parent.Tag = "MOVE" AndAlso oControl.Tag IsNot Nothing AndAlso TypeOf oControl.Tag Is clsDragInfo Then

            Dim oDragInfo As clsDragInfo = CType(oControl.Tag, clsDragInfo)
            Dim oPoint As Point = oDragInfo.NewLocation(Form.MousePosition)
            Dim oPointLabel As Point = oDragInfo.NewLocation(Form.MousePosition)
            oPointLabel.Y -= 17 : oPointLabel.X -= 2
            Dim oLabel As Label = oControl.Parent.Controls.Find("lbl" & oControl.Name, True)(0)

            If oControl.Parent.ClientRectangle.Contains(New System.Drawing.Rectangle(oPoint, oControl.Size)) Then

                oControl.Location = oPoint
                oLabel.Location = oPointLabel

                'Seta Posição
                Dim oLabelPosicao As Label = oControl.Parent.Controls.Find("lblPosicao", True)(0)
                oLabelPosicao.Text = "Posição: " & oPoint.X.ToString & " x " & oPoint.Y.ToString

            End If

        End If

    End Sub

    Public Sub Drag2(ByVal oControl As Control)

        If oControl.Parent.Tag = "MOVE" AndAlso oControl.Tag IsNot Nothing AndAlso TypeOf oControl.Tag Is clsDragInfo Then

            Dim oDragInfo As clsDragInfo = CType(oControl.Tag, clsDragInfo)
            Dim oPoint As Point = oDragInfo.NewLocation(Form.MousePosition)

            If oControl.Parent.ClientRectangle.Contains(New System.Drawing.Rectangle(oPoint, oControl.Size)) Then

                oControl.Location = oPoint
                Application.DoEvents()

            End If

        End If

    End Sub

    Public Sub StopDrag(ByVal oControl As Control)

        'Seta Posição
        Dim oLabelPosicao As Label = oControl.Parent.Controls.Find("lblPosicao", True)(0)
        oLabelPosicao.Text = ""

        'Limpa Controles
        oControl.Tag = Nothing

    End Sub

    Public Sub StopDrag2(ByVal oControl As Control)

        'Limpa Controles
        oControl.Tag = Nothing

    End Sub

#End Region

    Public Sub LoadDadosGrupoItem(ByVal iCodigoGrupoItem As Integer, _
                                  ByRef iCodigoMaterial As Integer, _
                                  ByRef iCodigoTipoPerfil As Integer, _
                                  ByRef iCodigoFamilia As Integer, _
                                  ByRef iCodigoTipoItemSPED As Integer)
        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grupo_item_dados_estrutura", oSqlParameter)

            If oSqlDataReader.Read Then


                If Not IsDBNull(oSqlDataReader.Item("codigo_material")) Then

                    iCodigoMaterial = oSqlDataReader.Item("codigo_material")
                Else
                    iCodigoMaterial = -1

                End If

                If Not IsDBNull(oSqlDataReader.Item("codigo_tipo_perfil")) Then

                    iCodigoTipoPerfil = oSqlDataReader.Item("codigo_tipo_perfil")
                Else
                    iCodigoTipoPerfil = -1

                End If

                If Not IsDBNull(oSqlDataReader.Item("codigo_familia")) Then

                    iCodigoFamilia = oSqlDataReader.Item("codigo_familia")
                Else
                    iCodigoFamilia = -1
                End If

                If Not IsDBNull(oSqlDataReader.Item("codigo_tipo_item_sped")) Then
                    iCodigoTipoItemSPED = oSqlDataReader.Item("codigo_tipo_item_sped")
                Else
                    iCodigoTipoItemSPED = -1
                End If
            End If


            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadFusoHorario() As String

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(0) As SqlParameter
        Dim sResult As String
        Try



            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1



            'Executa Query
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_fuso_horario", oSqlParameter)

            Return sResult
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ExecuteQueryReturn(ByVal sQuery As String) As Object

        Try

            'Obtem o DataSet
            Return SQLHelper.ExecuteScalar(goDatabase.sConnection, CommandType.Text, sQuery)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function TesteConection(ByVal sConnectionString As String)

        Dim oSqlConnection As New SqlConnection

        Try

            'Seta Conexão
            If System.Net.Dns.GetHostName.ToUpper <> "NOTE-THARCIUS" Then
                oSqlConnection.ConnectionString = sConnectionString.Replace("Connect Timeout = 999;", "Connect Timeout = 99")
            Else
                oSqlConnection.ConnectionString = sConnectionString.Replace("Connect Timeout = 999;", "Connect Timeout = 9")
            End If
            'Abre Conexão                                                   
            oSqlConnection.Open()

            Return True

        Catch ex As Exception
            Return False
        Finally
            oSqlConnection.Close()
        End Try

    End Function

    Public Sub UpdateConfiguraGrid(ByVal oGrid As GridEX, _
                                   ByVal sNomeFormulario As String)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim j As Integer
        Dim oSqlParameter(6) As SqlParameter

        Try

            For Each oColumn As GridEXColumn In oGrid.RootTable.Columns

                If oColumn.Tag = "S" Or (oColumn.Tag = "A" And VerificaDireito(sNomeFormulario, gcAdministrator) = True) Then

                    i = 0

                    'Seta Parametros - Código Usuário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_usuario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                    'Seta Parametros - Nome Formulário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "nome_formulario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 50
                    oSqlParameter(i).Value = sNomeFormulario : i += 1

                    'Seta Parametros - Nome Grid
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "nome_grid"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 50
                    oSqlParameter(i).Value = oGrid.Name : i += 1

                    'Seta Parametros - Campo
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "campo"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 50
                    oSqlParameter(i).Value = oColumn.Key : i += 1

                    'Seta Parametros - Width
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "width"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = oColumn.Width : i += 1

                    'Seta Parametros - Position
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "position"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = oColumn.Position

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_grid_position", oSqlParameter)

                End If

            Next

            If oGrid.RootTable.ChildTables.Count > 0 And oGrid.Name <> "grdOrcamentoComposicao" Then

                For Each oColumn As GridEXColumn In oGrid.RootTable.ChildTables(0).Columns

                    If oColumn.Tag = "S" Or (oColumn.Tag = "A" And VerificaDireito(sNomeFormulario, gcAdministrator) = True) Then

                        i = 0

                        'Seta Parametros - Código Usuário
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_usuario"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Int
                        oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                        'Seta Parametros - Código Empresa
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_empresa"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                        'Seta Parametros - Nome Formulário
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "nome_formulario"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 50
                        oSqlParameter(i).Value = sNomeFormulario : i += 1

                        'Seta Parametros - Nome Grid
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "nome_grid"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 50
                        oSqlParameter(i).Value = oGrid.Name : i += 1

                        'Seta Parametros - Campo
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "campo"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 50
                        oSqlParameter(i).Value = oColumn.Key : i += 1

                        'Seta Parametros - Width
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "width"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Int
                        oSqlParameter(i).Value = oColumn.Width : i += 1

                        'Seta Parametros - Position
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "position"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Int
                        oSqlParameter(i).Value = oColumn.Position

                        'Executa Query
                        ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_grid_position", oSqlParameter)

                    End If

                Next

            End If

            

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateConfiguraGrid(ByVal sGrid As String, _
                                   ByVal sNomeFormulario As String, _
                                   ByVal sColumn As String, _
                                   ByVal iWidth As Integer)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nome Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNomeFormulario : i += 1

            'Seta Parametros - Nome Grid
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_grid"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sGrid : i += 1

            'Seta Parametros - Campo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sColumn : i += 1

            'Seta Parametros - Width
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "width"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iWidth

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_grid_width", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateConfiguraGridCor(ByVal sGrid As String, _
                                      ByVal sNomeFormulario As String, _
                                      ByVal sColumn As String, _
                                      ByVal iR As Integer, _
                                      ByVal iG As Integer, _
                                      ByVal iB As Integer)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(7) As SqlParameter

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nome Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNomeFormulario : i += 1

            'Seta Parametros - Nome Grid
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_grid"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sGrid : i += 1

            'Seta Parametros - Campo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sColumn : i += 1

            'Seta Parametros - R
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "r"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iR = -1, DBNull.Value, iR) : i += 1

            'Seta Parametros - G
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "g"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iG = -1, DBNull.Value, iG) : i += 1

            'Seta Parametros - B
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "b"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iB = -1, DBNull.Value, iB)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_grid_cor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateConfiguraGridGrupo(ByVal sGrid As String, _
                                        ByVal sNomeFormulario As String, _
                                        ByVal sColumn As String, _
                                        ByVal bAction As Boolean, _
                                        ByVal iOrdemGrupo As Integer)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(6) As SqlParameter

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nome Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNomeFormulario : i += 1

            'Seta Parametros - Nome Grid
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_grid"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sGrid : i += 1

            'Seta Parametros - Campo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sColumn : i += 1

            'Seta Parametros - Ação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "acao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAction : i += 1

            'Seta Parametros - Ordem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ordem_grupo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iOrdemGrupo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_grid_group", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ConfiguraGrid(ByVal oGrid As GridEX, _
                             ByVal sNomeFormulario As String, _
                             Optional ByVal bResaltarSelecao As Boolean = True)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oColumn As GridEXColumn
        Dim i As Integer = 0
        Dim oSqlParameter(5) As SqlParameter

        Try

            With oGrid




                .GroupTotals = GroupTotals.Always

                'Seta Forma de Agrupar
                .Tag = ""
                .GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003
                .GroupRowFormatStyle.ForeColor = System.Drawing.Color.SteelBlue
                .GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
                .RootTable.CellToolTip = CellToolTip.TruncatedText
                .RootTable.TableHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
                .RootTable.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
                .RootTable.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .FocusCellFormatStyle.BackColor = System.Drawing.Color.Empty

                If .Name.Contains("grdOrcamento") Then
                    .FocusCellFormatStyle.BackColor = Drawing.Color.LightGreen
                    .EnterKeyBehavior = EnterKeyBehavior.NextRow
                End If

                For Each oColumn In oGrid.RootTable.Columns

                    If oColumn.Key = "x" And bResaltarSelecao = True Then
                        Dim oFormatCondition As New GridEXFormatCondition
                        oFormatCondition = New GridEXFormatCondition(oColumn, ConditionOperator.Equal, True)
                        oFormatCondition.FormatStyle.BackColor = System.Drawing.Color.FromArgb(192, 255, 192)
                        oGrid.RootTable.FormatConditions.Add(oFormatCondition)
                        oFormatCondition = New GridEXFormatCondition(oColumn, ConditionOperator.Equal, False)
                        oFormatCondition.FormatStyle.BackColor = System.Drawing.Color.Empty
                        oGrid.RootTable.FormatConditions.Add(oFormatCondition)
                        oFormatCondition = New GridEXFormatCondition(oColumn, ConditionOperator.IsNull, "")
                        oFormatCondition.FormatStyle.BackColor = System.Drawing.Color.Empty
                        oGrid.RootTable.FormatConditions.Add(oFormatCondition)
                    End If

                    'Seta Propriedade do Controle
                    oColumn.HideWhenGrouped = InheritableBoolean.True

                    'CharCasing
                    If oColumn.Key.Contains("email") = False Then oColumn.CharacterCasing = CharacterCasing.Upper Else oColumn.CharacterCasing = CharacterCasing.Lower

                    If oColumn.ColumnType = ColumnType.Image Or oColumn.ColumnType = ColumnType.ImageAndText Then

                        Select Case oColumn.Key
                            Case "remover_preco_venda" : oColumn.CellToolTipText = "Duplo clique para remover Preço de Venda." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "pdf" : oColumn.CellToolTipText = "Duplo clique para exportar relatório em *.PDF." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "kit" : oColumn.CellToolTipText = "Duplo clique para editar a composição do KIT." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "produto_preco_venda" : oColumn.CellToolTipText = "Duplo clique para inserir Preço de Venda." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "adicionar_observacao_preco_venda" : oColumn.CellToolTipText = "Duplo clique para adicionar Sugestão de Preço de Venda." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "historico_observacao_preco_venda" : oColumn.CellToolTipText = "Duplo clique para visualizar histórico do Preço de Venda." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "separacao_estoque" : oColumn.CellToolTipText = "Duplo clique para Imprimir Relatório de Separação de Material do Estoque." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "cancelar_titulo" : oColumn.CellToolTipText = "Duplo clique para Cancelar o Título." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "finalizar_apontamento" : oColumn.CellToolTipText = "Duplo clique para Finalizar o Apontamento." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "gerar_credito" : oColumn.CellToolTipText = "Duplo clique para Gerar Crédito referênte ao Título." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "atualizar_saldo" : oColumn.CellToolTipText = "Duplo clique para Atualizar Saldo do Título." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "apontamento" : oColumn.CellToolTipText = "Duplo clique para Apontamento Manual." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "regra_faturamento" : oColumn.CellToolTipText = "Duplo clique para Cadastrar a Regra de Faturamento." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "aprovar" : oColumn.CellToolTipText = "Duplo clique para aprovar o registro." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "nova_revisao" : oColumn.CellToolTipText = "Duplo clique para inserir nova revisão." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "apontamento_parada" : oColumn.CellToolTipText = "Duplo clique para Apontamento de Parada Manual." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "atualizar_comissao" : oColumn.CellToolTipText = "Duplo clique para atualiza a Comissão." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "executar" : oColumn.CellToolTipText = "Duplo clique para executar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "contato" : oColumn.CellToolTipText = "Duplo clique para visualizar o contato." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "historico_preco" : oColumn.CellToolTipText = "Duplo clique para visualizar o Histórico de Preço." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "adicionar_tag" : oColumn.CellToolTipText = "Duplo clique para adicionar TAG." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "adicionar_lote" : oColumn.CellToolTipText = "Duplo clique para adicionar lote ao Inventário." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "follow_up" : oColumn.CellToolTipText = "Duplo clique para efetuar Follow Up." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "mapa_comparativo" : oColumn.CellToolTipText = "Duplo clique para visualizar o mapa comparativo." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "quebra_ordem_producao" : oColumn.CellToolTipText = "Duplo clique para dividir Ordem de Produção." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "fluxo_financeiro" : oColumn.CellToolTipText = "Duplo clique para visualizar o fluxo financeiro." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "inserir_revisao" : oColumn.CellToolTipText = "Duplo clique para gerar nova Revisão." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "arquivo" : oColumn.CellToolTipText = "Duplo clique para visualizar o arquivo." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "editar" : oColumn.CellToolTipText = "Duplo clique para editar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "editar_parceiro_negocio" : oColumn.CellToolTipText = "Duplo clique para editar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "duplicar" : oColumn.CellToolTipText = "Duplo clique para duplicar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "email" : oColumn.CellToolTipText = "Duplo clique para enviar por e-mail." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "compensar" : oColumn.CellToolTipText = "Duplo clique para compensar cheque." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "cancelar" : oColumn.CellToolTipText = "Duplo clique para cancelar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "ativar" : oColumn.CellToolTipText = "Duplo clique para ativar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "historico", "historico_orcamento", "historico_pedido" : oColumn.CellToolTipText = "Duplo clique para visualizar o histórico." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "comentario" : oColumn.CellToolTipText = "Duplo clique para inserir histórico / comentário." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "view" : oColumn.CellToolTipText = "Duplo clique para visualizar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "visualizar_po_transito" : oColumn.CellToolTipText = "Duplo clique para visualizar Pedidos de Compra em Aberto." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "imprimir" : oColumn.CellToolTipText = "Duplo clique para imprimir." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "imprimir_nota_fiscal" : oColumn.CellToolTipText = "Duplo clique para imprimir a Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "confirmar_recebimento" : oColumn.CellToolTipText = "Duplo clique para manifestar a Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "download" : oColumn.CellToolTipText = "Duplo clique para fazer Download." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "download_xml" : oColumn.CellToolTipText = "Duplo clique para fazer Download do XML." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "web" : oColumn.CellToolTipText = "Duplo clique para abrir página na Web." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "adicionar_faturamento" : oColumn.CellToolTipText = "Clique para adicionar item a Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "remover_faturamento" : oColumn.CellToolTipText = "Clique para remover item da Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                            Case "quantidade_estoque_reservado" : oColumn.CellToolTipText = "Duplo clique para visualizar lista de Produto Reservado no Estoque." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                            Case "quantidade_compra" : oColumn.CellToolTipText = "Duplo clique para visualizar lista de Pedido de Compra em Trânsito." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                            Case "remover_faturamento" : oColumn.CellToolTipText = "Clique para remover item da Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                        End Select

                    End If

                Next

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Nome Formulário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = sNomeFormulario : i += 1

                'Seta Parametros - Nome Grid
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_grid"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oGrid.Name

                'Seleciona Dados
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_grid", oSqlParameter)

                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        If oGrid.RootTable.Columns.Contains(oSqlDataReader.Item("campo")) Then

                            oColumn = oGrid.RootTable.Columns(oSqlDataReader.Item("campo"))

                            If oColumn.Tag <> "N" Then

                                'Seta Visible da Colula
                                oColumn.Visible = IIf(IsDBNull(oSqlDataReader.Item("visible")), oColumn.Visible, oSqlDataReader.Item("visible"))
                                oColumn.Width = IIf(IsDBNull(oSqlDataReader.Item("width")), oColumn.Width, oSqlDataReader.Item("width"))

                                If IsDBNull(oSqlDataReader.Item("position")) = False Then
                                    oColumn.Position = IIf(oSqlDataReader.Item("position") > oGrid.RootTable.Columns.Count - 1, oGrid.RootTable.Columns.Count - 1, oSqlDataReader.Item("position"))
                                End If

                                'If IsDBNull(oSqlDataReader.Item("position")) = False Then oColumn.Position = IIf(IsDBNull(oSqlDataReader.Item("position")), oColumn.Position, IIf(oSqlDataReader.Item("position") > oGrid.RootTable.Columns.Count, oGrid.RootTable.Columns.Count - 1, oSqlDataReader.Item("position")))
                                oColumn.CharacterCasing = CharacterCasing.Upper
                                If IsDBNull(oSqlDataReader.Item("r")) = False Then
                                    oColumn.CellStyle.BackColor = System.Drawing.Color.FromArgb(oSqlDataReader.Item("r"), oSqlDataReader.Item("g"), oSqlDataReader.Item("b"))
                                End If
                                If oSqlDataReader.Item("agrupado") = True Then
                                    oGrid.RootTable.Groups.Add(oColumn)
                                End If

                            End If

                        End If

                    End While

                End If

                'Fecha o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

                If oGrid.RootTable.ChildTables.Count > 0 Then

                    For i = 0 To oGrid.RootTable.ChildTables.Count - 1

                        For Each oCol As GridEXColumn In oGrid.RootTable.ChildTables(i).Columns

                            oGrid.RootTable.ChildTables(i).RowHeight = 20
                            oGrid.RootTable.ChildTables(i).CellToolTip = CellToolTip.TruncatedText
                            oGrid.RootTable.ChildTables(i).HideColumnsWhenGrouped = InheritableBoolean.True

                            'CharCasing
                            If oCol.Key.Contains("email") = False Then oCol.CharacterCasing = CharacterCasing.Upper

                            Select Case oCol.Key
                                Case "remover_preco_venda" : oCol.CellToolTipText = "Duplo clique para remover Preço de Venda." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "kit" : oCol.CellToolTipText = "Duplo clique para editar a composição do KIT." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "pdf" : oCol.CellToolTipText = "Duplo clique para Exportar Relatório em *.PDF." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "produto_preco_venda" : oCol.CellToolTipText = "Duplo clique para inserir Preço de Venda." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "adicionar_observacao_preco_venda" : oCol.CellToolTipText = "Duplo clique para adicionar Sugestão de Preço de Venda." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "historico_observacao_preco_venda" : oCol.CellToolTipText = "Duplo clique para visualizar histórico do Preço de Venda." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "separacao_estoque" : oCol.CellToolTipText = "Duplo clique para Imprimir Relatório de Separação de Material do Estoque." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "cancelar_titulo" : oCol.CellToolTipText = "Duplo clique para Cancelar o Título." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "finalizar_apontamento" : oCol.CellToolTipText = "Duplo clique para Finalizar o Apontamento." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "gerar_credito" : oCol.CellToolTipText = "Duplo clique para Gerar Crédito referênte ao Título." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "atualizar_saldo" : oCol.CellToolTipText = "Duplo clique para Atualizar Saldo do Título." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "apontamento" : oCol.CellToolTipText = "Duplo clique para Apontamento Manual." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "regra_faturamento" : oCol.CellToolTipText = "Duplo clique para Cadastrar a Regra de Faturamento." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "apontamento_parada" : oCol.CellToolTipText = "Duplo clique para Apontamento de Parada Manual." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "aprovar" : oCol.CellToolTipText = "Duplo clique para aprovar o registro." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "nova_revisao" : oCol.CellToolTipText = "Duplo clique para inserir nova revisão." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "atualizar_comissao" : oCol.CellToolTipText = "Duplo clique para atualiza a Comissão." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "executar" : oCol.CellToolTipText = "Duplo clique para executar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "follow_up" : oCol.CellToolTipText = "Duplo clique para efetuar follow up." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "adicionar_tag" : oCol.CellToolTipText = "Duplo clique para adicionar TAG." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "historico_preco" : oCol.CellToolTipText = "Duplo clique para visualizar o Histórico de Preço." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "contato" : oCol.CellToolTipText = "Duplo clique para visualizar o contato." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "adicionar_lote" : oCol.CellToolTipText = "Duplo clique para adicionar lote ao Inventário." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "mapa_comparativo" : oCol.CellToolTipText = "Duplo clique para visualizar o mapa comparativo." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "quebra_ordem_producao" : oCol.CellToolTipText = "Duplo clique para dividir Ordem de Produção." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "fluxo_financeiro" : oCol.CellToolTipText = "Duplo clique para visualizar o fluxo financeiro." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "inserir_revisao" : oCol.CellToolTipText = "Duplo clique para gerar nova Revisão." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "arquivo" : oCol.CellToolTipText = "Duplo clique para visualizar o arquivo." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "editar" : oCol.CellToolTipText = "Duplo clique para editar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "editar_parceiro_negocio" : oCol.CellToolTipText = "Duplo clique para editar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "duplicar" : oCol.CellToolTipText = "Duplo clique para duplicar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "email" : oCol.CellToolTipText = "Duplo clique para enviar por e-mail." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "cancelar" : oCol.CellToolTipText = "Duplo clique para cancelar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "compensar" : oCol.CellToolTipText = "Duplo clique para compensar cheque." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "ativar" : oCol.CellToolTipText = "Duplo clique para ativar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "historico", "historico_orcamento", "historico_pedido" : oCol.CellToolTipText = "Duplo clique para visualizar o histórico." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "comentario" : oCol.CellToolTipText = "Duplo clique para inserir histórico / comentário." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "view" : oCol.CellToolTipText = "Duplo clique para visualizar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "visualizar_po_transito" : oCol.CellToolTipText = "Duplo clique para visualizar Pedidos de Compra em Aberto." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "imprimir" : oCol.CellToolTipText = "Duplo clique para imprimir." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "imprimir_nota_fiscal" : oColumn.CellToolTipText = "Duplo clique para imprimir a Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
                                Case "confirmar_recebimento" : oCol.CellToolTipText = "Duplo clique para manifestar a Nota Fiscal." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "download" : oCol.CellToolTipText = "Duplo clique para fazer Download." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "download_xml" : oCol.CellToolTipText = "Duplo clique para fazer Download do XML." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                                Case "web" : oCol.CellToolTipText = "Duplo clique para abrir página na Web." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
                            End Select

                        Next

                    Next i

                End If


            End With

            'Configura Texts
            Call ConfigurarBuiltInTextsGrid(oGrid)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Public Sub ConfiguraGrid(ByVal oGrid As GridEX, _
    '                         ByVal sNomeFormulario As String, _
    '                         Optional ByVal bResaltarSelecao As Boolean = True)

    '    'Variaveis Locais
    '    Dim oSqlDataReader As SqlDataReader
    '    Dim oColumn As GridEXColumn
    '    Dim i As Integer = 0
    '    Dim oSqlParameter(5) As SqlParameter

    '    Try

    '        With oGrid

    '            .GroupTotals = GroupTotals.Always

    '            'Seta Forma de Agrupar
    '            .Tag = ""
    '            .GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003
    '            .GroupRowFormatStyle.ForeColor = System.Drawing.Color.SteelBlue
    '            .GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
    '            .RootTable.CellToolTip = CellToolTip.TruncatedText
    '            .RootTable.TableHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
    '            .RootTable.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
    '            .RootTable.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
    '            .FocusCellFormatStyle.BackColor = System.Drawing.Color.Empty

    '            For Each oColumn In oGrid.RootTable.Columns

    '                If oColumn.Key = "x" And bResaltarSelecao = True Then
    '                    Dim oFormatCondition As New GridEXFormatCondition
    '                    oFormatCondition = New GridEXFormatCondition(oColumn, ConditionOperator.Equal, True)
    '                    oFormatCondition.FormatStyle.BackColor = System.Drawing.Color.FromArgb(192, 255, 192)
    '                    oGrid.RootTable.FormatConditions.Add(oFormatCondition)
    '                    oFormatCondition = New GridEXFormatCondition(oColumn, ConditionOperator.Equal, False)
    '                    oFormatCondition.FormatStyle.BackColor = System.Drawing.Color.Empty
    '                    oGrid.RootTable.FormatConditions.Add(oFormatCondition)
    '                    oFormatCondition = New GridEXFormatCondition(oColumn, ConditionOperator.IsNull, "")
    '                    oFormatCondition.FormatStyle.BackColor = System.Drawing.Color.Empty
    '                    oGrid.RootTable.FormatConditions.Add(oFormatCondition)
    '                End If

    '                'Seta Propriedade do Controle
    '                oColumn.HideWhenGrouped = InheritableBoolean.True

    '                'CharCasing
    '                If oColumn.Key.Contains("email") = False Then oColumn.CharacterCasing = CharacterCasing.Upper Else oColumn.CharacterCasing = CharacterCasing.Lower

    '                If oColumn.ColumnType = ColumnType.Image Or oColumn.ColumnType = ColumnType.ImageAndText Then

    '                    Select Case oColumn.Key
    '                        Case "remover_preco_venda" : oColumn.CellToolTipText = "Duplo clique para remover Preço de Venda." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "pdf" : oColumn.CellToolTipText = "Duplo clique para exportar relatório em *.PDF." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "kit" : oColumn.CellToolTipText = "Duplo clique para editar a composição do KIT." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "produto_preco_venda" : oColumn.CellToolTipText = "Duplo clique para inserir Preço de Venda." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "adicionar_observacao_preco_venda" : oColumn.CellToolTipText = "Duplo clique para adicionar Sugestão de Preço de Venda." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "historico_observacao_preco_venda" : oColumn.CellToolTipText = "Duplo clique para visualizar histórico do Preço de Venda." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "separacao_estoque" : oColumn.CellToolTipText = "Duplo clique para Imprimir Relatório de Separação de Material do Estoque." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "cancelar_titulo" : oColumn.CellToolTipText = "Duplo clique para Cancelar o Título." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "finalizar_apontamento" : oColumn.CellToolTipText = "Duplo clique para Finalizar o Apontamento." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "gerar_credito" : oColumn.CellToolTipText = "Duplo clique para Gerar Crédito referênte ao Título." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "atualizar_saldo" : oColumn.CellToolTipText = "Duplo clique para Atualizar Saldo do Título." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "apontamento" : oColumn.CellToolTipText = "Duplo clique para Apontamento Manual." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "regra_faturamento" : oColumn.CellToolTipText = "Duplo clique para Cadastrar a Regra de Faturamento." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "aprovar" : oColumn.CellToolTipText = "Duplo clique para aprovar o registro." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "nova_revisao" : oColumn.CellToolTipText = "Duplo clique para inserir nova revisão." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "apontamento_parada" : oColumn.CellToolTipText = "Duplo clique para Apontamento de Parada Manual." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "atualizar_comissao" : oColumn.CellToolTipText = "Duplo clique para atualiza a Comissão." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "executar" : oColumn.CellToolTipText = "Duplo clique para executar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "contato" : oColumn.CellToolTipText = "Duplo clique para visualizar o contato." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "historico_preco" : oColumn.CellToolTipText = "Duplo clique para visualizar o Histórico de Preço." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "adicionar_tag" : oColumn.CellToolTipText = "Duplo clique para adicionar TAG." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "adicionar_lote" : oColumn.CellToolTipText = "Duplo clique para adicionar lote ao Inventário." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "follow_up" : oColumn.CellToolTipText = "Duplo clique para efetuar Follow Up." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "mapa_comparativo" : oColumn.CellToolTipText = "Duplo clique para visualizar o mapa comparativo." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "quebra_ordem_producao" : oColumn.CellToolTipText = "Duplo clique para dividir Ordem de Produção." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "fluxo_financeiro" : oColumn.CellToolTipText = "Duplo clique para visualizar o fluxo financeiro." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "inserir_revisao" : oColumn.CellToolTipText = "Duplo clique para gerar nova Revisão." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "arquivo" : oColumn.CellToolTipText = "Duplo clique para visualizar o arquivo." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "editar" : oColumn.CellToolTipText = "Duplo clique para editar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "editar_parceiro_negocio" : oColumn.CellToolTipText = "Duplo clique para editar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "duplicar" : oColumn.CellToolTipText = "Duplo clique para duplicar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "email" : oColumn.CellToolTipText = "Duplo clique para enviar por e-mail." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "compensar" : oColumn.CellToolTipText = "Duplo clique para compensar cheque." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "cancelar" : oColumn.CellToolTipText = "Duplo clique para cancelar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "ativar" : oColumn.CellToolTipText = "Duplo clique para ativar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "historico", "historico_orcamento", "historico_pedido" : oColumn.CellToolTipText = "Duplo clique para visualizar o histórico." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "comentario" : oColumn.CellToolTipText = "Duplo clique para inserir histórico / comentário." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "view" : oColumn.CellToolTipText = "Duplo clique para visualizar." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "visualizar_po_transito" : oColumn.CellToolTipText = "Duplo clique para visualizar Pedidos de Compra em Aberto." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "imprimir" : oColumn.CellToolTipText = "Duplo clique para imprimir." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "imprimir_nota_fiscal" : oColumn.CellToolTipText = "Duplo clique para imprimir a Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "confirmar_recebimento" : oColumn.CellToolTipText = "Duplo clique para manifestar a Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "download" : oColumn.CellToolTipText = "Duplo clique para fazer Download." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "download_xml" : oColumn.CellToolTipText = "Duplo clique para fazer Download do XML." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "web" : oColumn.CellToolTipText = "Duplo clique para abrir página na Web." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "adicionar_faturamento" : oColumn.CellToolTipText = "Clique para adicionar item a Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "remover_faturamento" : oColumn.CellToolTipText = "Clique para remover item da Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                        Case "quantidade_estoque_reservado" : oColumn.CellToolTipText = "Duplo clique para visualizar lista de Produto Reservado no Estoque." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText
    '                        Case "quantidade_compra" : oColumn.CellToolTipText = "Duplo clique para visualizar lista de Pedido de Compra em Trânsito." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText
    '                        Case "remover_faturamento" : oColumn.CellToolTipText = "Clique para remover item da Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                    End Select

    '                End If

    '            Next

    '            'Seta Parametros - Código Usuário
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "codigo_usuario"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

    '            'Seta Parametros - Código Empresa
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "codigo_empresa"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

    '            'Seta Parametros - Nome Formulário
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "nome_formulario"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Size = 50
    '            oSqlParameter(i).Value = sNomeFormulario : i += 1

    '            'Seta Parametros - Nome Grid
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "nome_grid"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Size = 50
    '            oSqlParameter(i).Value = oGrid.Name

    '            'Seleciona Dados
    '            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_grid", oSqlParameter)

    '            If oSqlDataReader.HasRows = True Then

    '                While oSqlDataReader.Read

    '                    If oGrid.RootTable.Columns.Contains(oSqlDataReader.Item("campo")) Then

    '                        oColumn = oGrid.RootTable.Columns(oSqlDataReader.Item("campo"))

    '                        If oColumn.Tag = "A" Then
    '                            oColumn.Visible = VerificaDireito(sNomeFormulario, gcAdministrator)
    '                        Else

    '                            'Seta Visible da Colula
    '                            oColumn.Visible = IIf(IsDBNull(oSqlDataReader.Item("visible")), oColumn.Visible, oSqlDataReader.Item("visible"))
    '                            oColumn.Width = IIf(IsDBNull(oSqlDataReader.Item("width")), oColumn.Width, oSqlDataReader.Item("width"))
    '                            If IsDBNull(oSqlDataReader.Item("position")) = False Then oColumn.Position = IIf(IsDBNull(oSqlDataReader.Item("position")), oColumn.Position, IIf(oSqlDataReader.Item("position") > oGrid.RootTable.Columns.Count, oGrid.RootTable.Columns.Count - 1, oSqlDataReader.Item("position")))
    '                            oColumn.CharacterCasing = CharacterCasing.Upper
    '                            If IsDBNull(oSqlDataReader.Item("r")) = False Then
    '                                oColumn.CellStyle.BackColor = System.Drawing.Color.FromArgb(oSqlDataReader.Item("r"), oSqlDataReader.Item("g"), oSqlDataReader.Item("b"))
    '                            End If
    '                            If oSqlDataReader.Item("agrupado") = True Then
    '                                oGrid.RootTable.Groups.Add(oColumn)
    '                            End If

    '                        End If

    '                    End If

    '                End While

    '            End If

    '            'Fecha o SqlDataReader
    '            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

    '            If oGrid.RootTable.ChildTables.Count > 0 Then

    '                For i = 0 To oGrid.RootTable.ChildTables.Count - 1

    '                    For Each oCol As GridEXColumn In oGrid.RootTable.ChildTables(i).Columns

    '                        oGrid.RootTable.ChildTables(i).RowHeight = 20
    '                        oGrid.RootTable.ChildTables(i).CellToolTip = CellToolTip.TruncatedText
    '                        oGrid.RootTable.ChildTables(i).HideColumnsWhenGrouped = InheritableBoolean.True

    '                        'CharCasing
    '                        If oCol.Key.Contains("email") = False Then oCol.CharacterCasing = CharacterCasing.Upper

    '                        Select Case oCol.Key
    '                            Case "remover_preco_venda" : oCol.CellToolTipText = "Duplo clique para remover Preço de Venda." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "kit" : oCol.CellToolTipText = "Duplo clique para editar a composição do KIT." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "pdf" : oCol.CellToolTipText = "Duplo clique para Exportar Relatório em *.PDF." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "produto_preco_venda" : oCol.CellToolTipText = "Duplo clique para inserir Preço de Venda." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "adicionar_observacao_preco_venda" : oCol.CellToolTipText = "Duplo clique para adicionar Sugestão de Preço de Venda." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "historico_observacao_preco_venda" : oCol.CellToolTipText = "Duplo clique para visualizar histórico do Preço de Venda." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "separacao_estoque" : oCol.CellToolTipText = "Duplo clique para Imprimir Relatório de Separação de Material do Estoque." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "cancelar_titulo" : oCol.CellToolTipText = "Duplo clique para Cancelar o Título." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "finalizar_apontamento" : oCol.CellToolTipText = "Duplo clique para Finalizar o Apontamento." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "gerar_credito" : oCol.CellToolTipText = "Duplo clique para Gerar Crédito referênte ao Título." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "atualizar_saldo" : oCol.CellToolTipText = "Duplo clique para Atualizar Saldo do Título." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "apontamento" : oCol.CellToolTipText = "Duplo clique para Apontamento Manual." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "regra_faturamento" : oCol.CellToolTipText = "Duplo clique para Cadastrar a Regra de Faturamento." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "apontamento_parada" : oCol.CellToolTipText = "Duplo clique para Apontamento de Parada Manual." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "aprovar" : oCol.CellToolTipText = "Duplo clique para aprovar o registro." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "nova_revisao" : oCol.CellToolTipText = "Duplo clique para inserir nova revisão." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "atualizar_comissao" : oCol.CellToolTipText = "Duplo clique para atualiza a Comissão." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "executar" : oCol.CellToolTipText = "Duplo clique para executar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "follow_up" : oCol.CellToolTipText = "Duplo clique para efetuar follow up." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "adicionar_tag" : oCol.CellToolTipText = "Duplo clique para adicionar TAG." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "historico_preco" : oCol.CellToolTipText = "Duplo clique para visualizar o Histórico de Preço." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "contato" : oCol.CellToolTipText = "Duplo clique para visualizar o contato." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "adicionar_lote" : oCol.CellToolTipText = "Duplo clique para adicionar lote ao Inventário." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "mapa_comparativo" : oCol.CellToolTipText = "Duplo clique para visualizar o mapa comparativo." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "quebra_ordem_producao" : oCol.CellToolTipText = "Duplo clique para dividir Ordem de Produção." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "fluxo_financeiro" : oCol.CellToolTipText = "Duplo clique para visualizar o fluxo financeiro." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "inserir_revisao" : oCol.CellToolTipText = "Duplo clique para gerar nova Revisão." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "arquivo" : oCol.CellToolTipText = "Duplo clique para visualizar o arquivo." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "editar" : oCol.CellToolTipText = "Duplo clique para editar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "editar_parceiro_negocio" : oCol.CellToolTipText = "Duplo clique para editar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "duplicar" : oCol.CellToolTipText = "Duplo clique para duplicar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "email" : oCol.CellToolTipText = "Duplo clique para enviar por e-mail." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "cancelar" : oCol.CellToolTipText = "Duplo clique para cancelar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "compensar" : oCol.CellToolTipText = "Duplo clique para compensar cheque." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "ativar" : oCol.CellToolTipText = "Duplo clique para ativar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "historico", "historico_orcamento", "historico_pedido" : oCol.CellToolTipText = "Duplo clique para visualizar o histórico." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "comentario" : oCol.CellToolTipText = "Duplo clique para inserir histórico / comentário." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "view" : oCol.CellToolTipText = "Duplo clique para visualizar." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "visualizar_po_transito" : oCol.CellToolTipText = "Duplo clique para visualizar Pedidos de Compra em Aberto." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "imprimir" : oCol.CellToolTipText = "Duplo clique para imprimir." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "imprimir_nota_fiscal" : oColumn.CellToolTipText = "Duplo clique para imprimir a Nota Fiscal." : oColumn.CellToolTip = CellToolTip.UseCellToolTipText : oColumn.Width = 20
    '                            Case "confirmar_recebimento" : oCol.CellToolTipText = "Duplo clique para manifestar a Nota Fiscal." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "download" : oCol.CellToolTipText = "Duplo clique para fazer Download." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "download_xml" : oCol.CellToolTipText = "Duplo clique para fazer Download do XML." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                            Case "web" : oCol.CellToolTipText = "Duplo clique para abrir página na Web." : oCol.CellToolTip = CellToolTip.UseCellToolTipText : oCol.Width = 20
    '                        End Select

    '                    Next

    '                Next i

    '            End If

    '            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_grid", oSqlParameter)

    '            If oSqlDataReader.HasRows = True Then

    '                While oSqlDataReader.Read

    '                    'Configura Grid Child
    '                    If oGrid.RootTable.ChildTables.Count > 0 Then

    '                        For Each oCol As GridEXColumn In oGrid.RootTable.ChildTables(0).Columns

    '                            oCol = oGrid.RootTable.ChildTables(0).Columns(oSqlDataReader.Item("campo"))

    '                            If IsNothing(oCol) = False Then

    '                                If oCol.Tag = "A" Then
    '                                    oCol.Visible = VerificaDireito(sNomeFormulario, gcAdministrator)
    '                                Else

    '                                    'Seta Visible da Colula
    '                                    oCol.Visible = IIf(IsDBNull(oSqlDataReader.Item("visible")), oCol.Visible, oSqlDataReader.Item("visible"))
    '                                    oCol.Width = IIf(IsDBNull(oSqlDataReader.Item("width")), oCol.Width, oSqlDataReader.Item("width"))
    '                                    If IsDBNull(oSqlDataReader.Item("position")) = False Then
    '                                        oCol.Position = IIf(IsDBNull(oSqlDataReader.Item("position")), oCol.Position, IIf(oSqlDataReader.Item("position") > oGrid.RootTable.ChildTables(0).Columns.Count, oGrid.RootTable.ChildTables(0).Columns.Count - 1, oSqlDataReader.Item("position")))
    '                                    End If
    '                                    oCol.CharacterCasing = CharacterCasing.Upper
    '                                    If IsDBNull(oSqlDataReader.Item("r")) = False Then
    '                                        oCol.CellStyle.BackColor = System.Drawing.Color.FromArgb(oSqlDataReader.Item("r"), oSqlDataReader.Item("g"), oSqlDataReader.Item("b"))
    '                                    End If
    '                                    If oSqlDataReader.Item("agrupado") = True Then
    '                                        oGrid.RootTable.ChildTables(0).Groups.Add(oCol)
    '                                    End If

    '                                End If

    '                            End If

    '                        Next

    '                    End If

    '                End While

    '            End If

    '            'Fecha o SqlDataReader
    '            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

    '        End With

    '        'Configura Texts
    '        Call ConfigurarBuiltInTextsGrid(oGrid)

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Public Sub UpdateConfiguraSplit(ByVal sSplit As String, _
                                    ByVal sNomeFormulario As String, _
                                    ByVal iPainel1Size As String, _
                                    ByVal iPainel2Size As Integer)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nome Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNomeFormulario : i += 1

            'Seta Parametros - Nome Split
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_split"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sSplit : i += 1

            'Seta Parametros - Painel 1 - Size
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "painel1_size"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPainel1Size : i += 1

            'Seta Parametros - Painel 2 - Size
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "painel2_size"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPainel2Size

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_split", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ConfiguraSplit(ByVal oSplit As SplitContainer, _
                              ByVal sNomeFormulario As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oColumn As GridEXColumn
        Dim i As Integer = 0
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nome Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNomeFormulario : i += 1

            'Seta Parametros - Nome Split
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_split"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = oSplit.Name

            'Seleciona Dados
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_split", oSqlParameter)

            While oSqlDataReader.Read

                'Seta Visible da Colula
                ' oSplit.SplitterDistance = oSqlDataReader.Item("painel1_size")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExecuteQuery(ByVal sQuery As String)

        Try

            'Obtem o DataSet
            ExecuteNonQuery(goDatabase.sConnection, CommandType.Text, sQuery)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExecuteQuery(ByVal sQuery As String, _
                            ByVal sConnection As String)

        Try

            'Obtem o DataSet
            ExecuteNonQuery(sConnection, CommandType.Text, sQuery)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDescricaoQuery(ByVal oMaskedEditBox As MaskedEditBox, _
                                  ByVal sQuery As String)

        'Variaveis Locais
        Dim sResult As String

        Try

            'Obtem o DataSet
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.Text, sQuery).ToString

            oMaskedEditBox.Text = sResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDescricao(ByVal oMaskedEditBox As MaskedEditBox, _
                             ByVal sQuery As String)

        'Variaveis Locais
        Dim sResult As String

        Try

            'Obtem o DataSet
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery).ToString

            oMaskedEditBox.Text = sResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDescricao(ByVal oEditBox As EditBox, _
                             ByVal sQuery As String)

        'Variaveis Locais
        Dim sResult As String

        Try

            'Obtem o DataSet
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            oEditBox.Text = sResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadValor(ByVal txtNumericEditBox As NumericEditBox, _
                         ByVal sQuery As String)

        'Váriaveis Locais
        Dim dReturn As Double

        Try

            'Obtem o DataSet
            dReturn = ExecuteScalar(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            txtNumericEditBox.Value = dReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadValor(ByRef dValor As Double, _
                         ByVal sQuery As String)

        Try

            'Obtem o DataSet
            dValor = ExecuteScalar(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadCodigo(ByVal sQuery As String) As String

        'Variaveis Locais
        Dim sResult As String

        Try

            'Obtem o DataSet
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery)

            Return sResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadCodigoTexto(ByVal sQuery As String) As String

        'Variaveis Locais
        Dim sResult As String

        Try

            'Obtem o DataSet
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.Text, sQuery)

            Return sResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function ConsultaBancoDados(ByVal sQuery As String) As String

        'Variaveis Locais
        Dim sResult As String

        Try

            'Obtem o DataSet
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.Text, sQuery)

            Return sResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadConfiguracao(ByVal sTabela As String, _
                                     ByVal sCampo As String) As String

        'Variaveis Locais
        Dim sResult As String
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Campo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCampo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            sResult = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao", oSqlParameter)

            Return sResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadDescricao(ByVal sQuery As String) As String

        'Variaveis Locais
        Dim sResult As String

        Try

            'Obtem o DataSet
            sResult = CType(ExecuteScalar(goDatabase.sConnection, CommandType.Text, "EXECUTE " & sQuery), String)

            Return sResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadConfiguracaoEmail()

        Try

            'Váriaveis Locais
            Dim oSqlDataReader As SqlDataReader
            Dim oSqlParameter(1) As SqlParameter
            Dim i As Integer = 0

            'Seta Parametros = Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros = Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Abre o Data Reader
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_email", oSqlParameter)

            If oSqlDataReader.HasRows Then

                oSqlDataReader.Read()

                goEmail.iCodigoFormaEnvio = oSqlDataReader.Item("codigo_forma_envio")
                goEmail.sEmail = oSqlDataReader.Item("email")
                goEmail.sServidor = oSqlDataReader.Item("servidor")
                goEmail.iPorta = oSqlDataReader.Item("porta")
                goEmail.sUsuario = oSqlDataReader.Item("usuario")
                If Not IsDBNull(oSqlDataReader.Item("senha")) Then goEmail.sSenha = oSqlDataReader.Item("senha")
                goEmail.bSsl = oSqlDataReader.Item("ssl")

            Else

                goEmail.iCodigoFormaEnvio = -1
                goEmail.sEmail = ""
                goEmail.sServidor = ""
                goEmail.iPorta = 0
                goEmail.sUsuario = ""
                goEmail.sSenha = ""
                goEmail.bSsl = False

            End If

            'Fecha o SqlDataReader
            If Not oSqlDataReader.IsClosed Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosTransportadora(ByVal iCodigo As Integer, _
                                       ByVal txtCNPJ As MaskedEditBox, _
                                       ByVal txtInscricaoEstadual As MaskedEditBox, _
                                       ByVal cboUF As UIComboBox, _
                                       ByVal cboMunicipio As UIComboBox, _
                                       ByVal txtEndereco As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_transportadora", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Enabled = True : txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf") : txtCNPJ.Tag = oSqlDataReader.Item("codigo_personalidade")
                txtInscricaoEstadual.Enabled = True : txtInscricaoEstadual.Text = oSqlDataReader.Item("inscricao_estadual")
                cboUF.Enabled = True : cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.Enabled = True : cboMunicipio.Text = oSqlDataReader.Item("municipio")
                txtEndereco.Enabled = True : txtEndereco.Text = oSqlDataReader.Item("endereco")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigo As Long, _
                                        ByVal txtCNPJ As MaskedEditBox, _
                                        ByVal txtInscricaoEstadual As MaskedEditBox, _
                                        ByVal txtInscricaoSuframa As MaskedEditBox, _
                                        ByVal cboRegimeTributario As UIComboBox, _
                                        ByVal txtLogradouro As MaskedEditBox, _
                                        ByVal txtNumero As MaskedEditBox, _
                                        ByVal txtComplemento As MaskedEditBox, _
                                        ByVal txtBairro As MaskedEditBox, _
                                        ByVal txtCEP As MaskedEditBox, _
                                        ByVal cboPais As UIComboBox, _
                                        ByVal cboUF As UIComboBox, _
                                        ByVal cboMunicipio As UIComboBox, _
                                        ByVal txtTelefone As MaskedEditBox, _
                                        ByVal txtEmail As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Enabled = True : txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf") : txtCNPJ.Tag = oSqlDataReader.Item("codigo_personalidade")
                txtInscricaoEstadual.Enabled = True : txtInscricaoEstadual.Text = oSqlDataReader.Item("inscricao_estadual")
                txtInscricaoSuframa.Enabled = True : txtInscricaoSuframa.Text = oSqlDataReader.Item("inscricao_suframa")
                cboRegimeTributario.Enabled = True : cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                txtLogradouro.Enabled = True : txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Enabled = True : txtNumero.Text = oSqlDataReader.Item("numero")
                txtComplemento.Enabled = True : txtComplemento.Text = oSqlDataReader.Item("complemento")
                txtBairro.Enabled = True : txtBairro.Text = oSqlDataReader.Item("bairro")
                txtCEP.Enabled = True : txtCEP.Text = oSqlDataReader.Item("cep")
                cboPais.Enabled = True : cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                cboUF.Enabled = True : cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.Enabled = True : cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                txtTelefone.Enabled = True : txtTelefone.Text = oSqlDataReader.Item("telefone1")
                txtEmail.Enabled = True : txtEmail.Text = oSqlDataReader.Item("email")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigo As Long, _
                                        ByRef sLogradouro As String, _
                                        ByRef sTelefone As String, _
                                        ByRef sEmail As String, _
                                        ByRef sCnpj As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sLogradouro = oSqlDataReader.Item("logradouro")
                sTelefone = oSqlDataReader.Item("telefone1")
                sEmail = oSqlDataReader.Item("email")
                sCnpj = oSqlDataReader.Item("cnpj_cpf")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigo As Long, _
                                        ByVal txtCNPJ As MaskedEditBox, _
                                        ByVal txtInscricaoEstadual As MaskedEditBox, _
                                        ByVal txtInscricaoMunicipal As MaskedEditBox, _
                                        ByVal txtLogradouro As MaskedEditBox, _
                                        ByVal txtNumero As MaskedEditBox, _
                                        ByVal txtComplemento As MaskedEditBox, _
                                        ByVal txtBairro As MaskedEditBox, _
                                        ByVal txtCEP As MaskedEditBox, _
                                        ByVal cboPais As UIComboBox, _
                                        ByVal cboUF As UIComboBox, _
                                        ByVal cboMunicipio As UIComboBox, _
                                        ByVal txtTelefone As MaskedEditBox, _
                                        ByVal txtEmail As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Enabled = True : txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf") : txtCNPJ.Tag = oSqlDataReader.Item("codigo_personalidade")
                txtInscricaoEstadual.Enabled = True : txtInscricaoEstadual.Text = oSqlDataReader.Item("inscricao_estadual")
                txtInscricaoMunicipal.Enabled = True : txtInscricaoMunicipal.Text = oSqlDataReader.Item("inscricao_municipal")
                txtLogradouro.Enabled = True : txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Enabled = True : txtNumero.Text = oSqlDataReader.Item("numero")
                txtComplemento.Enabled = True : txtComplemento.Text = oSqlDataReader.Item("complemento")
                txtBairro.Enabled = True : txtBairro.Text = oSqlDataReader.Item("bairro")
                txtCEP.Enabled = True : txtCEP.Text = oSqlDataReader.Item("cep")
                cboPais.Enabled = True : cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                cboUF.Enabled = True : cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.Enabled = True : cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                txtTelefone.Enabled = True : txtTelefone.Text = oSqlDataReader.Item("telefone1")
                txtEmail.Enabled = True : txtEmail.Text = oSqlDataReader.Item("email")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigo As Long, _
                                        ByVal cboUF As UIComboBox, _
                                        ByVal cboMunicipio As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                cboUF.Enabled = True : cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.Enabled = True : cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocioFaturamento(ByVal lCodigo As Long, _
                                                   ByVal txtCNPJ As MaskedEditBox, _
                                                   ByVal txtInscricaoEstadual As MaskedEditBox, _
                                                   ByVal txtInscricaoSuframa As MaskedEditBox, _
                                                   ByVal txtLogradouro As MaskedEditBox, _
                                                   ByVal txtNumero As MaskedEditBox, _
                                                   ByVal txtComplemento As MaskedEditBox, _
                                                   ByVal txtBairro As MaskedEditBox, _
                                                   ByVal txtCEP As MaskedEditBox, _
                                                   ByVal cboPais As UIComboBox, _
                                                   ByVal cboUF As UIComboBox, _
                                                   ByVal cboMunicipio As UIComboBox, _
                                                   ByVal txtTelefone As MaskedEditBox, _
                                                   ByVal txtEmail As MaskedEditBox, _
                                                   ByVal cboModalidadeFrete As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Enabled = True : txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf") : txtCNPJ.Tag = oSqlDataReader.Item("codigo_personalidade")
                txtInscricaoEstadual.Enabled = True : txtInscricaoEstadual.Text = oSqlDataReader.Item("inscricao_estadual")
                txtInscricaoSuframa.Enabled = True : txtInscricaoSuframa.Text = oSqlDataReader.Item("inscricao_suframa")
                txtLogradouro.Enabled = True : txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Enabled = True : txtNumero.Text = oSqlDataReader.Item("numero")
                txtComplemento.Enabled = True : txtComplemento.Text = oSqlDataReader.Item("complemento")
                txtBairro.Enabled = True : txtBairro.Text = oSqlDataReader.Item("bairro")
                txtCEP.Enabled = True : txtCEP.Text = oSqlDataReader.Item("cep")
                cboPais.Enabled = True : If IsDBNull(oSqlDataReader.Item("codigo_pais")) = False Then cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                cboUF.Enabled = True : cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.Enabled = True : If IsDBNull(oSqlDataReader.Item("codigo_municipio")) = False Then cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                txtTelefone.Enabled = True : txtTelefone.Text = oSqlDataReader.Item("telefone1")
                txtEmail.Enabled = True : txtEmail.Text = oSqlDataReader.Item("email")
                cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigo As Long, _
                                        ByVal txtCNPJ As MaskedEditBox, _
                                        ByVal txtInscricaoEstadual As MaskedEditBox, _
                                        ByVal txtEndereco As MaskedEditBox, _
                                        ByVal cboUF As UIComboBox, _
                                        ByVal cboMunicipio As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Enabled = True : txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf") : txtCNPJ.Tag = oSqlDataReader.Item("codigo_personalidade")
                txtInscricaoEstadual.Enabled = True : txtInscricaoEstadual.Text = oSqlDataReader.Item("inscricao_estadual")
                txtEndereco.Enabled = True : txtEndereco.Text = oSqlDataReader.Item("logradouro")
                cboUF.Enabled = True : cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.Enabled = True : cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigo As Long, _
                                        ByVal txtCNPJ As MaskedEditBox, _
                                        ByVal txtInscricaoEstadual As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Enabled = True : txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf") : txtCNPJ.Tag = oSqlDataReader.Item("codigo_personalidade")
                txtInscricaoEstadual.Enabled = True : txtInscricaoEstadual.Text = oSqlDataReader.Item("inscricao_estadual")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigo As Long, _
                                        ByVal txtCNPJ As MaskedEditBox, _
                                        ByVal txtInscricaoEstadual As MaskedEditBox, _
                                        ByVal txtLogradouro As MaskedEditBox, _
                                        ByVal txtNumero As MaskedEditBox, _
                                        ByVal txtComplemento As MaskedEditBox, _
                                        ByVal txtBairro As MaskedEditBox, _
                                        ByVal txtCEP As MaskedEditBox, _
                                        ByVal cboPais As UIComboBox, _
                                        ByVal cboUF As UIComboBox, _
                                        ByVal cboMunicipio As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Enabled = True : txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf") : txtCNPJ.Tag = oSqlDataReader.Item("codigo_personalidade")
                txtInscricaoEstadual.Enabled = True : txtInscricaoEstadual.Text = oSqlDataReader.Item("inscricao_estadual")
                txtLogradouro.Enabled = True : txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Enabled = True : txtNumero.Text = oSqlDataReader.Item("numero")
                txtComplemento.Enabled = True : txtComplemento.Text = oSqlDataReader.Item("complemento")
                txtBairro.Enabled = True : txtBairro.Text = oSqlDataReader.Item("bairro")
                txtCEP.Enabled = True : txtCEP.Text = oSqlDataReader.Item("cep")
                cboPais.Enabled = True : cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                cboUF.Enabled = True : cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.Enabled = True : cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal iCodigo As Integer, _
                                        ByVal txtCNPJ As MaskedEditBox, _
                                        ByVal lblCNPJ As Label)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf")
                lblCNPJ.Text = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, "CPF:", "CNPJ:")
                txtCNPJ.Mask = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, "000,000,000-00", "00,000,000/0000-00")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal iCodigo As Integer, _
                                        ByVal txtCNPJ As MaskedEditBox, _
                                        ByVal lblCNPJ As Label, _
                                        ByVal txtMunicipioUF As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJ.Text = oSqlDataReader.Item("cnpj_cpf")
                lblCNPJ.Text = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, "CPF:", "CNPJ:")
                txtCNPJ.Mask = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, "000,000,000-00", "00,000,000/0000-00")
                txtMunicipioUF.Text = oSqlDataReader.Item("municipio") & " - " & oSqlDataReader.Item("uf")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocioEndereco(ByVal lCodigo As Long, _
                                                ByRef sEndereco As String, _
                                                ByRef sCEP As String, _
                                                ByRef sMunicipio As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                sEndereco = oSqlDataReader.Item("endereco")
                sCEP = oSqlDataReader.Item("cep")
                sMunicipio = oSqlDataReader.Item("municipio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosTransportadoraEndereco(ByVal iCodigo As Integer, _
                                               ByRef sEndereco As String, _
                                               ByRef sCEP As String, _
                                               ByRef sMunicipio As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_transportadora", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                sEndereco = oSqlDataReader.Item("endereco")
                sCEP = oSqlDataReader.Item("cep")
                sMunicipio = oSqlDataReader.Item("municipio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocioVenda(ByVal lNumeroPedido As Long, _
                                             ByVal cboCliente As UIComboBox, _
                                             ByVal txtCNPJCPF As MaskedEditBox, _
                                             ByVal lblCNPJCPF As Label)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Nº do Pedido
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_pedido"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lNumeroPedido

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCNPJCPF.Text = oSqlDataReader.Item("cnpj_cpf")
                lblCNPJCPF.Text = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, "CPF:", "CNPJ:")
                txtCNPJCPF.Mask = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, "000,000,000-00", "00,000,000/0000-00")
                cboCliente.SelectedValue = oSqlDataReader.Item("codigo")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocioCompra(ByVal lCodigoPedidoCompra As Long, _
                                              ByVal cboFornecedor As UIComboBox, _
                                              ByVal txtCNPJCPF As MaskedEditBox, _
                                              ByVal lblCNPJCPF As Label)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Número do Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedidoCompra : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_pedido_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Controles
                    txtCNPJCPF.Text = oSqlDataReader.Item("cnpj_cpf")
                    lblCNPJCPF.Text = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, "CPF:", "CNPJ:")
                    txtCNPJCPF.Mask = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, "000,000,000-00", "00,000,000/0000-00")
                    cboFornecedor.SelectedValue = oSqlDataReader.Item("codigo")

                End While

            Else
                txtCNPJCPF.Text = ""
                lblCNPJCPF.Text = "CPF / CNPJ:"
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosItem(ByVal sCodigoItem As String, _
                             ByVal iCodigoTipoItem As Integer, _
                             ByRef sDescricao As String, _
                             ByRef lCodigo As Long)

        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sDescricao = oSqlDataReader.Item("descricao")
                lCodigo = oSqlDataReader.Item("codigo")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ProcuraCep(ByVal lCep As Long, _
                          ByVal cboPais As UIComboBox, _
                          ByVal cboUF As UIComboBox, _
                          ByVal cboMunicipio As UIComboBox, _
                          ByVal txtBairro As MaskedEditBox, _
                          ByVal txtLogradouro As MaskedEditBox, _
                          ByVal txtComplemento As MaskedEditBox)

        Try

            'Verifica se foi preenchido o CEP
            Dim sUF As String = ""
            Dim sMunicipio As String = ""
            Dim sBairro As String = ""
            Dim sTipoLogradouro As String = ""
            Dim sLogradouro As String = ""

            'Busca CEP no Banco de Dados
            Call BuscaCEPDatabase(lCep, _
                                  sUF, _
                                  sMunicipio, _
                                  sBairro, _
                                  sTipoLogradouro, _
                                  sLogradouro)

            'Verifica se encontrou o CEP no Banco de Dados
            If sUF = "" Then

                'Busca CEP na Internet
                Call BuscaCepInternet(Format(lCep, "00000000"), _
                                      sUF, _
                                      sMunicipio, _
                                      sBairro, _
                                      sTipoLogradouro, _
                                      sLogradouro)
            End If

            'Preenche Controles
            cboPais.SelectedValue = CInt(Pais.Brasil)
            cboUF.SelectedValue = sUF
            cboMunicipio.Text = sMunicipio
            txtBairro.Text = sBairro
            txtLogradouro.Text = sTipoLogradouro & " " & sLogradouro

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ProcuraCep(ByVal lCep As Long, _
                          ByVal cboUF As UIComboBox, _
                          ByVal cboMunicipio As UIComboBox, _
                          ByVal txtLogradouro As MaskedEditBox)

        Try

            'Verifica se foi preenchido o CEP
            Dim sUF As String = ""
            Dim sMunicipio As String = ""
            Dim sBairro As String = ""
            Dim sTipoLogradouro As String = ""
            Dim sLogradouro As String = ""

            'Busca CEP no Banco de Dados
            Call BuscaCEPDatabase(lCep, _
                                  sUF, _
                                  sMunicipio, _
                                  sBairro, _
                                  sTipoLogradouro, _
                                  sLogradouro)

            'Verifica se encontrou o CEP no Banco de Dados
            If sUF = "" Then

                'Busca CEP na Internet
                Call BuscaCepInternet(Format(lCep, "00000000"), _
                                      sUF, _
                                      sMunicipio, _
                                      sBairro, _
                                      sTipoLogradouro, _
                                      sLogradouro)
            End If

            'Preenche Controles
            cboUF.SelectedValue = sUF
            cboMunicipio.Text = sMunicipio
            txtLogradouro.Text = sTipoLogradouro & " " & sLogradouro & " - " & sBairro

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub BuscaCEPDatabase(ByVal lCep As Long, _
                                ByRef sUF As String, _
                                ByRef sCidade As String, _
                                ByRef sBairro As String, _
                                ByRef sTipoLogradouro As String, _
                                ByRef sLogradouro As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim sRetorno As String = ""

        Try

            'Seta Váriaveis
            sUF = ""
            sCidade = ""
            sBairro = ""
            sTipoLogradouro = ""
            sLogradouro = ""

            'Seta Parametros - Codigo
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cep"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCep

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_dados_cep", oSqlParameter)

            'Verifica se foi encontrado algum registro
            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    If IsDBNull(oSqlDataReader.Item("uf")) = False Then sUF = oSqlDataReader.Item("uf").ToString
                    If IsDBNull(oSqlDataReader.Item("municipio")) = False Then sCidade = oSqlDataReader.Item("municipio").ToString
                    If IsDBNull(oSqlDataReader.Item("bairro")) = False Then sBairro = oSqlDataReader.Item("bairro").ToString
                    If IsDBNull(oSqlDataReader.Item("tipo_logradouro")) = False Then sTipoLogradouro = oSqlDataReader.Item("tipo_logradouro").ToString
                    If IsDBNull(oSqlDataReader.Item("logradouro")) = False Then sLogradouro = oSqlDataReader.Item("logradouro").ToString

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, "FUNCTION - PROCURA CEP")
        End Try

    End Sub

    Public Sub BuscaCepInternet(ByVal sCEP As String, _
                                ByRef sUF As String, _
                                ByRef sCidade As String, _
                                ByRef sBairro As String, _
                                ByRef sTipoLogradouro As String, _
                                ByRef sLogradouro As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim sResultado As String

        Try

            'Seta Váriaveis
            sUF = ""
            sCidade = ""
            sBairro = ""
            sTipoLogradouro = ""
            sLogradouro = ""

            'Cria a requisão HTTP
            Dim oWebRequest As WebRequest = WebRequest.Create("http://cep.republicavirtual.com.br/web_cep.php?cep=" + sCEP.Replace("-", "").Trim() + "&formato=xml")

            'Verifica se necessita Proxy
            If goConfiguracaoNFe.bHabilitarProxy = True Then

                'Configura as informações do Proxy
                Dim oWebProxy As New WebProxy(goConfiguracaoNFe.sEndereco, goConfiguracaoNFe.iPorta)

                'Verifica se existe Domínio
                If goConfiguracaoNFe.sDominio = "" Then
                    oWebProxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                Else
                    oWebProxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                End If
                'Informa o Proxy, configurado como o Proxy padrão para o WebRequest
                oWebRequest.Proxy = oWebProxy

            End If


            'Executa a requisão do XML do endereço, utilizando Proxy
            Dim oXmlStream As Stream = oWebRequest.GetResponse().GetResponseStream()

            oDataSet = New DataSet()
            'Usa o Stream obtido pela requisão como fonte do DataSet
            oDataSet.ReadXml(oXmlStream)

            If Not IsNothing(oDataSet) Then

                If (oDataSet.Tables(0).Rows.Count > 0) Then

                    sResultado = oDataSet.Tables(0).Rows(0).Item("resultado").ToString()

                    Select Case sResultado

                        Case "1"
                            sUF = oDataSet.Tables(0).Rows(0).Item("uf").ToString().Trim()
                            sCidade = oDataSet.Tables(0).Rows(0).Item("cidade").ToString().Trim()
                            sBairro = oDataSet.Tables(0).Rows(0).Item("bairro").ToString().Trim()
                            sTipoLogradouro = oDataSet.Tables(0).Rows(0).Item("tipo_logradouro").ToString().Trim()
                            sLogradouro = oDataSet.Tables(0).Rows(0).Item("logradouro").ToString().Trim()

                        Case "2"
                            sUF = oDataSet.Tables(0).Rows(0).Item("uf").ToString().Trim()
                            sCidade = oDataSet.Tables(0).Rows(0).Item("cidade").ToString().Trim()

                    End Select

                End If

            End If

        Catch ex As Exception
            Throw New Exception("Falha ao Buscar o Cep" & vbCrLf & ex.ToString)
        End Try

    End Sub

    Public Function LoadConfiguracaoNFe() As Boolean

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_nfe", oSqlParameter)

            'Verifica se foi encontrado algum registro
            If oSqlDataReader.HasRows = False Then

                'Seta Retorno da Função
                LoadConfiguracaoNFe = False

            Else

                'Seta Retorno da Função
                LoadConfiguracaoNFe = True

                While oSqlDataReader.Read

                    goConfiguracaoNFe.sPastaEntrada = oSqlDataReader.Item("pasta_entrada") & "\"
                    goConfiguracaoNFe.sPastaSaida = oSqlDataReader.Item("pasta_saida") & "\"
                    goConfiguracaoNFe.sPastaRecibo = oSqlDataReader.Item("pasta_recibo") & "\"
                    goConfiguracaoNFe.sPastaImpressao = oSqlDataReader.Item("pasta_impressao") & "\"
                    goConfiguracaoNFe.sPastaXSD = oSqlDataReader.Item("pasta_xsd") & "\"
                    goConfiguracaoNFe.sPastaEnvio = oSqlDataReader.Item("pasta_envio") & "\"
                    goConfiguracaoNFe.bHabilitarProxy = oSqlDataReader.Item("habilitar_proxy")
                    goConfiguracaoNFe.sDominio = oSqlDataReader.Item("dominio")
                    goConfiguracaoNFe.sUsuario = oSqlDataReader.Item("usuario")
                    goConfiguracaoNFe.sSenha = oSqlDataReader.Item("senha")
                    goConfiguracaoNFe.sEndereco = oSqlDataReader.Item("endereco")
                    goConfiguracaoNFe.iPorta = oSqlDataReader.Item("porta")
                    goConfiguracaoNFe.iCodigoTipoAmbienteNFe = oSqlDataReader.Item("codigo_tipo_ambiente_nfe")
                    goConfiguracaoNFe.iModoOperacaoNFe = oSqlDataReader.Item("codigo_modo_operacao_nfe")
                    goConfiguracaoNFe.iFormatoImpressaoDANFE = oSqlDataReader.Item("codigo_forma_impressao_danfe_nfe")
                    goConfiguracaoNFe.sUF = oSqlDataReader.Item("uf")
                    goConfiguracaoNFe.sCodigoEstado = oSqlDataReader.Item("codigo_estado")
                    goConfiguracaoNFe.iTimeOut = oSqlDataReader.Item("timeout")
                    goConfiguracaoNFe.iQuantidadeMaximaNF = oSqlDataReader.Item("quantidade_maxima_nfe")
                    goConfiguracaoNFe.iTamanhoMaximo = oSqlDataReader.Item("tamanho_maximo")
                    goConfiguracaoNFe.bHorarioVerao = oSqlDataReader.Item("horario_verao")
                    goConfiguracaoNFe.sCertificado = oSqlDataReader.Item("certificado")
                    'goConfiguracaoNFe.bEnviarEmailAutomaticamente = oSqlDataReader.Item("enviar_email_automatico")
                    'goConfiguracaoNFe.sUsuarioEmail = oSqlDataReader.Item("usuario_email")
                    'goConfiguracaoNFe.sEmail = oSqlDataReader.Item("email")
                    'goConfiguracaoNFe.sSenhaEmail = Cripitografar(oSqlDataReader.Item("senha_email"))
                    'goConfiguracaoNFe.sServidorEmail = oSqlDataReader.Item("servidor_email")
                    'goConfiguracaoNFe.iPortaEmail = oSqlDataReader.Item("porta_email")
                    'goConfiguracaoNFe.bSSLEmail = oSqlDataReader.Item("ssl_email")
                    'goConfiguracaoNFe.iCodigoAutotextoEmail = oSqlDataReader.Item("codigo_autotexto_email")

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadConfiguracaoNFSe() As Boolean

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim bReturn As Boolean
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_nfse", oSqlParameter)

            'Verifica se foi encontrado algum Registro
            If oSqlDataReader.HasRows = False Then

                'Limpa Controles
                goConfiguracaoNFSe.sPastaEntrada = ""
                goConfiguracaoNFSe.sPastaSaida = ""
                goConfiguracaoNFSe.sPastaRecibo = ""
                goConfiguracaoNFSe.sPastaImpressao = ""
                goConfiguracaoNFSe.sPastaXSD = ""
                goConfiguracaoNFSe.sPastaEnvio = ""
                goConfiguracaoNFSe.bHabilitarProxy = False
                goConfiguracaoNFSe.sDominio = ""
                goConfiguracaoNFSe.sUsuario = ""
                goConfiguracaoNFSe.sSenha = ""
                goConfiguracaoNFSe.sEndereco = ""
                goConfiguracaoNFSe.iPorta = 0
                goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = -1
                goConfiguracaoNFSe.iTamanhoMaximo = 0
                'Seta Retorno da Função
                bReturn = False

            Else

                While oSqlDataReader.Read

                    goConfiguracaoNFSe.sPastaEntrada = oSqlDataReader.Item("pasta_entrada") & "\"
                    goConfiguracaoNFSe.sPastaSaida = oSqlDataReader.Item("pasta_saida") & "\"
                    goConfiguracaoNFSe.sPastaRecibo = oSqlDataReader.Item("pasta_recibo") & "\"
                    goConfiguracaoNFSe.sPastaImpressao = oSqlDataReader.Item("pasta_impressao") & "\"
                    goConfiguracaoNFSe.sPastaXSD = oSqlDataReader.Item("pasta_xsd") & "\"
                    goConfiguracaoNFSe.sPastaEnvio = oSqlDataReader.Item("pasta_envio") & "\"
                    goConfiguracaoNFSe.bHabilitarProxy = oSqlDataReader.Item("habilitar_proxy")
                    goConfiguracaoNFSe.sDominio = oSqlDataReader.Item("dominio")
                    goConfiguracaoNFSe.sUsuario = oSqlDataReader.Item("usuario")
                    goConfiguracaoNFSe.sSenha = oSqlDataReader.Item("senha")
                    goConfiguracaoNFSe.sEndereco = oSqlDataReader.Item("endereco")
                    goConfiguracaoNFSe.iPorta = oSqlDataReader.Item("porta")
                    goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = oSqlDataReader.Item("codigo_tipo_ambiente_nfse")
                    goConfiguracaoNFSe.iTamanhoMaximo = oSqlDataReader.Item("tamanho_maximo")
                    'Seta Retorno da Função
                    bReturn = True

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Return bReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadConfiguracaoMDFe() As Boolean

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_mdfe", oSqlParameter)

            'Verifica se foi encontrado algum registro
            If oSqlDataReader.HasRows = False Then

                'Seta Retorno da Função
                LoadConfiguracaoMDFe = False

            Else

                'Seta Retorno da Função
                LoadConfiguracaoMDFe = True

                While oSqlDataReader.Read

                    goConfiguracaoMDFe.sPastaEntrada = oSqlDataReader.Item("pasta_entrada") & "\"
                    goConfiguracaoMDFe.sPastaSaida = oSqlDataReader.Item("pasta_saida") & "\"
                    goConfiguracaoMDFe.sPastaRecibo = oSqlDataReader.Item("pasta_recibo") & "\"
                    goConfiguracaoMDFe.sPastaImpressao = oSqlDataReader.Item("pasta_impressao") & "\"
                    goConfiguracaoMDFe.sPastaXSD = oSqlDataReader.Item("pasta_xsd") & "\"
                    goConfiguracaoMDFe.sPastaEnvio = oSqlDataReader.Item("pasta_envio") & "\"
                    goConfiguracaoMDFe.bHabilitarProxy = oSqlDataReader.Item("habilitar_proxy")
                    goConfiguracaoMDFe.sDominio = oSqlDataReader.Item("dominio")
                    goConfiguracaoMDFe.sUsuario = oSqlDataReader.Item("usuario")
                    goConfiguracaoMDFe.sSenha = oSqlDataReader.Item("senha")
                    goConfiguracaoMDFe.sEndereco = oSqlDataReader.Item("endereco")
                    goConfiguracaoMDFe.iPorta = oSqlDataReader.Item("porta")
                    goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = oSqlDataReader.Item("codigo_tipo_ambiente_mdfe")
                    goConfiguracaoMDFe.iModoOperacaoMDFe = oSqlDataReader.Item("codigo_modo_operacao_mdfe")
                    goConfiguracaoMDFe.iFormatoImpressaoDAMFE = oSqlDataReader.Item("codigo_forma_impressao_damfe_mdfe")
                    goConfiguracaoMDFe.sUF = oSqlDataReader.Item("uf")
                    goConfiguracaoMDFe.sCodigoEstado = oSqlDataReader.Item("codigo_estado")
                    goConfiguracaoMDFe.iTimeOut = oSqlDataReader.Item("timeout")
                    goConfiguracaoMDFe.iQuantidadeMaximaMDF = oSqlDataReader.Item("quantidade_maxima_mdfe")
                    goConfiguracaoMDFe.iTamanhoMaximo = oSqlDataReader.Item("tamanho_maximo")
                    goConfiguracaoMDFe.bHorarioVerao = oSqlDataReader.Item("horario_verao")
                    goConfiguracaoMDFe.sCertificado = oSqlDataReader.Item("certificado")

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosNCM(ByVal iCodigo As Integer, _
                            ByVal txtAliquotaIPI As NumericEditBox)

        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim oSqlDataReader As SqlDataReader

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ncm_dados", oSqlParameter)

            While oSqlDataReader.Read
                txtAliquotaIPI.Value = oSqlDataReader.Item("aliquota_ipi")
            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNCM(ByVal iCodigo As Integer, _
                            ByVal txtDescricao As MaskedEditBox, _
                            ByVal txtAliquotaIPI As NumericEditBox, _
                            ByVal txtExTIPI As MaskedEditBox)

        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim oSqlDataReader As SqlDataReader

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ncm_dados", oSqlParameter)

            While oSqlDataReader.Read
                txtAliquotaIPI.Value = oSqlDataReader.Item("aliquota_ipi")
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtExTIPI.Text = oSqlDataReader.Item("ex_tipi")
            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosEmitente()

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_empresa", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                goEmitente.sCNPJ = oSqlDataReader.Item("cnpj")
                goEmitente.sInscricaoEstadual = oSqlDataReader.Item("inscricao_estadual")
                goEmitente.sInscricaoMunicipal = oSqlDataReader.Item("inscricao_municipal")
                goEmitente.sInscricaoEstadualST = oSqlDataReader.Item("inscricao_estadual_st")
                goEmitente.sRazaoSocial = oSqlDataReader.Item("razao_social")
                goEmitente.sRegimeTributario = oSqlDataReader.Item("regime_tributario")
                goEmitente.iRegimeTributario = oSqlDataReader.Item("codigo_regime_tributario")
                goEmitente.sNomeFantasia = oSqlDataReader.Item("nome_fantasia")
                goEmitente.sLogradouro = oSqlDataReader.Item("logradouro")
                goEmitente.sNumero = oSqlDataReader.Item("numero")
                goEmitente.sComplemento = oSqlDataReader.Item("complemento")
                goEmitente.sBairro = oSqlDataReader.Item("bairro")
                goEmitente.sMunicipio = oSqlDataReader.Item("municipio")
                goEmitente.iMunicipio = oSqlDataReader.Item("codigo_municipio")
                goEmitente.sUF = oSqlDataReader.Item("uf")
                goEmitente.iUF = oSqlDataReader.Item("codigo_uf")
                goEmitente.sCEP = oSqlDataReader.Item("cep")
                goEmitente.sPais = oSqlDataReader.Item("pais")

            End While

            'Fecha o oSqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadConfiguracaoFonte()

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_fonte", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                goFonte.sFonte = oSqlDataReader.Item("fonte")
                goFonte.dSize = oSqlDataReader.Item("size")
                goFonte.bBold = oSqlDataReader.Item("bold")
                goFonte.bItalic = oSqlDataReader.Item("italic")

            End While

            'Fecha o oSqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ControlaLote(ByVal lCodigo As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim bReturn As Boolean

        Try

            'Seta Parametros - Código Item
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            bReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_item_controla_lote", oSqlParameter), Boolean)

            'Retorno da Função
            Return bReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadContatoParceiroNegocio(ByVal lCodigoParceiroNegocio As Long, _
                                               ByVal iTipoContato As Integer) As String

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Tipo do Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoContato : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_email_contato", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriavel
                sReturn = sReturn & IIf(sReturn.Trim = "", "", "; ") & oSqlDataReader.Item("email")

            End While

            'Fecha o oSqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            'Retorno da Função
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadDadosBanco(ByVal sBanco As String) As String

        Try

            'Variaveis Locais
            Dim oSqlParameter(0) As SqlParameter
            Dim sReturn As String

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_banco"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 3
            oSqlParameter(0).Value = sBanco

            'Executa Query
            sReturn = CStr(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_banco_boleto_bancario", oSqlParameter))

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadUFIBGE(ByVal iCodigo As Integer) As String

        'Variaveis Locais
        Dim sReturn As String
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código IBGE
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_ibge"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = iCodigo

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_estado_codigo_ibge", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadURLMDFe(ByVal iWebServiceMDFe As WebServiceMDFe) As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim sRetorn As String

        Try

            'Seta Parametros - Código Tipo Ambiente MDFe
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_tipo_ambiente_mdfe"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe


            'Seta Parametros - WebService MDFe
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_webservice_mdfe"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = iWebServiceMDFe

            'Executa Query
            sRetorn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_url_mdfe", oSqlParameter)

            'Retorna URL
            Return sRetorn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadURLNFe(ByVal iWebServiceNFe As WebServiceNFe, _
                               ByVal sUF As String) As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim sRetorn As String

        Try

            'Seta Parametros - Código Tipo Ambiente NFe
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_tipo_ambiente_nfe"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goConfiguracaoNFe.iCodigoTipoAmbienteNFe

            'Seta Parametros - UF
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "uf"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 2
            oSqlParameter(1).Value = sUF

            'Seta Parametros - WebService NFe
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_webservice_nfe"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = iWebServiceNFe

            'Executa Query
            sRetorn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_url_nfe", oSqlParameter)

            'Retorna URL
            Return sRetorn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadURLNFSe() As String

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Dim sRetorn As String

        Try

            'Seta Parametros - Código Tipo Ambiente NFSe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_nfse"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe

            'Executa Query
            sRetorn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_url_nfse", oSqlParameter)

            'Retorna URL
            Return sRetorn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadContato(ByVal lCodigoParceiroNegocio As Long, _
                                ByVal iTipoContato As Integer) As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim sReturn As String = ""
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código do Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código do Tipo de Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoContato : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_email_contato", oSqlParameter)

            While oSqlDataReader.Read

                sReturn = sReturn & IIf(sReturn = "", "", ",") & oSqlDataReader.Item("email")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadContatoOrcamento(ByVal lCodigoOrcamento As Long) As String

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim oSqlDataReader As SqlDataReader
        Dim sReturn As String = ""

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrcamento : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_orcamento_email", oSqlParameter)

            While oSqlDataReader.Read

                sReturn = sReturn & IIf(sReturn = "", "", ",") & oSqlDataReader.Item("email")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadContatoVenda(ByVal lCodigoPedidoVenda As Long) As String

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim oSqlDataReader As SqlDataReader
        Dim sReturn As String = ""

        Try

            'Seta Parametros - Código Pedido Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedidoVenda : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_email", oSqlParameter)

            While oSqlDataReader.Read

                sReturn = sReturn & IIf(sReturn = "", "", ",") & oSqlDataReader.Item("email")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadFormTipoDocumentoPagamento(ByVal iCodigoTipoDocumentoPagamento As Integer, _
                                                   ByVal sProcedure As String) As String

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim sReturn As String = ""

        Try

            'Seta Parametros - Código do Tipo de Documento de Pagamento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = iCodigoTipoDocumentoPagamento

            'Executa a Query
            sReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, sProcedure, oSqlParameter), String)

            'Retorna da Função
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaDireito(ByVal sFormulario As String, _
                                    ByVal sDireito As String) As Boolean

        'Variaveis Locais
        Dim sQuery As New StringBuilder
        Dim iReturn As Boolean

        Try

            'Seta Retorno da Função
            VerificaDireito = False

            If sDireito = gcInsert Or sDireito = gcUpdate Or sDireito = gcDelete Or sDireito = gcSelect Then

                If gcControlaLicenca = True Then
                    'Verifica se o controle deve ser através da API
                    If goUsuario.bValidacaoLicencaAPI = True Then
                        'Validação API Licença
                        If CDate(goUsuario.sDataValidacaoAPI) > Now.Date Or _
                             CDate(goUsuario.sDataUltimoAcessoAPI) > Now.Date Or _
                             DateAdd(DateInterval.Day, IIf(IsNumeric(goUsuario.iToleranciaAPI), goUsuario.iToleranciaAPI, 7), CDate(goUsuario.sDataValidadeAPI)) < Now.Date Then
                            'Retorno da Função
                            Return False
                        End If


                    Else
                        'Validação Padrão
                        If CDate(goUsuario.sDataValidacao) > Now.Date Or _
                              CDate(goUsuario.sDataUltimoAcesso) > Now.Date Or _
                              DateAdd(DateInterval.Day, 7, CDate(goUsuario.sDataValidade)) < Now.Date Then
                            'Retorno da Função
                            Return False
                        End If

                    End If


                End If


            End If

            'Query - Seleciona Direito
            sQuery.Append("SELECT ISNULL(tb_cad_perfil_usuario_direito." & sDireito & ", 0)")
            sQuery.Append("FROM tb_cad_perfil_usuario_direito INNER JOIN ")
            sQuery.Append("tb_stc_formulario ON ")
            sQuery.Append("tb_cad_perfil_usuario_direito.codigo_formulario = tb_stc_formulario.codigo ")
            sQuery.Append("WHERE (((tb_cad_perfil_usuario_direito.codigo_formulario) = " & sFormulario.Split(":")(0) & ") ")
            sQuery.Append("AND ((tb_stc_formulario.ativo) = 1) ")
            sQuery.Append("AND ((tb_cad_perfil_usuario_direito.codigo_perfil_usuario) = " & goUsuario.iPerfil & "));")

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.Text, sQuery.ToString), Boolean)

            'Seta Retorno da Função
            Return iReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaFormularioExiste(ByVal sFormulario As String) As Boolean

        'Variaveis Locais
        Dim sQuery As New StringBuilder
        Dim iReturn As Boolean

        Try

            'Query - Seleciona Direito
            sQuery.Append("SELECT COUNT(*) ")
            sQuery.Append("FROM tb_stc_formulario ")
            sQuery.Append("WHERE (((tb_stc_formulario.codigo) = " & sFormulario.Split(":")(0) & ") ")
            sQuery.Append("AND ((tb_stc_formulario.ativo) = 1));")

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.Text, sQuery.ToString), Boolean)

            'Seta Retorno da Função
            Return iReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadUFParceiroNegocio(ByVal iCodigoParceiroNegocio As Integer) As String

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim sReturn As String = ""
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Parceiro Negocio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_uf_parceiro_negocio", oSqlParameter)

            'Seta Retorno da Função
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadUFParceiroNegocioCotacao(ByVal lCodigoCotacao As Long, _
                                                 ByVal iCodigoCotacaoFornecedor As Integer) As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim sReturn As String = ""
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_uf_parceiro_negocio_compras_cotacao", oSqlParameter)

            'Seta Retorno da Função
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub ConfigureMaskEdit(ByVal oUserControl As UserControl)

        Try

            'Variaveis Locais
            Dim oSqlParameter(0) As SqlParameter
            Dim i As Integer = 0
            Dim oSqlDataReader As SqlDataReader
            Dim oAssembly As Assembly = GetExecutingAssembly()
            Dim oMaskedEditBox As MaskedEditBox

            Try

                'Seta Parametros - formulário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oUserControl.Name

                'Executa a Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_mascara_controle", oSqlParameter)

                While oSqlDataReader.Read

                    oMaskedEditBox = CType(oUserControl.Controls.Find(oSqlDataReader.Item("controle"), True)(0), MaskedEditBox)
                    oMaskedEditBox.Mask = oSqlDataReader.Item("mascara")

                End While

            Catch SqlEx As SqlException
                Throw SqlEx
            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ConfigureValorDefault(ByVal oUserControl As UserControl)

        Try

            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer = 0
            Dim oSqlDataReader As SqlDataReader
            Dim oAssembly As Assembly = GetExecutingAssembly()

            Try

                'Seta Parametros - formulário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oUserControl.Name : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa a Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_valor_default_controle", oSqlParameter)

                While oSqlDataReader.Read

                    Dim oControl() As Control = oUserControl.Controls.Find(oSqlDataReader.Item("controle"), True)

                    'Verifica se encontrol o Registro
                    If oControl.Length > 0 Then

                        Select Case oSqlDataReader.Item("tipo")

                            Case "CalendarCombo"
                                Dim oCalendarCombo As CalendarCombo = oControl(0)
                                If IsDBNull(oSqlDataReader.Item("valor")) Then
                                    oCalendarCombo.Value = Now
                                    oCalendarCombo.Checked = False
                                Else
                                    oCalendarCombo.Value = DateAdd(DateInterval.Day, oSqlDataReader.Item("valor"), Now)
                                End If

                            Case "EditBox"
                                Dim oEditBox As EditBox = oControl(0)
                                oEditBox.Text = oSqlDataReader.Item("valor")

                            Case "MaskedEditBox"
                                Dim oMaskedEditBox As MaskedEditBox = oControl(0)
                                oMaskedEditBox.Text = oSqlDataReader.Item("valor")

                            Case "NumericEditBox"
                                Dim oNumericEditBox As NumericEditBox = oControl(0)
                                oNumericEditBox.Value = oSqlDataReader.Item("valor")

                            Case "UIComboBox"
                                Dim oUIComboBox As UIComboBox = oControl(0)
                                oUIComboBox.SelectedValue = oSqlDataReader.Item("valor")
                        End Select

                    End If

                End While

                'Fecha o SQLDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch SqlEx As SqlException
                Throw SqlEx
            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SaveValorDefault(ByVal oUserControl As UserControl, _
                                ByVal sControle As String, _
                                ByVal sValor As String, _
                                ByVal sTipo As String)

        Try

            'Variaveis Locais
            Dim oSqlParameter(5) As SqlParameter
            Dim i As Integer = 0
          
            Try

                'Seta Parametros - formulário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oUserControl.Name : i += 1

                'Seta Parametros - Controle
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "controle"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 30
                oSqlParameter(i).Value = sControle : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_default"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = sValor : i += 1

                'Seta Parametros - Tipo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = sTipo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa a Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_static_valor_default_controle", oSqlParameter)

            Catch SqlEx As SqlException
                Throw SqlEx
            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SaveValorDefault(ByVal oForm As Form, _
                                ByVal sControle As String, _
                                ByVal sValor As String, _
                                ByVal sTipo As String)

        Try

            'Variaveis Locais
            Dim oSqlParameter(5) As SqlParameter
            Dim i As Integer = 0

            Try

                'Seta Parametros - formulário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oForm.Name : i += 1

                'Seta Parametros - Controle
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "controle"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 30
                oSqlParameter(i).Value = sControle : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_default"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = sValor : i += 1

                'Seta Parametros - Tipo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = sTipo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa a Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_static_valor_default_controle", oSqlParameter)

            Catch SqlEx As SqlException
                Throw SqlEx
            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ConfigureMaskEdit(ByVal oForm As Form)

        Try

            'Variaveis Locais
            Dim oSqlParameter(0) As SqlParameter
            Dim i As Integer = 0
            Dim oSqlDataReader As SqlDataReader
            Dim oAssembly As Assembly = GetExecutingAssembly()
            Dim oMaskedEditBox As MaskedEditBox

            Try

                'Seta Parametros - formulário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oForm.Name

                'Executa a Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_mascara_controle", oSqlParameter)

                While oSqlDataReader.Read

                    oMaskedEditBox = CType(oForm.Controls.Find(oSqlDataReader.Item("controle"), True)(0), MaskedEditBox)
                    oMaskedEditBox.Mask = oSqlDataReader.Item("mascara")

                End While

            Catch SqlEx As SqlException
                Throw SqlEx
            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GeraLayoutBoletoBancario(ByVal sName As String, _
                                        ByVal oBoletos As List(Of BoletoBancario), _
                                        ByRef sArquivo As String)


        'Váriaveis Locais
        Dim sHtml As New StringBuilder

       

        For Each oBoletoBancario As BoletoBancario In oBoletos

            sHtml.Append(oBoletoBancario.MontaHtml())

            'Responsável por "quebrar a página"
            If oBoletos.Count > 1 Then
                sHtml.Replace("<style>", "<style> .break { page-break-before: always; }")
            Else
                sHtml.Replace("<style>", "<style> .break { page-break-before: auto; }")
            End If
            sHtml.Append("<h1 class=""break""></h1>")


            sHtml.Replace("Sacador", "Pagador")
            sHtml.Replace("Sacado", "Pagador")
            sHtml.Replace("Cedente", "Beneficiário")
            sHtml.Replace("cedente", "beneficiário")

            sHtml.Replace("0710/70224", "0710.71.70224")
            sHtml.Replace("<td class=""w65 Ab bc Ac"">748-9</td>", "<td class=""w65 Ab bc Ac"">748-X</td>")
        Next
       
        If sArquivo <> "" Then
            If File.Exists(sArquivo) Then
                File.Delete(sArquivo)
            End If
        Else
            If sName = "" Then

                sArquivo = System.IO.Path.GetTempFileName().Replace(".tmp", ".html")

                If File.Exists(sArquivo) Then
                    File.Delete(sArquivo)
                End If
            Else

                sArquivo = System.IO.Path.GetTempPath & sName & ".html"

                If File.Exists(sArquivo) Then '
                    File.Delete(sArquivo)
                End If

            End If
        End If

        'If Not sArquivo.Contains("\\srv-magma16\ACTi\INTEGRAÇÃO\COBRANÇA\CARTA BOLETO") Then
        If Not sArquivo.Contains("\\srvfs\ACTi\INTEGRAÇÃO\COBRANÇA\CARTA BOLETO") Then

            Using oFileStream As New FileStream(sArquivo, FileMode.Create)
                Dim oStreamWriter As New StreamWriter(oFileStream, System.Text.Encoding.Default)
                oStreamWriter.Write(sHtml.ToString())
                oStreamWriter.Close()
                oFileStream.Close()
            End Using
        End If
    End Sub

    Public Sub GeraLayoutBoletoBancario(ByVal oBoletos As List(Of BoletoBancario), _
                                        ByRef sArquivo As String, _
                                        ByRef sHTMLReturn As String)

        'Váriaveis Locais
        Dim sHtml As New StringBuilder

        For Each oBoletoBancario As BoletoBancario In oBoletos
            sHtml.Append(oBoletoBancario.MontaHtml())
            'Responsável por "quebrar a página"
            sHtml.Replace("<style>", "<style> .break { page-break-before: auto; }")
            sHtml.Append("<h1 class=""break""></h1>")
        Next

        sArquivo = System.IO.Path.Combine(System.IO.Path.GetTempPath, "BOLETO.html")

        If File.Exists(sArquivo) Then
            File.Delete(sArquivo)
        End If

        sHTMLReturn = sHtml.ToString

        Using oFileStream As New FileStream(sArquivo, FileMode.Create)
            Dim oStreamWriter As New StreamWriter(oFileStream, System.Text.Encoding.Default)
            oStreamWriter.Write(sHtml.ToString())
            oStreamWriter.Close()
            oFileStream.Close()
        End Using

    End Sub

    Public Function ValidaIntegracaoExcel(ByVal sPlanilha As String,
                                          ByVal sArquivo As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Planilha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "planilha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = "[" & sPlanilha & "$]"

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validade_integracao_arquivo_excel", oSqlParameter)

            'Retorno da Função
            Return IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Return False
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub ConfiguraGridOrcamentoAdm(ByVal oGrid As GridEX,
                                         ByVal bAdmOrcamento As Boolean)


        Try

            For Each oColumn As GridEXColumn In oGrid.RootTable.Columns

                If oColumn.Tag = "A" And bAdmOrcamento = False Then
                    oColumn.Visible = False
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: BEMAFI :::"

    Public Function VerificaErroBemafi(ByVal iRetECF As Integer) As Boolean

        'Váriaveis Locais
        Dim iACK As Integer
        Dim iST1 As Integer
        Dim iST2 As Integer
        Dim iST3 As Integer

        Select Case iRetECF
            Case 0 : frmMain.Informacao(Mensagem.Erro, "Erro de comunicação com a Impressora Fiscal.") : Return False
            Case 1
                Bematech_FI_RetornoImpressoraMFD(iACK, iST1, iST2, iST3)
                Return True
            Case -2 : frmMain.Informacao(Mensagem.Erro, "Parâmetro inválido na função.") : Return False
            Case -4 : frmMain.Informacao(Mensagem.Erro, "O arquivo de inicialização BemaFI32.ini não foi encontrado no diretório de sistema do Windows.") : Return False
            Case -5 : frmMain.Informacao(Mensagem.Erro, "Erro ao abrir a porta de comunicação.") : Return False
            Case -27 : frmMain.Informacao(Mensagem.Erro, "Status da impressora diferente de 6,0,0 (ACK, ST1 e ST2).") : Return False
            Case Else : Return False
        End Select

        'Select Case iRetECF
        '    Case 0 : MsgBox("Erro de comunicação com a Impressora Fiscal.") : Return False
        '    Case 1
        '        Bematech_FI_RetornoImpressoraMFD(iACK, iST1, iST2, iST3)
        '        Return True
        '    Case -2 : MsgBox("Parâmetro inválido na função.") : Return False
        '    Case -4 : MsgBox("O arquivo de inicialização BemaFI32.ini não foi encontrado no diretório de sistema do Windows.") : Return False
        '    Case -5 : MsgBox("Erro ao abrir a porta de comunicação.") : Return False
        '    Case -27 : MsgBox("Status da impressora diferente de 6,0,0 (ACK, ST1 e ST2).") : Return False
        '    Case Else : Return False
        'End Select

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Public Sub VisualizarArquivo(ByVal sArquivo As String)

        Try

            If sArquivo = "" Then MsgBox("Arquivo Inexistente.", MsgBoxStyle.Exclamation, "Validação") : Exit Sub

            Process.Start(sArquivo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteArquivoBD(ByVal sTabela As String, _
                               ByVal sPath As String, _
                               ByVal lCodigo As Long, _
                               Optional ByVal iCodigo2 As Integer = -1, _
                               Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Path
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "path"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sPath : i += 1

            'Seta Parametros - Código 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo2 : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo3 : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_arquivo_banco_dados", oSqlParameter)

            'Exclui Arquivo
            If File.Exists(sPath) Then
                File.Delete(sPath)
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertArquivoBD(ByVal sTabela As String, _
                               ByVal sDescricao As String, _
                               ByVal sRevisao As String, _
                               ByVal sArquivo As String, _
                               ByVal iCodigoTipoArquivo As Integer, _
                               ByVal lCodigo As Long, _
                               Optional ByVal iCodigo2 As Integer = -1, _
                               Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Dim sArquivoServidor As String
        Dim bArquivoPadraoModulo As Boolean


        Try
            bArquivoPadraoModulo = LoadCodigo("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'arquivo_padrao_modulo'")
            'Carrega Pasta de Arquivo
            sArquivoServidor = LoadCodigo("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

            If sArquivoServidor = "" Then
                Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
            ElseIf Directory.Exists(sArquivoServidor) = False Then
                Throw New Exception("Você não possui permissão para enxergar a pasta (" & sArquivoServidor & ").")
            Else
                If bArquivoPadraoModulo = False Then
                    sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                    While File.Exists(sArquivoServidor) = True
                        sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                    End While
                Else
                    sArquivoServidor = sArquivoServidor & Replace(sTabela, "tb_", "") & "_" & CStr(lCodigo).PadLeft(6, "0") & "_" & sDescricao & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                End If

                File.Copy(sArquivo, sArquivoServidor)
            End If

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoArquivo = -1, DBNull.Value, iCodigoTipoArquivo) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivoServidor : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo3 = -1, DBNull.Value, iCodigo3) : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_arquivo_banco_dados", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertArquivoBDPath(ByVal sTabela As String, _
                                   ByVal sDescricao As String, _
                                   ByVal sRevisao As String, _
                                   ByVal sArquivo As String, _
                                   ByVal iCodigoTipoArquivo As Integer, _
                                   ByVal lCodigo As Long, _
                                   Optional ByVal iCodigo2 As Integer = -1, _
                                   Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Dim sArquivoServidor As String

        Try

            'Carrega Pasta de Arquivo
            sArquivoServidor = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

            If sArquivoServidor = "" Then
                Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
            ElseIf Directory.Exists(sArquivoServidor) = False Then
                Throw New Exception("Você não possui permissão para enxergar a pasta (" & sArquivoServidor & ").")
            Else
                sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                While File.Exists(sArquivoServidor) = True
                    sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                End While
                File.Copy(sArquivo, sArquivoServidor)
            End If

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoArquivo = -1, DBNull.Value, iCodigoTipoArquivo) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoServidor : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo3 = -1, DBNull.Value, iCodigo3) : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_arquivo_banco_dados", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertArquivoBDPath2(ByVal sTabela As String, _
                                    ByVal sDescricao As String, _
                                    ByVal sRevisao As String, _
                                    ByVal sArquivo As String, _
                                    ByVal iCodigoTipoArquivo As Integer, _
                                    ByVal lCodigo As Long, _
                                    Optional ByVal iCodigo2 As Integer = -1, _
                                    Optional ByVal iCodigo3 As Integer = -1, _
                                    Optional ByVal bAtivo As Boolean = True)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0
        Dim sArquivoServidor As String

        Try

            'Carrega Pasta de Arquivo
            sArquivoServidor = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

            If sArquivoServidor = "" Then
                Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
            ElseIf Directory.Exists(sArquivoServidor) = False Then
                Throw New Exception("Você não possui permissão para enxergar a pasta (" & sArquivoServidor & ").")
            Else
                sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                While File.Exists(sArquivoServidor) = True
                    sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                End While
                File.Copy(sArquivo, sArquivoServidor)
            End If

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoArquivo = -1, DBNull.Value, iCodigoTipoArquivo) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoServidor : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo3 = -1, DBNull.Value, iCodigo3) : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_arquivo_banco_dados", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateArquivoBD(ByVal sTabela As String, _
                               ByVal sDescricao As String, _
                               ByVal sRevisao As String, _
                               ByVal sArquivo As String, _
                               ByVal iCodigoTipoArquivo As Integer, _
                               ByVal sPath As String, _
                               ByVal lCodigo As Long, _
                               Optional ByVal iCodigo2 As Integer = -1, _
                               Optional ByVal iCodigo3 As Integer = -1, _
                               Optional ByVal bAtivo As Boolean = True)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0
        Dim sArquivoServidor As String

        Try

            'Carrega Pasta de Arquivo
            sArquivoServidor = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

            If sArquivo <> "" Then

                If sArquivoServidor = "" Then
                    Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
                ElseIf Directory.Exists(sArquivoServidor) = False Then
                    Throw New Exception("Você não possui permissão para enxergar a pasta (" & sArquivoServidor & ").")
                Else
                    sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                    While File.Exists(sArquivoServidor) = True
                        sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                    End While
                    File.Copy(sArquivo, sArquivoServidor)
                End If

            End If

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoArquivo : i += 1

            'Seta Parametros - Path
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "path"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPath : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivoServidor : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo3 = -1, DBNull.Value, iCodigo3) : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_arquivo_banco_dados", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateArquivoBDPath(ByVal sTabela As String, _
                                   ByVal sDescricao As String, _
                                   ByVal sRevisao As String, _
                                   ByVal sArquivo As String, _
                                   ByVal iCodigoTipoArquivo As Integer, _
                                   ByVal sPath As String, _
                                   ByVal lCodigo As Long, _
                                   Optional ByVal iCodigo2 As Integer = -1, _
                                   Optional ByVal iCodigo3 As Integer = -1, _
                                   Optional ByVal bAtivo As Boolean = True)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0
        Dim sArquivoServidor As String

        Try

            'Carrega Pasta de Arquivo
            sArquivoServidor = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

            If sArquivo <> "" Then

                If sArquivoServidor = "" Then
                    Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
                ElseIf Directory.Exists(sArquivoServidor) = False Then
                    Throw New Exception("Você não possui permissão para enxergar a pasta (" & sArquivoServidor & ").")
                Else
                    sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sArquivo, Len(sArquivo) - InStrRev(sArquivo, "."))
                    If File.Exists(sArquivoServidor) Then File.Delete(sArquivoServidor)
                    File.Copy(sArquivo, sArquivoServidor)
                End If

            End If

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoArquivo : i += 1

            'Seta Parametros - Path
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "path"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sPath : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoServidor : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo2 = -1, DBNull.Value, iCodigo2) : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo3 = -1, DBNull.Value, iCodigo3) : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_arquivo_banco_dados", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridArquivoBD(ByVal oGrid As GridEX, _
                                 ByVal sTabela As String, _
                                 ByVal lCodigo As Long, _
                                 Optional ByVal iCodigo2 As Integer = -1, _
                                 Optional ByVal iCodigo3 As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo2 : i += 1

            'Seta Parametros - Código3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo3 : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_arquivo_banco_dados", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub VisualizarDocumentoBD(ByVal oArquivo() As Byte, _
                                     ByVal sExtensao As String)

        Try

            Dim sArquivo As String = Path.GetTempPath & Format(Now, "yyyyMMdd_hhmmss") & "." & sExtensao

            While File.Exists(sArquivo) = True
                sArquivo = Path.GetTempPath & Format(Now, "yyyyMMdd_hhmmss") & "." & sExtensao
            End While

            'Verifica se foi Informado o Arquivo
            Dim oFileStream As New FileStream(sArquivo, FileMode.OpenOrCreate, FileAccess.Write)
            oFileStream.Write(oArquivo, 0, oArquivo.Length)
            oFileStream.Flush()
            oFileStream.Close()

            Process.Start(sArquivo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: VALIDAÇÃO :::"

    Public Function ValidaFormulario(ByVal oControlContainer As Control, _
                                     ByVal cForeColor As System.Drawing.Color, _
                                     Optional ByVal bValidaChildrens As Boolean = False) As Boolean

        Try

            'Seta Retorno da Função
            ValidaFormulario = False

            Dim oControlValidar As Control

            For Each oControl As Control In oControlContainer.Controls

                If TypeOf (oControl) Is Label AndAlso oControl.ForeColor = cForeColor Then

                    If oControlContainer.Controls.Find(oControl.Name.Replace("lbl", "txt"), True).Count > 0 Then
                        oControlValidar = oControlContainer.Controls.Find(oControl.Name.Replace("lbl", "txt"), True)(0)
                    ElseIf oControlContainer.Controls.Find(oControl.Name.Replace("lbl", "cbo"), True).Count > 0 Then
                        oControlValidar = oControlContainer.Controls.Find(oControl.Name.Replace("lbl", "cbo"), True)(0)
                    End If

                    'MaskedEditBox
                    If TypeOf (oControlValidar) Is MaskedEditBox Then
                        Dim oMaskedEditBox As MaskedEditBox = oControlValidar
                        If ValidaCampo(oMaskedEditBox, oControl, TipoCampo.texto) = False Then
                            Exit Function
                        End If
                    End If

                    'EditBox
                    If TypeOf (oControlValidar) Is EditBox Then
                        Dim oEditBox As EditBox = oControlValidar
                        If ValidaCampo(oEditBox, oControl, TipoCampo.texto) = False Then
                            Exit Function
                        End If
                    End If

                    'ComboBox
                    If TypeOf (oControlValidar) Is UIComboBox Then
                        Dim oUIComboBox As UIComboBox = oControlValidar
                        If ValidaCampo(oUIComboBox, oControl) = False Then
                            Exit Function
                        End If
                    End If

                ElseIf bValidaChildrens = True Then

                    If oControl.Controls.Count > 0 Then
                        Call ValidaFormulario(oControl, cForeColor, bValidaChildrens)
                    End If

                End If

            Next

            'Seta Retorno da Função
            ValidaFormulario = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Module
