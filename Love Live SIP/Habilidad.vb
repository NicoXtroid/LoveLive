Public Class Habilidad
    Private _id As Integer
    Private _id_skill As Integer
    Private _nombre As String
    Private _efecto As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set

    End Property

    Public Property Id_Skill As Integer
        Get
            Return _id_skill
        End Get
        Set(value As Integer)
            _id_skill = value
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

    Public Property Efecto As String
        Get
            Return _efecto
        End Get
        Set(value As String)
            _efecto = value
        End Set

    End Property



End Class
