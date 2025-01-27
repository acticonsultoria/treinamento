Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO

Public Class usrImpNCMIBPT

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadNCMImposto As New clsUsrImpNCMIBPT

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrImpNCMIBPT_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrImpNCMIBPT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter : Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: NCM :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ImpostoNCMIBPT
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoNCMIBPT)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivoExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Atualiza Dados - Configuração Arquivo Excel
                oClsCadNCMImposto.UpdateConfiguracaoArquivoExcel(IIf(cboColunaNCM.SelectedIndex = -1, "", cboColunaNCM.SelectedValue), _
                                                                 IIf(cboEXTipi.SelectedIndex = -1, "", cboEXTipi.SelectedValue), _
                                                                 IIf(cboColunaImpostoFederalNacional.SelectedIndex = -1, "", cboColunaImpostoFederalNacional.SelectedValue), _
                                                                 IIf(cboColunaImpostoFederalImportado.SelectedIndex = -1, "", cboColunaImpostoFederalImportado.SelectedValue), _
                                                                 IIf(cboColunaImpostoEstadual.SelectedIndex = -1, "", cboColunaImpostoEstadual.SelectedValue), _
                                                                 IIf(cboColunaImpostoMunicipal.SelectedIndex = -1, "", cboColunaImpostoMunicipal.SelectedValue), _
                                                                 IIf(cboColunaVigenciaInicio.SelectedIndex = -1, "", cboColunaVigenciaInicio.SelectedValue), _
                                                                 IIf(cboColunaVigenciaTermino.SelectedIndex = -1, "", cboColunaVigenciaTermino.SelectedValue), _
                                                                 IIf(cboColunaChave.SelectedIndex = -1, "", cboColunaChave.SelectedValue), _
                                                                 IIf(cboColunaVersao.SelectedIndex = -1, "", cboColunaVersao.SelectedValue), _
                                                                 IIf(cboColunaFonte.SelectedIndex = -1, "", cboColunaFonte.SelectedValue), _
                                                                 txtLinhaInicio.Value)

                'Importa Arquivo Excel
                Call ImportarArquivo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Limpa / Carrega Controles
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Valida Formulário
            If Validacao() = True Then

                'Verifica se o Usuário deseja Salvar o Pedido de Venda (1 por PO)
                If MsgBox("Deseja Salvar as Alíquotas Importadas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Salva 
                    Call Salvar()

                    'Limpa Formulário
                    Call Novo()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ImpostoNCMIBPT)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ImpostoNCMIBPT, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.ComercialIntegracaoEmbraer, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: NCM :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrImpNCMIBPT_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox            
            Dim oComboBox(10) As UIComboBox
            oComboBox(0) = cboColunaNCM : oComboBox(1) = cboColunaImpostoFederalNacional
            oComboBox(2) = cboColunaImpostoFederalImportado : oComboBox(3) = cboColunaImpostoEstadual
            oComboBox(4) = cboColunaImpostoMunicipal : oComboBox(5) = cboColunaVigenciaInicio
            oComboBox(6) = cboColunaVigenciaTermino : oComboBox(7) = cboColunaChave
            oComboBox(8) = cboColunaVersao : oComboBox(9) = cboColunaFonte
            oComboBox(10) = cboEXTipi
            Call LoadComboAZ(oComboBox)

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ImpostoNCMIBPT, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.ImpostoNCMIBPT, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ImpostoNCMIBPT, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoNCMIBPT)

            Call oClsCadNCMImposto.LoadControles(cboColunaNCM, _
                                                 cboEXTipi, _
                                                 cboColunaImpostoFederalNacional, _
                                                 cboColunaImpostoFederalImportado, _
                                                 cboColunaImpostoEstadual, _
                                                 cboColunaImpostoMunicipal, _
                                                 cboColunaVigenciaInicio, _
                                                 cboColunaVigenciaTermino, _
                                                 cboColunaChave, _
                                                 cboColunaVersao, _
                                                 cboColunaFonte, _
                                                 txtLinhaInicio)

            'Seta Focu
            btnArquivo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Carrega Controles
            Call oClsCadNCMImposto.LoadControles(cboColunaNCM, _
                                                 cboEXTipi, _
                                                 cboColunaImpostoFederalNacional, _
                                                 cboColunaImpostoFederalImportado, _
                                                 cboColunaImpostoEstadual, _
                                                 cboColunaImpostoMunicipal, _
                                                 cboColunaVigenciaInicio, _
                                                 cboColunaVigenciaTermino, _
                                                 cboColunaChave, _
                                                 cboColunaVersao, _
                                                 cboColunaFonte, _
                                                 txtLinhaInicio)

            'Limpa Controles
            txtArquivo.Text = ""
            grdListagem.DataSource = Nothing

            'Seta Focu
            btnArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Salva Pedido
            Call oClsCadNCMImposto.Salvar(grdListagem)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarArquivo()

        Try

            'Váriaveis Locais
            Dim oArquivo As New OpenFileDialog

            'Seta Dados do OpenFileDialog
            oArquivo.Filter = "Arquivo CSV|*.csv"
            oArquivo.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivo.ShowDialog = DialogResult.OK Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDataRow As DataRow
                Dim oDCCodigoNCM As New DataColumn("codigo_ncm")
                Dim oDCEXTipi As New DataColumn("ex_tipi")
                Dim oDCNacionalFederal As New DataColumn("nacional_federal")
                Dim oDCImportadosFederal As New DataColumn("importados_federal")
                Dim oDCEstadual As New DataColumn("estadual")
                Dim oDCMunicipal As New DataColumn("municipal")
                Dim oDCVigenciaInicio As New DataColumn("vigencia_inicio")
                Dim oDCVigenciaTermino As New DataColumn("vigencia_termino")
                Dim oDCChave As New DataColumn("chave")
                Dim oDCVersao As New DataColumn("versao")
                Dim oDCFonte As New DataColumn("fonte")

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCodigoNCM)
                oDataTable.Columns.Add(oDCEXTipi)
                oDataTable.Columns.Add(oDCNacionalFederal)
                oDataTable.Columns.Add(oDCImportadosFederal)
                oDataTable.Columns.Add(oDCEstadual)
                oDataTable.Columns.Add(oDCMunicipal)
                oDataTable.Columns.Add(oDCVigenciaInicio)
                oDataTable.Columns.Add(oDCVigenciaTermino)
                oDataTable.Columns.Add(oDCChave)
                oDataTable.Columns.Add(oDCVersao)
                oDataTable.Columns.Add(oDCFonte)
                'Seta DataType
                oDCNacionalFederal.DataType = 0.0.GetType
                oDCImportadosFederal.DataType = 0.0.GetType
                oDCEstadual.DataType = 0.0.GetType
                oDCMunicipal.DataType = 0.0.GetType
                oDCVigenciaInicio.DataType = Now.GetType
                oDCVigenciaTermino.DataType = Now.GetType

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Try

                    'Seta Controles
                    txtArquivo.Text = oArquivo.FileName

                    'Váriaveis - Arquivo
                    Dim oStreamReader As New StreamReader(txtArquivo.Text)
                    Dim sLinha As String = oStreamReader.ReadLine
                    Dim sVetor() As String
                    Dim sValores() As String
                    Dim i As Integer

                    ReDim sVetor(0)

                    'Verifica quantos registros existe
                    While IsNothing(sLinha) = False
                        sVetor(UBound(sVetor)) = sLinha
                        sLinha = oStreamReader.ReadLine
                        If IsNothing(sLinha) = False Then ReDim Preserve sVetor(UBound(sVetor) + 1)
                    End While

                    'Fecha o Arquivo
                    oStreamReader.Close()

                    'ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = sVetor.Count - txtLinhaInicio.Value + 1
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = True

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value - 1 To UBound(sVetor)

                        sValores = sVetor(i).Split(";")

                        'Seta ProgressBar
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

                        'Adiciona Linha
                        oDataRow = oDataTable.NewRow
                        'Preenche Dados da Linha
                        If cboColunaNCM.SelectedIndex = -1 Then oDataRow("codigo_ncm") = DBNull.Value Else oDataRow("codigo_ncm") = sValores(cboColunaNCM.SelectedIndex)
                        If cboEXTipi.SelectedIndex = -1 Then oDataRow("ex_tipi") = DBNull.Value Else oDataRow("ex_tipi") = sValores(cboEXTipi.SelectedIndex)
                        If cboColunaImpostoFederalNacional.SelectedIndex = -1 Then oDataRow("nacional_federal") = DBNull.Value Else oDataRow("nacional_federal") = sValores(cboColunaImpostoFederalNacional.SelectedIndex) / 100
                        If cboColunaImpostoFederalImportado.SelectedIndex = -1 Then oDataRow("importados_federal") = DBNull.Value Else oDataRow("importados_federal") = sValores(cboColunaImpostoFederalImportado.SelectedIndex) / 100
                        If cboColunaImpostoEstadual.SelectedIndex = -1 Then oDataRow("estadual") = DBNull.Value Else oDataRow("estadual") = sValores(cboColunaImpostoEstadual.SelectedIndex) / 100
                        If cboColunaImpostoMunicipal.SelectedIndex = -1 Then oDataRow("municipal") = DBNull.Value Else oDataRow("municipal") = sValores(cboColunaImpostoMunicipal.SelectedIndex) / 100
                        If cboColunaVigenciaInicio.SelectedIndex = -1 Then oDataRow("vigencia_inicio") = DBNull.Value Else oDataRow("vigencia_inicio") = sValores(cboColunaVigenciaInicio.SelectedIndex)
                        If cboColunaVigenciaTermino.SelectedIndex = -1 Then oDataRow("vigencia_termino") = DBNull.Value Else oDataRow("vigencia_termino") = sValores(cboColunaVigenciaTermino.SelectedIndex)
                        If cboColunaChave.SelectedIndex = -1 Then oDataRow("chave") = DBNull.Value Else oDataRow("chave") = sValores(cboColunaChave.SelectedIndex)
                        If cboColunaVersao.SelectedIndex = -1 Then oDataRow("versao") = DBNull.Value Else oDataRow("versao") = sValores(cboColunaVersao.SelectedIndex)
                        If cboColunaFonte.SelectedIndex = -1 Then oDataRow("fonte") = DBNull.Value Else oDataRow("fonte") = sValores(cboColunaFonte.SelectedIndex)
                        oDataTable.Rows.Add(oDataRow)

                    Next i

                    'Configura DataMember
                    Call ConfigurarDataMemberGrid(grdListagem)

                    'Carrega Grid
                    grdListagem.DataSource = oDataSet.DefaultViewManager
                    grdListagem.DataMember = oDataSet.Tables(0).TableName

                    'Seta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False

                Catch ex As Exception
                    Throw ex
                Finally
                    'Oculta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End Try

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Linha de Início
            If ValidaCampo(txtLinhaInicio, lblLinhaInicio, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Coluna NCM
            If ValidaCampo(cboColunaNCM, lblColunaNCM) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - EX
            If ValidaCampo(cboEXTipi, lblEXTipi) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Imposto Federal Nacional
            If ValidaCampo(cboColunaImpostoFederalNacional, lblColunaImpostoFederalNacional) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Imposto Federal Importados
            If ValidaCampo(cboColunaImpostoFederalImportado, lblColunaImpostoFederalImportado) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Imposto Estadual
            If ValidaCampo(cboColunaImpostoEstadual, lblColunaImpostoEstadual) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Imposto Municipal
            If ValidaCampo(cboColunaImpostoMunicipal, lblColunaImpostoMunicipal) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Vigência Início
            If ValidaCampo(cboColunaVigenciaInicio, lblColunaVigenciaInicio) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Vigência Término
            If ValidaCampo(cboColunaVigenciaTermino, lblColunaVigenciaTermino) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Fonte
            If ValidaCampo(cboColunaFonte, lblColunaFonte) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class


