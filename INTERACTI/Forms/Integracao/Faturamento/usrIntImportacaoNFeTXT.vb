Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO
Imports INTERACTI.clsUsrIntImportacaoItem
Imports INTERACTI.NFe.ValidaXML

Public Class usrIntImportacaoNFeTXT

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Arquivo As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsIntImportacaoNFe As New clsUsrIntImportacaoNFe
    Private oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe
    Private oClsFatEmissaoNFeItem As New clsFrmFatEmissaoNFeProduto
    Private oClsFatEmissaoNFeLocalRetirada As New clsFrmFatEmissaoNFeLocalRetirada
    Private oClsFatEmissaoNFeLocalEntrega As New clsFrmFatEmissaoNFeLocalEntrega
    Private oClsFatEmissaoNFeVolumeLacre As New clsFrmFatEmissaoNFeVolumeLacre

#End Region

#Region "::: ENUM :::"

    'Variáveis da Classe
    Private Enum B
        UFEmitente = 1
        CodigoNumericoChaveAcesso = 2
        NaturezaOperacao = 3
        FormaPagamento = 4
        Modelo = 5
        Serie = 6
        NotaFiscal = 7
        DataHoraEmissão = 8
        DataHoraSaida = 9
        TipoNotaFiscal = 10
        LocalDestinoOperacao = 11
        CodigoMunicipioFatorGerador = 12
        FormatoImpressao = 13
        FormaEmissao = 14
        DigitoVerificador = 15
        TipoAmbiente = 16
        FinalidadeNFe = 17
        OperacaoConsumidorFinal = 18
        PresencaComprador = 19
        ProcessoEmissaoNFe = 20
        VersaoProcessoEmissao = 21
        DataHoraEntradaContigencia = 22
        JustificativaContigencia = 23
    End Enum

    'Variáveis da Classe
    Private Enum B_OLD
        UFEmitente = 1
        CodigoNumericoChaveAcesso = 2
        NaturezaOperacao = 3
        FormaPagamento = 4
        Modelo = 5
        Serie = 6
        NotaFiscal = 7
        DataEmissão = 8
        DataSaida = 9
        HoraSaida = 10
        TipoNotaFiscal = 11
        CodigoMunicipioFatorGerador = 12
        FormatoImpressao = 13
        FormaEmissao = 14
        DigitoVerificador = 15
        TipoAmbiente = 16
        FinalidadeNFe = 17
        ProcessoEmissaoNFe = 18
        VersaoProcessoEmissao = 19
        DataHoraEntradaContigencia = 20
        JustificativaContigencia = 21
    End Enum

    Private Enum C
        RazaoSocial = 1
        NotaFantasia = 2
        InscricaoEstadual = 3
        InscricaoEstadualST = 4
        InscricaoMunicipal = 5
        CNAE = 6
        RegimeTributario = 7
        CnpjCPF = 1
        Logradouro = 1
        Numero = 2
        Complemento = 3
        Bairro = 4
        CoidigoMunicipio = 5
        NomeMunicipio = 6
        UF = 7
        CEP = 8
        CodigoPais = 9
        Pais = 10
        Telefone = 11
    End Enum

    Private Enum E
        RazaoSocial = 1
        InscricaoEstadual = 2
        InscricaoSuframa = 3
        Email = 4
        CnpjCPF = 1
        Logradouro = 1
        Numero = 2
        Complemento = 3
        Bairro = 4
        CodigoMunicipio = 5
        NomeMunicipio = 6
        UF = 7
        CEP = 8
        CodigoPais = 9
        Pais = 10
        Telefone = 11
    End Enum

    Private Enum F
        Logradouro = 1
        Numero = 2
        Complemento = 3
        Bairro = 4
        CodigoMunicipio = 5
        NomeMunicipio = 6
        UF = 7
        CNPJCPF = 1
    End Enum

    Private Enum G
        Logradouro = 1
        Numero = 2
        Complemento = 3
        Bairro = 4
        CodigoMunicipio = 5
        NomeMunicipio = 6
        UF = 7
        CNPJCPF = 1
    End Enum

    Private Enum H
        InformacaoAdicionalProduto = 2
        CodigoProduto = 1
        CodigoEAN = 2
        Descricao = 3
        NCM = 4
        EXTIPI = 5
        CEST = 6
        ___ = 7
        CFOP = 8
        UnidadeMedidaComercial = 9
        QuantidadeComercial = 10
        ValorUnitarioComercial = 11
        ValorTotal = 12
        CodigoEANTrib = 13
        UnidadeMedidaTrib = 14
        QuantidadeTrib = 15
        ValorUnitarioTrib = 16
        ValorFrete = 17
        ValorSeguro = 18
        ValorDesconto = 19
        ValorOutro = 20
        IncideTotal = 21
        NumeroPedido = 22
        NumeroItemPedido = 23
        FCI = 24
    End Enum

    Private Enum N02
        OrigemItem = 1
        SituacaoTributaria = 2
        ModalidadeBaseCalculoICMS = 3
        BaseCalculo = 4
        Aliquota = 5
        Valor = 6
    End Enum

    Private Enum N03
        OrigemItem = 1
        SituacaoTributaria = 2
        ModalidadeBaseCalculoICMS = 3
        BaseCalculo = 4
        Aliquota = 5
        Valor = 6
        ModalidadeBaseCalculoICMSST = 7
        IVA = 8
        ReducaoBaseCalculoST = 8
        BaseCalculoST = 9
        AliquotaST = 10
        ValorST = 11
    End Enum

    Private Enum N04
        OrigemItem = 1
        SituacaoTributaria = 2
        ModalidadeBaseCalculoICMS = 3
        ReducaoBaseCalculo = 4
        BaseCalculo = 5
        Aliquota = 6
        Valor = 7
        ValorDesonerado = 8
        MotivoDesoneracao = 9
    End Enum

    Private Enum N05
        OrigemItem = 1
        SituacaoTributaria = 2
        ModalidadeBaseCalculoICMSST = 3
        IVA = 4
        ReducaoBaseCalculoST = 5
        BaseCalculoST = 6
        AliquotaST = 7
        ValorST = 8
        ValorDesonerado = 9
        MotivoDesoneracao = 10
    End Enum

    Private Enum N06
        OrigemItem = 1
        SituacaoTributaria = 2
        ValorDesonerado = 3
        MotivoDesoneracao = 4
    End Enum

    Private Enum N07
        OrigemItem = 1
        SituacaoTributaria = 2
        ModalidadeBaseCalculoICMS = 3
        ReducaoBaseCalculo = 5
        BaseCalculo = 6
        Aliquota = 7
        ValosICMSOperacao = 8
        PercentualDiferimento = 9
        ValorICMSDiferido = 10
        ValorICMS = 11
    End Enum

    Private Enum N08
        OrigemItem = 1
        SituacaoTributaria = 2
        BaseCalculoRetido = 3
        ValorICMSRetido = 4
    End Enum

    Private Enum N09
        OrigemItem = 1
        SituacaoTributaria = 2
        ModalidadeBaseCalculoICMS = 3
        ReducaoBaseCalculo = 4
        BaseCalculo = 5
        Aliquota = 6
        Valor = 7
        ModalidadeBaseCalculoICMSST = 8
        IVA = 9
        ReducaoBaseCalculoST = 10
        BaseCalculoST = 11
        AliquotaST = 12
        ValorST = 13
        ValorDesonerado = 14
        MotivoDesoneracao = 15
        BaseCalculoRetido = 3
        ValorICMSRetido = 4
    End Enum

    Private Enum N10
        OrigemItem = 1
        SituacaoTributaria = 2
        ModalidadeBaseCalculoICMS = 3
        BaseCalculo = 4
        ReducaoBaseCalculo = 5
        Aliquota = 6
        Valor = 7
        ModalidadeBaseCalculoICMSST = 8
        IVA = 9
        ReducaoBaseCalculoST = 10
        BaseCalculoST = 11
        AliquotaST = 12
        ValorST = 13
        ValorDesonerado = 14
        MotivoDesoneracao = 15
        BaseCalculoRetido = 3
        ValorICMSRetido = 4
    End Enum

    Private Enum N10a
        OrigemItem = 1
        SituacaoTributaria = 2
        ModalidadeBaseCalculoICMS = 3
        BaseCalculo = 4
        ReducaoBaseCalculo = 5
        Aliquota = 6
        Valor = 7
        ModalidadeBaseCalculoICMSST = 8
        IVA = 9
        ReducaoBaseCalculoST = 10
        BaseCalculoST = 11
        AliquotaST = 12
        ValorST = 13
        BaseCalculoOperacaoPropria = 14
        UFDevidoICMSST = 15
    End Enum

    Private Enum N10b
        OrigemItem = 1
        SituacaoTributaria = 2
        BaseCalculoRetencao = 3
        ValorRetido = 4
        BaseCalculoSTUF = 5
        ValorSTUF = 6
    End Enum

    Private Enum O
        ClasseEnquadramento = 1
        CNPJProdutor = 2
        Selo = 3
        QuantidadeSelo = 4
        CodigoEnquadramento = 5       
    End Enum

    Private Enum O07
        SituacaoTributaria = 1
    End Enum

    Private Enum O08
        SituacaoTributaria = 1
    End Enum

    Private Enum O10
        BaseCalculo = 1
        AliquotaIPI = 2
    End Enum

    Private Enum O11
        QuantidadeUnidade = 1
        ValorUnidade = 2
        ValorIPI = 3
    End Enum

    Private Enum P
        BaseCalculo = 1
        DespesaAduaneira = 2
        ValorII = 3
        ValorIOF = 4
    End Enum

    Private Enum Q02
        SituacaoTributaria = 1
        BaseCalculo = 2
        Aliquota = 3
        Valor = 4
    End Enum

    Private Enum Q03
        SituacaoTributaria = 1
        BaseCalculoProduto = 2
        AliquotaProduto = 3
        Valor = 4
    End Enum

    Private Enum Q04
        SituacaoTributaria = 1
    End Enum

    Private Enum Q05
        SituacaoTributaria = 1
    End Enum

    Private Enum Q07
        BaseCalculo = 1
        Aliquota = 2
        Valor = 3
    End Enum

    Private Enum Q10
        BaseCalculoProduto = 1
        AliquotaProduto = 2
    End Enum

    Private Enum R
        Valor = 1
    End Enum

    Private Enum R02
        BaseCalculo = 1
        AliquotaPIS = 2
    End Enum

    Private Enum R04
        QuantidadeProduto = 1
        AliquotaProduto = 2
        Valor = 3
    End Enum

    Private Enum S02
        SituacaoTributaria = 1
        BaseCalculo = 2
        Aliquota = 3
        Valor = 4
    End Enum

    Private Enum S03
        SituacaoTributaria = 1
        BaseCalculoProduto = 2
        AliquotaProduto = 3
        Valor = 4
    End Enum

    Private Enum S04
        SituacaoTributaria = 1
    End Enum

    Private Enum S05
        SituacaoTributaria = 1
        Valor = 2
    End Enum

    Private Enum S07
        BaseCalculo = 1
        Aliquota = 2
    End Enum

    Private Enum S09
        BaseCalculoProduto = 1
        AliquotaProduto = 2
    End Enum

    Private Enum T
        Valor = 1
    End Enum

    Private Enum T02
        BaseCalculo = 1
        AliquotaCOFINS = 2
    End Enum

    Private Enum T04
        QuantidadeProduto = 1
        AliquotaProduto = 2
    End Enum

    Private Enum W02
        BaseCalculoICMS = 1
        ValorICMS = 2
        ValorICMSDesonerado = 3
        BaseCalculoICMSST = 4
        ValorICMSST = 5

        __1 = 6
        __2 = 7
        __3 = 8

        ValorProduto = 9
        ValorFrete = 10
        ValorSeguro = 11
        ValorDesconto = 12
        ValorII = 13
        ValorIPI = 14
        ValorPIS = 15
        ValorCOFINS = 16
        ValorOutras = 17
        ValorNotaFiscal = 18
        ValorTotalTributado = 19
    End Enum

    Private Enum X
        ModalidadeFrete = 1
    End Enum

    Private Enum X03
        RazaoSocial = 1
        InscricaoEstadual = 2
        Endereco = 3
        Municipio = 4
        UF = 5
    End Enum

    Private Enum X04
        CNPJCPF = 1
    End Enum

    Private Enum X05
        CNPJCPF = 1
    End Enum

    Private Enum X11
        ValorServico = 1
        BaseCalculoRetido = 2
        AliquotaRetido = 3
        ValorRetido = 4
        CFOP = 5
        CodigoMunicipioOcorrencia = 6
    End Enum

    Private Enum X18
        Placa = 1
        UF = 2
        RNTC = 3
    End Enum

    Private Enum X22
        Placa = 1
        UF = 2
        RNTC = 3
        Vagao = 4
        Balsa = 5
    End Enum

    Private Enum X26
        Quantidade = 1
        Especie = 2
        Marca = 3
        Volume = 4
        PesoLiquido = 5
        PesoBruto = 6
    End Enum

    Private Enum X33
        Lacre = 1
    End Enum

    Private Enum Y02
        Fatura = 1
        ValorOrigem = 2
        ValorDesconto = 3
        ValorLiquido = 4
    End Enum

    Private Enum Y07
        Duplicata = 1
        DataVencimento = 2
        Valor = 3
    End Enum

    Private Enum Z
        InformacaoAdicionalFisco = 1
        InformacaoAdicionalComplemento = 2
    End Enum

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrIntImportacaoNFeTXT_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.IntegracaoImportarNFeTXT
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.IntegracaoImportarNFeTXT)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasta.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controle
            txtPasta.Text = ""
            'Carrega Arquivo
            Call LoadArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Importa Itens
            Call Importar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "visualizar" : Call VisualizarDocumento(grdListagem.CurrentRow.Cells("arquivo").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.IntegracaoImportarNFeTXT)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.IntegracaoImportarNFeTXT, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica Direito
            btnPasta.Enabled = VerificaDireito(Formulario.IntegracaoImportarNFeTXT, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.IntegracaoImportarNFeTXT, gcInsert)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.IntegracaoImportarNFeTXT)

            'Seta Focu
            btnPasta.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Arquivo
            If txtPasta.Text = "" Then
                'Váriaveis Locais
                Dim oFolder As New FolderBrowserDialog
                'Verifica se foi Selecionado algum Arquivo
                If oFolder.ShowDialog = DialogResult.OK Then
                    txtPasta.Text = oFolder.SelectedPath
                End If
                'Desabilita FolderDialog
                oFolder.Dispose()
            End If

            'Verifica se foi selecionado alguma Pasta
            If txtPasta.Text <> "" Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Limpa Grid
                grdListagem.DataSource = Nothing

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCArquivo As New DataColumn("arquivo")
                Dim oDCImportado As New DataColumn("importado")

                oDCImportado.DataType = False.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCArquivo)
                oDataTable.Columns.Add(oDCImportado)

                'Carrega Arquivos
                Call LoadArquivo(txtPasta.Text, oDataTable)

                'Preenche Grid
                Call ConfigurarDataMemberGrid(grdListagem)

                'Carrega Grid
                grdListagem.DataSource = oDataSet.DefaultViewManager
                grdListagem.DataMember = oDataSet.Tables(0).TableName

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadArquivo(ByVal sFolder As String, _
                            ByRef oDataTable As DataTable)

        Try

            Dim sFile As String = ""
            Dim sFolderChildren As String = ""

            For Each sFile In Directory.GetFiles(sFolder)
                If sFile.ToLower.Contains(".txt") = True Then
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("arquivo") = sFile
                    oDataRow("importado") = oClsIntImportacaoNFe.ArquivoImportado(sFile)
                    oDataTable.Rows.Add(oDataRow)
                End If
            Next

            For Each sFolderChildren In Directory.GetDirectories(sFolder)
                Call LoadArquivo(sFolderChildren, oDataTable)
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtPasta.Text = ""
            grdListagem.DataSource = Nothing

            'Seta Focu
            btnPasta.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Importar()

        Dim sPrimeiraNota As String = ""

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Carrega Dados da NFe
                Call LoadConfiguracaoNFe()

                'Váriavel Local
                Dim oMensagem() As MensagemErro
                Dim sMensagem As String

                Dim iCodigo As Integer

                'Redimensiona Vetor
                ReDim oMensagem(0)
                oMensagem(0).Arquivo = ""
                oMensagem(0).Erro = ""

                For Each oRow As GridEXRow In gSelecaoRow

                    sMensagem = ""

                    'Verifica se o Arquivo Existe
                    If System.IO.File.Exists(oRow.Cells("arquivo").Value) Then

                        'Carrega Arquivo XML
                        Dim oStreamReader As StreamReader = New StreamReader(oRow.Cells("arquivo").Value.ToString)
                        Dim sLinha As String = ""
                        Dim sCampo() As String

                        'Seta Progressbar
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oStreamReader.ReadToEnd.Split(vbCrLf).Count
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                        frmMain.stbMain.Panels("pnlProgressBar").Visible = True

                        oStreamReader = New StreamReader(oRow.Cells("arquivo").Value.ToString)

                        'Verifica quantos registros existe
                        While IsNothing(sLinha) = False

                            'Le a Linha
                            sLinha = oStreamReader.ReadLine

                            'Verifica se a linha é válida
                            If IsNothing(sLinha) Then Exit While

                            'Carrega Váriaveis
                            sCampo = sLinha.Split("|")

                            'Verifica o Tipo
                            Select Case sCampo(0)
                                Case "A"
                                    iCodigo = 1
                                    'Insere Nota Fiscal
                                    Call oClsFatEmissaoNFe.InsertNotaFiscal()
                                Case "B"

                                    Select Case UBound(sCampo) + 1

                                        Case 23, 25
                                            oClsFatEmissaoNFe.NotaFiscal = sCampo(B.NotaFiscal)

                                            'Valida se existe a nota
                                            If oClsFatEmissaoNFe.ValidaNumeracaoNFe(oClsFatEmissaoNFe.NotaFiscal) = False Then

                                                'Informa ao usuário
                                                MsgBox("A numeração de NF [ " & oClsFatEmissaoNFe.NotaFiscal & " ] já foi utilizada! Importação cancelada!", MsgBoxStyle.Exclamation, "Erro na importação")

                                                'Exclui as notas já importadas, não autorizadas
                                                If sPrimeiraNota <> "" Then oClsFatEmissaoNFe.ExcluirNumeracaoNFe(sPrimeiraNota)

                                                'Sai do procedimento
                                                Exit Sub

                                            Else

                                                'Seta a primeira nota importada, caso precise reverter o processo
                                                sPrimeiraNota = oClsFatEmissaoNFe.NotaFiscal

                                            End If



                                            oClsFatEmissaoNFe.ModeloNotaFiscal = sCampo(B.Modelo)
                                            oClsFatEmissaoNFe.SequenciaNotaFiscal = sCampo(B.Serie)
                                            oClsFatEmissaoNFe.Serie = sCampo(B.Serie)
                                            oClsFatEmissaoNFe.DataEmissao = sCampo(B.DataHoraEmissão)
                                            oClsFatEmissaoNFe.NaturezaOperacao = sCampo(B.NaturezaOperacao)
                                            oClsFatEmissaoNFe.DataSaida = sCampo(B.DataHoraSaida)
                                            oClsFatEmissaoNFe.TipoItem = TipoItem.produto
                                            oClsFatEmissaoNFe.CodigoFormaEmissaoNFe = sCampo(B.FormaEmissao)
                                            oClsFatEmissaoNFe.CodigoTipoOperacaoNFe = TipoNotaFiscal.NotaFiscalEletronica
                                            oClsFatEmissaoNFe.CodigoTipoConsumidor = sCampo(B.OperacaoConsumidorFinal)
                                            oClsFatEmissaoNFe.CodigoFinalidadeEmissaoNFe = sCampo(B.FinalidadeNFe)
                                            oClsFatEmissaoNFe.CodigoTipoDocumentoFiscal = sCampo(B.TipoNotaFiscal)
                                            oClsFatEmissaoNFe.CodigoFormaPagamento = sCampo(B.FormaPagamento)
                                            Call oClsFatEmissaoNFe.UpdateNotaFiscal()

                                            'Case 21
                                            '    oClsFatEmissaoNFe.NotaFiscal = sCampo(B_OLD.NotaFiscal)
                                            '    oClsFatEmissaoNFe.ModeloNotaFiscal = sCampo(B_OLD.Modelo)
                                            '    oClsFatEmissaoNFe.SequenciaNotaFiscal = sCampo(B_OLD.Serie)
                                            '    oClsFatEmissaoNFe.Serie = sCampo(B_OLD.Serie)
                                            '    oClsFatEmissaoNFe.DataEmissao = sCampo(B_OLD.DataEmissão)
                                            '    oClsFatEmissaoNFe.NaturezaOperacao = sCampo(B_OLD.NaturezaOperacao)
                                            '    oClsFatEmissaoNFe.DataSaida = sCampo(B_OLD.DataSaida)
                                            '    oClsFatEmissaoNFe.TipoItem = TipoItem.produto
                                            '    oClsFatEmissaoNFe.CodigoFormaEmissaoNFe = sCampo(B_OLD.FormaEmissao)
                                            '    oClsFatEmissaoNFe.CodigoTipoOperacaoNFe = TipoNotaFiscal.NotaFiscalEletronica
                                            '    oClsFatEmissaoNFe.CodigoTipoConsumidor = TipoConsumidor.ConsumidorFinal
                                            '    oClsFatEmissaoNFe.CodigoFinalidadeEmissaoNFe = sCampo(B_OLD.FinalidadeNFe)
                                            '    oClsFatEmissaoNFe.CodigoTipoDocumentoFiscal = TipoDocumentoFiscal.Saida
                                            '    oClsFatEmissaoNFe.CodigoFormaPagamento = sCampo(B_OLD.FormaPagamento)
                                            '    Call oClsFatEmissaoNFe.UpdateNotaFiscal()

                                    End Select

                                Case "C" : Call oClsFatEmissaoNFe.InsertEmitente()

                                Case "E"
                                    oClsFatEmissaoNFe.CodigoDestinatario = 0
                                    oClsFatEmissaoNFe.RazaoSocialDestinatario = sCampo(E.RazaoSocial)
                                    oClsFatEmissaoNFe.CnpjCpfDestinatario = sCampo(E.CnpjCPF)
                                    oClsFatEmissaoNFe.InscricaoEstadualDestinatario = "" 'sCampo(E.InscricaoEstadual)

                                    oClsFatEmissaoNFe.InscricaoSuframaDestinatario = sCampo(E.InscricaoSuframa)
                                    oClsFatEmissaoNFe.EmailDestinatario = sCampo(E.Email)

                                Case "E02" : oClsFatEmissaoNFe.CnpjCpfDestinatario = sCampo(E.CnpjCPF)

                                Case "E03" : oClsFatEmissaoNFe.CnpjCpfDestinatario = sCampo(E.CnpjCPF)

                                Case "E03a" : oClsFatEmissaoNFe.CnpjCpfDestinatario = sCampo(E.CnpjCPF)

                                Case "E05"
                                    oClsFatEmissaoNFe.LogradouroDestinatario = sCampo(E.Logradouro)
                                    oClsFatEmissaoNFe.NumeroDestinatario = sCampo(E.Numero)
                                    oClsFatEmissaoNFe.ComplementoDestinatario = sCampo(E.Complemento)
                                    oClsFatEmissaoNFe.BairroDestinatario = sCampo(E.Bairro)
                                    oClsFatEmissaoNFe.CodigoMunicipioDestinatario = IIf(sCampo(E.CodigoMunicipio) = "", -1, LoadDescricao("sp_select_static_codigo_municipio_ibge '" & sCampo(E.CodigoMunicipio) & "'"))
                                    oClsFatEmissaoNFe.UFDestinatario = sCampo(E.UF)
                                    oClsFatEmissaoNFe.CepDestinatario = sCampo(E.CEP)
                                    oClsFatEmissaoNFe.CodigoPaisDestinatario = sCampo(E.CodigoPais)
                                    oClsFatEmissaoNFe.TelefoneDestinatario = sCampo(E.Telefone)
                                    oClsFatEmissaoNFe.OutroLugarRetirada = False
                                    oClsFatEmissaoNFe.OutroLugarEntrega = False

                                Case "F"
                                    oClsFatEmissaoNFeLocalRetirada.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
                                    oClsFatEmissaoNFe.OutroLugarRetirada = True
                                    oClsFatEmissaoNFeLocalRetirada.Logradouro = sCampo(F.Logradouro)
                                    oClsFatEmissaoNFeLocalRetirada.Numero = sCampo(F.Numero)
                                    oClsFatEmissaoNFeLocalRetirada.Complemento = sCampo(F.Complemento)
                                    oClsFatEmissaoNFeLocalRetirada.Bairro = sCampo(F.Bairro)
                                    oClsFatEmissaoNFeLocalRetirada.UF = sCampo(F.UF)
                                    oClsFatEmissaoNFeLocalRetirada.Municipio = IIf(sCampo(F.CodigoMunicipio) = "", -1, LoadDescricao("sp_select_static_codigo_municipio_ibge '" & sCampo(F.CodigoMunicipio) & "'"))

                                Case "F02"
                                    oClsFatEmissaoNFeLocalRetirada.CNPJ = sCampo(F.CNPJCPF)
                                    Call oClsFatEmissaoNFeLocalRetirada.Insert()

                                Case "F02a"
                                    oClsFatEmissaoNFeLocalRetirada.CNPJ = sCampo(F.CNPJCPF)
                                    Call oClsFatEmissaoNFeLocalRetirada.Insert()

                                Case "G"
                                    oClsFatEmissaoNFeLocalEntrega.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
                                    oClsFatEmissaoNFe.OutroLugarEntrega = True
                                    oClsFatEmissaoNFeLocalEntrega.Logradouro = sCampo(G.Logradouro)
                                    oClsFatEmissaoNFeLocalEntrega.Numero = sCampo(G.Numero)
                                    oClsFatEmissaoNFeLocalEntrega.Complemento = sCampo(G.Complemento)
                                    oClsFatEmissaoNFeLocalEntrega.Bairro = sCampo(G.Bairro)
                                    oClsFatEmissaoNFeLocalEntrega.UF = sCampo(G.UF)
                                    oClsFatEmissaoNFeLocalEntrega.Municipio = IIf(sCampo(G.CodigoMunicipio) = "", -1, LoadDescricao("sp_select_static_codigo_municipio_ibge '" & sCampo(G.CodigoMunicipio) & "'"))

                                Case "G02"
                                    oClsFatEmissaoNFeLocalEntrega.CNPJ = sCampo(G.CNPJCPF)
                                    Call oClsFatEmissaoNFeLocalEntrega.Insert()

                                Case "G02a"
                                    oClsFatEmissaoNFeLocalEntrega.CNPJ = sCampo(G.CNPJCPF)
                                    Call oClsFatEmissaoNFeLocalEntrega.Insert()

                                Case "H"
                                    oClsFatEmissaoNFeItem.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
                                    oClsFatEmissaoNFeItem.InformacoesAdicionais = sCampo(H.InformacaoAdicionalProduto)

                                Case "I"


                                    'Seta Valores do Item            
                                    oClsFatEmissaoNFeItem.CodigoItem = 0
                                    oClsFatEmissaoNFeItem.CodigoEmissaoItem = -1
                                    oClsFatEmissaoNFeItem.CodigoProdutoServico = sCampo(H.CodigoProduto)
                                    oClsFatEmissaoNFeItem.CodigoEAN = sCampo(H.CodigoEAN)
                                    oClsFatEmissaoNFeItem.Descricao = sCampo(H.Descricao)
                                    oClsFatEmissaoNFeItem.CodigoCFOP = 0
                                    oClsFatEmissaoNFeItem.CFOP = sCampo(H.CFOP)
                                    oClsFatEmissaoNFeItem.CEST = sCampo(H.CEST)
                                    oClsFatEmissaoNFeItem.CodigoNCM = 0
                                    oClsFatEmissaoNFeItem.NCM = sCampo(H.NCM)
                                    oClsFatEmissaoNFeItem.Quantidade = CDbl(Replace(sCampo(H.QuantidadeComercial), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorFrete = IIf(sCampo(H.ValorFrete) = "", 0, CDbl(Replace(sCampo(H.ValorFrete), ".", ",")))
                                    oClsFatEmissaoNFeItem.ValorSeguro = IIf(sCampo(H.ValorSeguro) = "", 0, CDbl(Replace(sCampo(H.ValorSeguro), ".", ",")))
                                    oClsFatEmissaoNFeItem.ValorOutrasDespesas = IIf(sCampo(H.ValorOutro) = "", 0, CDbl(Replace(sCampo(H.ValorOutro), ".", ",")))
                                    oClsFatEmissaoNFeItem.CodigoUnidadeMedida = 0
                                    oClsFatEmissaoNFeItem.UnidadeMedida = sCampo(H.UnidadeMedidaComercial)
                                    oClsFatEmissaoNFeItem.ValorUnitario = CDbl(Replace(sCampo(H.ValorUnitarioComercial), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorDesconto = IIf(sCampo(H.ValorDesconto) = "", 0, CDbl(Replace(sCampo(H.ValorDesconto), ".", ",")))
                                    oClsFatEmissaoNFeItem.ValorTotal = CDbl(Replace(sCampo(H.ValorTotal), ".", ","))
                                    oClsFatEmissaoNFeItem.IncideValorTotalNF = sCampo(H.IncideTotal)
                                    oClsFatEmissaoNFeItem.PedidoCompra = sCampo(H.NumeroPedido)
                                    oClsFatEmissaoNFeItem.NumeroItemPedidoCompra = IIf(sCampo(H.NumeroItemPedido) = "", 0, sCampo(H.NumeroItemPedido))
                                    oClsFatEmissaoNFeItem.CodigoEmissaoDI = -1
                                    oClsFatEmissaoNFeItem.CalculoAutomatico = IIf(goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD", True, False)
                                    Call oClsFatEmissaoNFeItem.InsertProduto()

                                    'Zera informação das CST´s
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = -1
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = -1
                                    oClsFatEmissaoNFeItem.BaseCalculoICMS = -1
                                    oClsFatEmissaoNFeItem.AliquotaICMS = -1
                                    oClsFatEmissaoNFeItem.ValorICMS = -1
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = -1
                                    oClsFatEmissaoNFeItem.IVA = -1
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = -1
                                    oClsFatEmissaoNFeItem.BaseCalculoICMSST = -1
                                    oClsFatEmissaoNFeItem.AliquotaICMSST = -1
                                    oClsFatEmissaoNFeItem.ValorICMSST = -1

                                    ''Insere a informação do estoque
                                    'If oClsFatEmissaoNFeItem.CFOP = "5102" Or _
                                    '    oClsFatEmissaoNFeItem.CFOP = "6102" Or _
                                    '    oClsFatEmissaoNFeItem.CFOP = "5910" Or _
                                    '    oClsFatEmissaoNFeItem.CFOP = "6910" Or _
                                    '    oClsFatEmissaoNFeItem.CFOP = "5405" Or _
                                    '    oClsFatEmissaoNFeItem.CFOP = "6405" Then
                                    Dim oClsFrmFatEmissaoNFeProdutoEstoque As New clsFrmFatEmissaoNFeProdutoEstoque
                                    oClsFrmFatEmissaoNFeProdutoEstoque.Insert(oClsFatEmissaoNFe.CodigoEmissaoCapa, _
                                                                              iCodigo, _
                                                                              1, _
                                                                              oClsFatEmissaoNFeItem.Quantidade, _
                                                                              oClsFatEmissaoNFeItem.Quantidade, _
                                                                              "")

                                    ' End If


                                    'Seta o codigo emissão item
                                    iCodigo += 1

                                Case "N02"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N02.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N02.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = sCampo(N02.ModalidadeBaseCalculoICMS)
                                    oClsFatEmissaoNFeItem.BaseCalculoICMS = CDbl(Replace(sCampo(N02.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMS = CDbl(Replace(sCampo(N02.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMS = CDbl(Replace(sCampo(N02.Valor), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N03"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N03.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N03.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = sCampo(N03.ModalidadeBaseCalculoICMS)
                                    oClsFatEmissaoNFeItem.BaseCalculoICMS = CDbl(Replace(sCampo(N03.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMS = CDbl(Replace(sCampo(N03.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMS = CDbl(Replace(sCampo(N03.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = sCampo(N03.ModalidadeBaseCalculoICMSST)
                                    oClsFatEmissaoNFeItem.IVA = CDbl(Replace(sCampo(N03.IVA), ".", ","))
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = CDbl(Replace(sCampo(N03.ReducaoBaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMSST = CDbl(Replace(sCampo(N03.BaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMSST = CDbl(Replace(sCampo(N03.AliquotaST), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMSST = CDbl(Replace(sCampo(N03.ValorST), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N04"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N04.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N04.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = sCampo(N04.ModalidadeBaseCalculoICMS)
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = CDbl(Replace(sCampo(N04.ReducaoBaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMS = CDbl(Replace(sCampo(N04.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMS = CDbl(Replace(sCampo(N04.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMS = CDbl(Replace(sCampo(N04.Valor), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N05"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N05.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N05.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = sCampo(N05.ModalidadeBaseCalculoICMSST)
                                    oClsFatEmissaoNFeItem.IVA = CDbl(Replace(sCampo(N05.IVA), ".", ","))
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = CDbl(Replace(sCampo(N05.ReducaoBaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMSST = CDbl(Replace(sCampo(N05.BaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMSST = CDbl(Replace(sCampo(N05.AliquotaST), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMSST = CDbl(Replace(sCampo(N05.ValorST), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N06"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N06.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N06.SituacaoTributaria)
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N07"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N07.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N07.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = sCampo(N07.ModalidadeBaseCalculoICMS)
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = CDbl(Replace(sCampo(N07.ReducaoBaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMS = CDbl(Replace(sCampo(N07.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMS = CDbl(Replace(sCampo(N07.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMS = CDbl(Replace(sCampo(N07.ValorICMS), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N08"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N08.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N08.SituacaoTributaria)
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N09"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N09.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N09.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = sCampo(N09.ModalidadeBaseCalculoICMS)
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = CDbl(Replace(sCampo(N09.ReducaoBaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMS = CDbl(Replace(sCampo(N09.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMS = CDbl(Replace(sCampo(N09.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMS = CDbl(Replace(sCampo(N09.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = sCampo(N09.ModalidadeBaseCalculoICMSST)
                                    oClsFatEmissaoNFeItem.IVA = CDbl(Replace(sCampo(N09.IVA), ".", ","))
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = CDbl(Replace(sCampo(N09.ReducaoBaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMSST = CDbl(Replace(sCampo(N09.BaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMSST = CDbl(Replace(sCampo(N09.AliquotaST), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMSST = CDbl(Replace(sCampo(N09.ValorST), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N10"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N10.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N10.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = sCampo(N10.ModalidadeBaseCalculoICMS)
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = CDbl(Replace(sCampo(N10.ReducaoBaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMS = CDbl(Replace(sCampo(N10.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMS = CDbl(Replace(sCampo(N10.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMS = CDbl(Replace(sCampo(N10.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = sCampo(N10.ModalidadeBaseCalculoICMSST)
                                    oClsFatEmissaoNFeItem.IVA = CDbl(Replace(sCampo(N10.IVA), ".", ","))
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = CDbl(Replace(sCampo(N10.ReducaoBaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMSST = CDbl(Replace(sCampo(N10.BaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMSST = CDbl(Replace(sCampo(N10.AliquotaST), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMSST = CDbl(Replace(sCampo(N10.ValorST), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "N10a"
                                    oClsFatEmissaoNFeItem.CodigoOrigemItem = sCampo(N10a.OrigemItem)
                                    oClsFatEmissaoNFeItem.SituacaoTributariaICMS = sCampo(N10a.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = sCampo(N10a.ModalidadeBaseCalculoICMS)
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = CDbl(Replace(sCampo(N10a.ReducaoBaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMS = CDbl(Replace(sCampo(N10a.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMS = CDbl(Replace(sCampo(N10a.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMS = CDbl(Replace(sCampo(N10a.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = sCampo(N10a.ModalidadeBaseCalculoICMSST)
                                    oClsFatEmissaoNFeItem.IVA = CDbl(Replace(sCampo(N10a.IVA), ".", ","))
                                    oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = CDbl(Replace(sCampo(N10a.ReducaoBaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.BaseCalculoICMSST = CDbl(Replace(sCampo(N10a.BaseCalculoST), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaICMSST = CDbl(Replace(sCampo(N10a.AliquotaST), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorICMSST = CDbl(Replace(sCampo(N10a.ValorST), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoICMS()

                                Case "O"
                                    oClsFatEmissaoNFeItem.ClasseEnquadramentoIPI = sCampo(O.ClasseEnquadramento)
                                    oClsFatEmissaoNFeItem.CNPJProdutorIPI = sCampo(O.CNPJProdutor)
                                    oClsFatEmissaoNFeItem.CodigoSeloControleIPI = sCampo(O.Selo)
                                    oClsFatEmissaoNFeItem.QuantidadeSeloControleIPI = sCampo(O.QuantidadeSelo)
                                    oClsFatEmissaoNFeItem.CodigoEnquadramentoIPI = sCampo(O.CodigoEnquadramento)
                                    oClsFatEmissaoNFeItem.TipoCalculoIPI = TipoCalculoImposto.Percentual

                                Case "O07"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaIPI = sCampo(O07.SituacaoTributaria)

                                Case "O08"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaIPI = sCampo(O08.SituacaoTributaria)
                                    Call oClsFatEmissaoNFeItem.InsertImpostoIPI()

                                Case "O10"
                                    oClsFatEmissaoNFeItem.BaseCalculoIPI = CDbl(Replace(sCampo(O10.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaIPI = CDbl(Replace(sCampo(O10.AliquotaIPI), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoIPI()

                                Case "O11"
                                    oClsFatEmissaoNFeItem.QuantidadeTotalUnidadePadraoIPI = CDbl(Replace(sCampo(O11.QuantidadeUnidade), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorUnidadeIPI = CDbl(Replace(sCampo(O11.ValorUnidade), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorIPI = CDbl(Replace(sCampo(O11.ValorIPI), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoIPI()

                                Case "P"
                                    oClsFatEmissaoNFeItem.BaseCalculoII = CDbl(Replace(sCampo(P.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.DespesaAduaneira = CDbl(Replace(sCampo(P.DespesaAduaneira), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaII = CDbl(Replace(sCampo(P.ValorII), ".", ",")) / CDbl(Replace(sCampo(P.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaIOF = CDbl(Replace(sCampo(P.ValorIOF), ".", ",")) / CDbl(Replace(sCampo(P.BaseCalculo), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoII()

                                Case "Q02"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaPIS = sCampo(Q02.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.BaseCalculoPIS = CDbl(Replace(sCampo(Q02.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoPIS = TipoCalculoImposto.Percentual
                                    oClsFatEmissaoNFeItem.AliquotaPorcentagemPIS = CDbl(Replace(sCampo(Q02.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorPIS = CDbl(Replace(sCampo(Q02.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoPISST = TipoCalculoImposto.Percentual
                                    Call oClsFatEmissaoNFeItem.InsertImpostoPIS()

                                Case "Q03"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaPIS = sCampo(Q03.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.QuantidadeVendidaPIS = CDbl(Replace(sCampo(Q03.BaseCalculoProduto), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoPIS = TipoCalculoImposto.Valor
                                    oClsFatEmissaoNFeItem.TipoCalculoPIS = -1
                                    oClsFatEmissaoNFeItem.AliquotaValorPIS = CDbl(Replace(sCampo(Q03.AliquotaProduto), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorPIS = CDbl(Replace(sCampo(Q03.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoPISST = TipoCalculoImposto.Percentual
                                    Call oClsFatEmissaoNFeItem.InsertImpostoPIS()

                                Case "Q04"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaPIS = sCampo(Q04.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.TipoCalculoPIS = -1
                                    oClsFatEmissaoNFeItem.TipoCalculoPISST = TipoCalculoImposto.Percentual
                                    Call oClsFatEmissaoNFeItem.InsertImpostoPIS()

                                Case "Q05"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaPIS = sCampo(Q05.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.TipoCalculoPIS = -1
                                    oClsFatEmissaoNFeItem.TipoCalculoPISST = TipoCalculoImposto.Percentual
                                    Call oClsFatEmissaoNFeItem.InsertImpostoPIS()

                                Case "Q07"
                                    oClsFatEmissaoNFeItem.BaseCalculoPIS = CDbl(Replace(sCampo(Q07.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaPorcentagemPIS = CDbl(Replace(sCampo(Q07.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoPIS = TipoCalculoImposto.Percentual
                                    oClsFatEmissaoNFeItem.ValorPIS = CDbl(Replace(sCampo(Q07.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoPISST = TipoCalculoImposto.Percentual
                                    Call oClsFatEmissaoNFeItem.InsertImpostoPIS()

                                Case "Q10"
                                    oClsFatEmissaoNFeItem.QuantidadeVendidaPIS = CDbl(Replace(sCampo(Q10.BaseCalculoProduto), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoPIS = TipoCalculoImposto.Valor
                                    oClsFatEmissaoNFeItem.AliquotaValorPIS = CDbl(Replace(sCampo(Q10.AliquotaProduto), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoPISST = TipoCalculoImposto.Percentual
                                    Call oClsFatEmissaoNFeItem.InsertImpostoPIS()

                                Case "S02"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaCOFINS = sCampo(S02.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.BaseCalculoCOFINS = CDbl(Replace(sCampo(S02.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaPorcentagemCOFINS = CDbl(Replace(sCampo(S02.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorCOFINS = CDbl(Replace(sCampo(S02.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINS = TipoCalculoImposto.Percentual
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
                                    Call oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

                                Case "S03"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaCOFINS = sCampo(S03.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.QuantidadeVendidaCOFINS = CDbl(Replace(sCampo(S03.BaseCalculoProduto), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaValorCOFINS = CDbl(Replace(sCampo(S03.AliquotaProduto), ".", ","))
                                    oClsFatEmissaoNFeItem.ValorCOFINS = CDbl(Replace(sCampo(S03.Valor), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINS = TipoCalculoImposto.Valor
                                    Call oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

                                Case "S04"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaCOFINS = sCampo(S04.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINS = -1
                                    Call oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

                                Case "S05"
                                    oClsFatEmissaoNFeItem.SituacaoTributariaCOFINS = sCampo(S05.SituacaoTributaria)
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINS = -1
                                    oClsFatEmissaoNFeItem.ValorCOFINS = CDbl(Replace(sCampo(S05.Valor), ".", ","))
                                    Call oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

                                Case "S07"
                                    oClsFatEmissaoNFeItem.BaseCalculoCOFINS = CDbl(Replace(sCampo(S07.BaseCalculo), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaPorcentagemCOFINS = CDbl(Replace(sCampo(S07.Aliquota), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINS = TipoCalculoImposto.Percentual
                                    Call oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

                                Case "S09"
                                    oClsFatEmissaoNFeItem.QuantidadeVendidaCOFINS = CDbl(Replace(sCampo(S09.BaseCalculoProduto), ".", ","))
                                    oClsFatEmissaoNFeItem.AliquotaValorCOFINS = CDbl(Replace(sCampo(S09.AliquotaProduto), ".", ","))
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
                                    oClsFatEmissaoNFeItem.TipoCalculoCOFINS = TipoCalculoImposto.Valor
                                    Call oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

                                Case "W02"
                                    oClsFatEmissaoNFe.BaseCalculoICMS = CDbl(Replace(sCampo(W02.BaseCalculoICMS), ".", ","))
                                    oClsFatEmissaoNFe.TotalICMS = CDbl(Replace(sCampo(W02.ValorICMS), ".", ","))
                                    'oClsFatEmissaoNFe.valoricmsdesonerado = 0 
                                    oClsFatEmissaoNFe.BaseCalculoICMSST = CDbl(Replace(sCampo(W02.BaseCalculoICMSST), ".", ","))
                                    oClsFatEmissaoNFe.TotalICMSST = CDbl(Replace(sCampo(W02.ValorICMSST), ".", ","))
                                    oClsFatEmissaoNFe.TotalProdutoServico = CDbl(Replace(sCampo(W02.ValorProduto), ".", ","))
                                    oClsFatEmissaoNFe.TotalFrete = CDbl(Replace(sCampo(W02.ValorFrete), ".", ","))
                                    oClsFatEmissaoNFe.TotalSeguro = CDbl(Replace(sCampo(W02.ValorSeguro), ".", ","))
                                    oClsFatEmissaoNFe.TotalDesconto = CDbl(Replace(sCampo(W02.ValorDesconto), ".", ","))
                                    oClsFatEmissaoNFe.TotalII = CDbl(Replace(sCampo(W02.ValorII), ".", ","))
                                    oClsFatEmissaoNFe.TotalIPI = CDbl(Replace(sCampo(W02.ValorIPI), ".", ","))
                                    oClsFatEmissaoNFe.PIS = CDbl(Replace(sCampo(W02.ValorPIS), ".", ","))
                                    oClsFatEmissaoNFe.COFINS = CDbl(Replace(sCampo(W02.ValorCOFINS), ".", ","))
                                    oClsFatEmissaoNFe.OutrasDespesas = CDbl(Replace(sCampo(W02.ValorOutras), ".", ","))
                                    oClsFatEmissaoNFe.TotalNotaFiscal = CDbl(Replace(sCampo(W02.ValorNotaFiscal), ".", ","))
                                    Call oClsFatEmissaoNFe.InsertTotal()
                                    Call oClsFatEmissaoNFe.InsertDestinatario(True)


                                Case "X"
                                    oClsFatEmissaoNFe.CodigoModalidadeFrete = sCampo(X.ModalidadeFrete)

                                Case "X03"
                                    oClsFatEmissaoNFe.RazaoSocialTransportadora = sCampo(X03.RazaoSocial)
                                    oClsFatEmissaoNFe.InscricaoEstadualTransportadora = sCampo(X03.InscricaoEstadual)
                                    oClsFatEmissaoNFe.EnderecoTransportadora = sCampo(X03.Endereco)
                                    oClsFatEmissaoNFe.MunicipioTransportadora = sCampo(X03.Municipio)
                                    oClsFatEmissaoNFe.UFTransportadora = sCampo(X03.UF)

                                Case "X04"
                                    oClsFatEmissaoNFe.CnpjCpfTransportadora = sCampo(X04.CNPJCPF)

                                Case "X05"
                                    oClsFatEmissaoNFe.CnpjCpfTransportadora = sCampo(X05.CNPJCPF)

                                Case "X11"
                                    oClsFatEmissaoNFe.ValorServicoTransporte = CDbl(Replace(sCampo(X11.ValorServico), ".", ","))
                                    oClsFatEmissaoNFe.BaseCalculoTransporte = CDbl(Replace(sCampo(X11.BaseCalculoRetido), ".", ","))
                                    oClsFatEmissaoNFe.AliquotaICMSTransporte = CDbl(Replace(sCampo(X11.AliquotaRetido), ".", ","))
                                    oClsFatEmissaoNFe.ValorICMSRetidoTransporte = CDbl(Replace(sCampo(X11.ValorRetido), ".", ","))
                                    oClsFatEmissaoNFe.CodigoCFOPTransporte = LoadDescricao("sp_select_cadastro_basico_codigo_cfop '" & sCampo(X11.CFOP) & "', " & goUsuario.iEmpresa)
                                    oClsFatEmissaoNFe.CodigoMunicipioICMSTransporte = sCampo(X11.CodigoMunicipioOcorrencia)

                                Case "X18"
                                    oClsFatEmissaoNFe.PlacaVeiculo = sCampo(X18.Placa)
                                    oClsFatEmissaoNFe.UFPlacaVeiculo = sCampo(X18.UF)
                                    oClsFatEmissaoNFe.RNTCVeiculo = sCampo(X18.RNTC)


                                Case "X22"
                                    oClsFatEmissaoNFe.PlacaVeiculo = sCampo(X22.Placa)
                                    oClsFatEmissaoNFe.UFPlacaVeiculo = sCampo(X22.UF)
                                    oClsFatEmissaoNFe.RNTCVeiculo = sCampo(X22.RNTC)
                                    oClsFatEmissaoNFe.Vagao = sCampo(X22.Vagao)
                                    oClsFatEmissaoNFe.Balsa = sCampo(X22.Balsa)


                                Case "X26"
                                    oClsFatEmissaoNFe.InsertVolume(sCampo(X26.Quantidade), _
                                                                   sCampo(X26.Especie), _
                                                                   sCampo(X26.Marca), _
                                                                   sCampo(X26.Volume), _
                                                                   IIf(sCampo(X26.PesoLiquido) = "", 0, CDbl(Replace(sCampo(X26.PesoLiquido), ".", ","))), _
                                                                   IIf(sCampo(X26.PesoBruto) = "", 0, CDbl(Replace(sCampo(X26.PesoBruto), ".", ","))))

                                Case "X33"
                                    Call oClsFatEmissaoNFeVolumeLacre.Insert(oClsFatEmissaoNFe.CodigoEmissaoCapa, _
                                                                             1, _
                                                                             sCampo(X33.Lacre))

                                Case "X33"
                                    Call oClsFatEmissaoNFeVolumeLacre.Insert(oClsFatEmissaoNFe.CodigoEmissaoCapa, _
                                                                             1, _
                                                                             sCampo(X33.Lacre))
                                Case "Y02"
                                    oClsFatEmissaoNFe.Fatura = sCampo(Y02.Fatura)
                                    oClsFatEmissaoNFe.CodigoCondicaoPagamento = -1
                                    oClsFatEmissaoNFe.ValorOriginal = IIf(sCampo(Y02.ValorOrigem) = "", 0, CDbl(Replace(sCampo(Y02.ValorOrigem), ".", ",")))
                                    oClsFatEmissaoNFe.ValorDesconto = IIf(sCampo(Y02.ValorDesconto) = "", 0, CDbl(Replace(sCampo(Y02.ValorDesconto), ".", ",")))
                                    oClsFatEmissaoNFe.ValorLiquido = IIf(sCampo(Y02.ValorLiquido) = "", 0, CDbl(Replace(sCampo(Y02.ValorLiquido), ".", ",")))
                                    oClsFatEmissaoNFe.InsertFatura()

                                Case "Y07"
                                    Call oClsFatEmissaoNFe.InsertFaturaDuplicata(sCampo(Y07.Duplicata), _
                                                                                 sCampo(Y07.DataVencimento), _
                                                                                 IIf(sCampo(Y07.Valor) = "", 0, CDbl(Replace(sCampo(Y07.Valor), ".", ","))))

                                Case "Z"
                                    oClsFatEmissaoNFe.InformacaoAdicionalFisco = sCampo(Z.InformacaoAdicionalFisco)
                                    oClsFatEmissaoNFe.InformacaoAdicionalContribuinte = sCampo(Z.InformacaoAdicionalComplemento)
                                    Call oClsFatEmissaoNFe.InsertInformacaoAdicional()
                                    Call oClsFatEmissaoNFe.InsertTransporte()

                            End Select

                            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

                        End While

                    End If

                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False

                Next

                'Informa o Usuário sobre o Sucesso da Operação
                If oMensagem(0).Arquivo = "" Then
                    MsgBox("Operação realizada com sucesso!", vbInformation)
                Else
                    Call ReportErro("Integração - Importar NFe - TXT", _
                                    "Log de Importação - Integração NFe", _
                                    oMensagem)
                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ReportErro(ByVal sTitle As String, _
                                ByVal sSubTitle As String, _
                                ByVal oMensagem() As MensagemErro) As String

        Dim sReportHTML As String

        'add header information
        sReportHTML = "<!DOCTYPE HTML PUBLIC -//W3C//DTD HTML 4.01 Transitional//EN > "
        sReportHTML &= "<html>"
        sReportHTML &= "<head>"
        sReportHTML &= "<title>" & sTitle & "</title>"
        sReportHTML &= "<meta http-equiv=Content-Type content=text/html; charset=iso-8859-1 > "
        sReportHTML &= "</head>"
        sReportHTML &= "<body>"

        'add title text / subtitle text block
        sReportHTML &= "<p><font face=Arial, Helvetica, sans-serif><strong><font size=3>" & sSubTitle & "</font></strong><br>"
        sReportHTML &= "<font size=" & "2" & ">Relatório Gerado em: " & Now & "<br>"
        sReportHTML &= "Relatório Gerado por : " & goUsuario.sUsuario & "</font></font></p>"

        'define the start of the table
        sReportHTML &= "<table width=100% border=1 cellspacing=0 bordercolor=#CCCCCC>"

        'create the header row
        sReportHTML &= "<tr>"
        sReportHTML &= "<td width=30% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Arquivo</font></strong></td>"
        sReportHTML &= "<td width=70% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Erro</font></strong></td>"
        sReportHTML &= "</tr>"

        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oMensagem.Count
        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
        frmMain.stbMain.Panels("pnlProgressBar").Visible = True

        For i As Integer = 0 To UBound(oMensagem)

            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

            sReportHTML &= "<tr>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Arquivo & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Erro & "</font></td>"
            sReportHTML &= "</tr>"
            Application.DoEvents()
        Next i

        frmMain.stbMain.Panels("pnlProgressBar").Visible = False

        'close page
        sReportHTML &= "</body>"
        sReportHTML &= "</html>"

        'Váriaveis Locais
        Dim sArquivo As String = System.IO.Path.GetTempPath
        sArquivo &= "INTERACTI_ERRO.html"

        If File.Exists(sArquivo) Then
            File.Delete(sArquivo)
        End If

        Using oFileStream As New FileStream(sArquivo, FileMode.Create)
            Dim oStreamWriter As New StreamWriter(oFileStream, System.Text.Encoding.Default)
            oStreamWriter.Write(sReportHTML.ToString())
            oStreamWriter.Close()
            oFileStream.Close()
        End Using

        Process.Start(sArquivo)

    End Function

#End Region

End Class

