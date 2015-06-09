<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="HA11.Results" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 378px;
            width: 631px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Output:</h1>

        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" TextMode="MultiLine" Height="125px" Width="391px"></asp:TextBox>

    </div>
    </form>
</body>
</html>
