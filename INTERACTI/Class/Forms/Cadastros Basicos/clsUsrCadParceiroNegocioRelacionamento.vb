Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCadParceiroNegocioRelacionamento

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridContato(ByVal oGrid As GridEX, _
                               ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_contato", oSqlParameter)
            
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

    Public Sub LoadGridEndereco(ByVal oGrid As GridEX, _
                                ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_endereco", oSqlParameter)

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

    Public Sub LoadGridPedidoCompra(ByVal oGrid As GridEX, _
                                    ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_pedido_compra", oSqlParameter)

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

    Public Sub LoadGridPedidoVenda(ByVal oGrid As GridEX, _
                                   ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_pedido_venda", oSqlParameter)

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

    Public Sub LoadGridTitulo(ByVal oGrid As GridEX, _
                              ByVal lCodigoParceiroNegocio As Long, _
                              ByVal sTipo As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_titulo", oSqlParameter)

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

    Public Sub LoadGridHistoricoVenda(ByVal oGrid As GridEX, _
                                      ByVal iCodigoCliente As Integer, _
                                      ByVal sDataInicio As String, _
                                      ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

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

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_pedido", oSqlParameter)

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

    Public Sub LoadGridHistoricoVendaProduto(ByVal oGrid As GridEX, _
                                             ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_pedido_produto", oSqlParameter)

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

    Public Sub LoadGridHistoricoOrcamento(ByVal oGrid As GridEX, _
                                          ByVal iCodigoCliente As Integer, _
                                          ByVal sDataInicio As String, _
                                          ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1
            
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

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_orcamento", oSqlParameter)

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

    Public Sub LoadGridHistoricoOrcamentoProduto(ByVal oGrid As GridEX, _
                                                 ByVal lCodigoOrcamento As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrcamento

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_orcamento_produto", oSqlParameter)

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

    Public Sub LoadControles(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal cboTipoInscricaoEstadual As UIComboBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtInscricaoEstadualSubstitutoTributario As MaskedEditBox, _
                             ByVal txtInscricaoMunicipal As MaskedEditBox, _
                             ByVal txtInscricaoSuframa As MaskedEditBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal cboVendedorInterno As UIComboBox, _
                             ByVal cboVendedorExterno As UIComboBox, _
                             ByVal txtObservacao As EditBox, _
                             ByVal txtTelefone1 As MaskedEditBox, _
                             ByVal txtTelefone2 As MaskedEditBox, _
                             ByVal txtTelefoneRecado As MaskedEditBox, _
                             ByVal txtFax As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal dtpDataFundacao As CalendarCombo, _
                             ByVal dtpDataCadastro As CalendarCombo)

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
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    cboTipoInscricaoEstadual.SelectedValue = oSqlDataReader.Item("codigo_tipo_inscricao_estadual")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtInscricaoEstadualSubstitutoTributario.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_substituto_tributario")), "", oSqlDataReader.Item("inscricao_estadual_substituto_tributario"))
                    txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                    txtInscricaoSuframa.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa"))
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboVendedorInterno.SelectedValue = oSqlDataReader.Item("codigo_vendedor_interno")
                    cboVendedorExterno.SelectedValue = oSqlDataReader.Item("codigo_vendedor")
                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtFax.Text = oSqlDataReader.Item("fax")
                    txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    If IsDBNull(oSqlDataReader.Item("data_fundacao")) Then
                        dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
                    Else
                        dtpDataFundacao.Value = oSqlDataReader.Item("data_fundacao") : dtpDataFundacao.Checked = True
                    End If
                    If IsDBNull(oSqlDataReader.Item("data_cadastro")) Then
                        dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
                    Else
                        dtpDataCadastro.Value = oSqlDataReader.Item("data_cadastro") : dtpDataCadastro.Checked = True
                    End If

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

    Public Sub Update(ByVal iCodigoParceiroNegocio As Integer, _
                      ByVal iCodigoPersonalidade As Integer, _
                      ByVal sCEP As String, _
                      ByVal iCodigoPais As Integer, _
                      ByVal sUF As String, _
                      ByVal iCodigoMunicipio As Integer, _
                      ByVal sLogradouro As String, _
                      ByVal sNumero As String, _
                      ByVal sBairro As String, _
                      ByVal sComplemento As String, _
                      ByVal sCNPJCPF As String, _
                      ByVal iCodigoTipoInscricaoEstadual As Integer, _
                      ByVal sInscricaoEstadual As String, _
                      ByVal sInscricaoEstadualSubstitutoTributario As String, _
                      ByVal sInscricaoMunicipal As String, _
                      ByVal sInscricaoSuframa As String, _
                      ByVal sEmail As String, _
                      ByVal sTelefone1 As String, _
                      ByVal sTelefone2 As String, _
                      ByVal sFax As String, _
                      ByVal sTelefoneRecado As String, _
                      ByVal iCodigoVendedorInterno As Integer, _
                      ByVal iCodigoVendedorExterno As Integer, _
                      ByVal sObservacao As String, _
                      ByVal sDataFundacao As String, _
                      ByVal sDataCadastro As String)

        'Variaveis Locais
        Dim oSqlParameter(27) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPersonalidade : i += 1

            'Seta Parametros - Cnpj/Cpf
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJCPF : i += 1

            'Seta Parametros - Código Tipo Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoInscricaoEstadual : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadual = "", DBNull.Value, sInscricaoEstadual) : i += 1

            'Seta Parametros - Inscrição Estadual Substituto Tributário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual_substituto_tributario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadualSubstitutoTributario = "", DBNull.Value, sInscricaoEstadualSubstitutoTributario) : i += 1

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sInscricaoMunicipal = "", DBNull.Value, sInscricaoMunicipal) : i += 1

            'Seta Parametros - Inscrição Suframa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_suframa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = IIf(sInscricaoSuframa = "", DBNull.Value, sInscricaoSuframa) : i += 1

            'Seta Parametros - País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPais : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipio = -1, DBNull.Value, iCodigoMunicipio) : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouro : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumero : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairro : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEP : i += 1

            'Seta Parametros - Código Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoVendedorExterno = -1, DBNull.Value, iCodigoVendedorExterno) : i += 1

            'Seta Parametros - Código Vendedor Interno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor_interno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoVendedorInterno = -1, DBNull.Value, iCodigoVendedorInterno) : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

            'Seta Parametros - Telefone 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone1 : i += 1

            'Seta Parametros - Telefone 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone2 : i += 1

            'Seta Parametros - Fax
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fax"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sFax : i += 1

            'Seta Parametros - Telefone Recado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_recado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefoneRecado : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEmail : i += 1

            'Seta Parametros - Data da Fundação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fundacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataFundacao), sDataFundacao, DBNull.Value) : i += 1

            'Seta Parametros - Data do Cadastro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataCadastro), sDataCadastro, DBNull.Value) : i += 1

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
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_relacionamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridNotaFiscal(ByVal oGrid As GridEX, _
                                  ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_nota_fiscal", oSqlParameter)

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

End Class
