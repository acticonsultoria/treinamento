Imports INTERACTI.SQLHelper
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX

Public Class clsUsrIntImportacaoSintegra

#Region "::: FUNCTION / SUB :::"

    Public Sub DeleteArquivoImportado(ByVal sArquivo As String)

        Try

            'Variaveis Locais
            Dim oSqlParameter(0) As SqlParameter

            'Seta Parametros - Data Inventário
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "arquivo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 255
            oSqlParameter(0).Value = sArquivo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_sintegra_arquivo_importado", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRegistro50(ByVal sLinha As String, _
                                ByVal sArquivo As String, _
                                ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oSqlParameter(17) As SqlParameter

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 14
            oSqlParameter(0).Value = Mid(sLinha, 3, 14).Trim

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "inscricao_estadual"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 14
            oSqlParameter(1).Value = Mid(sLinha, 17, 14).Trim

            'Seta Parametros - Data Emissão
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_emissao"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = CDate(Mid(sLinha, 37, 2) & "/" & Mid(sLinha, 35, 2) & "/" & Mid(sLinha, 31, 4))

            'Seta Parametros - UF
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "uf"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 2
            oSqlParameter(3).Value = Mid(sLinha, 39, 2).Trim

            'Seta Parametros - Modelo
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "modelo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = Mid(sLinha, 41, 2).Trim

            'Seta Parametros - Série
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "serie"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 3
            oSqlParameter(5).Value = Mid(sLinha, 43, 3)

            'Seta Parametros - Número
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "numero"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.BigInt
            oSqlParameter(6).Value = Mid(sLinha, 46, 6).Trim

            'Seta Parametros - CFOP
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "cfop"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Size = 4
            oSqlParameter(7).Value = Mid(sLinha, 52, 4).Trim

            'Seta Parametros - Emitente
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "emitente"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Size = 1
            oSqlParameter(8).Value = Mid(sLinha, 56, 1).Trim

            'Seta Parametros - Valor Total
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "valor_total"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Decimal
            oSqlParameter(9).Value = CLng(Mid(sLinha, 57, 13).Trim) / 100

            'Seta Parametros - Base de Cálculo do ICMS
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "base_calculo_icms"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Decimal
            oSqlParameter(10).Value = CLng(Mid(sLinha, 70, 13).Trim) / 100

            'Seta Parametros - Valor ICMS
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "valor_icms"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Decimal
            oSqlParameter(11).Value = CLng(Mid(sLinha, 83, 13).Trim) / 100

            'Seta Parametros - Isenta
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "isenta"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Decimal
            oSqlParameter(12).Value = CLng(Mid(sLinha, 96, 13).Trim) / 100

            'Seta Parametros - Outras
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "outras"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Decimal
            oSqlParameter(13).Value = CLng(Mid(sLinha, 109, 13).Trim) / 100

            'Seta Parametros - Alíquota
            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "aliquota"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.Decimal
            oSqlParameter(14).Value = CLng(Mid(sLinha, 122, 4).Trim) / 100

            'Seta Parametros - Situação
            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "situacao"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.VarChar
            oSqlParameter(15).Size = 1
            oSqlParameter(15).Value = Mid(sLinha, 126, 1).Trim

            'Seta Parametros - Arquivo
            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "arquivo"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.VarChar
            oSqlParameter(16).Size = 500
            oSqlParameter(16).Value = sArquivo

            oSqlParameter(17) = New SqlParameter
            oSqlParameter(17).ParameterName = "codigo_empresa"
            oSqlParameter(17).Direction = ParameterDirection.Input
            oSqlParameter(17).SqlDbType = SqlDbType.Int
            oSqlParameter(17).Value = iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_sintegra_registro_50", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRegistro51(ByVal sLinha As String, _
                                ByVal sArquivo As String, _
                                ByVal iEmpresa As Integer)

        Try

            If Mid(sLinha, 52, 4).Trim <> "3101" And Mid(sLinha, 52, 4).Trim <> "3127" Then

                'Variaveis Locais
                Dim oSqlParameter(13) As SqlParameter

                'Seta Parametros - CNPJ
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "cnpj"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.VarChar
                oSqlParameter(0).Size = 14
                oSqlParameter(0).Value = Mid(sLinha, 3, 14).Trim

                'Seta Parametros - Inscrição Estadual
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "inscricao_estadual"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.VarChar
                oSqlParameter(1).Size = 14
                oSqlParameter(1).Value = Mid(sLinha, 17, 14).Trim

                'Seta Parametros - Data Emissão
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "data_emissao"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Date
                oSqlParameter(2).Value = CDate(Mid(sLinha, 37, 2) & "/" & Mid(sLinha, 35, 2) & "/" & Mid(sLinha, 31, 4))

                'Seta Parametros - UF
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "uf"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.VarChar
                oSqlParameter(3).Size = 2
                oSqlParameter(3).Value = Mid(sLinha, 39, 2).Trim

                'Seta Parametros - Série
                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "serie"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.VarChar
                oSqlParameter(4).Size = 3
                oSqlParameter(4).Value = Mid(sLinha, 41, 3)

                'Seta Parametros - Número
                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "numero"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.BigInt
                oSqlParameter(5).Value = Mid(sLinha, 44, 6).Trim

                'Seta Parametros - CFOP
                oSqlParameter(6) = New SqlParameter
                oSqlParameter(6).ParameterName = "cfop"
                oSqlParameter(6).Direction = ParameterDirection.Input
                oSqlParameter(6).SqlDbType = SqlDbType.VarChar
                oSqlParameter(6).Size = 4
                oSqlParameter(6).Value = Mid(sLinha, 50, 4).Trim

                'Seta Parametros - Valor Total
                oSqlParameter(7) = New SqlParameter
                oSqlParameter(7).ParameterName = "valor_total"
                oSqlParameter(7).Direction = ParameterDirection.Input
                oSqlParameter(7).SqlDbType = SqlDbType.Decimal
                oSqlParameter(7).Value = CLng(Mid(sLinha, 54, 13).Trim) / 100

                'Seta Parametros - Valor IPI
                oSqlParameter(8) = New SqlParameter
                oSqlParameter(8).ParameterName = "valor_ipi"
                oSqlParameter(8).Direction = ParameterDirection.Input
                oSqlParameter(8).SqlDbType = SqlDbType.Decimal
                oSqlParameter(8).Value = CLng(Mid(sLinha, 67, 13).Trim) / 100

                'Seta Parametros - Isenta / Não Tributada
                oSqlParameter(9) = New SqlParameter
                oSqlParameter(9).ParameterName = "isenta_nao_tributada"
                oSqlParameter(9).Direction = ParameterDirection.Input
                oSqlParameter(9).SqlDbType = SqlDbType.Decimal
                oSqlParameter(9).Value = CLng(Mid(sLinha, 80, 13).Trim) / 100

                'Seta Parametros - Outras
                oSqlParameter(10) = New SqlParameter
                oSqlParameter(10).ParameterName = "outras"
                oSqlParameter(10).Direction = ParameterDirection.Input
                oSqlParameter(10).SqlDbType = SqlDbType.Decimal
                oSqlParameter(10).Value = CLng(Mid(sLinha, 93, 13).Trim) / 100

                'Seta Parametros - Situação
                oSqlParameter(11) = New SqlParameter
                oSqlParameter(11).ParameterName = "situacao"
                oSqlParameter(11).Direction = ParameterDirection.Input
                oSqlParameter(11).SqlDbType = SqlDbType.VarChar
                oSqlParameter(11).Size = 1
                oSqlParameter(11).Value = Mid(sLinha, 126, 1).Trim

                'Seta Parametros - Arquivo
                oSqlParameter(12) = New SqlParameter
                oSqlParameter(12).ParameterName = "arquivo"
                oSqlParameter(12).Direction = ParameterDirection.Input
                oSqlParameter(12).SqlDbType = SqlDbType.VarChar
                oSqlParameter(12).Size = 255
                oSqlParameter(12).Value = sArquivo

                oSqlParameter(13) = New SqlParameter
                oSqlParameter(13).ParameterName = "codigo_empresa"
                oSqlParameter(13).Direction = ParameterDirection.Input
                oSqlParameter(13).SqlDbType = SqlDbType.Int
                oSqlParameter(13).Value = iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_sintegra_registro_51", oSqlParameter)

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRegistro54(ByVal sLinha As String, _
                                ByVal sArquivo As String, _
                                ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oSqlParameter(16) As SqlParameter

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 14
            oSqlParameter(0).Value = Mid(sLinha, 3, 14).Trim

            'Seta Parametros - Modelo
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "modelo"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = Mid(sLinha, 17, 2).Trim

            'Seta Parametros - Série
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "serie"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 3
            oSqlParameter(2).Value = Mid(sLinha, 19, 3)

            'Seta Parametros - Número
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "numero"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = Mid(sLinha, 22, 6).Trim

            'Seta Parametros - CFOP
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "cfop"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 4
            oSqlParameter(4).Value = Mid(sLinha, 28, 4).Trim

            'Seta Parametros - CST
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "cst"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 3
            oSqlParameter(5).Value = Mid(sLinha, 32, 3).Trim

            'Seta Parametros - Número do Item
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "numero_item"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(6).Value = Mid(sLinha, 35, 3).Trim

            'Seta Parametros - Código Produto
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_produto"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Size = 14
            oSqlParameter(7).Value = Mid(sLinha, 38, 14).Trim

            'Seta Parametros - Quantidade
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "quantidade"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Decimal
            oSqlParameter(8).Value = Mid(sLinha, 52, 11).Trim / 1000

            'Seta Parametros - Valor Produto
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "valor_produto"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Decimal
            oSqlParameter(9).Value = CDbl(Mid(sLinha, 63, 12).Trim) / 100

            'Seta Parametros - Valor Desconto
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "valor_desconto"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Decimal
            oSqlParameter(10).Value = CLng(Mid(sLinha, 75, 12).Trim) / 100

            'Seta Parametros - Base de Cálculo do ICMS
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "base_calculo_icms"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Decimal
            oSqlParameter(11).Value = CLng(Mid(sLinha, 87, 12).Trim) / 100

            'Seta Parametros - Base de Cálculo do ICMS ST
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "base_calculo_icms_st"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Decimal
            oSqlParameter(12).Value = CLng(Mid(sLinha, 99, 12).Trim) / 100

            'Seta Parametros - Valor IPI
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "valor_ipi"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Decimal
            oSqlParameter(13).Value = CLng(Mid(sLinha, 111, 12).Trim) / 100

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "aliquota_icms"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.Decimal
            oSqlParameter(14).Value = CLng(Mid(sLinha, 123, 4).Trim) / 100

            'Seta Parametros - Arquivo
            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "arquivo"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.VarChar
            oSqlParameter(15).Size = 255
            oSqlParameter(15).Value = sArquivo

            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "codigo_empresa"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.Int
            oSqlParameter(16).Value = iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_sintegra_registro_54", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRegistro70(ByVal sLinha As String, _
                                ByVal sArquivo As String, _
                                ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oSqlParameter(17) As SqlParameter

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 14
            oSqlParameter(0).Value = Mid(sLinha, 3, 14).Trim

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "inscricao_estadual"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 14
            oSqlParameter(1).Value = Mid(sLinha, 17, 14).Trim

            'Seta Parametros - Data Emissão
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_emissao"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = CDate(Mid(sLinha, 37, 2) & "/" & Mid(sLinha, 35, 2) & "/" & Mid(sLinha, 31, 4))

            'Seta Parametros - UF
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "uf"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 2
            oSqlParameter(3).Value = Mid(sLinha, 39, 2).Trim

            'Seta Parametros - Modelo
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "modelo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = Mid(sLinha, 41, 2).Trim

            'Seta Parametros - Série
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "serie"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 3
            oSqlParameter(5).Value = Mid(sLinha, 43, 3)

            'Seta Parametros - Número
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "numero"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.BigInt
            oSqlParameter(6).Value = Mid(sLinha, 46, 6).Trim

            'Seta Parametros - CFOP
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "cfop"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Size = 4
            oSqlParameter(7).Value = Mid(sLinha, 52, 4).Trim

            'Seta Parametros - Valor Total
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "valor_total"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Decimal
            oSqlParameter(8).Value = CLng(Mid(sLinha, 56, 13).Trim) / 100

            'Seta Parametros - Base de Cálculo do ICMS
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "base_calculo_icms"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Decimal
            oSqlParameter(9).Value = CLng(Mid(sLinha, 69, 14).Trim) / 100

            'Seta Parametros - Valor ICMS
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "valor_icms"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Decimal
            oSqlParameter(10).Value = CLng(Mid(sLinha, 83, 14).Trim) / 100

            'Seta Parametros - Isenta
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "isenta"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Decimal
            oSqlParameter(11).Value = CLng(Mid(sLinha, 97, 14).Trim) / 100

            'Seta Parametros - Outras
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "outras"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Decimal
            oSqlParameter(12).Value = CLng(Mid(sLinha, 111, 14).Trim) / 100

            'Seta Parametros - Alíquota
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "modalidate_frete"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.VarChar
            oSqlParameter(13).Value = Mid(sLinha, 125, 1).Trim

            'Seta Parametros - Situação
            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "situacao"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.VarChar
            oSqlParameter(14).Size = 1
            oSqlParameter(14).Value = Mid(sLinha, 126, 1).Trim

            'Seta Parametros - Arquivo
            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "arquivo"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.VarChar
            oSqlParameter(15).Size = 500
            oSqlParameter(15).Value = sArquivo

            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "codigo_empresa"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.Int
            oSqlParameter(16).Value = iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_sintegra_registro_70", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRegistro74(ByVal sLinha As String, _
                                ByVal sArquivo As String, _
                                ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oSqlParameter(9) As SqlParameter

            'Seta Parametros - Data Inventário
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inventario"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = CDate(Mid(sLinha, 9, 2) & "/" & Mid(sLinha, 7, 2) & "/" & Mid(sLinha, 3, 4))

            'Seta Parametros - Código Produto
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_produto"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 14
            oSqlParameter(1).Value = Mid(sLinha, 11, 14).Trim

            'Seta Parametros - Quantidade
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "quantidade"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Decimal
            oSqlParameter(2).Value = Mid(sLinha, 25, 13).Trim / 1000

            'Seta Parametros - Valor Produto
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "valor_produto"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Decimal
            oSqlParameter(3).Value = CLng(Mid(sLinha, 38, 13).Trim) / 100

            'Seta Parametros - Código de Posse da Mercadoria Inventáriada
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_posse_mercadoria_inventariada"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 1
            oSqlParameter(4).Value = Mid(sLinha, 51, 1).Trim

            'Seta Parametros - CNPJ Proprietario
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "cnpj_proprietario"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 14
            oSqlParameter(5).Value = Mid(sLinha, 52, 14).Trim

            'Seta Parametros - Inscrição Estadual Proprietario
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "inscricao_estadual_proprietario"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Size = 14
            oSqlParameter(6).Value = Mid(sLinha, 66, 14).Trim

            'Seta Parametros - UF Proprietario
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "uf_proprietario"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Size = 2
            oSqlParameter(7).Value = Mid(sLinha, 80, 2).Trim

            'Seta Parametros - Arquivo
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "arquivo"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Size = 255
            oSqlParameter(8).Value = sArquivo

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo_empresa"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Int
            oSqlParameter(9).Value = iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_sintegra_registro_74", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            MsgBox(sLinha)
            Throw ex
        End Try

    End Sub

    Public Sub UpdateInformacao()

        Try


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_informacoes")

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRegistro75(ByVal sLinha As String, _
                                ByVal sArquivo As String, _
                                ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oSqlParameter(9) As SqlParameter

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicial"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = CDate(Mid(sLinha, 9, 2) & "/" & Mid(sLinha, 7, 2) & "/" & Mid(sLinha, 3, 4))

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_final"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = CDate(Mid(sLinha, 17, 2) & "/" & Mid(sLinha, 15, 2) & "/" & Mid(sLinha, 11, 4))

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_produto"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = Mid(sLinha, 19, 14).Trim

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ncm"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = (Mid(sLinha, 33, 8).Trim)

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "descricao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = Mid(sLinha, 41, 53).Trim

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "unidade_medida"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Value = Mid(sLinha, 94, 6).Trim

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "aliquota_ipi"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = CDbl(Mid(sLinha, 100, 5).Trim) / 100

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "aliquota_icms"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Float
            oSqlParameter(7).Value = CDbl(Mid(sLinha, 105, 4).Trim) / 100

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "arquivo"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Size = 255
            oSqlParameter(8).Value = sArquivo

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo_empresa"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Int
            oSqlParameter(9).Value = iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_sintegra_registro_75", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            MsgBox(sLinha)
            Throw ex
        End Try

    End Sub

    Public Sub InsertArquivoImportado(ByVal sArquivo As String, _
                                      ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter

            'Seta Parametros - Data Inventário
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "arquivo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 255
            oSqlParameter(0).Value = sArquivo

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_sintegra_arquivo_importado", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadRegistro50(ByVal oGrid As GridEX, _
                              ByVal sCNPJ As String, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal sCFOP As String, _
                              ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As DataSet
            Dim oSqlParameter(4) As SqlParameter

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 14
            oSqlParameter(0).Value = sCNPJ

            'Seta Parametros - Data Início
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_inicio"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Data Término
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Data Término
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "cfop"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 4
            oSqlParameter(3).Value = sCFOP


            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_empresa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sintegra_registro_50", oSqlParameter)
            
            'Configura DataMember
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

    Public Sub LoadRegistro70(ByVal oGrid As GridEX, _
                              ByVal sCNPJ As String, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal sCFOP As String, _
                              ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As DataSet
            Dim oSqlParameter(4) As SqlParameter

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 14
            oSqlParameter(0).Value = sCNPJ

            'Seta Parametros - Data Início
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_inicio"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Data Término
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Data Término
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "cfop"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 4
            oSqlParameter(3).Value = sCFOP


            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_empresa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sintegra_registro_70", oSqlParameter)

            'Configura DataMember
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

    Public Sub LoadRegistro51(ByVal oGrid As GridEX, _
                              ByVal sCNPJ As String, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal sCFOP As String, _
                              ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As DataSet
            Dim oSqlParameter(4) As SqlParameter

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 14
            oSqlParameter(0).Value = sCNPJ

            'Seta Parametros - Data Início
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_inicio"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Data Término
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Data Término
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "cfop"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 4
            oSqlParameter(3).Value = sCFOP

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_empresa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sintegra_registro_51", oSqlParameter)

            'Configura DataMember
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

    Public Sub LoadRegistro54(ByVal oGrid As GridEX, _
                              ByVal sCNPJ As String, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal sCFOP As String, _
                              ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As DataSet
            Dim oSqlParameter(4) As SqlParameter

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 14
            oSqlParameter(0).Value = sCNPJ

            'Seta Parametros - Data Início
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_inicio"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Data Término
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Data Término
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "cfop"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 4
            oSqlParameter(3).Value = sCFOP

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_empresa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sintegra_registro_54", oSqlParameter)

            'Configura DataMember
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

    Public Sub LoadRegistro74(ByVal oGrid As GridEX, _
                              ByVal sCNPJ As String, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal iEmpresa As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As DataSet
            Dim oSqlParameter(3) As SqlParameter

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 14
            oSqlParameter(0).Value = sCNPJ

            'Seta Parametros - Data Início
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_inicio"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Data Término
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sintegra_registro_74", oSqlParameter)

            'Configura DataMember
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

    Public Sub LoadArquivoImportado(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim oDataSet As DataSet

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sintegra_arquivo_importado")

            'Configura DataMember
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

    Public Sub LimparImportacao()

        Try

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_limpar")



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
