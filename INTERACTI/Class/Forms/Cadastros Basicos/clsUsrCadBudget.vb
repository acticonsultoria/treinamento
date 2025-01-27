Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCadBudget

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sCodigoContaContabil As String
    Private sDataCompetencia As String
    Private sDataFinanceiro As String
    Private dValor As Double
    Private bAtivo As Boolean
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoContaContabil() As String
        Get
            Return sCodigoContaContabil
        End Get
        Set(ByVal value As String)
            sCodigoContaContabil = value
        End Set
    End Property

    Public Property DataCompetencia() As String
        Get
            Return sDataCompetencia
        End Get
        Set(ByVal value As String)
            sDataCompetencia = value
        End Set
    End Property

    Public Property DataFinanceiro() As String
        Get
            Return sDataFinanceiro
        End Get
        Set(ByVal value As String)
            sDataFinanceiro = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return dValor
        End Get
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bativo = value
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

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_conta_contabil"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Value = sCodigoContaContabil

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_competencia"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = New Date(Year(CDate(sDataCompetencia)), Month(CDate(sDataCompetencia)), 1)

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_financeiro"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = New Date(Year(CDate(sDataFinanceiro)), Month(CDate(sDataFinanceiro)), 1)

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "valor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = dValor

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "ativo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Bit
            oSqlParameter(4).Value = bAtivo

            'Seta Parametros 
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_empresa"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(5).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_budget", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPlanilha(ByVal sCodigoContaContabil As String, _
                              ByVal sDataCompetencia As Date, _
                              ByVal sDataFinanceiro As Date, _
                              ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_conta_contabil"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Value = sCodigoContaContabil

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_competencia"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = sDataCompetencia

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_financeiro"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = sDataFinanceiro

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "valor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = dValor

       
            'Seta Parametros 
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_empresa"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(5).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_budget_planilha", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        Dim oSqlParameter(6) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_conta_contabil"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Value = sCodigoContaContabil

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_competencia"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = New Date(Year(CDate(sDataCompetencia)), Month(CDate(sDataCompetencia)), 1)

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_financeiro"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = New Date(Year(CDate(sDataFinanceiro)), Month(CDate(sDataFinanceiro)), 1)

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "valor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = dValor

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "ativo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Bit
            oSqlParameter(4).Value = bAtivo

            'Seta Parametros 
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_empresa"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(5).Value = goUsuario.iEmpresa

            'Seta Parametros
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(6).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_budget", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = oRow.Cells.Item("codigo").Value

                'Seta Parametros - Codigo Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_budget", oSqlParameter)

                'Deleta Linha
                oRow.Delete()
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Editar(ByVal iCodigo As Integer, _
                      ByVal cboContaContabil As UIComboBox, _
                      ByVal txtValor As NumericEditBox, _
                      ByVal dtpDataCompetencia As CalendarCombo, _
                      ByVal dtpDataFinanceiro As CalendarCombo, _
                      ByVal cboAtivo As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros - Codigo Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_budget_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                cboContaContabil.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil")
                txtValor.Value = oSqlDataReader.Item("valor")
                dtpDataCompetencia.Value = oSqlDataReader.Item("data_competencia")
                dtpDataFinanceiro.Value = oSqlDataReader.Item("data_financeiro")
                cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaDataCompetencia(ByVal iCodigo As Integer, _
                               ByVal sCodigoContaContabil As String, _
                               ByVal sDataCompetencia As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_conta_contabil"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = sCodigoContaContabil

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_competencia"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sDataCompetencia

            'Seta Parametros
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_budget", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sCodigoContaContabil As String, _
                        ByVal sDataInicioCompetencia As String, _
                        ByVal sDataTerminoCompetencia As String, _
                        ByVal sDataInicioFinanceiro As String, _
                        ByVal sDataTerminoFinanceiro As String, _
                        ByVal bAtivo As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        
        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_conta_contabil"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Value = sCodigoContaContabil

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "ativo"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Bit
            oSqlParameter(1).Value = IIf(bAtivo = -1, DBNull.Value, bAtivo)

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_inicio_competencia"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            If (sDataInicioCompetencia = "") Then
                oSqlParameter(2).Value = DBNull.Value
            Else
                oSqlParameter(2).Value = New Date(Year(CDate(sDataInicioCompetencia)), Month(CDate(sDataInicioCompetencia)), 1)
            End If

            'Seta Parametros
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "data_termino_competencia"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Date
            If (sDataTerminoCompetencia = "") Then
                oSqlParameter(3).Value = DBNull.Value
            Else
                oSqlParameter(3).Value = New Date(Year(CDate(sDataTerminoCompetencia)), Month(CDate(sDataTerminoCompetencia)), 1)
            End If

            'Seta Parametros
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_inicio_financeiro"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Date
            If (sDataInicioFinanceiro = "") Then
                oSqlParameter(4).Value = DBNull.Value
            Else
                oSqlParameter(4).Value = New Date(Year(CDate(sDataInicioFinanceiro)), Month(CDate(sDataInicioFinanceiro)), 1)
            End If

            'Seta Parametros
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_termino_financeiro"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Date
            If (sDataTerminoFinanceiro = "") Then
                oSqlParameter(5).Value = DBNull.Value
            Else
                oSqlParameter(5).Value = New Date(Year(CDate(sDataTerminoFinanceiro)), Month(CDate(sDataTerminoFinanceiro)), 1)
            End If

            'Seta Parametros - Código Empresa
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_empresa"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(6).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_budget", oSqlParameter)

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
