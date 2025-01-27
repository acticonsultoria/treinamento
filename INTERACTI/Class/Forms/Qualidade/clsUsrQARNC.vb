Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports INTERACTI.SQLHelper
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrQARNC

#Region "::: QUALIDADE :::"

    Public Function InsertRegistroNaoConformidade(ByVal lCodigoOrdemProducao As Long) As Long

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
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_rnc", oSqlParameter)

            Return oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadControles(ByVal lCodigo As Long,
                             ByVal txtNumeroRNC As MaskedEditBox,
                             ByVal dtpData As CalendarCombo,
                             ByVal cboResponsavel As UIComboBox,
                             ByVal cboFonte As UIComboBox,
                             ByVal txtOrdemProducao As MaskedEditBox,
                             ByVal txtItemNC As MaskedEditBox,
                             ByVal txtQtdNC As NumericEditBox,
                             ByVal cboImpacto As UIComboBox,
                             ByVal cboDisposicao As UIComboBox,
                             ByVal txtDescricaoNC As EditBox,
                             ByVal txtAnalise As EditBox,
                             ByVal txtNumeroRI As MaskedEditBox,
                             ByVal txtQtdOP As NumericEditBox,
                             ByVal cboProcessoProdutivo As UIComboBox,
                             ByVal cboProcessoProdutivoOrigem As UIComboBox,
                             ByVal cboFamiliaCausa As UIComboBox,
                             ByVal cboCausaRNC As UIComboBox,
                             ByVal cboAnaliseRNC As UIComboBox,
                             ByVal txtCaracteristica As MaskedEditBox,
                             ByVal txtClasseTolerancia As MaskedEditBox,
                             ByVal txtEquipamento As MaskedEditBox,
                             ByVal txtValorNominal As MaskedEditBox,
                             ByVal txtToleranciaMin As MaskedEditBox,
                             ByVal txtToleranciaMax As MaskedEditBox,
                             ByVal txtValorMinimo As NumericEditBox,
                             ByVal txtValorMaximo As NumericEditBox,
                             ByVal txtValorEncontrado As MaskedEditBox,
                             ByVal txtObservacaoCaracteristica As MaskedEditBox,
                             ByVal txtSequenciaCaracteristica As MaskedEditBox,
                             ByVal cboStatus As UIComboBox,
                             ByVal cboMaquina As UIComboBox,
                             ByVal cboFuncionario As UIComboBox,
                             ByVal txtAcaoImediata As EditBox,
                             ByVal cboAtendidoPorAcaoImediata As UIComboBox,
                             ByVal txtAnaliseCausa As EditBox,
                             ByVal cboAnalisadoPorAnaliseCausa As UIComboBox,
                             ByVal txtAcaoCorretiva As EditBox,
                             ByVal cboResponsavelAcaoCorretiva As UIComboBox,
                             ByVal dtpDataAcaoCorretiva As CalendarCombo,
                             ByVal cboAutorizadoPorAcaoCorretiva As UIComboBox,
                             ByVal txtObservacaoConclusao As EditBox)


        'Variaveis Locais
        Dim oSQLDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1


            'Executa Query
            oSQLDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_rnc_dados", oSqlParameter)


            If oSQLDataReader.Read Then

                txtNumeroRNC.Text = oSQLDataReader.Item("numero_rnc")
                dtpData.Value = oSQLDataReader.Item("data_rnc")
                cboResponsavel.SelectedValue = oSQLDataReader.Item("codigo_usuario_responsavel")
                cboFonte.SelectedValue = oSQLDataReader.Item("codigo_fonte_rnc")
                txtOrdemProducao.Text = oSQLDataReader.Item("numero_os")
                txtOrdemProducao.Tag = oSQLDataReader.Item("codigo_ordem_producao")
                txtItemNC.Text = oSQLDataReader.Item("descricao")
                txtQtdOP.Value = oSQLDataReader.Item("quantidade_planejada")
                txtQtdNC.Value = oSQLDataReader.Item("quantidade_rnc")
                cboDisposicao.SelectedValue = oSQLDataReader.Item("codigo_disposicao_rnc")
                txtDescricaoNC.Text = oSQLDataReader.Item("descricao_rnc")
                txtAnalise.Text = oSQLDataReader.Item("analise_rnc")
                cboProcessoProdutivo.SelectedValue = oSQLDataReader.Item("codigo_centro_custo")
                cboProcessoProdutivoOrigem.SelectedValue = oSQLDataReader.Item("codigo_centro_custo_origem")
                cboFamiliaCausa.SelectedValue = oSQLDataReader.Item("codigo_familia")
                cboCausaRNC.SelectedValue = oSQLDataReader.Item("codigo_causa")
                cboAnaliseRNC.SelectedValue = oSQLDataReader.Item("codigo_analise")
                txtNumeroRI.Text = oSQLDataReader.Item("numero_ri")
                txtCaracteristica.Text = oSQLDataReader.Item("descricao_caracteristica")
                txtClasseTolerancia.Text = oSQLDataReader.Item("classe_tolerancia")
                txtEquipamento.Text = oSQLDataReader.Item("descricao_equipamento")
                txtValorNominal.Text = oSQLDataReader.Item("valor_nominal")
                txtToleranciaMin.Text = oSQLDataReader.Item("tolerancia_minima")
                txtToleranciaMax.Text = oSQLDataReader.Item("tolerancia_maxima")
                txtValorMinimo.Value = oSQLDataReader.Item("valor_minimo")
                txtValorMaximo.Value = oSQLDataReader.Item("valor_maximo")
                txtValorEncontrado.Text = oSQLDataReader.Item("valor_encontrado")
                txtObservacaoCaracteristica.Text = oSQLDataReader.Item("observacao")
                txtSequenciaCaracteristica.Text = oSQLDataReader.Item("sequencia")
                cboStatus.SelectedValue = oSQLDataReader.Item("codigo_status")
                txtAcaoImediata.Text = oSQLDataReader.Item("acao_imediata")
                txtAnaliseCausa.Text = oSQLDataReader.Item("analise_causa")
                txtAcaoCorretiva.Text = oSQLDataReader.Item("acao_corretiva")
                txtObservacaoConclusao.Text = oSQLDataReader.Item("observacao_conclusao")

                If Not IsDBNull(oSQLDataReader.Item("codigo_maquina")) Then
                    cboMaquina.SelectedValue = oSQLDataReader.Item("codigo_maquina")
                Else
                    cboMaquina.SelectedIndex = -1
                End If
                If Not IsDBNull(oSQLDataReader.Item("codigo_funcionario")) Then
                    cboFuncionario.SelectedValue = oSQLDataReader("codigo_funcionario")
                Else
                    cboFuncionario.SelectedIndex = -1
                End If

                If Not IsDBNull(oSQLDataReader.Item("codigo_impacto")) Then
                    cboImpacto.SelectedValue = oSQLDataReader.Item("codigo_impacto")
                Else
                    cboImpacto.SelectedIndex = -1
                End If

                If Not IsDBNull(oSQLDataReader.Item("codigo_usuario_acao_imediata")) Then
                    cboAtendidoPorAcaoImediata.SelectedValue = oSQLDataReader.Item("codigo_usuario_acao_imediata")
                Else
                    cboAtendidoPorAcaoImediata.SelectedIndex = -1
                End If

                If Not IsDBNull(oSQLDataReader.Item("codigo_usuario_analise_causa")) Then
                    cboAnalisadoPorAnaliseCausa.SelectedValue = oSQLDataReader.Item("codigo_usuario_analise_causa")
                Else
                    cboAnalisadoPorAnaliseCausa.SelectedIndex = -1
                End If

                If Not IsDBNull(oSQLDataReader.Item("codigo_usuario_responsavel_acao_corretiva")) Then
                    cboResponsavelAcaoCorretiva.SelectedValue = oSQLDataReader.Item("codigo_usuario_responsavel_acao_corretiva")
                Else
                    cboResponsavelAcaoCorretiva.SelectedIndex = -1
                End If

                If Not IsDBNull(oSQLDataReader.Item("data_acao_corretiva")) Then
                    dtpDataAcaoCorretiva.Checked = True
                    dtpDataAcaoCorretiva.Value = oSQLDataReader.Item("data_acao_corretiva")
                Else
                    dtpDataAcaoCorretiva.Checked = False
                    dtpDataAcaoCorretiva.Value = Date.Now
                End If

                If Not IsDBNull(oSQLDataReader.Item("codigo_usuario_autorizado_acao_corretiva")) Then
                    cboAutorizadoPorAcaoCorretiva.SelectedValue = oSQLDataReader.Item("codigo_usuario_autorizado_acao_corretiva")
                Else
                    cboAutorizadoPorAcaoCorretiva.SelectedIndex = -1
                End If

                oSQLDataReader.Close()
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRNC(ByVal lCodigo As Long,
                         ByVal iCodigoUsuarioResponsavel As Integer,
                         ByVal iCodigoFonteRnc As Integer,
                         ByVal dQuantidadeRnc As Double,
                         ByVal sDescricaoRnc As String,
                         ByVal iCodigoDisposicaoRnc As Integer,
                         ByVal iCodigoImpacto As Integer,
                         ByVal sAnaliseRnc As String,
                         ByVal iCodigoCentroCusto As Integer,
                         ByVal iCodigoCentroCustoOrigem As Integer,
                         ByVal iCodigoCausa As Integer,
                         ByVal iCodigoAnalise As Integer,
                         ByVal iCodigoFamilia As Integer,
                         ByVal iCodigoStatus As Integer,
                         ByVal iCodigoMaquina As Integer,
                         ByVal iCodigoFuncionario As Integer,
                         ByVal sAcaoImediata As String,
                         ByVal iCodigoAtendidoPorAcaoImediata As Integer,
                         ByVal sAnaliseCausa As String,
                         ByVal iCodigoAnalisadoPorAnaliseCausa As Integer,
                         ByVal sAcaoCorretiva As String,
                         ByVal iCodigoResponsavelAcaoCorretiva As Integer,
                         ByVal sDataAcaoCorretiva As String,
                         ByVal iCodigoAutorizadoPorAcaoCorretiva As Integer,
                         ByVal sObservacaoConclusao As String
                         )

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
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario_responsavel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUsuarioResponsavel : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fonte_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFonteRnc : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeRnc : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricaoRnc : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_disposicao_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDisposicaoRnc : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "analise_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAnaliseRnc : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroCusto : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroCustoOrigem : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_causa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCausa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_analise"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoAnalise : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_familia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFamilia : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoMaquina = -1, DBNull.Value, iCodigoMaquina) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFuncionario = -1, DBNull.Value, iCodigoFuncionario) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_impacto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoImpacto = -1, DBNull.Value, iCodigoImpacto) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "acao_imediata"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAcaoImediata : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario_acao_imediata"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAtendidoPorAcaoImediata = -1, DBNull.Value, iCodigoAtendidoPorAcaoImediata) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "analise_causa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAnaliseCausa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario_analise_causa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAnalisadoPorAnaliseCausa = -1, DBNull.Value, iCodigoAnalisadoPorAnaliseCausa) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "acao_corretiva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAcaoCorretiva : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario_responsavel_acao_corretiva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoResponsavelAcaoCorretiva = -1, DBNull.Value, iCodigoResponsavelAcaoCorretiva) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_acao_corretiva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAcaoCorretiva = "", DBNull.Value, sDataAcaoCorretiva) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario_autorizado_acao_corretiva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAutorizadoPorAcaoCorretiva = -1, DBNull.Value, iCodigoAutorizadoPorAcaoCorretiva) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao_conclusao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacaoConclusao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoStatus


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_qualidade_rnc", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridRNC(ByVal oGrid As GridEX,
                           ByVal sDataInicio As String,
                           ByVal sDataTermino As String,
                           ByVal sNumeroRNC As String,
                           ByVal sOrdemProducao As String,
                           ByVal sItem As String,
                           ByVal iCodigoDisposicao As Integer,
                           ByVal iCodigoStatus As Integer)

        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroRNC = "", DBNull.Value, sNumeroRNC) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sOrdemProducao = "", DBNull.Value, sOrdemProducao) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sItem = "", DBNull.Value, sItem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_disposicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoDisposicao = 0, DBNull.Value, iCodigoDisposicao) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoStatus = 0, DBNull.Value, iCodigoStatus)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_rnc", oSqlParameter)

            'Configura DataMember - Grid
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

    Public Sub DeleteRNC()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Variavel
                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1 : ReDim Preserve oSqlParameter(i)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_qualidade_rnc", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function InsertSAC(ByVal lCodigoOrdemProducao As Long) As Long

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
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_sac"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_sac", oSqlParameter)

            Return oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Sub UpdateProsseguirProducao(ByVal lCodigoOrdemProducao As Long,
                                        ByVal lCodigoRNC As Long)
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
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRNC

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_qualidade_rnc_prosseguir_producao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Public Sub InsertArquivo(ByVal lCodigoRNC As Long,
                             ByVal sArquivo As String,
                             ByVal sDescricao As String)

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
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRNC : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_rnc_arquivo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateArquivo(ByVal lCodigoRNC As Long,
                             ByVal sArquivo As String,
                             ByVal sDescricao As String,
                             ByVal iCodigoArquivo As Integer)

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
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRNC : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoArquivo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_qualidade_rnc_arquivo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridArquivos(ByVal oGrid As GridEX,
                                   ByVal lCodigoRnc As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRnc : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_rnc_arquivo", oSqlParameter)

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

    Public Sub DeleteArquivo(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim sPath As String = ""

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0
                sPath = oRow.Cells("arquivo").Text

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_rnc"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_qualidade_rnc_arquivo", oSqlParameter)

                'Exclui o arquivo
                If File.Exists(sPath) Then
                    File.Delete(sPath)
                End If

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

#Region "::: FIND OP :::"
    Public Sub LoadGridFind(ByVal oGrid As GridEX,
                            ByVal sDataInicio As String,
                            ByVal sDataTermino As String,
                            ByVal sOrdemProducao As String,
                            ByVal sProduto As String,
                            ByVal sCliente As String)

        'Variaveis Locais

        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

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
            oSqlParameter(i).ParameterName = "ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sOrdemProducao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProduto : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCliente : i += 1 : ReDim Preserve oSqlParameter(i)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_rnc_procurar_op", oSqlParameter)

            'Configura DataMember - Grid
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

#Region "::: HISTORICO :::"

    Public Sub InsertHistorico(ByVal lCodigoRNC As Long,
                              ByVal sHistorico As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRNC : i += 1


            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Historico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sHistorico

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_rnc_historico", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX,
                                ByVal lCodigoRNC As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rnc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRNC : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_rnc_historico", oSqlParameter)

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


