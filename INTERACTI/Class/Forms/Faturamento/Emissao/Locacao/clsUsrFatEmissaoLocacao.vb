Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.Drawing.Printing

Public Class clsUsrFatEmissaoLocacao

#Region "::: VARIAVEIS :::"

#Region "::: VARIAVEIS - NOTA FISCAL :::"

    'Variaveis da Classe - Capa
    Private sCodigoModeloNotaFiscal As String
    Private iSerie As Integer
    Private lCodigoEmissaoNFLocacao As Long

#End Region

#Region "::: VARIAVEIS - CLIENTE :::"

    'Váriaveis da Classe - Destinatário
    Private iCodigoCliente As Integer
    Private sCnpjCpfCliente As String
    Private sInscricaoEstadualCliente As String
    Private sInscricaoMunicipalCliente As String
    Private sCepCliente As String
    Private iCodigoPaisCliente As Integer
    Private sUFCliente As String
    Private iCodigoMunicipioCliente As Integer
    Private sLogradouroCliente As String
    Private sNumeroCliente As String
    Private sBairroCliente As String
    Private sComplementoCliente As String
    Private sTelefoneCliente As String
    Private sEmailCliente As String

#End Region

#Region "::: VARIAVEIS - FATURA :::"

    'Váriaveis da Classe - Fatura
    Private sFatura As String
    Private dValorOriginal As Double
    Private dValorRetido As Double
    Private dValorDesconto As Double
    Private dValorLiquido As Double
    Private iCodigoFormaPagamentoNFe As Integer
    Private iNumeroParcela As Integer
    Private iIntervaloParcela As Integer

#End Region

#Region "::: VARIAVEIS - IMPOSTO :::"

    'Váriaveis da Classe - Fatura
    Private bLei10833 As Boolean
    Private dAliquotaLei10833 As Double
    Private bINSS As Boolean
    Private dAliquotaINSS As Double
    Private bISS As Boolean
    Private dAliquotaISS As Double
    Private bIR As Boolean
    Private dAliquotaIR As Double

#End Region

#Region "::: VARIAVEIS - DADOS ADICIONAIS :::"

    'Váriaveis da Classe - Fatura
    Private sDadosAdicionais As String
    
#End Region

#Region "::: VARIAVEIS - INTEGRAÇÃO :::"

    'Variaveis da Classe - Capa
    Private lCodigoTituloCapa As Long

#End Region

#End Region

#Region "::: PROPERTIE :::"

#Region "::: PROPERTIE - NOTA FISCAL :::"

    Public Property ModeloNotaFiscal() As String
        Get
            Return sCodigoModeloNotaFiscal
        End Get
        Set(ByVal value As String)
            sCodigoModeloNotaFiscal = value
        End Set
    End Property

    Public Property Serie() As Integer
        Get
            Return iSerie
        End Get
        Set(ByVal value As Integer)
            iSerie = value
        End Set
    End Property

    Public Property CodigoEmissaoNFLocacao() As Long
        Get
            Return lCodigoEmissaoNFLocacao
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoNFLocacao = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - CLIENTE :::"

    Public Property CodigoCliente() As Integer
        Get
            Return iCodigoCliente
        End Get
        Set(ByVal value As Integer)
            iCodigoCliente = value
        End Set
    End Property

    Public Property CnpjCpfCliente() As String
        Get
            Return sCnpjCpfCliente
        End Get
        Set(ByVal value As String)
            sCnpjCpfCliente = value
        End Set
    End Property

    Public Property InscricaoEstadualCliente() As String
        Get
            Return sInscricaoEstadualCliente
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualCliente = value
        End Set
    End Property

    Public Property InscricaoMunicipalCliente() As String
        Get
            Return sInscricaoMunicipalCliente
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipalCliente = value
        End Set
    End Property

    Public Property CepCliente() As String
        Get
            Return sCepCliente
        End Get
        Set(ByVal value As String)
            sCepCliente = value
        End Set
    End Property

    Public Property CodigoPaisCliente() As Integer
        Get
            Return iCodigoPaisCliente
        End Get
        Set(ByVal value As Integer)
            iCodigoPaisCliente = value
        End Set
    End Property

    Public Property UFCliente() As String
        Get
            Return sUFCliente
        End Get
        Set(ByVal value As String)
            sUFCliente = value
        End Set
    End Property

    Public Property CodigoMunicipioCliente() As Integer
        Get
            Return iCodigoMunicipioCliente
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioCliente = value
        End Set
    End Property

    Public Property LogradouroCliente() As String
        Get
            Return sLogradouroCliente
        End Get
        Set(ByVal value As String)
            sLogradouroCliente = value
        End Set
    End Property

    Public Property NumeroCliente() As String
        Get
            Return sNumeroCliente
        End Get
        Set(ByVal value As String)
            sNumeroCliente = value
        End Set
    End Property

    Public Property BairroCliente() As String
        Get
            Return sBairroCliente
        End Get
        Set(ByVal value As String)
            sBairroCliente = value
        End Set
    End Property

    Public Property ComplementoCliente() As String
        Get
            Return sComplementoCliente
        End Get
        Set(ByVal value As String)
            sComplementoCliente = value
        End Set
    End Property

    Public Property TelefoneCliente() As String
        Get
            Return sTelefoneCliente
        End Get
        Set(ByVal value As String)
            sTelefoneCliente = value
        End Set
    End Property

    Public Property EmailCliente() As String
        Get
            Return sEmailCliente
        End Get
        Set(ByVal value As String)
            sEmailCliente = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - FATURA :::"

    Public Property Fatura() As String
        Get
            Return sFatura
        End Get
        Set(ByVal value As String)
            sFatura = value
        End Set
    End Property

    Public Property ValorOriginal() As Double
        Get
            Return dValorOriginal
        End Get
        Set(ByVal value As Double)
            dValorOriginal = value
        End Set
    End Property

    Public Property ValorRetido() As Double
        Get
            Return dValorRetido
        End Get
        Set(ByVal value As Double)
            dValorRetido = value
        End Set
    End Property

    Public Property ValorDesconto() As Double
        Get
            Return dValorDesconto
        End Get
        Set(ByVal value As Double)
            dValorDesconto = value
        End Set
    End Property

    Public Property ValorLiquido() As Double
        Get
            Return dValorLiquido
        End Get
        Set(ByVal value As Double)
            dValorLiquido = value
        End Set
    End Property

    Public Property CodigoFormaPagamentoNFe() As Integer
        Get
            Return iCodigoFormaPagamentoNFe
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamentoNFe = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

    Public Property IntervaloParcela() As Integer
        Get
            Return iIntervaloParcela
        End Get
        Set(ByVal value As Integer)
            iIntervaloParcela = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - IMPOSTO :::"

    Public Property Lei10833() As Boolean
        Get
            Return bLei10833
        End Get
        Set(ByVal value As Boolean)
            bLei10833 = value
        End Set
    End Property

    Public Property AliquotaLei10833() As Double
        Get
            Return dAliquotaLei10833
        End Get
        Set(ByVal value As Double)
            dAliquotaLei10833 = value
        End Set
    End Property

    Public Property INSS() As Boolean
        Get
            Return bINSS
        End Get
        Set(ByVal value As Boolean)
            bINSS = value
        End Set
    End Property

    Public Property AliquotaINSS() As Double
        Get
            Return dAliquotaINSS
        End Get
        Set(ByVal value As Double)
            dAliquotaINSS = value
        End Set
    End Property

    Public Property ISS() As Boolean
        Get
            Return bISS
        End Get
        Set(ByVal value As Boolean)
            bISS = value
        End Set
    End Property

    Public Property AliquotaISS() As Double
        Get
            Return dAliquotaISS
        End Get
        Set(ByVal value As Double)
            dAliquotaISS = value
        End Set
    End Property

    Public Property IR() As Boolean
        Get
            Return bIR
        End Get
        Set(ByVal value As Boolean)
            bIR = value
        End Set
    End Property

    Public Property AliquotaIR() As Double
        Get
            Return dAliquotaIR
        End Get
        Set(ByVal value As Double)
            dAliquotaIR = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - DADOS ADICIONAIS :::"

    Public Property DadosAdicionais() As String
        Get
            Return sDadosAdicionais
        End Get
        Set(ByVal value As String)
            sDadosAdicionais = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - INTEGRAÇÃO :::"

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: NOTA FISCAL :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNotaFiscal As Long, _
                        ByVal iSerie As Integer, _
                        ByVal sCliente As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iSerie : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Data de Emissão - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoInicio = "", DBNull.Value, sDataEmissaoInicio) : i += 1

            'Seta Parametros - Data de Emissão - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoTermino = "", DBNull.Value, sDataEmissaoTermino) : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_locacao_capa", oSqlParameter)
                        
            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_locacao_capa"))

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX, _
                                 ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Locação Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_locacao_historico", oSqlParameter)

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

    Public Sub InsertCapa()

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sCodigoModeloNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSerie : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNFLocacao.Elaboracao : i += 1

            'Seta Parametros - Lei10833
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lei10833"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bLei10833 : i += 1

            'Seta Parametros - Alíquota Lei10833
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_lei10833"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaLei10833 : i += 1

            'Seta Parametros - INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bINSS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

            'Seta Parametros - ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bISS : i += 1

            'Seta Parametros - Alíquota ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            'Seta Parametros - IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIR : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Dados Adicionais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dados_adicionais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDadosAdicionais : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_locacao_capa", oSqlParameter)

            'Seta Váriavel 
            lCodigoEmissaoNFLocacao = oSqlParameter(14).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCapa()

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sCodigoModeloNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = iSerie.ToString : i += 1

            'Seta Parametros - Lei10833
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lei10833"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bLei10833 : i += 1

            'Seta Parametros - Alíquota Lei10833
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_lei10833"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaLei10833 : i += 1

            'Seta Parametros - INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bINSS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

            'Seta Parametros - ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bISS : i += 1

            'Seta Parametros - Alíquota ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            'Seta Parametros - IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIR : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Dados Adicionais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dados_adicionais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDadosAdicionais : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_locacao_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCapa()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Exclui Registro
            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_locacao_capa", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNotaFiscal(ByVal lCodigo As Long, _
                                   ByVal cboModelo As UIComboBox, _
                                   ByVal cboSerie As UIComboBox, _
                                   ByVal txtNotaFiscal As MaskedEditBox, _
                                   ByVal txtDataEmissao As MaskedEditBox, _
                                   ByVal cboCliente As UIComboBox, _
                                   ByVal txtCNPJCliente As MaskedEditBox, _
                                   ByVal txtInscricaoEstadualCliente As MaskedEditBox, _
                                   ByVal txtInscricaoMunicipalCliente As MaskedEditBox, _
                                   ByVal txtCEPCliente As MaskedEditBox, _
                                   ByVal cboPaisCliente As UIComboBox, _
                                   ByVal cboUFCliente As UIComboBox, _
                                   ByVal cboMunicipioCliente As UIComboBox, _
                                   ByVal txtLogradouroCliente As MaskedEditBox, _
                                   ByVal txtNumeroCliente As MaskedEditBox, _
                                   ByVal txtBairroCliente As MaskedEditBox, _
                                   ByVal txtComplementoCliente As MaskedEditBox, _
                                   ByVal txtTelefoneCliente As MaskedEditBox, _
                                   ByVal txtEmailCliente As MaskedEditBox, _
                                   ByVal chkLei10833 As UICheckBox, _
                                   ByVal txtLei10833 As NumericEditBox, _
                                   ByVal chkINSS As UICheckBox, _
                                   ByVal txtINSS As NumericEditBox, _
                                   ByVal chkISS As UICheckBox, _
                                   ByVal txtISS As NumericEditBox, _
                                   ByVal chkIR As UICheckBox, _
                                   ByVal txtIR As NumericEditBox, _
                                   ByVal txtDadosAdicionais As EditBox, _
                                   ByVal txtFatura As MaskedEditBox, _
                                   ByVal txtValorOriginal As NumericEditBox, _
                                   ByVal txtValorRetido As NumericEditBox, _
                                   ByVal txtValorDesconto As NumericEditBox, _
                                   ByVal txtValorLiquido As NumericEditBox, _
                                   ByVal cboFormaPagamento As UIComboBox, _
                                   ByVal txtNumeroParcela As NumericEditBox, _
                                   ByVal txtIntervaloEntreParcelas As NumericEditBox)

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
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_locacao_dados", oSqlParameter)

            While oSqlDataReader.Read

                cboModelo.SelectedValue = oSqlDataReader.Item("codigo_modelo")
                cboSerie.SelectedValue = oSqlDataReader.Item("serie")
                txtNotaFiscal.Text = IIf(IsDBNull(oSqlDataReader.Item("nota_fiscal")), "", oSqlDataReader.Item("nota_fiscal"))
                txtDataEmissao.Text = IIf(IsDBNull(oSqlDataReader.Item("data_emissao")), "", oSqlDataReader.Item("data_emissao"))
                cboCliente.SelectedValue = oSqlDataReader.Item("codigo_cliente")
                chkLei10833.Checked = oSqlDataReader.Item("lei10833")
                txtLei10833.Value = oSqlDataReader.Item("aliquota_lei10833")
                chkINSS.Checked = oSqlDataReader.Item("inss")
                txtINSS.Value = oSqlDataReader.Item("aliquota_inss")
                chkISS.Checked = oSqlDataReader.Item("iss")
                txtISS.Value = oSqlDataReader.Item("aliquota_iss")
                chkIR.Checked = oSqlDataReader.Item("ir")
                txtIR.Value = oSqlDataReader.Item("aliquota_ir")
                txtDadosAdicionais.Text = oSqlDataReader.Item("dados_adicionais")
                txtFatura.Text = oSqlDataReader.Item("fatura")
                txtValorOriginal.Value = oSqlDataReader.Item("valor_original")
                txtValorRetido.Value = oSqlDataReader.Item("valor_retido")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtValorLiquido.Value = oSqlDataReader.Item("valor_liquido")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_nfe")
                txtNumeroParcela.Value = oSqlDataReader.Item("numero_parcela")
                txtIntervaloEntreParcelas.Value = oSqlDataReader.Item("intervalo_parcela")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DuplicarNF(ByVal lCodigo As Long, _
                          ByRef lCodigoNovo As Long)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNFSe.AguardandoTransmissao : i += 1

            'Seta Parametros - Código Novo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_novo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_locacao_duplicar", oSqlParameter)

            'Seta Váriavel 
            lCodigoNovo = oSqlParameter(4).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateStatusNotaFiscal(ByVal lCodigo As Long, _
                                      ByVal iStatus As Integer, _
                                      Optional ByVal sDataEmissao As String = "", _
                                      Optional ByVal lNumeroDocumento As Long = 0)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissao) = False, DBNull.Value, sDataEmissao) : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lNumeroDocumento = 0, DBNull.Value, lNumeroDocumento)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_locacao_status", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Cancelar(ByVal lCodigo As Long, _
                        ByVal sJustificativa As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(StatusNFLocacao.Cancelada) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sJustificativa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_locacao_cancelar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CLIENTE :::"

    Public Sub InsertCliente()

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - CNPJ / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpfCliente : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadualCliente : i += 1

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = sInscricaoMunicipalCliente : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCepCliente : i += 1

            'Seta Parametros - Código Pais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPaisCliente : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFCliente : i += 1

            'Seta Parametros - Código Municipio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipioCliente : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouroCliente : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroCliente : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairroCliente : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplementoCliente = "", DBNull.Value, sComplementoCliente) : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sTelefoneCliente = "", DBNull.Value, sTelefoneCliente) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEmailCliente = "", DBNull.Value, sEmailCliente)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_locacao_cliente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCliente()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_locacao_cliente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: EMITENTE :::"

    Public Sub InsertEmitente()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_locacao_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEmitente()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_locacao_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Public Sub InsertFatura()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = IIf(sFatura = "", DBNull.Value, sFatura) : i += 1

            'Seta Parametros - Valor Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOriginal : i += 1

            'Seta Parametros - Valor Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorRetido : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorLiquido : i += 1

            'Seta Parametros - Código Forma de Pagamento NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaPagamentoNFe : i += 1

            'Seta Parametros - Número de Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Intervalo de Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iIntervaloParcela

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_locacao_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFaturaDuplicata(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim i As Integer
            Dim oSqlParameter(4) As SqlParameter

            For Each oRow As GridEXRow In oGrid.GetDataRows

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_locacao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - N° Duplicata
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_duplicata"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.RowIndex + 1 : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_locacao_fatura_duplicata", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFatura()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_locacao_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFatura(ByVal oGrid As GridEX, _
                              ByVal lCodigoEmissaoNFLocacao As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_locacao_fatura_duplicata", oSqlParameter)

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

    Public Sub GerarDuplicata(ByVal oGrid As GridEX, _
                              ByVal dValor As Double, _
                              ByVal iNumeroParcela As Integer, _
                              ByVal iIntervaloParcela As Integer)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Caso Valor Liquido maior que 0
            If dValor > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")

                'Seta DataType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)

                'Adiciona Linhas ao DataTable
                For i = 1 To iNumeroParcela
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("data_vencimento") = CDate(DateAdd(DateInterval.Day, i * iIntervaloParcela, Now.Date))
                    oDataRow("valor") = dValor / iNumeroParcela
                    oDataTable.Rows.Add(oDataRow)
                Next

                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Public Sub InsertProduto(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 1

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_locacao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Pedido Venda
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido_venda"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = IIf(oRow.Cells("codigo_pedido").Value = -1, DBNull.Value, oRow.Cells("codigo_pedido").Value) : i += 1

                'Seta Parametros - Código Pedido Venda - Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido_venda_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = IIf(oRow.Cells("codigo_pedido_item").Value = -1, DBNull.Value, oRow.Cells("codigo_pedido_item").Value) : i += 1

                'Seta Parametros - Código Pedido Venda Item Entrega
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido_venda_item_entrega"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = IIf(oRow.Cells("codigo_pedido_item_entrega").Value = -1, DBNull.Value, oRow.Cells("codigo_pedido_item_entrega").Value) : i += 1

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_item").Value : i += 1

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("codigo_produto").Value : i += 1

                'Seta Parametros - Descricao
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 5000
                oSqlParameter(i).Value = oRow.Cells("descricao").Value : i += 1

                'Seta Parametros - Quantidade
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "quantidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("quantidade").Value : i += 1

                'Seta Parametros - Valor Unitário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_unitario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_unitario").Value : i += 1

                'Seta Parametros - Valor Total
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_total"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_total").Value : i += 1

                'Seta Parametros - Código Centro de Gasto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_centro_custo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = IIf(oRow.Cells("codigo_centro_custo").Value = -1, DBNull.Value, oRow.Cells("codigo_centro_custo").Value) : i += 1

                'Seta Parametros - Código Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_conta_contabil"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = IIf(oRow.Cells("codigo_conta_contabil").Value = "", DBNull.Value, oRow.Cells("codigo_conta_contabil").Value)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_locacao_produto", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteProduto()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_locacao_produto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal oGrid As GridEX, _
                              ByVal lCodigoEmissaoNFLocacao As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_locacao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFLocacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_locacao_produto", oSqlParameter)

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
