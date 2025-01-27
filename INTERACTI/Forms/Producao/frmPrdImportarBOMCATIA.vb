Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdImportarBOMCATIA

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
    Private lCodigoOrdemProducao As Long
    Private lCodigoRequisicao As Long


#End Region

#Region "::: PROPERTY :::"
 
    Public Property CodigoOrdemProducao() As Long
        Get
            Return lCodigoOrdemProducao
        End Get
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

    Public Property CodigoRequisicao As Long
        Get
            Return lCodigoRequisicao
        End Get
        Set(value As Long)
            lCodigoRequisicao = value
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
        ConfigurarFormulario()

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            If MsgBox("Deseja importar a estrutura do catia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Importando BOM CATIA") = vbNo Then Exit Sub

            Importar()

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnArquivo_Click(sender As Object, e As EventArgs) Handles btnArquivo.Click

        Try

            LoadArquivo()

        Catch ex As Exception
            Throw ex
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

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadArquivo()

        Dim oApplicationClass As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim oArquivoExcel As New OpenFileDialog
        Dim i As Integer

        Try
            'Variaveis Locais
            Dim oArquivo As New OpenFileDialog
            Dim sReturn As String

            Dim iLinhaVazia As Integer = 0

            'Abre PopUp para Usuário selecionar a NFe
            'oArquivoXML.InitialDirectory = "c:\\dados"
            oArquivo.Filter = "(Arquivo BOM CATIA)|*.XLS;*.XLSX"
            oArquivo.Title = "Selecione o Arquivo"

            'Verifica se foi encontrado o Arquivo
            If oArquivo.ShowDialog() = DialogResult.OK Then

                'Seta Controles
                txtArquivo.Text = oArquivo.FileName
                'Excluir os arquivos anteirores 
                ExecuteQuery("sp_delete_integracao_estrutura_catia_temp " & goUsuario.iEmpresa)

                'Abre o Arquivo
                oApplicationClass.Workbooks.Open(txtArquivo.Text)

                'Primeiro item, é a OP pai
                Dim sCodigoPai As String = txtDescricaoProduto.Text
                
                'Percorre Linha a Linha o Arquivo
                For i = 5 To oApplicationClass.Rows.Count

                    lblLinha.Text = "Linha " & CStr(i)
                    Application.DoEvents()

                    'Verifica
                    If iLinhaVazia > 5 Then Exit For

                    'Verifica se acabou os registros
                    If oApplicationClass.Range("A" & i).Value Is Nothing Then
                        iLinhaVazia += 1
                        Continue For
                    End If
                    If oApplicationClass.Range("A" & i).Value.ToString.Contains("Recapitulation") Then
                        Exit For
                    End If

                    If oApplicationClass.Range("A" & i).Value.ToString.Contains("Bill of Material:") Then

                        sCodigoPai = oApplicationClass.Range("A" & i).Value.ToString.Replace("Bill of Material:", "")
                        sCodigoPai = sCodigoPai.Trim

                    End If


                    'Verifica se acabou os registros
                    If oApplicationClass.Range("B" & i).Value Is Nothing Then
                        iLinhaVazia += 1
                        Continue For
                    End If

                   

                    'Verfica se é o item
                    If IsNumeric(oApplicationClass.Range("A" & i).Value) Then

                        iLinhaVazia = 0

                        'Insere na tabela temporária
                        oClsUsrPrdProducaoManual.InsertBOMCATIA(oApplicationClass.Range("B" & i).Value, _
                                                                oApplicationClass.Range("A" & i).Value, _
                                                                sCodigoPai, _
                                                                oApplicationClass.Range("C" & i).Value, _
                                                                oApplicationClass.Range("D" & i).Value, _
                                                                IIf(IsDBNull(oApplicationClass.Range("E" & i).Value), "SEM DESCRIÇÃO", oApplicationClass.Range("E" & i).Value), _
                                                                "", _
                                                                oApplicationClass.Range("F" & i).Value)

                    End If


                Next

            End If

            oApplicationClass.Workbooks.Close()

            'Carrega os dados
            oClsUsrPrdProducaoManual.LoadGridBOMCatia(grdListagem, lCodigoOrdemProducao)



        Catch ex As Exception
            oApplicationClass.Workbooks.Close()

            Throw ex
        End Try


    End Sub

    Private Sub Importar()
        Try

            Dim lCodigoItem As Long

            PgrsBar.Maximum = grdListagem.GetRows.Count

            'Percorre os itens que terão que abrir OP, pois tem filhos
            For i As Integer = 0 To grdListagem.GetRows.Count - 1
                'Seta a linha
                grdListagem.Row = i

                If i = 31 Then
                    i = 31
                End If

                'Incrementa
                PgrsBar.Value = i
                Application.DoEvents()


                Dim lCodigoNovaOrdemProducao As Long

                'Se for a main, já está aberta a OP
                If IsDBNull(grdListagem.GetValue("codigo_ordem_producao")) Then


                    'Verifica se já foi cadastrado o item
                    lCodigoItem = LoadCodigo("sp_select_integracao_estrutura_catia_temp_codigo_produto '" & grdListagem.GetValue("codigo") & "'," & goUsuario.iEmpresa)

                    'Se ainda não for cadastrado,gerar
                    If lCodigoItem = -1 Then
                        lCodigoItem = oClsUsrPrdProducaoManual.InsertCadastroBasicoProdutoOP(
                                                                                    -1, _
                                                                                      grdListagem.GetValue("descricao"), _
                                                                                      "", _
                                                                                     0, _
                                                                                     0, _
                                                                                     0, _
                                                                                      0, _
                                                                                      5, _
                                                                                      lCodigoOrdemProducao, _
                                                                                      grdListagem.GetValue("codigo")) ' 5 - pc

                    End If


                'Cria um item na requisição da OP pai, para a OP nova
                Dim iCodigoRequisicaoItem As Integer = oClsUsrPrdProducaoManual.InsertRequisicaoItem(lCodigoRequisicao)

                'Atualiza os dados de requisição criada
                    oClsUsrPrdProducaoManual.UpdateRequisicaoEstoque(iCodigoRequisicao:=lCodigoRequisicao,
                                                                     iCodigoRequisicaoItem:=iCodigoRequisicaoItem,
                                                                     iCodigoGrupoItem:=-1, _
                                                                     iCodigoItem:=lCodigoItem, _
                                                                     dQuantidade:=grdListagem.GetValue("quantidade"),
                                                                     dMedida1:=0,
                                                                     dMedida2:=0,
                                                                     dMedida3:=0,
                                                                     dMedida4:=0,
                                                                     dPeso:=0,
                                                                     iCodigoUnidadeMedida:=5, _
                                                                     sCodigoProduto:="", _
                                                                     sDescricao:=grdListagem.GetValue("quantidade"), _
                                                                     iCodigoTipoItemRequisicao:=IIf(grdListagem.GetValue("tipo").ToString.ToUpper = "MATERIAL", 2, 1), _
                                                                     bItemCompra:=False, _
                                                                     sDataNecessidade:="", _
                                                                     sObservacao:="", _
                                                                     sObservacaoInterna:="", _
                                                                     sReferenciaEstrutura:=grdListagem.GetValue("codigo"))

                    Dim lCodigoOPPai As Long = LoadCodigo("sp_select_integracao_estrutura_catia_temp_op_pai " & grdListagem.GetValue("sequencia_pai") & "," & goUsuario.iEmpresa)

                    If lCodigoOPPai = -1 Then
                        lCodigoOPPai = lCodigoOrdemProducao
                    End If

                'Abre a ordem de produção
                    lCodigoNovaOrdemProducao = oClsUsrPrdProducaoManual.InsertOrdemProducaoRequisicao(lCodigoOrdemProducaoPai:=lCodigoOPPai, _
                                                                       lCodigoRequisicaoPai:=lCodigoRequisicao, _
                                                                       iCodigoRequisicaoItemPai:=iCodigoRequisicaoItem, _
                                                                       sCodigoProdutoCliente:=grdListagem.GetValue("codigo_produto_cliente"), _
                                                                        sNumeroDesenho:=grdListagem.GetValue("numero_desenho"), _
                                                                         sSubconjunto:=grdListagem.GetValue("subconjunto"), _
                                                                         sDetalhe:=grdListagem.GetValue("detalhe"), _
                                                                         lCodigoItem:=lCodigoItem, _
                                                                         sReferenciaEstrutura:=grdListagem.GetValue("codigo"))
                'Seta na listagem o codigo da ordem gerada
                grdListagem.SetValue("codigo_ordem_producao", lCodigoNovaOrdemProducao)

                Else

                    lCodigoNovaOrdemProducao = grdListagem.GetValue("codigo_ordem_producao")

                End if 


                'Atualiza o código na estrutura
                ExecuteQuery("sp_update_integracao_estrutura_catia_temp_codigo_ordem_producao '" & grdListagem.GetValue("codigo") & "'," & lCodigoNovaOrdemProducao & "," & goUsuario.iEmpresa)

                'Se for a main não entrar nos filhos pois abrirá as OP'
                If grdListagem.GetValue("tipo") = "main" Then Continue For

                'Agora insere os itens da lista como requisição
                For Each oRowChildren In grdListagem.CurrentRow.GetChildRows

                    'Verifica se já foi cadastrado o item
                    lCodigoItem = LoadCodigo("sp_select_integracao_estrutura_catia_temp_codigo_produto '" & oRowChildren.Cells.Item("codigo").Value & "'," & goUsuario.iEmpresa)

                    'Se ainda não for cadastrado,gerar
                    If lCodigoItem = -1 Then
                        lCodigoItem = oClsUsrPrdProducaoManual.InsertCadastroBasicoProdutoOP(
                                                                                    -1, _
                                                                                      oRowChildren.Cells.Item("descricao").Value, _
                                                                                      "", _
                                                                                     0, _
                                                                                     0, _
                                                                                     0, _
                                                                                      0, _
                                                                                      5, _
                                                                                      lCodigoNovaOrdemProducao, _
                                                                                      oRowChildren.Cells.Item("codigo").Value) ' 5 - pc
                    End If

                    'Verifica a requisição criada
                    Dim lCodigoNovaRequisicao As Long = LoadCodigo("sp_select_estoque_requisicao_ordem_producao_codigo " & lCodigoNovaOrdemProducao & "," & goUsuario.iEmpresa)

                    'Cria um item na requisição da OP pai, para a OP nova
                    Dim iCodigoRequisicaoItem As Integer = oClsUsrPrdProducaoManual.InsertRequisicaoItem(lCodigoNovaRequisicao)


                    'Atualiza os dados de requisição criada
                    oClsUsrPrdProducaoManual.UpdateRequisicaoEstoque(iCodigoRequisicao:=lCodigoNovaRequisicao,
                                                                     iCodigoRequisicaoItem:=iCodigoRequisicaoItem,
                                                                     iCodigoGrupoItem:=-1, _
                                                                     iCodigoItem:=lCodigoItem, _
                                                                     dQuantidade:=oRowChildren.Cells("quantidade").Value,
                                                                     dMedida1:=0,
                                                                     dMedida2:=0,
                                                                     dMedida3:=0,
                                                                     dMedida4:=0,
                                                                     dPeso:=0,
                                                                     iCodigoUnidadeMedida:=5, _
                                                                     sCodigoProduto:="", _
                                                                     sDescricao:=oRowChildren.Cells.Item("quantidade").Value, _
                                                                     iCodigoTipoItemRequisicao:=IIf(oRowChildren.Cells.Item("tipo").Value.ToString.ToUpper = "MATERIAL", 2, 1), _
                                                                     bItemCompra:=False, _
                                                                     sDataNecessidade:="", _
                                                                     sObservacao:="", _
                                                                     sObservacaoInterna:="", _
                                                                     sReferenciaEstrutura:=oRowChildren.Cells.Item("codigo").Value)




                Next



            Next


            'Agora reoorganizar os codigo OP pai
            'ExecuteQuery("sp_update_integracao_estrutura_catia_temp_hierarquia " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region


    

End Class