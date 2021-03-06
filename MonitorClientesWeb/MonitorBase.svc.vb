﻿Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web

<ServiceContract(Namespace:="")>
<AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)>
Public Class MonitorBase
    Shared KioskosActivos As New List(Of Kiosko)

    ' To use HTTP GET, add <WebGet()> attribute. (Default ResponseFormat is WebMessageFormat.Json)
    ' To create an operation that returns XML,
    '     add <WebGet(ResponseFormat:=WebMessageFormat.Xml)>,
    '     and include the following line in the operation body:
    '         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml"
    <OperationContract()>
    Public Sub DoWork()
        ' Add your operation implementation here
    End Sub

    <OperationContract()>
    <WebGet()>
    Public Sub RegistrarNotificacion(IP As String, HostName As String)
        Try
            KioskosActivos.Add(New Kiosko(IP, HostName))
            Dim x As Integer = 0

        Catch ex As Exception
        Finally

        End Try


    End Sub
    ' Add more operations here and mark them with <OperationContract()>
    <OperationContract()>
    <WebGet()>
    Public Function ObtenerKioskosActivos() As List(Of Kiosko)
        Return KioskosActivos
    End Function
End Class
