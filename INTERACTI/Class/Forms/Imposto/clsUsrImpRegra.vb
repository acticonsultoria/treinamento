Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrImpRegra

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigoTipoRegra As Integer
    Private iCodigoParceiroNegocio As Integer
    Private lCodigoProduto As Long
    Private iCodigoCFOP As Integer
    Private iCodigoNCM As Integer
    Private iCodigoPersonalidade As Integer
    Private iCodigoDestinacao As Integer
    Private sUFDestino As String
    Private iCodigoOrigemItem As Integer
    Private iCodigoDeposito As Integer
    Private sSituacaoTributariaICMS As String
    Private iModalidadeBaseCalculoICMS As Integer
    Private iModalidadeBaseCalculoICMSST As Integer
    Private dIVA As Double
    Private dAliquotaICMS As Double
    Private dAliquotaICMSST As Double
    Private dPercentualReducaoBCICMS As Double
    Private dPercentualReducaoBCICMSST As Double
    Private sSituacaoTributariaPIS As String
    Private dAliquotaPIS As Double
    Private dAliquotaValorPIS As Double
    Private sSituacaoTributariaCOFINS As String
    Private dAliquotaCOFINS As Double
    Private dAliquotaValorCOFINS As Double
    Private sSituacaoTributariaIPI As String
    Private iCodigoTipoCalculoIPI As Integer
    Private dAliquotaIPI As Double
    Private dAliquotaValorIPI As Double
    Private dAliquotaII As Double
    Private sMensagemDadosAdicionaisProduto As String
    Private sMensagemDadosAdicionaisNotaFiscal As String
    Private bInserirIPIOutras As Boolean
    Private sCodigoEnquadramentoIPI As String
    Private iCodigo As Integer
    Private dAliquotaInterestadual As Double
    Private dPercentualFCP As Double

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTipoRegra() As Integer
        Get
            Return iCodigoTipoRegra
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoRegra = value
        End Set
    End Property

    Public Property CodigoParceiroNegocio() As Integer
        Get
            Return iCodigoParceiroNegocio
        End Get
        Set(ByVal value As Integer)
            iCodigoParceiroNegocio = value
        End Set
    End Property

    Public Property CodigoProduto() As Long
        Get
            Return lCodigoProduto
        End Get
        Set(value As Long)
            lCodigoProduto = value
        End Set
    End Property

    Public Property CodigoCFOP() As Integer
        Get
            Return iCodigoCFOP
        End Get
        Set(ByVal value As Integer)
            iCodigoCFOP = value
        End Set
    End Property

    Public Property CodigoNCM() As Integer
        Get
            Return iCodigoNCM
        End Get
        Set(ByVal value As Integer)
            iCodigoNCM = value
        End Set
    End Property

    Public Property CodigoPersonalidade() As Integer
        Get
            Return iCodigoPersonalidade
        End Get
        Set(ByVal value As Integer)
            iCodigoPersonalidade = value
        End Set
    End Property

    Public Property CodigoDestinacao() As Integer
        Get
            Return iCodigoDestinacao
        End Get
        Set(ByVal value As Integer)
            iCodigoDestinacao = value
        End Set
    End Property

    Public Property UFDestino() As String
        Get
            Return sUFDestino
        End Get
        Set(ByVal value As String)
            sUFDestino = value
        End Set
    End Property

    Public Property CodigoEnquadramentoIPI() As String
        Get
            Return sCodigoEnquadramentoIPI
        End Get
        Set(ByVal value As String)
            sCodigoEnquadramentoIPI = value
        End Set
    End Property

    Public Property CodigoOrigemItem() As Integer
        Get
            Return iCodigoOrigemItem
        End Get
        Set(ByVal value As Integer)
            iCodigoOrigemItem = value
        End Set
    End Property

    Public Property CodigoDeposito() As Integer
        Get
            Return iCodigoDeposito
        End Get
        Set(ByVal value As Integer)
            iCodigoDeposito = value
        End Set
    End Property

    Public Property SituacaoTributariaICMS() As String
        Get
            Return sSituacaoTributariaICMS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaICMS = value
        End Set
    End Property

    Public Property ModalidadeBaseCalculoICMS() As Integer
        Get
            Return iModalidadeBaseCalculoICMS
        End Get
        Set(ByVal value As Integer)
            iModalidadeBaseCalculoICMS = value
        End Set
    End Property

    Public Property ModalidadeBaseCalculoICMSST() As Integer
        Get
            Return iModalidadeBaseCalculoICMSST
        End Get
        Set(ByVal value As Integer)
            iModalidadeBaseCalculoICMSST = value
        End Set
    End Property

    Public Property IVA() As Double
        Get
            Return dIVA
        End Get
        Set(ByVal value As Double)
            dIVA = value
        End Set
    End Property

    Public Property AliquotaICMS() As Double
        Get
            Return dAliquotaICMS
        End Get
        Set(ByVal value As Double)
            dAliquotaICMS = value
        End Set
    End Property

    Public Property AliquotaICMSST() As Double
        Get
            Return dAliquotaICMSST
        End Get
        Set(ByVal value As Double)
            dAliquotaICMSST = value
        End Set
    End Property

    Public Property PercentualReducaoBCICMS() As Double
        Get
            Return dPercentualReducaoBCICMS
        End Get
        Set(ByVal value As Double)
            dPercentualReducaoBCICMS = value
        End Set
    End Property

    Public Property PercentualReducaoBCICMSST() As Double
        Get
            Return dPercentualReducaoBCICMSST
        End Get
        Set(ByVal value As Double)
            dPercentualReducaoBCICMSST = value
        End Set
    End Property

    Public Property SituacaoTributariaPIS() As String
        Get
            Return sSituacaoTributariaPIS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaPIS = value
        End Set
    End Property

    Public Property AliquotaPIS() As Double
        Get
            Return dAliquotaPIS
        End Get
        Set(ByVal value As Double)
            dAliquotaPIS = value
        End Set
    End Property

    Public Property AliquotaValorPIS() As Double
        Get
            Return dAliquotaValorPIS
        End Get
        Set(ByVal value As Double)
            dAliquotaValorPIS = value
        End Set
    End Property

    Public Property SituacaoTributariaCOFINS() As String
        Get
            Return sSituacaoTributariaCOFINS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaCOFINS = value
        End Set
    End Property

    Public Property AliquotaCOFINS() As Double
        Get
            Return dAliquotaCOFINS
        End Get
        Set(ByVal value As Double)
            dAliquotaCOFINS = value
        End Set
    End Property

    Public Property AliquotaValorCOFINS() As Double
        Get
            Return dAliquotaValorCOFINS
        End Get
        Set(ByVal value As Double)
            dAliquotaValorCOFINS = value
        End Set
    End Property

    Public Property SituacaoTributariaIPI() As String
        Get
            Return sSituacaoTributariaIPI
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaIPI = value
        End Set
    End Property

    Public Property CodigoTipoCalculoIPI() As Integer
        Get
            Return iCodigoTipoCalculoIPI
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoCalculoIPI = value
        End Set
    End Property

    Public Property AliquotaIPI() As Double
        Get
            Return dAliquotaIPI
        End Get
        Set(ByVal value As Double)
            dAliquotaIPI = value
        End Set
    End Property

    Public Property AliquotaValorIPI() As Double
        Get
            Return dAliquotaValorIPI
        End Get
        Set(ByVal value As Double)
            dAliquotaValorIPI = value
        End Set
    End Property

    Public Property AliquotaII() As Double
        Get
            Return dAliquotaII
        End Get
        Set(ByVal value As Double)
            dAliquotaII = value
        End Set
    End Property

    Public Property MensagemDadosAdicionaisProduto() As String
        Get
            Return sMensagemDadosAdicionaisProduto
        End Get
        Set(ByVal value As String)
            sMensagemDadosAdicionaisProduto = value
        End Set
    End Property

    Public Property MensagemDadosAdicionaisNotaFiscal() As String
        Get
            Return sMensagemDadosAdicionaisNotaFiscal
        End Get
        Set(ByVal value As String)
            sMensagemDadosAdicionaisNotaFiscal = value
        End Set
    End Property

    Public Property InserirIPIOutras As Boolean
        Get
            Return bInserirIPIOutras
        End Get
        Set(ByVal value As Boolean)
            bInserirIPIOutras = value
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

    Public Property AliquotaInterestadual() As Double
        Get
            Return dAliquotaInterestadual
        End Get
        Set(ByVal value As Double)
            dAliquotaInterestadual = value
        End Set
    End Property

    Public Property PercentualFCP() As Double
        Get
            Return dPercentualFCP
        End Get
        Set(ByVal value As Double)
            dPercentualFCP = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(37) As SqlParameter
        Dim i As Integer = 0

        Try
            
            'Seta Parametros - Codigo Tipo Regra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_regra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoRegra : i += 1

            'Seta Parametros - Codigo Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoParceiroNegocio = -1, DBNull.Value, iCodigoParceiroNegocio) : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoProduto = -1, DBNull.Value, lCodigoProduto) : i += 1

            'Seta Parametros - Codigo CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCFOP : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, iCodigoNCM) : i += 1

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPersonalidade = -1, DBNull.Value, iCodigoPersonalidade) : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoDestinacao = -1, DBNull.Value, iCodigoDestinacao) : i += 1

            'Seta Parametros - UF Destino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUFDestino = "", DBNull.Value, sUFDestino) : i += 1

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoOrigemItem = -1, DBNull.Value, iCodigoOrigemItem) : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoDeposito = -1, DBNull.Value, iCodigoDeposito) : i += 1

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(sSituacaoTributariaICMS = "", DBNull.Value, sSituacaoTributariaICMS) : i += 1

            'Seta Parametros - Modalidade Base Calculo ICMS 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMS = -1, DBNull.Value, iModalidadeBaseCalculoICMS) : i += 1

            'Seta Parametros - Modalidade Base Calculo ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMSST = -1, DBNull.Value, iModalidadeBaseCalculoICMSST) : i += 1

            'Seta Parametros - IVA
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dIVA = -1, DBNull.Value, dIVA) : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMS = -1, DBNull.Value, dAliquotaICMS) : i += 1

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSST = -1, DBNull.Value, dAliquotaICMSST) : i += 1

            'Seta Parametros - Percentual de Redução da BC do ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_reducao_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPercentualReducaoBCICMS = -1, DBNull.Value, dPercentualReducaoBCICMS) : i += 1

            'Seta Parametros - Percentual de Redução da BC do ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_reducao_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPercentualReducaoBCICMSST = -1, DBNull.Value, dPercentualReducaoBCICMSST) : i += 1

            'Seta Parametros - Situação Tributária PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sSituacaoTributariaPIS = "", DBNull.Value, sSituacaoTributariaPIS) : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaPIS = -1, DBNull.Value, dAliquotaPIS) : i += 1

            'Seta Parametros - Alíquota Valor PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaValorPIS = -1, DBNull.Value, dAliquotaValorPIS) : i += 1

            'Seta Parametros - Situação Tributária COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sSituacaoTributariaCOFINS = "", DBNull.Value, sSituacaoTributariaCOFINS) : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaCOFINS = -1, DBNull.Value, dAliquotaCOFINS) : i += 1

            'Seta Parametros - Alíquota Valor COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaValorCOFINS = -1, DBNull.Value, dAliquotaValorCOFINS) : i += 1

            'Seta Parametros - Alíquota II
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ii"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaII = -1, DBNull.Value, dAliquotaII) : i += 1

            'Seta Parametros - Situação Tributária IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sSituacaoTributariaIPI = "", DBNull.Value, sSituacaoTributariaIPI) : i += 1

            'Seta Parametros - Código Tipo Calculo IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoCalculoIPI = -1, DBNull.Value, iCodigoTipoCalculoIPI) : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaIPI = -1, DBNull.Value, dAliquotaIPI) : i += 1

            'Seta Parametros - Alíquota Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaValorIPI = -1, DBNull.Value, dAliquotaValorIPI) : i += 1

            'Seta Parametros - Mensagem Dados Adicionais - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_dados_adicionais_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sMensagemDadosAdicionaisProduto = "", DBNull.Value, sMensagemDadosAdicionaisProduto) : i += 1

            'Seta Parametros - Mensagem Dados Adicionais - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_dados_adicionais_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sMensagemDadosAdicionaisNotaFiscal = "", DBNull.Value, sMensagemDadosAdicionaisNotaFiscal) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Inserir IPI Outras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inserir_ipi_outras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bInserirIPIOutras : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_enquadramento_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoEnquadramentoIPI : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_fcp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualFCP : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_interestadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaInterestadual : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_imposto_regra", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(37) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Tipo Regra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_regra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoRegra : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoProduto = -1, DBNull.Value, lCodigoProduto) : i += 1

            'Seta Parametros - Codigo Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoParceiroNegocio = -1, DBNull.Value, iCodigoParceiroNegocio) : i += 1

            'Seta Parametros - Codigo CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCFOP : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, iCodigoNCM) : i += 1

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPersonalidade = -1, DBNull.Value, iCodigoPersonalidade) : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoDestinacao = -1, DBNull.Value, iCodigoDestinacao) : i += 1

            'Seta Parametros - UF Destino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUFDestino = "", DBNull.Value, sUFDestino) : i += 1

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoOrigemItem = -1, DBNull.Value, iCodigoOrigemItem) : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoDeposito = -1, DBNull.Value, iCodigoDeposito) : i += 1

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(sSituacaoTributariaICMS = "", DBNull.Value, sSituacaoTributariaICMS) : i += 1

            'Seta Parametros - Modalidade Base Calculo ICMS 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMS = -1, DBNull.Value, iModalidadeBaseCalculoICMS) : i += 1

            'Seta Parametros - Modalidade Base Calculo ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMSST = -1, DBNull.Value, iModalidadeBaseCalculoICMSST) : i += 1

            'Seta Parametros - IVA
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dIVA = -1, DBNull.Value, dIVA) : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMS = -1, DBNull.Value, dAliquotaICMS) : i += 1

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSST = -1, DBNull.Value, dAliquotaICMSST) : i += 1

            'Seta Parametros - Percentual de Redução da BC do ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_reducao_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPercentualReducaoBCICMS = -1, DBNull.Value, dPercentualReducaoBCICMS) : i += 1

            'Seta Parametros - Percentual de Redução da BC do ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_reducao_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPercentualReducaoBCICMSST = -1, DBNull.Value, dPercentualReducaoBCICMSST) : i += 1

            'Seta Parametros - Situação Tributária PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sSituacaoTributariaPIS = "", DBNull.Value, sSituacaoTributariaPIS) : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaPIS = -1, DBNull.Value, dAliquotaPIS) : i += 1

            'Seta Parametros - Alíquota Valor PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaValorPIS = -1, DBNull.Value, dAliquotaValorPIS) : i += 1

            'Seta Parametros - Situação Tributária COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sSituacaoTributariaCOFINS = "", DBNull.Value, sSituacaoTributariaCOFINS) : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaCOFINS = -1, DBNull.Value, dAliquotaCOFINS) : i += 1

            'Seta Parametros - Alíquota Valor COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaValorCOFINS = -1, DBNull.Value, dAliquotaValorCOFINS) : i += 1

            'Seta Parametros - Alíquota II
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ii"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaII = -1, DBNull.Value, dAliquotaII) : i += 1

            'Seta Parametros - Situação Tributária IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sSituacaoTributariaIPI = "", DBNull.Value, sSituacaoTributariaIPI) : i += 1

            'Seta Parametros - Código Tipo Calculo IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoCalculoIPI = -1, DBNull.Value, iCodigoTipoCalculoIPI) : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaIPI = -1, DBNull.Value, dAliquotaIPI) : i += 1

            'Seta Parametros - Alíquota Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaValorIPI = -1, DBNull.Value, dAliquotaValorIPI) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Mensagem Dados Adicionais - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_dados_adicionais_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sMensagemDadosAdicionaisProduto = "", DBNull.Value, sMensagemDadosAdicionaisProduto) : i += 1

            'Seta Parametros - Mensagem Dados Adicionais - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_dados_adicionais_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sMensagemDadosAdicionaisNotaFiscal = "", DBNull.Value, sMensagemDadosAdicionaisNotaFiscal) : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Inserir IPI Outras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inserir_ipi_outras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bInserirIPIOutras : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_enquadramento_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoEnquadramentoIPI : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_fcp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualFCP : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_interestadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaInterestadual : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_imposto_regra", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i, j As Integer

        Try

            For j = 0 To UBound(gSelecaoRow)

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = gSelecaoRow(j).Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Deleta Linha
                gSelecaoRow(j).Delete()

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_imposto_regra", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoTipoRegra As Integer, _
                        ByVal iCodigoCFOP As Integer, _
                        ByVal iCodigoNCM As Integer, _
                        ByVal iCodigoPersonalidade As Integer, _
                        ByVal iCodigoDestinacao As Integer, _
                        ByVal sUFDestino As String, _
                        ByVal iCodigoOrigemItem As Integer, _
                        ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Regra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_regra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoRegra : i += 1

            'Seta Parametros - Codigo CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCFOP : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPersonalidade : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - UF Destino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFDestino : i += 1

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOrigemItem : i += 1

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_imposto_regra", oSqlParameter)

            'Configurar DataMember
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
                             ByVal cboTipoRegra As UIComboBox, _
                             ByVal cboParceiroNegocio As UIComboBox, _
                             ByVal cboProduto As UIComboBox, _
                             ByVal cboCFOP As UIComboBox, _
                             ByVal cboNCM As UIComboBox, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal cboDestinacao As UIComboBox, _
                             ByVal cboUFDestino As UIComboBox, _
                             ByVal cboOrigemItem As UIComboBox, _
                             ByVal cboDeposito As UIComboBox, _
                             ByVal cboSituacaoTributariaICMS As UIComboBox, _
                             ByVal cboModalidadeBaseCalculoICMS As UIComboBox, _
                             ByVal cboModalidadeBaseCalculoICMSST As UIComboBox, _
                             ByVal txtIVA As NumericEditBox, _
                             ByVal txtAliquotaICMS As NumericEditBox, _
                             ByVal txtAliquotaICMSST As NumericEditBox, _
                             ByVal txtPercentualReducaoBCICMS As NumericEditBox, _
                             ByVal txtPercentualReducaoBCICMSST As NumericEditBox, _
                             ByVal cboSituacaoTributariaPIS As UIComboBox, _
                             ByVal txtAliquotaPIS As NumericEditBox, _
                             ByVal txtAliquotaValorPIS As NumericEditBox, _
                             ByVal cboSituacaoTributariaCOFINS As UIComboBox, _
                             ByVal txtAliquotaCOFINS As NumericEditBox, _
                             ByVal txtAliquotaValorCOFINS As NumericEditBox, _
                             ByVal cboSituacaoTributariaIPI As UIComboBox, _
                             ByVal cboTipoCalculoIPI As UIComboBox, _
                             ByVal txtAliquotaIPI As NumericEditBox, _
                             ByVal txtAliquotaII As NumericEditBox, _
                             ByVal txtMensagemDadosAdicionaisProduto As EditBox, _
                             ByVal txtMensagemDadosAdicionaisNotaFiscal As EditBox, _
                             ByVal chkInserirIPIOutras As UICheckBox, _
                             ByVal cboCodigoEnquadramentoIPI As UIComboBox, _
                             ByVal txtPercentualFCP As NumericEditBox, _
                             ByVal txtAliquotaInterestadual As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_imposto_regra_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Controles
                    cboTipoRegra.SelectedValue = oSqlDataReader.Item("codigo_tipo_regra")
                    cboParceiroNegocio.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio")
                    cboProduto.SelectedValue = oSqlDataReader.Item("codigo_produto")
                    cboCFOP.SelectedValue = oSqlDataReader.Item("codigo_cfop")
                    cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")
                    cboUFDestino.SelectedValue = oSqlDataReader.Item("uf_destino")
                    cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
                    cboDeposito.SelectedValue = oSqlDataReader.Item("codigo_deposito")
                    cboSituacaoTributariaICMS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_icms")
                    cboModalidadeBaseCalculoICMS.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms")
                    cboModalidadeBaseCalculoICMSST.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms_st")
                    txtIVA.Value = oSqlDataReader.Item("iva")
                    txtAliquotaICMS.Value = oSqlDataReader.Item("aliquota_icms")
                    txtAliquotaICMSST.Value = oSqlDataReader.Item("aliquota_icms_st")
                    txtPercentualReducaoBCICMS.Value = oSqlDataReader.Item("percentual_reducao_base_calculo_icms")
                    txtPercentualReducaoBCICMSST.Value = oSqlDataReader.Item("percentual_reducao_base_calculo_icms_st")
                    cboSituacaoTributariaPIS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_pis")
                    txtAliquotaPIS.Value = oSqlDataReader.Item("aliquota_pis")
                    txtAliquotaValorPIS.Value = oSqlDataReader.Item("aliquota_valor_pis")
                    cboSituacaoTributariaCOFINS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_cofins")
                    txtAliquotaCOFINS.Value = oSqlDataReader.Item("aliquota_cofins")
                    txtAliquotaValorCOFINS.Value = oSqlDataReader.Item("aliquota_valor_cofins")
                    cboSituacaoTributariaIPI.SelectedValue = oSqlDataReader.Item("situacao_tributaria_ipi")
                    cboTipoCalculoIPI.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_ipi")
                    txtAliquotaIPI.Value = oSqlDataReader.Item("aliquota_ipi")
                    txtAliquotaII.Value = oSqlDataReader.Item("aliquota_ii")
                    txtMensagemDadosAdicionaisProduto.Text = oSqlDataReader.Item("mensagem_dados_adicionais_produto")
                    txtMensagemDadosAdicionaisNotaFiscal.Text = oSqlDataReader.Item("mensagem_dados_adicionais_nota_fiscal")
                    chkInserirIPIOutras.Checked = oSqlDataReader.Item("inserir_ipi_outras")
                    cboCodigoEnquadramentoIPI.SelectedValue = oSqlDataReader.Item("codigo_enquadramento_ipi")
                    txtAliquotaInterestadual.Value = oSqlDataReader.Item("aliquota_interestadual")
                    txtPercentualFCP.Value = oSqlDataReader.Item("percentual_fcp")
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

    Public Function Validacao(ByVal iCodigo As Integer, _
                              ByVal iCodigoTipoRegra As Integer, _
                              ByVal iCodigoParceiroNegocio As Integer, _
                              ByVal lCodigoProduto As Long, _
                              ByVal iCodigoCFOP As Integer, _
                              ByVal iCodigoNCM As Integer, _
                              ByVal iCodigoPersonalidade As Integer, _
                              ByVal iCodigoDestinacao As Integer, _
                              ByVal sUFDestino As String, _
                              ByVal iCodigoOrigemItem As Integer, _
                              ByVal iCodigoDeposito As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            Validacao = False

            'Seta Parametros - Código Tipo Regra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_regra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoRegra : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoProduto = -1, DBNull.Value, lCodigoProduto) : i += 1

            'Seta Parametros - Codigo Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCFOP : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPersonalidade : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - UF Destino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFDestino : i += 1

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOrigemItem : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_imposto_regra", oSqlParameter), Integer)

            'Seta Retorno da Função
            Validacao = IIf(iReturn = 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
