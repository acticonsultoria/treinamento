Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrRHFuncionarioSalario

#Region "::: FUNCTION / SUB :::"

    Public Sub Save(ByVal oRowUpdate As Hashtable, _
                    ByVal iMes As Integer, _
                    ByVal iAno As Integer)

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer
        Dim oRow As GridEXRow

        Try

            For Each oRow In oRowUpdate.Values

                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Funcionário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_funcionario").Value : i += 1

                'Seta Parametros - Mês
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "mes"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iMes : i += 1

                'Seta Parametros - Ano
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "ano"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iAno : i += 1

                'Seta Parametros - Salário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "salario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("salario").Value : i += 1

                'Seta Parametros - Quantidade Hora Extra
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "quantidade_hora_extra"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("quantidade_hora_extra").Value : i += 1

                'Seta Parametros - Valor Hora Extra
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_hora_extra"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_hora_extra").Value : i += 1

                'Seta Parametros - DSR
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "dsr"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("dsr").Value : i += 1

                'Seta Parametros - INSS
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "inss"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("inss").Value : i += 1

                'Seta Parametros - IRRF
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "irrf"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("irrf").Value : i += 1

                'Seta Parametros - FGTS
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "fgts"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("fgts").Value : i += 1

                'Seta Parametros - Vale Transporte
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "vale_transporte"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("vale_transporte").Value : i += 1

                'Seta Parametros - Vale Refeição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "vale_refeicao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("vale_refeicao").Value : i += 1

                'Seta Parametros - Vale Alimentação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "vale_alimentacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("vale_alimentacao").Value : i += 1

                'Seta Parametros - Assistência Médica
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "assistencia_medica"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("assistencia_medica").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_rh_funcionario_encargos_salario", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iMes As Integer, _
                        ByVal iAno As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Mês
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMes : i += 1

            'Seta Parametros - Ano
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iAno

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_rh_funcionario_encargos_salario", oSqlParameter)

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

    Public Sub UpdateConfiguracaoArquivoExcel(ByVal sColunaProntuario As String, _
                                              ByVal sColunaSalario As String, _
                                              ByVal sColunaQuantidadeHoraExtra As String, _
                                              ByVal sColunaValorHoraExtra As String, _
                                              ByVal sColunaDSR As String, _
                                              ByVal sColunaINSS As String, _
                                              ByVal sColunaIRRF As String, _
                                              ByVal sColunaFGTS As String, _
                                              ByVal sColunaValeTransporte As String, _
                                              ByVal sColunaValeRefeicao As String, _
                                              ByVal sColunaValeAlimentacao As String, _
                                              ByVal sColunaAssistenciaMedica As String, _
                                              ByVal iLinhaInicio As Integer)

        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

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

            'Seta Parametros - Coluna Prontuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_prontuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaProntuario : i += 1

            'Seta Parametros - Coluna Salário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_salario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaSalario : i += 1

            'Seta Parametros - Coluna Quantidade Hora Extra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_quantidade_hora_extra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaQuantidadeHoraExtra : i += 1

            'Seta Parametros - Coluna Valor Hora Extra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_valor_hora_extra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaValorHoraExtra : i += 1

            'Seta Parametros - Coluna DSR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_dsr"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaDSR : i += 1

            'Seta Parametros - Coluna INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaINSS : i += 1

            'Seta Parametros - Coluna IRRF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_irrf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaIRRF : i += 1

            'Seta Parametros - Coluna FGTS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_fgts"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaFGTS : i += 1

            'Seta Parametros - Coluna Vale Transporte
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_vale_transporte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaValeTransporte : i += 1

            'Seta Parametros - Coluna Vale Refeição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_vale_refeicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaValeRefeicao : i += 1

            'Seta Parametros - Coluna Vale Alimentação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_vale_alimentacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaValeAlimentacao : i += 1

            'Seta Parametros - Coluna Assistencia Médica
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_assistencia_medica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaAssistenciaMedica : i += 1

            'Seta Parametros - Linha Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "linha_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iLinhaInicio

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importacao_rh_funcionario_salario_encargos", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadConfiguracaoArquivoExcel(ByVal cboConfiguracaoColunaProntuario As UIComboBox, _
                                            ByVal cboConfiguracaoColunaSalario As UIComboBox, _
                                            ByVal cboConfiguracaoColunaQuantidadeHoraExtra As UIComboBox, _
                                            ByVal cboConfiguracaoColunaValorHoraExtra As UIComboBox, _
                                            ByVal cboConfiguracaoColunaDSR As UIComboBox, _
                                            ByVal cboConfiguracaoColunaINSS As UIComboBox, _
                                            ByVal cboConfiguracaoColunaIRRF As UIComboBox, _
                                            ByVal cboConfiguracaoColunaFGTS As UIComboBox, _
                                            ByVal cboConfiguracaoColunaValeTransporte As UIComboBox, _
                                            ByVal cboConfiguracaoColunaValeRefeicao As UIComboBox, _
                                            ByVal cboConfiguracaoColunaValeAlimentacao As UIComboBox, _
                                            ByVal cboConfiguracaoColunaAssistenciaMedica As UIComboBox, _
                                            ByVal txtLinhaInicio As NumericEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

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
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importacao_rh_funcionario_salario_encargos", oSqlParameter)

            While oSqlDataReader.Read

                cboConfiguracaoColunaProntuario.SelectedValue = oSqlDataReader.Item("coluna_prontuario")
                cboConfiguracaoColunaSalario.SelectedValue = oSqlDataReader.Item("coluna_salario")
                cboConfiguracaoColunaQuantidadeHoraExtra.SelectedValue = oSqlDataReader.Item("coluna_quantidade_hora_extra")
                cboConfiguracaoColunaValorHoraExtra.SelectedValue = oSqlDataReader.Item("coluna_valor_hora_extra")
                cboConfiguracaoColunaDSR.SelectedValue = oSqlDataReader.Item("coluna_dsr")
                cboConfiguracaoColunaINSS.SelectedValue = oSqlDataReader.Item("coluna_inss")
                cboConfiguracaoColunaIRRF.SelectedValue = oSqlDataReader.Item("coluna_irrf")
                cboConfiguracaoColunaFGTS.SelectedValue = oSqlDataReader.Item("coluna_fgts")
                cboConfiguracaoColunaValeTransporte.SelectedValue = oSqlDataReader.Item("coluna_vale_transporte")
                cboConfiguracaoColunaValeRefeicao.SelectedValue = oSqlDataReader.Item("coluna_vale_refeicao")
                cboConfiguracaoColunaValeAlimentacao.SelectedValue = oSqlDataReader.Item("coluna_vale_alimentacao")
                cboConfiguracaoColunaAssistenciaMedica.SelectedValue = oSqlDataReader.Item("coluna_assistencia_medica")
                txtLinhaInicio.Value = oSqlDataReader.Item("linha_inicio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
