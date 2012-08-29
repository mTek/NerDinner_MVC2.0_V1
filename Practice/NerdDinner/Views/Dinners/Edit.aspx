<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Models.Dinner>" %>


<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
	Edit: <%:Model.Title %>


</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit Dinner</h2>

    <script type="text/javascript" language="javascript">
            function test() {
                alert("--");
            }
    </script>


    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary("Please correct the errors and try again.") %>
        
        <fieldset>
            <legend>Fields</legend>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.Title) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.Title, new { size=15, onchange="test()"})%>
                <%: Html.ValidationMessageFor(m => m.Title, "*") %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(m => m.EventDate) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.EventDate, String.Format("{0:g}", Model.EventDate)) %>
                <%: Html.ValidationMessageFor(m => m.EventDate, "*") %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(m => m.Description) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.Description) %>
                <%: Html.ValidationMessageFor(m => m.Description, "*")%>
            </div>
            
            <%--<div class="editor-label">
                <%: Html.LabelFor(m => m.HostedBy) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.HostedBy) %>
                <%: Html.ValidationMessageFor(m => m.HostedBy) %>
            </div>--%>
            
            
            
            <div class="editor-label">
                <%: Html.LabelFor(m => m.Address) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.Address) %>
                <%: Html.ValidationMessageFor(m => m.Address, "*")%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(m => m.Country) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.Country) %>
                <%: Html.ValidationMessageFor(m => m.Country, "*")%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(m => m.ContactPhone) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.ContactPhone) %>
                <%: Html.ValidationMessageFor(m => m.ContactPhone, "*")%>
            </div>


            <div class="editor-label">
                <%: Html.LabelFor(m => m.Latitude) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.Latitude, String.Format("{0:F}", Model.Latitude)) %>
                <%: Html.ValidationMessageFor(m => m.Latitude, "*")%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(m => m.Longitude) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.Longitude, String.Format("{0:F}", Model.Longitude)) %>
                <%: Html.ValidationMessageFor(m => m.Longitude, "*")%>
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

