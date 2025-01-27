Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports Janus.Windows.EditControls
Imports Janus.Windows.UI

Public Class clsUsrIntProduto

#Region "::: VARIAVEIS :::"

    Private dDataInicio As Date
    Private dDataTermino As Date
    Private sArquivoNF As StreamWriter

#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Linha As String
        Dim Erro As String
    End Structure

    Private Structure Produto
        Dim iTipoItem As Integer
        Dim sGrupoItem As String
        Dim sCodigoItem As String
        Dim sCodigoBarras As String
        Dim bAtivo As Boolean
        Dim sDescricao As String
        Dim sMarca As String
        Dim sDescricao2 As String
        Dim sCodigoNCM As String
        Dim dPesoLiquido As Double
        Dim iCodigoOrigemItem As Integer
        Dim sObservacao As String
        Dim sUnidadeMedidaVenda As String
        Dim dFatorConversaoUnidadeMedidaVenda As Double
        Dim iFormaVenda As Integer
        Dim dPrecoVenda As Double
        Dim dMargemLucro As Double
        Dim dVariavel As Double
        Dim sUnidadeMedidaCompra As String
        Dim dFatorConversaoUnidadeMedidaCompra As Double
        Dim iLeadTime As Integer
        Dim bNecessitaFornecedorHomologado As Boolean
        Dim sUnidadeMedidaEstoque As String
        Dim dEstoqueMinimo As Double
        Dim dEstoqueMaximo As Double
        Dim bControlaLote As Boolean
        Dim bControlaValidade As Boolean
        Dim bControlaDataFabricacao As Boolean
        Dim dPercentualDesvalorizacao As Double
        Dim iFrequenciaDesvalorizacaoDia As Integer
        Dim bEstoque As Boolean
        Dim bCompra As Boolean
        Dim bVenda As Boolean
        Dim bProducao As Boolean
        Dim bAtivoFixo As Boolean
    End Structure

#End Region

#Region "::: ENUM :::"

    Private Enum ExcelProduto
        GrupoItem = 1
        CodigoProduto = 2
        CodigoEAN = 3
        Ativo = 4
        Descricao = 5
        Descricao2 = 6
        Marca = 7
        CodigoNCM = 8
        PesoLiquido = 9
        OrigemItem = 10
        Observacao = 11
        ItemVenda = 12
        UnidadeMedidaVenda = 13
        FatorConversaoUnidadeMedidaVenda = 14
        PrecoVenda = 15
        MargemLucro = 16
        Variavel = 17
        ItemCompra = 18
        UnidadeMedidaCompra = 19
        FatorConversaoUnidadeMedidaCompra = 20
        LeadTime = 21
        NecessitaFornecedorHomologado = 22
        ItemEstoque = 23
        UnidadeMedidaEstoque = 24
        EstoqueMinimo = 25
        LoteEconomico = 26
        ControlaLote = 27
        ControlaValidade = 28
        ControlaDataFabricacao = 29
        AtivoFixo = 30
        PercentualDesvalorizacao = 31
        FrequenciaDesvalorizacaoDia = 32
        ItemProducao = 33
    End Enum

#End Region

#Region "::: PROPERTIE ::: "

    Public Property DataInicio() As Date
        Get
            Return dDataInicio
        End Get
        Set(ByVal value As Date)
            dDataInicio = value
        End Set
    End Property

    Public Property DataTermino() As Date
        Get
            Return dDataTermino
        End Get
        Set(ByVal value As Date)
            dDataTermino = value
        End Set
    End Property

    Public Property ArquivoNF() As StreamWriter
        Get
            Return sArquivoNF
        End Get
        Set(ByVal value As StreamWriter)
            sArquivoNF = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Function ReportErro(ByVal pgbImportacao As UIProgressBar, _
                                ByVal sTitle As String, _
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
        sReportHTML &= "<td width=8% vAlign=top align=center bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Linha</font></strong></td>"
        sReportHTML &= "<td width=92% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Erro</font></strong></td>"
        sReportHTML &= "</tr>"

        pgbImportacao.Minimum = 0
        pgbImportacao.Maximum = UBound(oMensagem)

        For i As Integer = 0 To UBound(oMensagem)
            sReportHTML &= "<tr>"
            sReportHTML &= "<td vAlign=top align=center><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Linha & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Erro & "</font></td>"
            sReportHTML &= "</tr>"
            pgbImportacao.Value = i
            Application.DoEvents()
        Next i

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

    Public Sub ImportarProduto(ByVal pagDados As Tab.UITabPage, _
                               ByVal sArquivo As String, _
                               ByVal pgbImportacao As UIProgressBar, _
                               ByVal bCadastraGrupoItem As Boolean, _
                               ByVal bCadastraUnidadeMedida As Boolean, _
                               ByVal bCadastraNCM As Boolean, _
                               ByVal bAtualizaRegistroIgual As Boolean)

        'Váriaveis Locais            
        Dim oMensagem() As MensagemErro
        Dim i As Integer = 0
        Dim oApplication As New Excel.Application
        Dim oWorkbook As Excel.Workbook
        Dim oClsCadProduto As New clsUsrCadProduto

        Try

            'Seta Texto
            pagDados.Text = "Integração - Importar Produtos (Importando ...)"

            'Redimensiona Vetor
            ReDim oMensagem(0)
            oMensagem(0).Linha = ""
            oMensagem(0).Erro = ""

            'Abre o Arquivo            
            oWorkbook = oApplication.Workbooks.Open(sArquivo)

            'Define Planilja de Trabalho
            oWorkbook.Sheets("PRODUTO").Select()

            'Percorre Linha a Linha o Arquivo
            For i = 2 To oApplication.Rows.Count
                'Verifica se acabou os registros
                If oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value Is Nothing Then
                    Exit For
                End If
            Next i

            'Seta Propriedades
            pgbImportacao.Minimum = 1 : pgbImportacao.Maximum = i : pgbImportacao.Value = 1

            'Percorre Linha a Linha o Arquivo
            For i = 2 To oApplication.Rows.Count

                'Váriavel - Produto
                Dim oProduto As New Produto

                'Verifica se acabou os registros
                If oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value Is Nothing Then
                    Exit For
                ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value.ToString) > 50 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Código do Produto informado " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 60 caracteres."
                Else
                    oProduto.sCodigoItem = oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value
                End If

                'Verifica se foi Preenchido o Grupo de Item
                If oWorkbook.Application.Cells(i, ExcelProduto.GrupoItem).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Grupo de Item para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.GrupoItem).Value & "."
                ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.GrupoItem).Value.ToString) > 5 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Grupo de Item informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.GrupoItem).Value & " não pode ter mais do que 5 caracteres."
                Else
                    oProduto.sGrupoItem = oWorkbook.Application.Cells(i, ExcelProduto.GrupoItem).Value
                End If

                'Verifica se foi Preenchido o Código EAN
                If oWorkbook.Application.Cells(i, ExcelProduto.CodigoEAN).Value Is Nothing Then
                    'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    'oMensagem(UBound(oMensagem)).Linha = i
                    'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Código EAN para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.CodigoEAN).Value.ToString) > 14 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Código EAN informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 14 caracteres."
                Else
                    oProduto.sCodigoBarras = oWorkbook.Application.Cells(i, ExcelProduto.CodigoEAN).Value
                End If

                'Verifica se foi Preenchido o Ativo
                If oWorkbook.Application.Cells(i, ExcelProduto.Ativo).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Ativo para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf oWorkbook.Application.Cells(i, ExcelProduto.Ativo).Value.ToString <> "0" And oWorkbook.Application.Cells(i, ExcelProduto.Ativo).Value.ToString <> "1" Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Ativo não é válido"
                Else
                    oProduto.bAtivo = oWorkbook.Application.Cells(i, ExcelProduto.Ativo).Value
                End If

                'Verifica se foi Preenchido a Descrição
                If oWorkbook.Application.Cells(i, ExcelProduto.Descricao).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Descrição para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.Descricao).Value.ToString) > 120 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "A Descrição informada para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 120 caracteres."
                Else
                    oProduto.sDescricao = oWorkbook.Application.Cells(i, ExcelProduto.Descricao).Value
                End If

                'Verifica se foi Preenchido a Descrição2
                If oWorkbook.Application.Cells(i, ExcelProduto.Descricao2).Value Is Nothing Then
                    'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    'oMensagem(UBound(oMensagem)).Linha = i
                    'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Descrição² para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.Descricao2).Value.ToString) > 500 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "A Descrição² informada para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 500 caracteres."
                Else
                    oProduto.sDescricao2 = oWorkbook.Application.Cells(i, ExcelProduto.Descricao2).Value
                End If

                'Verifica se foi Preenchido a Marca
                If oWorkbook.Application.Cells(i, ExcelProduto.Marca).Value Is Nothing Then
                    'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    'oMensagem(UBound(oMensagem)).Linha = i
                    'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Marca para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.Marca).Value.ToString) > 100 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "A Marca informada para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 100 caracteres."
                Else
                    oProduto.sMarca = oWorkbook.Application.Cells(i, ExcelProduto.Marca).Value
                End If

                'Verifica se foi Preenchido o Código NCM
                If oWorkbook.Application.Cells(i, ExcelProduto.CodigoNCM).Value Is Nothing Then
                    oProduto.sCodigoNCM = "00000000"
                ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.CodigoNCM).Value.ToString.Trim) > 8 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Código NCM informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 8 caracteres."
                ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.CodigoNCM).Value.ToString.Trim) = False Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Código NCM informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                Else
                    oProduto.sCodigoNCM = oWorkbook.Application.Cells(i, ExcelProduto.CodigoNCM).Value.ToString.Trim
                End If

                'Verifica se foi Preenchido o Peso Líquido
                If oWorkbook.Application.Cells(i, ExcelProduto.PesoLiquido).Value Is Nothing Then
                    'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    'oMensagem(UBound(oMensagem)).Linha = i
                    'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Peso Líquido para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.PesoLiquido).Value) = False Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Peso Líquido informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                Else
                    oProduto.dPesoLiquido = oWorkbook.Application.Cells(i, ExcelProduto.PesoLiquido).Value
                End If

                'Verifica se foi Preenchido a Origem do Item
                If oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Origem do Item para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value.ToString <> "0" And _
                       oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value.ToString <> "1" And _
                       oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value.ToString <> "2" And _
                       oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value.ToString <> "3" And _
                       oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value.ToString <> "4" And _
                       oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value.ToString <> "5" And _
                       oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value.ToString <> "6" And _
                       oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value.ToString <> "7" Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Origem do Item não é válido"
                Else
                    oProduto.iCodigoOrigemItem = oWorkbook.Application.Cells(i, ExcelProduto.OrigemItem).Value
                End If

                'Verifica se foi Preenchido o Item de Venda
                If oWorkbook.Application.Cells(i, ExcelProduto.ItemVenda).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Item de Venda para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf oWorkbook.Application.Cells(i, ExcelProduto.ItemVenda).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.ItemVenda).Value.ToString <> "0" Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Item de Venda não é válido"
                Else
                    oProduto.bVenda = oWorkbook.Application.Cells(i, ExcelProduto.ItemVenda).Value
                End If

                If oWorkbook.Application.Cells(i, ExcelProduto.ItemVenda).Value.ToString = "1" Then

                    'Verifica se foi Preenchido a Unidade de Medida - Venda
                    If oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaVenda).Value Is Nothing Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Unidade de Medida de Venda para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaVenda).Value.ToString) > 6 Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "A Unidade de Medida de Venda informada para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 6 caracteres."
                    Else
                        oProduto.sUnidadeMedidaVenda = oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaVenda).Value.ToString.Trim
                    End If

                    'Verifica se foi Preenchido o Fator de Conversão - Unidade de Medida de Venda
                    If oWorkbook.Application.Cells(i, ExcelProduto.FatorConversaoUnidadeMedidaVenda).Value Is Nothing Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Fator de Conversão de Unidade de Medida de Venda para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.FatorConversaoUnidadeMedidaVenda).Value.ToString) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Fator de Conversão de Unidade de Medida de Venda informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.dFatorConversaoUnidadeMedidaVenda = oWorkbook.Application.Cells(i, ExcelProduto.FatorConversaoUnidadeMedidaVenda).Value.ToString.Trim
                    End If

                    'Verifica se foi Preenchido o Preço de Venda
                    If oWorkbook.Application.Cells(i, ExcelProduto.PrecoVenda).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Preço de Venda para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.PrecoVenda).Value) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Preço de Venda informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.dPrecoVenda = oWorkbook.Application.Cells(i, ExcelProduto.PrecoVenda).Value
                    End If

                    'Verifica se foi Preenchido a Magem de Lucro
                    If oWorkbook.Application.Cells(i, ExcelProduto.MargemLucro).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado a Margem de Lucro para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.PrecoVenda).Value) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "A Margem de Lucro informada para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.dMargemLucro = oWorkbook.Application.Cells(i, ExcelProduto.MargemLucro).Value
                    End If

                    'Verifica se foi Preenchido a Váriavel
                    If oWorkbook.Application.Cells(i, ExcelProduto.Variavel).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado a Váriavel para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.Variavel).Value) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "A Váriavel informada para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.dVariavel = oWorkbook.Application.Cells(i, ExcelProduto.Variavel).Value
                    End If

                End If

                'Verifica se foi Preenchido o Item de Compra
                If oWorkbook.Application.Cells(i, ExcelProduto.ItemCompra).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Item de Compra para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf oWorkbook.Application.Cells(i, ExcelProduto.ItemCompra).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.ItemCompra).Value.ToString <> "0" Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Item de Compra não é válido"
                Else
                    oProduto.bCompra = oWorkbook.Application.Cells(i, ExcelProduto.ItemCompra).Value.ToString
                End If

                If oWorkbook.Application.Cells(i, ExcelProduto.ItemCompra).Value.ToString = "1" Then

                    'Verifica se foi Preenchido a Unidade de Medida - Compra
                    If oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaCompra).Value Is Nothing Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Unidade de Medida de Compra para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaCompra).Value.ToString) > 6 Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "A Unidade de Medida de Compra informada para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 6 caracteres."
                    Else
                        oProduto.sUnidadeMedidaCompra = oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaCompra).Value.ToString
                    End If

                    'Verifica se foi Preenchido o Fator de Conversão - Unidade de Medida de Compra
                    If oWorkbook.Application.Cells(i, ExcelProduto.FatorConversaoUnidadeMedidaCompra).Value Is Nothing Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Fator de Conversão de Unidade de Medida de Compra para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.FatorConversaoUnidadeMedidaCompra).Value.ToString) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Fator de Conversão de Unidade de Medida de Compra informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.dFatorConversaoUnidadeMedidaCompra = oWorkbook.Application.Cells(i, ExcelProduto.FatorConversaoUnidadeMedidaCompra).Value.ToString
                    End If

                    'Verifica se foi Preenchido o Lead Time
                    If oWorkbook.Application.Cells(i, ExcelProduto.LeadTime).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Lead Time para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.LeadTime).Value) = False Then
                        oProduto.iLeadTime = 0
                    Else
                        oProduto.iLeadTime = oWorkbook.Application.Cells(i, ExcelProduto.LeadTime).Value
                    End If

                    'Verifica se foi Preenchido o Campo Necessita Fornecedor Homologado
                    If oWorkbook.Application.Cells(i, ExcelProduto.NecessitaFornecedorHomologado).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Necessita Fornecedor Homologado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf oWorkbook.Application.Cells(i, ExcelProduto.NecessitaFornecedorHomologado).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.NecessitaFornecedorHomologado).Value.ToString <> "0" Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Necessita Fornecedor Homologado não é válido"
                    Else
                        oProduto.bNecessitaFornecedorHomologado = oWorkbook.Application.Cells(i, ExcelProduto.NecessitaFornecedorHomologado).Value.ToString
                    End If

                End If

                'Verifica se foi Preenchido o Item de Estoque
                If oWorkbook.Application.Cells(i, ExcelProduto.ItemEstoque).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Item de Estoque para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf oWorkbook.Application.Cells(i, ExcelProduto.ItemEstoque).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.ItemEstoque).Value.ToString <> "0" Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Item de Estoque não é válido"
                Else
                    oProduto.bEstoque = oWorkbook.Application.Cells(i, ExcelProduto.ItemEstoque).Value.ToString
                End If

                If oWorkbook.Application.Cells(i, ExcelProduto.ItemEstoque).Value.ToString = "1" Then

                    'Verifica se foi Preenchido a Unidade de Medida - Estoque
                    If oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaEstoque).Value Is Nothing Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Unidade de Medida de Estoque para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf Len(oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaEstoque).Value.ToString) > 6 Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "A Unidade de Medida de Estoque informada para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " não pode ter mais do que 6 caracteres."
                    Else
                        oProduto.sUnidadeMedidaEstoque = oWorkbook.Application.Cells(i, ExcelProduto.UnidadeMedidaEstoque).Value.ToString
                    End If

                    'Verifica se foi Preenchido o Fator de Conversão - Estoque Mínimo
                    If oWorkbook.Application.Cells(i, ExcelProduto.EstoqueMinimo).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Estoque Mínimo para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.EstoqueMinimo).Value) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Estoque Mínimo informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.dEstoqueMinimo = oWorkbook.Application.Cells(i, ExcelProduto.EstoqueMinimo).Value
                    End If

                    'Verifica se foi Preenchido o Fator de Conversão - Lote Econômico
                    If oWorkbook.Application.Cells(i, ExcelProduto.LoteEconomico).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Lote Econômico para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.LoteEconomico).Value) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Lote Econômico informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.dEstoqueMaximo = oWorkbook.Application.Cells(i, ExcelProduto.LoteEconomico).Value
                    End If

                    'Verifica se foi Preenchido o Campo Controla Lote
                    If oWorkbook.Application.Cells(i, ExcelProduto.ControlaLote).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Controla Lote para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf oWorkbook.Application.Cells(i, ExcelProduto.ControlaLote).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.ControlaLote).Value.ToString <> "0" Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Controla Lote não é válido"
                    Else
                        oProduto.bControlaLote = oWorkbook.Application.Cells(i, ExcelProduto.ControlaLote).Value.ToString
                    End If

                    'Verifica se foi Preenchido o Campo Controla Validade
                    If oWorkbook.Application.Cells(i, ExcelProduto.ControlaValidade).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Controla Validade para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf oWorkbook.Application.Cells(i, ExcelProduto.ControlaValidade).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.ControlaValidade).Value.ToString <> "0" Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Controla Validade não é válido"
                    Else
                        oProduto.bControlaValidade = oWorkbook.Application.Cells(i, ExcelProduto.ControlaValidade).Value.ToString
                    End If

                    'Verifica se foi Preenchido o Campo Controla Data de Fabricação
                    If oWorkbook.Application.Cells(i, ExcelProduto.ControlaDataFabricacao).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Controla Data de Fabricação para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf oWorkbook.Application.Cells(i, ExcelProduto.ControlaDataFabricacao).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.ControlaDataFabricacao).Value.ToString <> "0" Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Controla Data de Fabricação não é válido"
                    Else
                        oProduto.bControlaDataFabricacao = oWorkbook.Application.Cells(i, ExcelProduto.ControlaDataFabricacao).Value.ToString
                    End If

                End If

                'Verifica se foi Preenchido o Item Ativo Fixo
                If oWorkbook.Application.Cells(i, ExcelProduto.AtivoFixo).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Item de Ativo Fixo para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf oWorkbook.Application.Cells(i, ExcelProduto.AtivoFixo).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.AtivoFixo).Value.ToString <> "0" Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Item de Ativo Fixo não é válido"
                Else
                    oProduto.bAtivoFixo = oWorkbook.Application.Cells(i, ExcelProduto.AtivoFixo).Value.ToString
                End If

                If oWorkbook.Application.Cells(i, ExcelProduto.AtivoFixo).Value.ToString = "1" Then

                    'Verifica se foi Preenchido o Fator de Conversão - Percentual de Desvalorização
                    If oWorkbook.Application.Cells(i, ExcelProduto.PercentualDesvalorizacao).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Percentual de Desvalorização para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.PercentualDesvalorizacao).Value.ToString) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "O Percentual de Desvalorização informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.dPercentualDesvalorizacao = oWorkbook.Application.Cells(i, ExcelProduto.PercentualDesvalorizacao).Value.ToString
                    End If

                    'Verifica se foi Preenchido o Fator de Conversão - Frequência de Desvalorização - Dia
                    If oWorkbook.Application.Cells(i, ExcelProduto.FrequenciaDesvalorizacaoDia).Value Is Nothing Then
                        'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        'oMensagem(UBound(oMensagem)).Linha = i
                        'oMensagem(Ubound(oMensagem)).erro = "Não foi informado o Campo Frequência de Desvalorização - Dia para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                    ElseIf IsNumeric(oWorkbook.Application.Cells(i, ExcelProduto.FrequenciaDesvalorizacaoDia).Value.ToString) = False Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = "A Frequência de Desvalorização - Dia informado para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & " deve ser numérico."
                    Else
                        oProduto.iFrequenciaDesvalorizacaoDia = oWorkbook.Application.Cells(i, ExcelProduto.FrequenciaDesvalorizacaoDia).Value.ToString
                    End If

                End If

                'Verifica se foi Preenchido o Item de Produção
                If oWorkbook.Application.Cells(i, ExcelProduto.ItemProducao).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado o Campo Item de Produção para o Produto " & oWorkbook.Application.Cells(i, ExcelProduto.CodigoProduto).Value & "."
                ElseIf oWorkbook.Application.Cells(i, ExcelProduto.ItemProducao).Value.ToString <> "1" And oWorkbook.Application.Cells(i, ExcelProduto.ItemProducao).Value.ToString <> "0" Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = i
                    oMensagem(UBound(oMensagem)).Erro = "O Valor informado para o campo Item de Produção não é válido"
                Else
                    oProduto.bProducao = oWorkbook.Application.Cells(i, ExcelProduto.ItemProducao).Value.ToString
                End If

                If oMensagem(UBound(oMensagem)).Linha <> i.ToString Then

                    Dim sMensagem As String = ""

                    'Insere Registro
                    Call oClsCadProduto.Import(bCadastraGrupoItem, _
                                               bCadastraUnidadeMedida, _
                                               bCadastraNCM, _
                                               bAtualizaRegistroIgual, _
                                               CInt(TipoItem.produto), _
                                               oProduto.sGrupoItem, _
                                               oProduto.sCodigoItem, _
                                               oProduto.sCodigoBarras, _
                                               oProduto.bAtivo, _
                                               oProduto.sDescricao, _
                                               oProduto.sMarca, _
                                               oProduto.sDescricao2, _
                                               oProduto.sCodigoNCM, _
                                               oProduto.dPesoLiquido, _
                                               oProduto.iCodigoOrigemItem, _
                                               oProduto.sObservacao, _
                                               oProduto.sUnidadeMedidaVenda, _
                                               oProduto.dFatorConversaoUnidadeMedidaVenda, _
                                               oProduto.iFormaVenda, _
                                               oProduto.sUnidadeMedidaCompra, _
                                               oProduto.dFatorConversaoUnidadeMedidaCompra, _
                                               oProduto.iLeadTime, _
                                               oProduto.bNecessitaFornecedorHomologado, _
                                               oProduto.sUnidadeMedidaEstoque, _
                                               oProduto.dEstoqueMinimo, _
                                               oProduto.dEstoqueMaximo, _
                                               oProduto.bControlaLote, _
                                               oProduto.bControlaValidade, _
                                               oProduto.bControlaDataFabricacao, _
                                               oProduto.dPercentualDesvalorizacao, _
                                               oProduto.iFrequenciaDesvalorizacaoDia, _
                                               oProduto.bEstoque, _
                                               oProduto.bCompra, _
                                               oProduto.bVenda, _
                                               oProduto.bProducao, _
                                               oProduto.bAtivoFixo, _
                                               sMensagem)

                    If sMensagem <> "" Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = i
                        oMensagem(UBound(oMensagem)).Erro = sMensagem
                    End If

                End If

                'Seta valor
                pgbImportacao.Value = pgbImportacao.Value + 1

                Application.DoEvents()

            Next i

            Application.DoEvents()

            'Verifica se é necessário e gera Relatório
            If oMensagem(UBound(oMensagem)).Linha <> "" Then

                'Seta Texto
                pagDados.Text = "Integração - Importar Produtos (Gerando Relatório ...)"
                Call ReportErro(pgbImportacao, _
                                "Integração - Importar Produto", _
                                "Log de Importação - Integração Produto", _
                                oMensagem)

            End If

            'Informa o Usuário.
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            oApplication = Nothing
            Throw ex
        Finally
            pgbImportacao.Value = 1
            pagDados.Text = "Integração - Importar Produtos"
            oWorkbook.Close(False)
            oWorkbook = Nothing
            oApplication = Nothing
        End Try

    End Sub

#End Region

End Class


