Public Class ePackage
    Dim id_paquete As Integer
    Dim peso, largo, ancho, profundidad As Double

    Public Sub New(id_paquete As Integer, peso As Double, largo As Double, ancho As Double, profundidad As Double)
        Me.id_paquete = id_paquete
        Me.peso = peso
        Me.largo = largo
        Me.ancho = ancho
        Me.profundidad = profundidad
    End Sub

    Public Sub New()
    End Sub

    Public Property Id_paquete1 As Integer
        Get
            Return id_paquete
        End Get
        Set(value As Integer)
            id_paquete = value
        End Set
    End Property

    Public Property Peso1 As Double
        Get
            Return peso
        End Get
        Set(value As Double)
            peso = value
        End Set
    End Property

    Public Property Largo1 As Double
        Get
            Return largo
        End Get
        Set(value As Double)
            largo = value
        End Set
    End Property

    Public Property Ancho1 As Double
        Get
            Return ancho
        End Get
        Set(value As Double)
            ancho = value
        End Set
    End Property

    Public Property Profundidad1 As Double
        Get
            Return profundidad
        End Get
        Set(value As Double)
            profundidad = value
        End Set
    End Property
End Class
