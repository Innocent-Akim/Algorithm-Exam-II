Public Class clsOpDebitCredit
    Inherits clsBase
    Dim numCompt As String
    Public Property NumCompt1 As String
        Get
            Return numCompt
        End Get
        Set(value As String)
            If value.ToString.Contains(" ") Or value.ToString.Contains("-") Or Not IsNumeric(value.ToString.Trim) Then
                Throw New Exception("Numéro compte invalide")
            Else
                numCompt = value
            End If
        End Set
    End Property
End Class
