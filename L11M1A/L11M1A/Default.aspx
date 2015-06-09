<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="L11M1A._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="content">

                Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="SubmitClick" /><br/>
                <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
            
            
        </div>

    </div>

</asp:Content>
