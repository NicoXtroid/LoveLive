Public Class Stats
    Private _id As Integer
    Private _id_carta As String
    Private _nivel As Integer
    Private _smile As Integer
    Private _pure As Integer
    Private _cool As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Id_carta As String
        Get
            Return _id_carta
        End Get
        Set(value As String)
            _id_carta = value
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
    Public Property Smile As Integer
        Get
            Return _smile
        End Get
        Set(value As Integer)
            _smile = value
        End Set
    End Property
    Public Property Pure As Integer
        Get
            Return _pure
        End Get
        Set(value As Integer)
            _pure = value
        End Set
    End Property
    Public Property Cool As Integer
        Get
            Return _cool
        End Get
        Set(value As Integer)
            _cool = value
        End Set
    End Property


End Class
