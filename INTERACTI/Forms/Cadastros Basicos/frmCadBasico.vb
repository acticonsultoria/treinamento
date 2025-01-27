Imports System.Reflection
Imports System.Reflection.Assembly
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.GridEX

Public Class frmCadBasico

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private sUsrControl As String
    Private sTitle As String
    Private oFormularioCadastroBasico() As FormularioCadastroBasico
    Private bTamanho As Boolean = False

#End Region

#Region "::: PROPERTIE :::"

    Public Property UsrControl() As String
        Get
            Return sUsrControl
        End Get
        Set(ByVal value As String)
            sUsrControl = value
        End Set
    End Property

    Public WriteOnly Property Titulo() As String
        Set(ByVal value As String)
            sTitle = value
        End Set
    End Property

    Public WriteOnly Property Tamanho() As Boolean
        Set(ByVal value As Boolean)
            bTamanho = value
        End Set
    End Property

    Public Property CadastroBasico() As FormularioCadastroBasico()
        Get
            Return oFormularioCadastroBasico
        End Get
        Set(ByVal value As FormularioCadastroBasico())
            oFormularioCadastroBasico = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadBasico_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Try

            'Limpa Váriaveis
            iTipoAutoTextoFind = TipoAutotexto.TBD
            sFormularioFind = ""
            sTabelaFind = ""
            lCodigoItemFind = -1
            iCodigoTipoItemFind = -1
            sItemVendaFind = ""
            sItemCompraFind = ""
            sItemProducaoFind = ""
            sItemEstoqueFind = ""
            sItemAtivoFixoFind = ""
            sInsumoProducaoFind = ""
            iCodigoTipoParceiroNegocioFind = -1
            sRetornoParceiroNegocio = ""
            bInserirProdutoFind = False
            sQueryFind = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadastroBasico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            Me.Visible = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Váriaveis Locais
            Dim oUsrControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            'Seta Título
            Me.Text = "Formulário - Cadastro Básico"                        
            oUsrControl = oAssembly.CreateInstance("INTERACTI." & sUsrControl)
            If IsNothing(oFormularioCadastroBasico) = False Then
                If IsNothing(oFormularioCadastroBasico(UBound(oFormularioCadastroBasico))) = False AndAlso oFormularioCadastroBasico(UBound(oFormularioCadastroBasico)).sControle = oUsrControl.Name Then
                    oUsrControl.Tag = oFormularioCadastroBasico(UBound(oFormularioCadastroBasico)).oValor
                Else
                    oUsrControl.Tag = "NOVO"
                End If
            End If

            'Configura Mascara
            Call ConfigureMaskEdit(oUsrControl) : Call LoadControlesTraducao(oUsrControl)

            'Adiciona UserControl
            Me.Controls.Add(oUsrControl)
            'Seta Posição
            oUsrControl.Left = 8
            oUsrControl.Top = 8

            If bTamanho = True Then
                'Me.StartPosition = FormStartPosition.Manual
                oUsrControl.Dock = DockStyle.Fill                
                Me.Size = frmMain.tlpMain.Size
                Me.Location = New Point(0, 23)
                Application.DoEvents()
            Else
                'Redimensiona Formulário                                
                Me.Width = oUsrControl.Width + 32
                Me.Height = oUsrControl.Height + 54
                'Reposiciona UserControl
                Me.Top = ((Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2)
                Me.Left = ((Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2)
            End If

            Me.Visible = True

            oUsrControl.Focus()

            'Carrega Cadastro Básico
            Call CarregaControles()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CarregaControles()

        Try

            'Verifica se foi Passado algum Parâmetro
            If Not oFormularioCadastroBasico Is Nothing Then

                'Váriaveis Locais
                Dim oControl As Control

                'Carrega Controles
                For i = 0 To UBound(oFormularioCadastroBasico)

                    If Me.Controls.Find(oFormularioCadastroBasico(i).sControle, True).Count > 0 Then

                        oControl = Me.Controls.Find(oFormularioCadastroBasico(i).sControle, True)(0)

                        If TypeOf oControl Is EditBox Then
                            oControl.Text = oFormularioCadastroBasico(i).oValor
                        ElseIf TypeOf oControl Is MaskedEditBox Then
                            oControl.Text = oFormularioCadastroBasico(i).oValor
                        ElseIf TypeOf oControl Is NumericEditBox Then
                            Dim oNumericEditBox As NumericEditBox = oControl
                            oNumericEditBox.Value = oFormularioCadastroBasico(i).oValor
                        ElseIf TypeOf oControl Is UIComboBox Then
                            Dim oCombo As UIComboBox = oControl
                            oCombo.SelectedValue = oFormularioCadastroBasico(i).oValor
                        ElseIf TypeOf oControl Is CalendarCombo Then
                            Dim oCombo As CalendarCombo = oControl
                            oCombo.Value = oFormularioCadastroBasico(i).oValor
                        ElseIf TypeOf oControl Is UIButton Then
                            Dim oButton As UIButton = oControl
                            oButton.Tag = oFormularioCadastroBasico(i).oValor
                        ElseIf TypeOf oControl Is GridEX Then
                            Dim oGrid As GridEX = oControl
                            Call ConfigurarDataMemberGrid(oGrid)
                            oGrid.DataMember = oFormularioCadastroBasico(i).oValor.Tables(0).TableName
                            oGrid.DataSource = oFormularioCadastroBasico(i).oValor.DefaultViewManager
                        ElseIf TypeOf oControl Is UserControl Then
                            oControl.Tag = oFormularioCadastroBasico(i).oValor
                        End If

                    ElseIf oFormularioCadastroBasico(i).sControle.Substring(0, 3) = "MP_" Then
                        If Me.Controls.Find(oFormularioCadastroBasico(i).sControle.Substring(3), True).Count > 0 Then
                            oControl = Me.Controls.Find(oFormularioCadastroBasico(i).sControle.Substring(3), True)(0)
                            Dim oCombo As UIComboBox = oControl
                            Dim sAuxiliar() As String = oFormularioCadastroBasico(i).oValor.ToString.Split("|")
                            If IsNothing(oCombo.DataSource) Then
                                oCombo.Items.Add(sAuxiliar(0), sAuxiliar(1))
                                oCombo.SelectedValue = sAuxiliar(1)
                            Else
                                Dim oDataSet As DataSet = oCombo.DataSource.DataSet
                                Dim oDataTable As DataTable = oDataSet.Tables(0)
                                Dim oDataRow As DataRow = oDataTable.NewRow
                                oDataRow("codigo") = sAuxiliar(1)
                                oDataRow("descricao") = sAuxiliar(0)
                                oDataTable.Rows.Add(oDataRow)
                                oCombo.DataSource = oDataSet.Tables(0)
                                oCombo.ValueMember = "CODIGO"
                                oCombo.DisplayMember = "DESCRICAO"
                                oCombo.SelectedValue = sAuxiliar(1)
                            End If
                        End If

                    ElseIf oFormularioCadastroBasico(i).sControle = "" Then



                    End If
                Next

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
