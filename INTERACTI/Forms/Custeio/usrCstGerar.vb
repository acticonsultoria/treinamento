Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports Microsoft.Office.Interop

Public Class usrCstGerar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCstGerar As New clsUsrCstGerar
    Private iRow As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Row() As Integer
        Get
            Return iRow
        End Get
        Set(ByVal value As Integer)
            iRow = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCstGerar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        Try

            If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCstGerar_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Váriaveis Locais
            Dim oArquivoExcel As New OpenFileDialog

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx;*.csv"
            oArquivoExcel.InitialDirectory = "c:\\"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Seta Controles
                txtArquivo.Text = oArquivoExcel.FileName

            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)

        End Try
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click

        Try

            Importar(True)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnImportarAno_Click(sender As Object, e As EventArgs) Handles btnImportarAno.Click
        Try
            'Recebe o primeiro dia do ano
            Dim dData As Date = New Date(Year(dtpData.Value), 1, 1)

            Dim iLinhaTotal As Integer = 22

            For i As Integer = 0 To 11

                'Incrementa o valor
                dtpData.Value = DateAdd(DateInterval.Month, i, dData)



                'Verifica se tem valor no mês
                Dim oApplicationClass As New Excel.Application
                oApplicationClass.Workbooks.Open(txtArquivo.Text)
                oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(4).Select()

                Dim ColEncargo As String

                If Month(dtpData.Value) = 1 Then
                    ColEncargo = "E"
                ElseIf Month(dtpData.Value) = 2 Then
                    ColEncargo = "F"
                ElseIf Month(dtpData.Value) = 3 Then
                    ColEncargo = "G"
                ElseIf Month(dtpData.Value) = 4 Then
                    ColEncargo = "H"
                ElseIf Month(dtpData.Value) = 5 Then
                    ColEncargo = "I"
                ElseIf Month(dtpData.Value) = 6 Then
                    ColEncargo = "J"
                ElseIf Month(dtpData.Value) = 7 Then
                    ColEncargo = "K"
                ElseIf Month(dtpData.Value) = 8 Then
                    ColEncargo = "L"
                ElseIf Month(dtpData.Value) = 9 Then
                    ColEncargo = "M"
                ElseIf Month(dtpData.Value) = 10 Then
                    ColEncargo = "N"
                ElseIf Month(dtpData.Value) = 11 Then
                    ColEncargo = "O"
                Else
                    ColEncargo = "P"
                End If


                If IsDBNull(oApplicationClass.Range(ColEncargo & CStr(iLinhaTotal)).Value) Then Exit For
                If oApplicationClass.Range(ColEncargo & CStr(iLinhaTotal)).Value Is Nothing Then Exit For
                If CInt(oApplicationClass.Range(ColEncargo & CStr(iLinhaTotal)).Value) = 0 Then Exit For

                'Chama o importar
                Call Importar(False)

                'Seta o progrress
                Application.DoEvents()

            Next


            MsgBox("Custeio finalizado!", vbInformation, "Custeio")

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUp
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCstGerar_KeyUp))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            Call ConfiguraGrid(grdEncargo, Formulario.CustoGerar)
            Call ConfiguraGrid(grdGGF, Formulario.CustoGerar)
            Call ConfiguraGrid(grdCustos, Formulario.CustoGerar)
            Call ConfiguraGrid(grdDespesa, Formulario.CustoGerar)
            Call ConfiguraGrid(grdBeneficiamento, Formulario.CustoGerar)

            'Seta configurações
            dtpData.Value = Now.Date
            'TabPages.Remove(pagDepreciacao)
            'tabCustos.TabPages.Remove(pagManutencao)
            btnImportarAno.Visible = False

            'Seta Focus
            dtpData.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub Importar(ByVal bExibirMensagem As Boolean)

        Try

            Cursor.Current = Cursors.WaitCursor

            oProgress.Visible = True
            oProgress.Value = 0
            oProgress.Maximum = 6
            lblInfo.Visible = True

            'Carrega
            CarregaCodigoCustoCapa()

            iRow = 3

            If Validacao() = True Then

                lblInfo.Text = "Importando GGF"
                ImportarGGF()
                oProgress.Value += 1
                Application.DoEvents()

                lblInfo.Text = "Importando Encargo"
                ImportarEncargo()
                oProgress.Value += 1
                Application.DoEvents()

                lblInfo.Text = "Importando Depreciação"
                ImportarDepreciacao()
                oProgress.Value += 1
                Application.DoEvents()

                lblInfo.Text = "Importando Receita"
                ImportarReceita()
                oProgress.Value += 1
                Application.DoEvents()

                lblInfo.Text = "Importando Despesa"
                ImportarDespesa()
                oProgress.Value += 1
                Application.DoEvents()

                lblInfo.Text = "Importando Outros"
                ImportarOutros()
                oProgress.Value += 1
                Application.DoEvents()

                'Finalizar o custeio
                lblInfo.Text = "Finalizando Custeio"
                oClsCstGerar.FinalizarCusteio()

                'Carrega os dados 
                LoadGGF()
                LoadEncargo()
                LoadDepreciacao()
                LoadManutencao()
                LoadDespesa()

                Cursor.Current = Cursors.Default

                If bExibirMensagem = True Then
                    MsgBox("Custeio finalizado com sucesso!", MsgBoxStyle.Information, "Inserindo custeio")
                End If

            End If

            lblInfo.Visible = False
            oProgress.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarGGF()


        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(4).Select()

            'Variáveis auxiliares para colunas
            Dim ColContaContabil As String = "A"
            Dim ColValor As String = ""
            Dim ColSubItem As String = "D"
            Dim ColImportar As String = "C"

            If Month(dtpData.Value) = 1 Then
                ColValor = "E"
            ElseIf Month(dtpData.Value) = 2 Then
                ColValor = "F"
            ElseIf Month(dtpData.Value) = 3 Then
                ColValor = "G"
            ElseIf Month(dtpData.Value) = 4 Then
                ColValor = "H"
            ElseIf Month(dtpData.Value) = 5 Then
                ColValor = "I"
            ElseIf Month(dtpData.Value) = 6 Then
                ColValor = "J"
            ElseIf Month(dtpData.Value) = 7 Then
                ColValor = "K"
            ElseIf Month(dtpData.Value) = 8 Then
                ColValor = "L"
            ElseIf Month(dtpData.Value) = 9 Then
                ColValor = "M"
            ElseIf Month(dtpData.Value) = 10 Then
                ColValor = "N"
            ElseIf Month(dtpData.Value) = 11 Then
                ColValor = "O"
            Else
                ColValor = "P"
            End If

            iRow = 30

            While iRow <= 32
                If oApplicationClass.Range(ColValor & CStr(iRow)).Value = 0 Or IsDBNull(oApplicationClass.Range(ColValor & CStr(iRow)).Value) Or IsNothing(oApplicationClass.Range(ColContaContabil & CStr(iRow)).Value) = True Then
                    iRow = iRow + 1
                    Continue While
                End If

                'Seta Parametros
                oClsCstGerar.Conta = oApplicationClass.Range(ColContaContabil & CStr(iRow)).Value
                oClsCstGerar.ValorGGF = oApplicationClass.Range(ColValor & CStr(iRow)).Value
                oClsCstGerar.SubItem = oApplicationClass.Range(ColSubItem & CStr(iRow)).Value

                oClsCstGerar.InsertGGF()

                iRow = iRow + 1

            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing


        Catch ex As Exception
            MsgBox("Problema de importação na linha " & CStr(iRow), MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub ImportarDepreciacao()

        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(4).Select()

            'Variáveis auxiliares para colunas
            Dim ColValor As String = ""
            Dim ColDescricao As String = "D"

            If Month(dtpData.Value) = 1 Then
                ColValor = "E"
            ElseIf Month(dtpData.Value) = 2 Then
                ColValor = "F"
            ElseIf Month(dtpData.Value) = 3 Then
                ColValor = "G"
            ElseIf Month(dtpData.Value) = 4 Then
                ColValor = "H"
            ElseIf Month(dtpData.Value) = 5 Then
                ColValor = "I"
            ElseIf Month(dtpData.Value) = 6 Then
                ColValor = "J"
            ElseIf Month(dtpData.Value) = 7 Then
                ColValor = "K"
            ElseIf Month(dtpData.Value) = 8 Then
                ColValor = "L"
            ElseIf Month(dtpData.Value) = 9 Then
                ColValor = "M"
            ElseIf Month(dtpData.Value) = 10 Then
                ColValor = "N"
            ElseIf Month(dtpData.Value) = 11 Then
                ColValor = "O"
            Else
                ColValor = "P"
            End If

            iRow = 33

            While iRow <= 33
                If oApplicationClass.Range(ColValor & CStr(iRow)).Value <> 0 And IsDBNull(oApplicationClass.Range(ColValor & CStr(iRow)).Value) = False Then

                    'Seta Parametros
                    oClsCstGerar.ValorDepreciacao = oApplicationClass.Range(ColValor & CStr(iRow)).Value
                    oClsCstGerar.DescricaoDepreciacao = oApplicationClass.Range(ColDescricao & CStr(iRow)).Value

                    oClsCstGerar.InsertDepreciacaoTMP()

                End If

                iRow = iRow + 1

            End While

            'If ValidaDado(oApplicationClass.Range(ColValor & CStr(iRow)).Value) = True Then

            '    If oApplicationClass.Range(ColValor & CStr(iRow)).Value <> 0 Then

            '        'Seta Parametros 
            '        oClsCstGerar.ValorDepreciacao = oApplicationClass.Range(ColValor & CStr(iRow)).Value
            '        oClsCstGerar.DescricaoDepreciacao = oApplicationClass.Range(ColDescricao & CStr(iRow)).Value

            '        oClsCstGerar.InsertDepreciacaoTMP()

            '    End If

            '    iRow = iRow + 1

            '    oApplicationClass.Workbooks.Close()
            '    oApplicationClass = Nothing

            'End If

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing

            oClsCstGerar.InsertDepreciacao()

        Catch ex As Exception
            MsgBox("Problema de importação na linha !", MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub ImportarManutencao()


        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(4).Select()

            'Variáveis auxiliares para colunas
            Dim ColContaContabil As String = ""
            Dim ColValor As String = ""
            Dim ColDescricao As String = ""

            If Month(dtpData.Value) = 1 Then
                ColValor = "J"
            ElseIf Month(dtpData.Value) = 2 Then
                ColValor = "K"
            ElseIf Month(dtpData.Value) = 3 Then
                ColValor = "L"
            ElseIf Month(dtpData.Value) = 4 Then
                ColValor = "M"
            ElseIf Month(dtpData.Value) = 5 Then
                ColValor = "N"
            ElseIf Month(dtpData.Value) = 6 Then
                ColValor = "O"
            ElseIf Month(dtpData.Value) = 7 Then
                ColValor = "P"
            ElseIf Month(dtpData.Value) = 8 Then
                ColValor = "Q"
            ElseIf Month(dtpData.Value) = 9 Then
                ColValor = "R"
            ElseIf Month(dtpData.Value) = 10 Then
                ColValor = "S"
            ElseIf Month(dtpData.Value) = 11 Then
                ColValor = "T"
            Else
                ColValor = "U"
            End If

            Dim manutencao As Boolean = 0

            While 1

                For j As Integer = 0 To 20

                    'If ValidaDado(oApplicationClass.Range(LoadRangeExcel(6, iRow)).Value) = True Then

                    If manutencao = True And ValidaDado(oApplicationClass.Range(LoadRangeExcel(6, iRow)).Value) = False Then

                        For k As Integer = 0 To 10

                            If oApplicationClass.Range(LoadRangeExcel(6, iRow)).Value = "DESPESAS" Then

                                iRow = iRow + 1

                                Exit While

                            End If

                            iRow = iRow + 1

                        Next

                    End If

                    If manutencao = True And ValidaDado(oApplicationClass.Range(LoadRangeExcel(6, iRow)).Value) = True Then

                        Exit For

                    End If

                    If oApplicationClass.Range(LoadRangeExcel(6, iRow)).Value = "MANUTENÇÃO" Then

                        iRow = iRow + 1
                        manutencao = 1

                        Exit For

                    End If

                    'End If

                    iRow = iRow + 1

                Next

                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(6, iRow)).Value) = True Then

                    ColContaContabil = "G"
                    ColDescricao = "F"

                    'Seta Parametros
                    oClsCstGerar.Conta = oApplicationClass.Range(ColContaContabil & CStr(iRow)).Value
                    oClsCstGerar.ValorManutencao = oApplicationClass.Range(ColValor & CStr(iRow)).Value
                    oClsCstGerar.DescricaoManutencao = oApplicationClass.Range(ColDescricao & CStr(iRow)).Value

                    oClsCstGerar.InsertManutencao()

                    iRow = iRow + 1

                Else

                    oApplicationClass.Workbooks.Close()
                    oApplicationClass = Nothing

                    Exit While

                End If

            End While

        Catch ex As Exception
            MsgBox("Problema de importação na linha !", MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub ImportarEncargo()

        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(4).Select()

            'Variáveis auxiliares para colunas
            Dim ColEncargo As String = ""
            Dim ColCentroCusto As String = "D"

            If Month(dtpData.Value) = 1 Then
                ColEncargo = "E"
            ElseIf Month(dtpData.Value) = 2 Then
                ColEncargo = "F"
            ElseIf Month(dtpData.Value) = 3 Then
                ColEncargo = "G"
            ElseIf Month(dtpData.Value) = 4 Then
                ColEncargo = "H"
            ElseIf Month(dtpData.Value) = 5 Then
                ColEncargo = "I"
            ElseIf Month(dtpData.Value) = 6 Then
                ColEncargo = "J"
            ElseIf Month(dtpData.Value) = 7 Then
                ColEncargo = "K"
            ElseIf Month(dtpData.Value) = 8 Then
                ColEncargo = "L"
            ElseIf Month(dtpData.Value) = 9 Then
                ColEncargo = "M"
            ElseIf Month(dtpData.Value) = 10 Then
                ColEncargo = "N"
            ElseIf Month(dtpData.Value) = 11 Then
                ColEncargo = "O"
            Else
                ColEncargo = "P"
            End If

            iRow = 64

            While iRow <= 94

                If oApplicationClass.Range(ColEncargo & CStr(iRow)).Value <> 0 And IsDBNull(oApplicationClass.Range(ColEncargo & CStr(iRow)).Value) = False Then

                    'Seta Parametros
                    oClsCstGerar.ValorEncargo = oApplicationClass.Range(ColEncargo & CStr(iRow)).Value
                    oClsCstGerar.CentroCustoEncargo = CStr(oApplicationClass.Range(ColCentroCusto & CStr(iRow)).Value)

                    oClsCstGerar.InsertEncargo()

                End If

                iRow = iRow + 1

            End While

            'Seta linha correta
            'While CStr(oApplicationClass.Range(ColCentroCusto & CStr(iRow)).Value) <> "GASTOS COM PESSOAL"

            '    iRow = iRow + 1

            'End While

            'iRow = iRow + 1

            'While 1

            '    If CStr(oApplicationClass.Range(ColCentroCusto & CStr(iRow)).Value) <> "GASTOS COM DEPRECIAÇÃO" _
            '    And CStr(oApplicationClass.Range(ColCentroCusto & CStr(iRow)).Value) <> "TOTAL DE CUSTOS" Then

            '        If oApplicationClass.Range(ColEncargo & CStr(iRow)).Value <> 0 Then

            '            'Seta Parametros
            '            oClsCstGerar.ValorEncargo = oApplicationClass.Range(ColEncargo & CStr(iRow)).Value
            '            oClsCstGerar.CentroCustoEncargo = CStr(oApplicationClass.Range(ColCentroCusto & CStr(iRow)).Value)

            '            oClsCstGerar.InsertEncargo()

            '        End If

            '        iRow = iRow + 1

            '    Else

            '        oApplicationClass.Workbooks.Close()
            '        oApplicationClass = Nothing

            '        Exit While

            '    End If

            'End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing

        Catch ex As Exception
            MsgBox("Problema de importação na linha !", MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub ImportarDespesa()

        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(4).Select()

            'Variáveis auxiliares para colunas
            Dim ColValor As String = ""
            Dim ColContaContabil As String = "A"
            Dim ColDescricao As String = "D"

            If Month(dtpData.Value) = 1 Then
                ColValor = "E"
            ElseIf Month(dtpData.Value) = 2 Then
                ColValor = "F"
            ElseIf Month(dtpData.Value) = 3 Then
                ColValor = "G"
            ElseIf Month(dtpData.Value) = 4 Then
                ColValor = "H"
            ElseIf Month(dtpData.Value) = 5 Then
                ColValor = "I"
            ElseIf Month(dtpData.Value) = 6 Then
                ColValor = "J"
            ElseIf Month(dtpData.Value) = 7 Then
                ColValor = "K"
            ElseIf Month(dtpData.Value) = 8 Then
                ColValor = "L"
            ElseIf Month(dtpData.Value) = 9 Then
                ColValor = "M"
            ElseIf Month(dtpData.Value) = 10 Then
                ColValor = "N"
            ElseIf Month(dtpData.Value) = 11 Then
                ColValor = "O"
            Else
                ColValor = "P"
            End If

            iRow = 104
            'Seta linha correta
            'While CStr(oApplicationClass.Range(ColDescricao & CStr(iRow)).Value) <> "DESPESAS"

            '    iRow = iRow + 1

            'End While

            While iRow <= 104

                If ValidaDado(oApplicationClass.Range(ColValor & CStr(iRow)).Value) = True Then

                    If oApplicationClass.Range(ColValor & CStr(iRow)).Value <> 0 Then

                        'Seta Parametros
                        oClsCstGerar.ValorDespesa = oApplicationClass.Range(ColValor & CStr(iRow)).Value
                        oClsCstGerar.Descricao = oApplicationClass.Range(ColDescricao & CStr(iRow)).Value
                        oClsCstGerar.Conta = oApplicationClass.Range(ColContaContabil & CStr(iRow)).Value

                        oClsCstGerar.InsertDespesa()

                    End If

                    iRow = iRow + 1

                Else

                    oApplicationClass.Workbooks.Close()
                    oApplicationClass = Nothing

                    Exit While

                End If

            End While

        Catch ex As Exception
            MsgBox("Problema de importação na linha !", MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub ImportarReceita()

        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(4).Select()

            'Variáveis auxiliares para colunas
            Dim ColValor As String = ""
            Dim ColContaContabil As String = "A"
            Dim ColDescricao As String = "D"

            If Month(dtpData.Value) = 1 Then
                ColValor = "E"
            ElseIf Month(dtpData.Value) = 2 Then
                ColValor = "F"
            ElseIf Month(dtpData.Value) = 3 Then
                ColValor = "G"
            ElseIf Month(dtpData.Value) = 4 Then
                ColValor = "H"
            ElseIf Month(dtpData.Value) = 5 Then
                ColValor = "I"
            ElseIf Month(dtpData.Value) = 6 Then
                ColValor = "J"
            ElseIf Month(dtpData.Value) = 7 Then
                ColValor = "K"
            ElseIf Month(dtpData.Value) = 8 Then
                ColValor = "L"
            ElseIf Month(dtpData.Value) = 9 Then
                ColValor = "M"
            ElseIf Month(dtpData.Value) = 10 Then
                ColValor = "N"
            ElseIf Month(dtpData.Value) = 11 Then
                ColValor = "O"
            Else
                ColValor = "P"
            End If

            iRow = 137

            While iRow <= 154

                If oApplicationClass.Range(ColValor & CStr(iRow)).Value = 0 Or IsDBNull(oApplicationClass.Range(ColValor & CStr(iRow)).Value) Or IsNothing(oApplicationClass.Range(ColContaContabil & CStr(iRow)).Value) = True Then
                    iRow = iRow + 1
                    Continue While
                End If

                'Seta Parametros
                oClsCstGerar.ValorReceita = oApplicationClass.Range(ColValor & CStr(iRow)).Value
                oClsCstGerar.Descricao = oApplicationClass.Range(ColDescricao & CStr(iRow)).Value
                oClsCstGerar.Conta = oApplicationClass.Range(ColContaContabil & CStr(iRow)).Value

                oClsCstGerar.InsertReceita()

                iRow = iRow + 1

            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing

        Catch ex As Exception
            MsgBox("Problema de importação na linha " & CStr(iRow), MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub ImportarOutros()

        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(4).Select()

            'Variáveis auxiliares para colunas
            Dim ColValor As String = ""
            Dim ColContaContabil As String = "A"
            Dim ColDescricao As String = "D"

            If Month(dtpData.Value) = 1 Then
                ColValor = "E"
            ElseIf Month(dtpData.Value) = 2 Then
                ColValor = "F"
            ElseIf Month(dtpData.Value) = 3 Then
                ColValor = "G"
            ElseIf Month(dtpData.Value) = 4 Then
                ColValor = "H"
            ElseIf Month(dtpData.Value) = 5 Then
                ColValor = "I"
            ElseIf Month(dtpData.Value) = 6 Then
                ColValor = "J"
            ElseIf Month(dtpData.Value) = 7 Then
                ColValor = "K"
            ElseIf Month(dtpData.Value) = 8 Then
                ColValor = "L"
            ElseIf Month(dtpData.Value) = 9 Then
                ColValor = "M"
            ElseIf Month(dtpData.Value) = 10 Then
                ColValor = "N"
            ElseIf Month(dtpData.Value) = 11 Then
                ColValor = "O"
            Else
                ColValor = "P"
            End If

            iRow = 157

            While iRow <= 500

                If oApplicationClass.Range(ColValor & CStr(iRow)).Value = 0 Or IsDBNull(oApplicationClass.Range(ColValor & CStr(iRow)).Value) Or IsNothing(oApplicationClass.Range(ColContaContabil & CStr(iRow)).Value) = True Then
                    iRow = iRow + 1
                    Continue While
                End If

                'Seta Parametros
                oClsCstGerar.ValorOutros = oApplicationClass.Range(ColValor & CStr(iRow)).Value
                oClsCstGerar.Descricao = oApplicationClass.Range(ColDescricao & CStr(iRow)).Value
                oClsCstGerar.Conta = oApplicationClass.Range(ColContaContabil & CStr(iRow)).Value

                oClsCstGerar.InsertOutros()


                iRow = iRow + 1

            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing

        Catch ex As Exception
            MsgBox("Problema de importação na linha " & CStr(iRow), MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub LoadEncargo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsCstGerar.LoadEncargo(grdEncargo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGGF()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsCstGerar.LoadGGF(grdGGF)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadDepreciacao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsCstGerar.LoadDepreciacao(grdDepreciacao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadManutencao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsCstGerar.LoadManutencao(grdManutencao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadDespesa()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsCstGerar.LoadDespesa(grdDespesa)

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

            'Verifica se foi Selecionado o Campo
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                btnArquivo.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo
            If ValidaCampo(dtpData, lblData) = False Then
                dtpData.Focus()
                Exit Function
            End If

            If ValidacaoDataCusteio(dtpData.Value) = False Then
                Exit Function
            End If


            'Exclui os dados anteriores
            Call oClsCstGerar.DeleteGGF()
            Call oClsCstGerar.DeleteEncargo()
            Call oClsCstGerar.DeleteDespesa()

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CarregaCodigoCustoCapa()

        Try
            oClsCstGerar.Mes = Month(dtpData.Value)
            oClsCstGerar.Ano = Year(dtpData.Value)

            Call oClsCstGerar.CarregaCenario()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            frmMain.errInfo.Clear()

            oClsCstGerar.Salvar(Month(dtpData.Value), _
                                Year(dtpData.Value), _
                                grdDespesa.GetTotalRow.Cells.Item("valor_rateio_fabrica").Value, _
                                grdDespesa.GetTotalRow.Cells.Item("valor_rateio_revenda").Value)

        Catch ex As Exception
            MsgBox("Problema de importação na linha !", MsgBoxStyle.Exclamation, "Problemas importação")
            Throw ex
        End Try

    End Sub

    Private Function ValidaDado(ByVal oValor As Object) As Boolean
        ValidaDado = True
        If oValor Is Nothing Then
            ValidaDado = False
        ElseIf IsDBNull(oValor) Then
            ValidaDado = False
        ElseIf IsNothing(oValor) Then
            ValidaDado = False
        ElseIf CStr(oValor) = "" Then
            ValidaDado = False
        End If

    End Function

    Private Function LoadRangeExcel(ByVal iIndice As Integer, ByVal iRow As Integer) As String
        Try

            Dim sIndice As String = ""
            If iIndice > 26 Then
                If iIndice - 26 > 26 Then
                    sIndice = "B"
                    iIndice -= 52
                Else
                    sIndice = "A"
                    iIndice -= 26
                End If
            Else

                sIndice = ""
            End If
            sIndice += Chr(64 + iIndice)

            Return sIndice & iRow
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class

