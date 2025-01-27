Public Class usrFat000000003

#Region "::: CONTROLES :::"

    Private Sub usrFat000000003_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFat000000003_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnGerarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarArquivo.Click

        Try

            'Gera Arquivo do Sintegra
            Call GerarArquivoSintegra()

            'Informa o Usuário sobre o sucesso da Operação
            MsgBox("Arquivo Sintegra Gerado com Sucesso!", MsgBoxStyle.Information, Me.Parent.Text)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega ComboBox
            Call LoadCombo(cboTipoDocumentoFiscal, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)

            'Verifica Direito
            btnGerarArquivo.Enabled = VerificaDireito(Formulario.RelatorioFAT000000003, gcPrint)

            'Configura DateTimePicker
            dtpDataEmissaoInicio.Value = DateAdd(DateInterval.Month, -1, Now.Date)
            dtpDataEmissaoTermino.Value = Now.Date

            'Seta Focu
            cboTipoDocumentoFiscal.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub GerarArquivoSintegra()

        Try

            'Váriaveis Locais
            Dim oFolderBrowserDialog As New FolderBrowserDialog

            'Abre PopUp para Usuário selecionar uma Pasta
            If oFolderBrowserDialog.ShowDialog() = DialogResult.OK Then

                'Váriavel - Classe Sintegra
                Dim oClsFAT000000003 As New clsUsrFAT000000003

                'Registro 10
                oClsFAT000000003.SintegraRegistro10(dtpDataEmissaoInicio.Value, _
                                                    dtpDataEmissaoTermino.Value)
                'Registro 11
                oClsFAT000000003.SintegraRegistro11(dtpDataEmissaoInicio.Value, _
                                                    dtpDataEmissaoTermino.Value)
                'Registro 50 - Emissão
                oClsFAT000000003.SintegraEmissaoRegistro50(dtpDataEmissaoInicio.Value, _
                                                           dtpDataEmissaoTermino.Value)
                'Registro 50 - Entrada
                oClsFAT000000003.SintegraEntradaRegistro50(dtpDataEmissaoInicio.Value, _
                                                           dtpDataEmissaoTermino.Value)
                'Registro 51 - Emissão
                oClsFAT000000003.SintegraEmissaoRegistro51(dtpDataEmissaoInicio.Value, _
                                                           dtpDataEmissaoTermino.Value)
                'Registro 51 - Entrada
                oClsFAT000000003.SintegraEntradaRegistro51(dtpDataEmissaoInicio.Value, _
                                                           dtpDataEmissaoTermino.Value)
                'Registro 54 - Emissão
                oClsFAT000000003.SintegraEmissaoRegistro54(dtpDataEmissaoInicio.Value, _
                                                           dtpDataEmissaoTermino.Value)
                'Registro 54 - Entrada
                oClsFAT000000003.SintegraEntradaRegistro54(dtpDataEmissaoInicio.Value, _
                                                           dtpDataEmissaoTermino.Value)
                'Registro 70
                oClsFAT000000003.SintegraEntradaRegistro70(dtpDataEmissaoInicio.Value, _
                                                           dtpDataEmissaoTermino.Value)
                'Registro 75
                oClsFAT000000003.SintegraRegistro75(dtpDataEmissaoInicio.Value, _
                                                    dtpDataEmissaoTermino.Value)
                'Registro 90
                oClsFAT000000003.SintegraRegistro90(oFolderBrowserDialog.SelectedPath & "\SINTEGRA_" & Format(dtpDataEmissaoInicio.Value, "yyyyMMdd") & "_" & Format(dtpDataEmissaoTermino.Value, "yyyyMMdd") & ".txt")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
