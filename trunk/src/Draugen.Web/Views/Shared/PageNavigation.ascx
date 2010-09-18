<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Services.Dtos.PageInfoDto>" %>
<table>
    <tr>
        <td>Første</td>
        <td>Forrige</td>
        <td>
        <% for (var i = 1; i <= Model.TotalPages; i++ ) { %>
            <% if(i == Model.Index){ Response.Write("<strong>" + i + "</strong>");} else { Response.Write(i);}%>
            <% if(i < Model.TotalPages){ Response.Write("&nbsp;");} %>
        <% } %>
        </td>
        <td>Neste</td>
        <td>Siste</td>
    </tr>
</table>

