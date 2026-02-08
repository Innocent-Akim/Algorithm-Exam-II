Public Class clsMouvementCompt

    Inherits clsBase

    Dim codeDebit, codeCredit, libelle As String
    Dim montDebit, montCredit As Double

    Public Property CodeCredit1 As String
        Get
            Return codeCredit
        End Get
        Set(value As String)
            If Len(value) > 10 Then
                Throw New Exception("La longueur du code crédit doit être inférieure ou égal à 10")
            Else
                If value.Contains("-") Or value.Contains("&") Or value.Contains("éè") Or value.Contains(")_à@é=+") Or value.Contains(" ") Then
                    Throw New Exception("Le code est invalide")
                Else
                    codeCredit = value
                End If
            End If
        End Set
    End Property

    Public Property CodeDebit1 As String
        Get
            Return codeDebit
        End Get
        Set(value As String)
            If Len(value) > 10 Then
                Throw New Exception("La longueur du code debit doit être inférieure ou égal à 10")
            Else
                If value.Contains("-") Or value.Contains("&") Or value.Contains("éè") Or value.Contains(")_à@é=+") Or value.Contains(" ") Then
                    Throw New Exception("Le code est invalide")
                Else
                    codeDebit = value
                End If
            End If
        End Set
    End Property

    Public Property Libelle1 As String
        Get
            Return libelle
        End Get
        Set(value As String)
            If Len(value) > 255 Then
                Throw New Exception("La longueur de libellé doit être inférieure ou égal à 255")
            Else
                libelle = value
            End If
        End Set
    End Property

    Public Property MontCredit1 As Double
        Get
            Return montCredit
        End Get
        Set(value As Double)
            If value.ToString.Contains(" ") Or value < 0 Or Not IsNumeric(value.ToString.Trim) Then
                Throw New Exception("Montant crédit invalide")
            Else
                montCredit = value
            End If
        End Set
    End Property

    Public Property MontDebit1 As Double
        Get
            Return montDebit
        End Get
        Set(value As Double)
            If value.ToString.Contains(" ") Or value < 0 Or Not IsNumeric(value.ToString.Trim) Then
                Throw New Exception("Montant débit invalide")
            Else
                montDebit = value
            End If
        End Set
    End Property
End Class
