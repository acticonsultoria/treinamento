Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsFrmFatEntradaNFProduto

#Region "::: VARIAVEIS :::"

    'Dados do Produto
    Private lCodigoEntradaCapa As Long
    Private iCodigoEntradaItem As Integer
    Private sCodigoProdutoFornecedor As String
    Private sCodigoEAN As String
    Private sDescricao As String
    Private iCodigoCFOP As Integer
    Private sCFOP As String
    Private iCodigoNCM As Integer
    Private sNCM As String
    Private dQuantidade As Double
    Private iCodigoUnidadeMedida As Integer
    Private sUnidadeMedida As String
    Private dValorUnitario As Double
    Private dValorDesconto As Double
    Private dValorFrete As Double
    Private dValorSeguro As Double
    Private dValorOutrasDespesas As Double
    Private dValorTotal As Double
    Private bIncideValorTotalNF As Boolean
    Private sInformacoesAdicionais As String

#End Region

#Region "::: PROPERTIE :::"

#Region "::: PRODUTO :::"

    Public Property CodigoEntradaCapa() As Long
        Get
            Return lCodigoEntradaCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public Property CodigoEntradaItem() As Integer
        Get
            Return iCodigoEntradaItem
        End Get
        Set(ByVal value As Integer)
            iCodigoEntradaItem = value
        End Set
    End Property

    Public Property CodigoProdutoFornecedor() As String
        Get
            Return sCodigoProdutoFornecedor
        End Get
        Set(ByVal value As String)
            sCodigoProdutoFornecedor = value
        End Set
    End Property

    Public Property CodigoEAN() As String
        Get
            Return sCodigoEAN
        End Get
        Set(ByVal value As String)
            sCodigoEAN = value
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

    Public Property CodigoCFOP() As Integer
        Get
            Return iCodigoCFOP
        End Get
        Set(ByVal value As Integer)
            iCodigoCFOP = value
        End Set
    End Property

    Public Property CFOP() As String
        Get
            Return sCFOP
        End Get
        Set(ByVal value As String)
            sCFOP = value
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

    Public Property NCM() As String
        Get
            Return sNCM
        End Get
        Set(ByVal value As String)
            sNCM = value
        End Set
    End Property

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property CodigoUnidadeMedida() As Integer
        Get
            Return iCodigoUnidadeMedida
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedida = value
        End Set
    End Property

    Public Property UnidadeMedida() As String
        Get
            Return sUnidadeMedida
        End Get
        Set(ByVal value As String)
            sUnidadeMedida = value
        End Set
    End Property

    Public Property ValorUnitario() As Double
        Get
            Return dValorUnitario
        End Get
        Set(ByVal value As Double)
            dValorUnitario = value
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

    Public Property ValorFrete() As Double
        Get
            Return dValorFrete
        End Get
        Set(ByVal value As Double)
            dValorFrete = value
        End Set
    End Property

    Public Property ValorSeguro() As Double
        Get
            Return dValorSeguro
        End Get
        Set(ByVal value As Double)
            dValorSeguro = value
        End Set
    End Property

    Public Property ValorOutrasDespesas() As Double
        Get
            Return dValorOutrasDespesas
        End Get
        Set(ByVal value As Double)
            dValorOutrasDespesas = value
        End Set
    End Property

    Public Property ValorTotal() As Double
        Get
            Return dValorTotal
        End Get
        Set(ByVal value As Double)
            dValorTotal = value
        End Set
    End Property

    Public Property IncideValorTotalNF() As Boolean
        Get
            Return bIncideValorTotalNF
        End Get
        Set(ByVal value As Boolean)
            bIncideValorTotalNF = value
        End Set
    End Property

    Public Property InformacoesAdicionais() As String
        Get
            Return sInformacoesAdicionais
        End Get
        Set(ByVal value As String)
            sInformacoesAdicionais = value
        End Set
    End Property

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: PRODUTO :::"

    Public Sub InsertProduto()

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Produto Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProdutoFornecedor : i += 1

            'Seta Parametros - Código EAN
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ean"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sCodigoEAN = "", DBNull.Value, sCodigoEAN) : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCFOP = -1, DBNull.Value, iCodigoCFOP) : i += 1

            'Seta Parametros - CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = IIf(iCodigoCFOP = -1, DBNull.Value, sCFOP) : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, iCodigoNCM) : i += 1

            'Seta Parametros - NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, sNCM) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, iCodigoUnidadeMedida) : i += 1

            'Seta Parametros - Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, sUnidadeMedida) : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor do Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Valor do Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorSeguro : i += 1

            'Seta Parametros - Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOutrasDespesas : i += 1

            'Seta Parametros - Valor Total
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Incide no Valor Total da Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incide_valor_total_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncideValorTotalNF : i += 1

            'Seta Parametros - Informações Adicionais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "informacoes_adicionais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sInformacoesAdicionais = "", DBNull.Value, sInformacoesAdicionais) : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item", oSqlParameter)

            'Seta Código
            iCodigoEntradaItem = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProduto()

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Produto Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProdutoFornecedor : i += 1

            'Seta Parametros - Código EAN
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ean"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sCodigoEAN = "", DBNull.Value, sCodigoEAN) : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCFOP = -1, DBNull.Value, iCodigoCFOP) : i += 1

            'Seta Parametros - CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = IIf(iCodigoCFOP = -1, DBNull.Value, sCFOP) : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, iCodigoNCM) : i += 1

            'Seta Parametros - NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, sNCM) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, iCodigoUnidadeMedida) : i += 1

            'Seta Parametros - Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, sUnidadeMedida) : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor do Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Valor do Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorSeguro : i += 1

            'Seta Parametros - Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOutrasDespesas : i += 1

            'Seta Parametros - Valor Total
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Incide no Valor Total da Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incide_valor_total_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncideValorTotalNF : i += 1

            'Seta Parametros - Informações Adicionais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "informacoes_adicionais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sInformacoesAdicionais = "", DBNull.Value, sInformacoesAdicionais) : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadProduto(ByVal lCodigoEntradaCapa As Long, _
                           ByVal iCodigoEntradaItem As Integer, _
                           ByVal cboCFOP As UIComboBox, _
                           ByVal txtCodigoProdutoFornecedor As MaskedEditBox, _
                           ByVal txtDescricao As MaskedEditBox, _
                           ByVal txtCodigoEAN As MaskedEditBox, _
                           ByVal cboIncideValorTotalNF As UIComboBox, _
                           ByVal cboNCM As UIComboBox, _
                           ByVal txtQuantidade As NumericEditBox, _
                           ByVal cboUnidadeMedida As UIComboBox, _
                           ByVal txtValorUnitario As NumericEditBox, _
                           ByVal txtValorFrete As NumericEditBox, _
                           ByVal txtValorSeguro As NumericEditBox, _
                           ByVal txtOutrasDespesas As NumericEditBox, _
                           ByVal txtValorDesconto As NumericEditBox, _
                           ByVal txtValorTotal As NumericEditBox, _
                           ByVal txtInformacoesAdicionais As EditBox, _
                           ByVal cboSituacaoTributariaICMS As UIComboBox, _
                           ByVal cboOrigemItem As UIComboBox, _
                           ByVal cboModalidadeBCICMS As UIComboBox, _
                           ByVal txtPorcentagemReducaoBCICMS As NumericEditBox, _
                           ByVal txtBaseCalculoICMS As NumericEditBox, _
                           ByVal txtAliquotaICMS As NumericEditBox, _
                           ByVal txtValorICMS As NumericEditBox, _
                           ByVal cboModalidadeBCICMSST As UIComboBox, _
                           ByVal txtIVA As NumericEditBox, _
                           ByVal txtPorcentagemReducaoBCICMSST As NumericEditBox, _
                           ByVal txtBaseCalculoICMSST As NumericEditBox, _
                           ByVal txtAliquotaICMSST As NumericEditBox, _
                           ByVal txtBaseCalculoICMSSTRetido As NumericEditBox, _
                           ByVal txtValorICMSSTRetido As NumericEditBox, _
                           ByVal cboSituacaoTributariaICMSSimples As UIComboBox, _
                           ByVal cboOrigemItemSimples As UIComboBox, _
                           ByVal txtAliquotaCalculoCredito As NumericEditBox, _
                           ByVal txtCreditoICMSAproveitado As NumericEditBox, _
                           ByVal cboModalidadeBCICMSSimples As UIComboBox, _
                           ByVal txtPorcentagemReducaoBCICMSSimples As NumericEditBox, _
                           ByVal txtBaseCalculoICMSSimples As NumericEditBox, _
                           ByVal txtAliquotaICMSSimples As NumericEditBox, _
                           ByVal txtValorICMSSimples As NumericEditBox, _
                           ByVal cboModalidadeBCICMSSTSimples As UIComboBox, _
                           ByVal txtIVASimples As NumericEditBox, _
                           ByVal txtPorcentagemReducaoBCICMSSTSimples As NumericEditBox, _
                           ByVal txtBaseCalculoICMSSTSimples As NumericEditBox, _
                           ByVal txtAliquotaICMSSTSimples As NumericEditBox, _
                           ByVal txtBaseCalculoICMSSTRetidoSimples As NumericEditBox, _
                           ByVal txtValorICMSSTRetidoSimples As NumericEditBox, _
                           ByVal cboSituacaoTributariaIPI As UIComboBox, _
                           ByVal cboTipoCalculoIPI As UIComboBox, _
                           ByVal txtBaseCalculoIPI As NumericEditBox, _
                           ByVal txtAliquotaIPI As NumericEditBox, _
                           ByVal txtQuantidadeIPI As NumericEditBox, _
                           ByVal txtValorUnidadeIPI As NumericEditBox, _
                           ByVal txtValorIPI As NumericEditBox, _
                           ByVal cboSituacaoTributariaPIS As UIComboBox, _
                           ByVal cboTipoCalculoPIS As UIComboBox, _
                           ByVal txtBaseCalculoPIS As NumericEditBox, _
                           ByVal txtAliquotaPercentualPIS As NumericEditBox, _
                           ByVal txtAliquotaValorPIS As NumericEditBox, _
                           ByVal txtQuantidadeVendidaPIS As NumericEditBox, _
                           ByVal txtValorPIS As NumericEditBox, _
                           ByVal cboSituacaoTributariaCOFINS As UIComboBox, _
                           ByVal cboTipoCalculoCOFINS As UIComboBox, _
                           ByVal txtBaseCalculoCOFINS As NumericEditBox, _
                           ByVal txtAliquotaPercentualCOFINS As NumericEditBox, _
                           ByVal txtAliquotaValorCOFINS As NumericEditBox, _
                           ByVal txtQuantidadeVendidaCOFINS As NumericEditBox, _
                           ByVal txtValorCOFINS As NumericEditBox, _
                           ByVal txtBaseCalculoII As NumericEditBox, _
                           ByVal txtDespesaAduaneiraII As NumericEditBox, _
                           ByVal txtValorIOF As NumericEditBox, _
                           ByVal txtValorII As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles - Dados Gerais
                cboCFOP.SelectedValue = oSqlDataReader.Item("codigo_cfop")
                txtCodigoProdutoFornecedor.Text = oSqlDataReader.Item("codigo_produto_fornecedor")
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtCodigoEAN.Text = oSqlDataReader.Item("codigo_ean")
                cboIncideValorTotalNF.SelectedValue = oSqlDataReader.Item("incide_valor_total_nota_fiscal")
                cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                cboUnidadeMedida.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida")
                txtValorUnitario.Value = oSqlDataReader.Item("valor_unitario")
                txtValorFrete.Text = oSqlDataReader.Item("valor_frete")
                txtValorSeguro.Text = oSqlDataReader.Item("valor_seguro")
                txtOutrasDespesas.Text = oSqlDataReader.Item("valor_outras_despesas")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtValorTotal.Value = oSqlDataReader.Item("valor_total")
                txtInformacoesAdicionais.Text = oSqlDataReader.Item("informacoes_adicionais")

                'Carrega Controles - ICMS
                cboSituacaoTributariaICMS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_icms")
                cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
                cboModalidadeBCICMS.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms")
                txtPorcentagemReducaoBCICMSST.Value = oSqlDataReader.Item("porcentagem_reducao_base_calculo")
                txtBaseCalculoICMS.Value = oSqlDataReader.Item("base_calculo_icms")
                txtAliquotaICMS.Value = oSqlDataReader.Item("aliquota_icms")
                txtValorICMS.Value = oSqlDataReader.Item("valor_icms")
                cboModalidadeBCICMSST.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms_st")
                txtIVA.Value = oSqlDataReader.Item("iva")
                txtPorcentagemReducaoBCICMSST.Value = oSqlDataReader.Item("porcentagem_reducao_base_calculo_st")
                txtBaseCalculoICMSST.Value = oSqlDataReader.Item("base_calculo_icms_st")
                txtAliquotaICMSST.Value = oSqlDataReader.Item("aliquota_icms_st")
                txtBaseCalculoICMSSTRetido.Value = oSqlDataReader.Item("base_calculo_icms_st_retido")
                txtValorICMSSTRetido.Value = oSqlDataReader.Item("valor_icms_st_retido")

                'Carrega Controles - ICMS - SIMPLES
                cboSituacaoTributariaICMSSimples.SelectedValue = oSqlDataReader.Item("situacao_tributaria_icms_simples")
                cboOrigemItemSimples.SelectedValue = oSqlDataReader.Item("codigo_origem_item_simples")
                txtAliquotaCalculoCredito.Value = oSqlDataReader.Item("aliquota_calculo_credito_simples")
                txtCreditoICMSAproveitado.Value = oSqlDataReader.Item("credito_icms_aproveitado_simples")
                cboModalidadeBCICMSSimples.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms_simples")
                txtPorcentagemReducaoBCICMSSTSimples.Value = oSqlDataReader.Item("porcentagem_reducao_base_calculo_simples")
                txtBaseCalculoICMSSimples.Value = oSqlDataReader.Item("base_calculo_icms_simples")
                txtAliquotaICMSSimples.Value = oSqlDataReader.Item("aliquota_icms_simples")
                txtValorICMSSimples.Value = oSqlDataReader.Item("valor_icms_simples")
                cboModalidadeBCICMSSTSimples.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms_st_simples")
                txtIVASimples.Value = oSqlDataReader.Item("iva_simples")
                txtPorcentagemReducaoBCICMSSTSimples.Value = oSqlDataReader.Item("porcentagem_reducao_base_calculo_st_simples")
                txtBaseCalculoICMSSTSimples.Value = oSqlDataReader.Item("base_calculo_icms_st_simples")
                txtAliquotaICMSSTSimples.Value = oSqlDataReader.Item("aliquota_icms_st_simples")
                txtBaseCalculoICMSSTRetidoSimples.Value = oSqlDataReader.Item("base_calculo_icms_st_retido_simples")
                txtValorICMSSTRetidoSimples.Value = oSqlDataReader.Item("valor_icms_st_retido_simples")

                'Carrega Controles - IPI
                cboSituacaoTributariaIPI.SelectedValue = oSqlDataReader.Item("situacao_tributaria_ipi")
                cboTipoCalculoIPI.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_ipi")
                txtBaseCalculoIPI.Value = oSqlDataReader.Item("base_calculo_ipi")
                txtAliquotaIPI.Value = oSqlDataReader.Item("aliquota_ipi")
                txtQuantidadeIPI.Value = oSqlDataReader.Item("quantidade_total_unidade_padrao_ipi")
                txtValorUnidadeIPI.Value = oSqlDataReader.Item("valor_unidade_ipi")
                txtValorIPI.Value = oSqlDataReader.Item("valor_ipi")

                'Carrega Controles - PIS
                cboSituacaoTributariaPIS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_pis")
                cboTipoCalculoPIS.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_pis")
                txtBaseCalculoPIS.Value = oSqlDataReader.Item("base_calculo_pis")
                txtAliquotaPercentualPIS.Value = oSqlDataReader.Item("aliquota_percentual_pis")
                txtAliquotaValorPIS.Value = oSqlDataReader.Item("aliquota_valor_pis")
                txtQuantidadeVendidaPIS.Value = oSqlDataReader.Item("quantidade_vendida_pis")
                txtValorPIS.Value = oSqlDataReader.Item("valor_pis")

                'Carrega Controles - COFINS
                cboSituacaoTributariaCOFINS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_cofins")
                cboTipoCalculoCOFINS.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_cofins")
                txtBaseCalculoCOFINS.Value = oSqlDataReader.Item("base_calculo_cofins")
                txtAliquotaPercentualCOFINS.Value = oSqlDataReader.Item("aliquota_percentual_cofins")
                txtAliquotaValorCOFINS.Value = oSqlDataReader.Item("aliquota_valor_cofins")
                txtQuantidadeVendidaCOFINS.Value = oSqlDataReader.Item("quantidade_vendida_cofins")
                txtValorCOFINS.Value = oSqlDataReader.Item("valor_cofins")

                'Carrega Controles - II
                txtBaseCalculoII.Value = oSqlDataReader.Item("base_calculo_ii")
                txtDespesaAduaneiraII.Value = oSqlDataReader.Item("despesa_aduaneira")
                txtValorIOF.Value = oSqlDataReader.Item("valor_iof")
                txtValorII.Value = oSqlDataReader.Item("valor_ii")

            End While

            'Fecha o oSqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Public Sub InsertEstoque(ByVal iCodigoTipoOperacao As Integer, _
                             ByVal sNumeroDocumento As String, _
                             ByVal lCodigoPedido As Long, _
                             ByVal iCodigoPedidoItem As Integer, _
                             ByVal iCodigoPedidoItemEntrega As Integer, _
                             ByVal lCodigoEmissaoCapa As Long, _
                             ByVal iCodigoEmissaoItem As Integer, _
                             ByVal lCodigoOrdemProducao As Long, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidade As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dQuantidadeEstoque As Double, _
                             ByVal iCodigoDeposito As Integer, _
                             ByVal sLote As String, _
                             ByVal sDataFabricacao As String, _
                             ByVal sDataValidade As String, _
                             ByVal sOCCapa As String, _
                             ByVal sOCLinha As String, _
                             ByVal bControlaQualidade As Boolean, _
                             ByVal lCodigoEntradaCapa As Long, _
                             ByVal iCodigoEntradaItem As Integer, _
                             ByVal iStatus As StatusFaturamentoEntradaRecebimento)

        'Variaveis Locais
        Dim oSqlParameter(23) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Código Tipo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sNumeroDocumento = "", DBNull.Value, sNumeroDocumento) : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, iCodigoUnidadeMedida) : i += 1

            'Seta Parametros - Fator Conversão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadeEstoque = -1, DBNull.Value, dQuantidadeEstoque / dQuantidade) : i += 1

            'Seta Parametros - Quantidade Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadeEstoque = -1, DBNull.Value, dQuantidadeEstoque) : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoDeposito = -1, DBNull.Value, iCodigoDeposito) : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            'Seta Parametros - Data de Fabricação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataFabricacao), sDataFabricacao, DBNull.Value) : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade), sDataValidade, DBNull.Value) : i += 1

            'Seta Parametros - OC Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "oc_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sOCCapa = "", DBNull.Value, sOCCapa) : i += 1

            'Seta Parametros - OC Linha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "oc_linha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sOCLinha = "", DBNull.Value, sOCLinha) : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedido = 0, DBNull.Value, lCodigoPedido) : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItem = 0, DBNull.Value, iCodigoPedidoItem) : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItemEntrega = 0, DBNull.Value, iCodigoPedidoItemEntrega) : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEmissaoCapa = 0, DBNull.Value, lCodigoEmissaoCapa) : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEmissaoItem = 0, DBNull.Value, iCodigoEmissaoItem) : i += 1

            'Seta Parametros - Código Ordem de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoOrdemProducao = 0, DBNull.Value, lCodigoOrdemProducao) : i += 1

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bControlaQualidade : i += 1

            'Seta Parametros - Status Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status_compras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_lote", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateEstoque(ByVal iCodigoTipoOperacao As Integer, _
                             ByVal sNumeroDocumento As String, _
                             ByVal lCodigoPedido As Long, _
                             ByVal iCodigoPedidoItem As Integer, _
                             ByVal iCodigoPedidoItemEntrega As Integer, _
                             ByVal lCodigoEmissaoCapa As Long, _
                             ByVal iCodigoEmissaoItem As Integer, _
                             ByVal lCodigoOrdemProducao As Long, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidade As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dQuantidadeEstoque As Double, _
                             ByVal iCodigoDeposito As Integer, _
                             ByVal sLote As String, _
                             ByVal sDataFabricacao As String, _
                             ByVal sDataValidade As String, _
                             ByVal sOCCapa As String, _
                             ByVal sOCLinha As String, _
                             ByVal bControlaQualidade As Boolean, _
                             ByVal lCodigoEntradaCapa As Long, _
                             ByVal iCodigoEntradaItem As Integer, _
                             ByVal iCodigo As Integer, _
                             ByVal iStatus As StatusFaturamentoEntradaRecebimento)

        'Variaveis Locais
        Dim oSqlParameter(24) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Tipo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sNumeroDocumento = "", DBNull.Value, sNumeroDocumento) : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, iCodigoUnidadeMedida) : i += 1

            'Seta Parametros - Fator Conversão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadeEstoque = -1, DBNull.Value, dQuantidadeEstoque / dQuantidade) : i += 1

            'Seta Parametros - Quantidade Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadeEstoque = -1, DBNull.Value, dQuantidadeEstoque) : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoDeposito = -1, DBNull.Value, iCodigoDeposito) : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            'Seta Parametros - Data de Fabricação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataFabricacao), sDataFabricacao, DBNull.Value) : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade), sDataValidade, DBNull.Value) : i += 1

            'Seta Parametros - OC Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "oc_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sOCCapa = "", DBNull.Value, sOCCapa) : i += 1

            'Seta Parametros - OC Linha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "oc_linha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sOCLinha = "", DBNull.Value, sOCLinha) : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedido = 0, DBNull.Value, lCodigoPedido) : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItem = 0, DBNull.Value, iCodigoPedidoItem) : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItemEntrega = 0, DBNull.Value, iCodigoPedidoItemEntrega) : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEmissaoCapa = 0, DBNull.Value, lCodigoEmissaoCapa) : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEmissaoItem = 0, DBNull.Value, iCodigoEmissaoItem) : i += 1

            'Seta Parametros - Código Ordem de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoOrdemProducao = 0, DBNull.Value, lCodigoOrdemProducao) : i += 1

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bControlaQualidade : i += 1

            'Seta Parametros - Status Compras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status_compras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_item_lote", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEstoque(ByVal lCodigoEntradaCapa As Long, _
                             ByVal iCodigoEntradaItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Entrada Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_item_lote", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridEstoque(ByVal lCodigoEntradaCapa As Long, _
                               ByVal iCodigoEntradaItem As Integer, _
                               ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_item_lote", oSqlParameter)

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

    Public Sub LoadDadosProduto(ByVal iCodigoTipoOperacao As Integer, _
                                ByVal lCodigoItem As Long, _
                                ByVal lCodigoEntradaCapa As Long, _
                                ByVal iCodigoEntradaItem As Integer, _
                                ByVal iCodigoEntradaItemLote As Integer, _
                                ByVal sOperacao As String, _
                                ByVal lCodigoPedido As Long, _
                                ByVal iCodigoPedidoItem As Integer, _
                                ByVal iCodigoPedidoItemEntrega As Integer, _
                                ByVal lCodigoEmissaoCapa As Long, _
                                ByVal iCodigoEmissaoItem As Integer, _
                                ByRef iCodigoUnidadeMedida As Integer, _
                                ByRef bItemEstoque As Boolean, _
                                ByRef bQualidade As Boolean, _
                                ByRef bLote As Boolean, _
                                ByRef bDataFabricacao As Boolean, _
                                ByRef bDataValidade As Boolean, _
                                ByRef dQuantidadePedido As Double, _
                                ByRef dQuantidadePendente As Double, _
                                ByRef dValorUnitario As Double, _
                                ByRef dFatorConversao As Double, _
                                ByRef sUnidadeMedida As String, _
                                ByRef dToleranciaQuantidade As Double, _
                                ByRef dToleranciaValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Código Entrada Item Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItemLote : i += 1

            'Seta Parametros - Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sOperacao : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItemEntrega : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_dados_produto", oSqlParameter)

            While oSqlDataReader.Read

                'Seta Váriaveis
                iCodigoUnidadeMedida = oSqlDataReader.Item("codigo_unidade_medida")
                bQualidade = oSqlDataReader.Item("controla_qualidade")
                lCodigoItem = oSqlDataReader.Item("codigo_item")
                bItemEstoque = oSqlDataReader.Item("item_estoque")
                bLote = oSqlDataReader.Item("controla_lote")
                bDataFabricacao = oSqlDataReader.Item("controla_data_fabricacao")
                bDataValidade = oSqlDataReader.Item("controla_validade")
                dQuantidadePedido = oSqlDataReader.Item("quantidade_pedido")
                dQuantidadePendente = oSqlDataReader.Item("quantidade_pendente")
                dValorUnitario = oSqlDataReader.Item("valor_unitario")
                dFatorConversao = oSqlDataReader.Item("fator_conversao")
                sUnidadeMedida = oSqlDataReader.Item("unidade_medida")
                dToleranciaQuantidade = oSqlDataReader.Item("tolerancia_quantidade")
                dToleranciaValor = oSqlDataReader.Item("tolerancia_valor")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: IMPOSTOS :::"

    Public Sub InsertImpostoICMS(ByVal lCodigoEntradaCapa As Long, _
                                 ByVal iCodigoEntradaItem As Integer, _
                                 ByVal sSituacaoTributariaICMS As String, _
                                 ByVal iCodigoOrigemItem As Integer, _
                                 ByVal iModalidadeBaseCalculoICMS As Integer, _
                                 ByVal dPorcentagemReducaoBaseCalculoICMS As Double, _
                                 ByVal dBaseCalculoICMS As Double, _
                                 ByVal dAliquotaICMS As Double, _
                                 ByVal dValorICMS As Double, _
                                 ByVal iModalidadeBaseCalculoICMSST As Integer, _
                                 ByVal dIVA As Double, _
                                 ByVal dPorcentagemReducaoBaseCalculoICMSST As Double, _
                                 ByVal dBaseCalculoICMSST As Double, _
                                 ByVal dAliquotaICMSST As Double, _
                                 ByVal dValorICMSST As Double, _
                                 ByVal dBaseCalculoICMSSTRetido As Double, _
                                 ByVal dValorICMSSTRetido As Double)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSituacaoTributariaICMS : i += 1

            'Seta Parametros - Código Origem do Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOrigemItem : i += 1

            'Seta Parametros - Código Modadelida Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMS = -1, DBNull.Value, iModalidadeBaseCalculoICMS) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPorcentagemReducaoBaseCalculoICMS > 0, dPorcentagemReducaoBaseCalculoICMS, DBNull.Value) : i += 1

            'Seta Parametros - Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMS > 0, dBaseCalculoICMS, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMS > 0, dAliquotaICMS, DBNull.Value) : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMS > 0, dValorICMS, DBNull.Value) : i += 1

            'Seta Parametros - Código Modalidade Base Cálculo ICMS ST
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
            oSqlParameter(i).Value = IIf(dIVA > 0, dIVA, DBNull.Value) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPorcentagemReducaoBaseCalculoICMSST > 0, dPorcentagemReducaoBaseCalculoICMSST, DBNull.Value) : i += 1

            'Seta Parametros - Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMSST > 0, dBaseCalculoICMSST, DBNull.Value) : i += 1

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSST > 0, dAliquotaICMSST, DBNull.Value) : i += 1

            'Seta Parametros - Valor ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSST > 0, dValorICMSST, DBNull.Value) : i += 1

            'Seta Parametros - Base de Cálculo ICMS ST - Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms_st_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSST > 0, dAliquotaICMSST, DBNull.Value) : i += 1

            'Seta Parametros - Valor ICMS ST - Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms_st_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSST > 0, dValorICMSST, DBNull.Value)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_icms", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoICMSSimples(ByVal lCodigoEntradaCapa As Long, _
                                        ByVal iCodigoEntradaItem As Integer, _
                                        ByVal sSituacaoTributariaICMSSimples As String, _
                                        ByVal iCodigoOrigemItemSimples As Integer, _
                                        ByVal dAliquotaCalculoCreditoSimples As Double, _
                                        ByVal dCreditoICMSAproveitadoSimples As Double, _
                                        ByVal iModalidadeBaseCalculoICMSSimples As Integer, _
                                        ByVal dPorcentagemReducaoBaseCalculoICMSSimples As Double, _
                                        ByVal dBaseCalculoICMSSimples As Double, _
                                        ByVal dAliquotaICMSSimples As Double, _
                                        ByVal dValorICMSSimples As Double, _
                                        ByVal iModalidadeBaseCalculoICMSSTSimples As Integer, _
                                        ByVal dIVASimples As Double, _
                                        ByVal dPorcentagemReducaoBaseCalculoICMSSTSimples As Double, _
                                        ByVal dBaseCalculoICMSSTSimples As Double, _
                                        ByVal dAliquotaICMSSTSimples As Double, _
                                        ByVal dValorICMSSTSimples As Double, _
                                        ByVal dBaseCalculoICMSSTRetidoSimples As Double, _
                                        ByVal dValorICMSSTRetidoSimples As Double)

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSituacaoTributariaICMSSimples : i += 1

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOrigemItemSimples : i += 1

            'Seta Parametros - Alíquota Calculo do Crédito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_calculo_credito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCalculoCreditoSimples : i += 1

            'Seta Parametros - Crédito do ICMS Aproveitado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "credito_icms_aproveitado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCreditoICMSAproveitadoSimples : i += 1

            'Seta Parametros - Código Modadelida Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMSSimples = -1, DBNull.Value, iModalidadeBaseCalculoICMSSimples) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPorcentagemReducaoBaseCalculoICMSSimples > 0, dPorcentagemReducaoBaseCalculoICMSSimples, DBNull.Value) : i += 1

            'Seta Parametros - Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMSSimples > 0, dBaseCalculoICMSSimples, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSSimples > 0, dAliquotaICMSSimples, DBNull.Value) : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSSimples > 0, dValorICMSSimples, DBNull.Value) : i += 1

            'Seta Parametros - Código Modalidade Base Cálculo ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMSSTSimples = -1, DBNull.Value, iModalidadeBaseCalculoICMSSTSimples) : i += 1

            'Seta Parametros - IVA
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dIVASimples > 0, dIVASimples, DBNull.Value) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPorcentagemReducaoBaseCalculoICMSSTSimples > 0, dPorcentagemReducaoBaseCalculoICMSSTSimples, DBNull.Value) : i += 1

            'Seta Parametros - Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMSSTSimples > 0, dBaseCalculoICMSSTSimples, DBNull.Value) : i += 1

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSSTSimples > 0, dAliquotaICMSSTSimples, DBNull.Value) : i += 1

            'Seta Parametros - Valor ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSSTSimples > 0, dValorICMSSTSimples, DBNull.Value) : i += 1

            'Seta Parametros - Base de Calculo do ICMS ST Retido Anteiormente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms_st_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMSSTRetidoSimples > 0, dBaseCalculoICMSSTRetidoSimples, DBNull.Value) : i += 1

            'Seta Parametros - Valor do ICMS ST Retido Anteiormente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms_st_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSSTRetidoSimples > 0, dValorICMSSTRetidoSimples, DBNull.Value)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_icms_simples", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoIPI(ByVal lCodigoEntradaCapa As Long, _
                                ByVal iCodigoEntradaItem As Integer, _
                                ByVal sClasseEnquadramentoIPI As String, _
                                ByVal sCNPJProdutorIPI As String, _
                                ByVal sCodigoSeloControleIPI As String, _
                                ByVal lQuantidadeSeloControleIPI As Long, _
                                ByVal sCodigoEnquadramentoIPI As String, _
                                ByVal sSituacaoTributariaIPI As String, _
                                ByVal iTipoCalculoIPI As Integer, _
                                ByVal dBaseCalculoIPI As Double, _
                                ByVal dAliquotaIPI As Double, _
                                ByVal dQuantidadeTotalUnidadePadraoIPI As Double, _
                                ByVal dValorUnidadeIPI As Double, _
                                ByVal dValorIPI As Double)

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Classe Enquadramento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "classe_enquadramento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = IIf(sClasseEnquadramentoIPI = "", DBNull.Value, sClasseEnquadramentoIPI) : i += 1

            'Seta Parametros - CNPJ Produtor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_produtor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCNPJProdutorIPI = "", DBNull.Value, sCNPJProdutorIPI) : i += 1

            'Seta Parametros - Código Selo Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_selo_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sCodigoSeloControleIPI = "", DBNull.Value, sCodigoSeloControleIPI) : i += 1

            'Seta Parametros - Quantidade Selo Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_selo_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lQuantidadeSeloControleIPI = -1, DBNull.Value, lQuantidadeSeloControleIPI) : i += 1

            'Seta Parametros - Código Enquadramento IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_enquadramento_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(sCodigoEnquadramentoIPI = "", DBNull.Value, sCodigoEnquadramentoIPI) : i += 1

            'Seta Parametros - Situação Tributária IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sSituacaoTributariaIPI : i += 1

            'Seta Parametros - Código Tipo Cálculo de Imposto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_imposto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iTipoCalculoIPI = -1, DBNull.Value, iTipoCalculoIPI) : i += 1

            'Seta Parametros - Base Cálculo IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoIPI = TipoCalculoImposto.Valor, DBNull.Value, dBaseCalculoIPI) : i += 1

            'Seta Parametros - Aliquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoIPI = TipoCalculoImposto.Valor, DBNull.Value, dAliquotaIPI) : i += 1

            'Seta Parametros - Quantidade Total Unidade Padrão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_total_unidade_padrao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoIPI = TipoCalculoImposto.Percentual, DBNull.Value, dQuantidadeTotalUnidadePadraoIPI) : i += 1

            'Seta Parametros - Valor Unidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoIPI = TipoCalculoImposto.Percentual, DBNull.Value, dValorUnidadeIPI) : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIPI

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_ipi", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoPIS(ByVal lCodigoEntradaCapa As Long, _
                                ByVal iCodigoEntradaItem As Integer, _
                                ByVal sSituacaoTributariaPIS As String, _
                                ByVal iTipoCalculoPIS As Integer, _
                                ByVal dBaseCalculoPIS As Double, _
                                ByVal dAliquotaPorcentagemPIS As Double, _
                                ByVal dAliquotaValorPIS As Double, _
                                ByVal dQuantidadeVendidaPIS As Double, _
                                ByVal dValorPIS As Double, _
                                ByVal iTipoCalculoPISST As Integer, _
                                ByVal dBaseCalculoPISST As Double, _
                                ByVal dAliquotaPorcentagemPISST As Double, _
                                ByVal dAliquotaValorPISST As Double, _
                                ByVal dQuantidadeVendidaPISST As Double, _
                                ByVal dValorPISST As Double)

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Situação Tributária PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sSituacaoTributariaPIS : i += 1

            'Seta Parametros - Código Tipo Cálculo Imposto PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_imposto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iTipoCalculoPIS = -1, DBNull.Value, iTipoCalculoPIS) : i += 1

            'Seta Parametros - Base Cálculo PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoPIS = TipoCalculoImposto.Percentual, dBaseCalculoPIS, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota (%)
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_percentual_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoPIS = TipoCalculoImposto.Percentual, dAliquotaPorcentagemPIS, DBNull.Value) : i += 1

            'Seta Parametros - Quantidade Vendida PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_vendida_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoPIS = TipoCalculoImposto.Valor, dQuantidadeVendidaPIS, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota (Valor)
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoPIS = TipoCalculoImposto.Valor, dAliquotaValorPIS, DBNull.Value) : i += 1

            'Seta Parametros - Valor PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPIS : i += 1

            'Seta Parametros - Código Tipo Cálculo Imposto PIS - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_imposto_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iTipoCalculoPISST = -1, DBNull.Value, iTipoCalculoPISST) : i += 1

            'Seta Parametros - Base Cálculo PIS - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_pis_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoPISST = TipoCalculoImposto.Percentual, dBaseCalculoPISST, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota (%) - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_percentual_pis_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoPISST = TipoCalculoImposto.Percentual, dAliquotaPorcentagemPISST, DBNull.Value) : i += 1

            'Seta Parametros - Quantidade Vendida PIS - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_vendida_pis_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoPISST = TipoCalculoImposto.Valor, dQuantidadeVendidaPISST, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota (Valor) - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_pis_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoPISST = TipoCalculoImposto.Valor, dAliquotaValorPISST, DBNull.Value) : i += 1

            'Seta Parametros - Valor PIS - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPISST

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_pis", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoCOFINS(ByVal lCodigoEntradaCapa As Long, _
                                   ByVal iCodigoEntradaItem As Integer, _
                                   ByVal sSituacaoTributariaCOFINS As String, _
                                   ByVal iTipoCalculoCOFINS As Integer, _
                                   ByVal dBaseCalculoCOFINS As Double, _
                                   ByVal dAliquotaPorcentagemCOFINS As Double, _
                                   ByVal dAliquotaValorCOFINS As Double, _
                                   ByVal dQuantidadeVendidaCOFINS As Double, _
                                   ByVal dValorCOFINS As Double, _
                                   ByVal iTipoCalculoCOFINSST As Integer, _
                                   ByVal dBaseCalculoCOFINSST As Double, _
                                   ByVal dAliquotaPorcentagemCOFINSST As Double, _
                                   ByVal dAliquotaValorCOFINSST As Double, _
                                   ByVal dQuantidadeVendidaCOFINSST As Double, _
                                   ByVal dValorCOFINSST As Double)

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Situação Tributária COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sSituacaoTributariaCOFINS : i += 1

            'Seta Parametros - Código Tipo Cálculo Imposto COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_imposto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINS = -1, DBNull.Value, iTipoCalculoCOFINS) : i += 1

            'Seta Parametros - Base Cálculo COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINS = TipoCalculoImposto.Percentual, dBaseCalculoCOFINS, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota (%)
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_percentual_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINS = TipoCalculoImposto.Percentual, dAliquotaPorcentagemCOFINS, DBNull.Value) : i += 1

            'Seta Parametros - Quantidade Vendida COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_vendida_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINS = TipoCalculoImposto.Valor, dQuantidadeVendidaCOFINS, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota (Valor)
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINS = TipoCalculoImposto.Valor, dAliquotaValorCOFINS, DBNull.Value) : i += 1

            'Seta Parametros - Valor COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCOFINS : i += 1

            'Seta Parametros - Código Tipo Cálculo Imposto COFINS - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_imposto_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINSST = -1, DBNull.Value, iTipoCalculoCOFINSST) : i += 1

            'Seta Parametros - Base Cálculo COFINS - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_cofins_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINSST = TipoCalculoImposto.Percentual, dBaseCalculoCOFINSST, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota (%) - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_percentual_cofins_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINSST = TipoCalculoImposto.Percentual, dAliquotaPorcentagemCOFINSST, DBNull.Value) : i += 1

            'Seta Parametros - Quantidade Vendida COFINS - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_vendida_cofins_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINSST = TipoCalculoImposto.Valor, dQuantidadeVendidaCOFINSST, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota (Valor) - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_cofins_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINSST = TipoCalculoImposto.Valor, dAliquotaValorCOFINSST, DBNull.Value) : i += 1

            'Seta Parametros - Valor COFINS - ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_cofins_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCOFINSST

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_cofins", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoII(ByVal lCodigoEntradaCapa As Long, _
                               ByVal iCodigoEntradaItem As Integer, _
                               ByVal dBaseCalculoII As Double, _
                               ByVal dDespesaAduaneira As Double, _
                               ByVal dValorIOF As Double, _
                               ByVal dValorII As Double)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Base Cálculo II
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculoII : i += 1

            'Seta Parametros - Despesas Aduaneiras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "despesa_aduaneira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDespesaAduaneira : i += 1

            'Seta Parametros - Valor IOF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_iof"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIOF : i += 1

            'Seta Parametros - Valor II
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ii"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorII

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_ii", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
