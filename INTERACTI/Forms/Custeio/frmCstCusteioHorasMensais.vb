Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports Microsoft.Office.Interop

Public Class frmCstCusteioHorasMensais

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private iCodigo As Integer
    Private iRow As Integer
    Private sData As String
    Private oClsCstGerar As New clsUsrCstGerar
    Private oClsCustHorasMensais As New clsUsrCustHorasMensais

#End Region

#Region "::: PROPERTIE :::"
    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property
    Public Property Data() As String
        Get
            Return sData
        End Get
        Set(ByVal value As String)
            sData = value
        End Set
    End Property

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

    Private Sub btnArquivo_Click(sender As Object, e As EventArgs) Handles btnArquivo.Click

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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub frmPrdOrdemProducaoCancelar_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            cboTipo.Items.Add("Subir Custeio do Mês", "1")
            cboTipo.Items.Add("Subir Horas Mensais", "2")

            dtpData.Value = sData

            Me.Location = New Point(300, 250)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Dim oApplicationClass As New Excel.Application

        Try

            Cursor.Current = Cursors.WaitCursor

            'Se for importar o Custeio do mês
            If cboTipo.SelectedValue = 1 Then

                CarregaCodigoCustoCapa()

                iRow = 3

                If Validacao() = True Then

                    Call ImportarGGF()
                    Call ImportarEncargo()
                    Call ImportarDepreciacao()
                    Call ImportarOutros()

                    'Finalizar o custeio
                    oClsCstGerar.FinalizarCusteio()

                    MsgBox("Custeio finalizado com sucesso!", MsgBoxStyle.Information, "Inserindo custeio")

                End If

                'Se for importar Horas Mensais
            Else

                If Validacao() = True Then

                    oApplicationClass.Workbooks.Open(txtArquivo.Text)
                    oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(1).Select()

                    ExecuteQuery("delete from tb_cst_horas_mensais where month(competencia) = " & CStr(Month(dtpData.Value)))

                    For i = 3 To oApplicationClass.Rows.Count

                        If oApplicationClass.Range("B" & i).Value = "" Or IsDBNull(oApplicationClass.Range("B" & i).Value) Then
                            Exit For
                        End If

                        oClsCustHorasMensais.Insert(iCodigoIntegracao:=oApplicationClass.Range("A" & i).Value, _
                                                    sNome:=oApplicationClass.Range("B" & i).Value, _
                                                    sCentroCusto:=oApplicationClass.Range("D" & i).Value, _
                                                    sData:=dtpData.Value, _
                                                    dHorasMensais:=oApplicationClass.Range("L" & i).Value, _
                                                    dHoraExtra50:=0, _
                                                    dHoraExtra100:=0, _
                                                    iFaltasDias:=0, _
                                                    dFaltasHoras:=0, _
                                                    dHorasFerias:=0, _
                                                    dTotalHoras:=oApplicationClass.Range("S" & i).Value)

                    Next

                    MsgBox("Importação realizada com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Concluído")

                End If

            End If

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing

            Call Novo()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            cboTipo.SelectedIndex = -1
            txtArquivo.Text = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                btnArquivo.Focus()
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

    Private Sub ImportarDepreciacao()

        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(3).Select()

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

            iRow = 88


            While iRow < 121
                If oApplicationClass.Range(ColValor & CStr(iRow)).Value <> 0 And IsDBNull(oApplicationClass.Range(ColValor & CStr(iRow)).Value) = False Then

                    'Seta Parametros
                    oClsCstGerar.ValorDepreciacao = oApplicationClass.Range(ColValor & CStr(iRow)).Value
                    oClsCstGerar.DescricaoDepreciacao = oApplicationClass.Range(ColDescricao & CStr(iRow)).Value

                    oClsCstGerar.InsertDepreciacaoTMP()

                End If

                iRow = iRow + 1

            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing

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
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(3).Select()

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

            iRow = 61

            While iRow < 86
                If oApplicationClass.Range(ColEncargo & CStr(iRow)).Value <> 0 And IsDBNull(oApplicationClass.Range(ColEncargo & CStr(iRow)).Value) = False Then

                    'Seta Parametros
                    oClsCstGerar.ValorEncargo = oApplicationClass.Range(ColEncargo & CStr(iRow)).Value
                    oClsCstGerar.CentroCustoEncargo = CStr(oApplicationClass.Range(ColCentroCusto & CStr(iRow)).Value)

                    oClsCstGerar.InsertEncargo()

                End If

                iRow = iRow + 1

            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing

        Catch ex As Exception
            MsgBox("Problema de importação na linha !", MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub ImportarGGF()


        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(1).Select()
            'oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(3).Select()

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

            iRow = 34

            While iRow < 59
                If oApplicationClass.Range(ColValor & CStr(iRow)).Value = 0 Or IsDBNull(oApplicationClass.Range(ColValor & CStr(iRow)).Value) = True Then
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

    Private Sub ImportarOutros()

        Dim oApplicationClass As New Excel.Application

        Try

            frmMain.errInfo.Clear()

            ''Abre o Arquivo
            oApplicationClass.Workbooks.Open(txtArquivo.Text)
            oApplicationClass.Workbooks.Open(txtArquivo.Text).Sheets(3).Select()

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

            iRow = 171

            While iRow <= 455

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
            MsgBox("Problema de importação na linha !", MsgBoxStyle.Exclamation, "Problemas importação")
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

    Private Sub CarregaCodigoCustoCapa()

        Try
            oClsCstGerar.Mes = Month(dtpData.Value)
            oClsCstGerar.Ano = Year(dtpData.Value)

            Call oClsCstGerar.CarregaCenario()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

End Class