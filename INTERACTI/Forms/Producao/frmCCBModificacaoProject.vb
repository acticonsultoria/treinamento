Imports Janus.Windows.GridEX

Public Class frmCCBModificacaoProject

#Region "::: VARIÁVEIS :::"


    Private lCodigoCB As Long
    Private sEO As String
    Dim oClsFrmCCBModificacaoProject As New clsFrmCCBModificacaoProject

#End Region

    Public Enum eType
        numero = 1
        texto = 2
    End Enum
#Region "::: PROPERTIES :::"

    Public Property CodigoCB() As Long
        Get
            Return lCodigoCB
        End Get
        Set(ByVal value As Long)
            lCodigoCB = value
        End Set
    End Property

    Public Property EO() As String
        Get
            Return sEO
        End Get
        Set(ByVal value As String)
            sEO = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCCBModificacaoProject_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub frmCCB_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        ''Redimensiona o User Control
        'Me.Top = (frmMain.tabMain.Top + ((frmMain.tabMain.Height - Me.Height) / 2) + gcUserControlAjust)
        'Me.Left = ((frmMain.tabMain.Width - Me.Width) / 2)

    End Sub

    Private Sub frmCCB_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Me.Dispose()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Me.Dispose()

    End Sub

    Private Sub grdAtividade_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAtividade.CellUpdated

        Try

            Select Case grdAtividade.CurrentColumn.Key

                Case "atividade"
                    If grdAtividade.RowCount > 0 Then Call LoadDadosAtividade()
                    grdAtividade.SetValue("atividade", Space((CInt(grdAtividade.GetValue("nivel")) - 1) * 4) & grdAtividade.CurrentRow.Cells("atividade").Text)

            End Select

        Catch ex As Exception

        End Try


    End Sub

    Private Sub grdAtividade_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdAtividade.RowDoubleClick

        Try

            'Variaveis Locais
            Dim iNivel As Integer

            Select Case grdAtividade.CurrentColumn.Key

                Case "mais"
                    If e.Row.RowIndex <> 0 Then
                        grdAtividade.Row = e.Row.RowIndex - 1
                        iNivel = CInt(grdAtividade.CurrentRow.Cells("nivel").Text)
                        If (CInt(e.Row.Cells("nivel").Text) + 1) <= (iNivel + 1) Then
                            grdAtividade.Row = e.Row.RowIndex
                            grdAtividade.SetValue("nivel", CInt(IIf(IsNumeric(e.Row.Cells("nivel").Text), e.Row.Cells("nivel").Text, 1)) + 1)
                            grdAtividade.SetValue("atividade", Space((CInt(grdAtividade.GetValue("nivel")) - 1) * 4) & e.Row.Cells("atividade").Text.Trim)
                        End If
                    End If

                Case "menos"
                    If e.Row.RowIndex <> 0 Then
                        If CInt(e.Row.Cells("nivel").Text) > 1 Then
                            grdAtividade.SetValue("nivel", CInt(IIf(IsNumeric(e.Row.Cells("nivel").Text), e.Row.Cells("nivel").Text, 1)) - 1)
                            grdAtividade.SetValue("atividade", Space((CInt(grdAtividade.GetValue("nivel")) - 1) * 4) & e.Row.Cells("atividade").Text.Trim)
                        End If
                    End If

                Case "predecessores"
                    If e.Row.RowIndex <> -1 Then
                        frmCCBProjectPredecessores.Grid = grdAtividade
                        frmCCBProjectPredecessores.Linha = e.Row.RowIndex
                        frmCCBProjectPredecessores.ShowDialog()
                    End If

            End Select

            Call VerificarProject()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub mnuInserirLinhaAcima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInserirLinhaAcima.Click

        Dim iNivel As Integer

        iNivel = grdAtividade.CurrentRow.Cells("nivel").Text
        grdAtividade.Row = grdAtividade.AddItem(grdAtividade.CurrentRow.RowIndex).RowIndex
        grdAtividade.SetValue("nivel", IIf(iNivel = 1, 2, iNivel))
        Call VerificarProject()
    End Sub

    Private Sub mnuInserirLinhaAbaixo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInserirLinhaAbaixo.Click

        Dim iNivel As Integer

        iNivel = grdAtividade.CurrentRow.Cells("nivel").Text
        grdAtividade.Row = grdAtividade.AddItem(grdAtividade.CurrentRow.RowIndex + 1).RowIndex
        grdAtividade.SetValue("nivel", IIf(iNivel = 1, 2, iNivel))

        Call VerificarProject()

    End Sub

    Private Sub mnuExcluirLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExcluirLinha.Click

        grdAtividade.CurrentRow.Delete()
        Call VerificarProject()
    End Sub

    Private Sub mnuInserirAtividadeLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInserirAtividadeLista.Click

        Try

            'Variaveis Locais
            Dim iNivel As Integer

            'Seta Nivel
            iNivel = grdAtividade.CurrentRow.Cells("nivel").Text

            ''Abre Formulário com Lista de Atividade
            'frmCCBListaAtividadeProject.Grid = grdAtividade
            'frmCCBListaAtividadeProject.Nivel = iNivel
            'frmCCBListaAtividadeProject.Linha = grdAtividade.CurrentRow.RowIndex + 1
            'frmCCBListaAtividadeProject.ShowDialog()


            Call VerificarProject()

        Catch ex As Exception

            frmMain.Informacao(ex.Message, Color.Red)

        End Try

    End Sub

    Private Sub grdAtividade_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdAtividade.MouseClick

        If grdAtividade.RowCount > 1 Then
            If grdAtividade.CurrentRow.RowIndex = 0 Then
                mnuInserirLinhaAcima.Enabled = False
                mnuExcluirLinha.Enabled = False
            Else
                mnuInserirLinhaAcima.Enabled = True
                mnuExcluirLinha.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try

            Call Salvar()

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try
    End Sub

    Private Sub btnInserirProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProject.Click
        Try
            'frmCCBListaProject.TxtUsuario = txtUsuario
            'frmCCBListaProject.TxtDataInput = txtDataInput
            'frmCCBListaProject.DtpDataInicio = dtpDataInicio
            'frmCCBListaProject.CodigoCB = lCodigoCB
            'frmCCBListaProject.ShowDialog()

            'If CStr(txtDataInput.Tag) = "" Then Exit Sub

            'Call oClsFrmCCBModificacaoProject.CarregarGrid(txtDataInput.Tag, _
            '                                                grdAtividade)

            'btnSalvar.Enabled = False

            'Call VerificarProject()

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            Call Novo()
        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try
    End Sub

    Private Sub cmdExportarTarefas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportarTarefas.Click
        Try

            ExportarTarefas()

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Sub

#End Region

#Region "::: SUB´S / FUNCTION´S :::"
    Public Function TratarCampoGrid(ByVal sCampo As Object, ByVal eType As eType) As String

        Try

            If eType = eType.numero Then

                If IsDBNull(sCampo) = True Then
                    TratarCampoGrid = "-1"
                ElseIf CStr(sCampo) = "" Then
                    TratarCampoGrid = "-1"
                ElseIf Not IsNumeric(sCampo) = True Then
                    TratarCampoGrid = "-1"
                Else
                    TratarCampoGrid = sCampo
                End If
            ElseIf eType = eType.texto And IsDBNull(sCampo) = True Then
                TratarCampoGrid = ""
            ElseIf sCampo = Nothing Then
                TratarCampoGrid = ""
            Else
                TratarCampoGrid = sCampo
            End If

        Catch ex As Exception
            Throw ex
        End Try


    End Function
    Private Sub Novo()
        Try
            'Capa
            txtDataInput.Text = ""
            txtUsuario.Text = ""
            dtpDataInicio.Value = Now
            txtDataInput.Tag = ""
            Call oClsFrmCCBModificacaoProject.LoadDadosUsuario(goUsuario.iUsuario, txtUsuario)
            txtDataInput.Text = Format(Now, "dd/MM/yyyy")

            btnSalvar.Enabled = True
            LimpaGridUnbound(grdAtividade)
            'Adiciona Linha
            grdAtividade.AddItem("", "", "1", sEO)
            
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub LimpaGridUnbound(ByVal oGrid As Janus.Windows.GridEX.GridEX)

        Try

            'Variaveis Locais
            Dim oRow As GridEXRow

            For Each oRow In oGrid.GetDataRows

                oRow.Delete()

            Next

            'Limpando os itens
            oGrid.ClearItems()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Configura Combo da Grid
            Call LoadComboGrid(grdAtividade, "atividade", "sp_select_combo_ccb_cadastro_atividade_project " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdAtividade, "departamento", "sp_select_combo_ccb_recurso_cb " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdAtividade, "restricao", "sp_select_combo_ccb_cadastro_tipo_restricao")

            'Limpando
            Call Novo()
         

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(ex.Message, Color.Red)

        End Try

    End Sub

    Private Sub LoadDadosAtividade()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(grdAtividade.GetValue("atividade")) Then
                'Adiciona Linha
                oClsFrmCCBModificacaoProject.LoadDadosAtividade(grdAtividade, _
                                                                grdAtividade.GetValue("atividade"))
            End If


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(ex.Message, Color.Red)

        End Try

    End Sub

    Private Sub Salvar()
        Try


            Dim oRow As Janus.Windows.GridEX.GridEXRow

            'Validando as linhas
            If ValidarLinha() = False Then Exit Sub

            'Passagem dos parâmetros
            With oClsFrmCCBModificacaoProject

                .DataInicio = dtpDataInicio.Value
                .DataInput = CDate(txtDataInput.Text)
                .Usuario = txtUsuario.Tag
                .CodigoCB = lCodigoCB
                .InsertCapa()

            End With



            For Each oRow In grdAtividade.GetDataRows

                With oRow.Cells

                    oClsFrmCCBModificacaoProject.Atividade = TratarCampoGrid(.Item("atividade").Value, eType.numero)
                    oClsFrmCCBModificacaoProject.DescricaoAtividade = TratarCampoGrid(.Item("atividade").Text, eType.texto)
                    oClsFrmCCBModificacaoProject.DataRestricao = IIf(Not IsDate(.Item("data_restricao").Value), Date.MinValue, .Item("data_restricao").Value)
                    oClsFrmCCBModificacaoProject.Departamento = TratarCampoGrid(.Item("departamento").Value, eType.numero)
                    oClsFrmCCBModificacaoProject.Nivel = TratarCampoGrid(.Item("nivel").Value, eType.numero)
                    oClsFrmCCBModificacaoProject.PrazoFinal = IIf(Not IsDate(.Item("prazo_final").Value), Date.MinValue, .Item("prazo_final").Value)
                    oClsFrmCCBModificacaoProject.Predecessor = TratarCampoGrid(.Item("predecessores").Value, eType.texto)
                    oClsFrmCCBModificacaoProject.Sequencia = oRow.RowIndex + 1
                    oClsFrmCCBModificacaoProject.Tempo = TratarCampoGrid(.Item("tempo").Value, eType.numero)
                    oClsFrmCCBModificacaoProject.TipoRestricao = TratarCampoGrid(.Item("restricao").Value, eType.numero)
                    oClsFrmCCBModificacaoProject.PorcentagemConcluida = TratarCampoGrid(.Item("porcentagem_concluida").Value, eType.numero)

                    oClsFrmCCBModificacaoProject.InsertLinha()

                End With

            Next
            frmMain.Informacao("Project salvo com sucesso!", Color.Blue)
            btnSalvar.Enabled = False


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarLinha() As Boolean
        Try

            ValidarLinha = False

            Dim oRow As Janus.Windows.GridEX.GridEXRow
            Dim oVetorRow() As Janus.Windows.GridEX.GridEXRow


            'Recebendo o veotr de row
            oVetorRow = grdAtividade.GetDataRows

            ''Varrendo cada linha
            'For Each oRow In oVetorRow
            '    With oRow.Cells

            '        If IsNumeric(.Item("predecessores").Text) Then

            '            'Verificando se o predecessor tem número maior ou igual à sua sequência
            '            If .Item("predecessores").Text >= oRow.RowIndex + 1 Then
            '                frmMain.Informacao("A sequência [" & CStr(oRow.RowIndex + 1) & "] tem predecessor maior ou igual a ela mesma!", Color.Red)
            '                Exit Function
            '            End If

            '            'Verificando se o precedessor é de um nível menor
            '            If .Item("nivel").Text <> oVetorRow(.Item("predecessores").Text - 1).Cells.Item("nivel").Text Then
            '                frmMain.Informacao("A sequência [" & CStr(oRow.RowIndex + 1) & "] tem predecessor de nível diferente!", Color.Red)
            '                Exit Function
            '            End If

            '        End If
            '    End With
            'Next


            ValidarLinha = True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ExportarTarefas()

        Try


            If sfdArquivoProject.ShowDialog() = Windows.Forms.DialogResult.OK Then
                oClsFrmCCBModificacaoProject.ExportarTarefas(grdAtividade, sfdArquivoProject.FileName)

                frmMain.Informacao("Project criado com sucesso!", Color.Blue)

                If MsgBox("Deseja abrir o project criado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Project") = MsgBoxResult.Yes Then

                    Process.Start(sfdArquivoProject.FileName)

                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VerificarProject()
        Try
            Dim oRow() As Janus.Windows.GridEX.GridEXRow = grdAtividade.GetDataRows
            Dim sPais As String = ""
            Dim iContNivel As Integer
            Dim iAtual As Integer = 0
            Dim iCont As Integer

            'Não busca até o último
            For iCont = 0 To oRow.Length - 1
                iAtual = 1000
                sPais = ""

                'Setando o ponteiro
                grdAtividade.Row = iCont

                'O primeiro registro não tem pai
                If iCont > 0 Then

                    'Verificação para receber os pais do nível
                    iContNivel = iCont
                    iAtual = grdAtividade.GetValue("nivel")
                    'Percorrendo de trás para frente
                    While iContNivel > 0
                        'Se o nível for menor (pai)
                        If oRow(iContNivel - 1).Cells.Item("nivel").Value >= 1 Then
                            'Se o nível for menor que atual
                            If oRow(iContNivel - 1).Cells.Item("nivel").Value < iAtual Then
                                'Seta o nível atual
                                iAtual = oRow(iContNivel - 1).Cells.Item("nivel").Value
                                'Concatena a sequência
                                sPais += CStr(iContNivel) + ";"
                            End If
                        End If
                        'Decrementando
                        iContNivel += -1
                    End While

                    'Se tiver pai, "tira" o último ";"
                    If sPais.Length > 0 Then
                        sPais = Mid(sPais, 1, Len(sPais) - 1)
                    End If

                    'Adicionando na grid
                    grdAtividade.SetValue("pais", sPais)

                End If
                'Setando novamente
                grdAtividade.Row = iCont

                'O último nunca pode ser negrito
                If iCont = oRow.Length - 1 Then
                    grdAtividade.SetValue("negrito", 0)

                Else 'Verificação dos outros registros

                    'Se existir um subnível, deixa negrito
                    If oRow(iCont).Cells.Item("nivel").Value < oRow(iCont + 1).Cells.Item("nivel").Value Then
                        grdAtividade.SetValue("negrito", 1)
                        grdAtividade.SetValue("tempo", "")
                        grdAtividade.SetValue("porcentagem_concluida", "")
                    Else
                        grdAtividade.SetValue("negrito", 0)
                    End If
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class