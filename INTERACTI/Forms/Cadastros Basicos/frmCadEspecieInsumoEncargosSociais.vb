Imports Janus.Windows.GridEX

Public Class frmCadEspecieInsumoEncargosSociais

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadEncargosSociais As New clsUsrCadEncargosSociais

    Private iCodigoEspecieInsumo As Integer
    Private oHashTable As New Hashtable

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoEspecieInsumo() As Integer
        Set(ByVal value As Integer)
            iCodigoEspecieInsumo = value
        End Set
    End Property

    Public Property Estrutura() As Hashtable
        Set(ByVal value As Hashtable)
            oHashTable = value
        End Set
        Get
            Return oHashTable
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadEspecieInsumoEncargosSociais_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadEspecieInsumoEncargosSociais_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagemEspecie.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagemEspecie.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagemEspecie.GroupByBoxVisible = True
                grdListagemEspecie.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagemEspecie
            oForm.NomeFormulario = Formulario.CadastroBasicoEncargos
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagemEspecie, Formulario.CadastroBasicoEncargos)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagemEspecie)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Váriaveis Locais
            Dim oEstrutura As EncargosSociais

            'Limpa HashTable
            oHashTable.Clear()

            'Carrega HashTable
            For Each oRow As GridEXRow In grdListagemEspecie.GetCheckedRows
                oEstrutura.iCodigoEncargo = oRow.Cells("codigo").Value
                oEstrutura.dPercentual = oRow.Cells("percentual").Value
                oHashTable.Add(oRow.Cells("codigo").Value, oEstrutura)
            Next

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagemEspecie_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagemEspecie.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemEspecie, _
                                     Formulario.CadastroBasicoEncargos)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemEspecie_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagemEspecie.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemEspecie.Name, _
                                     Formulario.CadastroBasicoEncargos, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemEspecie_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagemEspecie.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagemEspecie.Name, _
                                          Formulario.CadastroBasicoEncargos, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
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
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadEspecieInsumoEncargosSociais_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call ConfiguraGrid(grdListagemEspecie, Formulario.CadastroBasicoEncargos)

            'Seta Parametros
            Call oClsCadEncargosSociais.LoadGrid(grdListagemEspecie, _
                                                 iCodigoEspecieInsumo)

            'Verifica se foi preenchido algum valor anteriormente
            If oHashTable.Count > 0 Then
                For Each oEstrutura As EncargosSociais In oHashTable.Values
                    For Each oRow As GridEXRow In grdListagemEspecie.GetDataRows
                        If oRow.Cells("codigo").Value = oEstrutura.iCodigoEncargo Then
                            oRow.CheckState = RowCheckState.Checked
                            Call UpdateRegistroGrid(grdListagemEspecie, "codigo = " & oEstrutura.iCodigoEncargo, "percentual", oEstrutura.dPercentual)
                            Exit For
                        End If
                    Next
                Next
            End If

            'Atualiza Grid
            grdListagemEspecie.Refresh()

            'Seta Focu
            grdListagemEspecie.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class