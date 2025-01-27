Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsFrmFatEmissaoNFsPedidoVenda

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadDadosPedidoVenda(ByVal lCodigoPedido As Long, _
                                    ByVal txtCliente As MaskedEditBox, _
                                    ByVal txtCNPJCPF As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_pedido_venda_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCliente.Text = oSqlDataReader.Item("razao_social")
                txtCliente.Tag = oSqlDataReader.Item("codigo")
                txtCNPJCPF.Text = oSqlDataReader.Item("cnpj_cpf")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosPedidoVendaServico(ByVal lCodigoPedido As Long, _
                                           ByVal iCodigoPedidoItem As Integer, _
                                           ByVal txtDescricao As EditBox, _
                                           ByVal txtValorServico As NumericEditBox, _
                                           ByVal txtValorServicoPendente As NumericEditBox, _
                                           ByVal txtCentroCusto As MaskedEditBox, _
                                           ByVal txtContaContabil As MaskedEditBox, _
                                           ByRef dAliquotaISS As Double, _
                                           ByRef bISSRetido As Boolean, _
                                           ByRef dAliquotaPIS As Double, _
                                           ByRef dAliquotaCOFINS As Double, _
                                           ByRef dAliquotaINSS As Double, _
                                           ByRef dAliquotaCSLL As Double, _
                                           ByRef dAliquotaIR As Double, _
                                           ByRef sFormaPagamento As String, _
                                           ByRef iCodigoCondicaoPagamento As Integer, _
                                           ByRef iIntervaloEntreParcelas As Integer, _
                                           ByRef iNumeroParcela As Integer, _
                                           ByRef iCodigoCentroCusto As Integer, _
                                           ByVal sCodigoContaContabil As String, _
                                           ByRef lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido de Venda Inte
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_pedido_venda_item_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtValorServico.Value = oSqlDataReader.Item("valor_servico_pendente")
                txtValorServicoPendente.Value = oSqlDataReader.Item("valor_servico_pendente")
                txtCentroCusto.Text = oSqlDataReader.Item("centro_custo")
                txtContaContabil.Text = oSqlDataReader.Item("conta_contabil")
                dAliquotaISS = oSqlDataReader.Item("aliquota_iss")
                bISSRetido = oSqlDataReader.Item("iss_retido")
                dAliquotaPIS = oSqlDataReader.Item("aliquota_pis")
                dAliquotaCOFINS = oSqlDataReader.Item("aliquota_cofins")
                dAliquotaINSS = oSqlDataReader.Item("aliquota_inss")
                dAliquotaCSLL = oSqlDataReader.Item("aliquota_csll")
                dAliquotaIR = oSqlDataReader.Item("aliquota_ir")
                lCodigoItem = oSqlDataReader.Item("codigo_item")
                sFormaPagamento = oSqlDataReader.Item("forma_pagamento")
                iCodigoCondicaoPagamento = oSqlDataReader.Item("codigo_condicao_pagamento")
                iIntervaloEntreParcelas = oSqlDataReader.Item("intervalo_parcela")
                iNumeroParcela = oSqlDataReader.Item("numero_parcela")
                iCodigoCentroCusto = oSqlDataReader.Item("codigo_centro_custo")
                sCodigoContaContabil = oSqlDataReader.Item("codigo_conta_contabil")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaTipoItem(ByVal iPedido As Integer) As Boolean


        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0
        Dim bResultado As Boolean = False

        Try

            'Seta Parametros - Código Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_tipo_item_servico", oSqlParameter)

            If oSqlDataReader.HasRows Then
                bResultado = True
            Else
                bResultado = False
            End If

            Return bResultado


        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
