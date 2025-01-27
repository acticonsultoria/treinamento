Imports Newtonsoft.Json
Imports System.Net
Imports System.Runtime.Serialization.Json
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class DFE

    Public Sub AtualizarImportacao()

      
        Try
            'Primeiro atualiza o evento
            Dim oClient As New WebClient
            Dim sResponse As String

            'Verifica o último nsu
            Dim sUltimoNSU As String = LoadUltimoNSU()

            'Monta a URL com o endereço + cnpj + nsu
            Dim sUrl As String = LoadEnderecoApiDestinada()
            sUrl += goUsuario.sCNPJEmpresa.Replace(",", "").Replace(".", "").Replace("/", "").Replace("-", "")
            sUrl += sUltimoNSU

            'Seta o protocolo
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            'Faz o request
            oClient.Encoding = System.Text.Encoding.UTF8

            oClient.Headers.Add("content-type", "application/json")
            sResponse = oClient.DownloadString(sUrl)


            Dim oJSON = JsonConvert.DeserializeObject(Of DFE_EVENTO.JSON_DFE_EVENTO.Root)(sResponse)
            Dim sNSUAtual As String = ""

            For Each oData In oJSON.data

                'Escreve para depois atualizar
                sNSUAtual = oData.nsu

                'Variaveis Locais
                Dim oSqlParameter(15) As SqlParameter
                Dim i As Integer = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "chave_acesso"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oData.chave_acesso : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nsu"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oData.nsu : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "cnpj"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oData.cnpj : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo_evento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oData.tipo_evento : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "evento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oData.evento : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "sequencia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oData.sequencia : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_emissao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oData.data_emissao : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "correcao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oData.correcao : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oData.valor : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "razao_social"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oData.razao_social : i += 1


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oData.codigo_tipo_nota_fiscal : i += 1


                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nota_destinada_integracao", oSqlParameter)


            Next

            'Escreve o ultimo NSU
            UpdateConfiguracaoNSU(sUltimoNSU, sNSUAtual, "OK")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
