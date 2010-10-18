<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Services.Dtos.PageInfoDto>" %>
<%@ Import Namespace="Draugen.Helpers" %>
<div class="paging">
        <%= Html.PagePreviousLink(Model) %>
        <%= Html.PageFirstLink(Model) %>
        <% for (var i = 1; i <= Model.TotalPages; i++ ) { %>
            <%= Html.PageIndexLink(Model, i) %>
        <% } %>
        <%= Html.PageLastLink(Model) %>
        <%= Html.PageNextLink(Model) %>
</div>

