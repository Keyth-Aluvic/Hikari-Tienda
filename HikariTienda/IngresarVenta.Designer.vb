<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IngresarVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresarVenta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtValorCompra = New System.Windows.Forms.TextBox()
        Me.txtRutCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIngresarVenta = New System.Windows.Forms.Button()
        Me.btnAtras2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Pink
        Me.GroupBox1.Controls.Add(Me.txtIdProducto)
        Me.GroupBox1.Controls.Add(Me.txtValorCompra)
        Me.GroupBox1.Controls.Add(Me.txtRutCliente)
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(9, 206)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.ReadOnly = True
        Me.txtIdProducto.Size = New System.Drawing.Size(91, 20)
        Me.txtIdProducto.TabIndex = 7
        '
        'txtValorCompra
        '
        Me.txtValorCompra.Location = New System.Drawing.Point(9, 149)
        Me.txtValorCompra.Name = "txtValorCompra"
        Me.txtValorCompra.ReadOnly = True
        Me.txtValorCompra.Size = New System.Drawing.Size(91, 20)
        Me.txtValorCompra.TabIndex = 6
        '
        'txtRutCliente
        '
        Me.txtRutCliente.Location = New System.Drawing.Point(9, 91)
        Me.txtRutCliente.Name = "txtRutCliente"
        Me.txtRutCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtRutCliente.TabIndex = 5
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(9, 32)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(135, 20)
        Me.txtNombreCliente.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "# Producto*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ganancias:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'btnIngresarVenta
        '
        Me.btnIngresarVenta.BackColor = System.Drawing.Color.Pink
        Me.btnIngresarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarVenta.Location = New System.Drawing.Point(81, 265)
        Me.btnIngresarVenta.Name = "btnIngresarVenta"
        Me.btnIngresarVenta.Size = New System.Drawing.Size(75, 35)
        Me.btnIngresarVenta.TabIndex = 1
        Me.btnIngresarVenta.Text = "Vender"
        Me.btnIngresarVenta.UseVisualStyleBackColor = False
        '
        'btnAtras2
        '
        Me.btnAtras2.BackColor = System.Drawing.Color.Pink
        Me.btnAtras2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAtras2.Location = New System.Drawing.Point(21, 271)
        Me.btnAtras2.Name = "btnAtras2"
        Me.btnAtras2.Size = New System.Drawing.Size(26, 23)
        Me.btnAtras2.TabIndex = 3
        Me.btnAtras2.Text = "↩"
        Me.btnAtras2.UseVisualStyleBackColor = False
        '
        'IngresarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(240, 312)
        Me.Controls.Add(Me.btnAtras2)
        Me.Controls.Add(Me.btnIngresarVenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IngresarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtValorCompra As TextBox
    Friend WithEvents txtRutCliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIngresarVenta As Button
    Friend WithEvents btnAtras2 As Button
End Class
