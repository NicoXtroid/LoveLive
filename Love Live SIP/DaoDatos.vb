Imports System.Data.OleDb

Public Class DaoDatos
    Dim conexion As New Conexion()


    Function GetCarta()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Carta"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function

    Function GetCartaPorJugador(carta As Carta_jugador)
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "Select * from Carta_jugador where usuario = '" & carta.Usuario & "' and id_mazo =  " & carta.Id_Mazo & ""
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function


    Function Disband(idUsuario As String, idMazo As Integer)
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "Update Carta_Jugador set id_carta = 0 where usuario = '" & idUsuario & "' and id_mazo =  " & idMazo & ""
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset

    End Function



    Function GetCartaJugador()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Carta_Jugador"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function

    Function GetHabilidad()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Habilidad"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function


    Function GetIdol()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Idol"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function

    Function GetJugador()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Jugador"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function

    Function GetMazo()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Mazo"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function

    Function GetStats()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Stats"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function


    Function ConsultarHabilidad(skill As Habilidad)
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Habilidad where id_skill = " & skill.Id_Skill & ""
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function

    Function ConsultarCarta(carta As Carta)
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Carta where id_carta = " & carta.Id_Carta & ""
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function

    Function ConsultarIdol(carta As Carta)
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Idol where id_idol = " & carta.Id_Idol & ""
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function

    Function LlenarTablaDetalle(carta As Carta)
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "select ca.id_carta, ca.rareza, ca.sub_unidad, idl.nombre, idl.main_unit,
                               idl.instituto, idl.curso, sk.nombre, sk.efecto, st.smile, st.cool, st.pure 
                               from Carta ca, Idol idl, Habilidad sk, Stats st where 
                               ca.id_idol = idl.id_idol and 
                               ca.id_skill = sk.id_skill and 
                               (ca.id_carta = st.id_carta and ca.nivel = st.nivel) and 
                               ca.id_carta = '" & carta.Id_Carta & "'"

        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)
        conexion.CerrarConexion()
        Return dataset.Tables(0)

    End Function

    Function LlenarTablaCartas()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "select ca.Id, ca.id_carta as Carta, idl.nombre as Nombre, ca.rareza as Rareza, skill.nombre as Skill, ca.sub_unidad as Sub_Unidad, ca.nivel as Nivel
                               from Carta ca, Idol idl, Habilidad skill 
                               where ca.id_idol = idl.id_idol and 
                               ca.id_skill = skill.id_skill"

        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)
        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function

    Function ObtenerStats(stats As Stats)
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "Select * from Stats where id_carta = '" & stats.Id_carta & "' and nivel = " & stats.Nivel & ""
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function
    Function GetJugadores()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet
        command.Connection = conexion.GetConexion
        conexion.AbrirConexion()
        command.CommandText = "Select * from Jugador"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)
        conexion.CerrarConexion()
        Return dataset.Tables(0)
    End Function

    Function insertarJugador(jugador As Jugador)
        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()
        command.CommandText = "Insert into Jugador (usuario,contraseña,correo) values ('" & jugador.Usuario & "','" & jugador.Contraseña & "','" & jugador.Correo & "')"
        command.ExecuteNonQuery()
        conexion.CerrarConexion()
        '------------------------------------------------------------------------------------

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()
        For i = 1 To 9

            For j = 1 To 9
                command.CommandText = "Insert into Carta_jugador (id_carta,usuario,id_mazo) values ('" & 0 & "','" & jugador.Usuario & "','" & i & "')"
                command.ExecuteNonQuery()
            Next
        Next

        conexion.CerrarConexion()
        Return jugador

    End Function
    Public Function ValidarUsuario(jugador As Jugador)

        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()


        command.CommandText = "select * from Jugador where usuario = '" & jugador.Usuario & "' and contraseña ='" & jugador.Contraseña & "'"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0).Rows.Count



    End Function

    Function actualizar(carta As Carta_jugador)
        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()
        command.CommandText = "Update Carta_jugador set id_carta ='" & carta.Id_Carta & "' Where usuario ='" & carta.Usuario & "' and id_mazo =" & carta.Id_Mazo & " and id =" & carta.Id & ""
        command.ExecuteNonQuery()
        conexion.CerrarConexion()
        Return carta
    End Function


End Class
