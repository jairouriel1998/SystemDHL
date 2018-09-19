Public Class eCountries
    Dim id_pais As Integer
    Dim nombre As String
    Dim zona As Integer
    Dim DHL_ExpressWorldWide, DHL_Express12, DHL_Express9 As Byte

    Public Sub New(id_pais As Integer, nombre As String, zona As Integer, dHL_ExpressWorldWide As Byte, dHL_Express12 As Byte, dHL_Express9 As Byte)
        Me.id_pais = id_pais
        Me.nombre = nombre
        Me.zona = zona
        Me.DHL_ExpressWorldWide = dHL_ExpressWorldWide
        Me.DHL_Express12 = dHL_Express12
        Me.DHL_Express9 = dHL_Express9
    End Sub

    Public Sub New()
    End Sub

    Public Property Id_pais1 As Integer
        Get
            Return id_pais
        End Get
        Set(value As Integer)
            id_pais = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Zona1 As Integer
        Get
            Return zona
        End Get
        Set(value As Integer)
            zona = value
        End Set
    End Property

    Public Property DHL_ExpressWorldWide1 As Byte
        Get
            Return DHL_ExpressWorldWide
        End Get
        Set(value As Byte)
            DHL_ExpressWorldWide = value
        End Set
    End Property

    Public Property DHL_Express121 As Byte
        Get
            Return DHL_Express12
        End Get
        Set(value As Byte)
            DHL_Express12 = value
        End Set
    End Property

    Public Property DHL_Express91 As Byte
        Get
            Return DHL_Express9
        End Get
        Set(value As Byte)
            DHL_Express9 = value
        End Set
    End Property
End Class
