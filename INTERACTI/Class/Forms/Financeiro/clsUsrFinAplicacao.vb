Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop

Public Class clsUsrFinAplicacao

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private bAtivo As Boolean
    Private iCodigo As Integer
    Private iCodigoBancoConta As Integer
    Private iCodigoAplicacaoSaldo As Integer
    Private dSaldoAtual As Double
    Private dSaldoAnterior As Double
    Private dtData As Date

#End Region

#Region "::: PROPERTIE :::"

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
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

    Public Property CodigoBancoConta() As Integer
        Get
            Return iCodigoBancoConta
        End Get
        Set(ByVal value As Integer)
            iCodigoBancoConta = value
        End Set
    End Property

    Public Property CodigoAplicacaoSaldo() As Integer
        Get
            Return iCodigoAplicacaoSaldo
        End Get
        Set(ByVal value As Integer)
            iCodigoAplicacaoSaldo = value
        End Set
    End Property

    Public Property SaldoAnterior() As Double
        Get
            Return dSaldoAnterior
        End Get
        Set(ByVal value As Double)
            dSaldoAnterior = value
        End Set
    End Property

    Public Property SaldoAtual() As Double
        Get
            Return dSaldoAtual
        End Get
        Set(ByVal value As Double)
            dSaldoAtual = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return dtData
        End Get
        Set(ByVal value As Date)
            dtData = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Safra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_aplicacao_saldo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateConta()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Safra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saldo_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dSaldoAtual : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saldo_anterior"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dSaldoAnterior : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_aplicacao_saldo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAplicacaoSaldo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_aplicacao_saldo_conta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dtData : i += 1
            
            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Safra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_aplicacao_saldo", oSqlParameter)

            iCodigoAplicacaoSaldo = oSqlParameter(i).Value
            
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertConta()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Safra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saldo_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dSaldoAtual : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saldo_anterior"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dSaldoAnterior : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_aplicacao_saldo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAplicacaoSaldo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Safra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_aplicacao_saldo_conta", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
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
                
                'Seta Parametros - Codigo Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_aplicacao_saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_aplicacao_saldo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_aplicacao_saldo", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio) = False, DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino) = False, DBNull.Value, sDataTermino) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_aplicacao_saldo", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_aplicacao_saldo"))

            'Carrega Grid                
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridContaEditar(ByVal oGrid As GridEX, _
                                   ByVal iCodigoAplicacaoSaldo As Integer, _
                                   ByVal iCodigo As Integer, _
                                   ByVal dtData As Date)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros  
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros  
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_aplicacao_saldo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAplicacaoSaldo : i += 1

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_aplicacao_saldo_conta", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub LoadGridConta(ByVal oGrid As GridEX, _
                             ByVal dtData As Date)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_aplicacao_saldo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAplicacaoSaldo : i += 1

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_aplicacao_saldo_conta", oSqlParameter)

            iCodigoAplicacaoSaldo = oSqlParameter(i).Value

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

    Public Sub Pagar(ByVal oGrid As GridEX, _
                     ByVal iCodigoAplicacaoSaldo As Integer, _
                     ByVal dtData As Date)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros  
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros  
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_aplicacao_saldo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAplicacaoSaldo : i += 1

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_aplicacao_saldo_conta_pagar", oSqlParameter)

          

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

#End Region

End Class
