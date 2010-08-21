<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Draugen.Master" Inherits="System.Web.Mvc.ViewPage<Draugen.Services.ViewModels.Pages.HomePage>" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

    <h2>Index</h2>
    <table>
    <% foreach (var fangst in Model.Fangster) { %>
        <tr>
            <td><%= fangst.Art %></td>
            <td><%= fangst.Dato %></td>
            <td><%= fangst.Fisker %></td>
            <td><%= fangst.Lengde %></td>
            <td><%= fangst.Poeng %></td>
            <td><%= fangst.Sted %></td>
            <td><%= fangst.Vekt %></td>
        </tr>
    <% } %>
    </table>
</asp:Content>

