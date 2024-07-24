<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_Jugadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listado_Jugadores))
        Me.dgv_jugadores = New System.Windows.Forms.DataGridView()
        Me.bt_volver = New System.Windows.Forms.Button()
        Me.bt_nuevo = New System.Windows.Forms.Button()
        CType(Me.dgv_jugadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_jugadores
        '
        Me.dgv_jugadores.AllowUserToAddRows = False
        Me.dgv_jugadores.AllowUserToResizeColumns = False
        Me.dgv_jugadores.AllowUserToResizeRows = False
        Me.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_jugadores.Location = New System.Drawing.Point(17, 108)
        Me.dgv_jugadores.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_jugadores.Name = "dgv_jugadores"
        Me.dgv_jugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_jugadores.Size = New System.Drawing.Size(681, 190)
        Me.dgv_jugadores.TabIndex = 0
        '
        'bt_volver
        '
        Me.bt_volver.BackColor = System.Drawing.Color.Transparent
        Me.bt_volver.BackgroundImage = CType(resources.GetObject("bt_volver.BackgroundImage"), System.Drawing.Image)
        Me.bt_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_volver.FlatAppearance.BorderSize = 0
        Me.bt_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bt_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bt_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_volver.Location = New System.Drawing.Point(17, 13)
        Me.bt_volver.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_volver.Name = "bt_volver"
        Me.bt_volver.Size = New System.Drawing.Size(93, 60)
        Me.bt_volver.TabIndex = 1
        Me.bt_volver.UseVisualStyleBackColor = False
        '
        'bt_nuevo
        '
        Me.bt_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.bt_nuevo.BackgroundImage = CType(resources.GetObject("bt_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.bt_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_nuevo.FlatAppearance.BorderSize = 0
        Me.bt_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bt_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bt_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_nuevo.Location = New System.Drawing.Point(505, 336)
        Me.bt_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Size = New System.Drawing.Size(193, 67)
        Me.bt_nuevo.TabIndex = 2
        Me.bt_nuevo.UseVisualStyleBackColor = False
        '
        'Listado_Jugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(715, 416)
        Me.Controls.Add(Me.bt_nuevo)
        Me.Controls.Add(Me.bt_volver)
        Me.Controls.Add(Me.dgv_jugadores)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Listado_Jugadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Jugadores"
        CType(Me.dgv_jugadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_jugadores As DataGridView
    Friend WithEvents bt_volver As Button
    Friend WithEvents bt_nuevo As Button
End Class
