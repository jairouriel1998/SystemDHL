Public Class eInternationalRates
    Dim id_tarifasInternacionales As Integer
    Dim peso, zona1, zona2, zona3, zona4, zona5, zona6, zona7 As Double

    Public Sub New(id_tarifasInternacionales As Integer, peso As Double, zona1 As Double, zona2 As Double, zona3 As Double, zona4 As Double, zona5 As Double, zona6 As Double, zona7 As Double)
        Me.id_tarifasInternacionales = id_tarifasInternacionales
        Me.peso = peso
        Me.zona1 = zona1
        Me.zona2 = zona2
        Me.zona3 = zona3
        Me.zona4 = zona4
        Me.zona5 = zona5
        Me.zona6 = zona6
        Me.zona7 = zona7
    End Sub

    Public Sub New()
    End Sub

    Public Property Id_tarifasInternacionales1 As Integer
        Get
            Return id_tarifasInternacionales
        End Get
        Set(value As Integer)
            id_tarifasInternacionales = value
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

    Public Property Zona11 As Double
        Get
            Return zona1
        End Get
        Set(value As Double)
            zona1 = value
        End Set
    End Property

    Public Property Zona21 As Double
        Get
            Return zona2
        End Get
        Set(value As Double)
            zona2 = value
        End Set
    End Property

    Public Property Zona31 As Double
        Get
            Return zona3
        End Get
        Set(value As Double)
            zona3 = value
        End Set
    End Property

    Public Property Zona41 As Double
        Get
            Return zona4
        End Get
        Set(value As Double)
            zona4 = value
        End Set
    End Property

    Public Property Zona51 As Double
        Get
            Return zona5
        End Get
        Set(value As Double)
            zona5 = value
        End Set
    End Property

    Public Property Zona61 As Double
        Get
            Return zona6
        End Get
        Set(value As Double)
            zona6 = value
        End Set
    End Property

    Public Property Zona71 As Double
        Get
            Return zona7
        End Get
        Set(value As Double)
            zona7 = value
        End Set
    End Property
End Class
