Public Class clsBase
    Dim code, noms, designation, sexe, adresse, contact, codeProduit As String
    Dim qte As Integer
    Dim dte As Date

    Public Property Adresse1 As String
        Get
            Return adresse
        End Get
        Set(value As String)
            If Len(value) <= 100 Then
                adresse = value
            Else
                Throw New Exception("La longueur de l'adresse doit être inférieure ou égal à 100")
            End If
        End Set
    End Property

    Public Property Code1 As String
        Get
            Return code
        End Get
        Set(value As String)
            If Len(value) > 10 Then
                Throw New Exception("La longueur du code doit être inférieure ou égal à 10")
            Else
                If value.Contains("-") Or value.Contains("&") Or value.Contains("é") Or value.Contains("@") Or value.Contains(" ") Or value.Contains(";") Or value.Contains("!") Or value.Contains("°") Then
                    Throw New Exception("Le code est invalide")
                Else
                    If value.Contains(":") Or value.Contains(",") Or value.Contains("é") Or value.Contains("_") Or value.Contains("?") Or value.Contains("(") Or value.Contains(")") Then
                        Throw New Exception("Le code est invalide")
                    Else
                        If value.Contains("<") Or value.Contains(">") Or value.Contains("#") Or value.Contains("%") Or value.Contains("*") Or value.Contains("=") Or value.Contains("+") Then
                            Throw New Exception("Le code est invalide")
                        Else
                            code = value
                        End If
                    End If
                End If
            End If
        End Set
    End Property

    Public Property Contact1 As String
        Get
            Return contact
        End Get
        Set(value As String)
            If Len(value) <> 13 Or value.Contains(" ") Or Not value.Contains("+") Then
                Throw New Exception("Le numéro doit être en 13 caractères et doit commencer par le signe +")
            Else
                contact = value
            End If
        End Set
    End Property

    Public Property Designation1 As String
        Get
            Return designation
        End Get
        Set(value As String)
            If Len(value) > 50 Then
                Throw New Exception("La longueur de la designation doit être inférieure ou égal à 50")
            Else
                designation = value
            End If
        End Set
    End Property

    Public Property Noms1 As String
        Get
            Return noms
        End Get
        Set(value As String)
            If Len(value) > 50 Then
                Throw New Exception("La longueur du noms doit être inférieure ou égal à 50")
            Else
                noms = value
            End If
        End Set
    End Property

    Public Property Qte1 As Integer
        Get
            Return qte
        End Get
        Set(value As Integer)
            If value.ToString.Contains(" ") Or value < 0 Or Not IsNumeric(value.ToString.Trim) Then
                Throw New Exception("Quantité invalide")
            Else
                qte = value
            End If
        End Set
    End Property

    Public Property Sexe1 As String
        Get
            Return sexe
        End Get
        Set(value As String)
            If Len(value) > 4 Then
                Throw New Exception("La longueur du sexe doit être inférieure ou égal à 4")
            Else
                sexe = value
            End If
        End Set
    End Property

    Public Property Dte1 As Date
        Get
            Return dte
        End Get
        Set(value As Date)
            Dim i As Integer
            i = DateDiff(DateInterval.Day, CDate(value), DateTime.Now)
            If (i > 0) Then
                Throw New Exception("La date doit prendre una valeur ou égale à celle d'aujourd'hui")
            Else
                dte = value
            End If
        End Set
    End Property

    Public Property CodeProduit1 As String
        Get
            Return codeProduit
        End Get
        Set(value As String)
            If Len(value) > 10 Then
                Throw New Exception("La longueur du code produit doit être inférieure ou égal à 10")
            Else
                If value.Contains("-") Or value.Contains("&") Or value.Contains("éè") Or value.Contains(")_à@é=+") Or value.Contains(" ") Then
                    Throw New Exception("Le code est invalide")
                Else
                    codeProduit = value
                End If
            End If
        End Set
    End Property
End Class
