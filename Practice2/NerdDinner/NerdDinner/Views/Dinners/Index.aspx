<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<NerdDinner.Models.Dinner>>" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Dinners</h2>
    <ul>
    <% foreach (var item in Model) { %>
    
        <li>
            <%:Html.ActionLink(item.Title,"Details/" + item.DinnerID) %> @ <%:item.EventDate.ToString() %>&nbsp;&nbsp;&nbsp; <%:Html.ActionLink("Delete","Delete/" + item.DinnerID) %> 
        </li>
    
    <% } %>
    </ul>
    

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

