Public Class eArticles
    Dim id_articulo As Integer
    Dim descripcion, origen As String
    Dim prohibido, restringido, peligroso As Byte
    Dim material As String


    Public Sub New(id_articulo As Integer, descripcion As String, origen As String, prohibido As Byte, restringido As Byte, peligroso As Byte, material As String)
        Me.id_articulo = id_articulo
        Me.descripcion = descripcion
        Me.origen = origen
        Me.prohibido = prohibido
        Me.restringido = restringido
        Me.peligroso = peligroso
        Me.material = material
    End Sub

    Public Sub New()
    End Sub

    Public Property Id_articulo1 As Integer
        Get
            Return id_articulo
        End Get
        Set(value As Integer)
            id_articulo = value
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

    Public Property Origen1 As String
        Get
            Return origen
        End Get
        Set(value As String)
            origen = value
        End Set
    End Property

    Public Property Prohibido1 As Byte
        Get
            Return prohibido
        End Get
        Set(value As Byte)
            prohibido = value
        End Set
    End Property

    Public Property Restringido1 As Byte
        Get
            Return restringido
        End Get
        Set(value As Byte)
            restringido = value
        End Set
    End Property

    Public Property Peligroso1 As Byte
        Get
            Return peligroso
        End Get
        Set(value As Byte)
            peligroso = value
        End Set
    End Property

    Public Property Material1 As String
        Get
            Return material
        End Get
        Set(value As String)
            material = value
        End Set
    End Property
End Class
