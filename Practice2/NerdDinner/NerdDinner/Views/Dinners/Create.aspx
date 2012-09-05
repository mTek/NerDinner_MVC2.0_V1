<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Models.Dinner>" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Host a Dinner</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary("Please correct the errors.") %>

        <fieldset>
            <p> 
                <%: Html.LabelFor(model => model.Title) %>
                <%: Html.TextBoxFor(model => model.Title) %>
                <%: Html.ValidationMessageFor(model => model.Title) %>
            </p>
            <p>
                <%: Html.LabelFor(model => model.EventDate) %>
                <%: Html.TextBoxFor(model => model.EventDate) %>
                <%: Html.ValidationMessageFor(model => model.EventDate) %>
            </p>
            <p>
                <%: Html.LabelFor(model => model.Description) %>
                <%: Html.TextBoxFor(model => model.Description) %>
                <%: Html.ValidationMessageFor(model => model.Description) %>
            </p>
            
            <%--<div class="editor-label">
                <%: Html.LabelFor(model => model.HostedBy) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.HostedBy) %>
                <%: Html.ValidationMessageFor(model => model.HostedBy) %>
            </div>
            --%>
            <p>
                <%: Html.LabelFor(model => model.ContactPhone) %>
                <%: Html.TextBoxFor(model => model.ContactPhone) %>
                <%: Html.ValidationMessageFor(model => model.ContactPhone) %>
            </p>
            
            <p>
                <%: Html.LabelFor(model => model.Address) %>
                <%: Html.TextBoxFor(model => model.Address) %>
                <%: Html.ValidationMessageFor(model => model.Address) %>
            </p>
            
            <p>
                <%: Html.LabelFor(model => model.Country) %>
                <%: Html.TextBoxFor(model => model.Country) %>
                <%: Html.ValidationMessageFor(model => model.Country) %>
            </p>
            
            <p>
                <%: Html.LabelFor(model => model.Latitude) %>
                <%: Html.TextBoxFor(model => model.Latitude) %>
                <%: Html.ValidationMessageFor(model => model.Latitude) %>
            </p>
            
            <p>
                <%: Html.LabelFor(model => model.Longitude) %>
                <%: Html.TextBoxFor(model => model.Longitude) %>
                <%: Html.ValidationMessageFor(model => model.Longitude) %>
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

