Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports INTERACTI.SQLHelper
Imports System.IO
Imports System.Drawing.Imaging
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCadVeiculoMDFe

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigoVeiculo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoVeiculo() As Integer
        Get
            Return iCodigoVeiculo
        End Get
        Set(ByVal value As Integer)
            iCodigoVeiculo = value
        End Set
    End Property
     
#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: VEÍCULO :::"

    Public Sub Insert(ByVal iCodigoTipoCarroceria As Integer, _
                      ByVal sUF As String, _
                      ByVal iRntrc As Integer, _
                      ByVal sPlaca As String, _
                      ByVal iRenavam As Integer, _
                      ByVal bAtivo As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Carroceria
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_carroceria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoCarroceria : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - RNTRC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntrc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRntrc : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 7
            oSqlParameter(i).Value = sPlaca : i += 1

            'Seta Parametros - Renavam
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "renavam"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRenavam : i += 1

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

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_veiculo_mdfe", oSqlParameter)

            'Seta Parâmetro
            iCodigoVeiculo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal iCodigoTipoCarroceria As Integer, _
                      ByVal sUF As String, _
                      ByVal iRntrc As Integer, _
                      ByVal sPlaca As String, _
                      ByVal iRenavam As Integer, _
                      ByVal bAtivo As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Carroceria
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_carroceria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoCarroceria : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - RNTRC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntrc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRntrc : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 7
            oSqlParameter(i).Value = sPlaca : i += 1

            'Seta Parametros - Renavam
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "renavam"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRenavam : i += 1

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

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoVeiculo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_veiculo_mdfe", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim j, i As Integer

        Try

            For j = 0 To UBound(gSelecaoRow)

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = gSelecaoRow(j).Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_veiculo_mdfe", oSqlParameter)

                'Deleta Linha
                gSelecaoRow(j).Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal iCodigo As Integer, _
                         ByVal txtRenavam As NumericEditBox, _
                         ByVal txtRntrc As NumericEditBox, _
                         ByVal cboUF As UIComboBox, _
                         ByVal cboTipoCarroceria As UIComboBox, _
                         ByVal txtPlaca As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_veiculo_mdfe", oSqlParameter)

            While oSqlDataReader.Read

                'Preenche Controles
                cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboTipoCarroceria.SelectedValue = oSqlDataReader.Item("codigo_tipo_carroceria")
                txtPlaca.Text = oSqlDataReader.Item("placa")
                txtRenavam.Value = oSqlDataReader.Item("renavam")
                txtRntrc.Value = oSqlDataReader.Item("rntrc")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoTipoCarroceria As Integer, _
                        ByVal sUF As String, _
                        ByVal iRntrc As Integer, _
                        ByVal sPlaca As String, _
                        ByVal iRenavam As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim i As Integer = 0
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros - Código Tipo Carroceria
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_carroceria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoCarroceria : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - RNTRC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntrc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRntrc : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 7
            oSqlParameter(i).Value = IIf(sPlaca = "", DBNull.Value, sPlaca) : i += 1

            'Seta Parametros - Renavam
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "renavam"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRenavam : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_veiculo_mdfe", oSqlParameter)

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

    Public Function ValidaRenavam(ByVal lCodigo As Long, _
                                  ByVal iRenavam As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaRenavam = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Renavam
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "renavam"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRenavam : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_veiculo_mdfe", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaRenavam = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
