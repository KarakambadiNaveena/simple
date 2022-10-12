<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Oct_3.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Enter the UserID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="227px"></asp:TextBox>
            <br />
            <br />
            Enter the Password&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="220px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" />
            <br />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
