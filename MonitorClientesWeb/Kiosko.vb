Public Class Kiosko
    Private _NombreHost As String


#Region "Propiedades"
    Public Property NombreHost() As String
        Get
            Return _NombreHost
        End Get
        Set(ByVal value As String)
            _NombreHost = value
        End Set
    End Property

    Private _IPKiosko As String
    Public Property IPKiosko() As String
        Get
            Return _IPKiosko
        End Get
        Set(ByVal value As String)
            _IPKiosko = value
        End Set
    End Property


#End Region


    Public Sub New(IP As String, HostName As String)
        _IPKiosko = IP
        _NombreHost = HostName
    End Sub



End Class
