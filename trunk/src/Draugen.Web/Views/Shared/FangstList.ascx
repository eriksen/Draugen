<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Model.Shared.FangstList>" %>
<%@ Import Namespace="Draugen.Helpers" %>
<% foreach (var fangst in Model) { %>
<div class="fangst">
    <table cellspacing="0"  width="380px">
        <tr>
            <td rowspan="2" class="thumbnai> <%= Html.Image(Url.Content("~/Content/Images/Fangstbilder/Thumbnail/" + fangst.Bilde)) %></td>
            <td><%= fangst.Art %> på <%= fangst.Vekt %>&nbsp;kg og <%= fangst.Poeng %>&nbsp;poeng tatt&nbsp;<%= fangst.Dato %> av&nbsp;<%= fangst.Fisker %> på&nbsp;<%= fangst.Sted %></td>
        </tr>
        <tr>
            <td rowspan="2"><%= Html.KommentarExtract(fangst.Kommentar) %></td>
        </tr>
    </table>
</div>
<% } %>
