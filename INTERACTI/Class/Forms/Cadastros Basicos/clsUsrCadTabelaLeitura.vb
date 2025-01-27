Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCadTabelaLeitura

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sRevisao As String
    Private sDescricao As String
    Private bAtivo As Boolean
    Private iCodigo As Integer
    Private dValorAte10Agua As Double
    Private dValorAte20Agua As Double
    Private dValorAte50Agua As Double
    Private dValorAcima50Agua As Double
    Private dRateioAgua As Double
    Private dTaxaAnaliseAgua As Double
    Private dValorAte10Esgoto As Double
    Private dValorAte20Esgoto As Double
    Private dValorAte50Esgoto As Double
    Private dValorAcima50Esgoto As Double

#End Region

#Region "::: PROPERTIE :::"

    Public Property Revisao() As String
        Get
            Return sRevisao
        End Get
        Set(ByVal value As String)
            sRevisao = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

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

    Public Property ValorAte10Agua() As Double
        Get
            Return dValorAte10Agua
        End Get
        Set(ByVal value As Double)
            dValorAte10Agua = value
        End Set
    End Property

    Public Property ValorAte20Agua() As Double
        Get
            Return dValorAte20Agua
        End Get
        Set(ByVal value As Double)
            dValorAte20Agua = value
        End Set
    End Property

    Public Property ValorAte50Agua() As Double
        Get
            Return dValorAte50Agua
        End Get
        Set(ByVal value As Double)
            dValorAte50Agua = value
        End Set
    End Property

    Public Property ValorAcima50Agua() As Double
        Get
            Return dValorAcima50Agua
        End Get
        Set(ByVal value As Double)
            dValorAcima50Agua = value
        End Set
    End Property

    Public Property RateioAgua() As Double
        Get
            Return dRateioAgua
        End Get
        Set(ByVal value As Double)
            dRateioAgua = value
        End Set
    End Property

    Public Property TaxaAnaliseAgua() As Double
        Get
            Return dTaxaAnaliseAgua
        End Get
        Set(ByVal value As Double)
            dTaxaAnaliseAgua = value
        End Set
    End Property

    Public Property ValorAte10Esgoto() As Double
        Get
            Return dValorAte10Esgoto
        End Get
        Set(ByVal value As Double)
            dValorAte10Esgoto = value
        End Set
    End Property

    Public Property ValorAte20Esgoto() As Double
        Get
            Return dValorAte20Esgoto
        End Get
        Set(ByVal value As Double)
            dValorAte20Esgoto = value
        End Set
    End Property

    Public Property ValorAte50Esgoto() As Double
        Get
            Return dValorAte50Esgoto
        End Get
        Set(ByVal value As Double)
            dValorAte50Esgoto = value
        End Set
    End Property

    Public Property ValorAcima50Esgoto() As Double
        Get
            Return dValorAcima50Esgoto
        End Get
        Set(ByVal value As Double)
            dValorAcima50Esgoto = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Revisao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Valor até 10 - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10Agua : i += 1

            'Seta Parametros - Valor até 20 - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20Agua : i += 1

            'Seta Parametros - Valor até 50 - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50Agua : i += 1

            'Seta Parametros - Valor Acima  50 - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50Agua : i += 1

            'Seta Parametros - Rateio - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRateioAgua : i += 1

            'Seta Parametros - Taxa Análise - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_analise_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaAnaliseAgua : i += 1

            'Seta Parametros - Valor até 10 - Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10Esgoto : i += 1

            'Seta Parametros - Valor até 10 - Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20Esgoto : i += 1

            'Seta Parametros - Valor até 10 - Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50Esgoto : i += 1

            'Seta Parametros - Valor Acima 50 - Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50Esgoto : i += 1

            'Seta Parametros - Codigo Usuário
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_tabela_leitura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Valor até 10 - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10Agua : i += 1

            'Seta Parametros - Valor até 20 - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20Agua : i += 1

            'Seta Parametros - Valor até 50 - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50Agua : i += 1

            'Seta Parametros - Valor Acima  50 - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50Agua : i += 1

            'Seta Parametros - Rateio - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRateioAgua : i += 1

            'Seta Parametros - Taxa Análise - Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_analise_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaAnaliseAgua : i += 1

            'Seta Parametros - Valor até 10 - Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10Esgoto : i += 1

            'Seta Parametros - Valor até 10 - Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20Esgoto : i += 1

            'Seta Parametros - Valor até 10 - Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50Esgoto : i += 1

            'Seta Parametros - Valor Acima 50 - Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50Esgoto : i += 1

            'Seta Parametros - Codigo Usuário
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_tabela_leitura", oSqlParameter)

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
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_tabela_leitura", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Editar(ByVal lCodigoRecibo As Long, _
                      ByVal txtAte10Agua As NumericEditBox, _
                      ByVal txtAte20Agua As NumericEditBox, _
                      ByVal txtAte50Agua As NumericEditBox, _
                      ByVal txtAcima50Agua As NumericEditBox, _
                      ByVal txtRateioAgua As NumericEditBox, _
                      ByVal txtTaxaAnaliseAgua As NumericEditBox, _
                      ByVal txtAte10Esgoto As NumericEditBox, _
                      ByVal txtAte20Esgoto As NumericEditBox, _
                      ByVal txtAte50Esgoto As NumericEditBox, _
                      ByVal txtAcima50Esgoto As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_tabela_leitura_editar", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtAte10Agua.Value = oSqlDataReader.Item("valor_ate_10_agua")
                txtAte20Agua.Value = oSqlDataReader.Item("valor_ate_20_agua")
                txtAte50Agua.Value = oSqlDataReader.Item("valor_ate_50_agua")
                txtAcima50Agua.Value = oSqlDataReader.Item("valor_acima_50_agua")
                txtRateioAgua.Value = oSqlDataReader.Item("rateio_agua")
                txtTaxaAnaliseAgua.Value = oSqlDataReader.Item("taxa_analise_agua")
                txtAte10Esgoto.Value = oSqlDataReader.Item("valor_ate_10_esgoto")
                txtAte20Esgoto.Value = oSqlDataReader.Item("valor_ate_20_esgoto")
                txtAte50Esgoto.Value = oSqlDataReader.Item("valor_ate_50_esgoto")
                txtAcima50Esgoto.Value = oSqlDataReader.Item("valor_acima_50_esgoto")
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
                        ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_tabela_leitura", oSqlParameter)

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
