Public Class eConsumers
    Dim id_persona As Integer
    Dim nombre, apellido, identidad, telefono, email As String
    Dim id_cliente As Integer
    Dim Direccion As String

    Public Sub New()
    End Sub

    Public Sub New(id_persona As Integer, nombre As String, apellido As String, identidad As String, telefono As String, email As String, id_cliente As Integer, direccion As String)
        Me.id_persona = id_persona
        Me.nombre = nombre
        Me.apellido = apellido
        Me.identidad = identidad
        Me.telefono = telefono
        Me.email = email
        Me.id_cliente = id_cliente
        Me.Direccion = direccion
    End Sub

    Public Property Id_persona1 As Integer
        Get
            Return id_persona
        End Get
        Set(value As Integer)
            id_persona = value
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

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property Identidad1 As String
        Get
            Return identidad
        End Get
        Set(value As String)
            identidad = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Id_cliente1 As Integer
        Get
            Return id_cliente
        End Get
        Set(value As Integer)
            id_cliente = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property
End Class
