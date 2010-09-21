<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Draugen.Master" Inherits="System.Web.Mvc.ViewPage<Draugen.Model.Hjem.HjemModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div id="sistefangster">
        <h2><strong></strong></h2>
        <h2><strong>Draugens siste fangster</strong></h2>
        <div id="l1">
            <% Html.RenderPartial("FangstList", Model.Fangster); %>
            <%= Html.ActionLink("Første side", "Fangster", 2) %>
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
