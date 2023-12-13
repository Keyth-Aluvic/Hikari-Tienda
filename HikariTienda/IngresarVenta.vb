'Primero se importan las capas de Datos y Entidad, para poder trabajar con ellas.
Imports Datos
Imports Entidad

Public Class IngresarVenta

    'Se crean objetos DVenta y EVenta para capturar y procesar los datos.
    Dim ObjDVenta As New DVenta
    Dim ObjEVenta As New EVenta

    Dim rut As Integer


    'Al cargar el formulario se desabilita el botón para ingresar los datos.
    Private Sub IngresarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreCliente.Text = MenuP.ObjEProducto.Nombre
        txtIdProducto.Text = MenuP.ObjEProducto.IdProducto
        txtValorCompra.Text = MenuP.ObjEProducto.Precio - MenuP.ObjEProducto.VolumenVentas
        txtRutCliente.Text = 1
        txtRutCliente.Select()
        TemaForm(Me)
    End Sub

    'Esta subrutina valida que los datos mas importantes (Valor e ID) no puedan enviarse
    'en blanco, pues el botón para ingresar datos no se habilitará hasta que se llenen
    'estos campos.
    Private Sub Validar()
        If txtValorCompra.Text <> "" And txtIdProducto.Text <> "" Then
            btnIngresarVenta.Enabled = True
        Else
            btnIngresarVenta.Enabled = False
        End If
    End Sub

    'Esta subrutina evita que se puedan escribir caracteres alfabéticos en un campo donde
    'solo se acepten números.
    Private Sub SoloNumeros(e)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Function Digito(R As Integer) As String
        Dim i, sum As Integer

        i = 1 : sum = 0
        Do
            i = i + 1
            sum = sum + ((R Mod 10) * i)
            R = R \ 10
            If i = 7 Then i = 1
        Loop Until R = 0

        sum = sum Mod 11
        sum = 11 - sum

        Select Case sum
            Case 11
                Digito = "-0"
            Case 10
                Digito = "-K"
            Case Else
                Digito = "-" & sum
        End Select
    End Function

    Private Sub txtRutCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutCliente.KeyPress
        SoloNumeros(e)
        'If InStr(1, "0123456789-K" & Chr(8), e.KeyChar) = 0 Then
        '    e.KeyChar = ""
        'End If
    End Sub

    Private Sub txtRutCliente_TextChanged(sender As Object, e As EventArgs) Handles txtRutCliente.TextChanged


        txtValorCompra.Text = (MenuP.ObjEProducto.Precio - MenuP.ObjEProducto.VolumenVentas) * txtRutCliente.Text

        'Dim id As String = txtRutCliente.Text.Split("-")(0)
        'Validar()

        'If (id <> "") Then
        '    rut = Convert.ToInt32(id)
        'End If

        'Dim rutVer As String = rut & Digito(rut)

        'If (String.Compare(txtRutCliente.Text, rutVer) = 0) Or txtRutCliente.Text = "" Then
        '    btnIngresarVenta.Enabled = True
        '    lblValidRut.Visible = False
        'Else
        '    btnIngresarVenta.Enabled = False
        '    lblValidRut.Visible = True
        'End If

        'txtNombreCliente.Text = rutVer

    End Sub

    'Se llama a SoloNumeros(e) para cada campo que solo acepte números.
    Private Sub txtValorCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorCompra.KeyPress
        SoloNumeros(e)
    End Sub

    'Se llama a Validar() cada vez que se cambia el texto de uno de los campos requeridos,
    'para que se habilite el botón en cuanto se llenen estos campos.
    Private Sub txtValorCompra_TextChanged(sender As Object, e As EventArgs) Handles txtValorCompra.TextChanged
        Validar()
    End Sub

    Private Sub txtIdProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdProducto.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged
        Validar()
    End Sub

    'Cuando finalmente se llenan los TextBox requeridos y se hace click en el 
    'btnIngresarVenta, se hace todo el procesamiento de datos.
    Private Sub btnIngresarVenta_Click(sender As Object, e As EventArgs) Handles btnIngresarVenta.Click
        'Se capturan todos los datos junto a la fecha actual en el EVenta creado
        'al principio de la clase.
        ObjEVenta.NombreCliente = txtNombreCliente.Text
        ObjEVenta.RutCliente = txtRutCliente.Text
        ObjEVenta.ValorCompra = txtValorCompra.Text
        ObjEVenta.Fecha = DateTime.Now
        ObjEVenta.IdProducto = txtIdProducto.Text
        'Y se llama la función Ingresar del DVenta, usando como modelo el EVenta con
        'los datos capturados, listos para ser ingresados a la base de datos.
        ObjDVenta.DVenta_Ingresar(ObjEVenta)

        'Se muestra un mensaje de que el producto ha sido agregado con éxito.
        MessageBox.Show("La venta se ha realizado con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Y se vacían los TextBox para ser llenados de nuevo.

        MenuP.ObjEProducto.Stock = MenuP.ObjEProducto.Stock - txtRutCliente.Text
        MenuP.ObjDProducto.DProducto_Modificar(MenuP.ObjEProducto)
        MenuP.FillGrid()

        Me.Close()
        MenuP.Show()

    End Sub

    Private Sub IngresarVenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MenuP.Show()
    End Sub

    Private Sub btnAtras2_Click(sender As Object, e As EventArgs) Handles btnAtras2.Click
        Me.Close()
        MenuP.Show()
    End Sub

End Class