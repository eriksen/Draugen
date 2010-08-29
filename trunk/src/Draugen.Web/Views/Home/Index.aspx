<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Draugen.Master" Inherits="System.Web.Mvc.ViewPage<Draugen.Services.Dtos.FangstDto[]>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <title>Draugen</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

    <div id="sistefangster">
        <h2><strong>Draugens siste fangster</strong></h2>
        <div id="l1">
            <% Html.RenderPartial("FangstDeck", Model); %>
        </div>
    </div>
</asp:Content>

    