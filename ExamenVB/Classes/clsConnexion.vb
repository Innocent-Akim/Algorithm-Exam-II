Imports System.IO
Imports System.Windows.Forms

Public Class clsConnexion

    Public chemin As String

    Public Function readFilePath(cheminDoc As String)

        Try
            chemin = File.ReadAllText(cheminDoc).Trim()
            Return chemin
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

End Class
