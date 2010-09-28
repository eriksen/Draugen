<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Services.Dtos.FangstListDto>" %>
<%@ Import Namespace="Draugen.Helpers" %>
<% foreach (var fangst in Model) { %>
<div class="fangst">
    <table cellspacing="0" width="600px">
        <tr>
            <td rowspan="2" class="thumbnail"> <%= Html.Image(Url.Content("~/Content/Images/Fangstbilder/Thumbnail/draug100.jpg")) %></td>
            <td class="detail">
                <%= fangst.Dato %>
            </td>
            <td class="detail">
                <%= fangst.Art %>
            </td>
            <td class="detail">
                <%= fangst.Fisker %>
            </td>
            <td class="detail">
                <%= fangst.Sted %>
            </td>
            <td class="numericdetail">
                <%= fangst.Vekt %> kg
            </td>
            <td class="numericdetail">
                <%= fangst.Poeng %> poeng
            </td>
        </tr>
        <tr>
            <td colspan="6" class="kommentar">
                <%= Html.KommentarExtract(fangst.Kommentar) %>
            </td>
        </tr>
    </table>
</div>
<% } %>
<% Html.RenderPartial("PageNavigation", Model.PageInfo); %>
