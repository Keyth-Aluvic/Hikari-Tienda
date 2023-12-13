Public Class EProducto

    'En la capa de Entidad, se crean los atributos de la clase Producto, equivalentes a
    'sus columnas en la base de datos.
    Public varIdProducto As Integer
    Public varNombre As String
    Public varPrecio As Integer
    Public varStock As Integer
    Public varIdCategoria As Integer
    Public varVolumenVentas As Integer

    'Y por cada atributo, se crea un propiedad con sus respectivos Get y Set
    Public Property IdProducto As Integer
        Get
            Return varIdProducto
        End Get
        Set(value As Integer)
            varIdProducto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return varNombre
        End Get
        Set(value As String)
            varNombre = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return varPrecio
        End Get
        Set(ByVal value As Integer)
            varPrecio = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return varStock
        End Get
        Set(value As Integer)
            varStock = value
        End Set
    End Property

    Public Property IdCategoria As Integer
        Get
            Return varIdCategoria
        End Get
        Set(value As Integer)
            varIdCategoria = value
        End Set
    End Property

    Public Property VolumenVentas As Integer
        Get
            Return varVolumenVentas
        End Get
        Set(value As Integer)
            varVolumenVentas = value
        End Set
    End Property

End Class
