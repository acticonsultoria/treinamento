Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop

Public Class clsUsrIntCarcare

#Region "::: VARIAVEIS :::"

    Private sEmail As String
    Private sEmailXML As String

#End Region

#Region "::: PROPERTIE ::: "

    Public Property Email As Integer
        Get
            Return sEmail
        End Get
        Set(ByVal value As Integer)
            sEmail = value
        End Set
    End Property

    Public Property EmailXML As Integer
        Get
            Return sEmailXML
        End Get
        Set(ByVal value As Integer)
            sEmailXML = value
        End Set
    End Property

#End Region

    Private Enum Indice
        NumeroPedido = 1
        DataPedido = 2
        StatusPedido = 3
        CodigoStatus = 4
        Loja = 5
        FormaPagamento = 6
        CodigoFormaPagamento = 7
        FormaEntrega = 8
        CodigoFormaEntrega = 9
        Subtotal = 10
        Frete = 11
        Descontos = 12
        Total = 13
        Pago = 14
        Reembolso = 15
        Devendo = 16
        QuantidadeItens = 17
        ClienteNome = 18
        ClienteEmail = 19
        ClientePessoaJuridica = 20
        ClienteRazaoSocial = 21
        ClienteNomeFantasia = 22
        ClienteCPFCPNJ = 23
        ClienteIE = 24
        EntregaNome = 25
        EntregaEmpresa = 26
        EntregaEndereco = 27
        EntregaCEP = 28
        EntregaCidade = 29
        EntregaUFDescricao = 30
        EntregaUFCodigo = 31
        EntregaPaisDescricao = 32
        EntregaPaisCodigo = 33
        EntregaTelefone = 34
        CobrancaNome = 35
        CobrancaEmpresa = 36
        CobrancaEndereco = 37
        CobrancaCEP = 38
        CobrancaCidade = 39
        CobrancaEstado = 40
        CobrancaCodigoEstado = 41
        CobrancaPais = 42
        CobrancaCodigoPais = 43
        CobrancaTelefone = 44
        ItemCompradoNome = 45
        ItemCompradoStatus = 46
        ItemCompradoCodigoStatus = 47
        ItemCompradoSKU = 48
        ItemCompradoOpcoes = 49
        ItemCompradoPrecoOriginal = 50
        ItemCompradoPreco = 51
        ItemCompradoQuantidadePedida = 52
        ItemCompradoQuantidadeFaturada = 53
        ItemCompradoQuantidadeEntregue = 54
        ItemCompradoQuantidadeCancelado = 55
        ItemCompradoQuantidadeReembolsado = 56
        ItemCompradoDesconto = 57
        ItemCompradoTotal = 58

    End Enum

#Region "::: FUNCTION / SUB :::"

#Region "::: ARQUIVO :::"

    Public Function Validacao(ByVal sPlanilha As String, _
                              ByVal sArquivo As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Planilha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "planilha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = "[" & sPlanilha & "$]"

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validade_integracao_arquivo_excel", oSqlParameter)

            'Retorno da Função
            Return IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Return False
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Salvar(ByVal sArquivo As String, _
                      ByVal sPlanilha As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel 
            i = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Planilha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "planilha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = "[" & sPlanilha & "$]" : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_venda_carcare", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function FormatarValor(ByVal sValor As String) As Double
        Try

            Return CDbl(sValor.Replace("R$", "").Replace(",", "."))

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ImportarPlanilha(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(59) As SqlParameter
        Dim i As Integer = 0
        Dim iRow As Integer = 2
        Dim oApplicationClass As New Excel.ApplicationClass
        'Abre o Arquivo
        oApplicationClass.Workbooks.Open(sArquivo)

        Try
            ExecuteNonQuery(goDatabase.sConnection, CommandType.Text, "truncate table tb_int_temp_importacao_pedido_venda_carcare")

            'Percorre Linha a Linha o Arquivo até não ter mais registros
            While 1


                'Verifica se acabou os registros
                If oApplicationClass.Range(LoadRangeExcel(Indice.NumeroPedido, iRow)).Value Is Nothing Then
                    Exit While
                ElseIf IsDBNull(oApplicationClass.Range(LoadRangeExcel(Indice.NumeroPedido, iRow)).Value) Then
                    Exit While
                ElseIf CStr(oApplicationClass.Range(LoadRangeExcel(Indice.NumeroPedido, iRow)).Value) = "" Then
                    Exit While
                End If

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.NumeroPedido, iRow)).Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.DataPedido, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status_pedido_descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.StatusPedido, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status_pedido_codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CodigoStatus, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "loja"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.Loja, iRow)).Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "forma_pagamento_descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.FormaPagamento, iRow)).Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "forma_pagamento_codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CodigoFormaPagamento, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "forma_entrega_descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CodigoFormaEntrega, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "forma_entrega_codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CodigoFormaEntrega, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "subtotal"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.Subtotal, iRow)).Value.Replace("R$", "") : i += 1
                'oSqlParameter(i).Value = FormatarValor(oApplicationClass.Range(LoadRangeExcel(Indice.Subtotal, iRow)).Value) : i += 1
                '.Replace("R$", "").Replace(",", ".")

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "frete"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.Frete, iRow)).Value.Replace("R$", "") : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descontos"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.Descontos, iRow)).Value.Replace("R$", "") : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "total"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.Total, iRow)).Value.Replace("R$", "") : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "pago"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.Pago, iRow)).Value.Replace("R$", "") : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "reembolso"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.Reembolso, iRow)).Value.ToString.Replace("R$", "").Replace(".", "").Replace(",", ".") : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "devendo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.Devendo, iRow)).Value.ToString.Replace("R$", "").Replace(".", "").Replace(",", ".") : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "quantidade_itens"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.QuantidadeItens, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cliente_nome"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ClienteNome, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cliente_email"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ClienteEmail, iRow)).Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cliente_pessoa_juridica"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ClientePessoaJuridica, iRow)).Value.ToString.Replace("SIM", "True").Replace("NÃO", "FALSE").Replace("NAO", "FALSE") : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cliente_razao_social"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ClienteRazaoSocial, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cliente_nome_fantasia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ClienteNomeFantasia, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cliente_cnpj_cpf"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ClienteCPFCPNJ, iRow)).Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cliente_ie"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ClienteIE, iRow)).Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_nome"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaNome, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaEmpresa, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_endereco"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaEndereco, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_cep"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaCEP, iRow)).Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_cidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaCidade, iRow)).Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_uf_descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaUFDescricao, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_uf_codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaUFCodigo, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_pais_descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaPaisDescricao, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_pais_codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaPaisCodigo, iRow)).Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "entrega_telefone"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.EntregaTelefone, iRow)).Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_nome"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaNome, iRow)).Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaEmpresa, iRow)).Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_endereco"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaEndereco, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_cep"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaCEP, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_cidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaCidade, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_uf_descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaEstado, iRow)).Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_uf_codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaCodigoEstado, iRow)).Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_pais_descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaPais, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_pais_codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaCodigoPais, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cobranca_telefone"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.CobrancaTelefone, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_nome"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoNome, iRow)).Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_status_descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoStatus, iRow)).Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_status_codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoCodigoStatus, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_SKU"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoSKU, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_opcoes"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoOpcoes, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_preco_original"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoPrecoOriginal, iRow)).Value.Replace("R$", "") : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_preco"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoPreco, iRow)).Value.Replace("R$", "") : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_quantidade_pedida"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoQuantidadePedida, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_quantidade_faturada"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoQuantidadeFaturada, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_quantidade_entregue"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoQuantidadeEntregue, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_quantidade_cancelado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoQuantidadeCancelado, iRow)).Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_quantidade_reembolsado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoQuantidadeReembolsado, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_desconto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoDesconto, iRow)).Value.Replace("R$", "") : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item_comprado_total"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Indice.ItemCompradoTotal, iRow)).Value.Replace("R$", "") : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario

                sEmail = oApplicationClass.Range(LoadRangeExcel(Indice.ClienteEmail, iRow)).Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_venda_carcare", oSqlParameter)
                iRow += 1
                 
            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
        Catch SqlEx As SqlException
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw SqlEx
        Catch ex As Exception
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub


    Public Sub ImportarXML(ByVal sArquivo As String)
        Try
            'Variaveis Locais
            Dim oSqlParameter(65) As SqlParameter
            Dim oXMLDocument As New Xml.XmlDocument
            oXMLDocument.Load(sArquivo)

            ExecuteNonQuery(goDatabase.sConnection, CommandType.Text, "truncate table tb_int_temp_importacao_pedido_venda_carcare_xml")

            Dim oNodes As Xml.XmlNodeList = oXMLDocument.GetElementsByTagName("pedido")
            Dim oNode As Xml.XmlNode
            For iNode As Integer = 0 To oNodes.Count - 1
                oNode = oNodes(iNode)
                Dim i As Integer = 0

                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "numero_pedido"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.VarChar
                oSqlParameter(0).Value = oNode.Item("pedido_numero").InnerText

                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "data_pedido"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.VarChar
                oSqlParameter(1).Value = oNode.Item("pedido_data").InnerText

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "status_pedido_descricao"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.VarChar
                oSqlParameter(2).Value = oNode.Item("pedido_status").InnerText

                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "status_pedido_codigo"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.VarChar
                oSqlParameter(3).Value = oNode.Item("pedido_codigo_status").InnerText

                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "loja"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.VarChar
                oSqlParameter(4).Value = oNode.Item("loja_website_group_name").InnerText

                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "forma_pagamento_descricao"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.VarChar
                oSqlParameter(5).Value = oNode.Item("pedido_pagamento").InnerText

                oSqlParameter(6) = New SqlParameter
                oSqlParameter(6).ParameterName = "forma_pagamento_codigo"
                oSqlParameter(6).Direction = ParameterDirection.Input
                oSqlParameter(6).SqlDbType = SqlDbType.VarChar
                oSqlParameter(6).Value = oNode.Item("pedido_codigo_pagamento").InnerText

                oSqlParameter(7) = New SqlParameter
                oSqlParameter(7).ParameterName = "forma_entrega_descricao"
                oSqlParameter(7).Direction = ParameterDirection.Input
                oSqlParameter(7).SqlDbType = SqlDbType.VarChar
                oSqlParameter(7).Value = oNode.Item("pedido_entrega").InnerText

                oSqlParameter(8) = New SqlParameter
                oSqlParameter(8).ParameterName = "forma_entrega_codigo"
                oSqlParameter(8).Direction = ParameterDirection.Input
                oSqlParameter(8).SqlDbType = SqlDbType.VarChar
                oSqlParameter(8).Value = oNode.Item("pedido_codigo_entrega").InnerText

                oSqlParameter(9) = New SqlParameter
                oSqlParameter(9).ParameterName = "subtotal"
                oSqlParameter(9).Direction = ParameterDirection.Input
                oSqlParameter(9).SqlDbType = SqlDbType.Float
                oSqlParameter(9).Value = Replace(oNode.Item("pedido_subtotal").InnerText, "R$", "")

                oSqlParameter(10) = New SqlParameter
                oSqlParameter(10).ParameterName = "frete"
                oSqlParameter(10).Direction = ParameterDirection.Input
                oSqlParameter(10).SqlDbType = SqlDbType.Float
                oSqlParameter(10).Value = Replace(oNode.Item("pedido_frete").InnerText, "R$", "")

                oSqlParameter(11) = New SqlParameter
                oSqlParameter(11).ParameterName = "descontos"
                oSqlParameter(11).Direction = ParameterDirection.Input
                oSqlParameter(11).SqlDbType = SqlDbType.Float
                oSqlParameter(11).Value = Replace(oNode.Item("pedido_desconto").InnerText, "R$", "")

                oSqlParameter(12) = New SqlParameter
                oSqlParameter(12).ParameterName = "total"
                oSqlParameter(12).Direction = ParameterDirection.Input
                oSqlParameter(12).SqlDbType = SqlDbType.Float
                oSqlParameter(12).Value = Replace(oNode.Item("pedido_total").InnerText, "R$", "")

                oSqlParameter(13) = New SqlParameter
                oSqlParameter(13).ParameterName = "pago"
                oSqlParameter(13).Direction = ParameterDirection.Input
                oSqlParameter(13).SqlDbType = SqlDbType.Float
                oSqlParameter(13).Value = Replace(oNode.Item("pedido_pago").InnerText, "R$", "")

                oSqlParameter(14) = New SqlParameter
                oSqlParameter(14).ParameterName = "reembolso"
                oSqlParameter(14).Direction = ParameterDirection.Input
                oSqlParameter(14).SqlDbType = SqlDbType.Float
                oSqlParameter(14).Value = Replace(oNode.Item("pedido_reembolso").InnerText, "R$", "")

                oSqlParameter(15) = New SqlParameter
                oSqlParameter(15).ParameterName = "devendo"
                oSqlParameter(15).Direction = ParameterDirection.Input
                oSqlParameter(15).SqlDbType = SqlDbType.Float
                oSqlParameter(15).Value = Replace(oNode.Item("pedido_devendo").InnerText, "R$", "")

                oSqlParameter(16) = New SqlParameter
                oSqlParameter(16).ParameterName = "quantidade_itens"
                oSqlParameter(16).Direction = ParameterDirection.Input
                oSqlParameter(16).SqlDbType = SqlDbType.Int
                oSqlParameter(16).Value = oNode.Item("pedido_quantidade_itens").InnerText

                oSqlParameter(17) = New SqlParameter
                oSqlParameter(17).ParameterName = "cliente_nome"
                oSqlParameter(17).Direction = ParameterDirection.Input
                oSqlParameter(17).SqlDbType = SqlDbType.VarChar
                oSqlParameter(17).Value = oNode.Item("cliente_nome").InnerText

                oSqlParameter(18) = New SqlParameter
                oSqlParameter(18).ParameterName = "cliente_email"
                oSqlParameter(18).Direction = ParameterDirection.Input
                oSqlParameter(18).SqlDbType = SqlDbType.VarChar
                oSqlParameter(18).Value = oNode.Item("cliente_email").InnerText

                oSqlParameter(19) = New SqlParameter
                oSqlParameter(19).ParameterName = "cliente_pessoa_juridica"
                oSqlParameter(19).Direction = ParameterDirection.Input
                oSqlParameter(19).SqlDbType = SqlDbType.Bit
                oSqlParameter(19).Value = IIf(oNode.Item("cliente_pj").InnerText = "NÃO", "False", "True")

                oSqlParameter(20) = New SqlParameter
                oSqlParameter(20).ParameterName = "cliente_razao_social"
                oSqlParameter(20).Direction = ParameterDirection.Input
                oSqlParameter(20).SqlDbType = SqlDbType.VarChar
                oSqlParameter(20).Value = oNode.Item("cliente_razao_social").InnerText

                oSqlParameter(21) = New SqlParameter
                oSqlParameter(21).ParameterName = "cliente_nome_fantasia"
                oSqlParameter(21).Direction = ParameterDirection.Input
                oSqlParameter(21).SqlDbType = SqlDbType.VarChar
                oSqlParameter(21).Value = oNode.Item("cliente_nome_fantasia").InnerText

                oSqlParameter(22) = New SqlParameter
                oSqlParameter(22).ParameterName = "cliente_cnpj_cpf"
                oSqlParameter(22).Direction = ParameterDirection.Input
                oSqlParameter(22).SqlDbType = SqlDbType.VarChar
                oSqlParameter(22).Value = oNode.Item("cliente_cpf_cnpj").InnerText

                oSqlParameter(23) = New SqlParameter
                oSqlParameter(23).ParameterName = "cliente_ie"
                oSqlParameter(23).Direction = ParameterDirection.Input
                oSqlParameter(23).SqlDbType = SqlDbType.VarChar
                oSqlParameter(23).Value = oNode.Item("cliente_ie").InnerText

                oSqlParameter(24) = New SqlParameter
                oSqlParameter(24).ParameterName = "entrega_nome"
                oSqlParameter(24).Direction = ParameterDirection.Input
                oSqlParameter(24).SqlDbType = SqlDbType.VarChar
                oSqlParameter(24).Value = oNode.Item("entrega_nome").InnerText

                oSqlParameter(25) = New SqlParameter
                oSqlParameter(25).ParameterName = "entrega_empresa"
                oSqlParameter(25).Direction = ParameterDirection.Input
                oSqlParameter(25).SqlDbType = SqlDbType.VarChar
                oSqlParameter(25).Value = oNode.Item("entrega_empresa").InnerText

                Dim sVetorLinha() As String
                sVetorLinha = oNode.Item("entrega_endereco").InnerText.ToString.Split(vbLf)

                Dim sRua As String = sVetorLinha(0)
                Dim sNumero As String = sVetorLinha(1)
                Dim sComplemento As String
                Dim sBairro As String

                If sVetorLinha.Count = 4 Then
                    sComplemento = sVetorLinha(2)
                    sBairro = sVetorLinha(3)
                Else
                    sComplemento = ""
                    sBairro = sVetorLinha(2)
                End If

                oSqlParameter(26) = New SqlParameter
                oSqlParameter(26).ParameterName = "entrega_rua"
                oSqlParameter(26).Direction = ParameterDirection.Input
                oSqlParameter(26).SqlDbType = SqlDbType.VarChar
                oSqlParameter(26).Value = sRua

                oSqlParameter(27) = New SqlParameter
                oSqlParameter(27).ParameterName = "entrega_numero"
                oSqlParameter(27).Direction = ParameterDirection.Input
                oSqlParameter(27).SqlDbType = SqlDbType.Int
                oSqlParameter(27).Value = sNumero

                oSqlParameter(28) = New SqlParameter
                oSqlParameter(28).ParameterName = "entrega_complemento"
                oSqlParameter(28).Direction = ParameterDirection.Input
                oSqlParameter(28).SqlDbType = SqlDbType.VarChar
                oSqlParameter(28).Value = sComplemento

                oSqlParameter(29) = New SqlParameter
                oSqlParameter(29).ParameterName = "entrega_bairro"
                oSqlParameter(29).Direction = ParameterDirection.Input
                oSqlParameter(29).SqlDbType = SqlDbType.VarChar
                oSqlParameter(29).Value = sBairro

                oSqlParameter(30) = New SqlParameter
                oSqlParameter(30).ParameterName = "entrega_cep"
                oSqlParameter(30).Direction = ParameterDirection.Input
                oSqlParameter(30).SqlDbType = SqlDbType.VarChar
                oSqlParameter(30).Value = oNode.Item("entrega_cep").InnerText

                oSqlParameter(31) = New SqlParameter
                oSqlParameter(31).ParameterName = "entrega_cidade"
                oSqlParameter(31).Direction = ParameterDirection.Input
                oSqlParameter(31).SqlDbType = SqlDbType.VarChar
                oSqlParameter(31).Value = oNode.Item("entrega_cidade").InnerText

                oSqlParameter(32) = New SqlParameter
                oSqlParameter(32).ParameterName = "entrega_uf_descricao"
                oSqlParameter(32).Direction = ParameterDirection.Input
                oSqlParameter(32).SqlDbType = SqlDbType.VarChar
                oSqlParameter(32).Value = oNode.Item("entrega_estado").InnerText

                oSqlParameter(33) = New SqlParameter
                oSqlParameter(33).ParameterName = "entrega_uf_codigo"
                oSqlParameter(33).Direction = ParameterDirection.Input
                oSqlParameter(33).SqlDbType = SqlDbType.VarChar
                oSqlParameter(33).Value = oNode.Item("entrega_codigo_estado").InnerText

                oSqlParameter(34) = New SqlParameter
                oSqlParameter(34).ParameterName = "entrega_pais_descricao"
                oSqlParameter(34).Direction = ParameterDirection.Input
                oSqlParameter(34).SqlDbType = SqlDbType.VarChar
                oSqlParameter(34).Value = oNode.Item("entrega_pais").InnerText

                oSqlParameter(35) = New SqlParameter
                oSqlParameter(35).ParameterName = "entrega_pais_codigo"
                oSqlParameter(35).Direction = ParameterDirection.Input
                oSqlParameter(35).SqlDbType = SqlDbType.VarChar
                oSqlParameter(35).Value = oNode.Item("entrega_codigo_pais").InnerText

                oSqlParameter(36) = New SqlParameter
                oSqlParameter(36).ParameterName = "entrega_telefone"
                oSqlParameter(36).Direction = ParameterDirection.Input
                oSqlParameter(36).SqlDbType = SqlDbType.VarChar
                oSqlParameter(36).Value = oNode.Item("entrega_telefone").InnerText

                oSqlParameter(37) = New SqlParameter
                oSqlParameter(37).ParameterName = "cobranca_nome"
                oSqlParameter(37).Direction = ParameterDirection.Input
                oSqlParameter(37).SqlDbType = SqlDbType.VarChar
                oSqlParameter(37).Value = oNode.Item("cobranca_nome").InnerText

                oSqlParameter(38) = New SqlParameter
                oSqlParameter(38).ParameterName = "cobranca_empresa"
                oSqlParameter(38).Direction = ParameterDirection.Input
                oSqlParameter(38).SqlDbType = SqlDbType.VarChar
                oSqlParameter(38).Value = oNode.Item("cobranca_empresa").InnerText

                Dim sVetorLinhaCobranca() As String
                sVetorLinhaCobranca = oNode.Item("cobranca_endereco").InnerText.ToString.Split(vbLf)

                Dim sRuaCobranca As String = sVetorLinhaCobranca(0)
                Dim sNumeroCobranca As String = sVetorLinhaCobranca(1)
                Dim sComplementoCobranca As String
                Dim sBairroCobranca As String

                If sVetorLinhaCobranca.Count = 4 Then
                    sComplementoCobranca = sVetorLinhaCobranca(2)
                    sBairroCobranca = sVetorLinhaCobranca(3)
                Else
                    sComplementoCobranca = ""
                    sBairroCobranca = sVetorLinhaCobranca(2)
                End If

                oSqlParameter(39) = New SqlParameter
                oSqlParameter(39).ParameterName = "cobranca_rua"
                oSqlParameter(39).Direction = ParameterDirection.Input
                oSqlParameter(39).SqlDbType = SqlDbType.VarChar
                oSqlParameter(39).Value = sRuaCobranca

                oSqlParameter(40) = New SqlParameter
                oSqlParameter(40).ParameterName = "cobranca_numero"
                oSqlParameter(40).Direction = ParameterDirection.Input
                oSqlParameter(40).SqlDbType = SqlDbType.Int
                oSqlParameter(40).Value = sNumeroCobranca

                oSqlParameter(41) = New SqlParameter
                oSqlParameter(41).ParameterName = "cobranca_complemento"
                oSqlParameter(41).Direction = ParameterDirection.Input
                oSqlParameter(41).SqlDbType = SqlDbType.VarChar
                oSqlParameter(41).Value = sComplementoCobranca

                oSqlParameter(42) = New SqlParameter
                oSqlParameter(42).ParameterName = "cobranca_bairro"
                oSqlParameter(42).Direction = ParameterDirection.Input
                oSqlParameter(42).SqlDbType = SqlDbType.VarChar
                oSqlParameter(42).Value = sBairroCobranca

                oSqlParameter(43) = New SqlParameter
                oSqlParameter(43).ParameterName = "cobranca_cep"
                oSqlParameter(43).Direction = ParameterDirection.Input
                oSqlParameter(43).SqlDbType = SqlDbType.VarChar
                oSqlParameter(43).Value = oNode.Item("cobranca_cep").InnerText

                oSqlParameter(44) = New SqlParameter
                oSqlParameter(44).ParameterName = "cobranca_cidade"
                oSqlParameter(44).Direction = ParameterDirection.Input
                oSqlParameter(44).SqlDbType = SqlDbType.VarChar
                oSqlParameter(44).Value = oNode.Item("cobranca_cidade").InnerText

                oSqlParameter(45) = New SqlParameter
                oSqlParameter(45).ParameterName = "cobranca_uf_descricao"
                oSqlParameter(45).Direction = ParameterDirection.Input
                oSqlParameter(45).SqlDbType = SqlDbType.VarChar
                oSqlParameter(45).Value = oNode.Item("cobranca_estado").InnerText

                oSqlParameter(46) = New SqlParameter
                oSqlParameter(46).ParameterName = "cobranca_uf_codigo"
                oSqlParameter(46).Direction = ParameterDirection.Input
                oSqlParameter(46).SqlDbType = SqlDbType.VarChar
                oSqlParameter(46).Value = oNode.Item("cobranca_codigo_estado").InnerText

                oSqlParameter(47) = New SqlParameter
                oSqlParameter(47).ParameterName = "cobranca_pais_descricao"
                oSqlParameter(47).Direction = ParameterDirection.Input
                oSqlParameter(47).SqlDbType = SqlDbType.VarChar
                oSqlParameter(47).Value = oNode.Item("cobranca_pais").InnerText

                oSqlParameter(48) = New SqlParameter
                oSqlParameter(48).ParameterName = "cobranca_pais_codigo"
                oSqlParameter(48).Direction = ParameterDirection.Input
                oSqlParameter(48).SqlDbType = SqlDbType.VarChar
                oSqlParameter(48).Value = oNode.Item("cobranca_codigo_pais").InnerText

                oSqlParameter(49) = New SqlParameter
                oSqlParameter(49).ParameterName = "cobranca_telefone"
                oSqlParameter(49).Direction = ParameterDirection.Input
                oSqlParameter(49).SqlDbType = SqlDbType.VarChar
                oSqlParameter(49).Value = oNode.Item("cobranca_telefone").InnerText

                Dim oXmlItem As New Xml.XmlDocument
                oXmlItem.LoadXml(oNode.OuterXml)

                Dim oNodesItem As Xml.XmlNodeList = oXmlItem.GetElementsByTagName("item")
                Dim oNodeItem As Xml.XmlNode
                For iNodeItem As Integer = 0 To oNodesItem.Count - 1
                    oNodeItem = oNodesItem(iNodeItem)

                    oSqlParameter(50) = New SqlParameter
                    oSqlParameter(50).ParameterName = "item_comprado_nome"
                    oSqlParameter(50).Direction = ParameterDirection.Input
                    oSqlParameter(50).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(50).Value = oNodeItem.Item("item_nome").InnerText

                    oSqlParameter(51) = New SqlParameter
                    oSqlParameter(51).ParameterName = "item_comprado_status_descricao"
                    oSqlParameter(51).Direction = ParameterDirection.Input
                    oSqlParameter(51).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(51).Value = oNodeItem.Item("item_status").InnerText

                    oSqlParameter(52) = New SqlParameter
                    oSqlParameter(52).ParameterName = "item_comprado_status_codigo"
                    oSqlParameter(52).Direction = ParameterDirection.Input
                    oSqlParameter(52).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(52).Value = oNodeItem.Item("item_codigo_status").InnerText

                    oSqlParameter(53) = New SqlParameter
                    oSqlParameter(53).ParameterName = "item_comprado_SKU"
                    oSqlParameter(53).Direction = ParameterDirection.Input
                    oSqlParameter(53).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(53).Value = oNodeItem.Item("item_sku").InnerText

                    oSqlParameter(54) = New SqlParameter
                    oSqlParameter(54).ParameterName = "item_comprado_opcoes"
                    oSqlParameter(54).Direction = ParameterDirection.Input
                    oSqlParameter(54).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(54).Value = oNodeItem.Item("item_opcoes").InnerText

                    oSqlParameter(55) = New SqlParameter
                    oSqlParameter(55).ParameterName = "item_comprado_preco_original"
                    oSqlParameter(55).Direction = ParameterDirection.Input
                    oSqlParameter(55).SqlDbType = SqlDbType.Float
                    oSqlParameter(55).Value = Replace(oNodeItem.Item("item_preco_original").InnerText, "R$", "")

                    oSqlParameter(56) = New SqlParameter
                    oSqlParameter(56).ParameterName = "item_comprado_preco"
                    oSqlParameter(56).Direction = ParameterDirection.Input
                    oSqlParameter(56).SqlDbType = SqlDbType.Float
                    oSqlParameter(56).Value = Replace(oNodeItem.Item("item_preco").InnerText, "R$", "")

                    oSqlParameter(57) = New SqlParameter
                    oSqlParameter(57).ParameterName = "item_comprado_quantidade_pedida"
                    oSqlParameter(57).Direction = ParameterDirection.Input
                    oSqlParameter(57).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(57).Value = oNodeItem.Item("item_pedido_quantidade").InnerText

                    oSqlParameter(58) = New SqlParameter
                    oSqlParameter(58).ParameterName = "item_comprado_quantidade_faturada"
                    oSqlParameter(58).Direction = ParameterDirection.Input
                    oSqlParameter(58).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(58).Value = oNodeItem.Item("item_fatura_quantidade").InnerText

                    oSqlParameter(59) = New SqlParameter
                    oSqlParameter(59).ParameterName = "item_comprado_quantidade_entregue"
                    oSqlParameter(59).Direction = ParameterDirection.Input
                    oSqlParameter(59).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(59).Value = oNodeItem.Item("item_entrega_quantidade").InnerText

                    oSqlParameter(60) = New SqlParameter
                    oSqlParameter(60).ParameterName = "item_comprado_quantidade_cancelado"
                    oSqlParameter(60).Direction = ParameterDirection.Input
                    oSqlParameter(60).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(60).Value = oNodeItem.Item("item_cancelado_quantidade").InnerText

                    oSqlParameter(61) = New SqlParameter
                    oSqlParameter(61).ParameterName = "item_comprado_quantidade_reembolsado"
                    oSqlParameter(61).Direction = ParameterDirection.Input
                    oSqlParameter(61).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(61).Value = oNodeItem.Item("item_reembolso_quantidade").InnerText

                    oSqlParameter(62) = New SqlParameter
                    oSqlParameter(62).ParameterName = "item_comprado_desconto"
                    oSqlParameter(62).Direction = ParameterDirection.Input
                    oSqlParameter(62).SqlDbType = SqlDbType.Float
                    oSqlParameter(62).Value = Replace(oNodeItem.Item("item_desconto").InnerText, "R$", "")

                    oSqlParameter(63) = New SqlParameter
                    oSqlParameter(63).ParameterName = "item_comprado_total"
                    oSqlParameter(63).Direction = ParameterDirection.Input
                    oSqlParameter(63).SqlDbType = SqlDbType.Float
                    oSqlParameter(63).Value = Replace(oNodeItem.Item("item_total").InnerText, "R$", "")

                    oSqlParameter(64) = New SqlParameter
                    oSqlParameter(64).ParameterName = "codigo_empresa"
                    oSqlParameter(64).Direction = ParameterDirection.Input
                    oSqlParameter(64).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(64).Value = goUsuario.iEmpresa

                    oSqlParameter(65) = New SqlParameter
                    oSqlParameter(65).ParameterName = "codigo_usuario"
                    oSqlParameter(65).Direction = ParameterDirection.Input
                    oSqlParameter(65).SqlDbType = SqlDbType.Int
                    oSqlParameter(65).Value = goUsuario.iUsuario


                    sEmailXML = oNode.Item("cliente_email").InnerText

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_venda_carcare_xml", oSqlParameter)

                Next
            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarPlanilhaPedido()

        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            'oSqlParameter(i) = New SqlParameter
            'oSqlParameter(i).ParameterName = "email"
            'oSqlParameter(i).Direction = ParameterDirection.Input
            'oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            'oSqlParameter(i).Value = sEmail : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_venda_carcare_pedido", oSqlParameter)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarPlanilhaPedidoXML()

        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmailXML : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_venda_carcare_pedido_xml", oSqlParameter)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadDataSetExcel(ByVal sArquivo As String, _
                      ByVal sPlanilha As String)
        Try



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function LoadRangeExcel(ByVal iIndice As Integer, ByVal iRow As Integer) As String
        Try

            Dim sIndice As String = ""
            If iIndice > 26 Then
                If iIndice - 26 > 26 Then
                    sIndice = "B"
                    iIndice -= 52
                Else
                    sIndice = "A"
                    iIndice -= 26
                End If
            Else

                sIndice = ""
            End If
            sIndice += Chr(64 + iIndice)

            Return sIndice & iRow
        Catch ex As Exception
            Throw ex
        End Try

    End Function
#End Region

#End Region

End Class

