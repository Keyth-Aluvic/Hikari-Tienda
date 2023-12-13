Public Class ECategoria

    Private varIdCategoria As Integer
    Public Property IdCategoria() As Integer
        Get
            Return varIdCategoria
        End Get
        Set(ByVal value As Integer)
            varIdCategoria = value
        End Set
    End Property

    Private varNombre As String
    Public Property Nombre() As String
        Get
            Return varNombre
        End Get
        Set(ByVal value As String)
            varNombre = value
        End Set
    End Property

End Class
