Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.CalendarCombo
Imports INTERACTI.SQLHelper
Imports System.IO
Imports System.Drawing.Imaging
Public Class clsUsrCadAtivoImobilizado

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigo As Long
    Private sCaminho As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

    Public Property Caminho() As String
        Get
            Return sCaminho
        End Get
        Set(ByVal value As String)
            sCaminho = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: ATIVO :::"

    Public Function LoadHelp(ByVal sFormulario As String, _
                             ByVal sCampo As String) As String

        'Variaveis Locais

        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFormulario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo

            'Executa Query
            Dim sReturn As String = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_help", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadHelp2(ByVal sFormulario As String, _
                              ByVal sCampo As String) As String

        'Variaveis Locais

        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFormulario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo

            'Executa Query
            Dim sReturn As String = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_help", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadFoto(ByVal iCodigoAtivoImobilizado As Integer, _
                        ByVal iCodigoFoto As Integer, _
                        ByVal pctFoto As PictureBox)

        'Variaveis Locais

        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim oSQLDataReader As SqlDataReader

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ativo_imobilizado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAtivoImobilizado : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_foto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFoto

            'Executa Query
            oSQLDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_foto2", oSqlParameter)


            If oSQLDataReader.Read Then
                'Carrega Logo
                If Not IsDBNull(oSQLDataReader.Item("foto")) Then
                    Dim bytBLOBData(oSQLDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                    oSQLDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    pctFoto.Image = Image.FromStream(stmBLOBData)
                End If

            End If
            oSQLDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertHelp(ByVal sFormulario As String, _
                        ByVal sCampo As String, _
                        ByVal sTexto As String)

        'Variaveis Locais

        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "texto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTexto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFormulario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_static_help", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImportacaoAtivo(ByVal sGrupo As String, _
                               ByVal sCodigo As String, _
                               ByVal sAgregado As String, _
                               ByVal sDescricao As String, _
                               ByVal dValorAquisicao As Double, _
                               ByVal sDataAquisicao As String, _
                               ByVal dAplicada As Double, _
                               ByVal dAnual As Double, _
                               ByVal sMesAtual As String, _
                               ByVal iNumeroMeses As Integer, _
                               ByVal dAcumulada As Double, _
                               ByVal dValorBem As Double, _
                               ByVal dDepreciacaoMensal As Double, _
                               ByVal dValorAtualBem As Double, _
                               ByVal dDepreciacaoAcumulada As Double)

        'Variaveis Locais
        Dim oSqlParameter(30) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "grupo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sGrupo = "", DBNull.Value, sGrupo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCodigo = "", DBNull.Value, sCodigo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agregado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sAgregado = "", DBNull.Value, sAgregado) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sDescricao = "", DBNull.Value, sDescricao) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aquisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorAquisicao = -1, DBNull.Value, dValorAquisicao) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aquisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sDataAquisicao = "", DBNull.Value, sDataAquisicao) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aplicada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAplicada = -1, DBNull.Value, dAplicada) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "anual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAnual = -1, DBNull.Value, dAnual) : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mes_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sMesAtual = "", DBNull.Value, sMesAtual) : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iNumeroMeses = -1, DBNull.Value, iNumeroMeses) : i += 1 : ReDim Preserve oSqlParameter(i)



            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "acumulada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAcumulada = -1, DBNull.Value, dAcumulada) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_bem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorBem = -1, DBNull.Value, dValorBem) : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "depreciacao_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dDepreciacaoMensal = -1, DBNull.Value, dDepreciacaoMensal) : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_atual_bem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorAtualBem = -1, DBNull.Value, dValorAtualBem) : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "depreciacao_acumulada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dDepreciacaoAcumulada = -1, DBNull.Value, dDepreciacaoAcumulada) 


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_importacao_ativo", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.InputOutput
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_ativo_imobilizado", oSqlParameter)

            lCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal sUnidade As String, _
                      ByRef sNumeroFicha As String, _
                      ByRef sNumeroPatrimonial As String, _
                      ByRef sNumeroAtivo As String, _
                      ByVal sNumeracaoEmpresa As String, _
                      ByVal sChapaIdentificacao As String, _
                      ByVal sDescricao As String, _
                      ByVal iStatus As Integer, _
                      ByVal iCodigoGrupoAtivo As Integer, _
                      ByVal sDataAtivacao As String, _
                      ByVal iCodigoProprietario As Integer, _
                      ByVal dCustoLiquidoAquisicaoTransferencia As Double, _
                      ByVal dCustoLiquidoInstalacaoAcessorios As Double, _
                      ByVal dCustoLiquidoTotalAtivoImobilizado As Double, _
                      ByVal iCondicaoAquisicao As Integer, _
                      ByVal sNumeroDocumentoOrigem As String, _
                      ByVal sDataDocumentoOrigem As String, _
                      ByVal sFornecedorOrigem As String, _
                      ByVal sChaveAcessoOrigem As String, _
                      ByVal sArquivoAnexoOrigem As String, _
                      ByVal iTipoDocumento As Integer, _
                      ByVal sNumeroDocumento As String, _
                      ByVal sDataDocumento As String, _
                      ByVal sFornecedor As String, _
                      ByVal sCnpjCpfFornecedor As String, _
                      ByVal sChaveAcesso As String, _
                      ByVal sNCM As String, _
                      ByVal sNumeroDI As String, _
                      ByVal sArquivoAnexoDocumento As String, _
                      ByVal dCustoBruto As Double, _
                      ByVal dValorFrete As Double, _
                      ByVal dValorICMS As Double, _
                      ByVal dValorIPI As Double, _
                      ByVal dValorPIS As Double, _
                      ByVal dValorCOFINS As Double, _
                      ByVal dCustoLiquido As Double, _
                      ByVal sModeloAtivo As String, _
                      ByVal sNumeroSerieFabricanteAtivo As String, _
                      ByVal sIdentificacaoAtivo As String, _
                      ByVal sOutrasCaracteristicasAtivo As String, _
                      ByVal sResponsavelDepartamentoAtivo As String, _
                      ByVal sResponsavelCadastroAtivo As String, _
                      ByVal iCodigoCentroCustoAtivo As Integer, _
                      ByVal sCodigoContaContabilAtivo As String, _
                      ByVal sLocalizacaoAtivo As String, _
                      ByVal sObservacaoAtivo As String, _
                      ByVal dEstimativaVidaUtilFiscal As Double, _
                      ByVal dTaxaDepreciacaoAnualFiscal As Double, _
                      ByVal dTaxaDepreciacaoMensalFiscal As Double, _
                      ByVal iCodigoTurnoDepreciacaoFiscal As Integer, _
                      ByVal dTaxaDepreciacaoTurnoFiscal As Double, _
                      ByVal dValorDepreciacaoMensalFiscal As Double, _
                      ByVal dValorTotalDepreciadoFiscal As Double, _
                      ByVal dSaldoDepreciacaoFiscal As Double, _
                      ByVal dEstimativaVidaUtilEconomica As Double, _
                      ByVal dEstimativaValorFinalVidaUtilEconomica As Double, _
                      ByVal dVidaRemanescenteEconomica As Double, _
                      ByVal dValorResidualEconomica As Double, _
                      ByVal dValorDepreciavelEconomica As Double, _
                      ByVal dValorDepreciacaoAnualEconomica As Double, _
                      ByVal dValorDepreciacaoMensalEconomica As Double, _
                      ByVal dValorTotalDepreciadoEconomica As Double, _
                      ByVal dSaldoDepreciacaoEconomica As Double, _
                      ByVal sJustificativaVidaUtilEconomica As String, _
                      ByVal sDataInicioGarantia As String, _
                      ByVal sDataTerminoGarantia As String, _
                      ByVal sArquivoAnexoGarantia As String, _
                      ByVal sTermosGarantia As String, _
                      ByVal lCodigoEmissaoCapa As Long, _
                      ByVal lCodigoEmissaoItem As Long, _
                      ByVal lCodigoEntradaCapa As Long, _
                      ByVal lCodigoEntradaItem As Long, _
                      ByVal iCodigoAtivoPai As Integer, _
                      ByVal sCodigoProduto As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sUnidade : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_ficha"
            oSqlParameter(i).Direction = ParameterDirection.InputOutput
            oSqlParameter(i).Size = 100
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_patrimonial"
            oSqlParameter(i).Direction = ParameterDirection.InputOutput
            oSqlParameter(i).Size = 100
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_ativo"
            oSqlParameter(i).Direction = ParameterDirection.InputOutput
            oSqlParameter(i).Size = 100
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numeracao_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = IIf(sNumeracaoEmpresa = "", DBNull.Value, sNumeracaoEmpresa) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chapa_identificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sChapaIdentificacao = "", DBNull.Value, sChapaIdentificacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iStatus : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_ativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAtivacao = "", DBNull.Value, sDataAtivacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_proprietario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoProprietario = 0, DBNull.Value, iCodigoProprietario) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_liquido_aquisicao_transferencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoLiquidoAquisicaoTransferencia : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_liquido_instalacao_acessorios"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoLiquidoInstalacaoAcessorios : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_liquido_total_ativo_imobilizado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoLiquidoTotalAtivoImobilizado : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_aquisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCondicaoAquisicao = -1, DBNull.Value, iCondicaoAquisicao) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = IIf(sNumeroDocumentoOrigem = "", DBNull.Value, sNumeroDocumentoOrigem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_documento_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sDataDocumentoOrigem = "", DBNull.Value, sDataDocumentoOrigem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sFornecedorOrigem = "", DBNull.Value, sFornecedorOrigem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sChaveAcessoOrigem = "", DBNull.Value, sChaveAcessoOrigem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_anexo_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivoAnexoOrigem = "", DBNull.Value, sArquivoAnexoOrigem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iTipoDocumento = -1, DBNull.Value, iTipoDocumento) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNumeroDocumento = "", DBNull.Value, sNumeroDocumento) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataDocumento = "", DBNull.Value, sDataDocumento) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sFornecedor = "", DBNull.Value, sFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sCnpjCpfFornecedor = "", DBNull.Value, sCnpjCpfFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sChaveAcesso = "", DBNull.Value, sChaveAcesso) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = IIf(sNCM = "", DBNull.Value, sNCM) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNumeroDI = "", DBNull.Value, sNumeroDI) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_anexo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivoAnexoDocumento = "", DBNull.Value, sArquivoAnexoDocumento) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_bruto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoBruto : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIPI : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPIS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCOFINS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoLiquido : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "modelo_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sModeloAtivo = "", DBNull.Value, sModeloAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_serie_fabricante_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNumeroSerieFabricanteAtivo = "", DBNull.Value, sNumeroSerieFabricanteAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "identificacao_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sIdentificacaoAtivo = "", DBNull.Value, sIdentificacaoAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_caracteristicas_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sOutrasCaracteristicasAtivo = "", DBNull.Value, sOutrasCaracteristicasAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "responsavel_departamento_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = IIf(sResponsavelDepartamentoAtivo = "", DBNull.Value, sResponsavelDepartamentoAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "responsavel_cadastro_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = IIf(sResponsavelCadastroAtivo = "", DBNull.Value, sResponsavelCadastroAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroCustoAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sCodigoContaContabilAtivo = "", DBNull.Value, sCodigoContaContabilAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "localizacao_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sLocalizacaoAtivo = "", DBNull.Value, sLocalizacaoAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sObservacaoAtivo = "", DBNull.Value, sObservacaoAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estimativa_vida_util_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dEstimativaVidaUtilFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_depreciacao_anual_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaDepreciacaoAnualFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_depreciacao_mensal_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaDepreciacaoMensalFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_turno_depreciacao_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTurnoDepreciacaoFiscal = -1, DBNull.Value, iCodigoTurnoDepreciacaoFiscal) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_depreciacao_turno_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaDepreciacaoTurnoFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciacao_mensal_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciacaoMensalFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_depreciado_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalDepreciadoFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saldo_depreciacao_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dSaldoDepreciacaoFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estimativa_vida_util_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dEstimativaVidaUtilEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estimativa_valor_final_vida_util_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dEstimativaValorFinalVidaUtilEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "vida_remanescente_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dVidaRemanescenteEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_residual_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorResidualEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciavel_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciavelEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciacao_anual_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciacaoAnualEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciacao_mensal_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciacaoMensalEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_depreciado_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalDepreciadoEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saldo_depreciacao_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dSaldoDepreciacaoEconomica : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa_vida_util_economica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sJustificativaVidaUtilEconomica = "", DBNull.Value, sJustificativaVidaUtilEconomica) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_garantia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicioGarantia = "", DBNull.Value, sDataInicioGarantia) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino_garantia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataTerminoGarantia = "", DBNull.Value, sDataTerminoGarantia) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_anexo_garantia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivoAnexoGarantia = "", DBNull.Value, sArquivoAnexoGarantia) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termos_garantia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sTermosGarantia = "", DBNull.Value, sTermosGarantia) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEmissaoCapa = 0, DBNull.Value, lCodigoEmissaoCapa) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEmissaoItem = 0, DBNull.Value, lCodigoEmissaoItem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEntradaCapa = 0, DBNull.Value, lCodigoEntradaCapa) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEntradaItem = 0, DBNull.Value, lCodigoEntradaItem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ativo_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAtivoPai = -1, DBNull.Value, iCodigoAtivoPai) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoProduto : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_ativo_imobilizado", oSqlParameter)

            'Preenche as variaveis
            sNumeroFicha = oSqlParameter(2).Value
            sNumeroPatrimonial = oSqlParameter(3).Value

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_ativo_imobilizado", oSqlParameter)

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
                        ByVal sNumeroFicha As String, _
                        ByVal sGrupoAtivo As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_ficha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroFicha : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "grupo_ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sGrupoAtivo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_ativo_imobilizado"))

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesAtivo(ByVal cboUnidade As UIComboBox, _
                                  ByVal txtNumeroFicha As MaskedEditBox, _
                                  ByVal txtNumeroPatrimonial As MaskedEditBox, _
                                  ByVal txtNumeracaoEmpresa As MaskedEditBox, _
                                  ByVal txtChapaIdentificacao As MaskedEditBox, _
                                  ByVal txtDescricao As MaskedEditBox, _
                                  ByVal cboStatus As UIComboBox, _
                                  ByVal cboGrupoAtivo As UIComboBox, _
                                  ByVal dtpDataAtivacao As CalendarCombo, _
                                  ByVal cboProprietario As UIComboBox, _
                                  ByVal txtCustoLiquidoAquisicaoTransferencia As NumericEditBox, _
                                  ByVal txtCustoLiquidoInstalacaoAcessorios As NumericEditBox, _
                                  ByVal txtCustoLiquidoTotalAtivoImobilizado As NumericEditBox, _
                                  ByVal cboCondicaoAquisicao As UIComboBox, _
                                  ByVal txtNumeroDocumentoOrigem As MaskedEditBox, _
                                  ByVal dtpDataDocumentoOrigem As CalendarCombo, _
                                  ByVal txtFornecedorOrigem As MaskedEditBox, _
                                  ByVal txtChaveAcessoOrigem As MaskedEditBox, _
                                  ByVal txtArquivoAnexoOrigem As MaskedEditBox, _
                                  ByVal cboTipoDocumento As UIComboBox, _
                                  ByVal txtNumeroDocumento As MaskedEditBox, _
                                  ByVal dtpDataDocumento As CalendarCombo, _
                                  ByVal txtFornecedor As MaskedEditBox, _
                                  ByVal txtCNPJCPFFornecedor As MaskedEditBox, _
                                  ByVal txtChaveAcesso As MaskedEditBox, _
                                  ByVal txtNCM As MaskedEditBox, _
                                  ByVal txtNumeroDI As MaskedEditBox, _
                                  ByVal txtArquivoAnexoDocumento As MaskedEditBox, _
                                  ByVal txtCustoBruto As NumericEditBox, _
                                  ByVal txtValorICMS As NumericEditBox, _
                                  ByVal txtValorIPI As NumericEditBox, _
                                  ByVal txtValorPIS As NumericEditBox, _
                                  ByVal txtValorCOFINS As NumericEditBox, _
                                  ByVal txtValorFrete As NumericEditBox, _
                                  ByVal txtCustoLiquido As NumericEditBox, _
                                  ByVal txtModeloAtivo As MaskedEditBox, _
                                  ByVal txtNumeroSerieFabricanteAtivo As MaskedEditBox, _
                                  ByVal txtIdentificacaoAtivo As MaskedEditBox, _
                                  ByVal txtOutrasCaracteristicasAtivo As MaskedEditBox, _
                                  ByVal txtResponsavelDepartamentoAtivo As MaskedEditBox, _
                                  ByVal txtResponsavelCadastroAtivo As MaskedEditBox, _
                                  ByVal cboCentroCustoAtivo As UIComboBox, _
                                  ByVal cboContaContabil As UIComboBox, _
                                  ByVal txtLocalizacaoAtivo As MaskedEditBox, _
                                  ByVal txtObservacaoAtivo As EditBox, _
                                  ByVal txtEstimativaVidaUtilFiscal As NumericEditBox, _
                                  ByVal txtTaxaDepreciacaoAnualFiscal As NumericEditBox, _
                                  ByVal txtTaxaDepreciacaoMensalFiscal As NumericEditBox, _
                                  ByVal cboTurnoDepreciacaoFiscal As UIComboBox, _
                                  ByVal txtTaxaDepreciacaoTurnoFiscal As NumericEditBox, _
                                  ByVal txtValorDepreciacaoMensalFiscal As NumericEditBox, _
                                  ByVal txtValorTotalDepreciadoFiscal As NumericEditBox, _
                                  ByVal txtSaldoDepreciacaoFiscal As NumericEditBox, _
                                  ByVal txtEstimativaVidaUtilEconomica As NumericEditBox, _
                                  ByVal txtEstimativaValorFinalVidaUtilEconomica As NumericEditBox, _
                                  ByVal txtVidaRemanescenteEconomica As NumericEditBox, _
                                  ByVal txtValorResidualEconomica As NumericEditBox, _
                                  ByVal txtValorDepreciavelEconomica As NumericEditBox, _
                                  ByVal txtValorDepreciacaoAnualEconomica As NumericEditBox, _
                                  ByVal txtValorDepreciacaoMensalEconomica As NumericEditBox, _
                                  ByVal txtValorTotalDepreciadoEconomica As NumericEditBox, _
                                  ByVal txtSaldoDepreciacaoEconomica As NumericEditBox, _
                                  ByVal txtJustificativaVidaUtilEconomica As EditBox, _
                                  ByVal dtpDataInicioGarantia As CalendarCombo, _
                                  ByVal dtpDataTerminoGarantia As CalendarCombo, _
                                  ByVal txtArquivoAnexoGarantia As MaskedEditBox, _
                                  ByVal txtTermosGarantia As EditBox, _
                                  ByVal chkIdentificacaoNotaFiscal As UICheckBox, _
                                  ByRef lCodigoEmissaoCapaAtivo As Long, _
                                  ByRef lCodigoEmissaoItemAtivo As Long, _
                                  ByRef lCodigoEntradaCapaAtivo As Long, _
                                  ByRef lCodigoEntradaItemAtivo As Long, _
                                  ByVal cboAtivoPai As UIComboBox, _
                                  ByVal txtCodigoProduto As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_dados", oSqlParameter)

            If oSqlDataReader.Read Then


                cboUnidade.SelectedValue = oSqlDataReader.Item("unidade")
                txtNumeroFicha.Text = oSqlDataReader.Item("numero_ficha")
                txtNumeroPatrimonial.Text = oSqlDataReader.Item("numero_patrimonial")
                txtNumeracaoEmpresa.Text = oSqlDataReader.Item("numeracao_empresa")
                txtChapaIdentificacao.Text = oSqlDataReader.Item("chapa_identificacao")
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                cboStatus.SelectedValue = oSqlDataReader.Item("status")

                If IsDBNull(oSqlDataReader.Item("codigo_grupo_ativo")) Then
                    cboGrupoAtivo.SelectedIndex = -1
                Else
                    cboGrupoAtivo.SelectedValue = oSqlDataReader.Item("codigo_grupo_ativo")
                End If

                If IsDBNull(oSqlDataReader.Item("data_ativacao")) Then
                    dtpDataAtivacao.Value = Now
                    dtpDataAtivacao.Checked = False
                Else
                    dtpDataAtivacao.Value = oSqlDataReader.Item("data_ativacao")
                    dtpDataAtivacao.Checked = True
                End If

                If IsDBNull(oSqlDataReader.Item("codigo_proprietario")) Then
                    cboProprietario.SelectedIndex = -1
                Else
                    cboProprietario.SelectedValue = oSqlDataReader.Item("codigo_proprietario")
                End If

                txtCustoLiquidoAquisicaoTransferencia.Value = oSqlDataReader.Item("custo_liquido_aquisicao_transferencia")
                txtCustoLiquidoInstalacaoAcessorios.Value = oSqlDataReader.Item("custo_liquido_instalacao_acessorios")
                txtCustoLiquidoTotalAtivoImobilizado.Value = oSqlDataReader.Item("custo_liquido_total_ativo_imobilizado")

                If IsDBNull(oSqlDataReader.Item("codigo_condicao_aquisicao")) Then
                    cboCondicaoAquisicao.SelectedIndex = -1
                Else
                    cboCondicaoAquisicao.SelectedValue = oSqlDataReader.Item("codigo_condicao_aquisicao")
                End If

                txtNumeroDocumentoOrigem.Text = oSqlDataReader.Item("numero_documento_origem")
                dtpDataDocumentoOrigem.Value = oSqlDataReader.Item("data_documento_origem")
                txtFornecedorOrigem.Text = oSqlDataReader.Item("fornecedor_origem")
                txtChaveAcessoOrigem.Text = oSqlDataReader.Item("chave_acesso_origem")
                txtArquivoAnexoOrigem.Text = oSqlDataReader.Item("arquivo_anexo_origem")

                If IsDBNull(oSqlDataReader.Item("tipo_documento")) Then
                    cboTipoDocumento.SelectedIndex = -1
                Else
                    cboTipoDocumento.SelectedValue = oSqlDataReader.Item("tipo_documento")
                End If


                txtNumeroDocumento.Text = oSqlDataReader.Item("numero_documento")
                dtpDataDocumento.Value = oSqlDataReader.Item("data_documento")
                txtFornecedor.Text = oSqlDataReader.Item("fornecedor")
                txtCNPJCPFFornecedor.Text = oSqlDataReader.Item("cnpj_cpf_fornecedor")
                txtChaveAcesso.Text = oSqlDataReader.Item("chave_acesso")
                txtNCM.Text = oSqlDataReader.Item("ncm")
                txtNumeroDI.Text = oSqlDataReader.Item("numero_di")
                txtArquivoAnexoDocumento.Text = oSqlDataReader.Item("arquivo_anexo_documento")
                txtCustoBruto.Text = oSqlDataReader.Item("custo_bruto")
                txtValorICMS.Text = oSqlDataReader.Item("valor_icms")
                txtValorIPI.Text = oSqlDataReader.Item("valor_ipi")
                txtValorPIS.Text = oSqlDataReader.Item("valor_pis")
                txtValorCOFINS.Text = oSqlDataReader.Item("valor_cofins")
                txtValorFrete.Text = oSqlDataReader.Item("valor_frete")
                txtCustoLiquido.Text = oSqlDataReader.Item("custo_liquido")
                txtModeloAtivo.Text = oSqlDataReader.Item("modelo_ativo")
                txtNumeroSerieFabricanteAtivo.Text = oSqlDataReader.Item("numero_serie_fabricante_ativo")
                txtIdentificacaoAtivo.Text = oSqlDataReader.Item("identificacao_ativo")
                txtOutrasCaracteristicasAtivo.Text = oSqlDataReader.Item("outras_caracteristicas_ativo")
                txtResponsavelDepartamentoAtivo.Text = oSqlDataReader.Item("responsavel_departamento_ativo")
                txtResponsavelCadastroAtivo.Text = oSqlDataReader.Item("responsavel_cadastro_ativo")

                If IsDBNull(oSqlDataReader.Item("codigo_centro_custo_ativo")) Then
                    cboCentroCustoAtivo.SelectedIndex = -1
                Else
                    cboCentroCustoAtivo.SelectedValue = oSqlDataReader.Item("codigo_centro_custo_ativo")
                End If

                If IsDBNull(oSqlDataReader.Item("codigo_conta_contabil_ativo")) Then
                    cboContaContabil.SelectedIndex = -1
                Else
                    cboContaContabil.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil_ativo")
                End If

                txtLocalizacaoAtivo.Text = oSqlDataReader.Item("localizacao_ativo")
                txtObservacaoAtivo.Text = oSqlDataReader.Item("observacao_ativo")
                txtEstimativaVidaUtilFiscal.Text = oSqlDataReader.Item("estimativa_vida_util_fiscal")

                If IsDBNull(oSqlDataReader.Item("codigo_turno_depreciacao_fiscal")) Then
                    cboTurnoDepreciacaoFiscal.SelectedIndex = -1
                Else
                    cboTurnoDepreciacaoFiscal.SelectedValue = oSqlDataReader.Item("codigo_turno_depreciacao_fiscal")
                End If

                txtValorTotalDepreciadoFiscal.Value = oSqlDataReader.Item("valor_total_depreciado_fiscal")
                txtSaldoDepreciacaoFiscal.Value = oSqlDataReader.Item("saldo_depreciacao_fiscal")
                txtEstimativaVidaUtilEconomica.Value = oSqlDataReader.Item("estimativa_vida_util_economica")
                txtEstimativaValorFinalVidaUtilEconomica.Value = oSqlDataReader.Item("estimativa_valor_final_vida_util_economica")
                txtValorTotalDepreciadoEconomica.Value = oSqlDataReader.Item("valor_total_depreciado_economica")
                txtSaldoDepreciacaoEconomica.Value = oSqlDataReader.Item("saldo_depreciacao_economica")
                txtJustificativaVidaUtilEconomica.Text = oSqlDataReader.Item("justificativa_vida_util_economica")

                If IsDBNull(oSqlDataReader.Item("data_inicio_garantia")) Then

                    dtpDataInicioGarantia.Value = Now
                    dtpDataInicioGarantia.Checked = False

                Else
                    dtpDataInicioGarantia.Value = oSqlDataReader.Item("data_inicio_garantia")
                    dtpDataInicioGarantia.Checked = True

                End If

                If IsDBNull(oSqlDataReader.Item("data_termino_garantia")) Then

                    dtpDataTerminoGarantia.Value = Now
                    dtpDataTerminoGarantia.Checked = False

                Else
                    dtpDataTerminoGarantia.Value = oSqlDataReader.Item("data_termino_garantia")
                    dtpDataTerminoGarantia.Checked = True

                End If

                txtArquivoAnexoGarantia.Text = oSqlDataReader.Item("arquivo_anexo_garantia")
                txtTermosGarantia.Text = oSqlDataReader.Item("termos_garantia")
                chkIdentificacaoNotaFiscal.Checked = oSqlDataReader.Item("identificacao_nota_fiscal")
                lCodigoEmissaoCapaAtivo = oSqlDataReader.Item("codigo_emissao_capa")
                lCodigoEmissaoItemAtivo = oSqlDataReader.Item("codigo_emissao_item")
                lCodigoEntradaCapaAtivo = oSqlDataReader.Item("codigo_entrada_capa")
                lCodigoEntradaItemAtivo = oSqlDataReader.Item("codigo_entrada_item")

                If IsDBNull(oSqlDataReader.Item("codigo_ativo_pai")) Then
                    cboAtivoPai.SelectedIndex = -1
                Else
                    cboAtivoPai.SelectedValue = oSqlDataReader.Item("codigo_ativo_pai")
                End If

                txtCodigoProduto.Text = oSqlDataReader.Item("codigo_produto")

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesGrupoAtivo(ByVal iCodigo As Integer, _
                                       ByVal iCodigoAtivoPai As Integer, _
                                       ByVal txtEstimativaVidaUtil As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ativo_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAtivoPai : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_stc_grupo_ativo_imobilizado_dados", oSqlParameter)

            If oSqlDataReader.Read Then

                txtEstimativaVidaUtil.Value = oSqlDataReader.Item("vida_util_estimada_anos")

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadAtivoNumeroPatrimonial(ByVal lCodigo As Integer, _
                                       ByVal sUnidade As String, _
                                       ByVal dDataAquisicao As Date) As String

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUnidade : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aquisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataAquisicao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            Dim sReturn As String = ""

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_numero_patrimonial", oSqlParameter)

            If oSqlDataReader.Read Then

                sReturn = oSqlDataReader.Item(0)

            End If

            oSqlDataReader.Close()

            Return sReturn


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGridFind(ByVal oGrid As GridEX)

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_find_ativo_imobilizado", oSqlParameter)

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

#Region "::: CUSTO :::"


    Public Sub LoadGridCusto(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ativo_imobilizado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDataBase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_custo", oSqlParameter)

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

    Public Sub ChangeCusto(ByVal iCodigo As Integer, _
                           ByVal lCodigoAtivo As Long, _
                           ByVal iTipo As Integer, _
                           ByVal sNumeracao As String, _
                           ByVal sNumeroPratimonial As String, _
                           ByVal sChapaIdentificacao As String, _
                           ByVal sDescricao As String, _
                           ByVal sNumeroDocumento As String, _
                           ByVal dDataDocumento As Date, _
                           ByVal sFornecedor As String, _
                           ByVal sCnpjCpfFornecedor As String, _
                           ByVal sChaveAcesso As String, _
                           ByVal sArquivoAnexoDocumento As String, _
                           ByVal dCustoBrutoUnitario As Double, _
                           ByVal dValorFrete As Double, _
                           ByVal dValorICMS As Double, _
                           ByVal dValorIPI As Double, _
                           ByVal dValorPIS As Double, _
                           ByVal dValorCOFINS As Double, _
                           ByVal dCustoLiquidoUnitario As Double, _
                           ByVal dQuantidade As Double, _
                           ByVal dCustoTotal As Double, _
                           Optional lCodigoEntradaCapa As Long = 0, _
                           Optional lCodigoEmissaoCapa As Long = 0, _
                           Optional iCodigoEntradaitem As Integer = 0, _
                           Optional iCodigoEmissaoItem As Integer = 0, _
                           Optional lCodigoNFsCapa As Long = 0)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(27) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ativo_imobilizado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtivo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numeracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeracao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_patrimonial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroPratimonial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chapa_identificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChapaIdentificacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFornecedor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCnpjCpfFornecedor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_anexo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivoAnexoDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_bruto_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoBrutoUnitario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIPI : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPIS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCOFINS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_liquido_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoLiquidoUnitario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoTotal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEntradaCapa = 0, DBNull.Value, lCodigoEntradaCapa) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEmissaoCapa = 0, DBNull.Value, lCodigoEmissaoCapa) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEntradaitem = 0, DBNull.Value, iCodigoEntradaitem) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEmissaoItem = 0, DBNull.Value, iCodigoEmissaoItem) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoNFsCapa = 0, DBNull.Value, lCodigoNFsCapa)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_change_cadastro_basico_ativo_imobilizado_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCusto(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            For Each oRow In oGrid.GetCheckedRows

                i = 0
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ativo_imobilizado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigo : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código 
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDataBase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_ativo_imobilizado_custo", oSqlParameter)

            Next


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FOTO :::"
     
    Public Sub LoadGridFoto(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ativo_imobilizado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDataBase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_foto", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadDadosFoto(ByVal iNumeroFicha As Integer) As Integer

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim bReturn As Integer

        Try
             
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_ficha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroFicha : i += 1
             
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_foto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    bReturn = oSqlDataReader.Item("numero_foto")

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Return bReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub DeleteFoto(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            For Each oRow In oGrid.GetCheckedRows

                i = 0
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ativo_imobilizado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigo : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código 
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDataBase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_ativo_imobilizado_foto", oSqlParameter)

            Next


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ChangeFoto(ByVal iCodigo As Integer, _
                          ByVal lCodigoAtivo As Long, _
                          ByVal sDescricao As String, _
                          ByVal picFoto As PictureBox, _
                          ByVal sCaminho As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            i = 0
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ativo_imobilizado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtivo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "caminho_foto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sCaminho : i += 1


            'Verifica se existe Foto
            If Not picFoto.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picFoto.Image.Save(oMemoryStream, ImageFormat.Jpeg)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Logo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value : i += 1

            End If

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_change_cadastro_basico_ativo_imobilizado_foto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FIND :::"

    Public Sub LoadGridFindNFAtivo(ByVal oGrid As GridEX, _
                                   ByVal sNotaFiscal As String, _
                                   ByVal sEmitente As String, _
                                   ByVal sDataInicio As String, _
                                   ByVal sDataTermino As String, _
                                   ByVal sProduto As String, _
                                   ByVal sCFOP As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oDataSet As New DataSet
        Dim i As Integer = 0
        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNotaFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmitente : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCFOP : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProduto

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_find_nf", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFindNFAtivoAcessorio(ByVal oGrid As GridEX, _
                                            ByVal sNotaFiscal As String, _
                                            ByVal sEmitente As String, _
                                            ByVal sDataInicio As String, _
                                            ByVal sDataTermino As String, _
                                            ByVal sProduto As String, _
                                            ByVal sCFOP As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oDataSet As New DataSet
        Dim i As Integer = 0
        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNotaFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmitente : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCFOP : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProduto

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_find_nf_acessorio", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

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

#Region "::: ANEXO :::"

    Public Function LoadCaminhoPasta()

        'Variaveis Locais

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
            sCaminho = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ativo_imobilizado_pasta_anexo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
