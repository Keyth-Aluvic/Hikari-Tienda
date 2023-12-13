'Primero se importan las capas de Datos y Entidad, para poder trabajar con ellas.
Imports Datos
Imports Entidad

Public Class ListaVenta

    'Se crean objetos DVenta y EVenta para capturar y procesar los datos.
    Dim ObjDVenta As New DVenta
    Dim ObjEVenta As New EVenta

    'Esta función se encarga de llenar la Grid, usando el procedimiento almacenado
    'Proc_listar_Finanzas, a través de la función DVenta_Listar, se ordenan los datos
    'y se les da nombre y ancho a cada columna.
    Private Sub FillGrid()
        dgvVentas.DataSource = ObjDVenta.DVenta_Listar
        Me.dgvVentas.Columns("IDVenta").DisplayIndex = 0
        Me.dgvVentas.Columns("IDVenta").Width = 45
        Me.dgvVentas.Columns("IDVenta").HeaderText = "#"
        Me.dgvVentas.Columns("IDVenta").ReadOnly = True
        Me.dgvVentas.Columns("Vendidos").DisplayIndex = 1
        Me.dgvVentas.Columns("Vendidos").Width = 55
        Me.dgvVentas.Columns("Vendidos").HeaderText = "Producto"
        Me.dgvVentas.Columns("Ganancias").DisplayIndex = 2
        Me.dgvVentas.Columns("Ganancias").Width = 55
        Me.dgvVentas.Columns("Ganancias").HeaderText = "Ganancia"
        Me.dgvVentas.Columns("Fecha").DisplayIndex = 3
        Me.dgvVentas.Columns("Fecha").Width = 75
        Me.dgvVentas.Columns("Fecha").HeaderText = "Fecha"
        Me.dgvVentas.Columns("IDProducto").DisplayIndex = 4
        Me.dgvVentas.Columns("IDProducto").Width = 45
        Me.dgvVentas.Columns("IDProducto").HeaderText = "#Prod."
    End Sub

    'Al cargar el formulario se llena la Grid con los datos de la tabla Finanzas, y se
    'deshabilita el botón Modificar.
    Private Sub ListaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid()
        'btnModificarVenta.Enabled = False
        TemaForm(Me)
    End Sub

    'Al hacer click en el contenido de la Grid, el botón se habilitará, con el fin de
    'poder modificar su contenido.
    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick
        'btnModificarVenta.Enabled = True
    End Sub

    'Al hacer click en el botón Modificar, se ejecutará el procedimiento almacenado 
    'Proc_modificar_Finanzas, que actualizará los datos de la fila seleccionada.
    Private Sub btnModificarVenta_Click(sender As Object, e As EventArgs)
        'Se entregan los valores de la fila que se haya modificado en la Grid, a un objeto
        'de la clase EVenta.
        ObjEVenta.IdVenta = dgvVentas.CurrentRow.Cells("IDVenta").EditedFormattedValue.ToString
        ObjEVenta.NombreCliente = dgvVentas.CurrentRow.Cells("Vendidos").EditedFormattedValue.ToString
        ObjEVenta.ValorCompra = dgvVentas.CurrentRow.Cells("Ganancias").EditedFormattedValue.ToString
        ObjEVenta.Fecha = dgvVentas.CurrentRow.Cells("Fecha").EditedFormattedValue.ToString
        ObjEVenta.IdProducto = dgvVentas.CurrentRow.Cells("IDProducto").EditedFormattedValue.ToString
        'Y se llama el procedimiento Modificar del DVenta.
        ObjDVenta.DVenta_Modificar(ObjEVenta)

        'Se muestra un mensaje informando que la modificación se ha realizado.
        MessageBox.Show("Venta modificada con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAtras4_Click(sender As Object, e As EventArgs) Handles btnAtras4.Click
        Me.Close()
        MenuP.Show()
    End Sub

    Private Sub ListaVenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MenuP.Show()
    End Sub
End Class