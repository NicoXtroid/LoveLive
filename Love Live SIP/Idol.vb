Public Class Idol
    Private _id As Integer
    Private _id_idol As Integer
    Private _nombre As String
    Private _cumpleaños As String
    Private _main_unit As String
    Private _instituto As String
    Private _curso As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Id_idol As Integer
        Get
            Return _id_idol
        End Get
        Set(value As Integer)
            _id_idol = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Cumpleaños As String
        Get
            Return _cumpleaños
        End Get
        Set(value As String)
            _cumpleaños = value
        End Set
    End Property

    Public Property Main_unit As String
        Get
            Return _main_unit
        End Get
        Set(value As String)
            _main_unit = value
        End Set
    End Property

    Public Property Instituto As String
        Get
            Return _instituto
        End Get
        Set(value As String)
            _instituto = value
        End Set
    End Property

    Public Property Curso As Integer
        Get
            Return _curso
        End Get
        Set(value As Integer)
            _curso = value
        End Set
    End Property

End Class
