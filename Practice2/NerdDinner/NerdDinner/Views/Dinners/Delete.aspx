<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Models.Dinner>" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Confirm Delete</h2>

    <fieldset>
        <p>Please confirm that you want to cancel the dinner:<i><%:Model.Title %></i></p> 
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
            <input type="submit" name="confirmbutton" value="Delete" />
		    
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</asp:Content>

