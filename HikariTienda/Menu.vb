'Primero se importan las capas de Datos y Entidad, para poder trabajar con ellas.
Imports Datos
Imports Entidad

Public Class MenuP

    'A continuación se encuentran los procesos de cada uno de los 4 Button que tiene este
    'menu, donde cada uno muestra el formulario correspondiente.
    Private Sub btnIngresarProducto_Click(sender As Object, e As EventArgs) Handles btnIngresarProducto.Click
        IngresarProducto.Show()
        Me.Hide()
    End Sub

    'Se crean objetos DProducto y EProducto para capturar y procesar los datos.
    Public ObjDProducto As New DProducto
    Public ObjEProducto As New EProducto

    'Esta función se encarga de llenar la Grid, usando el procedimiento almacenado
    'Proc_listar_Producto, a través de la función DProducto_Listar, se ordenan los datos
    'y se les da nombre y ancho a cada columna.
    Public Sub FillGrid()
        dgvInventario.DataSource = ObjDProducto.DProducto_Listar
        Me.dgvInventario.Columns("IDProducto").DisplayIndex = 0
        Me.dgvInventario.Columns("IDProducto").Width = 45
        Me.dgvInventario.Columns("IDProducto").HeaderText = "#"
        Me.dgvInventario.Columns("IDProducto").ReadOnly = True
        Me.dgvInventario.Columns("Nombre").DisplayIndex = 1
        Me.dgvInventario.Columns("Nombre").Width = 125
        Me.dgvInventario.Columns("Nombre").HeaderText = "Nombre"
        Me.dgvInventario.Columns("Precio").DisplayIndex = 2
        Me.dgvInventario.Columns("Precio").Width = 65
        Me.dgvInventario.Columns("Precio").HeaderText = "Precio"
        Me.dgvInventario.Columns("Stock").DisplayIndex = 3
        Me.dgvInventario.Columns("Stock").Width = 55
        Me.dgvInventario.Columns("Stock").HeaderText = "Stock"
        Me.dgvInventario.Columns("IDCategoria").DisplayIndex = 4
        Me.dgvInventario.Columns("IDCategoria").Width = 85
        Me.dgvInventario.Columns("IDCategoria").HeaderText = "Categoría"
        Me.dgvInventario.Columns("Coste").DisplayIndex = 5
        Me.dgvInventario.Columns("Coste").Width = 65
        Me.dgvInventario.Columns("Coste").HeaderText = "Coste"
    End Sub

    'Al cargar el formulario se llena la Grid con los datos de la tabla Productos, y se
    'deshabilitan los botones Modificar y Eliminar.
    Private Sub ListaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid()
        btnModificarProducto.Enabled = False
        btnEliminarProducto.Enabled = False
        btnIngresarVenta.Enabled = False
        TemaPrincipal(Me)
    End Sub

    'Al hacer click en el contenido de la Grid, los botones se habilitarán, con el fin de
    'poder modificar o eliminar su contenido.
    Private Sub dgvInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellContentClick
        btnModificarProducto.Enabled = True
        btnEliminarProducto.Enabled = True
        btnIngresarVenta.Enabled = True
    End Sub

    'Al hacer click en el botón Modificar, se ejecutará el procedimiento almacenado 
    'Proc_modificar_producto, que actualizará los datos de la fila seleccionada.
    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        'Se entregan los valores de la fila que se haya modificado en la Grid, a un objeto
        'de la clase EProducto.
        ObjEProducto.IdProducto = dgvInventario.CurrentRow.Cells("IDProducto").EditedFormattedValue.ToString
        ObjEProducto.Nombre = dgvInventario.CurrentRow.Cells("Nombre").EditedFormattedValue.ToString
        ObjEProducto.Precio = dgvInventario.CurrentRow.Cells("Precio").EditedFormattedValue.ToString
        ObjEProducto.Stock = dgvInventario.CurrentRow.Cells("Stock").EditedFormattedValue.ToString
        ObjEProducto.IdCategoria = dgvInventario.CurrentRow.Cells("IDCategoria").EditedFormattedValue.ToString
        ObjEProducto.VolumenVentas = dgvInventario.CurrentRow.Cells("Coste").EditedFormattedValue.ToString
        'Y se llama el procedimiento Modificar del DProducto.
        ObjDProducto.DProducto_Modificar(ObjEProducto)

        'Se muestra un mensaje informando que la modificación se ha realizado.
        MessageBox.Show("Producto modificado con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FillGrid()
    End Sub

    'Al hacer click en el botón Eliminar, se toma el ID del objeto que se tenía seleccionado
    'en la Grid, y se envía al procedimiento Proc_eliminar_producto.
    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click

        'Se guarda el ID de la fila que se tenía seleccionada.
        ObjEProducto.IdProducto = dgvInventario.CurrentRow.Cells("IDProducto").EditedFormattedValue.ToString
        'Y se elimina la fila correspondiente en la base de datos, con la función
        'Eliminar de la clase DProducto.
        ObjDProducto.DProducto_Eliminar(ObjEProducto)

        'Se muestra un mensaje informando que la eliminación se ha realizado.
        MessageBox.Show("Producto eliminado con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FillGrid()
    End Sub

    Private Sub ListaProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
        IngresarProducto.Close()
        ListaVenta.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvInventario.DataSource = ObjDProducto.DProducto_Buscar(txtBuscar.Text)
        Me.dgvInventario.Columns("IDProducto").DisplayIndex = 0
        Me.dgvInventario.Columns("IDProducto").Width = 45
        Me.dgvInventario.Columns("IDProducto").HeaderText = "#"
        Me.dgvInventario.Columns("IDProducto").ReadOnly = True
        Me.dgvInventario.Columns("Nombre").DisplayIndex = 1
        Me.dgvInventario.Columns("Nombre").Width = 125
        Me.dgvInventario.Columns("Nombre").HeaderText = "Nombre"
        Me.dgvInventario.Columns("Precio").DisplayIndex = 2
        Me.dgvInventario.Columns("Precio").Width = 65
        Me.dgvInventario.Columns("Precio").HeaderText = "Precio"
        Me.dgvInventario.Columns("Stock").DisplayIndex = 3
        Me.dgvInventario.Columns("Stock").Width = 55
        Me.dgvInventario.Columns("Stock").HeaderText = "Stock"
        Me.dgvInventario.Columns("IDCategoria").DisplayIndex = 4
        Me.dgvInventario.Columns("IDCategoria").Width = 85
        Me.dgvInventario.Columns("IDCategoria").HeaderText = "Categoría"
        Me.dgvInventario.Columns("Coste").DisplayIndex = 5
        Me.dgvInventario.Columns("Coste").Width = 65
        Me.dgvInventario.Columns("Coste").HeaderText = "Coste"
    End Sub

    Private Sub btnListaVenta_Click(sender As Object, e As EventArgs) Handles btnListaVenta.Click
        ListaVenta.Show()
        Me.Hide()
    End Sub

    Public Sub btnIngresarVenta_Click(sender As Object, e As EventArgs) Handles btnIngresarVenta.Click
        ObjEProducto.IdProducto = dgvInventario.CurrentRow.Cells("IDProducto").EditedFormattedValue.ToString
        ObjEProducto.Nombre = dgvInventario.CurrentRow.Cells("Nombre").EditedFormattedValue.ToString
        ObjEProducto.Precio = dgvInventario.CurrentRow.Cells("Precio").EditedFormattedValue.ToString
        ObjEProducto.Stock = dgvInventario.CurrentRow.Cells("Stock").EditedFormattedValue.ToString
        ObjEProducto.IdCategoria = dgvInventario.CurrentRow.Cells("IDCategoria").EditedFormattedValue.ToString
        ObjEProducto.VolumenVentas = dgvInventario.CurrentRow.Cells("Coste").EditedFormattedValue.ToString

        IngresarVenta.Show()
        Me.Hide()
    End Sub
End Class