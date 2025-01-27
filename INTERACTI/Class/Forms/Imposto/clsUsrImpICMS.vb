Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrImpICMS

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCFOP As Integer
    Private sCST As String
    Private sFormulaICMS As String
    Private sFormulaICMSST As String
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CFOP() As Integer
        Get
            Return iCFOP
        End Get
        Set(ByVal value As Integer)
            iCFOP = value
        End Set
    End Property

    Public Property CST() As String
        Get
            Return sCST
        End Get
        Set(ByVal value As String)
            sCST = value
        End Set
    End Property

    Public Property FormulaICMS() As String
        Get
            Return sFormulaICMS
        End Get
        Set(ByVal value As String)
            sFormulaICMS = value
        End Set
    End Property

    Public Property FormulaICMSST() As String
        Get
            Return sFormulaICMSST
        End Get
        Set(ByVal value As String)
            sFormulaICMSST = value
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
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Codigo CFOP
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_cfop"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCFOP

            'Seta Parametros - Código Situação Tributária ICMS
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 3
            oSqlParameter(2).Value = sCST

            'Seta Parametros - Fórmula ICMS
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "formula_icms"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 500
            oSqlParameter(3).Value = IIf(sFormulaICMS = "", DBNull.Value, sFormulaICMS)

            'Seta Parametros - Fórmula ICMS ST
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "formula_icms_st"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 500
            oSqlParameter(4).Value = IIf(sFormulaICMSST = "", DBNull.Value, sFormulaICMSST)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_imposto_icms", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros - Codigo CFOP
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cfop"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCFOP

            'Seta Parametros - Código Situação Tributária ICMS
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 3
            oSqlParameter(1).Value = sCST

            'Seta Parametros - Fórmula ICMS
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "formula_icms"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 500
            oSqlParameter(2).Value = IIf(sFormulaICMS = "", DBNull.Value, sFormulaICMS)

            'Seta Parametros - Fórmula ICMS ST
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "formula_icms_st"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 500
            oSqlParameter(3).Value = IIf(sFormulaICMSST = "", DBNull.Value, sFormulaICMSST)

            'Seta Parametros - Código
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_empresa"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(5).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_imposto_icms", oSqlParameter)

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

            For i = 0 To UBound(gSelecaoRow)

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.Int
                oSqlParameter(0).Value = gSelecaoRow(i).Cells("codigo").Value

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Deleta Linha
                gSelecaoRow(i).Delete()

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_imposto_icms", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCFOP As Integer, _
                        ByVal sCST As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código CFOP
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cfop"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCFOP

            'Seta Parametros - Código CST
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 2
            oSqlParameter(1).Value = sCST

            'Seta Parametros - Código Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_imposto_icms", oSqlParameter)
            
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

    Public Sub LoadControles(ByVal iCodigo As Integer, _
                             ByVal cboCFOP As UIComboBox, _
                             ByVal cboCST As UIComboBox, _
                             ByVal txtFormula As MaskedEditBox, _
                             ByVal txtFormulaST As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_imposto_dados_icms", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Controles
                    cboCFOP.SelectedValue = oSqlDataReader.Item("codigo_cfop")
                    cboCFOP.Tag = iCodigo
                    cboCST.SelectedValue = oSqlDataReader.Item("situacao_tributaria_icms")
                    txtFormula.Text = oSqlDataReader.Item("formula_icms")
                    txtFormulaST.Text = oSqlDataReader.Item("formula_icms_st")

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

    Public Function ValidaCFOPCST(ByVal iCFOP As Integer, _
                                  ByVal sCST As String, _
                                  ByVal iCOdigo As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaCFOPCST = False

            'Seta Parametros - Codigo
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cfop"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCFOP

            'Seta Parametros - Código CST
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 3
            oSqlParameter(1).Value = sCST

            'Seta Parametros - Codigo
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCOdigo

            'Seta Parametros - Codigo Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_imposto_icms", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCFOPCST = IIf(iReturn = 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
