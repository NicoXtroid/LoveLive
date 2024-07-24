
Imports System.Data.OleDb
Public Class FrmListar
    Dim bsnNegocio As New BsnNegocio()

    Public Sub New()

        InitializeComponent()
        DgvCartas.DataSource = bsnNegocio.LlenarTablaCartas()
        DgvCartas.Columns(0).Visible = False
        DgvCartas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Dim carta As New Carta()
        carta.Id = Integer.Parse(DgvCartas.Rows(0).Cells(1).Value)
        Dim stats As New Stats()
        stats.Id_carta = Integer.Parse(DgvCartas.Rows(0).Cells(1).Value)

        stats.Nivel = Integer.Parse(DgvCartas.Rows(0).Cells(6).Value)
        DgvHabilidad.DataSource = bsnNegocio.ObtenerStats(stats)
        lblCool.Text = Integer.Parse(DgvHabilidad.Rows.Item(0).Cells(5).Value)
        lblPure.Text = Integer.Parse(DgvHabilidad.Rows.Item(0).Cells(4).Value)
        lblSmile.Text = Integer.Parse(DgvHabilidad.Rows.Item(0).Cells(3).Value)
        pbWaifus.Image = Image.FromFile("../../ImagenesCartas/" + carta.Id.ToString + ".png")
        pbWaifus.SizeMode = PictureBoxSizeMode.StretchImage
        pb1.Image = Image.FromFile("../../Image/Atributo/Smile.png")
        pb1.SizeMode = PictureBoxSizeMode.StretchImage
        pb2.Image = Image.FromFile("../../Image/Atributo/Pure.png")
        pb2.SizeMode = PictureBoxSizeMode.StretchImage
        pb3.Image = Image.FromFile("../../Image/Atributo/Cool.png")
        pb3.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Public Sub FrmListar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pbWaifus.Image = Image.FromFile("../../ImagenesCartas/1353.png")
        pbWaifus.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub

    Private Sub DgvCartas_Click(sender As Object, e As EventArgs) Handles DgvCartas.Click
        Dim carta As New Carta()
        carta.Id = Integer.Parse(DgvCartas.SelectedRows.Item(0).Cells(1).Value)
        pbWaifus.Image = Image.FromFile("../../ImagenesCartas/" + carta.Id.ToString + ".png")
        pbWaifus.SizeMode = PictureBoxSizeMode.StretchImage
        Dim stats As New Stats()
        stats.Id_carta = DgvCartas.SelectedRows.Item(0).Cells(1).Value.ToString()

        stats.Nivel = Integer.Parse(DgvCartas.SelectedRows.Item(0).Cells(6).Value)
        DgvHabilidad.DataSource = bsnNegocio.ObtenerStats(stats)
        lblCool.Text = Integer.Parse(DgvHabilidad.Rows.Item(0).Cells(5).Value)
        lblPure.Text = Integer.Parse(DgvHabilidad.Rows.Item(0).Cells(4).Value)
        lblSmile.Text = Integer.Parse(DgvHabilidad.Rows.Item(0).Cells(3).Value)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSmile.Click

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim formPrincipal As New frmPrincipal
        formPrincipal.Show()

        Me.Dispose()
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        Dim carta As New Carta
        carta.Id_Carta = Integer.Parse(DgvCartas.SelectedRows.Item(0).Cells(1).Value)

        Dim frmDetalleCarta As New frmWaifu(carta)
        Me.Dispose()
        frmDetalleCarta.ShowDialog()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim carta As New Carta
        carta.Id_Carta = Integer.Parse(DgvCartas.SelectedRows.Item(0).Cells(1).Value)
        Dim formMazo As New FrmMazo(carta)
        formMazo.Show()
        Me.Hide()

        'formMazo.ShowDialog()
    End Sub
End Class