
Imports System.Windows.Forms
Imports WMPLib

Public Class frmWaifu
    Dim bsnNegocio As New BsnNegocio()

    Public Sub New()
        InitializeComponent()
        'My.Computer.Audio.Play("../../Music/Love_Live_SIP_OP.WAV")

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim formLista As New FrmListar()

        Me.Dispose()
        formLista.ShowDialog()

    End Sub

    Private Sub frmWaifu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Sub New(carta As Carta)
        InitializeComponent()
        'My.Computer.Audio.Play("../../Music/Love_Live_SIP_OP.WAV")
        'MsgBox(carta.Id_Carta, MsgBoxStyle.Information, "Alerta")

        dgvDetalle.DataSource = bsnNegocio.LlenarTablaDetalle(carta)


        txtCarta.Text = Integer.Parse(dgvDetalle.Rows.Item(0).Cells(0).Value)
        txtIdol.Text = dgvDetalle.Rows.Item(0).Cells(3).Value
        txtInstituto.Text = dgvDetalle.Rows.Item(0).Cells(5).Value
        txtCurso.Text = Integer.Parse(dgvDetalle.Rows.Item(0).Cells(6).Value)
        txtSkill.Text = dgvDetalle.Rows.Item(0).Cells(7).Value
        txtSkillE.Text = dgvDetalle.Rows.Item(0).Cells(8).Value

        txtSmile.Text = Integer.Parse(dgvDetalle.Rows.Item(0).Cells(9).Value)
        txtCool.Text = Integer.Parse(dgvDetalle.Rows.Item(0).Cells(10).Value)
        txtPure.Text = Integer.Parse(dgvDetalle.Rows.Item(0).Cells(11).Value)


        imgGrupo.Image = Image.FromFile("../../Image/main/" & dgvDetalle.Rows.Item(0).Cells(4).Value & ".png")
        imgGrupo.SizeMode = PictureBoxSizeMode.StretchImage

        imgRareza.Image = Image.FromFile("../../Image/Rareza/" & dgvDetalle.Rows.Item(0).Cells(1).Value & ".png")
        imgRareza.SizeMode = PictureBoxSizeMode.StretchImage

        imgSub.Image = Image.FromFile("../../Image/sub/" & dgvDetalle.Rows.Item(0).Cells(2).Value & ".png")
        imgSub.SizeMode = PictureBoxSizeMode.StretchImage

        imgCarta.Image = Image.FromFile("../../ImagenesCartas/" & dgvDetalle.Rows.Item(0).Cells(0).Value & ".png")
        imgCarta.SizeMode = PictureBoxSizeMode.StretchImage


    End Sub


End Class
