Public Class Listado_Jugadores
    Dim bsnNegocio As New BsnNegocio

    Private Sub Listado_Jugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_jugadores.DataSource = bsnNegocio.getJugadores()
        dgv_jugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_jugadores.Columns(0).Visible = False
        dgv_jugadores.Columns(2).Visible = False


    End Sub

    Private Sub bt_volver_Click(sender As Object, e As EventArgs) Handles bt_volver.Click
        frmLogin.Show()
        Me.Dispose()

    End Sub

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
        frmNuevo_Jugador.Show()
        Me.Dispose()

    End Sub
End Class