<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Services.ViewData.Shared.Decks.FangstDeck>" %>
<%@ Import Namespace="Draugen.Helpers" %>
<table cellspacing="0">
    <tr>
        <th>Fangst</th>
        <th>Art</th>
        <th>Gram</th>
        <th>Fisker</th>
        <th>Sted</th>
        <th>Dato</th>
    </tr>
    <% foreach (var fangst in Model) { %>
    <tr>
        <td><%= Html.Image(fangst.Bilde) %></td>
        <td><%= fangst.Art %></td>
        <td class="numeric"><%= fangst.Vekt %></td>
        <td><%= fangst.Fisker %></td>
        <td><%= fangst.Sted %></td>
        <td><%= fangst.Dato %></td>
    </tr>
    <% } %>
</table>
<div id="bottomads">&nbsp;</div>