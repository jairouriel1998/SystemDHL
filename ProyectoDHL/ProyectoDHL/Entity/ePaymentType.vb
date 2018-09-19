Public Class ePaymentType
    Dim id_tipoPago As Integer
    Dim descripcion As String

    Public Sub New(id_tipoPago As Integer, descripcion As String)
        Me.id_tipoPago = id_tipoPago
        Me.descripcion = descripcion
    End Sub

    Public Sub New()
    End Sub

    Public Property Id_tipoPago1 As Integer
        Get
            Return id_tipoPago
        End Get
        Set(value As Integer)
            id_tipoPago = value
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
End Class
