<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaifu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWaifu))
        Me.imgCarta = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.imgRareza = New System.Windows.Forms.PictureBox()
        Me.imgSub = New System.Windows.Forms.PictureBox()
        Me.imgGrupo = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.txtCarta = New System.Windows.Forms.TextBox()
        Me.txtIdol = New System.Windows.Forms.TextBox()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.txtSkill = New System.Windows.Forms.TextBox()
        Me.txtInstituto = New System.Windows.Forms.TextBox()
        Me.txtSmile = New System.Windows.Forms.TextBox()
        Me.txtPure = New System.Windows.Forms.TextBox()
        Me.txtCool = New System.Windows.Forms.TextBox()
        Me.txtSkillE = New System.Windows.Forms.RichTextBox()
        CType(Me.imgCarta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRareza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgCarta
        '
        Me.imgCarta.BackgroundImage = CType(resources.GetObject("imgCarta.BackgroundImage"), System.Drawing.Image)
        Me.imgCarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCarta.Location = New System.Drawing.Point(652, 33)
        Me.imgCarta.Margin = New System.Windows.Forms.Padding(4)
        Me.imgCarta.Name = "imgCarta"
        Me.imgCarta.Size = New System.Drawing.Size(365, 476)
        Me.imgCarta.TabIndex = 0
        Me.imgCarta.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Carta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(316, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Idol:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Rareza:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 341)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Instituto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(248, 438)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sub Unidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 438)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Group:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 377)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 28)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Curso:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 178)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 28)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Skill:"
        '
        'imgRareza
        '
        Me.imgRareza.BackColor = System.Drawing.Color.Transparent
        Me.imgRareza.BackgroundImage = CType(resources.GetObject("imgRareza.BackgroundImage"), System.Drawing.Image)
        Me.imgRareza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgRareza.Location = New System.Drawing.Point(152, 130)
        Me.imgRareza.Margin = New System.Windows.Forms.Padding(4)
        Me.imgRareza.Name = "imgRareza"
        Me.imgRareza.Size = New System.Drawing.Size(51, 43)
        Me.imgRareza.TabIndex = 11
        Me.imgRareza.TabStop = False
        '
        'imgSub
        '
        Me.imgSub.BackColor = System.Drawing.Color.Transparent
        Me.imgSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgSub.Location = New System.Drawing.Point(400, 418)
        Me.imgSub.Margin = New System.Windows.Forms.Padding(4)
        Me.imgSub.Name = "imgSub"
        Me.imgSub.Size = New System.Drawing.Size(115, 69)
        Me.imgSub.TabIndex = 14
        Me.imgSub.TabStop = False
        '
        'imgGrupo
        '
        Me.imgGrupo.BackColor = System.Drawing.Color.Transparent
        Me.imgGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgGrupo.Location = New System.Drawing.Point(127, 430)
        Me.imgGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.imgGrupo.Name = "imgGrupo"
        Me.imgGrupo.Size = New System.Drawing.Size(76, 60)
        Me.imgGrupo.TabIndex = 15
        Me.imgGrupo.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(37, 506)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(41, 37)
        Me.PictureBox6.TabIndex = 16
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(37, 550)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(41, 37)
        Me.PictureBox7.TabIndex = 17
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(37, 594)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(41, 37)
        Me.PictureBox8.TabIndex = 18
        Me.PictureBox8.TabStop = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(17, 16)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(114, 70)
        Me.btnRegresar.TabIndex = 19
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(787, 570)
        Me.dgvDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(148, 92)
        Me.dgvDetalle.TabIndex = 20
        Me.dgvDetalle.Visible = False
        '
        'txtCarta
        '
        Me.txtCarta.Enabled = False
        Me.txtCarta.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarta.Location = New System.Drawing.Point(148, 86)
        Me.txtCarta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCarta.Name = "txtCarta"
        Me.txtCarta.Size = New System.Drawing.Size(132, 34)
        Me.txtCarta.TabIndex = 21
        '
        'txtIdol
        '
        Me.txtIdol.Enabled = False
        Me.txtIdol.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdol.Location = New System.Drawing.Point(388, 86)
        Me.txtIdol.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdol.Name = "txtIdol"
        Me.txtIdol.Size = New System.Drawing.Size(200, 34)
        Me.txtIdol.TabIndex = 22
        '
        'txtCurso
        '
        Me.txtCurso.Enabled = False
        Me.txtCurso.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurso.Location = New System.Drawing.Point(127, 380)
        Me.txtCurso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(132, 34)
        Me.txtCurso.TabIndex = 23
        '
        'txtSkill
        '
        Me.txtSkill.Enabled = False
        Me.txtSkill.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSkill.Location = New System.Drawing.Point(112, 181)
        Me.txtSkill.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSkill.Name = "txtSkill"
        Me.txtSkill.Size = New System.Drawing.Size(203, 34)
        Me.txtSkill.TabIndex = 24
        '
        'txtInstituto
        '
        Me.txtInstituto.Enabled = False
        Me.txtInstituto.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstituto.Location = New System.Drawing.Point(152, 332)
        Me.txtInstituto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInstituto.Name = "txtInstituto"
        Me.txtInstituto.Size = New System.Drawing.Size(437, 34)
        Me.txtInstituto.TabIndex = 25
        '
        'txtSmile
        '
        Me.txtSmile.Enabled = False
        Me.txtSmile.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSmile.Location = New System.Drawing.Point(87, 506)
        Me.txtSmile.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSmile.Name = "txtSmile"
        Me.txtSmile.Size = New System.Drawing.Size(115, 34)
        Me.txtSmile.TabIndex = 26
        '
        'txtPure
        '
        Me.txtPure.Enabled = False
        Me.txtPure.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPure.Location = New System.Drawing.Point(87, 551)
        Me.txtPure.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPure.Name = "txtPure"
        Me.txtPure.Size = New System.Drawing.Size(115, 34)
        Me.txtPure.TabIndex = 27
        '
        'txtCool
        '
        Me.txtCool.Enabled = False
        Me.txtCool.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCool.Location = New System.Drawing.Point(87, 594)
        Me.txtCool.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCool.Name = "txtCool"
        Me.txtCool.Size = New System.Drawing.Size(115, 34)
        Me.txtCool.TabIndex = 28
        '
        'txtSkillE
        '
        Me.txtSkillE.Enabled = False
        Me.txtSkillE.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSkillE.Location = New System.Drawing.Point(112, 225)
        Me.txtSkillE.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSkillE.Name = "txtSkillE"
        Me.txtSkillE.Size = New System.Drawing.Size(532, 99)
        Me.txtSkillE.TabIndex = 29
        Me.txtSkillE.Text = ""
        '
        'frmWaifu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.Rooftop_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1033, 700)
        Me.Controls.Add(Me.txtSkillE)
        Me.Controls.Add(Me.txtCool)
        Me.Controls.Add(Me.txtPure)
        Me.Controls.Add(Me.txtSmile)
        Me.Controls.Add(Me.txtInstituto)
        Me.Controls.Add(Me.txtSkill)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.txtIdol)
        Me.Controls.Add(Me.txtCarta)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.imgGrupo)
        Me.Controls.Add(Me.imgSub)
        Me.Controls.Add(Me.imgRareza)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgCarta)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmWaifu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Carta"
        CType(Me.imgCarta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRareza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgCarta As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents imgRareza As PictureBox
    Friend WithEvents imgSub As PictureBox
    Friend WithEvents imgGrupo As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents txtCarta As TextBox
    Friend WithEvents txtIdol As TextBox
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents txtSkill As TextBox
    Friend WithEvents txtInstituto As TextBox
    Friend WithEvents txtSmile As TextBox
    Friend WithEvents txtPure As TextBox
    Friend WithEvents txtCool As TextBox
    Friend WithEvents txtSkillE As RichTextBox
End Class
