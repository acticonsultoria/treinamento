Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Data.OleDb

Public Class usrFinImportacaoExtrato

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinImportacaoExtrato As New clsUsrFinImportacaoExtrato
    Private iCodigoTituloCapa As Integer
    Private iCodigoBanco As Integer
    Private sNumeroParcela As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroParcela() As String
        Get
            Return sNumeroParcela
        End Get
        Set(ByVal value As String)
            sNumeroParcela = value
        End Set
    End Property

    Public Property CodigoTituloCapa() As Integer
        Get
            Return iCodigoTituloCapa
        End Get
        Set(ByVal value As Integer)
            iCodigoTituloCapa = value
        End Set
    End Property

    Public Property CodigoBanco() As Integer
        Get
            Return iCodigoBanco
        End Get
        Set(ByVal value As Integer)
            iCodigoBanco = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinImportacaoExtrato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub usrFinImportacaoExtrato_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDespesa)

            'Seta Focu
            cboContaBancariaFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.FinanceiroImportarExtrato
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.FinanceiroImportarExtrato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdArquivo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click
        ExportExcel(grdArquivo)
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDespesa)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            cboContaBancariaFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     Formulario.FinanceiroImportarExtrato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.FinanceiroImportarExtrato, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.FinanceiroImportarExtrato, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Arquivo
            LoadCodigo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FinanceiroReclassificacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReclassificacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroReclassificacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReclassificacao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FinanceiroReclassificacao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            Select Case grdArquivo.CurrentColumn.Key

                Case "documento_referencia_texto" : Call Vinculo()
                Case "limpar_vinculo" : Call LimparVinculo()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados do Registro
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados
            Call Salvar()

            'Valida Dados do Formulário
            If ValidacaoPagar() = True Then

                'Salva Dados do Registro
                Call Pagar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinImportacaoExtrato_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.FinanceiroImportarExtrato, gcDelete)
            btnExcluir.Enabled = VerificaDireito(Formulario.FinanceiroImportarExtrato, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroImportarExtrato, gcPrint)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.FinanceiroImportarExtrato, gcPrint)

            'Carrega Controles
            Call LoadCombo(cboContaBancariaFiltro, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)
            'Carrega Combo da Grid
            Call LoadComboGrid(grdArquivo, "centro_custo", "sp_select_combo_cadastro_basico_centro_custo_extrato " & goUsuario.iEmpresa & ", -1, -1")

            dtpDataInicio.Checked = False
            dtpDataTermino.Checked = False
            dtpDataInicio.Value = Now
            dtpDataTermino.Value = Now
            
            txtData.Text = Now

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.FinanceiroImportarExtrato)
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroImportarExtrato)

           

            'Seta Aba
            tabMain.TabPages.Remove(pagDespesa)

            dtpDataInicio.Checked = False
            dtpDataTermino.Checked = False

            'Seta Focu
            cboContaBancariaFiltro.Focus()

            grdArquivo.RootTable.RowHeight = -1
            grdArquivo.RootTable.Columns("documento_referencia_texto").MaxLines = 5
            grdArquivo.RootTable.Columns("documento_referencia_texto").WordWrap = True

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub LoadCodigo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsFinImportacaoExtrato.ValidaBanco(grdArquivo, _
                                                 cboContaBancaria.SelectedValue)
            'Seta Código do Banco
            Dim lCodigoBanco As Long

            oClsFinImportacaoExtrato.LoadCodigoBanco(cboContaBancaria.SelectedValue, _
                                                     lCodigoBanco)

           
            'Verifica se encontrou o codigo do banco
            If IsNumeric(lCodigoBanco) Then

                Select Case lCodigoBanco

                    Case 341 : ImportarArquivoTxtItau()
                    Case 1 : ImportarArquivoTxtBancoBrasil()
                    Case 237 : ImportarArquivoExcelBradesco()
                    Case 399 : ImportarArquivoExcelHSBC()
                    Case 353 : ImportarArquivoExcelSantander()
                    Case 104 : ImportarArquivoTxtCaixa()
                    Case 33 : ImportarArquivoExcelSantander()
                    Case 748
                        If MsgBox("Arquivo excel?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                            Call ImportarArquivoExcelSicredi()

                        Else

                            Call ImportarArquivoTxtSicredi()

                        End If

                End Select

            End If

            'Carrega Combo da Grid
            Call LoadComboGrid(grdArquivo, "centro_custo", "sp_select_combo_cadastro_basico_centro_custo_extrato " & goUsuario.iEmpresa & ", -1, -1")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsFinImportacaoExtrato.LoadGrid(grdListagem, _
                                              IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                              IIf(dtpDataInicio.Checked = False, "", dtpDataInicio.Value), _
                                              IIf(dtpDataTermino.Checked = False, "", dtpDataTermino.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarArquivoExcelBradesco()

        If Validacao() = True Then

            Try

                'Váriaveis Locais
                Dim oArquivoExcel As New OpenFileDialog

                'Seta Dados do OpenFileDialog
                oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
                oArquivoExcel.InitialDirectory = "c:\\DADOS"

                'Verifica se foi Selecionado algum Arquivo
                If oArquivoExcel.ShowDialog = DialogResult.OK Then

                    'Seta Controles
                    txtArquivo.Text = oArquivoExcel.FileName

                End If

                Call oClsFinImportacaoExtrato.ImportarExtratoBradesco(cboContaBancaria.SelectedValue, _
                                                                      txtArquivo.Text, _
                                                                      dtpDataInicio.Value)

                Call oClsFinImportacaoExtrato.ImportarExtratoArquivoBradesco(txtArquivo.Text.Trim)

                Call oClsFinImportacaoExtrato.LoadGridMovimento(grdArquivo)

               


            Catch ex As Exception
                Throw ex
            End Try

        End If
    End Sub

    Private Sub ImportarArquivoExcelSantander()

        Try

            If Validacao() = False Then Exit Sub

            'Váriaveis Locais
            Dim oArquivoExcel As New OpenFileDialog

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
            oArquivoExcel.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Seta Controles
                txtArquivo.Text = oArquivoExcel.FileName

            End If

            oClsFinImportacaoExtrato.ImportarExtratoSantander(cboContaBancaria.SelectedValue, _
                                                              txtArquivo.Text, _
                                                              dtpDataInicio.Value)

            oClsFinImportacaoExtrato.ImportarExtratoArquivoSantander(txtArquivo.Text.Trim)

            oClsFinImportacaoExtrato.ImportarExtratoArquivoVinculoAutomatico()

            oClsFinImportacaoExtrato.LoadGridMovimento(grdArquivo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarArquivoExcelHSBC()

        If Validacao() = True Then

            Try

                'Váriaveis Locais
                Dim oArquivoExcel As New OpenFileDialog

                'Seta Dados do OpenFileDialog
                oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
                oArquivoExcel.InitialDirectory = "c:\\DADOS"

                'Verifica se foi Selecionado algum Arquivo
                If oArquivoExcel.ShowDialog = DialogResult.OK Then

                    'Seta Controles
                    txtArquivo.Text = oArquivoExcel.FileName

                End If

                Call oClsFinImportacaoExtrato.ImportarExtratoHSBC(cboContaBancaria.SelectedValue, _
                                                                      txtArquivo.Text, _
                                                                      dtpDataInicio.Value)

                Call oClsFinImportacaoExtrato.ImportarExtratoArquivoHSBC(txtArquivo.Text.Trim)

                Call oClsFinImportacaoExtrato.LoadGridMovimento(grdArquivo)

            Catch ex As Exception
                Throw ex
            End Try

        End If
    End Sub

    Private Sub ImportarArquivoExcelSicredi()

        If Validacao() = True Then

            Try

                'Váriaveis Locais
                Dim oArquivoExcel As New OpenFileDialog

                'Seta Dados do OpenFileDialog
                oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
                oArquivoExcel.InitialDirectory = "c:\\DADOS"

                'Verifica se foi Selecionado algum Arquivo
                If oArquivoExcel.ShowDialog = DialogResult.OK Then

                    'Seta Controles
                    txtArquivo.Text = oArquivoExcel.FileName

                End If

                Call oClsFinImportacaoExtrato.ImportarExtratoSicrediE(cboContaBancaria.SelectedValue, _
                                                                      txtArquivo.Text, _
                                                                      dtpDataInicio.Value)

                Call oClsFinImportacaoExtrato.ImportarExtratoArquivoSicrediE(txtArquivo.Text.Trim)

                Call oClsFinImportacaoExtrato.LoadGridMovimento(grdArquivo)




            Catch ex As Exception
                Throw ex
            End Try

        End If

    End Sub

    Private Sub ImportarArquivoTxtCaixa()
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            Dim AbrirComo As OpenFileDialog = New OpenFileDialog()
            Dim caminho As DialogResult
            Dim fluxoTexto As IO.StreamReader
            Dim Arquivo As String
            Dim linhaTexto As String
            Dim texto As String
            Dim nomeArquivo As String = ""
            Dim oArquivoExcel As New OpenFileDialog
            Dim iCodigo As Integer = 0

            AbrirComo.Title = "Abrir como"
            AbrirComo.FileName = "Nome Arquivo"
            AbrirComo.Filter = "Arquivos Textos (*.txt)|*.txt"
            caminho = AbrirComo.ShowDialog
            Arquivo = AbrirComo.FileName
            txtArquivo.Text = AbrirComo.FileName

            If txtArquivo.Text = Nothing Then
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
            Else

                'cria um novo objeto StreamReader
                Dim objReader As New StreamReader(Arquivo, System.Text.Encoding.Default)

                dt.Columns.Add("numero_documento", "".GetType)
                dt.Columns.Add("descricao", "".GetType)
                dt.Columns.Add("data", Now.GetType)
                dt.Columns.Add("tipo", "".GetType)
                dt.Columns.Add("valor", 0.0.GetType)
                dt.Columns.Add("saldo", 0.0.GetType)
                dt.Columns.Add("documento_referencia", "".GetType)
                dt.Columns.Add("documento_referencia_texto", "".GetType)
                dt.Columns.Add("codigo", 0.GetType)
                dt.Columns.Add("banco_conta_transferencia", "".GetType)
                dt.Columns.Add("codigo_banco_conta_transferencia", 0.GetType)


                Dim iLinha As Integer = 0
                Dim bFlag As Boolean = False

                'percorre o arquivo
                Do While objReader.Peek() <> -1
                    linhaTexto = objReader.ReadLine()
                    iLinha += 1

                    If iLinha < 0 Then

                        Continue Do

                    End If

                    If ((linhaTexto.Substring(0, 6).Trim).Contains("Conta")) Then

                        Continue Do

                    End If

                    Dim sVetorLinha() As String

                    sVetorLinha = linhaTexto.Trim.Split(";")

                    row = dt.Rows.Add
                    row("data") = DateTime.ParseExact(sVetorLinha(1).Replace("""", ""), "yyyyMMdd", Nothing)
                    row("numero_documento") = sVetorLinha(2).Replace("""", "")
                    row("descricao") = sVetorLinha(3).Replace("""", "")
                    row("valor") = sVetorLinha(4).Replace(".", ",").Replace("""", "")
                    If sVetorLinha(5).Replace("""", "") = "D" Then
                        row("tipo") = "DESPESA"
                    Else
                        row("tipo") = "RECEITA"
                    End If

                    'atribui ao datagridview o objeto datatable criado
                    grdArquivo.DataSource = dt

                    Call oClsFinImportacaoExtrato.ImportarExtratoCaixa(cboContaBancaria.SelectedValue, _
                                                                       txtArquivo.Text, _
                                                                       dtpDataInicio.Value)

                    Call oClsFinImportacaoExtrato.ImportarExtratoArquivoCaixa(grdArquivo)

                    row("codigo") = oClsFinImportacaoExtrato.CodigoPai

                    If bFlag = True Then
                        Exit Do
                    End If
                Loop
            End If

            frmMain.Informacao(Mensagem.RegistroInserido)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
     
    Private Sub ImportarArquivoTxtSicredi()
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            Dim AbrirComo As OpenFileDialog = New OpenFileDialog()
            Dim caminho As DialogResult
            Dim fluxoTexto As IO.StreamReader
            Dim Arquivo As String
            Dim linhaTexto As String
            Dim texto As String
            Dim nomeArquivo As String = ""
            Dim oArquivoExcel As New OpenFileDialog
            Dim iCodigo As Integer = 0

            AbrirComo.Title = "Abrir como"
            AbrirComo.FileName = "Nome Arquivo"
            AbrirComo.Filter = "Arquivos Textos (*.txt)|*.txt"
            caminho = AbrirComo.ShowDialog
            Arquivo = AbrirComo.FileName
            txtArquivo.Text = AbrirComo.FileName

            If txtArquivo.Text = Nothing Then
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
            Else

                'cria um novo objeto StreamReader
                Dim objReader As New StreamReader(Arquivo, System.Text.Encoding.Default)

                dt.Columns.Add("numero_documento", "".GetType)
                dt.Columns.Add("descricao", "".GetType)
                dt.Columns.Add("data", Now.GetType)
                dt.Columns.Add("tipo", "".GetType)
                dt.Columns.Add("valor", 0.0.GetType)
                dt.Columns.Add("saldo", 0.0.GetType)
                dt.Columns.Add("documento_referencia", "".GetType)
                dt.Columns.Add("documento_referencia_texto", "".GetType)
                dt.Columns.Add("codigo", 0.GetType)
                dt.Columns.Add("banco_conta_transferencia", "".GetType)
                dt.Columns.Add("codigo_banco_conta_transferencia", 0.GetType)
                dt.Columns.Add("centro_custo", 0.GetType)

                Dim iLinha As Integer = 0
                Dim bFlag As Boolean = False

                'percorre o arquivo
                Do While objReader.Peek() <> -1
                    linhaTexto = objReader.ReadLine()
                    iLinha += 1

                    If iLinha < 13 Then

                        Continue Do

                    End If

                    If ((linhaTexto.Substring(29, 25).Trim).Contains("Saldo")) Or ((linhaTexto.Substring(29, 25).Trim).Contains("S A L D O")) Then

                        Continue Do

                    End If

                    If IsDate(linhaTexto.Substring(2, 10)) Then

                        bFlag = True

                        row = dt.Rows.Add
                        If (linhaTexto.Substring(73, 13).Trim) = "" Then
                            row("tipo") = "RECEITA"

                            row("valor") = linhaTexto.Substring(92, 13).Replace(".", "")
                            Try
                                row("saldo") = linhaTexto.Substring(105, 25).Replace(".", "")
                            Catch ex2 As Exception
                                row("saldo") = DBNull.Value
                            End Try
                        Else
                            row("tipo") = "DESPESA"
                            row("valor") = linhaTexto.Substring(73, 13).Replace(".", "")
                            Try
                                row("saldo") = linhaTexto.Substring(105, 25).Replace(".", "")
                            Catch ex2 As Exception
                                row("saldo") = DBNull.Value
                            End Try

                        End If
                        row("data") = linhaTexto.Substring(2, 10)
                        row("numero_documento") = linhaTexto.Substring(13, 14).Trim
                        row("descricao") = linhaTexto.Substring(27, 46).Trim
                    Else
                        If bFlag = True Then
                            Exit Do
                        End If
                    End If

                Loop

                'atribui ao datagridview o objeto datatable criado
                grdArquivo.DataSource = dt


                Call oClsFinImportacaoExtrato.ImportarExtratoSicredi(cboContaBancaria.SelectedValue, _
                                                                      txtArquivo.Text, _
                                                                      dtpDataInicio.Value)

                Call oClsFinImportacaoExtrato.ImportarExtratoArquivoSicredi(grdArquivo)

                Call oClsFinImportacaoExtrato.LoadGridMovimento(grdArquivo)

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarArquivoTxtItau()
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            Dim AbrirComo As OpenFileDialog = New OpenFileDialog()
            Dim caminho As DialogResult
            Dim fluxoTexto As IO.StreamReader
            Dim Arquivo As String
            Dim linhaTexto As String
            Dim texto As String
            Dim nomeArquivo As String = ""
            Dim oArquivoExcel As New OpenFileDialog
            Dim iCodigo As Integer = 0

            AbrirComo.Title = "Abrir como"
            AbrirComo.FileName = "Nome Arquivo"
            AbrirComo.Filter = "Arquivos Textos (*.txt)|*.txt"
            caminho = AbrirComo.ShowDialog
            Arquivo = AbrirComo.FileName
            txtArquivo.Text = AbrirComo.FileName

            If txtArquivo.Text = Nothing Then
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
            Else

                'cria um novo objeto StreamReader
                Dim objReader As New StreamReader(Arquivo, System.Text.Encoding.Default)

                dt.Columns.Add("numero_documento", "".GetType)
                dt.Columns.Add("descricao", "".GetType)
                dt.Columns.Add("data", Now.GetType)
                dt.Columns.Add("tipo", "".GetType)
                dt.Columns.Add("valor", 0.0.GetType)
                dt.Columns.Add("saldo", 0.0.GetType)
                dt.Columns.Add("documento_referencia", "".GetType)
                dt.Columns.Add("documento_referencia_texto", "".GetType)
                dt.Columns.Add("codigo", 0.GetType)
                dt.Columns.Add("banco_conta_transferencia", "".GetType)
                dt.Columns.Add("codigo_banco_conta_transferencia", 0.GetType)


                Dim iLinha As Integer = 0
                Dim bFlag As Boolean = False

                'percorre o arquivo
                Do While objReader.Peek() <> -1
                    linhaTexto = objReader.ReadLine()
                    iLinha += 1

                    If iLinha < 0 Then

                        Continue Do

                    End If

                    If ((linhaTexto.Substring(11, 24).Trim).Contains("Saldo")) Or ((linhaTexto.Substring(11, 24).Trim).Contains("S A L D O")) Then

                        Continue Do

                    End If

                    If IsDate(linhaTexto.Substring(0, 10)) Then

                        bFlag = True
                        iCodigo += 1
                        row = dt.Rows.Add
                        row("codigo") = iCodigo
                        row("data") = linhaTexto.Substring(0, 10)
                        row("descricao") = linhaTexto.Substring(11, 24).Trim
                        If linhaTexto.Substring(36, 1).Trim = "-" Then
                            row("tipo") = "DESPESA"
                            row("valor") = linhaTexto.Substring(37)
                        Else
                            row("tipo") = "RECEITA"
                            row("valor") = linhaTexto.Substring(36)
                        End If
                        row("numero_documento") = "-"
                        row("saldo") = DBNull.Value

                    Else
                        If bFlag = True Then
                            Exit Do
                        End If
                    End If

                    'atribui ao datagridview o objeto datatable criado
                    grdArquivo.DataSource = dt

                Loop

                Call oClsFinImportacaoExtrato.ImportarExtratoItau(cboContaBancaria.SelectedValue, _
                                                                      txtArquivo.Text, _
                                                                      dtpDataInicio.Value)

                Call oClsFinImportacaoExtrato.ImportarExtratoArquivoItau(grdArquivo)

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarArquivoTxtBancoBrasil()
        Dim iLinha As Integer = 0
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            Dim AbrirComo As OpenFileDialog = New OpenFileDialog()
            Dim caminho As DialogResult
            Dim fluxoTexto As IO.StreamReader
            Dim Arquivo As String
            Dim linhaTexto As String
            Dim texto As String
            Dim nomeArquivo As String = ""
            Dim iCodigo As Integer = 0

            AbrirComo.Title = "Abrir como"
            AbrirComo.FileName = "Nome Arquivo"
            AbrirComo.Filter = "Arquivos Textos (*.txt)|*.txt"
            caminho = AbrirComo.ShowDialog
            Arquivo = AbrirComo.FileName
            txtArquivo.Text = AbrirComo.FileName

            If txtArquivo.Text = Nothing Then
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
            Else

                'cria um novo objeto StreamReader
                Dim objReader As New StreamReader(Arquivo, System.Text.Encoding.Default)

                dt.Columns.Add("numero_documento", "".GetType)
                dt.Columns.Add("descricao", "".GetType)
                dt.Columns.Add("data", Now.GetType)
                dt.Columns.Add("tipo", "".GetType)
                dt.Columns.Add("valor", 0.0.GetType)
                dt.Columns.Add("saldo", 0.0.GetType)
                dt.Columns.Add("documento_referencia", "".GetType)
                dt.Columns.Add("documento_referencia_texto", "".GetType)
                dt.Columns.Add("codigo", 0.GetType)
                dt.Columns.Add("banco_conta_transferencia", "".GetType)
                dt.Columns.Add("codigo_banco_conta_transferencia", 0.GetType)


                Dim bFlag As Boolean = False

                'percorre o arquivo
                Do While objReader.Peek() <> -1
                    linhaTexto = objReader.ReadLine()
                    iLinha += 1

                    'If iLinha <= 13 Then

                    '    Continue Do

                    'End If

                
                    If iLinha < 5 Then
                        Continue Do
                    End If

                    If linhaTexto.Trim = "" Then
                        Continue Do
                    End If

                    If linhaTexto.Length < 13 Then
                        Continue Do
                    End If

                    If Not IsDate(linhaTexto.Substring(3, 10)) Then
                        Continue Do
                    End If

                    If ((linhaTexto.Substring(0, 19).Trim).Contains("Lançamentos futuros")) Then
                        Exit Do
                    End If

                    If Len(linhaTexto) > 5 And Len(linhaTexto.Trim) = 0 Then
                        Continue Do
                    End If

                    If ((linhaTexto.Substring(15, 11).Trim).ToUpper.Contains("OBSERVAÇÕES")) Then
                        Exit Do
                    End If
                    If ((linhaTexto.Substring(30, 6).Trim).ToUpper.Contains("TARIFA")) Then
                        Continue Do
                    End If

                    If linhaTexto.Length < 43 Then
                        Continue Do
                    End If

                    If ((linhaTexto.Substring(29, 14).Trim).ToUpper.Contains("SALDO")) Or ((linhaTexto.Substring(29, 14).Trim).ToUpper.Contains("S A L D O")) Or linhaTexto.Substring(64, 14).ToUpper.Contains("SALDO") Then


                        Continue Do

                    End If

                    If IsDate(linhaTexto.Substring(3, 10)) Then

                        bFlag = True

                        row = dt.Rows.Add
                        iCodigo += 1
                        row("codigo") = iCodigo
                        row("data") = linhaTexto.Substring(3, 10)
                        If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
                            row("descricao") = linhaTexto.Substring(64, 25).Trim
                            row("numero_documento") = linhaTexto.Substring(95, 19).Trim
                            If (linhaTexto.Substring(115, 15).Trim) = "" Then
                                row("valor") = "0,00"
                            Else
                                row("valor") = linhaTexto.Substring(115, 15)
                            End If
                            If (linhaTexto.Substring(130, 1).Trim) = "C" Then
                                row("tipo") = "RECEITA"
                            ElseIf (linhaTexto.Substring(130, 1).Trim) = "D" Then
                                row("tipo") = "DESPESA"
                            Else
                                row("tipo") = "RECEITA"
                                row("valor") = linhaTexto.Substring(115, 15) / 100
                            End If
                            If (linhaTexto.Substring(132, 15).Trim) = "" Then
                                row("saldo") = DBNull.Value
                            Else
                                row("saldo") = linhaTexto.Substring(132, 15)
                            End If
                        Else
                            row("descricao") = linhaTexto.Substring(29, 25).Trim
                            row("numero_documento") = linhaTexto.Substring(55, 19).Trim
                            If (linhaTexto.Substring(75, 15).Trim) = "" Then
                                row("valor") = "0,00"
                            Else
                                row("valor") = linhaTexto.Substring(75, 15)
                            End If
                            If (linhaTexto.Substring(90, 1).Trim) = "C" Then
                                row("tipo") = "RECEITA"
                            ElseIf (linhaTexto.Substring(90, 1).Trim) = "D" Then
                                row("tipo") = "DESPESA"
                            Else
                                row("tipo") = "RECEITA"
                                row("valor") = linhaTexto.Substring(75, 19) / 100
                            End If
                            If (linhaTexto.Substring(94, 12).Trim) = "" Then
                                row("saldo") = DBNull.Value
                            Else
                                row("saldo") = linhaTexto.Substring(94, 12)
                            End If
                        End If


                       
                        
                       


                    Else
                        If (linhaTexto.Substring(29, 14).Trim) <> "" Then

                            Continue Do
                        Else
                            If bFlag = True Then
                                Exit Do
                            End If
                        End If
                    End If
                Loop

                'atribui ao datagridview o objeto datatable criado
                grdArquivo.DataSource = dt


                Call oClsFinImportacaoExtrato.ImportarExtratoBancoBrasil(cboContaBancaria.SelectedValue, _
                                                                      txtArquivo.Text, _
                                                                      dtpDataInicio.Value)

                Call oClsFinImportacaoExtrato.ImportarExtratoArquivoBancoBrasil(grdArquivo)

            End If

        Catch ex As Exception
            MsgBox("Problemas na linha " + CStr(iLinha) + " ( " + ex.Message + " )")
            Throw ex
        End Try
    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este extrato" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFinImportacaoExtrato.Delete()

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

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboContaBancaria.SelectedIndex = -1
            txtArquivo.Text = ""
            grdArquivo.DataSource = Nothing
            txtData.Text = Date.Now.ToString("dd/MM/yyyy")
            cboContaBancariaFiltro.SelectedIndex = -1
            dtpDataInicio.Checked = False

            'Seta Focu
            cboContaBancaria.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroImportarExtrato, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    grdArquivo.DataSource = Nothing
                    txtArquivo.Text = .Item("arquivo").Value
                    cboContaBancaria.SelectedValue = .Item("banco").Value
                    txtData.Text = Date.Now.ToString("dd/MM/yyyy")
                    oClsFinImportacaoExtrato.Codigo = .Item("codigo_importacao_extrato").Value

                   

                    Call oClsFinImportacaoExtrato.LoadGridMovimentoEditar(grdArquivo, _
                                                                         .Item("codigo_importacao_extrato").Value)
                   

                End With

                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDespesa)

                
                'Seta Focu
                cboContaBancaria.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Vinculo()

        Try

            Dim numeroDocumento As String
            Dim tipo As String

            numeroDocumento = grdArquivo.CurrentRow.Cells("numero_documento").Value
            tipo = grdArquivo.CurrentRow.Cells("tipo").Value

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroImportarExtrato, gcUpdate) = True Then

                If (((numeroDocumento.Trim).Contains("COB0000")) And ((tipo.Trim).Contains("R"))) Then

                    If MsgBox("Esse registro pode estar na importação de boleto! Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                        'MsgBox("Esse registro está na importação de boleto!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, Me.Parent.Text)

                        Dim oForm As New frmFinImportacaoExtratoVinculo

                        oForm.txtNumeroDocumento.Text = grdArquivo.CurrentRow.Cells("numero_documento").Value
                        oForm.txtDescricao.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                        oForm.txtDataEmissao.Text = grdArquivo.CurrentRow.Cells("data").Value
                        oForm.txtValor.Text = grdArquivo.CurrentRow.Cells("valor").Value
                        oForm.txtTipo.Text = grdArquivo.CurrentRow.Cells("tipo").Value
                        oForm.Grid = grdArquivo
                        oForm.CodigoImportacaoExtrato = oClsFinImportacaoExtrato.Codigo

                        'Verifica se foi selecionada a opção 
                        If Not IsDBNull(grdArquivo.CurrentRow.Cells("codigo_banco_conta_transferencia").Value) Then
                            oForm.cboBancoContaTransferencia.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_banco_conta_transferencia").Value
                        End If


                        Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    End If

                Else

                    Dim oForm As New frmFinImportacaoExtratoVinculo

                    oForm.txtNumeroDocumento.Text = grdArquivo.CurrentRow.Cells("numero_documento").Value
                    oForm.txtDescricao.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                    oForm.txtDataEmissao.Text = grdArquivo.CurrentRow.Cells("data").Value
                    oForm.txtValor.Text = grdArquivo.CurrentRow.Cells("valor").Value
                    oForm.txtTipo.Text = grdArquivo.CurrentRow.Cells("tipo").Value
                    oForm.Grid = grdArquivo
                    oForm.CodigoImportacaoExtrato = oClsFinImportacaoExtrato.Codigo

                    'Verifica se foi selecionada a opção 
                    If Not IsDBNull(grdArquivo.CurrentRow.Cells("codigo_banco_conta_transferencia").Value) Then
                        oForm.cboBancoContaTransferencia.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_banco_conta_transferencia").Value
                    End If


                    Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                End If

                Call Salvar()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimparVinculo()

        Try

            With grdArquivo.CurrentRow.Cells

                grdArquivo.SetValue("documento_referencia", DBNull.Value)
                grdArquivo.SetValue("documento_referencia_texto", DBNull.Value)
                grdArquivo.SetValue("centro_custo", DBNull.Value)

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Salvar()
        Try
            Dim sVetorLinha() As String
            Dim sVetorColuna() As String

            'Exclui Registro
            oClsFinImportacaoExtrato.DeleteVinculo(oClsFinImportacaoExtrato.Codigo)

            'Percorre os registros
            For Each oRow In grdArquivo.GetDataRows

                'Verifica se foi setado o vinculo
                If IsDBNull(oRow.Cells.Item("documento_referencia").Value) Then
                    Continue For
                End If


                sVetorLinha = oRow.Cells.Item("documento_referencia").Value.ToString.Split(";")

                For iLinha As Integer = 0 To sVetorLinha.Count - 1

                    'Quebra o vetor
                    sVetorColuna = sVetorLinha(iLinha).ToString.Split("|")

                    ' 0 - Codigo Titulo Capa
                    ' 1 - Numero Parcela

                    'Salva
                    Call oClsFinImportacaoExtrato.Salvar(sVetorColuna(0), _
                                                         sVetorColuna(1), _
                                                         oRow.Cells.Item("codigo").Value, _
                                                         IIf(IsDBNull(oRow.Cells.Item("codigo_banco_conta_transferencia").Value), -1, oRow.Cells.Item("codigo_banco_conta_transferencia").Value),
                                                         IIf(IsDBNull(oRow.Cells.Item("centro_custo").Value), -1, oRow.Cells.Item("centro_custo").Value))
                Next
            Next
            frmMain.Informacao(Mensagem.RegistroInserido)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Pagar()
        Try

            'Verifica se o Usuário Deseja Excluir os Registros Selecionados
            If MsgBox("Deseja fazer as baixas desses documentos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then



                Call oClsFinImportacaoExtrato.Pagar(oClsFinImportacaoExtrato.Codigo)



                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Conta Contábil
            If cboContaBancaria.SelectedIndex = -1 Then
                frmMain.errInfo.SetError(lblArquivo, "Primeiramente selecione uma conta bancária.")
                cboContaBancaria.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoPagar() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPagar = False

            'If IsDBNull(grdArquivo.CurrentRow.Cells("documento_referencia").Value) Then
            '    frmMain.errInfo.SetError(grdArquivo, "Primeiramente vincule todos os documentos.")
            '    Exit Function
            'End If

            'Seta Retorno da Função
            ValidacaoPagar = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function



#End Region

#End Region


End Class

