Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrImpNCMIBPT

#Region "::: FUNCTION / SUB :::"

#Region "::: NCM :::"

    Public Sub LoadControles(ByVal cboColunaNCM As UIComboBox, _
                             ByVal cboColunaEX As UIComboBox, _
                             ByVal cboColunaImpostoFederalNacional As UIComboBox, _
                             ByVal cboColunaImpostoFederalImportado As UIComboBox, _
                             ByVal cboColunaImpostoEstadual As UIComboBox, _
                             ByVal cboColunaImpostoMunicipal As UIComboBox, _
                             ByVal cboColunaVigenciaInicio As UIComboBox, _
                             ByVal cboColunaVigenciaTermino As UIComboBox, _
                             ByVal cboColunaChave As UIComboBox, _
                             ByVal cboColunaVesao As UIComboBox, _
                             ByVal cboColunaFonte As UIComboBox, _
                             ByVal txtLinhaInicio As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importacao_ncm_aliquotas", oSqlParameter)

            'Verifica se foi encontrado algum Registro
            If oSqlDataReader.HasRows = False Then

                'Limpa Controles
                cboColunaNCM.Text = ""
                cboColunaEX.Text = ""
                cboColunaImpostoFederalNacional.Text = ""
                cboColunaImpostoFederalImportado.Text = ""
                cboColunaImpostoEstadual.Text = ""
                cboColunaImpostoMunicipal.Text = ""
                cboColunaVigenciaInicio.Text = ""
                cboColunaVigenciaTermino.Text = ""
                cboColunaChave.Text = ""
                cboColunaVesao.Text = ""
                cboColunaFonte.Text = ""
                txtLinhaInicio.Value = ""

            Else

                While oSqlDataReader.Read

                    'Preenche Controles
                    cboColunaNCM.SelectedValue = oSqlDataReader.Item("coluna_ncm")
                    cboColunaEX.SelectedValue = oSqlDataReader.Item("coluna_ex")
                    cboColunaImpostoFederalNacional.SelectedValue = oSqlDataReader.Item("coluna_federal_nacional")
                    cboColunaImpostoFederalImportado.SelectedValue = oSqlDataReader.Item("coluna_federal_importados")
                    cboColunaImpostoEstadual.SelectedValue = oSqlDataReader.Item("coluna_estadual")
                    cboColunaImpostoMunicipal.SelectedValue = oSqlDataReader.Item("coluna_municipal")
                    cboColunaVigenciaInicio.SelectedValue = oSqlDataReader.Item("coluna_vigencia_inicio")
                    cboColunaVigenciaTermino.SelectedValue = oSqlDataReader.Item("coluna_vigencia_termino")
                    cboColunaChave.SelectedValue = oSqlDataReader.Item("coluna_chave")
                    cboColunaVesao.SelectedValue = oSqlDataReader.Item("coluna_versao")
                    cboColunaFonte.SelectedValue = oSqlDataReader.Item("coluna_fonte")
                    txtLinhaInicio.Value = oSqlDataReader.Item("linha_inicio")

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

    Public Sub UpdateConfiguracaoArquivoExcel(ByVal sColunaNCM As String, _
                                              ByVal sColunaEX As String, _
                                              ByVal sColunaImpostoFederalNacional As String, _
                                              ByVal sColunaImpostoFederalImportado As String, _
                                              ByVal sColunaImpostoEstadual As String, _
                                              ByVal sColunaImpostoMunicipal As String, _
                                              ByVal sColunaVigenciaInicio As String, _
                                              ByVal sColunaVigenciaTermino As String, _
                                              ByVal sColunaChave As String, _
                                              ByVal sColunaVersao As String, _
                                              ByVal sColunaFonte As String, _
                                              ByVal iLinhaInicio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
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

            'Seta Parametros - Coluna NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaNCM = "", DBNull.Value, sColunaNCM) : i += 1

            'Seta Parametros - Coluna EX
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_ex"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaEX = "", DBNull.Value, sColunaEX) : i += 1

            'Seta Parametros - Coluna Federal Nacional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_federal_nacional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaImpostoFederalNacional = "", DBNull.Value, sColunaImpostoFederalNacional) : i += 1

            'Seta Parametros - Coluna Federal Importado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_federal_importados"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaImpostoFederalImportado = "", DBNull.Value, sColunaImpostoFederalImportado) : i += 1

            'Seta Parametros - Coluna Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaImpostoEstadual = "", DBNull.Value, sColunaImpostoEstadual) : i += 1

            'Seta Parametros - Coluna Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaImpostoMunicipal = "", DBNull.Value, sColunaImpostoMunicipal) : i += 1

            'Seta Parametros - Coluna Vigência Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_vigencia_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaVigenciaInicio = "", DBNull.Value, sColunaVigenciaInicio) : i += 1

            'Seta Parametros - Coluna Vigência Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_vigencia_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaVigenciaTermino = "", DBNull.Value, sColunaVigenciaTermino) : i += 1

            'Seta Parametros - Coluna Chave
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_chave"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaChave = "", DBNull.Value, sColunaChave) : i += 1

            'Seta Parametros - Coluna Versão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_versao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaVersao = "", DBNull.Value, sColunaVersao) : i += 1

            'Seta Parametros - Coluna Fonte
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_fonte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaFonte = "", DBNull.Value, sColunaFonte) : i += 1

            'Seta Parametros - Linha Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "linha_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = iLinhaInicio

            'Executa Query
            SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_integracao_importacao_ncm_aliquotas", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Salvar(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oRow As GridEXRow
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer

        Try

            'ProgressBar
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oGrid.GetDataRows.Count
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
            frmMain.stbMain.Panels("pnlProgressBar").Visible = True

            For Each oRow In oGrid.GetDataRows

                'Seta Váriavel 
                i = 0

                'Seta ProgressBar
                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

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

                'Seta Parametros - NCM
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ncm"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 10
                oSqlParameter(i).Value = oRow.Cells("codigo_ncm").Value : i += 1

                'Seta Parametros - EX Tipi
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "ex_tipi"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 3
                oSqlParameter(i).Value = oRow.Cells("ex_tipi").Value : i += 1

                'Seta Parametros - Federal Nacional
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "federal_nacional"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("nacional_federal").Value : i += 1

                'Seta Parametros - Federal Importados
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "federal_importados"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("importados_federal").Value : i += 1

                'Seta Parametros - Estadual
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "estadual"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("estadual").Value : i += 1

                'Seta Parametros - Municipal
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "municipal"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("municipal").Value : i += 1

                'Seta Parametros - Vigência Início
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "vigencia_inicio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = IIf(IsDate(oRow.Cells("vigencia_inicio").Value), oRow.Cells("vigencia_inicio").Value, DBNull.Value) : i += 1

                'Seta Parametros - Vigência Término
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "vigencia_termino"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = IIf(IsDate(oRow.Cells("vigencia_termino").Value), oRow.Cells("vigencia_termino").Value, DBNull.Value) : i += 1

                'Seta Parametros - Chave
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "chave"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oRow.Cells("chave").Value : i += 1

                'Seta Parametros - Versão
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "versao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oRow.Cells("versao").Value : i += 1

                'Seta Parametros - Fonte
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "fonte"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oRow.Cells("fonte").Value

                'Executa Query
                SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_ncm_aliquotas", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        Finally
            'Oculta ProgressBar
            frmMain.stbMain.Panels("pnlProgressBar").Visible = False
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default
        End Try


    End Sub

#End Region

#End Region

End Class

