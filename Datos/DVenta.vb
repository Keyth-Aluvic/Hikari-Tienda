'Primero se hacen las importaciones necesarias del sistema para trabajar con conexiones
'con base de datos SQL, además de importar la capa de Entidad, para acceder a los
'atributos de las clases contenidas ahí y conectarla con la capa de datos.
Imports System.Data.SqlClient
Imports Entidad

Public Class DVenta

    'Se crean todas la variables necesarias para interactuar con la base de datos, entre
    'ellas un objeto de la clase Connex, comando, adaptador y conexión a SQL.
    Dim ObjConex As New Connex
    Dim Cmd As SqlCommand
    Dim Da As SqlDataAdapter
    Dim Cn As SqlConnection

    'Esta función conecta con el procedimiento almacenado de la base de datos, que permite
    'registrar una Venta en la tabla Finanzas, basado en el modelo de la clase EVenta, que
    'se encuentra en la capa de Entidad.
    Public Function DVenta_Ingresar(ByVal Add As EVenta)
        Try
            'Se les da los valores necesario a las variables anteriormente mencionadas, se
            'abre la conexión con la base de datos y se llama el procedimiento almacenado
            '"Proc_ingresar_Finanzas" de la base de datos."
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("agregarVenta")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            'Se entregan los valores correspondientes al procedimiento almacenado.
            With Cmd.Parameters
                .AddWithValue("@vendidos", Add.RutCliente)
                .AddWithValue("@ganancias", Add.ValorCompra)
                .AddWithValue("@fecha", Add.Fecha)
                .AddWithValue("@idproducto", Add.IdProducto)
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
    'Finanzas, usando como modelo la clase EVenta.
    Public Function DVenta_Modificar(ByVal Modify As EVenta)
        Try
            'Se les da los valores necesario a las variables anteriormente mencionadas, se
            'abre la conexión con la base de datos y se llama el procedimiento almacenado
            '"Proc_modificar_Finanzas" de la base de datos."
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("Proc_modificar_Finanzas")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            'Se entregan los valores correspondientes al procedimiento almacenado.
            With Cmd.Parameters
                .AddWithValue("@idventa", Modify.IdVenta)
                .AddWithValue("@nombrecliente", Modify.NombreCliente)
                .AddWithValue("@rutcliente", Modify.RutCliente)
                .AddWithValue("@valorcompra", Modify.ValorCompra)
                .AddWithValue("@fecha", Modify.Fecha)
                .AddWithValue("@idproducto", Modify.IdProducto)
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

    'Esta función conecta con el procedimiento almacenado para consultar el contenido de 
    'la tabla Finanzas.
    Public Function DVenta_Listar()
        Try
            'Se le dan los valores necesarios a las variables de clase, conectando con la
            'base de datos y llamando al procedimiento "Proc_listar_Finanzas"
            Cn = ObjConex.Conectar
            Cmd = New SqlCommand("listarVenta")
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

End Class