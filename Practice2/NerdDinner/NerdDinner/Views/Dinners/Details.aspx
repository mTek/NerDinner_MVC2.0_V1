<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Models.Dinner>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">DinnerID</div>
        <div class="display-field"><%: Model.DinnerID %></div>
        
        <div class="display-label">Title</div>
        <div class="display-field"><%: Model.Title %></div>
        
        <div class="display-label">EventDate</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.EventDate) %></div>
        
        <div class="display-label">Description</div>
        <div class="display-field"><%: Model.Description %></div>
        
        <div class="display-label">HostedBy</div>
        <div class="display-field"><%: Model.HostedBy %></div>
        
        <div class="display-label">ContactPhone</div>
        <div class="display-field"><%: Model.ContactPhone %></div>
        
        <div class="display-label">Address</div>
        <div class="display-field"><%: Model.Address %></div>
        
        <div class="display-label">Country</div>
        <div class="display-field"><%: Model.Country %></div>
        
        <div class="display-label">Latitude</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.Latitude) %></div>
        
        <div class="display-label">Longitude</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.Longitude) %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.DinnerID }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

