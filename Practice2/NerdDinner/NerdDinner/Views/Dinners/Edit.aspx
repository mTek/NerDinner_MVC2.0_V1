<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Models.Dinner>" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit Dinner</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(false ,"Please check the errors.") %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Title) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Title) %>
                <%: Html.ValidationMessageFor(model => model.Title, "*") %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.EventDate) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.EventDate)%>
                <%: Html.ValidationMessageFor(model => model.EventDate, "*")%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Description) %>
            </div>
            <div class="editor-field">
                <%--<%: Html.TextBoxFor(model => model.Description, htmlAttributes: new { @class = "required", maxlength = "10" })%>
                --%>
                <%: Html.TextBox("Description","", htmlAttributes: new { @class = "required", maxlength = "10" })%>
                
                <%: Html.ValidationMessageFor(model => model.Description, "*")%>
                 <%: Html.ValidationMessageFor(model => model.Description, "*")%>
                
            </div>
            
            <%--<div class="editor-label">
                <%: Html.LabelFor(model => model.HostedBy) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.HostedBy) %>
                <%: Html.ValidationMessageFor(model => model.HostedBy) %>
            </div>--%>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ContactPhone) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ContactPhone) %>
                <%: Html.ValidationMessageFor(model => model.ContactPhone, "*")%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Address) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Address) %>
                <%: Html.ValidationMessageFor(model => model.Address, "*")%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Country) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Country) %>
                <%: Html.ValidationMessageFor(model => model.Country, "*")%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Latitude) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Latitude, String.Format("{0:F}", Model.Latitude)) %>
                <%: Html.ValidationMessageFor(model => model.Latitude, "*")%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Longitude) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Longitude, String.Format("{0:F}", Model.Longitude)) %>
                <%: Html.ValidationMessageFor(model => model.Longitude, "*")%>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

