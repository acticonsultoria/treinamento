Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrFinReclassificacaoValor

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigoTituloCapa As Long
    Private iTipoTituloFinanceiro As Integer
    Private dValor As Double
    Private sData As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property TipoTituloFinanceiro() As Integer
        Get
            Return iTipoTituloFinanceiro
        End Get
        Set(ByVal value As Integer)
            iTipoTituloFinanceiro = value
        End Set
    End Property

    Public Property Data() As String
        Get
            Return sData
        End Get
        Set(ByVal value As String)
            sData = value
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

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CAPA :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sSerie As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal sTipo As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal iCodigoTipoDocumento As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter

        Try

            'Seta Parametros - Número Documento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_documento"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Value = sNumeroDocumento

            'Seta Parametros - Série
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "serie"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = sSerie

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "parceiro_negocio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sParceiroNegocio

            'Seta Parametros - Tipo
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "tipo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Char
            oSqlParameter(3).Value = sTipo

            'Seta Parametros - Data Emissão Início
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_emissao_inicio"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.DateTime
            oSqlParameter(4).Value = IIf(sDataEmissaoInicio = "", DBNull.Value, sDataEmissaoInicio)

            'Seta Parametros - Data Emissão Término
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_emissao_termino"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.DateTime
            oSqlParameter(5).Value = IIf(sDataEmissaoTermino = "", DBNull.Value, sDataEmissaoTermino)

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "tipo_documento"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iCodigoTipoDocumento

            'Seta Parametros - Código Empresa
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_empresa"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(7).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_reclassificacao_valor", oSqlParameter)

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

    Public Sub LoadControles(ByVal lCodigoTituloCapa As Long, _
                             ByVal txtNumeroDocumento As MaskedEditBox, _
                             ByVal txtSerie As MaskedEditBox, _
                             ByVal txtDataEmissao As MaskedEditBox, _
                             ByVal txtParceiroNegocio As MaskedEditBox, _
                             ByVal txtTipoDocumento As MaskedEditBox, _
                             ByVal txtTipoTitulo As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_dados_classificacao_valor", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read
                     
                    txtNumeroDocumento.Text = oSqlDataReader.Item("numero_documento")
                    txtSerie.Text = oSqlDataReader.Item("serie")
                    txtDataEmissao.Text = oSqlDataReader.Item("data_emissao")
                    txtParceiroNegocio.Text = oSqlDataReader.Item("parceiro_negocio")
                    txtTipoDocumento.Text = oSqlDataReader.Item("tipo_documento")
                    txtTipoTitulo.Text = IIf(oSqlDataReader.Item("tipo") = "D", "Despesa", "Receita")

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

#End Region

#Region "::: PAGO :::"

    Public Sub LoadGridPago(ByVal oGrid As GridEX, _
                        ByVal lCodigoTituloCapa As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Número Documento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_reclassificacao_valor_pago", oSqlParameter)

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

#Region "::: DEVE :::"

    Public Sub InsertParcela(ByVal lCodigoTituloCapa As Long, _
                             ByVal sDataVencimento As String, _
                             ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Titulo Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_vencimento"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.DateTime
            oSqlParameter(2).Value = sDataVencimento

            'Seta Parametros - Valor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "valor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = dValor

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_classificacao_valor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateParcela(ByVal lCodigoTituloCapa As Long, _
                             ByVal sDataVencimento As String, _
                             ByVal dValor As Double, _
                             ByVal iNumeroParcela As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Código Titulo Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_vencimento"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.DateTime
            oSqlParameter(2).Value = sDataVencimento

            'Seta Parametros - Valor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "valor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = dValor

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "numero_parcela"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iNumeroParcela

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_classificacao_valor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteParcela(ByVal lCodigoTituloCapa As Long, _
                             ByVal iNumeroParcela As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_parcela"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iNumeroParcela

            'Seta Parametros - Código Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_classificacao_valor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDeve(ByVal oGrid As GridEX, _
                            ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_reclassificacao_valor_deve", oSqlParameter)

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

    Public Sub UpdateCapa(ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Titulo Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_total_classificacao_valor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Validacao(ByVal lCodigoTituloCapa As Long, _
                              ByVal iNumeroParcela As Integer, _
                              ByRef sMensagem As String) As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            Validacao = False

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Executa Query
            sMensagem = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_financeiro_titulo_classificacao_valor_parcela", oSqlParameter)

            'Retorno da Função
            Return sMensagem

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PAGO :::"

    Public Sub LoadGridBoleto(ByVal oGrid As GridEX, _
                              ByVal lCodigoTituloCapa As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Número Documento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_reclassificacao_valor_boleto", oSqlParameter)

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

#End Region

End Class
