Public Class eExtraServices
    Dim id_servicioExtra As Integer
    Dim descripcion As String
    Dim precio As Double
    Dim tipoServicioExtra As String

    Public Sub New(id_servicioExtra As Integer, descripcion As String, precio As Double, tipoServicioExtra As String)
        Me.id_servicioExtra = id_servicioExtra
        Me.descripcion = descripcion
        Me.precio = precio
        Me.tipoServicioExtra = tipoServicioExtra
    End Sub

    Public Sub New()
    End Sub

    Public Property Id_servicioExtra1 As Integer
        Get
            Return id_servicioExtra
        End Get
        Set(value As Integer)
            id_servicioExtra = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property Precio1 As Double
        Get
            Return precio
        End Get
        Set(value As Double)
            precio = value
        End Set
    End Property

    Public Property TipoServicioExtra1 As String
        Get
            Return tipoServicioExtra
        End Get
        Set(value As String)
            tipoServicioExtra = value
        End Set
    End Property
End Class
