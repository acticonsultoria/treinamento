Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.EditControls
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrVenContrato

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sDescricao As String
    Private bAtivo As Boolean
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

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

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CONTRATO :::"
    Public Sub Insert(ByVal sNumeroContrato As String, _
                      ByVal iCodigoCliente As Integer, _
                      ByVal iCodigoTipoSocietario As Integer, _
                      ByVal sDataFundacao As String, _
                      ByVal iPrazoBalancoEspecial As Integer, _
                      ByVal iPrazoPgtoMorte As Integer, _
                      ByVal iPrazoDissolucao As Integer, _
                      ByVal sDataImpressao As String, _
                      ByVal sNomeAdvogado As String, _
                      ByVal sNumeroOAB As String, _
                      ByVal sNomeTestemunha1 As String, _
                      ByVal sRGTestemunha1 As String, _
                      ByVal sNomeTestemunha2 As String, _
                      ByVal sRGTestemunha2 As String, _
                      ByVal sDataAssinatura As String, _
                      ByVal sUFForo As String, _
                      ByVal iCodigoMunicipioForo As Integer, _
                      ByVal dCapitalSocial As Double, _
                      ByVal iNumeroQuotas As Integer, _
                      ByVal dValorQuota As Double, _
                      ByVal iCodigoHandout As Integer)

        'Variaveis Locais
        Dim oSqlParameter(60) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_societario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoSocietario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fundacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataFundacao = "", DBNull.Value, sDataFundacao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prazo_balanco_especial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPrazoBalancoEspecial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prazo_pgto_morte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPrazoPgtoMorte : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prazo_dissolucao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPrazoDissolucao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_impressao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataImpressao = "", DBNull.Value, sDataImpressao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_advogado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeAdvogado : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_oab"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroOAB : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_testemunha1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeTestemunha1 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg_testemunha1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRGTestemunha1 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_testemunha2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeTestemunha2 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg_testemunha2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRGTestemunha2 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_assinatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAssinatura = "", DBNull.Value, sDataAssinatura) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_foro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUFForo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio_foro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipioForo = -1, DBNull.Value, iCodigoMunicipioForo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "capital_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCapitalSocial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_quotas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroQuotas : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_quota"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorQuota : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_handout"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoHandout : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_contrato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal sNumeroContrato As String, _
                      ByVal iCodigoCliente As Integer, _
                      ByVal iCodigoTipoSocietario As Integer, _
                      ByVal sDataFundacao As String, _
                      ByVal iPrazoBalancoEspecial As Integer, _
                      ByVal iPrazoPgtoMorte As Integer, _
                      ByVal iPrazoDissolucao As Integer, _
                      ByVal sDataImpressao As String, _
                      ByVal sNomeAdvogado As String, _
                      ByVal sNumeroOAB As String, _
                      ByVal sNomeTestemunha1 As String, _
                      ByVal sRGTestemunha1 As String, _
                      ByVal sNomeTestemunha2 As String, _
                      ByVal sRGTestemunha2 As String, _
                      ByVal sDataAssinatura As String, _
                      ByVal sUFForo As String, _
                      ByVal iCodigoMunicipioForo As Integer, _
                      ByVal dCapitalSocial As Double, _
                      ByVal iNumeroQuotas As Integer, _
                      ByVal dValorQuota As Double, _
                      ByVal iCodigoHandout As Integer, _
                      ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(60) As SqlParameter
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
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_societario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoSocietario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fundacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataFundacao = "", DBNull.Value, sDataFundacao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prazo_balanco_especial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPrazoBalancoEspecial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prazo_pgto_morte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPrazoPgtoMorte : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prazo_dissolucao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPrazoDissolucao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_impressao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataImpressao = "", DBNull.Value, sDataImpressao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_advogado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeAdvogado : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_oab"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroOAB : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_testemunha1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeTestemunha1 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg_testemunha1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRGTestemunha1 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_testemunha2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeTestemunha2 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg_testemunha2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRGTestemunha2 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_assinatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAssinatura = "", DBNull.Value, sDataAssinatura) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_foro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUFForo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio_foro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipioForo = -1, DBNull.Value, iCodigoMunicipioForo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "capital_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCapitalSocial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_quotas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroQuotas : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_quota"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorQuota : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_handout"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoHandout : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_contrato", oSqlParameter)

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_contrato", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateSocios(ByVal iCodigo As Integer, _
                      ByVal iCodigoParceiroNegocio As Integer, _
                      ByVal iQuantidadeQuotas As Integer, _
                      ByVal dValorQuota As Double, _
                      ByVal dPorcentagem As Double)

        'Variaveis Locais
        Dim oSqlParameter(60) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_quotas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iQuantidadeQuotas : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_quota"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorQuota : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPorcentagem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_socios_contrato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroContrato As String, _
                        ByVal iCodigoCliente As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCliente = -1, DBNull.Value, iCodigoCliente) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_contrato", oSqlParameter)

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

    Public Sub LoadGridSocios(ByVal oGrid As GridEX, _
                              ByVal iCodigoCliente As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_socios", oSqlParameter)

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


    Public Sub IntegracaoHandout(ByVal iCodigoHandout As Integer, _
                               ByVal iCodigoContrato As Integer)
        Try
            Dim oSqlParameter(4) As SqlParameter
            Dim i As Integer = 0

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_handout"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoHandout : i += 1


            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_contrato_clausula", oSqlParameter)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LoadDadosContratoAbertura(ByVal lCodigo As Long, _
                                         ByRef sRazaoSocial As String, _
                                          ByRef sTextoSocios1 As String, _
                                          ByRef sTextoSocios2 As String, _
                                          ByRef sTextoSocios3 As String, _
                                          ByRef sTextoSocios4 As String, _
                                          ByRef sTextoSocios5 As String, _
                                          ByRef sTextoSocios6 As String, _
                                          ByRef sTipoSocietario As String, _
                                          ByRef sEnderecoCliente As String, _
                                          ByRef sBairroCliente As String, _
                                          ByRef sCidadeCliente As String, _
                                          ByRef sUFCliente As String, _
                                          ByRef sCEPCliente As String, _
                                          ByRef sNumeroFiliais As String, _
                                          ByRef sNumeroFiliaisExtenso As String, _
                                          ByRef sTextoFiliais As String, _
                                          ByRef sTextoCNAE As String, _
                                          ByRef sDataRegistro As String, _
                                          ByRef dCapitalSocial As Double, _
                                          ByRef sCapitalSocialExtenso As String, _
                                          ByRef dValorQuota As Double, _
                                          ByRef sValorQuotaExtenso As String, _
                                          ByRef sNumeroQuotas As String, _
                                          ByRef sNumeroQuotasExtenso As String, _
                                          ByRef sNomeSocio1 As String, _
                                          ByRef sNomeSocio2 As String, _
                                          ByRef sNomeSocio3 As String, _
                                          ByRef sNomeSocio4 As String, _
                                          ByRef sNomeSocio5 As String, _
                                          ByRef sNomeSocio6 As String, _
                                          ByRef sNomeSocio7 As String, _
                                          ByRef dQtdQuotas1 As Double, _
                                          ByRef dQtdQuotas2 As Double, _
                                          ByRef dQtdQuotas3 As Double, _
                                          ByRef dQtdQuotas4 As Double, _
                                          ByRef dQtdQuotas5 As Double, _
                                          ByRef dQtdQuotas6 As Double, _
                                          ByRef dQtdQuotas7 As Double, _
                                          ByRef dValorQuota1 As Double, _
                                          ByRef dValorQuota2 As Double, _
                                          ByRef dValorQuota3 As Double, _
                                          ByRef dValorQuota4 As Double, _
                                          ByRef dValorQuota5 As Double, _
                                          ByRef dValorQuota6 As Double, _
                                          ByRef dValorQuota7 As Double, _
                                          ByRef dPorcentagem1 As Double, _
                                          ByRef dPorcentagem2 As Double, _
                                          ByRef dPorcentagem3 As Double, _
                                          ByRef dPorcentagem4 As Double, _
                                          ByRef dPorcentagem5 As Double, _
                                          ByRef dPorcentagem6 As Double, _
                                          ByRef dPorcentagem7 As Double, _
                                          ByRef dTotalQuota As Double, _
                                          ByRef dValorTotalQuota As Double, _
                                          ByRef sSociosAdministradores As String, _
                                          ByRef sPrazoBalancoEspecial As String, _
                                          ByRef sPrazoBalancoEspecialExtenso As String, _
                                          ByRef sPrazoPgtoMorte As String, _
                                          ByRef sPrazoPgtoMorteExtenso As String, _
                                          ByRef sPrazoDissolucao As String, _
                                          ByRef sPrazoDissolucaoExtenso As String, _
                                          ByRef sCidadeForo As String, _
                                          ByRef sEstadoForo As String, _
                                          ByRef sDataImpressao As String, _
                                          ByRef sQualificacao1 As String, _
                                          ByRef sQualificacao2 As String, _
                                          ByRef sQualificacao3 As String, _
                                          ByRef sQualificacao4 As String, _
                                          ByRef sQualificacao5 As String, _
                                          ByRef sQualificacao6 As String, _
                                          ByRef sNomeTestemunha1 As String, _
                                          ByRef sNomeTestemunha2 As String, _
                                          ByRef sRGTestemunha1 As String, _
                                          ByRef sRGTestemunha2 As String, _
                                          ByRef sNomeAdvogado As String, _
                                          ByRef sNumeroOAB As String, _
                                          ByRef sDataAssinatura As String)

        'Váriaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_contrato_abertura", oSqlParameter)

            While oSqlDataReader.Read

                'Seta Váriaveis
                sRazaoSocial = oSqlDataReader.Item("razao_social")
                sTextoSocios1 = oSqlDataReader.Item("texto_socios1")
                sTextoSocios2 = oSqlDataReader.Item("texto_socios2")
                sTextoSocios3 = oSqlDataReader.Item("texto_socios3")
                sTextoSocios4 = oSqlDataReader.Item("texto_socios4")
                sTextoSocios5 = oSqlDataReader.Item("texto_socios5")
                sTextoSocios6 = oSqlDataReader.Item("texto_socios6")
                sTipoSocietario = oSqlDataReader.Item("tipo_societario")
                sEnderecoCliente = oSqlDataReader.Item("endereco_cliente")
                sBairroCliente = oSqlDataReader.Item("bairro_cliente")
                sCidadeCliente = oSqlDataReader.Item("cidade_cliente")
                sUFCliente = oSqlDataReader.Item("uf_cliente")
                sCEPCliente = oSqlDataReader.Item("cep_cliente")
                sNumeroFiliais = oSqlDataReader.Item("numero_filiais")
                sNumeroFiliaisExtenso = oSqlDataReader.Item("numero_filiais_extenso")
                sTextoFiliais = oSqlDataReader.Item("texto_filiais")
                sTextoCNAE = oSqlDataReader.Item("texto_cnae")
                sDataRegistro = oSqlDataReader.Item("data_registro")
                sCapitalSocialExtenso = oSqlDataReader.Item("capital_social_extenso")
                dCapitalSocial = oSqlDataReader.Item("capital_social")
                dValorQuota = oSqlDataReader("valor_quota")
                sValorQuotaExtenso = oSqlDataReader.Item("valor_quota_extenso")
                sNumeroQuotasExtenso = oSqlDataReader.Item("numero_quotas_extenso")
                sNumeroQuotas = oSqlDataReader.Item("numero_quotas")
                sNomeSocio1 = oSqlDataReader.Item("nome_socio1")
                sNomeSocio2 = oSqlDataReader.Item("nome_socio2")
                sNomeSocio3 = oSqlDataReader.Item("nome_socio3")
                sNomeSocio4 = oSqlDataReader.Item("nome_socio4")
                sNomeSocio5 = oSqlDataReader.Item("nome_socio5")
                sNomeSocio6 = oSqlDataReader.Item("nome_socio6")
                sNomeSocio7 = oSqlDataReader.Item("nome_socio7")
                dQtdQuotas1 = oSqlDataReader.Item("qtd_quotas1")
                dQtdQuotas2 = oSqlDataReader.Item("qtd_quotas2")
                dQtdQuotas3 = oSqlDataReader.Item("qtd_quotas3")
                dQtdQuotas4 = oSqlDataReader.Item("qtd_quotas4")
                dQtdQuotas5 = oSqlDataReader.Item("qtd_quotas5")
                dQtdQuotas6 = oSqlDataReader.Item("qtd_quotas6")
                dQtdQuotas7 = oSqlDataReader.Item("qtd_quotas7")
                dValorQuota1 = oSqlDataReader.Item("valor_quota1")
                dValorQuota2 = oSqlDataReader.Item("valor_quota2")
                dValorQuota3 = oSqlDataReader.Item("valor_quota3")
                dValorQuota4 = oSqlDataReader.Item("valor_quota4")
                dValorQuota5 = oSqlDataReader.Item("valor_quota5")
                dValorQuota6 = oSqlDataReader.Item("valor_quota6")
                dValorQuota7 = oSqlDataReader.Item("valor_quota7")
                dPorcentagem1 = oSqlDataReader.Item("porcentagem1")
                dPorcentagem2 = oSqlDataReader.Item("porcentagem2")
                dPorcentagem3 = oSqlDataReader.Item("porcentagem3")
                dPorcentagem4 = oSqlDataReader.Item("porcentagem4")
                dPorcentagem5 = oSqlDataReader.Item("porcentagem5")
                dPorcentagem6 = oSqlDataReader.Item("porcentagem6")
                dPorcentagem7 = oSqlDataReader.Item("porcentagem7")
                dTotalQuota = oSqlDataReader.Item("total_quota")
                dValorTotalQuota = oSqlDataReader.Item("valor_total_quota")
                sSociosAdministradores = oSqlDataReader.Item("socios_administradores")
                sPrazoBalancoEspecial = oSqlDataReader.Item("prazo_balanco_especial")
                sPrazoBalancoEspecialExtenso = oSqlDataReader.Item("prazo_balanco_especial_extenso")
                sPrazoPgtoMorte = oSqlDataReader.Item("prazo_pgto_morte")
                sPrazoPgtoMorteExtenso = oSqlDataReader.Item("prazo_pgto_morte_extenso")
                sPrazoDissolucao = oSqlDataReader.Item("prazo_dissolucao")
                sPrazoDissolucaoExtenso = oSqlDataReader.Item("prazo_dissolucao_extenso")
                sCidadeForo = oSqlDataReader.Item("cidade_foro")
                sEstadoForo = oSqlDataReader.Item("estado_foro")
                sDataImpressao = oSqlDataReader.Item("data_impressao")
                sQualificacao1 = oSqlDataReader.Item("qualificacao1")
                sQualificacao2 = oSqlDataReader.Item("qualificacao2")
                sQualificacao3 = oSqlDataReader.Item("qualificacao3")
                sQualificacao4 = oSqlDataReader.Item("qualificacao4")
                sQualificacao5 = oSqlDataReader.Item("qualificacao5")
                sQualificacao6 = oSqlDataReader.Item("qualificacao6")
                sNomeTestemunha1 = oSqlDataReader.Item("nome_testemunha1")
                sNomeTestemunha2 = oSqlDataReader.Item("nome_testemunha2")
                sRGTestemunha1 = oSqlDataReader.Item("rg_testemunha1")
                sRGTestemunha2 = oSqlDataReader.Item("rg_testemunha2")
                sNomeAdvogado = oSqlDataReader.Item("nome_advogado")
                sNumeroOAB = oSqlDataReader.Item("numero_oab")
                sDataAssinatura = oSqlDataReader.Item("data_assinatura")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: CLÁUSULA :::"
    Public Sub DeleteClausula()

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

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_contrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_contrato").Value : i += 1

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_contrato_clausula", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridClausula(ByVal oGrid As GridEX, _
                              ByVal iCodigoContrato As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_contrato_clausula", oSqlParameter)

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

    Public Sub LoadTreeView(ByVal oTreeView As TreeView, _
                       ByVal iCodigoContrato As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_contrato_clausula_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Then
                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("clausula_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho").ToString, oSqlDataReader.Item("clausula_filho"))
                    oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho")
                End If

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateClausula(ByVal iCodigo As Integer, _
                           ByVal iCodigoContrato As Integer, _
                           ByVal iCodigoClausulaPai As Integer, _
                           ByVal sDesignacao As String, _
                           ByVal iCodigoTipoClausula As Integer, _
                           ByVal bObrigatoria As Boolean, _
                           ByVal sDescricao As String)

        'Variaveis Locais
        Dim oSqlParameter(40) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_clausula_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoClausulaPai = -1, DBNull.Value, iCodigoClausulaPai) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "designacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDesignacao : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_clausula"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoClausula : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "obrigatoria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bObrigatoria : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_contrato_clausula", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertClausula(ByVal iCodigoContrato As Integer, _
                            ByVal iCodigoClausulaPai As Integer, _
                            ByVal sDesignacao As String, _
                            ByVal iCodigoTipoClausula As Integer, _
                            ByVal bObrigatoria As Boolean, _
                            ByVal sDescricao As String)

        'Variaveis Locais
        Dim oSqlParameter(40) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_clausula_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoClausulaPai = -1, DBNull.Value, iCodigoClausulaPai) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "designacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDesignacao : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_clausula"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoClausula : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "obrigatoria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bObrigatoria : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_contrato_clausula2", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TAG :::"
    Public Sub LoadGridTag(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_sga_tag", oSqlParameter)

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

    Public Sub LoadGridTag(ByVal oGrid As GridEX, _
                         ByVal iCodigoContrato As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_contrato_tag", oSqlParameter)

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

    Public Sub UpdateTag(ByVal iCodigoContrato As Integer, _
                          ByVal sTag As String, _
                          ByVal sTexto As String)

        'Variaveis Locais
        Dim oSqlParameter(40) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tag"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTag : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "texto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTexto : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_contrato_tag", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TERMO DEFINIDO :::"
    Public Sub LoadGridTermoDefinido(ByVal oGrid As GridEX, _
                              ByVal iCodigoContrato As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_contrato_termo_definido", oSqlParameter)

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

    Public Sub InsertTermoDefinido(ByVal iCodigoContrato As Integer, _
                                    ByVal sTermo As String)

        'Variaveis Locais
        Dim oSqlParameter(40) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTermo : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_contrato_termo_definido", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteTermoDefinido()

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

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_contrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_contrato").Value : i += 1

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_contrato_termo_definido", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#End Region

End Class
