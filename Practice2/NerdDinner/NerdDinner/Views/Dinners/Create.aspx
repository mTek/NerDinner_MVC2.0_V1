<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Models.DinnerFormViewModel>" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            <p>
            <label for="Title">Dinner Title:</label>
            <%: Html.EditorFor(m => Model.Dinner.Title) %>
        </p>
        <p>
            <label for="EventDate">Event Date:</label>
            <%: Html.EditorFor(m => m.Dinner.EventDate) %>
        </p>
        <p>
            <label for="Description">Description:</label>
            <%: Html.TextAreaFor(m => Model.Dinner.Description, 6, 35, null) %>
        </p>
        <p>
            <label for="Address">Address:</label>
            <%: Html.EditorFor(m => Model.Dinner.Address)%>
        </p>
        <p>
            <label for="Country">Country:</label>
            <%: Html.DropDownList("Dinner.Country", Model.Countries) %>                
        </p>
        <p>
            <label for="ContactPhone">Contact Info:</label>
            <%: Html.EditorFor(m => Model.Dinner.ContactPhone)%>
        </p>
        <p>
            <%: Html.HiddenFor(m => Model.Dinner.Latitude)%>
            <%: Html.HiddenFor(m => Model.Dinner.Longitude)%>
        </p>   
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

