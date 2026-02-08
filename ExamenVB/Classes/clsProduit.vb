Public Class clsProduit

    Inherits clsBase
    Dim prix As Integer
    Dim qrImage As Byte

    Public Property Prix1 As Integer
        Get
            Return prix
        End Get
        Set(value As Integer)
            prix = value
        End Set
    End Property

    Public Property QrImage1 As Byte
        Get
            Return qrImage
        End Get
        Set(value As Byte)
            qrImage = value
        End Set
    End Property
End Class
