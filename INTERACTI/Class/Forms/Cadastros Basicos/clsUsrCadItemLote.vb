Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls 
Imports Janus.Windows.GridEX.EditControls

Public Class clsusrCadItemLote


#Region "::: FUNCTION / SUB :::"

    Public Sub Insert(ByVal iCodigoTipo As Integer, _
                      ByVal sCodigoClasse As String, _
                      ByVal sDescricaoFinal As String, _
                      ByVal sDescricaoFinal2 As String, _
                      ByVal iCodigoNCM As Integer, _
                      ByVal sNumeroDesenho As String, _
                      ByVal sSC As String, _
                      ByVal sDet As String, _
                      ByVal sPartNumberFinal As String, _
                      ByRef iCodigo As Integer, _
                      ByVal bDireito As Boolean, _
                      ByVal bEsquerdo As Boolean, _
                      ByVal bItemCompra As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - item compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bItemCompra : i += 1

            'Seta Parametros - Numero desenho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDesenho : i += 1


            'Seta Parametros - Direito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "direito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDireito : i += 1

            'Seta Parametros - Esquerdo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "esquerdo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEsquerdo : i += 1

            'Seta Parametros - SC 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSC : i += 1

            'Seta Parametros - DEt
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "det"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDet : i += 1

            'Seta Parametros - Código Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipo : i += 1

            'Seta Parametros - Código Classe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_classe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoClasse : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDescricaoFinal : i += 1

            'Seta Parametros - Descricao 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_final2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDescricaoFinal2 : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Part Number Final  
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPartNumberFinal : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_lote", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal lCodigo As Long, _
                      ByVal iCodigoTipo As Integer, _
                      ByVal sCodigoClasse As String, _
                      ByVal sDescricaoFinal As String, _
                      ByVal sDescricaoFinal2 As String, _
                      ByVal iCodigoNCM As Integer, _
                      ByVal sNumeroDesenho As String, _
                      ByVal sSC As String, _
                      ByVal sDet As String, _
                      ByVal sPartNumberFinal As String, _
                      ByVal bDireito As Boolean, _
                      ByVal bEsquerdo As Boolean, _
                      ByVal bItemCompra As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - item compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bItemCompra : i += 1

            'Seta Parametros - Numero desenho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDesenho : i += 1


            'Seta Parametros - Direito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "direito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDireito : i += 1

            'Seta Parametros - Esquerdo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "esquerdo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEsquerdo : i += 1

            'Seta Parametros - SC 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSC : i += 1

            'Seta Parametros - DEt
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "det"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDet : i += 1

            'Seta Parametros - Código Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipo : i += 1

            'Seta Parametros - Código Classe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_classe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoClasse : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDescricaoFinal : i += 1

            'Seta Parametros - Descricao 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_final2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDescricaoFinal2 : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Part Number Final  
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPartNumberFinal : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_lote", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0


                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteUnico(ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCodigo(ByVal lCodigo As Long, _
                                        ByVal sCodigoProduto As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaCodigo = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_produto", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCodigo = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sPnPai As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - PN Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pn_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sPnPai : i += 1
             
            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_lote", oSqlParameter)
            
            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("pn_pai"), oDataSet.Tables(1).Columns("pn_pai"))

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridItem(ByVal oGrid As GridEX, _
                            ByVal sNumeroDesenho As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Numero desenho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDesenho : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_lote_listagem", oSqlParameter)

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

    Public Sub LoadDadosClasse(ByVal sCodigoClasse As String, _
                               ByVal txtDescricao As MaskedEditBox, _
                               ByVal txtDescricao2 As MaskedEditBox, _
                               ByVal cboNCM As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Classe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_classe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.varchar
            oSqlParameter(i).Value = sCodigoClasse : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_lote_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                    txtDescricao.Text = oSqlDataReader.Item("descricao")
                    txtDescricao2.Text = oSqlDataReader.Item("descricao2")

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

    Public Sub LoadGridFindClasse(ByVal oGrid As GridEX, _
                                  ByVal iCodigoTipo As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - PN Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_find_classe_seng", oSqlParameter)

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

    Public Sub EditarProduto(ByVal lCodigoItem As Long, _
                             ByVal cboTipo As UIComboBox, _
                             ByVal cboClasse As UIComboBox, _
                             ByVal cboNCM As UIComboBox, _
                             ByVal txtNumeroDesenho As MaskedEditBox, _
                             ByVal txtSC As NumericEditBox, _
                             ByVal txtDET As NumericEditBox, _
                             ByVal chkEsquerda As UICheckBox, _
                             ByVal chkDireita As UICheckBox, _
                             ByVal txtPartNumberFinal As MaskedEditBox, _
                             ByVal chkItemCompra As UICheckBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_lote_dados_item", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    cboTipo.SelectedValue = oSqlDataReader.Item("codigo_tipo_seng")
                    cboClasse.SelectedValue = oSqlDataReader.Item("codigo_classe_seng")
                    cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                    txtNumeroDesenho.Text = oSqlDataReader.Item("numero_desenho")
                    txtSC.Text = oSqlDataReader.Item("sc")
                    txtDET.Text = oSqlDataReader.Item("det")
                    chkEsquerda.Checked = oSqlDataReader.Item("esquerdo")
                    chkDireita.Checked = oSqlDataReader.Item("direito")
                    txtPartNumberFinal.Text = oSqlDataReader.Item("codigo_item")
                    chkItemCompra.Checked = oSqlDataReader.Item("item_compra")
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

#End Region

End Class
