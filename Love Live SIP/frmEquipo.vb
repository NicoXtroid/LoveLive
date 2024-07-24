Public Class frmEquipo
    Dim bsnNegocio As New BsnNegocio()
    Public Sub New()
        InitializeComponent()
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()

        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 1


        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Public Sub New(carta As Carta)

        InitializeComponent()

        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()

        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 1
        MsgBox(cartita.Usuario)
        MsgBox(cartita.Id_Mazo)

        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)

    End Sub

    Public Sub llenarImagenesMazo(carta As Carta_jugador)
        Dim cart As Integer

        cart = Integer.Parse(dgvCartas.Rows(0).Cells(1).Value)
        If cart <> 0 Then
            pb0.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb0.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb0.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb0.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        cart = Integer.Parse(dgvCartas.Rows(1).Cells(1).Value)
        If cart <> 0 Then
            pb1.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb1.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        cart = Integer.Parse(dgvCartas.Rows(2).Cells(1).Value)
        If cart <> 0 Then
            pb2.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb2.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb2.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb2.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        cart = Integer.Parse(dgvCartas.Rows(3).Cells(1).Value)
        If cart <> 0 Then
            pb3.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb3.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb3.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb3.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        cart = Integer.Parse(dgvCartas.Rows(4).Cells(1).Value)
        If cart <> 0 Then
            pb4.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb4.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb4.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb4.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        cart = Integer.Parse(dgvCartas.Rows(5).Cells(1).Value)
        If cart <> 0 Then
            pb5.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb5.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb5.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb5.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        cart = Integer.Parse(dgvCartas.Rows(6).Cells(1).Value)
        If cart <> 0 Then
            pb6.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb6.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb6.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb6.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        cart = Integer.Parse(dgvCartas.Rows(7).Cells(1).Value)
        If cart <> 0 Then
            pb7.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb7.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb7.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb7.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        cart = Integer.Parse(dgvCartas.Rows(8).Cells(1).Value)
        If cart <> 0 Then
            pb8.Image = Image.FromFile("../../WaifuIcon/" + cart.ToString() + ".png")
            pb8.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pb8.Image = Image.FromFile("../../WaifuIcon/" + "NoWaifu" + ".png")
            pb8.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub FrmMazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTeam2_Click(sender As Object, e As EventArgs) Handles btnTeam2.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 2
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Private Sub btnTeam1_Click(sender As Object, e As EventArgs) Handles btnTeam1.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 1
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Private Sub btnTeam3_Click(sender As Object, e As EventArgs) Handles btnTeam3.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 3
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Private Sub btnTeam4_Click(sender As Object, e As EventArgs) Handles btnTeam4.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 4
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 5
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Private Sub btnTeam6_Click(sender As Object, e As EventArgs) Handles btnTeam6.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 6
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim formPrincipal As New frmPrincipal
        formPrincipal.Show()

        Me.Dispose()
    End Sub

    Private Sub btnDisband_Click(sender As Object, e As EventArgs) Handles btnDisband.Click
        Dim us As String
        Dim maz As Integer

        us = dgvCartas.Rows.Item(0).Cells(2).Value
        maz = Integer.Parse(dgvCartas.Rows.Item(0).Cells(3).Value)
        If MessageBox.Show("Esta seguro que deseea Eliminar??", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then

            bsnNegocio.Disband(us, maz)
            MsgBox("Eliminación correcta", MsgBoxStyle.Information, "Alerta")
            '////////////////////
            Dim datosUsuarios As New Jugador()
            datosUsuarios = frmLogin.datosUsuario()

            Dim cartita As New Carta_jugador()
            cartita.Usuario = datosUsuarios.Usuario
            cartita.Id_Mazo = maz
            dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
            llenarImagenesMazo(cartita)
        End If

    End Sub

    Private Sub btnTeam7_Click(sender As Object, e As EventArgs) Handles btnTeam7.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 7
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Private Sub btnTeam8_Click(sender As Object, e As EventArgs) Handles btnTeam8.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 8
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub

    Private Sub btnTeam9_Click(sender As Object, e As EventArgs) Handles btnTeam9.Click
        Dim datosUsuarios As New Jugador()
        datosUsuarios = frmLogin.datosUsuario()
        Dim cartita As New Carta_jugador()
        cartita.Usuario = datosUsuarios.Usuario
        cartita.Id_Mazo = 9
        dgvCartas.DataSource = bsnNegocio.GetCartaPorJugador(cartita)
        llenarImagenesMazo(cartita)
    End Sub
End Class