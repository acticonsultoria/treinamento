Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdCenarioConfigurarDias

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdCenario As New clsUsrPrdCenario
    Private iCodigoCenario As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoCenario() As Integer
        Get
            Return iCodigoCenario
        End Get
        Set(ByVal value As Integer)
            iCodigoCenario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub dtpPeriodo_ValueChanged(sender As Object, e As EventArgs) Handles dtpPeriodo.ValueChanged

        Try

            If IsNothing(grdPeriodo.RootTable) Then Exit Sub

            oClsUsrPrdCenario.LoadGridPeriodo(grdPeriodo, _
                                              dtpPeriodo.Value)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdPeriodo_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdPeriodo.RowDoubleClick

        Try

            If IsNothing(grdPeriodo.CurrentColumn) Then Exit Sub

            Select Case grdPeriodo.CurrentColumn.Key

                Case "excluir" : Excluir()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirSabados_Click(sender As Object, e As EventArgs) Handles btnExcluirSabados.Click

        Try

            ExcluirSabados()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirDomingos_Click(sender As Object, e As EventArgs) Handles btnExcluirDomingos.Click

        Try

            ExcluirDomingos()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirFDS_Click(sender As Object, e As EventArgs) Handles btnExcluirFDS.Click

        Try

            ExcluirFinaisDeSemana()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdPeriodo_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdPeriodo.CellValueChanged

        Try

            Select Case grdPeriodo.CurrentColumn.Key

                Case "quantidade_turnos"

                    If IsNumeric(grdPeriodo.GetValue("quantidade_turnos")) = False Then
                        MsgBox("Quantidade de turno inválida", MsgBoxStyle.Exclamation)
                        grdPeriodo.SetValue("quantidade_turnos", 1)
                        Exit Sub
                    End If

                    If grdPeriodo.GetValue("quantidade_turnos") > 3 Then
                        MsgBox("Quantidade de turno inválida", MsgBoxStyle.Exclamation)
                        grdPeriodo.SetValue("quantidade_turnos", 1)
                        Exit Sub
                    End If


            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdPeriodo_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdPeriodo.CellUpdated

        Try

            Select Case grdPeriodo.CurrentColumn.Key

                Case "quantidade_turnos"

                    If IsNumeric(grdPeriodo.GetValue("quantidade_turnos")) = False Then
                        MsgBox("Quantidade de turno inválida", MsgBoxStyle.Exclamation)
                        grdPeriodo.SetValue("quantidade_turnos", 1)
                        Exit Sub
                    End If

                    If grdPeriodo.GetValue("quantidade_turnos") > 3 Then
                        MsgBox("Quantidade de turno inválida", MsgBoxStyle.Exclamation)
                        grdPeriodo.SetValue("quantidade_turnos", 1)
                        Exit Sub
                    End If

                Case "horario_inicio"
                    ValidacaoHorario()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
            LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina -1," & goUsuario.iEmpresa, False)

            dtpPeriodo.Value = Now

            cboMaquina.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboCentroTrabalho, lblCentroTrabalho) = False Then Return False
            If ValidaCampo(cboMaquina, lblMaquina) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            If MsgBox("Deseja salvar esse período?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            For Each oRow As GridEXRow In grdPeriodo.GetDataRows

                oClsUsrPrdCenario.InsertMaquina(iCodigoCenario, _
                                                cboCentroTrabalho.SelectedValue, _
                                                cboMaquina.SelectedValue, _
                                                oRow.Cells("dia").Value & "/" & Month(dtpPeriodo.Value) & "/" & Year(dtpPeriodo.Value), _
                                                oRow.Cells("horas_disponiveis").Value, _
                                                oRow.Cells("horario_inicio").Value, _
                                                oRow.Cells("quantidade_turnos").Value)

            Next

            frmMain.Informacao(Mensagem.RegistroSalvo)

            Cursor.Current = Cursors.Default

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Excluir()

        Try

            If MsgBox("Deseja excluir essa linha?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            grdPeriodo.CurrentRow.Delete()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirSabados()

        Try

            If MsgBox("Deseja excluir todos os sábados do mês?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            For Each oRow As GridEXRow In grdPeriodo.GetDataRows

                Dim sData As String = oRow.Cells("dia").Value & "/" & Month(dtpPeriodo.Value) & "/" & Year(dtpPeriodo.Value)

                If Weekday(sData) = 7 Then
                    oRow.Delete()
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirDomingos()

        Try

            If MsgBox("Deseja excluir todos os domingos do mês?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            For Each oRow As GridEXRow In grdPeriodo.GetDataRows

                Dim sData As String = oRow.Cells("dia").Value & "/" & Month(dtpPeriodo.Value) & "/" & Year(dtpPeriodo.Value)

                If Weekday(sData) = 1 Then
                    oRow.Delete()
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirFinaisDeSemana()

        Try

            If MsgBox("Deseja excluir todos os finais de semana do mês?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            For Each oRow As GridEXRow In grdPeriodo.GetDataRows

                Dim sData As String = oRow.Cells("dia").Value & "/" & Month(dtpPeriodo.Value) & "/" & Year(dtpPeriodo.Value)

                If Weekday(sData) = 1 Or Weekday(sData) = 7 Then
                    oRow.Delete()
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ValidacaoHorario()

        Try

            If grdPeriodo.GetValue("horario_inicio").ToString.Length > 8 Then
                MsgBox("Horário de início inválido", MsgBoxStyle.Exclamation)
                grdPeriodo.SetValue("horario_inicio", "08:00:00")
                Exit Sub
            End If

            Dim sHora1() As String = grdPeriodo.GetValue("horario_inicio").ToString.Split(":")
            Dim dHoraDecimal As Double = sHora1(0) + (sHora1(1) / 60) + (sHora1(2) / 3600)

            If CInt(sHora1(0)) > 24 Or CInt(sHora1(1)) > 60 Or CInt(sHora1(2)) > 60 Then
                MsgBox("Horário de início inválido", MsgBoxStyle.Exclamation)
                grdPeriodo.SetValue("horario_inicio", "08:00:00")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Horário de início inválido", MsgBoxStyle.Exclamation)
            grdPeriodo.SetValue("horario_inicio", "08:00:00")
        End Try

    End Sub

#End Region

End Class