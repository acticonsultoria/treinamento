Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoImprimir

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sCodigo As String
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo As String
        Get
            Return sCodigo
        End Get
        Set(value As String)
            sCodigo = value
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


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try

            If grdListagem.GetCheckedRows.Count = 0 Then

                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Sub

            End If

            Imprimir()
            Me.Dispose()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub



    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Sair da tela
        Me.Dispose()
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridOrdemProducaoImpressao(grdListagem, sCodigo)

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
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            Dim sCodigoOP As String = ""

            For Each oRow In grdListagem.GetCheckedRows

                sCodigoOP += IIf(sCodigoOP = "", "", ",") & CStr(oRow.Cells.Item("codigo").Value)

            Next


            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
            goCrystalReport.sReportParameter(1).sValue = sCodigoOP
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "PRD000000001.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("PRD000000001", "Ordem de Produção", oReport)

            'Atualiza Registro no Banco de Dados
            'Call ExecuteQuery("UPDATE tb_prd_ordem_producao SET impresso = 1 WHERE (((codigo_empresa) = " & goUsuario.iEmpresa & ") AND ((codigo) = " + grdListagem.CurrentRow.Cells("codigo").Value + "))")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    
#End Region

End Class