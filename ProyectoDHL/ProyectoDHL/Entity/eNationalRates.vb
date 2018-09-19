Public Class eNationalRates
    Dim id_tarifasNacionales As Integer
    Dim peso, zona1 As Double
    Dim ciudad, tipoServicio As String

    Public Sub New(id_tarifasNacionales As Integer, peso As Double, zona1 As Double, ciudad As String, tipoServicio As String)
        Me.id_tarifasNacionales = id_tarifasNacionales
        Me.peso = peso
        Me.zona1 = zona1
        Me.ciudad = ciudad
        Me.tipoServicio = tipoServicio
    End Sub

    Public Sub New()
    End Sub

    Public Property Id_tarifasNacionales1 As Integer
        Get
            Return id_tarifasNacionales
        End Get
        Set(value As Integer)
            id_tarifasNacionales = value
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

    Public Property Ciudad1 As String
        Get
            Return ciudad
        End Get
        Set(value As String)
            ciudad = value
        End Set
    End Property

    Public Property TipoServicio1 As String
        Get
            Return tipoServicio
        End Get
        Set(value As String)
            tipoServicio = value
        End Set
    End Property
End Class
