<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="CallRestApi._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Country Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnGetInfo" runat="server" Text="Get Info" />
            <br />
            <br />
            <asp:TextBox ID="txtResult" runat="server" Enabled="False" Height="235px" ReadOnly="True" TextMode="MultiLine" Width="890px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
