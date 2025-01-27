Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsUsrFatEntradaNFeDestinada

#Region "::: FUNCTION / SUB :::"

#Region "::: NF-E AUTORIZADA :::"

    Public Sub UpdateConferencia(ByVal sChaveAcesso As String, _
                                 ByVal sDataConferencia As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_conferencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataConferencia : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Quety
            SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_nfe_destinada_conferencia", oSqlParameter)

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertNFeAutorizada(ByVal sNSU As String, _
                                  ByVal sChaveAcesso As String, _
                                  ByVal sCNPJ As String, _
                                  ByVal sRazaoSocial As String, _
                                  ByVal sInscricaoEstadual As String, _
                                  ByVal dDataEmissao As Date, _
                                  ByVal iCodigoTipoNF As Integer, _
                                  ByVal dValor As Double, _
                                  ByVal iCodigoSituacaoNFe As Integer, _
                                  ByVal iCodigoSituacaoManifestacao As Integer, _
                                  ByVal dDataAutorizacao As Date, _
                                  Optional ByVal iCodigoTipoNotaFiscal As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nsu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNSU : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sCNPJ : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadual : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataEmissao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_situacao_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoSituacaoNFe : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_situacao_manifestacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoSituacaoManifestacao : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoNotaFiscal : i += 1



            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_autorizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataAutorizacao

            'Executa Quety
            SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nfe_destinada_autorizada", oSqlParameter)

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridNFeAutorizada(ByVal oGrid As GridEX, _
                                     ByVal lNotaFiscal As Long, _
                                     ByVal sDataInicio As String, _
                                     ByVal sDataTermino As String, _
                                     ByVal sEmitente As String, _
                                     ByVal sStatus As String, _
                                     ByVal iCodigoTipoDocumentoFiscal As Integer, _
                                     ByVal bSomentePendencia As Boolean,
                                     ByVal bListarCTeCancelado As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmitente : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoDocumentoFiscal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "somente_pendencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSomentePendencia : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cte_cancelado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bListarCTeCancelado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Quety
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfe_destinada_autorizada", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("chave_acesso"), oDataSet.Tables(1).Columns("chave_acesso"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertEmissaoNFeAutorizada(ByVal sNSU As String, _
                                  ByVal sChaveAcesso As String, _
                                  ByVal sCNPJ As String, _
                                  ByVal sRazaoSocial As String, _
                                  ByVal sInscricaoEstadual As String, _
                                  ByVal dDataEmissao As Date, _
                                  ByVal iCodigoTipoNF As Integer, _
                                  ByVal dValor As Double, _
                                  ByVal iCodigoSituacaoNFe As Integer, _
                                  ByVal iCodigoSituacaoManifestacao As Integer, _
                                  ByVal dDataAutorizacao As Date)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nsu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNSU : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sCNPJ : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadual : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataEmissao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_situacao_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoSituacaoNFe : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_situacao_manifestacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoSituacaoManifestacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_autorizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataAutorizacao

            'Executa Quety
            SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfe_destinada_autorizada", oSqlParameter)

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: NF-E CANCELADA :::"

    Public Sub LoadGridNFeCancelada(ByVal oGrid As GridEX, _
                                    ByVal sDataInicio As String, _
                                    ByVal sDataTermino As String, _
                                    ByVal sEmitente As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sEmitente : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Quety
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfe_destinada_cancelada", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertNFeCancelada(ByVal sNSU As String, _
                                  ByVal sChaveAcesso As String, _
                                  ByVal sCNPJ As String, _
                                  ByVal sRazaoSocial As String, _
                                  ByVal sInscricaoEstadual As String, _
                                  ByVal dDataEmissao As Date, _
                                  ByVal iCodigoTipoNF As Integer, _
                                  ByVal dValor As Double, _
                                  ByVal iCodigoSituacaoNFe As Integer, _
                                  ByVal iCodigoSituacaoManifestacao As Integer, _
                                  ByVal dDataAutorizacao As Date)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0
        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nsu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNSU : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sCNPJ : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadual : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataEmissao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_situacao_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoSituacaoNFe : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_situacao_manifestacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoSituacaoManifestacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_autorizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataAutorizacao : i += 1

            'Executa Quety
            SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nfe_destinada_cancelada", oSqlParameter)

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizarCTeCancelado(ByVal sChaveAcesso As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChaveAcesso

            'Executa Quety
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_nfe_destinada_cte_cancelado", oSqlParameter)

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CC-E :::"

    Public Sub InsertNFeCCe(ByVal sNSU As String, _
                            ByVal sChaveAcesso As String, _
                            ByVal dDataEvento As Date, _
                            ByVal sTipoEvento As String, _
                            ByVal sDescricaoEvento As String, _
                            ByVal sSequencia As String, _
                            ByVal sCorrecao As String, _
                            ByVal iCodigoTipoNF As Integer, _
                            ByVal dDataAutorizacao As Date)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nsu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNSU : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = sSequencia : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_evento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 6
            oSqlParameter(i).Value = sTipoEvento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_evento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sDescricaoEvento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "correcao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = sCorrecao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_evento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataEvento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_autorizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataAutorizacao

            'Executa Quety
            SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_nfe_destinada_cce", oSqlParameter)

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridNFeCCe(ByVal oGrid As GridEX, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal sEmitente As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sEmitente : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Quety
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfe_destinada_cce", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ALERTA :::"

    Public Sub LoadGridAlerta(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_alerta_nfe_destinada", oSqlParameter)

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


