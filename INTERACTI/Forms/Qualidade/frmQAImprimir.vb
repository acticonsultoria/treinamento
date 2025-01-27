Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO
Imports Org.BouncyCastle.Math

Public Class frmQAImprimir

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sNumeroOS As String
    Private sReport As String
    Private oClsUsrQARelatorioInspecao As New clsUsrQARelatorioInspecao

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroOS As String
        Get
            Return sNumeroOS
        End Get
        Set(value As String)
            sNumeroOS = value
        End Set
    End Property

    Public Property Report As String
        Get
            Return sReport
        End Get
        Set(value As String)
            sReport = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Sair da tela
        Me.Dispose()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Try


            If grdListagem.GetCheckedRows.Count = 0 Then

                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Sub

            End If


            Call Imprimir()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsUsrQARelatorioInspecao.LoadGridRelatorioInspecaoImprimir(grdListagem, sNumeroOS)

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub



    Private Sub Imprimir()

        Try


            Dim sCodigoRI As String = ""

            For Each oRow In grdListagem.GetCheckedRows

                sCodigoRI += IIf(sCodigoRI = "", "", ",") & CStr(oRow.Cells.Item("codigo_ri").Value)

            Next

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_relatorio_inspecao"
            goCrystalReport.sReportParameter(0).sValue = sCodigoRI
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("QA000000007", "Relatório de Inspeção", oReport)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

End Class