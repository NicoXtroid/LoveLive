Public Class Jugador
    Private _id As Integer
    Private _usuario As String
    Private _contraseña As String
    Private _correo As String
    Public Sub New()
        MyBase.New()

    End Sub
    Public Sub New(usuario As String, contraseña As String)
        MyBase.New()
        _usuario = usuario
        _contraseña = contraseña
    End Sub
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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


    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property


End Class
