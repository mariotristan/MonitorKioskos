Imports System.Net

Public Class MonitorClientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        DoGetHostEntry(Request.ServerVariables("remote_addr"))



    End Sub
    Public Sub DoGetHostEntry(hostName As [String])

        Try
            Dim host As IPHostEntry = Dns.GetHostEntry(hostName)
            Response.Write(" Esta pantalla solo resuelve el hostname del cliente que consulta la peticion y guarda el IP, Nombre y Fecha" + "<br />")
            Response.Write("IP del Cliente:" + hostName + "<br />")
            Response.Write("Nombre del Host:" + host.HostName + "<br /> ")
            Response.Write("Hora del Request:" + Now.ToString() + "<br />")

            Dim Servicio As New MonitorBase
            Servicio.RegistrarNotificacion(hostName, host.HostName)


        Catch ex As Exception
            Response.Write(ex.Message)

        End Try

    End Sub

End Class