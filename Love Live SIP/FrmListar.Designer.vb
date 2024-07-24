<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListar
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
        Me.DgvCartas = New System.Windows.Forms.DataGridView()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblSmile = New System.Windows.Forms.Label()
        Me.lblPure = New System.Windows.Forms.Label()
        Me.lblCool = New System.Windows.Forms.Label()
        Me.DgvHabilidad = New System.Windows.Forms.DataGridView()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pbWaifus = New System.Windows.Forms.PictureBox()
        CType(Me.DgvCartas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvHabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWaifus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCartas
        '
        Me.DgvCartas.AllowUserToAddRows = False
        Me.DgvCartas.AllowUserToDeleteRows = False
        Me.DgvCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCartas.Location = New System.Drawing.Point(17, 16)
        Me.DgvCartas.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvCartas.Name = "DgvCartas"
        Me.DgvCartas.ReadOnly = True
        Me.DgvCartas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvCartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCartas.Size = New System.Drawing.Size(1016, 636)
        Me.DgvCartas.TabIndex = 0
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.Back2
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(1315, 695)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(165, 71)
        Me.btnAtras.TabIndex = 1
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.Transparent
        Me.btnDetalle.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.Details
        Me.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDetalle.FlatAppearance.BorderSize = 0
        Me.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Location = New System.Drawing.Point(1096, 695)
        Me.btnDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(165, 71)
        Me.btnDetalle.TabIndex = 2
        Me.btnDetalle.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.AddtoTeam
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(868, 695)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(165, 71)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblSmile
        '
        Me.lblSmile.AutoSize = True
        Me.lblSmile.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmile.Location = New System.Drawing.Point(1161, 500)
        Me.lblSmile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSmile.Name = "lblSmile"
        Me.lblSmile.Size = New System.Drawing.Size(0, 37)
        Me.lblSmile.TabIndex = 8
        '
        'lblPure
        '
        Me.lblPure.AutoSize = True
        Me.lblPure.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPure.Location = New System.Drawing.Point(1161, 559)
        Me.lblPure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPure.Name = "lblPure"
        Me.lblPure.Size = New System.Drawing.Size(0, 37)
        Me.lblPure.TabIndex = 9
        '
        'lblCool
        '
        Me.lblCool.AutoSize = True
        Me.lblCool.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCool.Location = New System.Drawing.Point(1161, 618)
        Me.lblCool.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCool.Name = "lblCool"
        Me.lblCool.Size = New System.Drawing.Size(0, 37)
        Me.lblCool.TabIndex = 10
        '
        'DgvHabilidad
        '
        Me.DgvHabilidad.AllowUserToAddRows = False
        Me.DgvHabilidad.AllowUserToDeleteRows = False
        Me.DgvHabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHabilidad.Location = New System.Drawing.Point(39, 660)
        Me.DgvHabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvHabilidad.Name = "DgvHabilidad"
        Me.DgvHabilidad.ReadOnly = True
        Me.DgvHabilidad.Size = New System.Drawing.Size(205, 107)
        Me.DgvHabilidad.TabIndex = 11
        Me.DgvHabilidad.Visible = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.Transparent
        Me.pb3.Location = New System.Drawing.Point(1096, 615)
        Me.pb3.Margin = New System.Windows.Forms.Padding(4)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(41, 37)
        Me.pb3.TabIndex = 7
        Me.pb3.TabStop = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.Transparent
        Me.pb2.Location = New System.Drawing.Point(1096, 559)
        Me.pb2.Margin = New System.Windows.Forms.Padding(4)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(41, 37)
        Me.pb2.TabIndex = 6
        Me.pb2.TabStop = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Transparent
        Me.pb1.Location = New System.Drawing.Point(1096, 500)
        Me.pb1.Margin = New System.Windows.Forms.Padding(4)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(41, 38)
        Me.pb1.TabIndex = 5
        Me.pb1.TabStop = False
        '
        'pbWaifus
        '
        Me.pbWaifus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbWaifus.Location = New System.Drawing.Point(1096, 16)
        Me.pbWaifus.Margin = New System.Windows.Forms.Padding(4)
        Me.pbWaifus.Name = "pbWaifus"
        Me.pbWaifus.Size = New System.Drawing.Size(363, 476)
        Me.pbWaifus.TabIndex = 4
        Me.pbWaifus.TabStop = False
        '
        'FrmListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Love_Live_SIP.My.Resources.Resources.Otonokizaka_high_school_7
        Me.ClientSize = New System.Drawing.Size(1505, 801)
        Me.Controls.Add(Me.DgvHabilidad)
        Me.Controls.Add(Me.lblCool)
        Me.Controls.Add(Me.lblPure)
        Me.Controls.Add(Me.lblSmile)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.pbWaifus)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.DgvCartas)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmListar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Idols"
        CType(Me.DgvCartas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvHabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWaifus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvCartas As DataGridView
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnDetalle As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents pbWaifus As PictureBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents lblSmile As Label
    Friend WithEvents lblPure As Label
    Friend WithEvents lblCool As Label
    Friend WithEvents DgvHabilidad As DataGridView
End Class
