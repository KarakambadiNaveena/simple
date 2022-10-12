<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Sep30.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Panel ID="Panel1" runat="server" ToolTip="enter the valid password">
                 <asp:Label ID="lbluserid" runat="server" Text="Enter the Userid"></asp:Label>
                 <asp:TextBox ID="txtid" runat="server" style="margin-left: 43px" Width="187px" ToolTip="enter the valid userid"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Label ID="lblpassword" runat="server" Text="Enter the Password"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="txtpwd" runat="server" OnTextChanged="txtpwd_TextChanged" style="margin-left: 0px" Width="187px"></asp:TextBox>
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
                 <asp:ImageButton ID="btnsubmit" runat="server" ImageUrl="~/App_Images/doremon.jpg" OnClick="ImageButton1_Click" style="margin-left: 126px" ToolTip="pls enter the valid userid and password" Width="101px" />
                 <asp:Button ID="Button1" runat="server" Text="Button" />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
            </asp:Panel>
        </div>
        
        <p>
            &nbsp;</p>
        
    </form>
</body>
</html>
