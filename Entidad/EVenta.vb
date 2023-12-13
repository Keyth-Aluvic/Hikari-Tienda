Public Class EVenta

    'En la capa de Entidad, se crean los atributos de la clase Venta, equivalentes a
    'sus columnas en la base de datos.
    Private varIdVenta As Integer
    Private varNombreCliente As String
    Private varRutCliente As String
    Private varValorCompra As Integer
    Private varFecha As Date
    Private varIdProducto As Integer

    'Y por cada atributo, se crea un propiedad con sus respectivos Get y Set
    Public Property IdVenta As Integer
        Get
            Return varIdVenta
        End Get
        Set(value As Integer)
            varIdVenta = value
        End Set
    End Property

    Public Property NombreCliente As String
        Get
            Return varNombreCliente
        End Get
        Set(value As String)
            varNombreCliente = value
        End Set
    End Property

    Public Property RutCliente As String
        Get
            Return varRutCliente
        End Get
        Set(value As String)
            varRutCliente = value
        End Set
    End Property

    Public Property ValorCompra As Integer
        Get
            Return varValorCompra
        End Get
        Set(value As Integer)
            varValorCompra = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return varFecha
        End Get
        Set(value As Date)
            varFecha = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return varIdProducto
        End Get
        Set(value As Integer)
            varIdProducto = value
        End Set
    End Property

End Class
