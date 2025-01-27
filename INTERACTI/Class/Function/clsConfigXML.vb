Imports System.Xml

Public Class clsConfigXML

#Region "::: VÁRIAVEIS :::"

    Private sStringConnection As String
    Private sDataSource As String
    Private sInitialCatalog As String
    Private sUserID As String
    Private sPassword As String
    Private oXmlDocument As XmlDocument
    Private sReportPath As String

#End Region

#Region "::: CONSTRUTOR :::"

    Sub New()

        'Carrega Arquivo
        LoadXML()

    End Sub

#End Region

#Region "::: DESTRUTOR :::"

    Sub Terminate()

        'Fecha Arquivo
        oXmlDocument = Nothing

    End Sub

#End Region

#Region "::: PROPERTY :::"

    Public Property StringConnection()
        Get
            Return sStringConnection
        End Get
        Set(ByVal value)
            sStringConnection = value
        End Set
    End Property

    Public Property DataSource()
        Get
            Return sDataSource
        End Get
        Set(ByVal value)
            sDataSource = value
        End Set
    End Property

    Public Property InitialCatalog()
        Get
            Return sInitialCatalog
        End Get
        Set(ByVal value)
            sInitialCatalog = value
        End Set
    End Property

    Public Property UserID()
        Get
            Return sUserID
        End Get
        Set(ByVal value)
            sUserID = value
        End Set
    End Property

    Public Property Password()
        Get
            Return sPassword
        End Get
        Set(ByVal value)
            sPassword = value
        End Set
    End Property

    Public Property ReportPath() As String
        Get
            Return sReportPath
        End Get
        Set(ByVal value As String)
            sReportPath = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadXML()

        Try

            'Seta Variavel
            oXmlDocument = New XmlDocument()

            'Abre o Arquivo XML
            oXmlDocument.Load(ApplicationPath() & "XmlConfig\Config.xml")

            'Inicia TreeView
            IniciarTreeView()

            'Chama XML
            ChamaXML()

        Catch ex As Exception

            'Informa o Usuário sobre o Erro Ocorrido
            MsgBox("Arquivo de Configuração do Banco de Dados não foi encontrado. Contate o Administrador do Sistema." + vbNewLine + ex.Message, MsgBoxStyle.Critical, gAplicacao)
            End

        End Try

    End Sub

    Private Sub IniciarTreeView()

        'Variaveis Locais
        Dim oTreeNode As New TreeNode("XML")

        LerNos(oXmlDocument.DocumentElement, oTreeNode)

        oTreeNode.ExpandAll()

    End Sub

    Private Sub LerNos(ByVal oXmlNode As XmlNode, ByVal oTreeNode As TreeNode)

        'Variaveis Locais
        Dim sInfo As String

        If oXmlNode.NodeType = XmlNodeType.Comment OrElse oXmlNode.NodeType = XmlNodeType.Text Then
            sInfo = oXmlNode.NodeType.ToString() & ":" & oXmlNode.Value
        Else
            sInfo = oXmlNode.NodeType.ToString() & ":" & oXmlNode.Name
        End If

        Dim OTreeNodeFilho As TreeNode = oTreeNode.Nodes.Add(sInfo)

        ' ... e então chamo este método recursivamente para cada nó filho.
        For Each xn As XmlNode In oXmlNode.ChildNodes
            LerNos(xn, OTreeNodeFilho)
        Next

    End Sub

    Private Sub ChamaXML()

        Dim oXmlNodeList As XmlNodeList = oXmlDocument.GetElementsByTagName("ConfigDatabase")

        For Each oXmlNode As XmlNode In oXmlNodeList
            sStringConnection = (oXmlNode.SelectSingleNode("./StringConnection").InnerText)
            sDataSource = (oXmlNode.SelectSingleNode("./DataSource").InnerText)
            sInitialCatalog = (oXmlNode.SelectSingleNode("./InitialCatalog").InnerText)
            sUserID = (oXmlNode.SelectSingleNode("./UserID").InnerText)
            sPassword = (oXmlNode.SelectSingleNode("./Password").InnerText)
        Next

        oXmlNodeList = oXmlDocument.GetElementsByTagName("Report")

        For Each oXmlNode As XmlNode In oXmlNodeList
            sReportPath = (oXmlNode.SelectSingleNode("./Path").InnerText)
        Next

    End Sub

#End Region

End Class
