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
Imports Newtonsoft.Json


Imports System.Net
Imports System.Runtime.Serialization.Json


Public Class clsUsrIntMagma

#Region "::: ENUM :::"

    Private Enum Produto
        CodigoProduto = 0
        Descricao = 1
        PrecoCompra = 2
        PrecoVenda = 3
        UnidadeMedida = 5
        CodigoNCM = 10
        CodigoOrigemItem = 9
    End Enum

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub ImportarProduto(ByVal lCodigoVitrine As Long, _
                               ByVal sCodigoVitrine As String, _
                               ByVal sDataInicio As String, _
                               ByVal sDataTermino As String)

        'Váriaveis Locais           
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriaveis
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = IIf(lCodigoVitrine = -1, DBNull.Value, lCodigoVitrine) : i += 1

                'Seta Parametros - Código Vitrine
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_vitrine"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = sCodigoVitrine : i += 1

                'Seta Parametros - Data Início
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_inicio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = sDataInicio : i += 1

                'Seta Parametros - Data Término
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_termino"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = sDataTermino : i += 1

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("codigo_item").Value : i += 1

                'Seta Parametros - Descrição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 120
                oSqlParameter(i).Value = oRow.Cells("descricao").Value : i += 1

                'Seta Parametros - Código NCM
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "ncm"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 8
                oSqlParameter(i).Value = oRow.Cells("codigo_ncm").Value : i += 1

                'Seta Parametros - Unidade Medida - Venda
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "unidade_medida"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 6
                oSqlParameter(i).Value = oRow.Cells("unidade_medida").Value : i += 1

                'Seta Parametros - Preço Revendedor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "preco_revendedor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("preco_revendedor").Value : i += 1

                'Seta Parametros - Preço Consumidor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "preco_consumidor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("preco_consumidor").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_magma", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarPedido(ByVal sVetor() As String)

        'Váriaveis Locais           
        Dim oSqlParameter(40) As SqlParameter
        Dim sValores() As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim sMensagem As String
        Dim lCodigoPedido As Long

        Try

            For j = 0 To UBound(sVetor)

                'Seta Váriaveis
                i = 0

                If sVetor(j).Substring(1, 1) = "" Then

                    sValores = sVetor(j).Split(",")

                    'Seta Parametros - Código Representante
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_representante"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 20
                    oSqlParameter(i).Value = sVetor(j).Substring(4, 6) : i += 1

                    'Seta Parametros - Nº Pedido
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "numero_pedido"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 20
                    oSqlParameter(i).Value = sVetor(j).Substring(4, 6) : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                    'Seta Parametros - Código Usuário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_usuario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                    'Seta Parametros - Código Pedido
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_pedido"
                    oSqlParameter(i).Direction = ParameterDirection.Output
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_import_pedido_capa", oSqlParameter)

                    lCodigoPedido = oSqlParameter(i).Value

                Else

                    sValores = sVetor(j).Split(",")

                    'Seta Parametros - Código Pedido
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_pedido"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoPedido : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                    'Seta Parametros - Código Produto
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_produto"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 60
                    oSqlParameter(i).Value = sValores(0) : i += 1

                    'Seta Parametros - Quantidade
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "quantidade"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = sValores(1)

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_import_pedido_linha", oSqlParameter)

                End If

                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = j

                sMensagem = oSqlParameter(i).Value

            Next j

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarParceiroNegocio()

        'Váriaveis Locais           
        Dim oSqlParameter(32) As SqlParameter
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim sMensagem As String

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0
                j = j + 1

                'Seta Parametros - Código Personalidade
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_personalidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = Personalidade.Fisica : i += 1

                'Seta Parametros - Cliente
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cliente"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = 1 : i += 1

                'Seta Parametros - Fornecedor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "fornecedor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = 0 : i += 1

                'Seta Parametros - Agente Logistico
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "agente_logistico"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = 0 : i += 1

                'Seta Parametros - Despachante
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "despachante"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = 0 : i += 1

                'Seta Parametros - Código Magma
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_identificacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("codigo_identificacao").Value : i += 1

                'Seta Parametros - Razão Social
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "razao_social"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("nome").Value : i += 1

                'Seta Parametros - Nome Fantasia
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_fantasia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("nome").Value : i += 1

                'Seta Parametros - Logradouro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "logradouro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("tipo_logradouro").Value & " " & oRow.Cells("logradouro").Value : i += 1

                'Seta Parametros - Número
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("numero").Value : i += 1

                'Seta Parametros - Bairro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "bairro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("bairro").Value : i += 1

                'Seta Parametros - CEP
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cep"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).Size = 10
                oSqlParameter(i).Value = oRow.Cells("cep").Value : i += 1

                'Seta Parametros - Complemento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "complemento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("ponto_referencia").Value : i += 1

                'Seta Parametros - Código IBGE
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ibge"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 10
                oSqlParameter(i).Value = oRow.Cells("codigo_ibge").Value : i += 1

                'Seta Parametros - Celular
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "celular"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("celular").Value : i += 1

                'Seta Parametros - Telefone
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "telefone"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("telefone").Value : i += 1

                'Seta Parametros - E-mail
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "email"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("email").Value : i += 1

                'Seta Parametros - Ano Cadastro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "ano_cadastro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("ano").Value : i += 1

                'Seta Parametros - Semana Cadastro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "semana_cadastro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("semana").Value : i += 1

                'Seta Parametros - Código Indicador
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_indicador"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("codigo_indicante").Value : i += 1

                'Seta Parametros - Sexo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "sexo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 1
                oSqlParameter(i).Value = oRow.Cells("sexo").Value : i += 1

                'Seta Parametros - Data Nascimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_nascimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_nascimento").Value : i += 1

                'Seta Parametros - CPF
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cpf"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("cpf").Value : i += 1

                'Seta Parametros - RG
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "rg"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("rg").Value : i += 1

                'Seta Parametros - Órgão Emissor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "orgao_emissor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 10
                oSqlParameter(i).Value = oRow.Cells("orgao_expedidor").Value : i += 1

                'Seta Parametros - Data Emissão
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_emissao_rg"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_emissao_rg").Value : i += 1

                'Seta Parametros - Nome Pai
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_pai"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("nome_pai").Value : i += 1

                'Seta Parametros - Nome Mãe
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_mae"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("nome_mae").Value : i += 1

                'Seta Parametros - Data Cadastro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_cadastro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_cadastro").Value : i += 1

                'Seta Parametros - Rota
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "rota"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("rota").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Mensagem
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "mensagem"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 1000

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_import_cadastro_basico_parceiro_negocio", oSqlParameter)

                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = j

                sMensagem = oSqlParameter(i).Value

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDataTableConsultor(ByRef oDataSet As DataSet, _
                                      ByVal sCNPJCPF As String, _
                                      ByVal sCEP As String, _
                                      ByVal sNumero As String)

        'Variaveis Locais
        Dim oDataRow As DataRow
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Identificação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJCPF : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEP : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumero : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastrato_basico_parceiro_negocio_cep_numero", oSqlParameter)

            While oSqlDataReader.Read

                'Adicionando na tabela
                oDataRow = oDataSet.Tables(1).Rows.Add

                'Setando os valores
                oDataRow("codigo") = oSqlDataReader.Item("codigo")
                oDataRow("nome") = oSqlDataReader.Item("nome")
                oDataRow("condicao_pagamento") = oSqlDataReader.Item("condicao_pagamento")
                oDataRow("limite_credito") = oSqlDataReader.Item("limite_credito")
                oDataRow("cep") = sCEP
                oDataRow("numero") = sNumero

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDataTableCliente(ByRef oDataSet As DataSet, _
                                    ByVal sNumeroPedido As String, _
                                    ByVal sCodigoIdentificacao As String)

        'Variaveis Locais
        Dim oDataRow As DataRow
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Identificação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_identificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoIdentificacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastrato_basico_parceiro_negocio_codigo_identificacao", oSqlParameter)

            If oSqlDataReader.HasRows = False Then

                'Adicionando na tabela
                oDataRow = oDataSet.Tables(0).Rows.Add

                'Setando os valores
                oDataRow("numero_pedido") = sNumeroPedido
                oDataRow("codigo_identificacao") = sCodigoIdentificacao

            Else

                While oSqlDataReader.Read

                    'Adicionando na tabela
                    oDataRow = oDataSet.Tables(0).Rows.Add

                    'Setando os valores
                    oDataRow("numero_pedido") = sNumeroPedido
                    oDataRow("codigo_identificacao") = sCodigoIdentificacao
                    oDataRow("nome") = oSqlDataReader.Item("razao_social")
                    oDataRow("logradouro") = oSqlDataReader.Item("logradouro")
                    oDataRow("numero") = oSqlDataReader.Item("numero")
                    oDataRow("bairro") = oSqlDataReader.Item("bairro")
                    oDataRow("cep") = oSqlDataReader.Item("cep")
                    oDataRow("ponto_referencia") = oSqlDataReader.Item("complemento")
                    oDataRow("municipio") = oSqlDataReader.Item("municipio")
                    oDataRow("celular") = oSqlDataReader.Item("telefone1")
                    oDataRow("telefone") = oSqlDataReader.Item("telefone2")
                    oDataRow("telefone2") = oSqlDataReader.Item("telefone_recado")
                    oDataRow("email") = oSqlDataReader.Item("email2")
                    oDataRow("semana_ano") = oSqlDataReader.Item("semana_ano")
                    oDataRow("indicante") = oSqlDataReader.Item("indicante")
                    oDataRow("sexo") = oSqlDataReader.Item("sexo")
                    oDataRow("data_nascimento") = oSqlDataReader.Item("data_nascimento")
                    oDataRow("cpf") = oSqlDataReader.Item("cpf")
                    oDataRow("rg") = oSqlDataReader.Item("rg")
                    oDataRow("orgao_emissor") = oSqlDataReader.Item("orgao_emissor")
                    oDataRow("data_emissao_rg") = oSqlDataReader.Item("data_emissao_rg")
                    oDataRow("nome_mae") = oSqlDataReader.Item("nome_mae")
                    oDataRow("nome_pai") = oSqlDataReader.Item("nome_pai")
                    oDataRow("data_cadastro") = oSqlDataReader.Item("data_cadastro")
                    oDataRow("rota") = oSqlDataReader.Item("rota")
                    oDataRow("codigo") = oSqlDataReader.Item("codigo")

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridVitrine(ByVal oGrid As GridEX, _
                               ByVal lCodigoVitrine As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Vitrine
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vitrine"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoVitrine : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_vitrine_produto", oSqlParameter)

            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Public Sub LoadGridJson(ByVal oGrid As GridEX, ByVal sUrl As String)


    '    Try

    '        'Client para trazer os dados da string
    '        Dim oClient As New WebClient
    '        Dim sResponse As String

    '        'Traz os dados de ocorrencias
    '        sResponse = oClient.DownloadString(New Uri(sUrl))

    '        'Quebra o JSON como serializer
    '        Dim oOcorrenciaList = JsonConvert.DeserializeObject(Of List(Of Ocorrencia))(sResponse)


    '        Dim oDataSet As New DataSet
    '        oDataSet.Tables.Add("main")


    '        oDataSet.Tables(0).Columns.Add("link")
    '        oDataSet.Tables(0).Columns.Add("codigo_produto_0")
    '        oDataSet.Tables(0).Columns.Add("codigo_produto_1")
    '        oDataSet.Tables(0).Columns.Add("codigo_produto_2")
    '        oDataSet.Tables(0).Columns.Add("codigo_produto_3")
    '        oDataSet.Tables(0).Columns.Add("codigo_produto_4")
    '        oDataSet.Tables(0).Columns.Add("codigo_revendedora")
    '        oDataSet.Tables(0).Columns.Add("distrito_consultora")
    '        oDataSet.Tables(0).Columns.Add("grupo_revendedora")
    '        oDataSet.Tables(0).Columns.Add("codigo")
    '        oDataSet.Tables(0).Columns.Add("link_consultora")
    '        oDataSet.Tables(0).Columns.Add("data")
    '        oDataSet.Tables(0).Columns.Add("data_modificacao")
    '        oDataSet.Tables(0).Columns.Add("motivo_0")
    '        oDataSet.Tables(0).Columns.Add("motivo_1")
    '        oDataSet.Tables(0).Columns.Add("motivo_2")
    '        oDataSet.Tables(0).Columns.Add("motivo_3")
    '        oDataSet.Tables(0).Columns.Add("motivo_4")
    '        oDataSet.Tables(0).Columns.Add("produto_0")
    '        oDataSet.Tables(0).Columns.Add("produto_1")
    '        oDataSet.Tables(0).Columns.Add("produto_2")
    '        oDataSet.Tables(0).Columns.Add("produto_3")
    '        oDataSet.Tables(0).Columns.Add("produto_4")
    '        oDataSet.Tables(0).Columns.Add("nota_fiscal")
    '        oDataSet.Tables(0).Columns.Add("obs_0")
    '        oDataSet.Tables(0).Columns.Add("obs_1")
    '        oDataSet.Tables(0).Columns.Add("obs_2")
    '        oDataSet.Tables(0).Columns.Add("obs_3")
    '        oDataSet.Tables(0).Columns.Add("obs_4")
    '        oDataSet.Tables(0).Columns.Add("oc_exportado")
    '        oDataSet.Tables(0).Columns.Add("protocolo")
    '        oDataSet.Tables(0).Columns.Add("qtd_produto_0")
    '        oDataSet.Tables(0).Columns.Add("qtd_produto_1")
    '        oDataSet.Tables(0).Columns.Add("qtd_produto_2")
    '        oDataSet.Tables(0).Columns.Add("qtd_produto_3")
    '        oDataSet.Tables(0).Columns.Add("qtd_produto_4")
    '        oDataSet.Tables(0).Columns.Add("semana_nf")
    '        oDataSet.Tables(0).Columns.Add("status")
    '        oDataSet.Tables(0).Columns.Add("status_produto_0")
    '        oDataSet.Tables(0).Columns.Add("status_produto_1")
    '        oDataSet.Tables(0).Columns.Add("status_produto_2")
    '        oDataSet.Tables(0).Columns.Add("status_produto_3")
    '        oDataSet.Tables(0).Columns.Add("status_produto_4")
    '        oDataSet.Tables(0).Columns.Add("consultora")

    '        'Percorre todos os itens da tabela
    '        For Each ItemOcorrencia As Ocorrencia In oOcorrenciaList

    '            'Adiciona uma linha
    '            Dim oDataRow As DataRow = oDataSet.Tables(0).Rows.Add

    '            If ItemOcorrencia._links.self.Count > 0 Then oDataRow("link") = ItemOcorrencia._links.self(0).href

    '            oDataRow("codigo_produto_0") = ItemOcorrencia.codprod_0
    '            oDataRow("codigo_produto_1") = ItemOcorrencia.codprod_1
    '            oDataRow("codigo_produto_2") = ItemOcorrencia.codprod_2
    '            oDataRow("codigo_produto_3") = ItemOcorrencia.codprod_3
    '            oDataRow("codigo_produto_4") = ItemOcorrencia.codprod_4
    '            oDataRow("codigo_revendedora") = ItemOcorrencia.codrevend
    '            oDataRow("grupo_revendedora") = ItemOcorrencia.grpconsultora
    '            oDataRow("distrito_consultora") = ItemOcorrencia.distconsul
    '            oDataRow("codigo") = ItemOcorrencia.id
    '            oDataRow("link_consultora") = ItemOcorrencia.link
    '            oDataRow("data") = ItemOcorrencia.date
    '            oDataRow("data_modificacao") = ItemOcorrencia.modified
    '            oDataRow("motivo_0") = ItemOcorrencia.motivo_0
    '            oDataRow("motivo_1") = ItemOcorrencia.motivo_1
    '            oDataRow("motivo_2") = ItemOcorrencia.motivo_2
    '            oDataRow("motivo_3") = ItemOcorrencia.motivo_3
    '            oDataRow("motivo_4") = ItemOcorrencia.motivo_4
    '            oDataRow("produto_0") = ItemOcorrencia.nomeprod_0
    '            oDataRow("produto_1") = ItemOcorrencia.nomeprod_1
    '            oDataRow("produto_2") = ItemOcorrencia.nomeprod_2
    '            oDataRow("produto_3") = ItemOcorrencia.nomeprod_3
    '            oDataRow("produto_4") = ItemOcorrencia.nomeprod_4
    '            oDataRow("nota_fiscal") = ItemOcorrencia.numeronf
    '            oDataRow("obs_0") = ItemOcorrencia.obs_0
    '            oDataRow("obs_1") = ItemOcorrencia.obs_1
    '            oDataRow("obs_2") = ItemOcorrencia.obs_2
    '            oDataRow("obs_3") = ItemOcorrencia.obs_3
    '            oDataRow("obs_4") = ItemOcorrencia.obs_4
    '            oDataRow("oc_exportado") = ItemOcorrencia.ocexportado
    '            oDataRow("protocolo") = ItemOcorrencia.protocolo
    '            oDataRow("qtd_produto_0") = ItemOcorrencia.qtdprod_0
    '            oDataRow("qtd_produto_1") = ItemOcorrencia.qtdprod_1
    '            oDataRow("qtd_produto_2") = ItemOcorrencia.qtdprod_2
    '            oDataRow("qtd_produto_3") = ItemOcorrencia.qtdprod_3
    '            oDataRow("qtd_produto_4") = ItemOcorrencia.qtdprod_4
    '            oDataRow("semana_nf") = ItemOcorrencia.semananf
    '            oDataRow("status") = ItemOcorrencia.status
    '            oDataRow("status_produto_0") = ItemOcorrencia.stsprod_0
    '            oDataRow("status_produto_1") = ItemOcorrencia.stsprod_1
    '            oDataRow("status_produto_2") = ItemOcorrencia.stsprod_2
    '            oDataRow("status_produto_3") = ItemOcorrencia.stsprod_3
    '            oDataRow("status_produto_4") = ItemOcorrencia.stsprod_4
    '            oDataRow("consultora") = ItemOcorrencia.title.rendered

    '        Next


    '        'Limpa as colunas da grid
    '        oGrid.RootTable.Columns.Clear()


    '        'Configura a grid de acordo com o dataset
    '        For Each oDataColumn As DataColumn In oDataSet.Tables(0).Columns

    '            oGrid.RootTable.Columns.Add(oDataColumn.ColumnName).Caption = oDataColumn.ColumnName

    '        Next


    '        'Configura os datamembers
    '        ConfigurarDataMemberGrid(oGrid)

    '        'Carrega Grid
    '        oGrid.DataSource = oDataSet.DefaultViewManager
    '        oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub ImportarOcorrenciasJson(ByVal oGrid As GridEX, ByVal sUrl As String)


        Try
            

            'Primeiro, exclui os dados da tabela de integração
            Call DeleteIntegracaoOcorrencia()


            'Client para trazer os dados da string
            Dim oClient As New WebClient
            Dim sResponse As String

            'Traz os dados de ocorrencias
            sResponse = oClient.DownloadString(New Uri(sUrl))

            'Quebra o JSON como serializer
            Dim oOcorrenciaList = JsonConvert.DeserializeObject(Of List(Of Ocorrencia))(sResponse)


            Dim oSqlParameter(44) As SqlParameter


            'Percorre todos os itens da tabela
            For Each ItemOcorrencia As Ocorrencia In oOcorrenciaList

                'Insere no BD
                Dim i As Integer = 0


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "link_ocorrencia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                If ItemOcorrencia._links.self.Count > 0 Then
                    oSqlParameter(i).Value = ItemOcorrencia._links.self(0).href
                Else
                    oSqlParameter(i).Value = ""
                End If
                i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto_0"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.codprod_0 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto_1"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.codprod_1 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto_2"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.codprod_2 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto_3"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.codprod_3 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto_4"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.codprod_4 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_revendedora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.codrevend : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "grupo_consultora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.grpconsultora : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "distrito_consultora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.codrevend : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ocorrencia_site"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.id : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "link_consultora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.link : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = ItemOcorrencia.date : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_modificacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = ItemOcorrencia.modified : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "motivo_0"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.motivo_0 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "motivo_1"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.motivo_1 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "motivo_2"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.motivo_2 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "motivo_3"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.motivo_3 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "motivo_4"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.motivo_4 : i += 1
 
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "produto_0"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.nomeprod_0 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "produto_1"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.nomeprod_1 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "produto_2"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.nomeprod_2 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "produto_3"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.nomeprod_3 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "produto_4"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.nomeprod_4 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nota_fiscal"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.numeronf : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "obs_0"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.obs_0 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "obs_1"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.obs_1 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "obs_2"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.obs_2 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "obs_3"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.obs_3 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "obs_4"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.obs_4 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "oc_exportado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.ocexportado : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "protocolo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.protocolo : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "qtd_produto_0"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.qtdprod_0 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "qtd_produto_1"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.qtdprod_1 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "qtd_produto_2"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.qtdprod_2 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "qtd_produto_3"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.qtdprod_3 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "qtd_produto_4"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.qtdprod_4 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "semana_nf"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.semananf : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.status : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status_produto_0"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.stsprod_0 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status_produto_1"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.stsprod_1 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status_produto_2"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.stsprod_2 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status_produto_3"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.stsprod_3 : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status_produto_4"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.stsprod_4 : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "consultora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = ItemOcorrencia.title.rendered : i += 1

                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_magma_ocorrencia_site", oSqlParameter)

            Next


            'Agora faz um loadgrid 
            ReDim Preserve oSqlParameter(0)


            'Limpa os formatcondition
            oGrid.RootTable.FormatConditions.Clear()

            'Limpa as colunas da grid
            oGrid.RootTable.Columns.Clear()

            'Carrega os dados
            Dim oDataSet As New DataSet
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_magma_ocorrencia_site", oSqlParameter)


            'Configura a grid de acordo com o dataset
            For Each oDataColumn As DataColumn In oDataSet.Tables(0).Columns

                oGrid.RootTable.Columns.Add(oDataColumn.ColumnName).Caption = oDataColumn.ColumnName.Replace("_", " ")
                Select Case oDataColumn.ColumnName
                    Case "codigo"
                        oGrid.RootTable.Columns(oDataColumn.ColumnName).Visible = False
                    Case "codigo_empresa"
                        oGrid.RootTable.Columns(oDataColumn.ColumnName).Visible = False
                End Select


            Next


            'Configura os datamembers
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()


            'Insere os dois format conditions 
            Dim oFormatCondition As GridEXFormatCondition

            oFormatCondition = New GridEXFormatCondition(oGrid.RootTable.Columns("status_interacti"), ConditionOperator.IsNull, "")
            oFormatCondition.FormatStyle.ForeColor = Color.ForestGreen
            oGrid.RootTable.FormatConditions.Add(oFormatCondition)

            oFormatCondition = New GridEXFormatCondition(oGrid.RootTable.Columns("status_interacti"), ConditionOperator.NotIsNull, "")
            oFormatCondition.FormatStyle.ForeColor = Color.SteelBlue
            oGrid.RootTable.FormatConditions.Add(oFormatCondition)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DeleteIntegracaoOcorrencia()


        Try



            Dim oSqlParameter(0) As SqlParameter

            'Insere no BD
            Dim i As Integer = 0


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1



            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_integracao_magma_ocorrencia_site", oSqlParameter)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InsertOcorencia(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(14) As SqlParameter


        Try

            For Each oRow In oGrid.GetDataRows

                If IsDBNull(oRow.Cells.Item("status_interacti").Value) Then

                    oSqlParameter(0) = New SqlParameter
                    oSqlParameter(0).ParameterName = "codigo_empresa"
                    oSqlParameter(0).Direction = ParameterDirection.Input
                    oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(0).Value = goUsuario.iEmpresa

                    oSqlParameter(1) = New SqlParameter
                    oSqlParameter(1).ParameterName = "numero_protocolo"
                    oSqlParameter(1).Direction = ParameterDirection.Input
                    oSqlParameter(1).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(1).Value = oRow.Cells("protocolo").Value

                    oSqlParameter(2) = New SqlParameter
                    oSqlParameter(2).ParameterName = "data"
                    oSqlParameter(2).Direction = ParameterDirection.Input
                    oSqlParameter(2).SqlDbType = SqlDbType.DateTime
                    oSqlParameter(2).Value = oRow.Cells("data").Value

                    oSqlParameter(3) = New SqlParameter
                    oSqlParameter(3).ParameterName = "semana_nf"
                    oSqlParameter(3).Direction = ParameterDirection.Input
                    oSqlParameter(3).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(3).Value = IIf(IsDBNull(oRow.Cells("semana_nf").Value) = True, DBNull.Value, oRow.Cells("semana_nf").Value)

                    oSqlParameter(4) = New SqlParameter
                    oSqlParameter(4).ParameterName = "codigo_revendedor"
                    oSqlParameter(4).Direction = ParameterDirection.Input
                    oSqlParameter(4).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(4).Value = IIf(IsDBNull(oRow.Cells("codigo_revendedora").Value) = True, DBNull.Value, oRow.Cells("codigo_revendedora").Value)

                    oSqlParameter(5) = New SqlParameter
                    oSqlParameter(5).ParameterName = "nome_revendor"
                    oSqlParameter(5).Direction = ParameterDirection.Input
                    oSqlParameter(5).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(5).Value = oRow.Cells("consultora").Value.ToString.Trim

                    oSqlParameter(6) = New SqlParameter
                    oSqlParameter(6).ParameterName = "nota_fiscal"
                    oSqlParameter(6).Direction = ParameterDirection.Input
                    oSqlParameter(6).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(6).Value = oRow.Cells("nota_fiscal").Value.ToString.Trim



                    oSqlParameter(7) = New SqlParameter
                    oSqlParameter(7).ParameterName = "codigo_produto"
                    oSqlParameter(7).Direction = ParameterDirection.Input
                    oSqlParameter(7).SqlDbType = SqlDbType.VarChar


                    oSqlParameter(8) = New SqlParameter
                    oSqlParameter(8).ParameterName = "nome_produto"
                    oSqlParameter(8).Direction = ParameterDirection.Input
                    oSqlParameter(8).SqlDbType = SqlDbType.VarChar


                    oSqlParameter(9) = New SqlParameter
                    oSqlParameter(9).ParameterName = "quantidade"
                    oSqlParameter(9).Direction = ParameterDirection.Input
                    oSqlParameter(9).SqlDbType = SqlDbType.VarChar

                    oSqlParameter(10) = New SqlParameter
                    oSqlParameter(10).ParameterName = "motivo"
                    oSqlParameter(10).Direction = ParameterDirection.Input
                    oSqlParameter(10).SqlDbType = SqlDbType.VarChar

                    oSqlParameter(11) = New SqlParameter
                    oSqlParameter(11).ParameterName = "observacao"
                    oSqlParameter(11).Direction = ParameterDirection.Input
                    oSqlParameter(11).SqlDbType = SqlDbType.VarChar

                    oSqlParameter(12) = New SqlParameter
                    oSqlParameter(12).ParameterName = "codigo_status"
                    oSqlParameter(12).Direction = ParameterDirection.Input
                    oSqlParameter(12).SqlDbType = SqlDbType.Int

                    oSqlParameter(13) = New SqlParameter
                    oSqlParameter(13).ParameterName = "codigo"
                    oSqlParameter(13).Direction = ParameterDirection.Output
                    oSqlParameter(13).SqlDbType = SqlDbType.BigInt


                    oSqlParameter(14) = New SqlParameter
                    oSqlParameter(14).ParameterName = "codigo_ocorrencia_site"
                    oSqlParameter(14).Direction = ParameterDirection.Input
                    oSqlParameter(14).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(14).Value = oRow.Cells("codigo_ocorrencia_site").Value.ToString.Trim

                    'Verifica de 0 até 4 (existem 5 campos para inserir)
                    For i As Integer = 0 To 4

                        'Verifica
                        If oRow.Cells.Item("codigo_produto_" & CStr(i)).Value.ToString.Trim <> "" Then


                            'Define os valores
                            oSqlParameter(7).Value = oRow.Cells("codigo_produto_" & CStr(i)).Value.ToString.Trim
                            oSqlParameter(8).Value = oRow.Cells("produto_" & CStr(i)).Value.ToString.Trim
                            oSqlParameter(9).Value = oRow.Cells("qtd_produto_" & CStr(i)).Value.ToString.Trim
                            oSqlParameter(10).Value = oRow.Cells("motivo_" & CStr(i)).Value.ToString.Trim
                            oSqlParameter(11).Value = oRow.Cells("obs_" & CStr(i)).Value.ToString.Trim
                            oSqlParameter(12).Value = oRow.Cells("status_produto_" & CStr(i)).Value

                            'Executa Query  
                            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_ocorrencia", oSqlParameter)

                        End If

                        

                    Next

                   
                End If


            Next


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidarInserirOcorencia(ByVal oGrid As GridEX) As Boolean

        'Variaveis Locais

        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            ValidarInserirOcorencia = False

         
            ''Seta Parametros - Código Empresa
            'oSqlParameter(i) = New SqlParameter
            'oSqlParameter(i).ParameterName = "codigo_empresa"
            'oSqlParameter(i).Direction = ParameterDirection.Input
            'oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            'oSqlParameter(i).Value = goUsuario.iEmpresa

            ''Executa Query
            'ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_vitrine_produto", oSqlParameter)

            ValidarInserirOcorencia = True

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class


