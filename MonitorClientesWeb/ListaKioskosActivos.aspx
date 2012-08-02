<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ListaKioskosActivos.aspx.vb" Inherits="MonitorClientesWeb.ListaKioskosActivos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">

     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>
                    <%: Page.Title %>.</h1>
                <h2>Lista de Kioskos activos</h2>
            </hgroup>
            <p id ="ListaKiskosParrafo" runat ="server">
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>. The page features <mark>videos, tutorials, and samples</mark>to help you get the most from ASP.NET. If you have any questions about ASP.NET visit <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
        </div>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
