Imports System.IO

Public Class clsPDFCreator

    Private pdftk_filename As String = "pdftk.exe" ' nome do ficheiro

    Public Function PDFCreatorExists() As Boolean
        Return File.Exists(ApplicationPath() & pdftk_filename)
    End Function

    Public Function GetPDFCreatorFilename() As String
        Return (ApplicationPath() & pdftk_filename)
    End Function

    Public Sub MergePDFFiles(ByVal FilesToMerge As String, ByVal NewPDFFileName As String)
        Process.Start(GetPDFCreatorFilename(), FilesToMerge & " cat output " & NewPDFFileName)
    End Sub

End Class

