<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.btnTeam = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.logo_shadow
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(439, 57)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(388, 119)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnMember
        '
        Me.btnMember.BackColor = System.Drawing.Color.Transparent
        Me.btnMember.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.Members
        Me.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMember.FlatAppearance.BorderSize = 0
        Me.btnMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMember.Location = New System.Drawing.Point(523, 548)
        Me.btnMember.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(221, 107)
        Me.btnMember.TabIndex = 1
        Me.btnMember.UseVisualStyleBackColor = False
        '
        'btnTeam
        '
        Me.btnTeam.BackColor = System.Drawing.Color.Transparent
        Me.btnTeam.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.Team
        Me.btnTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTeam.FlatAppearance.BorderSize = 0
        Me.btnTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeam.Location = New System.Drawing.Point(294, 548)
        Me.btnTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeam.Name = "btnTeam"
        Me.btnTeam.Size = New System.Drawing.Size(221, 107)
        Me.btnTeam.TabIndex = 2
        Me.btnTeam.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.Other
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(752, 548)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(221, 107)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.Uranohoshi_Girls_High_School_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1303, 656)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnTeam)
        Me.Controls.Add(Me.btnMember)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMember As Button
    Friend WithEvents btnTeam As Button
    Friend WithEvents btnLogout As Button
End Class
