<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaVenta))
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnAtras4 = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.Pink
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.GridColor = System.Drawing.Color.DarkOrchid
        Me.dgvVentas.Location = New System.Drawing.Point(12, 12)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(463, 238)
        Me.dgvVentas.TabIndex = 0
        '
        'btnAtras4
        '
        Me.btnAtras4.BackColor = System.Drawing.Color.Pink
        Me.btnAtras4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAtras4.Location = New System.Drawing.Point(21, 282)
        Me.btnAtras4.Name = "btnAtras4"
        Me.btnAtras4.Size = New System.Drawing.Size(26, 23)
        Me.btnAtras4.TabIndex = 3
        Me.btnAtras4.Text = "↩"
        Me.btnAtras4.UseVisualStyleBackColor = False
        '
        'ListaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(488, 333)
        Me.Controls.Add(Me.btnAtras4)
        Me.Controls.Add(Me.dgvVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de Venta"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnAtras4 As Button
End Class
