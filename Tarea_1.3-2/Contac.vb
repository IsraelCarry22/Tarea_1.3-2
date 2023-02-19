Public Class Contac

    Private _gmail As String
    Private _telephone As String

    Public Property Telefono As String
        Get
            Return _telephone
        End Get
        Set(value As String)
            _telephone = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _gmail
        End Get
        Set(ByVal value As String)
            _gmail = value
        End Set
    End Property

    Public Sub New()
        _gmail = String.Empty
        _telephone = String.Empty
    End Sub

    Public Sub New(ByVal _telephone As String, ByVal _gmail As String)
        Me._gmail = _gmail
        Me._telephone = _telephone
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & Telefono
    End Function
End Class