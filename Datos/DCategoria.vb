Imports System.Data.SqlClient
Imports Entidad

Public Class DCategoria

    Dim ObjConex As New Connex
    Dim Cmd As SqlCommand
    Dim Da As SqlDataAdapter
    Dim Cn As SqlConnection

    Public Function DCategoria_Ingresar(ByVal Add As ECategoria)
        Try
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("agregarCategoria")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            With Cmd.Parameters
                .AddWithValue("@nombre", Add.Nombre)
            End With

            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Cn.Close()
    End Function

    Public Function DCategoria_Modificar(ByVal Modify As ECategoria)
        Try
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("modificarCategoria")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            With Cmd.Parameters
                .AddWithValue("@idcategoria", Modify.IdCategoria)
                .AddWithValue("@nombre", Modify.Nombre)
            End With

            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Cn.Close()
    End Function

    Public Function DCategoria_Eliminar(ByVal Supress As ECategoria)
        Try
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("eliminarCategoria")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            With Cmd.Parameters
                .AddWithValue("@idcategoria", Supress.IdCategoria)
            End With

            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Cn.Close()
    End Function

    Public Function DCategoria_Listar()
        Try
            Cn = ObjConex.Conectar()
            Cmd = New SqlCommand("listarCategoria")
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Cn

            If Cmd.ExecuteNonQuery Then
                Dim Adaptador As New SqlDataAdapter(Cmd)
                Dim Tabla As New DataTable
                Adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Cn.Close()
    End Function

End Class
