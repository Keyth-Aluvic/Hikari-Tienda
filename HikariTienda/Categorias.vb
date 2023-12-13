Imports Datos
Imports Entidad

Public Class Categorias

    Dim ObjECategoria As New ECategoria
    Dim ObjDCategoria As New DCategoria

    Private Sub FillList()
        dgvCategorias.DataSource = ObjDCategoria.DCategoria_Listar()
        Me.dgvCategorias.Columns("IDCategoria").Visible = False
        Me.dgvCategorias.Columns("Nombre").ReadOnly = True
        Me.dgvCategorias.Columns("Nombre").Width = 185
    End Sub

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FillList()
        btnAgregar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        TemaForm(Me)
    End Sub

    Private Sub btnAtras1_Click(sender As Object, e As EventArgs) Handles btnAtras1.Click
        Me.Close()
        IngresarProducto.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ObjECategoria.Nombre = txtNew.Text
        ObjDCategoria.DCategoria_Ingresar(ObjECategoria)

        MessageBox.Show("Categoría agregada con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FillList()
        IngresarProducto.FillBox()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjECategoria.IdCategoria = dgvCategorias.CurrentRow.Cells("IDCategoria").EditedFormattedValue.ToString
        ObjECategoria.Nombre = txtNew.Text
        ObjDCategoria.DCategoria_Modificar(ObjECategoria)

        MessageBox.Show("Categoría modificada con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FillList()
        IngresarProducto.FillBox()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjECategoria.IdCategoria = dgvCategorias.CurrentRow.Cells("IDCategoria").EditedFormattedValue.ToString
        ObjDCategoria.DCategoria_Eliminar(ObjECategoria)

        MessageBox.Show("Categoría eliminada con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FillList()
        IngresarProducto.FillBox()
    End Sub

    Private Sub txtNew_TextChanged(sender As Object, e As EventArgs) Handles txtNew.TextChanged
        If txtNew.Text <> "" Then
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
        End If
    End Sub

    Private Sub dgvCategorias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellContentClick
        txtSelect.Text = dgvCategorias.CurrentRow.Cells("Nombre").EditedFormattedValue.ToString

        If txtNew.Text <> "" Then
            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If
        btnEliminar.Enabled = True
    End Sub
End Class