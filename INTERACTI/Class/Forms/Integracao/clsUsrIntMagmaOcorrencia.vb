Public Class OcorrenciaInfo
    Public Property list As List(Of List)
End Class

Public Class Guid
    Public Property rendered As String
End Class

Public Class Title
    Public Property rendered As String
End Class

Public Class Excerpt
    Public Property rendered As String
    Public Property [protected] As Boolean
End Class

Public Class Self
    Public Property href As String
End Class

Public Class Collection
    Public Property href As String
End Class

Public Class About
    Public Property href As String
End Class

Public Class WpAttachment
    Public Property href As String
End Class

Public Class Cury
    Public Property name As String
    Public Property href As String
    Public Property templated As Boolean
End Class

Public Class Links
    Public Property self As Self()
    Public Property collection As Collection()
    Public Property about As About()
    'Public Property wp:attachment As WpAttachment()
    Public Property curies As Cury()
End Class

Public Class Ocorrencia
    Public Property id As Integer
    Public Property [date] As DateTime
    Public Property date_gmt As DateTime
    Public Property guid As Guid
    Public Property modified As DateTime
    Public Property modified_gmt As DateTime
    Public Property slug As String
    Public Property status As String
    Public Property type As String
    Public Property link As String
    Public Property title As Title
    Public Property excerpt As Excerpt
    Public Property template As String
    Public Property protocolo As String
    Public Property codrevend As String
    Public Property numeronf As String
    Public Property semananf As String
    Public Property codprod_0 As String
    Public Property codprod_1 As String
    Public Property codprod_2 As Object
    Public Property codprod_3 As Object
    Public Property codprod_4 As Object
    Public Property nomeprod_0 As String
    Public Property nomeprod_1 As String
    Public Property nomeprod_2 As Object
    Public Property nomeprod_3 As Object
    Public Property nomeprod_4 As Object
    Public Property qtdprod_0 As String
    Public Property qtdprod_1 As String
    Public Property qtdprod_2 As Object
    Public Property qtdprod_3 As Object
    Public Property qtdprod_4 As Object
    Public Property motivo_0 As String
    Public Property motivo_1 As String
    Public Property motivo_2 As Object
    Public Property motivo_3 As Object
    Public Property motivo_4 As Object
    Public Property obs_0 As String
    Public Property obs_1 As String
    Public Property obs_2 As Object
    Public Property obs_3 As Object
    Public Property obs_4 As Object
    Public Property distconsul As String
    Public Property grpconsultora As String
    Public Property ocexportado As String
    Public Property stsprod_0 As String
    Public Property stsprod_3 As String
    Public Property stsprod_2 As String
    Public Property stsprod_1 As String
    Public Property stsprod_4 As String
    Public Property _links As Links
End Class
Public Class List

    Public Property ocorrencia As List(Of Ocorrencia)
End Class
