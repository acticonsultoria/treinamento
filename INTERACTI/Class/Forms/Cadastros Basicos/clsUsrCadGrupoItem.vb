Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class clsUsrCadGrupoItem

#Region "::: VARIÁVEIS :::"

    Private iCodigo As Integer

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

#Region "::: GRUPO DE ITEM :::"

    Public Sub Insert(ByVal sDescricao As String,
                      ByVal bAtivo As Boolean,
                      ByVal iCodigoGrupoItemPai As Integer,
                      ByVal sSigla As String,
                      ByVal iCodigoMaterial As Integer,
                      ByVal iCodigoTipoPerfil As Integer,
                      ByVal iCodigoFamilia As Integer,
                      ByVal iCodigoTipoItemSPED As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            ''Seta Parametros - Código Grupo Item
            'oSqlParameter(i) = New SqlParameter
            'oSqlParameter(i).ParameterName = "codigo_grupo_item"
            'oSqlParameter(i).Direction = ParameterDirection.Input
            'oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            'oSqlParameter(i).Size = 20
            'oSqlParameter(i).Value = sCodigoGrupoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Grupo de Item Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoGrupoItemPai = -1, DBNull.Value, iCodigoGrupoItemPai) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sigla
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sigla"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sSigla : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMaterial = -1, DBNull.Value, iCodigoMaterial) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_perfil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTipoPerfil = -1, DBNull.Value, iCodigoTipoPerfil) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item_sped"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTipoItemSPED = -1, DBNull.Value, iCodigoTipoItemSPED) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_familia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFamilia = -1, DBNull.Value, iCodigoFamilia) : i += 1 : ReDim Preserve oSqlParameter(i)


            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_grupo_item", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal iCodigo As Integer,
                      ByVal sDescricao As String,
                      ByVal bAtivo As Boolean,
                      ByVal iCodigoGrupoItemPai As Integer,
                      ByVal sSigla As String,
                      ByVal iCodigoMaterial As Integer,
                      ByVal iCodigoTipoPerfil As Integer,
                      ByVal iCodigoFamilia As Integer,
                      ByVal iCodigoTipoItemSPED As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            ''Seta Parametros - Código Grupo Item
            'oSqlParameter(i) = New SqlParameter
            'oSqlParameter(i).ParameterName = "codigo_grupo_item"
            'oSqlParameter(i).Direction = ParameterDirection.Input
            'oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            'oSqlParameter(i).Size = 20
            'oSqlParameter(i).Value = sCodigoGrupoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Grupo de Item Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoGrupoItemPai = -1, DBNull.Value, iCodigoGrupoItemPai) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sigla
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sigla"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sSigla : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMaterial = -1, DBNull.Value, iCodigoMaterial) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_perfil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTipoPerfil = -1, DBNull.Value, iCodigoTipoPerfil) : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item_sped"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTipoItemSPED = -1, DBNull.Value, iCodigoTipoItemSPED) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_familia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFamilia = -1, DBNull.Value, iCodigoFamilia) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_grupo_item", oSqlParameter)

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

            For Each oNode As TreeNode In gSelecaoNode

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oNode.Tag : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_grupo_item", oSqlParameter)

                oNode.Remove()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCodigoGrupoItem(ByVal iCodigo As Integer, _
                                          ByVal sCodigoGrupoItem As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoGrupoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_grupo_item", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sCodigoGrupoItem As String, _
                        ByVal sDescricao As String, _
                        ByVal iCodigoGrupoItemPai As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sCodigoGrupoItem : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Grupo de Item Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItemPai : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grupo_item", oSqlParameter)

            'Seta DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadTreeView(ByVal oTreeView As TreeView, _
                            ByVal sGrupoItem As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sGrupoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grupo_item_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Then

                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")

                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode
                    Try
                        oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                        oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                        oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho")
                    Catch
                        Dim oNode As TreeNode
                        oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                        oNode.Tag = oSqlDataReader.Item("codigo_filho")
                    End Try

                End If

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadTreeViewMarca(ByVal oTreeView As TreeView, _
                                 ByVal iCodigoMarca As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMarca : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grupo_item_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Then

                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                    oNode.Checked = True

                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                    oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho")
                    oNodeFilho.Checked = True

                End If

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadTreeViewChecked(ByVal oTreeView As TreeView, _
                                   ByVal sGrupoItem As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sGrupoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grupo_item_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Then

                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                    oNode.Checked = True

                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                    oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho")
                    oNodeFilho.Checked = True

                End If

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadTreeViewCheckedVenda(ByVal oTreeView As TreeView, _
                                        ByVal sGrupoItem As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sGrupoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grupo_item_treeview_venda", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Then

                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                    oNode.Checked = True

                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("grupo_item_filho"))
                    oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho")
                    oNodeFilho.Checked = True

                End If

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal iCodigoGrupoItem As Integer, _
                             ByVal txtCodigoGrupoItem As MaskedEditBox, _
                             ByVal txtDescricao As MaskedEditBox, _
                             ByVal txtSigla As MaskedEditBox, _
                             ByVal cboGrupoItemPai As UIComboBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal cboMaterial As UIComboBox, _
                             ByVal cboTipoPerfil As UIComboBox, _
                             ByVal cboTipoItemSPED As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grupo_item_dados", oSqlParameter)

            While oSqlDataReader.Read

                txtCodigoGrupoItem.Text = oSqlDataReader.Item("codigo_grupo_item")
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtSigla.Text = oSqlDataReader.Item("sigla")
                cboGrupoItemPai.SelectedValue = oSqlDataReader.Item("codigo_grupo_item_pai")
                cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")

                If Not IsDBNull(oSqlDataReader.Item("codigo_material")) Then
                    cboMaterial.SelectedValue = oSqlDataReader.Item("codigo_material")
                Else
                    cboMaterial.SelectedIndex = -1
                End If

                If Not IsDBNull(oSqlDataReader.Item("codigo_tipo_perfil")) Then
                    cboTipoPerfil.SelectedValue = oSqlDataReader.Item("codigo_tipo_perfil")
                Else
                    cboTipoPerfil.SelectedIndex = -1
                End If
            
                If Not IsDBNull(oSqlDataReader.Item("codigo_tipo_item_sped")) Then
                    cboTipoItemSPED.SelectedValue = oSqlDataReader.Item("codigo_tipo_item_sped")
                Else
                    cboTipoItemSPED.SelectedIndex = -1
                End If
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

#Region "::: GRUPO DE ITEM - ALTERAR :::"

    Public Sub LoadGridAlterar(ByVal oGrid As GridEX, _
                               ByVal iCodigoGrupoItem As Integer, _
                               ByVal sItem As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grupo_item_alterar", oSqlParameter)

            'Seta DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AlterarGrupoItem(ByVal iCodigoGrupoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Grupo Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_grupo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_grupo_item", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DuplicarEstrutura(ByVal iCodigo As Integer,
                                 ByVal iCodigoPai As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - codigo pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoPai = -1, DBNull.Value, iCodigoPai)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_grupo_item_duplicar_estrutura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
