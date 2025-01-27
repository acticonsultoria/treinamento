Imports INTERACTI.SQLHelper
Imports System.Data.SqlClient
Imports System.Text
Imports System.Reflection
Imports System.Reflection.Assembly
Imports System.IO
Imports System.Drawing.Imaging
Imports Janus.Windows.UI.StatusBar

Public Class clsFrmMain

    Public Sub LoadMenu(ByVal oMenuStrip As MenuStrip)

        Try

            'Oculta Controle
            frmMain.tlpMain.Visible = False

            'Carrega Menu Suspenso            
            Call LoadMenuSuspenso(oMenuStrip)

            'Torna Visivel Controle
            frmMain.tlpMain.Visible = True

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadMenuSuspenso(ByVal oMenuStrip As MenuStrip)

        Try


            'Variaveis Locais            
            Dim oSqlDataReader As SqlDataReader
            Dim oMenuItem As ToolStripMenuItem
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer = 0
            Dim iTotal As Integer = 0

            'Seta Parametros = Perfil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).ParameterName = "codigo_perfil"
            oSqlParameter(i).Value = goUsuario.iPerfil : i += 1

            'Seta Parametros = Idioma
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_idioma"
            oSqlParameter(i).Value = goUsuario.iIdioma : i += 1

            'Seta Parametros = Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Seta Váriavel
            iTotal = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_menu_suspenso_quantidade", oSqlParameter)

            'Seta Máximo
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = iTotal
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
            frmMain.stbMain.Panels("pnlProgressBar").Visible = True

            'Limpa Menu            
            oMenuStrip.Items.Clear()

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_menu_suspenso", oSqlParameter)

            'Carrega Grupo
            While oSqlDataReader.Read()

                'Seta Progressbar
                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1
                frmMain.stbMain.Panels("pnlProgressBar").ToolTipText = FormatNumber(frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue * 100 / iTotal, 2) & "%"

                'Seta Valores do Grupo
                oMenuItem = New ToolStripMenuItem
                oMenuItem.Text = oSqlDataReader.Item("descricao").ToString
                oMenuItem.Tag = oSqlDataReader.Item("user_control").ToString
                oMenuItem.Name = oSqlDataReader.Item("codigo").ToString
                If IsDBNull(oSqlDataReader.Item("imagem")) = False Then
                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    oMenuItem.Image = Image.FromStream(stmBLOBData)
                End If

                'Verifica o Nível
                If oSqlDataReader.Item("nivel") > 0 Then

                    Try
                        Dim oMenuPai As ToolStripMenuItem
                        oMenuPai = oMenuStrip.Items.Find(oSqlDataReader.Item("codigo_menu_pai"), True)(0)
                        oMenuPai.DropDownItems.Add(oMenuItem)

                    Catch ex As Exception
                        oMenuStrip.Items.Add(oMenuItem)
                    End Try
                Else
                    oMenuStrip.Items.Add(oMenuItem)
                End If

                'Verifica se está associado há algum Registro
                If IsDBNull(oSqlDataReader.Item("user_control")) = False Then
                    If oSqlDataReader.Item("visualizar") = False Then oMenuItem.Enabled = False
                    AddHandler oMenuItem.Click, AddressOf MenuSuspenso_Click
                End If

            End While

            oMenuStrip.MinimumSize = New Size(0, 24)
            'oToolStripItem = oMenuStrip.Items.Add(Global.INTERACTI.My.Resources.logo_interacti)
            'bMensagem = True

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        Finally
            'Oculta ProgressBar
            frmMain.stbMain.Panels("pnlProgressBar").Visible = False
        End Try

    End Sub

    Public Sub LoadBarraIdioma(ByVal oStatusBar As UIStatusBar)

        Try

            'Variaveis Locais
            Dim oSqlDataReader As SqlDataReader
            Dim oPanel As UIStatusBarPanel

            'Carrega Lista de Idioma
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_idioma")

            'Carrega Grupo
            While oSqlDataReader.Read()

                'Carrega Painel
                oPanel = New UIStatusBarPanel
                oPanel.Alignment = HorizontalAlignment.Right
                oPanel.DrawBorder = False
                oPanel.Width = 20
                oPanel.ToolTipText = oSqlDataReader.Item("descricao")
                oPanel.Key = oSqlDataReader.Item("codigo")
                If IsDBNull(oSqlDataReader.Item("imagem")) = False Then
                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    oPanel.Image = Image.FromStream(stmBLOBData)
                End If

                'Adiciona Painel
                oStatusBar.Panels.Add(oPanel)

            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadTelaInicial()

        Try

            'Variaveis Locais
            Dim oAssembly As Assembly = GetExecutingAssembly()
            Dim oSqlDataReader As SqlDataReader
            Dim oSqlParameter(1) As SqlParameter
            Dim i As Integer = 0

            'Seta Parametros = Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros = Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Value = goUsuario.iUsuario

            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_tela_inicial_abrir", oSqlParameter)

            'Carrega Telas
            While oSqlDataReader.Read()

                Dim oUsrControl As UserControl
                oUsrControl = oAssembly.CreateInstance("INTERACTI." & oSqlDataReader.Item("user_control"))
                oUsrControl.Tag = oSqlDataReader.Item("codigo")
                oUsrControl.Dock = IIf(CType(LoadDescricao("sp_select_static_formulario_fill '" & oSqlDataReader.Item("user_control") & "'"), Boolean) = True, DockStyle.Fill, DockStyle.None)
                Call frmMain.LoadPage(oSqlDataReader.Item("user_control"), Strings.StrConv(oSqlDataReader.Item("descricao"), VbStrConv.ProperCase), oUsrControl)

                'Executa Tarefas Pendentes do Sistema
                Application.DoEvents()

            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub MenuSuspenso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais            
            Dim oAssembly As Assembly = GetExecutingAssembly()
            Dim sFormulario() As String

          


            sFormulario = sender.tag.ToString.Split("|")

            'Verifica qual Botão foi Pressionado
            Select Case sFormulario(0)

                Case "frmAdmConfigXML"
                    Dim sConnectionAtual As String = goDatabase.sConnection
                    frmAdmConfigXML.ShowDialog()
                    'Verifica se foi Alterado o Banco de Dados
                    If sConnectionAtual <> goDatabase.sConnection Then
                        'Limpa Váriavel
                        goUsuario.sUsuario = ""
                        'Abre Formulário de Login
                        frmLogin.ShowDialog()
                    End If

                Case "frmAdmAtualizar"
                    VerificaVersaoAplicativo()




                Case "frmLogin" : frmLogin.ShowDialog()
                    'Case "frmAdmBackup" : frmAdmBackup.ShowDialog()
                Case "frmIntExportExcelTable" : frmIntExportExcelTable.ShowDialog()
                Case "frmAdmControleLicenca" : frmAdmControleLicenca.ShowDialog()
                Case "frmLnkVendaProducao" : frmLnkVendaProducao.ShowDialog()
                Case "frmLnkVendaFaturamento" : frmLnkVendaFaturamento.ShowDialog()
                Case "frmCadOperacaoTaxaHora" : frmCadOperacaoTaxaHora.ShowDialog()

                Case "usrAjuda"

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    sURLHelp = sFormulario(1)
                    Dim oAjuda As New usrAjuda
                    oAjuda.Dock = DockStyle.Fill

                    Dim oMenuPai As ToolStripMenuItem
                    Dim sText As String = sender.text

                    oMenuPai = sender.OwnerItem
                    sText = oMenuPai.Text & " - " & sText
                    While Not oMenuPai.OwnerItem Is Nothing
                        oMenuPai = oMenuPai.OwnerItem
                        sText = oMenuPai.Text & " - " & sText
                    End While

                    'Executa Tarefas Pendentes do Sistema
                    Application.DoEvents()

                    'Abre Relatório
                    frmMain.LoadPage(sFormulario(0), sText, oAjuda)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case "usrAdmAtualizarAplicativo"

                    Call VerificaVersaoAplicativo()

                Case "CAD000000001.rpt", _
                     "CAD000000002.rpt", _
                     "CAD000000007.rpt"

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Dim oMenuPai As ToolStripMenuItem
                    Dim sText As String = sender.text

                    oMenuPai = sender.OwnerItem
                    sText = oMenuPai.Text & " - " & sText
                    While Not oMenuPai.OwnerItem Is Nothing
                        oMenuPai = oMenuPai.OwnerItem
                        sText = oMenuPai.Text & " - " & sText
                    End While

                    Application.DoEvents()

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Redimenciona Vetor
                    ReDim goCrystalReport.sReportParameter(1)
                    'Seta Parametros
                    goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                    goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                    goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                    goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                    goCrystalReport.sReport = goCrystalReport.sPath & sFormulario(0)

                    Dim oReport As New usrReport
                    oReport.Dock = DockStyle.Fill

                    'Abre Relatório
                    frmMain.LoadPageReport(sFormulario(0), sText, oReport)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Else

                    Dim oUsrControl As UserControl
                    Dim oMenuPai As ToolStripMenuItem
                    Dim sText As String = sender.text

                    'Limpa Váriaveis
                    iCodigoTipoItemFind = TipoItem.nao_definido
                    sItemVendaFind = ""
                    sItemAtivoFixoFind = ""
                    sItemEstoqueFind = ""
                    sItemCompraFind = ""
                    sItemProducaoFind = ""
                    bInserirProdutoFind = False
                    sTipoFind = ""
                    sTelaVenda = ""
                    iCodigoClienteGlobal = -1
                    sClienteGlobal = ""
                    sRevisaoGlobal = ""
                    lCodigoVendaGlobal = -1

                    'Carrega o Menu
                    oMenuPai = sender.OwnerItem
                    sText = oMenuPai.Text & " - " & sText
                    While Not oMenuPai.OwnerItem Is Nothing
                        oMenuPai = oMenuPai.OwnerItem
                        sText = oMenuPai.Text & " - " & sText
                    End While

                    'Seta UserControl
                    oUsrControl = oAssembly.CreateInstance("INTERACTI." & sFormulario(0))
                    oUsrControl.Tag = sFormulario(1)
                    oUsrControl.Dock = IIf(CType(LoadDescricao("sp_select_static_formulario_fill '" & sFormulario(0) & "'"), Boolean) = True, DockStyle.Fill, DockStyle.None)

                    'Configura Mascara
                    Call ConfigureMaskEdit(oUsrControl) : Call LoadControlesTraducao(oUsrControl)

                    'Carrega Página
                    Call frmMain.LoadPage(sFormulario(0), sText, oUsrControl)

                    'Executa Tarefas Pendentes do Sistema
                    Application.DoEvents()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, gAplicacao)
        End Try

    End Sub

    Public Function ValidaVersao(ByVal sVersao As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaVersao = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "versao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = sVersao : i += 1

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_administracao_versao", oSqlParameter), String)

            'Seta Retorno da Função
            ValidaVersao = IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadVersaoAplicativo()
        Try
            'Váriaveis Locais
            Dim oSqlDataReader As SqlDataReader
            Dim oSqlParameter(0) As SqlParameter
            Dim i As Integer = 0

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Abre o Data Reader
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_aplicativo", oSqlParameter)

            Dim sReturn As String = ""

            If oSqlDataReader.Read Then

                sReturn = oSqlDataReader.Item("versao")

            End If

   
            oSqlDataReader.Close()

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub VerificaVersaoAplicativo()

        Try



                'Váriaveis Locais
                Dim oSqlDataReader As SqlDataReader
                Dim oSqlParameter(0) As SqlParameter
                Dim i As Integer = 0

                'Seta Parametros - Código da Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Abre o Data Reader
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_aplicativo", oSqlParameter)

                'Verifica se foi Encontrado algum Registro
                If oSqlDataReader.HasRows Then

                    While oSqlDataReader.Read

                        If oSqlDataReader.Item("versao") <> Application.ProductVersion.ToString Then

                            If File.Exists(oSqlDataReader.Item("aplicativo")) = False Then
                                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Executável não encontrado, ou seu login não possui direito de acesso")
                            End
                            End If

                            'Renomeia a versão antiga
                            If System.IO.File.Exists(ApplicationPath() & "INTERACTI.exe") Then
                                Dim oFile As New System.IO.FileInfo(ApplicationPath() & "INTERACTI.exe")



                                For iTentativa As Integer = 0 To 10
                                    Try
                                        System.IO.File.Move(ApplicationPath() & "INTERACTI.exe", ApplicationPath() & "INTERACTI" & Now.Year & "_" & Now.Month & "_" & Now.Hour & "_" & Now.Minute & ".exe")
                                        Exit For
                                    Catch ex As Exception

                                        Threading.Thread.Sleep(10000)
                                        frmMain.Informacao("           Tentativa " & CStr(iTentativa) & " de 10", Color.Red)
                                        Application.DoEvents()
                                    End Try

                                Next

                                oFile = Nothing
                            End If

                            'Renomeia a versão antiga
                            'If System.IO.File.Exists(ApplicationPath() & "XmlConfig\logo.bmp") Then
                            '    Dim oFile As New System.IO.FileInfo(ApplicationPath() & "XmlConfig\logo.bmp")
                            '    oFile.MoveTo(ApplicationPath() & "XmlConfig\logo" & Now.Year & "_" & Now.Month & "_" & Now.Hour & "_" & Now.Minute & ".bmp")
                            '    oFile = Nothing
                            'End If

                            'Copia o novo Executável
                            Cursor.Current = Cursors.WaitCursor
                            System.IO.File.Copy(oSqlDataReader.Item("aplicativo"), ApplicationPath() & "INTERACTI.exe")
                            'If File.Exists(ApplicationPath() & "XmlConfig\logo.bmp") Then File.Delete(ApplicationPath() & "XmlConfig\logo.bmp") : System.IO.File.Copy(oSqlDataReader.Item("aplicativo").ToString.Replace("INTERACTI.exe", "XmlConfig\logo.bmp").Replace("AGROACTI.exe", "XmlConfig\logo.bmp"), ApplicationPath() & "XmlConfig\logo.bmp")
                            'If File.Exists(ApplicationPath() & "Boleto.Net.pdb") Then File.Delete(ApplicationPath() & "Boleto.Net.pdb") : System.IO.File.Copy(oSqlDataReader.Item("aplicativo").ToString.Replace("INTERACTI.exe", "Boleto.Net.pdb").Replace("AGROACTI.exe", "Boleto.Net.pdb"), ApplicationPath() & "Boleto.Net.pdb")
                            Cursor.Current = Cursors.Default

                            'Informa o Usuário sobre o sucesso da Operação
                            MsgBox("Versão atualizada com sucesso! Reabra o sistema para que as alterações tenham efeitos!", MsgBoxStyle.Information, "Alteração de Versão")

                            'Fecha o Sistema
                            End

                        End If

                    End While

            
                'Fecha o SqlDataReader
                If Not oSqlDataReader.IsClosed Then oSqlDataReader.Close()

                'Exclui Arquivos Anteriores
                For Each sFile As String In Directory.GetFiles(ApplicationPath())
                    If sFile.Contains("INTERACTI" & Format(Now.Date, "yyyy")) Or sFile.Contains("INTERACTI" & Format(DateAdd(DateInterval.Year, -1, Now.Date), "yyyy")) Then

                        Try
                            File.Delete(sFile)
                        Catch ex As Exception


                        End Try

                    End If
                    'If sFile.Contains("XmlConfig\logo" & Format(Now.Date, "yyyy")) Or sFile.Contains("XmlConfig\logo" & Format(DateAdd(DateInterval.Year, -1, Now.Date), "yyyy")) Then
                    '    File.Delete(sFile)
                    'End If
                Next

            End If
        Catch SqlEx As SqlException
            MsgBox(SqlEx.Message)
            End
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try

    End Sub

    Public Sub EmailFinanceiroAvisoPrazo()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_email_aviso_receitas_atraso", oSqlParameter)
            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_email_aviso_despesas_atraso", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
