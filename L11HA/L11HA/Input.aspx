<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="HA11.Input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Input</title>
    <style type="text/css">
        .auto-style4 {
            width: 472px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div>
<%--        <table id="layouttable">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Vorname"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="FirstnameTextbox" ValidationGroup="check" runat="server" style="margin-left: 0px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validator2" runat="server" ControlToValidate="FirstnameTextbox" ErrorMessage="please provide firstname" Visible="False"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="firstnameValidator" ControlToValidate="FirstnameTextbox" runat="server" Type="String"></asp:CompareValidator>
                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nachname"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="LastnameTextbox" ValidationGroup="check" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validator1" runat="server" ControlToValidate="LastnameTextbox" ErrorMessage="please provide lastname" Visible="False"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="lastnameValidator" ControlToValidate="LastnameTextbox" runat="server" Type="String"></asp:CompareValidator>
                    
                </td>

                <td>
                    
                    <asp:Button ID="submitButton" OnClick="Button1_Click" CausesValidation="True" Text="Submit Data" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Geburtsdatum"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="BirthdateTextbox" ValidationGroup="check" runat="server"></asp:TextBox>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="BirthdateTextbox" ErrorMessage="Please enter a valid date format" ValidationExpression="\d{2}.\d{2}.\d{4}"></asp:RegularExpressionValidator>
                </td>
                <td>

                </td>
            </tr>
        </table>--%>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label2" runat="server" Text="Vorname"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="FirstnameTextbox" ValidationGroup="check" runat="server" style="margin-left: 0px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="validator2" runat="server" ControlToValidate="FirstnameTextbox" ErrorMessage="please provide firstname" Visible="False"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="firstnameValidator" ControlToValidate="FirstnameTextbox" runat="server" ValidationGroup="check" Type="String"></asp:CompareValidator> 
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label1" runat="server" Text="Nachname"></asp:Label>
                            </td>
                            <td>
                               <asp:TextBox ID="LastnameTextbox" ValidationGroup="check" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="validator1" runat="server" ControlToValidate="LastnameTextbox" ErrorMessage="please provide lastname"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="lastnameValidator" ControlToValidate="LastnameTextbox" runat="server" ValidationGroup="check" Type="String"></asp:CompareValidator>
                                                                 
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label3" runat="server" Text="Geburtsdatum"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="BirthdateTextbox" ValidationGroup="check" runat="server"></asp:TextBox>
                                <asp:CompareValidator id="dateValidator" runat="server" Type="Date" Operator="DataTypeCheck" ControlToValidate="BirthdateTextbox" ValidationGroup="check" ErrorMessage="Please enter a valid date."></asp:CompareValidator>
                   </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <asp:Button ID="submitButton" OnClick="Button1_Click" CausesValidation="True" Text="Submit Data" runat="server"/>
                </td>
            </tr>
        </table>   
    </div>
</form>
</body>
</html>