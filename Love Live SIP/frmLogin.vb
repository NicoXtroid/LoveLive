Imports System.Windows.Forms
Imports WMPLib

Public Class frmLogin

    Dim bsnNegocio As New BsnNegocio()
    Dim xy As Integer

    Public Sub New()
        InitializeComponent()

        'My.Computer.Audio.Play("../../Music/Love_Live_SIP_OP.WAV")

    End Sub



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_usuario.Text = ""
        txt_contraseña.Text = ""
        My.Computer.Audio.Play("../../Music/Love_Live_SIP_OP.wav")
    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Application.Exit()

    End Sub

    
    Function datosUsuario()
        Dim usuarioRegistrado As New Jugador()
        usuarioRegistrado.Usuario = txt_usuario.Text
        Return usuarioRegistrado
    End Function

    Private Sub bt_aceptar_Click(sender As Object, e As EventArgs) Handles bt_aceptar.Click
        Dim jugador As New Jugador(txt_usuario.Text, txt_contraseña.Text)
        If bsnNegocio.ValidarUsuario(jugador) Then
            'Me.Hide()

            Dim Principal As New frmPrincipal()
            Principal.Show()
            Me.Hide()

        Else
            MsgBox("El usuario y/o contraseña es inválido", MsgBoxStyle.Information, "Alerta")
            txt_usuario.Text = ""
            txt_contraseña.Text = ""
        End If
    End Sub

    Private Sub lb_nuevo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lb_nuevo.LinkClicked
        Listado_Jugadores.Show()
        Me.Hide()

    End Sub
End Class