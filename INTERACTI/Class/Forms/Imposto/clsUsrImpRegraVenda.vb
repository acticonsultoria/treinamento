Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrImpRegraVenda

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
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
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

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
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

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

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSituacaoTributariaICMS : i += 1

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
            oSqlParameter(i).Value = dIVA : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMSST : i += 1

            'Seta Parametros - Percentual de Redução da BC do ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_reducao_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualReducaoBCICMS : i += 1

            'Seta Parametros - Percentual de Redução da BC do ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_reducao_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualReducaoBCICMSST : i += 1

            'Seta Parametros - Situação Tributária PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sSituacaoTributariaPIS : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Alíquota Valor PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaValorPIS : i += 1

            'Seta Parametros - Situação Tributária COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sSituacaoTributariaCOFINS : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            'Seta Parametros - Alíquota Valor COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaValorCOFINS : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_imposto_regra_venda", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(22) As SqlParameter

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
            oSqlParameter(1).Value = iCodigoCFOP

            'Seta Parametros - Código NCM
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_ncm"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoNCM

            'Seta Parametros - Código Personalidade
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_personalidade"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iCodigoPersonalidade

            'Seta Parametros - Código Destinação
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_destinacao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = iCodigoDestinacao

            'Seta Parametros - UF Destino
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "uf_destino"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 2
            oSqlParameter(5).Value = sUFDestino

            'Seta Parametros - Código Origem Item
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_origem_item"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(6).Value = iCodigoOrigemItem

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Size = 3
            oSqlParameter(7).Value = sSituacaoTributariaICMS

            'Seta Parametros - Modalidade Base Calculo ICMS 
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_modalidade_base_calculo_icms"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(8).Value = IIf(iModalidadeBaseCalculoICMS = -1, DBNull.Value, iModalidadeBaseCalculoICMS)

            'Seta Parametros - Modalidade Base Calculo ICMS ST
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo_modalidade_base_calculo_icms_st"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(9).Value = IIf(iModalidadeBaseCalculoICMSST = -1, DBNull.Value, iModalidadeBaseCalculoICMSST)

            'Seta Parametros - IVA
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "iva"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Float
            oSqlParameter(10).Value = dIVA

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "aliquota_icms"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Float
            oSqlParameter(11).Value = dAliquotaICMS

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "aliquota_icms_st"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Float
            oSqlParameter(12).Value = dAliquotaICMSST

            'Seta Parametros - Percentual de Redução da BC do ICMS
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "percentual_reducao_base_calculo_icms"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Float
            oSqlParameter(13).Value = dPercentualReducaoBCICMS

            'Seta Parametros - Percentual de Redução da BC do ICMS ST
            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "percentual_reducao_base_calculo_icms_st"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.Float
            oSqlParameter(14).Value = dPercentualReducaoBCICMSST

            'Seta Parametros - Situação Tributária PIS
            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "situacao_tributaria_pis"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.VarChar
            oSqlParameter(15).Size = 2
            oSqlParameter(15).Value = sSituacaoTributariaPIS

            'Seta Parametros - Alíquota PIS
            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "aliquota_pis"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.Float
            oSqlParameter(16).Value = dAliquotaPIS

            'Seta Parametros - Alíquota Valor PIS
            oSqlParameter(17) = New SqlParameter
            oSqlParameter(17).ParameterName = "aliquota_valor_pis"
            oSqlParameter(17).Direction = ParameterDirection.Input
            oSqlParameter(17).SqlDbType = SqlDbType.Float
            oSqlParameter(17).Value = dAliquotaValorPIS

            'Seta Parametros - Situação Tributária COFINS
            oSqlParameter(18) = New SqlParameter
            oSqlParameter(18).ParameterName = "situacao_tributaria_cofins"
            oSqlParameter(18).Direction = ParameterDirection.Input
            oSqlParameter(18).SqlDbType = SqlDbType.VarChar
            oSqlParameter(18).Size = 2
            oSqlParameter(18).Value = sSituacaoTributariaCOFINS

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(19) = New SqlParameter
            oSqlParameter(19).ParameterName = "aliquota_cofins"
            oSqlParameter(19).Direction = ParameterDirection.Input
            oSqlParameter(19).SqlDbType = SqlDbType.Float
            oSqlParameter(19).Value = dAliquotaCOFINS

            'Seta Parametros - Alíquota Valor COFINS
            oSqlParameter(20) = New SqlParameter
            oSqlParameter(20).ParameterName = "aliquota_valor_cofins"
            oSqlParameter(20).Direction = ParameterDirection.Input
            oSqlParameter(20).SqlDbType = SqlDbType.Float
            oSqlParameter(20).Value = dAliquotaValorCOFINS

            'Seta Parametros - Código Usuário
            oSqlParameter(21) = New SqlParameter
            oSqlParameter(21).ParameterName = "codigo_usuario"
            oSqlParameter(21).Direction = ParameterDirection.Input
            oSqlParameter(21).SqlDbType = SqlDbType.Int
            oSqlParameter(21).Value = goUsuario.iUsuario

            'Seta Parametros - Código
            oSqlParameter(22) = New SqlParameter
            oSqlParameter(22).ParameterName = "codigo"
            oSqlParameter(22).Direction = ParameterDirection.Input
            oSqlParameter(22).SqlDbType = SqlDbType.Int
            oSqlParameter(22).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_imposto_regra_venda", oSqlParameter)

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_imposto_regra_venda", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoCFOP As Integer, _
                        ByVal iCodigoNCM As Integer, _
                        ByVal iCodigoPersonalidade As Integer, _
                        ByVal iCodigoDestinacao As Integer, _
                        ByVal sUFDestino As String, _
                        ByVal iCodigoOrigemItem As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter

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
            oSqlParameter(1).Value = iCodigoCFOP

            'Seta Parametros - Código NCM
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_ncm"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoNCM

            'Seta Parametros - Código Personalidade
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_personalidade"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iCodigoPersonalidade

            'Seta Parametros - Código Destinação
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_destinacao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = iCodigoDestinacao

            'Seta Parametros - UF Destino
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "uf_destino"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 2
            oSqlParameter(5).Value = sUFDestino

            'Seta Parametros - Código Origem Item
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_origem_item"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(6).Value = iCodigoOrigemItem

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_imposto_regra_venda", oSqlParameter)
            
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
                             ByVal cboNCM As UIComboBox, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal cboDestinacao As UIComboBox, _
                             ByVal cboUFDestino As UIComboBox, _
                             ByVal cboOrigemItem As UIComboBox, _
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
                             ByVal txtAliquotaValorCOFINS As NumericEditBox)

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_imposto_dados_regra_venda", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Controles
                    cboCFOP.SelectedValue = oSqlDataReader.Item("codigo_cfop")
                    cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")
                    cboUFDestino.SelectedValue = oSqlDataReader.Item("uf_destino")
                    cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
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
                              ByVal iCodigoCFOP As Integer, _
                              ByVal iCodigoNCM As Integer, _
                              ByVal iCodigoPersonalidade As Integer, _
                              ByVal iCodigoDestinacao As Integer, _
                              ByVal sUFDestino As String, _
                              ByVal iCodigoOrigemItem As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            Validacao = False

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
            oSqlParameter(1).Value = iCodigoCFOP

            'Seta Parametros - Código NCM
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_ncm"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoNCM

            'Seta Parametros - Código Personalidade
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_personalidade"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iCodigoPersonalidade

            'Seta Parametros - Código Destinação
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_destinacao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = iCodigoDestinacao

            'Seta Parametros - UF Destino
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "uf_destino"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 2
            oSqlParameter(5).Value = sUFDestino

            'Seta Parametros - Código Origem Item
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_origem_item"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(6).Value = iCodigoOrigemItem

            'Seta Parametros - Código
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(7).Value = iCodigo

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_imposto_regra_venda", oSqlParameter), Integer)

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
