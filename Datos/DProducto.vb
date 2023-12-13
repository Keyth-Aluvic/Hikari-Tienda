'Primero se hacen las importaciones necesarias del sistema para trabajar con conexiones
'con base de datos SQL, además de importar la capa de Entidad, para acceder a los
'atributos de las clases contenidas ahí y conectarla con la capa de datos.
Imports System.Data.SqlClient
Imports Entidad

Public Class DProducto

    'Se crean todas la variables necesarias para interactuar con la base de datos, entre
    'ellas un objeto de la clase Connex, comando, adaptador y conexión a SQL.
    Dim ObjConex As New Connex
    Dim Cmd As SqlCommand
    Dim Da As SqlDataAdapter
    Dim Cn As SqlConnection

    'Esta función conecta con el procedimiento almacenado de la base de datos, que permite
    'registrar un Producto en la tabla del mismo nombre, basado en el modelo de la clase
    'EProducto, que se encuentra en la capa de Entidad.
    Public Function DProducto_Ingresar(ByVal Add As EProducto)
        Try
            'Se les da los valores necesario a las variables anteriormente mencionadas, se
            'abre la conexión con la base de datos y se llama el procedimiento almacenado
            '"Proc_ingresar_Producto" de la base de datos."
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("agregarProducto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            'Se entregan los valores correspondientes al procedimiento almacenado.
            With Cmd.Parameters
                .AddWithValue("@nombre", Add.Nombre)
                .AddWithValue("@precio", Add.Precio)
                .AddWithValue("@stock", Add.Stock)
                .AddWithValue("@idcategoria", Add.IdCategoria)
                .AddWithValue("@coste", Add.VolumenVentas)
            End With

            'Se comprueba que el query haya sido ejecutado exitosamente.
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

            'Un catch que mostrará un mensaje cuando la conexión a la base de datos falle.
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        'Y se cierra la conexión con la base de datos para terminar la función.
        Cn.Close()
    End Function

    'Esta función conecta con el procedimiento almacenado para modificar filas de la tabla
    'Productos, usando como modelo la clase EProducto.
    Public Function DProducto_Modificar(ByVal Modify As EProducto)
        Try
            'Se les da los valores necesario a las variables anteriormente mencionadas, se
            'abre la conexión con la base de datos y se llama el procedimiento almacenado
            '"Proc_modificar_producto" de la base de datos."
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("modificarProducto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            'Se entregan todos los valores al procedimiento almacenado.
            With Cmd.Parameters
                .AddWithValue("@idproducto", Modify.IdProducto)
                .AddWithValue("@nombre", Modify.Nombre)
                .AddWithValue("@precio", Modify.Precio)
                .AddWithValue("@stock", Modify.Stock)
                .AddWithValue("@idcategoria", Modify.IdCategoria)
                .AddWithValue("@coste", Modify.VolumenVentas)
            End With

            'Se comprueba que el query haya sido ejecutado exitosamente.
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

            'Un catch que mostrará un mensaje cuando la conexión a la base de datos falle.
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        'Y se cierra la conexión con la base de datos para terminar la función.
        Cn.Close()
    End Function

    'Esta función conecta con el procedimiento almacenado para eliminar filas de la tabla
    'Productos, usando como modelo la clase EProducto.
    Public Function DProducto_Eliminar(ByVal Suppress As EProducto)
        Try
            'Se les da los valores necesario a las variables anteriormente mencionadas, se
            'abre la conexión con la base de datos y se llama el procedimiento almacenado
            '"Proc_eliminar_producto" de la base de datos."
            Cn = ObjConex.Conectar
            Cmd = New SqlCommand("eliminarProducto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            'Solo se entrega el ID del producto a eliminar, y el procedimiento hará el resto.
            Cmd.Parameters.AddWithValue("@idproducto", Suppress.IdProducto)

            'Se comprueba que el query haya sido ejecutado exitosamente.
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

            'Un catch que mostrará un mensaje cuando la conexión a la base de datos falle.
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        'Y se cierra la conexión con la base de datos para terminar la función.
        Cn.Close()
    End Function

    'Esta función permite consultar el contenido de la tabla Productos.
    Public Function DProducto_Listar()
        Try
            'Se les da los valores necesarios a las variables creadas con anterioridad, y
            'se llama al procedimiento almacenado "Proc_listar_Producto"
            Cn = ObjConex.Conectar
            Cmd = New SqlCommand("listarProducto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            'Se comprueba que el query haya sido ejecutado exitosamente.
            If Cmd.ExecuteNonQuery Then
                Dim Adaptador As New SqlDataAdapter(Cmd)
                Dim Tabla As New DataTable
                Adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If

            'Un catch que mostrará un mensaje cuando la conexión a la base de datos falle.
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

        'Y se cierra la conexión con la base de datos para terminar la función.
        Cn.Close()
    End Function

    Public Function DProducto_Buscar(ByVal Search As String)
        Try
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("buscarProducto")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            Cmd.Parameters.AddWithValue("@buscar", Search)

            If Cmd.ExecuteNonQuery Then
                Dim Adaptador As New SqlDataAdapter(Cmd)
                Dim Tabla As New DataTable
                Adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Cn.Close()
    End Function

End Class
