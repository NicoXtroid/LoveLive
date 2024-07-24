Public Class Carta
    Private _id As Integer
    Private _id_carta As String
    Private _id_idol As Integer
    Private _rareza As String
    Private _id_skill As Integer
    Private _sub_unidad As Integer
    Private _nivel As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set

    End Property

    Public Property Id_Carta As String
        Get
            Return _id_carta
        End Get
        Set(value As String)
            _id_carta = value
        End Set

    End Property

    Public Property Id_Idol As Integer
        Get
            Return _id_idol
        End Get
        Set(value As Integer)
            _id_idol = value
        End Set

    End Property

    Public Property Rareza As String
        Get
            Return _rareza
        End Get
        Set(value As String)
            _rareza = value
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

    Public Property Sub_unidad As Integer
        Get
            Return _sub_unidad
        End Get
        Set(value As Integer)
            _sub_unidad = value
        End Set
    End Property

    Public Property Nivel As Integer
        Get
            Return _nivel
        End Get
        Set(value As Integer)
            _nivel = value
        End Set
    End Property


End Class
