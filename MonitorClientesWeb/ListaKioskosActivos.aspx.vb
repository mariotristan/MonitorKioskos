Public Class ListaKioskosActivos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Servicio As New MonitorBase
        Dim ListaKioskos As List(Of Kiosko) = Servicio.ObtenerKioskosActivos()
        Dim lista As String
        lista = "<ul>"
        For Each Elemento As Kiosko In ListaKioskos
           
            lista += "<li>" + Elemento.NombreHost + "</li>"

        Next
        lista += "</ul>"

        ListaKiskosParrafo.InnerHtml = lista
    End Sub

End Class