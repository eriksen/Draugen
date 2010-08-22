<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Draugen.Master" Inherits="System.Web.Mvc.ViewPage<Draugen.Services.ViewModels.Pages.HomePage>" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

    <h2>Index</h2>
    <% foreach (var fangst in Model.Fangster) { %>
       <% Html.RenderPartial("FangstCard", fangst); %>
    <% } %>
</asp:Content>

