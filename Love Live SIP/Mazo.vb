Public Class Mazo
    Private _id As Integer
    Private _id_mazo As Integer
    Private _nombre As String



    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property




End Class
