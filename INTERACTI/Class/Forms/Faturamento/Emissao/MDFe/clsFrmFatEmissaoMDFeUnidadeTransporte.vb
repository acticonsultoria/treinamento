Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsFrmFatEmissaoMDFeUnidadeTransporte

#Region "::: FUNCTION / SUB :::"

    'Public Sub LoadDadosPedidoVenda(ByVal lCodigoPedido As Long, _
    '                                ByVal txtCliente As MaskedEditBox, _
    '                                ByVal txtCNPJCPF As MaskedEditBox)

    '    'Variaveis Locais
    '    Dim oSqlParameter(1) As SqlParameter
    '    Dim oSqlDataReader As SqlDataReader
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Código Pedido de Venda
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = lCodigoPedido : i += 1

    '        'Seta Parametros - Código Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa

    '        'Executa Query
    '        oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_pedido_venda_dados", oSqlParameter)

    '        While oSqlDataReader.Read

    '            'Carrega Controles
    '            txtCliente.Text = oSqlDataReader.Item("razao_social")
    '            txtCliente.Tag = oSqlDataReader.Item("codigo")
    '            txtCNPJCPF.Text = oSqlDataReader.Item("cnpj_cpf")

    '        End While

    '        'Fecha o SqlDataReader
    '        If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Public Sub LoadGridPedidoVenda(ByVal oGrid As GridEX, _
    '                               ByVal iCodigoCliente As Integer, _
    '                               ByVal lNumeroPedido As Long, _
    '                               ByVal iCodigoTipoItem As Integer)

    '    'Variaveis Locais
    '    Dim oSqlParameter(3) As SqlParameter
    '    Dim oDataSet As DataSet
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Código Cliente
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_cliente"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = iCodigoCliente : i += 1

    '        'Seta Parametros - Nº Pedido
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "numero_pedido"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = lNumeroPedido : i += 1

    '        'Seta Parametros - Código Tipo Item
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_tipo_item"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = iCodigoTipoItem : i += 1

    '        'Seta Parametros - Código Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa

    '        'Executa Query
    '        oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_pedido_venda", oSqlParameter)

    '        'Configura DataMember
    '        Call ConfigurarDataMemberGrid(oGrid)

    '        'Carrega Grid
    '        oGrid.DataSource = oDataSet.DefaultViewManager
    '        oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Public Sub LoadGridFatura(ByVal oGrid As GridEX, _
    '                          ByVal lCodigoPedido As Long, _
    '                          ByVal dValor As Double)

    '    'Variaveis Locais
    '    Dim oSqlParameter(2) As SqlParameter
    '    Dim oDataSet As DataSet
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Código Pedido
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_pedido"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = lCodigoPedido : i += 1

    '        'Seta Parametros - Valor
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "valor"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.Float
    '        oSqlParameter(i).Value = dValor : i += 1

    '        'Seta Parametros - Código Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa

    '        'Executa Query
    '        oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfs_pedido_venda_fatura", oSqlParameter)

    '        'Configura DataMember
    '        Call ConfigurarDataMemberGrid(oGrid)

    '        'Carrega Grid
    '        oGrid.DataSource = oDataSet.DefaultViewManager
    '        oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Public Sub LoadGridNotaFiscalDocumentos(ByVal oGrid As GridEX, _
                                            ByVal lCodigoEmissaoCapa As Long, _
                                            ByVal iTipo As Integer, _
                                            ByVal sChaveAcesso As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "tipo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iTipo

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "chave_acesso"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sChaveAcesso

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteUnidadeCarga(ByVal iCodigo As Integer, _
                                  ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDocumentos(ByVal lCodigoEmissaoCapa As Long,
                                ByVal sChaveAcesso As String,
                                ByVal iCodigoTipo As Integer,
                                ByVal iQuantidadeRateada As Integer,
                                ByVal iNumeroLacre As Integer, _
                                ByVal iTipo As Integer, _
                                ByVal sUF As String, _
                                ByVal iCodigoMunicipio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter

        Try
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "chave_acesso"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sChaveAcesso

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_unidade_transporte"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTipo

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "quantidade_rateada"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iQuantidadeRateada

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "numero_lacre"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iNumeroLacre

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "tipo"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iTipo

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "uf"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Value = sUF

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_municipio"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = iCodigoMunicipio

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_unidade_transporte", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDocumentos(ByVal lCodigoEmissaoCapa As Long,
                                ByVal sChaveAcesso As String,
                                ByVal iCodigoTipo As Integer,
                                ByVal iQuantidadeRateada As Integer,
                                ByVal iNumeroLacre As Integer, _
                                ByVal iTipo As Integer, _
                                ByVal iCodigo As Integer, _
                                ByVal sChaveAcessoAntiga As String, _
                                ByVal sUF As String, _
                                ByVal iCodigoMunicipio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "chave_acesso"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sChaveAcesso

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_unidade_transporte"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTipo

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "quantidade_rateada"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iQuantidadeRateada

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "numero_lacre"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iNumeroLacre

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "tipo"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iTipo

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.BigInt
            oSqlParameter(7).Value = iCodigo

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "chave_acesso_antiga"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Value = sChaveAcessoAntiga

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "uf"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.VarChar
            oSqlParameter(9).Value = sUF

            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "codigo_municipio"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Int
            oSqlParameter(10).Value = iCodigoMunicipio

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_unidade_transporte", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
