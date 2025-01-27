Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmFatEmissaoImportarExcelRemessa

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrFatEmissaoNFe As New clsUsrFatEmissaoNFe
    Private lCodigoEmissaoCapa As Long = -1

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(value As Long)
            lCodigoEmissaoCapa = value
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

    Private Sub btnArquivoExcel_Click(sender As Object, e As EventArgs) Handles btnArquivoExcel.Click

        Try

            ImportarArquivoExcelTemp()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            If Validacao() = False Then Exit Sub

            Salvar()

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Sair da tela
        Me.Dispose()
    End Sub

    Private Sub cboCFOP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCFOP.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verificando se foi selecionado algum registro
            If cboCFOP.SelectedIndex > -1 Then

                'Carrega Combo Situação Tributária
                Call LoadCombo(cboSituacaoTributariaICMS, _
                               "sp_select_combo_static_situacao_tributaria_icms_cfop " & cboCFOP.SelectedValue & "," & goUsuario.iEmpresa)

                'Pré-determinado se houver somente um registro
                cboSituacaoTributariaPIS.SelectedIndex = IIf(cboSituacaoTributariaPIS.Items.Count = 1, 0, -1)
                cboSituacaoTributariaCOFINS.SelectedIndex = IIf(cboSituacaoTributariaCOFINS.Items.Count = 1, 0, -1)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaICMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSituacaoTributariaICMS.SelectedIndexChanged

        Try

            'Desabilita Controles - ICMS
            txtPorcentagemReducaoBCICMS.Enabled = False
            txtAliquotaICMS.Enabled = False
            'Desabilita Controles - ICMS ST
            txtIVA.Enabled = False
            txtPorcentagemReducaoBCICMSST.Enabled = False
            txtAliquotaICMSST.Enabled = False

            If cboSituacaoTributariaICMS.SelectedIndex <> -1 Then

                Select Case cboSituacaoTributariaICMS.SelectedValue

                    Case "00"
                        'Habilita Controles - ICMS
                        txtAliquotaICMS.Enabled = True

                    Case "10"
                        'Habilita Controles - ICMS
                        txtAliquotaICMS.Enabled = True
                        'Habilita Controles - ICMS ST
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "20"
                        'Habilita Controles - ICMS
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True

                    Case "30"
                        'Habilita Controles - ICMS ST
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "40", "41", "50"

                    Case "51"
                        'Habilita Controles - ICMS
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True

                    Case "70"
                        'Habilita Controles - ICMS
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True
                        'Habilita Controles - ICMS ST
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "90"
                        'Habilita Controles - ICMS
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True
                        'Habilita Controles - ICMS ST
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                End Select

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaIPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSituacaoTributariaIPI.SelectedIndexChanged

        Try

            If cboSituacaoTributariaIPI.SelectedIndex = -1 Then
                Call LoadCombo(cboCodigoEnquadramento, "sp_select_combo_static_classe_enquadramento_ipi ''")
            Else
                If cboSituacaoTributariaIPI.SelectedValue = "04" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "05" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "02" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "01" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "54" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "55" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "52" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "51" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "49" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "59" Then
                    Call LoadCombo(cboCodigoEnquadramento, "sp_select_combo_static_classe_enquadramento_ipi '" & cboSituacaoTributariaIPI.SelectedValue & "'")
                    cboCodigoEnquadramento.Enabled = True
                Else
                    cboCodigoEnquadramento.Enabled = False
                    cboCodigoEnquadramento.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaCOFINS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSituacaoTributariaCOFINS.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboSituacaoTributariaCOFINS.SelectedIndex <> -1 Then

                'COFINS
                For Each oControl In grpCOFINS.Controls
                    'Caso não seja Label
                    If Not TypeOf oControl Is Label Then
                        If InStr(oControl.Tag, "|" & cboSituacaoTributariaCOFINS.Text & "|", CompareMethod.Text) > 0 Then
                            oControl.Enabled = True
                        Else
                            oControl.Enabled = False
                        End If
                    End If
                Next

                'Verificando se existe a alíquota
                If txtAliquotaCOFINS.Enabled = True Then
                    txtAliquotaCOFINS.Value = 7.6
                Else
                    txtAliquotaCOFINS.Value = 0
                End If

            Else

                'Desabilita Controles grpcofins
                For Each oControl In grpCOFINS.Controls
                    If Not TypeOf oControl Is Label Then
                        oControl.Enabled = False
                    End If
                Next

                'Desabilita Controles grpcofinsSST
                For Each oControl In grpCOFINSST.Controls
                    If Not TypeOf oControl Is Label Then
                        oControl.Enabled = False
                    End If
                Next

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Carrega combo - CFOP
            LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_saida " & goUsuario.iEmpresa)
            'Carrega Combo - ICMS
            LoadCombo(cboSituacaoTributariaICMS, "sp_select_combo_static_situacao_tributaria_icms", False)
            'Carrega Combo - IPI
            LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi 1", False)
            'Carrega Combo - PIS
            LoadCombo(cboSituacaoTributariaPIS, "sp_select_combo_static_situacao_tributaria_pis ")
            'Carrega Combo - COFINS
            LoadCombo(cboSituacaoTributariaCOFINS, "sp_select_combo_static_situacao_tributaria_cofins ")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub ImportarArquivoExcelTemp()

        Dim oApplicationClass As New Excel.ApplicationClass

        Try

            frmMain.errInfo.Clear()
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx;*.csv"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Exclui dados da tabela
                oClsUsrFatEmissaoNFe.DeleteProdutoExcel()

                'Seta Controles
                txtArquivoExcel.Text = oArquivoExcel.FileName

                'Abre o Arquivo
                oApplicationClass.Workbooks.Open(oArquivoExcel.FileName)

                'Percorre Linha a Linha o Arquivo
                For i = 2 To oApplicationClass.Rows.Count

                    'Verifica se acabou os registros
                    If oApplicationClass.Range("B" & i).Value Is Nothing Then
                        Exit For
                    End If

                    'Adiciona(Linha)
                    oClsUsrFatEmissaoNFe.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("C" & i).Value, _
                                                             oApplicationClass.Range("D" & i).Value, _
                                                             oApplicationClass.Range("E" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value)

                Next

                oClsUsrFatEmissaoNFe.LoadGridProdutoExcel(grdListagem)
                oApplicationClass.Workbooks.Close()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            oApplicationClass.Workbooks.Close()
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            lCodigoEmissaoCapa = oClsUsrFatEmissaoNFe.InsertProdutoExcelNFe(cboCFOP.SelectedValue, _
                                                                            cboCFOP.Text.Trim)

            Dim iCont As Integer
            Dim oRow() As Janus.Windows.GridEX.GridEXRow = grdListagem.GetRows

            For iCont = 0 To oRow.Count - 1

                'Insere Imposto - ICMS
                If cboSituacaoTributariaICMS.SelectedIndex <> -1 Then InsertImpostoICMS()
                'Insere Imposto - IPI
                If cboSituacaoTributariaIPI.SelectedIndex <> -1 Then InsertImpostoIPI(oRow(iCont))
                'Insere Imposto - PIS
                If cboSituacaoTributariaPIS.SelectedIndex <> -1 Then InsertImpostoPIS(oRow(iCont))
                'Insere Imposto - COFINS
                If cboSituacaoTributariaCOFINS.SelectedIndex <> -1 Then InsertImpostoCOFINS(oRow(iCont))

            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertImpostoCOFINS(ByVal oRow As Janus.Windows.GridEX.GridEXRow)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona Item
            oClsUsrFatEmissaoNFe.InsertImpostoCOFINS(lCodigoEmissaoCapa, _
                                                     cboSituacaoTributariaCOFINS.Text.Trim, _
                                                     1, _
                                                     IIf(txtAliquotaCOFINS.Value > 0, oRow.Cells.Item("valor_total").Value, 0), _
                                                     txtAliquotaCOFINS.Value, _
                                                     0)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub InsertImpostoPIS(ByVal oRow As Janus.Windows.GridEX.GridEXRow)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona Item
            oClsUsrFatEmissaoNFe.InsertImpostoPIS(lCodigoEmissaoCapa, _
                                                  cboSituacaoTributariaPIS.Text.Trim, _
                                                  IIf(txtAliquotaPIS.Value > 0, oRow.Cells.Item("valor_total").Value, 0), _
                                                  txtAliquotaPIS.Value, _
                                                  0)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub InsertImpostoICMS()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona Item
            oClsUsrFatEmissaoNFe.InsertImpostoICMS(lCodigoEmissaoCapa, _
                                                   IIf(cboSituacaoTributariaICMS.SelectedIndex = -1, -1, cboSituacaoTributariaICMS.SelectedValue), _
                                                   cboSituacaoTributariaICMS.Text.Trim, _
                                                   3, _
                                                   txtPorcentagemReducaoBCICMS.Value, _
                                                   0, _
                                                   txtAliquotaICMS.Value, _
                                                   0, _
                                                   -1, _
                                                   txtIVA.Value, _
                                                   txtPorcentagemReducaoBCICMSST.Value, _
                                                   0, _
                                                   txtAliquotaICMSST.Value, _
                                                   0)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub InsertImpostoIPI(ByVal oRow As Janus.Windows.GridEX.GridEXRow)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona Item
            oClsUsrFatEmissaoNFe.InsertImpostoIPI(lCodigoEmissaoCapa, _
                                                  cboSituacaoTributariaIPI.Text, _
                                                  "", _
                                                  cboCodigoEnquadramento.Text, _
                                                  -1, _
                                                  IIf(txtAliquotaIPI.Value > 0, oRow.Cells.Item("valor_total").Value, 0), _
                                                  txtAliquotaIPI.Value, _
                                                  0, _
                                                  0)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message.ToString, Me.Parent.ToString)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            For Each oRow In grdListagem.GetRows
                If IsDBNull(oRow.Cells.Item("status").Value) = False Then
                    frmMain.Informacao("Linha " + CStr(oRow.RowIndex + 1) + " está com problema.", Color.Red)
                    Exit Function
                End If
            Next

            'Verifica se foi Selecionado o Campo - CFOP
            If ValidaCampo(cboCFOP, lblCFOP) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado a Situação Tributária do ICMS
            tabMain.SelectedTab = pagDados : tabTributo.SelectedTab = pagICMS
            If ValidaCampo(cboSituacaoTributariaICMS, lblSituacaoTributariaICMS) = False Then
                cboSituacaoTributariaICMS.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado a Situação Tributária do PIS
            If ValidaCampo(cboSituacaoTributariaPIS, lblSituacaoTributariaPIS) = False Then
                tabMain.SelectedTab = pagDados : tabTributo.SelectedTab = pagPIS
                cboSituacaoTributariaPIS.Focus()
                Exit Function
            End If


            'Verifica se foi Selecionado a Situação Tributária do COFINS
            If ValidaCampo(cboSituacaoTributariaCOFINS, lblSituacaoTributariaCOFINS) = False Then
                tabMain.SelectedTab = pagDados : tabTributo.SelectedTab = pagCOFINS
                cboSituacaoTributariaCOFINS.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            TratamentoErro(ex.Message.ToString, Me.Name)
        End Try

    End Function

#End Region

End Class