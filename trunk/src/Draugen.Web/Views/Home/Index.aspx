<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Draugen.Master" Inherits="System.Web.Mvc.ViewPage<Draugen.Web.Models.Fangster>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
    <% foreach (var fangst in Model.List){ %>
    <h3><%= fangst.Vekt %></h3>
    <% } %>
</asp:Content>
