Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls


Public Class clsUsrCadPlanoContas

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sContaContabil As String
    Private sNomeConta As String
    Private sCodigoContaContabil As String
    Private sCodigoIntegracao As String
    Private sCodigoContaContabilOrigem As String
    Private bAtivo As Boolean
    Private sCodigo As String
    Private iCodigoCentroGasto As Integer
    Private iCodigoCFOP As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoCFOP() As Integer
        Get
            Return iCodigoCFOP
        End Get
        Set(ByVal value As Integer)
            iCodigoCFOP = value
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
    Public Property ContaContabil() As String
        Get
            Return sContaContabil
        End Get
        Set(ByVal value As String)
            sContaContabil = value
        End Set
    End Property

    Public Property NomeConta() As String
        Get
            Return sNomeConta
        End Get
        Set(ByVal value As String)
            sNomeConta = value
        End Set
    End Property

    Public Property CodigoContaContabil() As String
        Get
            Return sCodigoContaContabil
        End Get
        Set(ByVal value As String)
            sCodigoContaContabil = value
        End Set
    End Property

    Public Property CodigoContaContabilOrigem() As String
        Get
            Return sCodigoContaContabilOrigem
        End Get
        Set(ByVal value As String)
            sCodigoContaContabilOrigem = value
        End Set
    End Property

    Public Property CodigoIntegracao() As String
        Get
            Return sCodigoIntegracao
        End Get
        Set(ByVal value As String)
            sCodigoIntegracao = value
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

    Public Property Codigo() As String
        Get
            Return sCodigo
        End Get
        Set(ByVal value As String)
            sCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert(ByVal oTreeView As TreeView)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sContaContabil : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNomeConta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoContaContabil = -1, DBNull.Value, sCodigoContaContabil) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Integração
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_integracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoIntegracao = "", DBNull.Value, sCodigoIntegracao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Conta Contábil Origem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoContaContabilOrigem = -1, DBNull.Value, sCodigoContaContabilOrigem) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCFOP = -1, DBNull.Value, iCodigoCFOP)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_plano_contas", oSqlParameter)

            Dim oNodePai As TreeNode
            Dim oNodeFilho As TreeNode

            If sCodigoContaContabil <> -1 Then

                oNodePai = oTreeView.Nodes.Find(sCodigoContaContabil, True)(0)
                oNodePai.ForeColor = IIf(oNodePai.ForeColor = Color.ForestGreen, Color.ForestGreen, Color.Blue)
                oNodeFilho = oNodePai.Nodes.Add(sContaContabil, sContaContabil & " - " & sNomeConta)
                oNodeFilho.Tag = sContaContabil

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal oTreeView As TreeView)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Conta Contábil - Old
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil_old"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sContaContabil : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNomeConta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoContaContabil = -1, DBNull.Value, sCodigoContaContabil) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Conta Contábil Origem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoContaContabilOrigem = -1, DBNull.Value, sCodigoContaContabilOrigem) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Integração
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_integracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoIntegracao = "", DBNull.Value, sCodigoIntegracao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCFOP = -1, DBNull.Value, iCodigoCFOP)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_plano_contas", oSqlParameter)

            Dim oNodePai As TreeNode
            Dim oNodeFilho As TreeNode

            If sCodigoContaContabil <> -1 Then

                oNodePai = oTreeView.Nodes.Find(sCodigoContaContabil, True)(0)
                oNodePai.ForeColor = IIf(oNodePai.ForeColor = Color.ForestGreen, Color.ForestGreen, Color.Blue)
                oNodeFilho = oNodePai.Nodes.Add(sContaContabil, sContaContabil & " - " & sNomeConta)
                oNodeFilho.Tag = sContaContabil

            End If

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

                'Seta Parametros - Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "conta_contabil"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oNode.Tag : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_plano_contas", oSqlParameter)

                'Exclui Nó
                oNode.Remove()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosContaContabil(ByVal sContaContabil As String, _
                                      ByVal txtContaContabil As MaskedEditBox, _
                                      ByVal txtCodigoIntegracao As MaskedEditBox, _
                                      ByVal txtNomeConta As MaskedEditBox, _
                                      ByVal cboOrigem As UIComboBox, _
                                      ByVal cboItemSuperior As UIComboBox, _
                                      ByVal cboAtivo As UIComboBox, _
                                      ByVal cboCFOP As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sContaContabil

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_conta_contabil_dados", oSqlParameter)

            If oSqlDataReader.HasRows = False Then

                txtNomeConta.Text = ""
                txtContaContabil.Text = ""
                cboOrigem.SelectedIndex = -1
                cboItemSuperior.SelectedIndex = -1
                txtCodigoIntegracao.Text = ""
                cboAtivo.SelectedIndex = -1
                cboCFOP.SelectedIndex = -1

            Else

                While oSqlDataReader.Read

                    txtNomeConta.Text = oSqlDataReader.Item("nome_conta")
                    txtContaContabil.Text = oSqlDataReader.Item("conta_contabil")
                    txtContaContabil.Tag = oSqlDataReader.Item("conta_contabil")
                    txtCodigoIntegracao.Text = oSqlDataReader.Item("codigo_integracao")
                    cboOrigem.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil_origem")
                    cboItemSuperior.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil")
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")

                    If IsDBNull(oSqlDataReader("codigo_cfop")) Then
                        cboCFOP.SelectedIndex = -1
                    Else
                        cboCFOP.SelectedValue = oSqlDataReader("codigo_cfop")
                    End If

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_plano_contas_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Or sDescricao <> "" Then
                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("conta_contabil"), oSqlDataReader.Item("descricao"))
                    oNode.Tag = oSqlDataReader.Item("conta_contabil")
                    iNivel = oSqlDataReader.Item("nivel")
                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_conta_contabil_origem"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("conta_contabil"), oSqlDataReader.Item("descricao"))
                    oNodeFilho.Tag = oSqlDataReader.Item("conta_contabil")
                    
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
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_plano_contas_item_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Or sDescricao <> "" Then
                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("conta_contabil"), oSqlDataReader.Item("descricao"))
                    oNode.Tag = oSqlDataReader.Item("conta_contabil")
                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_conta_contabil_origem"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("conta_contabil"), oSqlDataReader.Item("descricao"))
                    oNodeFilho.Tag = oSqlDataReader.Item("conta_contabil")
                
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_plano_contas_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If iNivel = 1 Then

                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("conta_contabil_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                    iNivel = oSqlDataReader.Item("nivel")
                    oNode.Checked = True

                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("conta_contabil_filho"))
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

    Public Function ValidaCodigoContaContabil(ByVal sCodigo As String, _
                                              ByVal sContaContabil As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Parametros - Código Conta Contábil - Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigo : i += 1

            'Seta Parametros - Codigo Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sContaContabil : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_conta_contabil", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
