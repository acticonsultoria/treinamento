Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports INTERACTI.SQLHelper
Imports INTERACTI.OleDbHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrVenEmbraer2

#Region "::: FUNCTION / SUB :::"

#Region "::: PEDIDO VENDA :::"

    Public Sub LoadControles(ByVal iCodigoTipoPlanilha As Integer, _
                             ByVal cboColunaPO As UIComboBox, _
                             ByVal cboColunaPOLinha As UIComboBox, _
                             ByVal cboColunaCodigoEmbraer As UIComboBox, _
                             ByVal cboColunaCodigoItem As UIComboBox, _
                             ByVal cboColunaNCM As UIComboBox, _
                             ByVal cboColunaDescricao As UIComboBox, _
                             ByVal cboColunaPrevisaoEntrega As UIComboBox, _
                             ByVal cboColunaPrioridade As UIComboBox, _
                             ByVal cboColunaQuantidade As UIComboBox, _
                             ByVal cboColunaUnidadeMedida As UIComboBox, _
                             ByVal cboColunaValorUnitario As UIComboBox, _
                             ByVal cboColunaCentro As UIComboBox, _
                             ByVal cboColunaIPIDestacado As UIComboBox, _
                             ByVal cboColunaBaseCalculoICMS As UIComboBox, _
                             ByVal cboColunaAliquotaICMS As UIComboBox, _
                             ByVal cboColunaValorUnitarioICMS As UIComboBox, _
                             ByVal cboColunaBaseCalculoIPI As UIComboBox, _
                             ByVal cboColunaAliquotaIPI As UIComboBox, _
                             ByVal cboColunaValorUnitarioIPI As UIComboBox, _
                             ByVal cboColunaValorTotal As UIComboBox, _
                             ByVal txtLinhaInicio As NumericEditBox, _
                             ByVal txtPlanilha As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Tipo Planilja
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_planilha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoPlanilha : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importacao_pedido_venda_embraer2", oSqlParameter)

            'Verifica se foi encontrado algum Registro
            If oSqlDataReader.HasRows = False Then

                'Limpa Controles
                cboColunaPO.Text = ""
                cboColunaPOLinha.Text = ""
                cboColunaCodigoEmbraer.Text = ""
                cboColunaCodigoItem.Text = ""
                cboColunaNCM.Text = ""
                cboColunaDescricao.Text = ""
                cboColunaPrevisaoEntrega.Text = ""
                cboColunaPrioridade.Text = ""
                cboColunaQuantidade.Text = ""
                cboColunaUnidadeMedida.Text = ""
                cboColunaValorUnitario.Text = ""
                cboColunaCentro.Text = ""
                cboColunaIPIDestacado.Text = ""
                cboColunaBaseCalculoICMS.Text = ""
                cboColunaAliquotaICMS.Text = ""
                cboColunaValorUnitarioICMS.Text = ""
                cboColunaBaseCalculoIPI.Text = ""
                cboColunaAliquotaIPI.Text = ""
                cboColunaValorUnitarioIPI.Text = ""
                cboColunaValorTotal.Text = ""
                txtLinhaInicio.Text = ""
                txtPlanilha.Text = ""

            Else

                While oSqlDataReader.Read

                    'Preenche Controles
                    cboColunaPO.SelectedValue = oSqlDataReader.Item("coluna_po")
                    cboColunaPOLinha.SelectedValue = oSqlDataReader.Item("coluna_po_linha")
                    cboColunaCodigoEmbraer.SelectedValue = oSqlDataReader.Item("coluna_codigo_embraer")
                    cboColunaCodigoItem.SelectedValue = oSqlDataReader.Item("coluna_codigo_item")
                    cboColunaNCM.SelectedValue = oSqlDataReader.Item("coluna_ncm")
                    cboColunaDescricao.SelectedValue = oSqlDataReader.Item("coluna_descricao")
                    cboColunaPrevisaoEntrega.SelectedValue = oSqlDataReader.Item("coluna_previsao_entrega")
                    cboColunaPrioridade.SelectedValue = oSqlDataReader.Item("coluna_prioridade")
                    cboColunaQuantidade.SelectedValue = oSqlDataReader.Item("coluna_quantidade")
                    cboColunaUnidadeMedida.SelectedValue = oSqlDataReader.Item("coluna_unidade_medida")
                    cboColunaValorUnitario.SelectedValue = oSqlDataReader.Item("coluna_valor_unitario")
                    cboColunaCentro.SelectedValue = oSqlDataReader.Item("coluna_centro")
                    cboColunaIPIDestacado.SelectedValue = oSqlDataReader.Item("coluna_ipi_destacado")
                    cboColunaBaseCalculoICMS.SelectedValue = oSqlDataReader.Item("coluna_base_calculo_icms")
                    cboColunaAliquotaICMS.SelectedValue = oSqlDataReader.Item("coluna_aliquota_icms")
                    cboColunaValorUnitarioICMS.SelectedValue = oSqlDataReader.Item("coluna_valor_unitario_icms")
                    cboColunaBaseCalculoIPI.SelectedValue = oSqlDataReader.Item("coluna_base_calculo_ipi")
                    cboColunaAliquotaIPI.SelectedValue = oSqlDataReader.Item("coluna_aliquota_ipi")
                    cboColunaValorUnitarioIPI.SelectedValue = oSqlDataReader.Item("coluna_valor_unitario_ipi")
                    cboColunaValorTotal.SelectedValue = oSqlDataReader.Item("coluna_valor_total")
                    txtLinhaInicio.Value = oSqlDataReader.Item("linha_inicio")
                    txtPlanilha.Text = oSqlDataReader.Item("planilha")

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateConfiguracaoArquivoExcel(ByVal iCodigoTipoPlanilha As Integer, _
                                              ByVal sColunaPO As String, _
                                              ByVal sColunaPOLinha As String, _
                                              ByVal sColunaCodigoEmbraer As String, _
                                              ByVal sColunaCodigoItem As String, _
                                              ByVal sColunaNCM As String, _
                                              ByVal sColunaDescricao As String, _
                                              ByVal sColunaPrevisaoEntrega As String, _
                                              ByVal sColunaPrioridade As String, _
                                              ByVal sColunaQuantidade As String, _
                                              ByVal sColunaUnidadeMedida As String, _
                                              ByVal sColunaValorUnitario As String, _
                                              ByVal sColunaCentro As String, _
                                              ByVal sColunaIPIDestacado As String, _
                                              ByVal sColunaBaseCalculoICMS As String, _
                                              ByVal sColunaAliquotaICMS As String, _
                                              ByVal sColunaValorUnitarioICMS As String, _
                                              ByVal sColunaBaseCalculoIPI As String, _
                                              ByVal sColunaAliquotaIPI As String, _
                                              ByVal sColunaValorUnitarioIPI As String, _
                                              ByVal sColunaValorTotal As String, _
                                              ByVal iLinhaInicio As Integer, _
                                              ByVal sPlanilha As String)

        'Variaveis Locais
        Dim oSqlParameter(24) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Tipo Planilja
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_planilha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoPlanilha : i += 1

            'Seta Parametros - Coluna PO
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_po"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaPO = "", DBNull.Value, sColunaPO) : i += 1

            'Seta Parametros - Coluna PO Linha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_po_linha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaPOLinha = "", DBNull.Value, sColunaPOLinha) : i += 1

            'Seta Parametros - Coluna Código Embraer
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_codigo_embraer"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaCodigoEmbraer = "", DBNull.Value, sColunaCodigoEmbraer) : i += 1

            'Seta Parametros - Coluna Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaCodigoItem = "", DBNull.Value, sColunaCodigoItem) : i += 1

            'Seta Parametros - Coluna NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaNCM = "", DBNull.Value, sColunaNCM) : i += 1

            'Seta Parametros - Coluna Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaDescricao = "", DBNull.Value, sColunaDescricao) : i += 1

            'Seta Parametros - Coluna Previsão Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_previsao_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaPrevisaoEntrega = "", DBNull.Value, sColunaPrevisaoEntrega) : i += 1

            'Seta Parametros - Coluna Prioridade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_prioridade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaPrioridade = "", DBNull.Value, sColunaPrioridade) : i += 1

            'Seta Parametros - Coluna Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaQuantidade = "", DBNull.Value, sColunaQuantidade) : i += 1

            'Seta Parametros - Coluna Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaUnidadeMedida = "", DBNull.Value, sColunaUnidadeMedida) : i += 1

            'Seta Parametros - Coluna Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaValorUnitario = "", DBNull.Value, sColunaValorUnitario) : i += 1

            'Seta Parametros - Coluna Centro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_centro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaCentro = "", DBNull.Value, sColunaCentro) : i += 1

            'Seta Parametros - Coluna IPI Destacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_ipi_destacado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaIPIDestacado = "", DBNull.Value, sColunaIPIDestacado) : i += 1

            'Seta Parametros - Coluna Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaBaseCalculoICMS = "", DBNull.Value, sColunaBaseCalculoICMS) : i += 1

            'Seta Parametros - Coluna Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaAliquotaICMS = "", DBNull.Value, sColunaAliquotaICMS) : i += 1

            'Seta Parametros - Coluna Valor Unitario ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_valor_unitario_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaValorUnitarioICMS = "", DBNull.Value, sColunaValorUnitarioICMS) : i += 1

            'Seta Parametros - Coluna Base Cálculo IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_base_calculo_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaBaseCalculoIPI = "", DBNull.Value, sColunaBaseCalculoIPI) : i += 1

            'Seta Parametros - Coluna Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaAliquotaIPI = "", DBNull.Value, sColunaAliquotaIPI) : i += 1

            'Seta Parametros - Coluna Valor Unitario IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_valor_unitario_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaValorUnitarioIPI = "", DBNull.Value, sColunaValorUnitarioIPI) : i += 1

            'Seta Parametros - Coluna Valor Total
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaValorTotal = "", DBNull.Value, sColunaValorTotal) : i += 1

            'Seta Parametros - Planilha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "planilha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sPlanilha : i += 1

            'Seta Parametros - Linha Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "linha_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = iLinhaInicio

            'Executa Query
            SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_integracao_importacao_pedido_venda_embraer2", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosCliente(ByVal sCodigoIntegracao As String, _
                                ByRef iCodigoCliente As Integer, _
                                ByRef sRazaoSocial As String)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Integracao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_integracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sCodigoIntegracao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_dados_integracao", oSqlParameter)

            If oSqlDataReader.HasRows = False Then
                'Limpa Váriaveis
                iCodigoCliente = -1
                sRazaoSocial = ""
            Else
                'Carrega Váriaveis
                While oSqlDataReader.Read
                    iCodigoCliente = oSqlDataReader.Item("codigo")
                    sRazaoSocial = oSqlDataReader.Item("razao_social")
                End While
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosPedido(ByVal sPO As String, _
                               ByVal iPOLinha As Integer, _
                               ByRef lCodigoPedido As Long, _
                               ByRef iCodigoPedidoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - PO
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sPO.Trim : i += 1

            'Seta Parametros - PO
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPOLinha : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados_integracao", oSqlParameter)

            If oSqlDataReader.HasRows = False Then
                'Limpa Váriaveis
                lCodigoPedido = -1
                iCodigoPedidoItem = -1
            Else
                'Carrega Váriaveis
                While oSqlDataReader.Read
                    lCodigoPedido = oSqlDataReader.Item("codigo_pedido")
                    iCodigoPedidoItem = oSqlDataReader.Item("codigo_pedido_item")
                End While
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Salvar(ByVal oGrid As GridEX, _
                      ByVal sFormaCadastro As String)

        'Variaveis Locais
        Dim oRow As GridEXRow
        Dim oSqlParameter(24) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow In oGrid.GetDataRows

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Forma de Cadastro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "forma_cadastro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 10
                oSqlParameter(i).Value = sFormaCadastro : i += 1

                'Seta Parametros - Nº Pedido Cliente
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_pedido_cliente"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 15
                oSqlParameter(i).Value = oRow.Cells("po").Value.ToString.Trim : i += 1

                'Seta Parametros - Nº Pedido Item Cliente
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("po_linha").Value.ToString.Trim : i += 1

                'Seta Parametros - Código Embraer
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_embraer"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("codigo_embraer").Value.ToString.Trim : i += 1

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("codigo_item").Value.ToString.Trim : i += 1

                'Seta Parametros - NCM
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "ncm"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("ncm").Value.ToString.Trim : i += 1

                'Seta Parametros - Descrição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 500
                oSqlParameter(i).Value = oRow.Cells("descricao").Value.ToString.Trim : i += 1

               'Seta Parametros - Data Previsão Entrega
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_previsao_entrega"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_previsao_entrega").Value : i += 1

                'Seta Parametros - Prioridade
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "prioridade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 10
                oSqlParameter(i).Value = oRow.Cells("prioridade").Value.ToString.Trim : i += 1

                'Seta Parametros - Quantidade
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "quantidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("quantidade").Value : i += 1

                'Seta Parametros - Unidade Medida
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "unidade_medida"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 4
                oSqlParameter(i).Value = oRow.Cells("unidade_medida").Value.ToString.Trim : i += 1
               
                'Seta Parametros - Valor Unitário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_unitario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_unitario").Value : i += 1

                'Seta Parametros - Código Cliente
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_cliente"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_cliente").Value : i += 1

                'Seta Parametros - IPI Destacado
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "ipi_destacado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = IIf(oRow.Cells("ipi_destacado").Value = "SIM", True, False) : i += 1

                'Seta Parametros - Base Cálculo ICMS
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "base_calculo_icms"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("base_calculo_icms").Value : i += 1

                'Seta Parametros - Alíquota ICMS
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "aliquota_icms"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("aliquota_icms").Value : i += 1

                'Seta Parametros - Valor Unitário ICMS
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_unitario_icms"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_unitario_icms").Value : i += 1

                'Seta Parametros - Base Cálculo IPI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "base_calculo_ipi"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("base_calculo_ipi").Value : i += 1

                'Seta Parametros - Alíquota IPI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "aliquota_ipi"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("aliquota_ipi").Value : i += 1

                'Seta Parametros - Valor Unitário IPI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_unitario_ipi"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_unitario_ipi").Value : i += 1

                'Seta Parametros - Valor Total
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_total"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_total").Value : i += 1

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido").Value : i += 1

                'Seta Parametros - Código Pedido Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido_item").Value

                'Executa Query
                SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_integracao2", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: INTEGRAÇÃO :::"

#Region "::: SELMA :::"

    Public Function SELMAValidaDesenho(ByVal sStringConnection As String, _
                                       ByVal sPartNumber As String, _
                                       ByVal sRevisao As String) As Boolean

        'Variaveis Locais
        Dim sQuery As String
        Dim iReturn As Integer
        Dim oConnection As New OleDbConnection

        Try

            'Seta String de Conexão
            oConnection.ConnectionString = sStringConnection

            'Abre String de Conexão
            oConnection.Open()

            'Query - Seleciona Dados do Desenho
            sQuery = "SELECT "
            sQuery = sQuery & "COUNT(*) AS quantidade "
            sQuery = sQuery & "FROM "
            sQuery = sQuery & "DESENHO "
            sQuery = sQuery & "WHERE (((REV_LP) <> '" & sRevisao & "') "
            sQuery = sQuery & "AND ((Desenho) = '" & sPartNumber & "'))"
            'Executa Query
            iReturn = OleDbHelper.ExecuteScalar(oConnection, CommandType.Text, sQuery)

            If iReturn <> 0 Then

                'Atualiza Tabela PROCESSO
                sQuery = "UPDATE PROCESSO SET "
                sQuery = sQuery & "SSS = 'Sim' "
                sQuery = sQuery & "WHERE (((Desenho) = '" & sPartNumber & "'))"
                OleDbHelper.ExecuteNonQuery(oConnection, CommandType.Text, sQuery)

                'Atualiza Tabela SERVICO
                sQuery = "UPDATE SERVICO SET "
                sQuery = sQuery & "Fluxo = 'Proc', "
                sQuery = sQuery & "dt_fx = '" & Now.Date & "' "
                sQuery = sQuery & "WHERE (((Desenho) = '" & sPartNumber & "'))"
                OleDbHelper.ExecuteNonQuery(oConnection, CommandType.Text, sQuery)

            End If

            'Seta Retorno da Função
            Return IIf(iReturn = 0, True, False)

        Catch OleDbEx As OleDbException
            Throw OleDbEx
        Catch ex As Exception
            Throw ex
        Finally
            'Fecha String de Conexão
            If oConnection.State = ConnectionState.Open Then
                oConnection.Close()
                oConnection = Nothing
            End If
        End Try

    End Function

#End Region

#End Region

#End Region

End Class

