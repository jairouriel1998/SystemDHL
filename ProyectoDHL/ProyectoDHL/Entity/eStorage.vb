Public Class eStorage
    Dim id_almacenaje, dias As Integer
    Dim valorTramoInicial, valorTramoFinal, costoFijo As Double
    Dim tipoAlmacenaje, ciudad As String

    Public Sub New(id_almacenaje As Integer, dias As Integer, valorTramoInicial As Double, valorTramoFinal As Double, costoFijo As Double, tipoAlmacenaje As String, ciudad As String)
        Me.id_almacenaje = id_almacenaje
        Me.dias = dias
        Me.valorTramoInicial = valorTramoInicial
        Me.valorTramoFinal = valorTramoFinal
        Me.costoFijo = costoFijo
        Me.tipoAlmacenaje = tipoAlmacenaje
        Me.ciudad = ciudad
    End Sub

    Public Sub New()
    End Sub

    Public Property Id_almacenaje1 As Integer
        Get
            Return id_almacenaje
        End Get
        Set(value As Integer)
            id_almacenaje = value
        End Set
    End Property

    Public Property Dias1 As Integer
        Get
            Return dias
        End Get
        Set(value As Integer)
            dias = value
        End Set
    End Property

    Public Property ValorTramoInicial1 As Double
        Get
            Return valorTramoInicial
        End Get
        Set(value As Double)
            valorTramoInicial = value
        End Set
    End Property

    Public Property ValorTramoFinal1 As Double
        Get
            Return valorTramoFinal
        End Get
        Set(value As Double)
            valorTramoFinal = value
        End Set
    End Property

    Public Property CostoFijo1 As Double
        Get
            Return costoFijo
        End Get
        Set(value As Double)
            costoFijo = value
        End Set
    End Property

    Public Property TipoAlmacenaje1 As String
        Get
            Return tipoAlmacenaje
        End Get
        Set(value As String)
            tipoAlmacenaje = value
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
End Class
