<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Services.Dtos.PageInfoDto>" %>
<%@ Import Namespace="Draugen.Helpers" %>
<table>
    <tr>
        <td><%= Html.PageFirstLink(Model) %></td>
        <td><%= Html.PagePreviousLink(Model) %></td>
        <td>
        <% for (var i = 1; i <= Model.TotalPages; i++ ) { %>
            <%= Html.PageIndexLink(Model, i) %>
        <% } %>
        </td>
        <td><%= Html.PageNextLink(Model) %></td>
        <td><%= Html.PageLastLink(Model) %></td>
    </tr>
</table>

