Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.Math

Public Class frmFinReceitaImportarPagamentoCartao

#Region "::: VARIAVEIS :::"

    'Váriaveis
    Private oClsFinReceitaLancamento As New clsUsrFinReceitaLancamento



#End Region


#Region "::: CONTROLES :::"

    Private Sub grdBoleta_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated
        Try
            grdListagem.CurrentRow.Cells.Item("descricao").Value = LoadCodigo("sp_select_cadastro_basico_descricao_item " & CInt(grdListagem.CurrentRow.Cells("codigo_produto_servico").Value) & ", " & goUsuario.iEmpresa)
            grdListagem.CurrentRow.Cells.Item("codigo_ncm").Value = LoadCodigo("sp_select_cadastro_basico_item_codigo_ncm " & CInt(grdListagem.CurrentRow.Cells("codigo_produto_servico").Value) & ", " & goUsuario.iEmpresa)
            grdListagem.CurrentRow.Cells.Item("ncm").Value = LoadCodigo("sp_select_cadastro_basico_codigo_ncm_boleta " & CInt(grdListagem.CurrentRow.Cells("codigo_ncm").Value) & ", " & goUsuario.iEmpresa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub frmFatEmissaoNFeProdutoXML_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub



    Private Sub btnConfigurarGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridXML.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridXML.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridXML.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try
            Cursor.Current = Cursors.WaitCursor

            Dim sCodigo As String = ""

            For Each oRow In grdListagem.GetRows

                If oRow.Cells.Item("nome").Value = "" Or IsDBNull(oRow.Cells.Item("nome").Value) = True Then
                    Continue For
                End If

                sCodigo += CStr(oRow.Cells.Item("codigo").Value) + ","
            Next

            If sCodigo <> "" Then

                oClsFinReceitaLancamento.InsertPagamentoCartao(sCodigo)


                Cursor.Current = Cursors.Default
                'Fecha o Formulário
                Me.Dispose()
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Verifica se o usuário deseja cancelar a importação da Nota Fiscal Eletrônica
            If MsgBox("Deseja Cancelar a Importação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Váriavel 
                'sResultado = "N"

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNF_DropDown(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.DropDown

    End Sub

    Private Sub grdXML_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FaturamentoEntradaNF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEntradaNF, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))

            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            'Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)


            oClsFinReceitaLancamento.LoadGridPagamentoCartao(grdListagem)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try
            


        Catch ex As Exception
            Throw ex
        End Try

    End Sub
 


#End Region

End Class

