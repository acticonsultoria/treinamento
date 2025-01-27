Imports Janus.Windows.GridEX

Public Class frmCCBProjectPredecessores

#Region "::: VARIÁVEIS :::"

    Private oClsFrmCCBProjectPredecessores As New clsFrmCCBProjectPredecessores

    Private oGrid As Janus.Windows.GridEX.GridEX
    Private iAtividades() As Integer
    Private iLinha As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

    Public Property Linha() As Integer
        Get
            Return iLinha
        End Get
        Set(ByVal value As Integer)
            iLinha = value
        End Set
    End Property

#End Region
    Public Enum eType
        numero = 1
        texto = 2
    End Enum
#Region "::: CONTROLES :::"

    Private Sub frmCCBProjectPredecessores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub frmCCBProjectPredecessores_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        ''Redimensiona o User Control
        'Me.Top = (frmMain.tabMain.Top + ((frmMain.tabMain.Height - Me.Height) / 2) + gcUserControlAjust)
        'Me.Left = ((frmMain.tabMain.Width - Me.Width) / 2)

    End Sub

    Private Sub frmCCBProjectPredecessores_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Me.Dispose()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Me.Dispose()

    End Sub

    Private Sub btnInserirAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirAtividade.Click

        Try

            'Insere Atividade
            InserirAtividade()

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Try
            Call Limpar()
        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try
    End Sub
    Private Sub grdListagem_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.CellValueChanged
        Try
            If e.Column.Key = "tipo" Or e.Column.Key = "duracao" Then
                grdListagem.CurrentRow.CheckState = RowCheckState.Checked
            End If
        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try
    End Sub

#End Region

#Region "::: SUB´S / FUNCTION´S :::"

    Private Sub Limpar()

        Try

            Call LimpaGridUnbound(grdListagem)
            Call LoadItens()
            oGrid.SetValue("predecessores", "")

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
            Dim sPais() As String
            Dim iContPais As Integer
            Dim iCont As Integer
            Dim sSequencia() As String
            Dim sFormula() As String
            Dim bFlag As Boolean = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Call LoadComboGrid(grdListagem, "tipo", "sp_select_combo_ccb_tipo_predecessora")
          
            'Recebendo o vetor dos pais
            sPais = oGrid.GetDataRows(iLinha).Cells.Item("pais").Text.Split(";")
            If TratarCampoGrid(oGrid.GetValue("predecessores"), eType.texto) <> "" Then

                'Quebrando a fórmula
                sFormula = Mid(oGrid.GetValue("predecessores"), 1, Len(oGrid.GetValue("predecessores")) - 1).Split(";")

                For iCont = 0 To sFormula.Length - 1
                    sSequencia = sFormula(iCont).Split(",")
                    'Adicionando os itens
                    grdListagem.AddItem(False, _
                                        sSequencia(0), _
                                        "", _
                                         LTrim(oGrid.GetRow(CInt(sSequencia(0)) - 1).Cells.Item("atividade").Text), _
                                         sSequencia(1), _
                                         sSequencia(2), _
                                         0).CheckState = RowCheckState.Checked



                    'Se tiver pais
                    If Not sPais Is Nothing Then

                        'Percorrendo o vetor
                        For iContPais = 0 To sPais.Length - 1

                            'Se o for o pai, não pode ser predecessor, então pinta a linha
                            If sPais(iContPais) = CStr(sSequencia(0)) Then

                                'Setando para o último registro
                                grdListagem.Row = grdListagem.RecordCount - 1
                                grdListagem.SetValue("bloqueado", 1)
                                bFlag = True
                                Exit For
                            End If
                        Next
                    End If

                Next


            Else

                'Se não tiver predecessores
                Call LoadItens()
            End If


            If bFlag = True Then
                frmMain.Informacao("Verificar integridade da fórmula!", Color.Red)
            End If
            'Call LoadAtividades()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(ex.Message, Color.Red)

        End Try

    End Sub

    Public Sub LoadAtividades()

        'Variaveis Locais
        Dim i As Integer

        Try

            'Carrega Grid
            With grdListagem.RootTable.Columns("id").ValueList

                'Limpa Combo
                .Clear()

                For i = (iLinha - 1) To 0 Step -1

                    .Add(i, i)

                Next

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadItens()
        Try

            Dim oRow As Janus.Windows.GridEX.GridEXRow
            Dim sPais() As String
            Dim iContPais As Integer

            'Recebendo o vetor dos pais
            sPais = oGrid.GetDataRows(iLinha).Cells.Item("pais").Text.Split(";")

            'Varrendo cada linha
            For Each oRow In oGrid.GetDataRows
                With oRow.Cells

                    'Verificando se o predecessor tem número maior ou igual à sua sequência
                    If iLinha = oRow.RowIndex Then
                        Continue For
                    End If

                    ''Verificando se o precedessor é de um nível menor
                    'If .Item("nivel").Text < oGrid.GetDataRows(iLinha).Cells.Item("nivel").Text Then
                    '    Continue For
                    'End If

                    'Adicionando os itens
                    grdListagem.AddItem(False, _
                                        oRow.RowIndex + 1, _
                                        oRow.Cells.Item("nivel").Text, _
                                         LTrim(oRow.Cells.Item("atividade").Text), _
                                         "", _
                                         "", _
                                         0)


                    'Se tiver pais
                    If Not sPais Is Nothing Then

                        'Percorrendo o vetor
                        For iContPais = 0 To sPais.Length - 1

                            'Se o for o pai, não pode ser predecessor, então pinta a linha
                            If sPais(iContPais) = CStr(oRow.RowIndex + 1) Then

                                'Setando para o último registro
                                grdListagem.Row = grdListagem.RecordCount - 1
                                grdListagem.SetValue("bloqueado", 1)
                                Exit For
                            End If
                        Next
                    End If

                End With
            Next
          
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
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
    Private Sub InserirAtividade()
        Try

            Dim oRow As Janus.Windows.GridEX.GridEXRow
            Dim sFormula As String = ""



            If grdListagem.GetCheckedRows.Length > 0 Then


                For Each oRow In grdListagem.GetCheckedRows
                    sFormula += CStr(oRow.Cells("id").Text) + "," + _
                                IIf(TratarCampoGrid(oRow.Cells.Item("tipo").Value, eType.texto) = "", "0", CStr(oRow.Cells.Item("tipo").Value)) + "," + _
                                IIf(TratarCampoGrid(oRow.Cells.Item("latencia").Value, eType.texto) = "", "0", CStr(oRow.Cells.Item("latencia").Value)) + ";"

                    If oRow.Cells.Item("bloqueado").Value = 1 Then

                        frmMain.Informacao("A atividade [" & oRow.Cells.Item("atividade").Value & "] não pode ser uma predecessora!", Color.Red)
                        Exit Sub
                    End If

                Next

                oGrid.Row = iLinha
                oGrid.SetValue("predecessores", sFormula)

                Me.Dispose()

            Else
                frmMain.Informacao("Selecione ao menos um predecessor!", Color.Red)
            End If
        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try
    End Sub

#End Region

  
   
End Class