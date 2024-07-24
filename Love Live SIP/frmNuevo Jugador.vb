Public Class frmNuevo_Jugador
    Dim jugador As New Jugador()
    Dim bsnNegocion As New BsnNegocio


    Private Sub Nuevo_Jugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_usuario.Text = ""
        txt_contraseña.Text = ""
        txt_correo.Text = ""
    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Listado_Jugadores.Show()
        Me.Dispose()

    End Sub

    Private Sub bt_aceptar_Click(sender As Object, e As EventArgs) Handles bt_aceptar.Click
        Dim bln As Boolean = bsnNegocion.IsValidEmail(txt_correo.Text)

        If bln = True Then
            jugador.Usuario = txt_usuario.Text
            jugador.Contraseña = txt_contraseña.Text
            jugador.Correo = txt_correo.Text
            bsnNegocion.InsertarJugador(jugador)
            MsgBox("Jugador insertado correctamente", MsgBoxStyle.Information, "Alerta")
            Listado_Jugadores.Show()
            Me.Dispose()
        Else
            MsgBox("Correo erroneo", MsgBoxStyle.Information, "Alerta")
            txt_correo.Text = ""
        End If
    End Sub
End Class