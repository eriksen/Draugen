<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Model.Shared.FangstList>" %>
<table cellspacing="0">
    <tr>
        <th>Art</th>
        <th>Vekt</th>
        <th>Fisker</th>
        <th>Sted</th>
        <th>Dato</th>
        <th>Poeng</th>
    </tr>
    <% foreach (var fangst in Model) { %>
    <tr>
        <td><%= fangst.Art %></td>
        <td class="numeric"><%= fangst.Vekt %> kg</td>
        <td><%= fangst.Fisker %></td>
        <td><%= fangst.Sted %></td>
        <td><%= fangst.Dato %></td>
        <td class="numeric"><%= fangst.Poeng %></td>
    </tr>
    <% } %>
</table>