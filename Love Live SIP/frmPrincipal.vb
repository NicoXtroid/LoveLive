Public Class frmPrincipal
    Dim formLogin As New frmLogin
    Public Sub New()
        InitializeComponent()

        'Me.formLogin = formLogin


    End Sub
    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        Dim frmListarCartas As New FrmListar()
        frmListarCartas.Show()

        Me.Dispose()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        'Dim salir As New frmLogin
        'salir.ShowDialog()
        formLogin.Show()

        Me.Dispose()

    End Sub

    Private Sub btnTeam_Click(sender As Object, e As EventArgs) Handles btnTeam.Click
        Dim frmTeam As New frmEquipo()
        frmTeam.Show()

        Me.Dispose()
    End Sub
End Class