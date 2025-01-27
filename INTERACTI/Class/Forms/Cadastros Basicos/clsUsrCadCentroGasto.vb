Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCadCentroGasto

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigoCentroGastoPai As Integer
    Private sCodigoCentroGasto As String
    Private sDescricao As String
    Private iCodigoTipoCentroGasto As Integer
    Private iCodigoFormaRateioCentroGasto As Integer
    Private iCodigoClassificacaoCentroGasto As Integer
    Private bAtivo As Boolean
    Private iCodigoCentroGasto As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoCentroGastoPai() As Integer
        Get
            Return iCodigoCentroGastoPai
        End Get
        Set(ByVal value As Integer)
            iCodigoCentroGastoPai = value
        End Set
    End Property

    Public Property CentroGasto() As String
        Get
            Return sCodigoCentroGasto
        End Get
        Set(ByVal value As String)
            sCodigoCentroGasto = value
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

    Public Property CodigoTipoCentroGasto() As Integer
        Get
            Return iCodigoTipoCentroGasto
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoCentroGasto = value
        End Set
    End Property

    Public Property CodigoFormaRateioCentroGasto() As Integer
        Get
            Return iCodigoFormaRateioCentroGasto
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaRateioCentroGasto = value
        End Set
    End Property

    Public Property CodigoClassificacaoCentroGasto() As Integer
        Get
            Return iCodigoClassificacaoCentroGasto
        End Get
        Set(ByVal value As Integer)
            iCodigoClassificacaoCentroGasto = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
        End Set
    End Property

    Public Property CodigoCentroGasto() As Integer
        Get
            Return iCodigoCentroGasto
        End Get
        Set(ByVal value As Integer)
            iCodigoCentroGasto = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CENTRO DE GASTO :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Centro de Gasto Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGastoPai = -1, DBNull.Value, iCodigoCentroGastoPai) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoCentroGasto : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo de Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoCentroGasto : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Forma de Rateio do Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_rateio_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaRateioCentroGasto = -1, DBNull.Value, iCodigoFormaRateioCentroGasto) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Classificação Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_classificacao_centro_gasto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoClassificacaoCentroGasto = -1, DBNull.Value, iCodigoClassificacaoCentroGasto) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_centro_custo", oSqlParameter)

            'Seta Váriavel
            iCodigoCentroGasto = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Centro de Gasto Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGastoPai = -1, DBNull.Value, iCodigoCentroGastoPai) : i += 1

            'Seta Parametros - Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoCentroGasto : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Tipo de Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoCentroGasto : i += 1

            'Seta Parametros - Código Forma de Rateio do Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_rateio_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaRateioCentroGasto = -1, DBNull.Value, iCodigoFormaRateioCentroGasto) : i += 1

            'Seta Parametros - Código Classificação Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_classificacao_centro_gasto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoClassificacaoCentroGasto = -1, DBNull.Value, iCodigoClassificacaoCentroGasto) : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

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
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroGasto

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_centro_custo", oSqlParameter)

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_centro_custo", oSqlParameter)

                'Exclui Nó
                oNode.Remove()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal iCodigoCentroGasto As Integer, _
                             ByVal cboCentroGastoPai As UIComboBox, _
                             ByVal cboTipoCentroGasto As UIComboBox, _
                             ByVal txtCodigoCentroGasto As MaskedEditBox, _
                             ByVal txtDescricaoCentroGasto As MaskedEditBox, _
                             ByVal cboFormaRateioCentroGasto As UIComboBox, _
                             ByVal cboClassificacaoCentroGasto As UIComboBox, _
                             ByVal cboAtivo As UIComboBox)

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
            oSqlParameter(i).Value = iCodigoCentroGasto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_centro_custo_dados", oSqlParameter)

            While oSqlDataReader.Read

                cboCentroGastoPai.SelectedValue = oSqlDataReader.Item("codigo_centro_custo_pai")
                cboTipoCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_tipo_centro_custo")
                txtCodigoCentroGasto.Text = oSqlDataReader.Item("codigo_centro_custo")
                txtDescricaoCentroGasto.Text = oSqlDataReader.Item("descricao")
                cboFormaRateioCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_forma_rateio_centro_custo")
                cboClassificacaoCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_classificacao_centro_gasto")
                cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCentroGasto(ByVal iCodigo As Integer, _
                                      ByVal sCodigoCentroGasto As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Parametros - Sigla
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoCentroGasto : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_centro_custo", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadTreeView(ByVal oTreeView As TreeView, _
                            ByVal sDescricao As String, _
                            Optional ByVal iNivel As Integer = 1)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nivel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(sDescricao = "", iNivel, -1) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_centro_custo_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Or sDescricao <> "" Then
                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("centro_custo_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                    If oSqlDataReader.Item("ativo") = False Then
                        oNode.ForeColor = Color.Firebrick
                    End If
                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho").ToString, oSqlDataReader.Item("centro_custo_filho"))
                    oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho")
                    If oSqlDataReader.Item("ativo") = False Then
                        oNodeFilho.ForeColor = Color.Firebrick
                    End If
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

    Public Sub LoadTreeViewFind(ByVal oTreeView As TreeView, _
                                ByVal sDescricao As String, _
                                ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Codigo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_centro_custo_item_treeview", oSqlParameter)
            
            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Or sDescricao <> "" Then
                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("centro_custo_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("centro_custo_filho"))
                    oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho")
                    
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

    Public Sub LoadTreeViewSelecionado(ByVal oTreeView As TreeView, _
                                       ByVal sDescricao As String, _
                                       Optional ByVal iNivel As Integer = 1)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nivel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(sDescricao = "", iNivel, -1) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_centro_custo_treeview", oSqlParameter)
            
            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Or sDescricao <> "" Then
                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("centro_custo_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                    oNode.Checked = True

                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("centro_custo_filho"))
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

#End Region

#End Region

End Class
