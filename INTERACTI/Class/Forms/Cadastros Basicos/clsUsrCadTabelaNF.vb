Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrCadTabelaNF

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNFInicial As String
    Private sNFFinal As String
    Private sTabela As String
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"
    Public Property NFInicial() As String
        Get
            Return sNFInicial
        End Get
        Set(ByVal value As String)
            sNFInicial = value
        End Set
    End Property
    Public Property NFFinal() As String
        Get
            Return sNFFinal
        End Get
        Set(ByVal value As String)
            sNFFinal = value
        End Set
    End Property
    Public Property Tabela() As String
        Get
            Return sTabela
        End Get
        Set(ByVal value As String)
            sTabela = value
        End Set
    End Property
    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property
#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert(ByVal sNFInicial As String, _
                      ByVal sNFFinal As String, _
                      ByVal sTabela As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nf_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNFInicial : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nf_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNFFinal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_tabela_nota_fiscal", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal sNFInicial As String, _
                      ByVal sNFFinal As String, _
                      ByVal sTabela As String, _
                      ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try


           'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nf_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNFInicial : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nf_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNFFinal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_tabela_nota_fiscal", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_tabela_nota_fiscal", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNF As String, _
                        ByVal sTabela As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNF : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTabela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_tabela_nota_fiscal", oSqlParameter)

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

  

#End Region

End Class
