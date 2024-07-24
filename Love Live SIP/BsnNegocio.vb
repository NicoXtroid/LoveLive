Imports System.Text.RegularExpressions

Public Class BsnNegocio
    Dim daoDatos As New DaoDatos()

    Function GetCarta()
        Return daoDatos.GetCarta()
    End Function

    Function GetCartaPorJugador(carta As Carta_jugador)
        Return daoDatos.GetCartaPorJugador(carta)
    End Function

    Function Disband(idUsuario As String, idMazo As Integer)
        Return daoDatos.Disband(idUsuario, idMazo)
    End Function


    Function GetCartaJugador()
        Return daoDatos.GetCartaJugador()
    End Function

    Function GetHabilidad()
        Return daoDatos.GetHabilidad()
    End Function

    Function GetIdol()
        Return daoDatos.GetIdol()
    End Function

    Function GetJugador()
        Return daoDatos.GetJugador()
    End Function

    Function GetMazo()
        Return daoDatos.GetMazo()
    End Function

    Function GetStats()
        Return daoDatos.GetStats()
    End Function

    Function ConsultarHabilidad(skill As Habilidad)
        Return daoDatos.ConsultarHabilidad(skill)
    End Function

    Function ConsultarCarta(carta As Carta)
        Return daoDatos.ConsultarCarta(carta)
    End Function

    Function ConsultarIdol(carta As Carta)
        Return daoDatos.ConsultarIdol(carta)
    End Function
    Function LlenarTablaCartas()
        Return daoDatos.LlenarTablaCartas()
    End Function

    Function LlenarTablaDetalle(carta As Carta)
        Return daoDatos.LlenarTablaDetalle(carta)
    End Function

    Function ObtenerStats(stats As Stats)
        Return daoDatos.ObtenerStats(stats)
    End Function
    Function getJugadores()
        Return daoDatos.GetJugadores

    End Function
    Function InsertarJugador(jugador As Jugador)
        Return daoDatos.insertarJugador(jugador)
    End Function
    Public Function ValidarUsuario(jugador As Jugador)
        Return daoDatos.ValidarUsuario(jugador)

    End Function
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function


    Public Function actualizar(carta As Carta_jugador)
        Return daoDatos.actualizar(carta)
    End Function
End Class
