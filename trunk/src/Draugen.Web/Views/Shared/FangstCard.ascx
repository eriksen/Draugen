<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Services.ViewModels.Cards.FangstCard>" %>
<div class="fangstCard">
<b class="rtop"><b class="r1"></b> <b class="r2"></b> <b class="r3"></b> <b class="r4"></b></b>
<table>
    <tr>
        <td rowspan="4">img</td>
        <td>Art:</td><td><%= Model.Art %></td>
        <td>Poeng:</td><td><%= Model.Poeng %></td>
    </tr>
    <tr>
        <td>Fisker:</td><td><%= Model.Fisker %></td>
        <td>Vekt:</td><td><%= Model.Vekt %></td>
    </tr>
    <tr>
        <td>Sted:</td><td><%= Model.Sted %></td>
        <td>Lengde:</td><td><%= Model.Lengde %></td>
    </tr>
    <tr>
        <td>Team:</td><td><%= Model.Team %></td>
        <td colspan="2">fangstdetaljer</td>
    </tr>
</table>
<b class="rbottom"><b class="r4"></b> <b class="r3"></b> <b class="r2"></b> <b class="r1"></b></b>
</div>
