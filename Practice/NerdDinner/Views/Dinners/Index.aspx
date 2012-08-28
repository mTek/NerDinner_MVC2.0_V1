<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<NerdDinner.Models.Dinner>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <ul>
    <% foreach (var dinner in Model) { %>
    
        <li>
            <a href="/Dinners/Details/<%: dinner.DinnerID %>">
            <%:dinner.Title %>
            </a>
            on
            <%:dinner.EventDate.ToShortDateString() %>
            @
            <%:dinner.EventDate.ToShortTimeString() %>
        </li>
    
    <% } %>
    </ul>
    
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

