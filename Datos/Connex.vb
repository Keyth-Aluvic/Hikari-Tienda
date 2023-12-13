'Primero se hacen las importaciones necesarias del sistema para trabajar con conexiones
'con base de datos SQL.
Imports System.Data.SqlClient

Public Class Connex

    'Se crea un objeto con el nombre "Cnn" como nueva conexión a SQL, que servirá como
    'medio para abrir y cerrar la conexión con la base de datos.
    Public Cnn As New SqlConnection

    'Esta función nos devuelve el String usado para conectarse a la base de datos 
    '"HikariTienda" cuando esta se encuentra entre las bases de datos locales.
    Public Function GetConnectioString() As String
        Return "Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=HikariTienda;Integrated Security = True"
    End Function

    'La función "Conectar()" se llama cada vez que sea necesario conectarse a la base
    'de datos.
    Public Function Conectar()
        Cnn = New SqlConnection(GetConnectioString)
        Cnn.Open()
        Return Cnn
    End Function

    'Y la función "Desconectar()" cada vez que dicha conexión ya no sea necesaria.
    Public Function Desconectar() As Boolean
        Try

            If Cnn.State = ConnectionState.Open Then
                Cnn.Close()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False

        End Try
    End Function

End Class
