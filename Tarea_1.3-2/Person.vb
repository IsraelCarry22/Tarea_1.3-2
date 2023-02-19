Public Class Person
    Inherits Contac

    'atributos de la calse'
    Private _name As String
    Private _last_name_father As String
    Private _last_name_mother As String
    Private _birthdate As DateTime?

    'propiedades'
    Public Property Nombre As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Apellido_Paterno As String
        Get
            Return _last_name_father
        End Get
        Set(ByVal value As String)
            _last_name_father = value
        End Set
    End Property

    Public Property Apellido_Materno As String
        Get
            Return _last_name_mother
        End Get
        Set(ByVal value As String)
            _last_name_mother = value
        End Set
    End Property

    Public Property Fecha_Cumpleaños As DateTime?
        Get
            Return _birthdate
        End Get
        Set(ByVal value As DateTime?)
            _birthdate = value
        End Set
    End Property

    Public ReadOnly Property Edad As Integer
        Get
            Dim _age As Integer
            _age = (DateTime.Now.Year - Fecha_Cumpleaños.Value.Year)
            Return _age
        End Get
    End Property

    'Contructores'
    Public Sub New()
        MyBase.New()
        _name = String.Empty
        _last_name_father = String.Empty
        _last_name_mother = String.Empty
        _birthdate = Nothing
    End Sub

    Public Sub New(ByVal _name As String, ByVal _last_name_father As String, ByVal _last_name_mother As String, ByVal _birthdate As DateTime?, ByVal _telephone As String, ByVal _gmail As String)
        MyBase.New(_gmail, _telephone)
        Me._name = _name
        Me._last_name_father = _last_name_father
        Me._last_name_mother = _last_name_mother
        Me._birthdate = _birthdate
    End Sub

    Public Overrides Function ToString() As String
        Return _name.ToUpper() & Edad
    End Function
End Class