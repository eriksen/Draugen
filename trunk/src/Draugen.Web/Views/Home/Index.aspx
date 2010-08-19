<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Draugen.Master" Inherits="System.Web.Mvc.ViewPage<Draugen.Services.ViewModels.Pages.HomeData>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
    <% foreach (var fangst in Model.Fangster){ %>
    <table>
        <tr>
            <tr><%= fangst.Art.Navn %></tr>
            <tr><%= fangst.Dato %></tr>
            <tr><%= fangst.Fisker.Navn %></tr>
            <tr><%= fangst.Lengde %></tr>
            <tr><%= fangst.Poeng %></tr>
            <tr><%= fangst.Vekt %></tr>
            <tr><%= fangst.Sted.Navn %></tr>
            <tr><%= fangst.Team.Navn %></tr>
        </tr>
    </table>
    <% } %>
</asp:Content>
