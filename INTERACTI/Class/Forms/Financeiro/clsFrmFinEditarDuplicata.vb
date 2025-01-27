Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO
Imports Janus.Windows.CalendarCombo

Public Class clsFrmFinEditarDuplicata

#Region "::: VARIAVEIS :::"

    Private lCodigoTituloCapa As Long
    Private iNumeroParcela As Integer
    Private dtDataVencimentoParcela As Date
    Private dValorParcela As Double
    Private dValorCorrigidoDocumento As Double

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

    Public Property DataVencimentoParcela() As Date
        Get
            Return dtDataVencimentoParcela
        End Get
        Set(ByVal value As Date)
            dtDataVencimentoParcela = value
        End Set
    End Property

    Public Property ValorParcela() As Double
        Get
            Return dValorParcela
        End Get
        Set(ByVal value As Double)
            dValorParcela = value
        End Set
    End Property

    Public Property ValorCorrigidoDocumento() As Double
        Get
            Return dValorCorrigidoDocumento
        End Get
        Set(ByVal value As Double)
            dValorCorrigidoDocumento = value
        End Set
    End Property
#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadDados(ByVal txtNumeroDocumento As MaskedEditBox, _
                         ByVal txtSerieDocumento As MaskedEditBox, _
                         ByVal txtValorDocumento As NumericEditBox, _
                         ByVal dtpDataVencimento As CalendarCombo, _
                         ByVal txtValorParcela As NumericEditBox)


        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Número Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_editar_parcela", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtNumeroDocumento.Text = oSqlDataReader.Item("numero_documento")
                    txtSerieDocumento.Text = oSqlDataReader.Item("serie_documento")
                    txtValorDocumento.Text = oSqlDataReader.Item("valor_documento")
                    dtpDataVencimento.Text = oSqlDataReader.Item("data_vencimento_parcela")
                    txtValorParcela.Tag = oSqlDataReader.Item("valor_parcela")
                    txtValorParcela.Text = oSqlDataReader.Item("valor_parcela")

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Número Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Data Vencimento Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dtDataVencimentoParcela : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Documento Corrigido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_documento_corrigido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCorrigidoDocumento : i += 1

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
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_editar_parcela", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
