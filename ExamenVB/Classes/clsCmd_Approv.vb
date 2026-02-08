Public Class clsCmd_Approv

    Inherits clsBase
    Dim codeCl_Fss As String

    Public Property CodeCl_Fss1 As String
        Get
            Return codeCl_Fss
        End Get
        Set(value As String)
            If Len(value) > 10 Then
                Throw New Exception("La longueur doit être inférieure ou égal à 10")
            Else
                If value.Contains("-") Or value.Contains("&") Or value.Contains("éè") Or value.Contains(")_à@é=+") Or value.Contains(" ") Then
                    Throw New Exception("Le code est invalide")
                Else
                    codeCl_Fss = value
                End If
            End If
        End Set
    End Property
End Class
