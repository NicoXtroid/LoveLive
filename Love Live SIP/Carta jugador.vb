Public Class Carta_jugador
    Private _id As Integer
    Private _id_carta As String
    Private _usuario As String
    Private _id_mazo As Integer

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

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Id_Mazo As Integer
        Get
            Return _id_mazo
        End Get
        Set(value As Integer)
            _id_mazo = value
        End Set
    End Property


End Class
