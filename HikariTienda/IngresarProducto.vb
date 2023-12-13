'Primero se importan las capas de Datos y Entidad, para poder trabajar con ellas.
Imports Datos
Imports Entidad

Public Class IngresarProducto

    'Se crean objetos DProducto y EProducto para capturar y procesar los datos.
    Dim ObjDProducto As New DProducto
    Dim ObjEProducto As New EProducto
    Dim ObjDCategoria As New DCategoria

    Public Sub FillBox()
        cmbCategoria.DataSource = ObjDCategoria.DCategoria_Listar
        cmbCategoria.ValueMember = "IDCategoria"
        cmbCategoria.DisplayMember = "Nombre"
    End Sub

    'Al cargar el formulario se desabilita el botón para ingresar los datos.
    Private Sub IngresarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillBox()
        btnIngresarProducto.Enabled = False
        TemaForm(Me)
    End Sub

    'Esta subrutina valida que los datos mas importantes (Nombre, Precio y Stock) no puedan
    'enviarse en blanco, pues el botón para ingresar datos no se habilitará hasta que se
    'llenen estos campos.
    Private Sub Validar()
        If txtNombreProducto.Text <> "" And txtPrecio.Text <> "" And txtStock.Text <> "" Then
            btnIngresarProducto.Enabled = True
        Else
            btnIngresarProducto.Enabled = False
        End If
    End Sub

    'Esta subrutina evita que se puedan escribir caracteres alfabéticos en un campo donde
    'solo se acepten números.
    Private Sub SoloNumeros(e)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    'Se llama a Validar() cada vez que se cambia el texto de uno de los campos requeridos,
    'para que se habilite el botón en cuanto se llenen estos campos.
    Private Sub txtNombreProducto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProducto.TextChanged
        Validar()
    End Sub

    'Se llama a SoloNumeros(e) para cada campo que solo acepte números.
    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        Validar()
    End Sub

    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        Validar()
    End Sub

    Private Sub txtVolumenVentas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumenVentas.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtVolumenVentas_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        Validar()
    End Sub

    'Cuando finalmente se llenan los TextBox requeridos y se hace click en el 
    'btnIngresarProducto, se hace todo el procesamiento de datos.
    Private Sub btnIngresarProducto_Click(sender As Object, e As EventArgs) Handles btnIngresarProducto.Click

        'Si no se especifíca VolumenVentas, se pone en "0" por defecto.
        If txtVolumenVentas.Text.Equals("") = True Then
            txtVolumenVentas.Text = "0"
        End If

        'Se capturan todos los datos en el EProducto creado al principio.
        ObjEProducto.Nombre = txtNombreProducto.Text
        ObjEProducto.Precio = txtPrecio.Text
        ObjEProducto.Stock = txtStock.Text
        ObjEProducto.IdCategoria = cmbCategoria.SelectedValue
        ObjEProducto.VolumenVentas = txtVolumenVentas.Text
        'Y se llama la función Ingresar del DProducto, usando como modelo el EProducto con
        'los datos capturados, listos para ser ingresados a la base de datos.
        ObjDProducto.DProducto_Ingresar(ObjEProducto)

        'Se muestra un mensaje de que el producto ha sido agregado con éxito.
        MessageBox.Show("Producto agregado con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Y se vacían los TextBox para ser llenados de nuevo.
        txtNombreProducto.Text = ""
        txtPrecio.Text = ""
        txtStock.Text = ""
        cmbCategoria.Text = ""
        txtVolumenVentas.Text = ""

        MenuP.FillGrid()
    End Sub

    Private Sub IngresarProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MenuP.Show()
    End Sub

    Private Sub btnAtras1_Click(sender As Object, e As EventArgs) Handles btnAtras1.Click
        Me.Close()
        MenuP.Show()
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        Me.Hide()
        Categorias.Show()
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        txtIdCategoria.Text = cmbCategoria.SelectedValue.ToString
    End Sub
End Class