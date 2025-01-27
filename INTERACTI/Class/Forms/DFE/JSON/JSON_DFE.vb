
Namespace DFE_EVENTO
    Public Class JSON_DFE_EVENTO

        Public Class Data
            Public Property chave_acesso As String
            Public Property data_emissao As DateTime
            Public Property tipo_evento As String
            Public Property sequencia As Integer
            Public Property correcao As String
            Public Property nsu As String
            Public Property cnpj As String
            Public Property evento As String
            Public Property razao_social As String
            Public Property valor As Double
            Public Property codigo_tipo_nota_fiscal As Integer
        End Class

        Public Class Root
            Public Property data As Data()
        End Class

    End Class
End Namespace