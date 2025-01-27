Option Strict Off
Option Explicit On

Imports System.Xml.Serialization
Imports System.IO
Imports System.IO.File

Namespace NFe.Cabecalho

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe"), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe", IsNullable:=False)> _
    Partial Public Class cabecMsg

        Public Sub Save(ByVal sFileName As String)

            Dim oStreamWriter As StreamWriter

            Try

                oStreamWriter = CreateText(sFileName)
                Dim oXmlSerializer As New XmlSerializer(GetType(cabecMsg))
                oXmlSerializer.Serialize(oStreamWriter, Me)

            Finally
                oStreamWriter.Close()
            End Try

        End Sub

        Public Shared Function Load(ByVal sFileName As String) As cabecMsg

            Dim oFileStream As FileStream
            Dim oReturn As cabecMsg

            Try

                oFileStream = OpenRead(sFileName)
                Dim oXmlSerializer As New XmlSerializer(GetType(cabecMsg))
                oReturn = oXmlSerializer.Deserialize(oFileStream)

            Finally
                oFileStream.Close()
            End Try

            Return oReturn

        End Function

        Private versaoDadosField As String

        Private versaoField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="token")> _
        Public Property versaoDados() As String
            Get
                Return Me.versaoDadosField
            End Get
            Set(ByVal value As String)
                Me.versaoDadosField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="token")> _
        Public Property versao() As String
            Get
                Return Me.versaoField
            End Get
            Set(ByVal value As String)
                Me.versaoField = value
            End Set
        End Property

    End Class

End Namespace