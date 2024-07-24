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
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pbWaifus = New System.Windows.Forms.PictureBox()
        Me.lblSmile = New System.Windows.Forms.Label()
        Me.lblPure = New System.Windows.Forms.Label()
        Me.lblCool = New System.Windows.Forms.Label()
        Me.DgvHabilidad = New System.Windows.Forms.DataGridView()
        CType(Me.DgvCartas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWaifus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvHabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCartas
        '
        Me.DgvCartas.AllowUserToAddRows = False
        Me.DgvCartas.AllowUserToDeleteRows = False
        Me.DgvCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCartas.Location = New System.Drawing.Point(13, 13)
        Me.DgvCartas.Name = "DgvCartas"
        Me.DgvCartas.ReadOnly = True
        Me.DgvCartas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvCartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCartas.Size = New System.Drawing.Size(762, 517)
        Me.DgvCartas.TabIndex = 0
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(986, 565)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(124, 58)
        Me.btnAtras.TabIndex = 1
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(822, 565)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(124, 58)
        Me.btnDetalle.TabIndex = 2
        Me.btnDetalle.Text = "Ver Detalle"
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(651, 565)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(124, 58)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar al Album"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'pb3
        '
        Me.pb3.Location = New System.Drawing.Point(822, 500)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(31, 30)
        Me.pb3.TabIndex = 7
        Me.pb3.TabStop = False
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(822, 454)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(31, 30)
        Me.pb2.TabIndex = 6
        Me.pb2.TabStop = False
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(822, 406)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(31, 31)
        Me.pb1.TabIndex = 5
        Me.pb1.TabStop = False
        '
        'pbWaifus
        '
        Me.pbWaifus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbWaifus.Location = New System.Drawing.Point(822, 13)
        Me.pbWaifus.Name = "pbWaifus"
        Me.pbWaifus.Size = New System.Drawing.Size(273, 387)
        Me.pbWaifus.TabIndex = 4
        Me.pbWaifus.TabStop = False
        '
        'lblSmile
        '
        Me.lblSmile.AutoSize = True
        Me.lblSmile.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmile.Location = New System.Drawing.Point(871, 406)
        Me.lblSmile.Name = "lblSmile"
        Me.lblSmile.Size = New System.Drawing.Size(0, 28)
        Me.lblSmile.TabIndex = 8
        '
        'lblPure
        '
        Me.lblPure.AutoSize = True
        Me.lblPure.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPure.Location = New System.Drawing.Point(871, 454)
        Me.lblPure.Name = "lblPure"
        Me.lblPure.Size = New System.Drawing.Size(0, 28)
        Me.lblPure.TabIndex = 9
        '
        'lblCool
        '
        Me.lblCool.AutoSize = True
        Me.lblCool.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCool.Location = New System.Drawing.Point(871, 502)
        Me.lblCool.Name = "lblCool"
        Me.lblCool.Size = New System.Drawing.Size(0, 28)
        Me.lblCool.TabIndex = 10
        '
        'DgvHabilidad
        '
        Me.DgvHabilidad.AllowUserToAddRows = False
        Me.DgvHabilidad.AllowUserToDeleteRows = False
        Me.DgvHabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHabilidad.Location = New System.Drawing.Point(29, 536)
        Me.DgvHabilidad.Name = "DgvHabilidad"
        Me.DgvHabilidad.ReadOnly = True
        Me.DgvHabilidad.Size = New System.Drawing.Size(154, 87)
        Me.DgvHabilidad.TabIndex = 11
        Me.DgvHabilidad.Visible = False
        '
        'FrmListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 651)
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
        Me.Name = "FrmListar"
        Me.Text = "FrmListar"
        CType(Me.DgvCartas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWaifus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvHabilidad, System.ComponentModel.ISupportInitialize).EndInit()
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
