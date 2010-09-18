<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Services.Dtos.FangstListDto>" %>
<%@ Import Namespace="Draugen.Helpers" %>
<% foreach (var fangst in Model) { %>
<div class="fangst">
    <table cellspacing="0" width="600px">
        <tr>
            <td rowspan="2" class="thumbnail"> <%= Html.Image(Url.Content("~/Content/Images/Fangstbilder/Thumbnail/draug100.jpg")) %></td>
            <td>
                <%= fangst.Dato %>
            </td>
            <td>
                <%= fangst.Art %> av <%= fangst.Fisker %>. <%= fangst.Sted %>
            </td>
        </tr>
        <tr>
            <td>
                <%= fangst.Vekt %>&nbsp;kg<br />
                <%= fangst.Poeng %>&nbsp;poeng
            </td>
            <td>
                <%= Html.KommentarExtract(fangst.Kommentar) %>
            </td>
        </tr>
    </table>
</div>
<% } %>
<% Html.RenderPartial("PageNavigation", Model.PageInfo); %>
