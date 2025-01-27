Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCstControle

    Private sAssunto As String
    Private sCabecalho As String
    Private sDestinatario As String

    Public Property Assunto() As String
        Get
            Return sAssunto
        End Get
        Set(ByVal value As String)
            sAssunto = value
        End Set
    End Property

    Public Property Cabecalho() As String
        Get
            Return sCabecalho
        End Get
        Set(ByVal value As String)
            sCabecalho = value
        End Set
    End Property

    Public Property Destinatario() As String
        Get
            Return sDestinatario
        End Get
        Set(ByVal value As String)
            sDestinatario = value
        End Set
    End Property

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_controle", oSqlParameter)

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

    Public Sub LoadDadosCenario(ByVal oGridEstoque As GridEX, _
                                ByVal oGridMovimentacao As GridEX, _
                                ByVal lCodigo As Long, _
                                ByVal bExibir As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "exibir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bExibir : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_controle_dados", oSqlParameter)


            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGridMovimentacao)
            oGridMovimentacao.DataSource = oDataSet.DefaultViewManager
            oGridMovimentacao.DataMember = oDataSet.Tables(0).TableName

            If bExibir = True Then

                Call ConfigurarDataMemberGrid(oGridEstoque)
                oGridEstoque.DataSource = oDataSet.DefaultViewManager
                oGridEstoque.DataMember = oDataSet.Tables(1).TableName

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDataMovimentacao(ByVal lCodigoMovimentacao As Long, _
                                      ByVal sDataMovimentacao As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_movimentacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoMovimentacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_movimentacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataMovimentacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_custeio_controle_estoque_data_movimentacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateEstoqueObservacao(ByVal lCodigoMovimentacao As Long, _
                                       ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_movimentacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoMovimentacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_custeio_controle_estoque_observacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadEmail(ByVal dEstoqueMP As Double, _
                         ByVal dEstoqueElaboracao As Double, _
                         ByVal dEstoqueAcabado As Double, _
                         ByVal sData As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "assunto"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cabecalho"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "destinatario"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_mp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dEstoqueMP : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_elaboracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dEstoqueElaboracao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_acabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dEstoqueAcabado : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sData

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_email_custeio_controle_relatorio", oSqlParameter)

            sAssunto = oSqlParameter(0).Value
            sCabecalho = oSqlParameter(1).Value
            sDestinatario = oSqlParameter(2).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class



