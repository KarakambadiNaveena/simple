<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userregistration.aspx.cs" Inherits="Sep30.userregistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Select from the list<asp:DropDownList ID="DropDownList1" runat="server" Height="21px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 35px" AutoPostBack="True">
                <asp:ListItem>PersonalDetails</asp:ListItem>
                <asp:ListItem>EducationDetails</asp:ListItem>
                <asp:ListItem>BankDetails</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnsubmit" runat="server" OnClick="Button1_Click" style="margin-left: 59px" Text="Submit" Width="122px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:MultiView ID="Userdata" runat="server">
            <br />
            <br />
            <asp:View ID="PersonalDetails" runat="server">
                Enter the personal Details<br />
                <br />
                Enter&nbsp; Name :&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" MaxLength="20" style="margin-left: 27px" Width="129px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BackColor="#CCFFCC" BorderColor="#CCFF66" BorderStyle="Solid" ControlToValidate="TextBox1" ErrorMessage="Its a compulsory field" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;<br />
                <br />
                Enter Age :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Age is required"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Not in valid range" MaximumValue="60" MinimumValue="20"></asp:RangeValidator>
                <br />
                <br />
                <br />
                Enter Address&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="129px"></asp:TextBox>
                <br />
                <br />
                Enter MobileNo :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" MaxLength="10" TextMode="Number" Width="129px"></asp:TextBox>
                <br />
                <br />
                UploadResume&nbsp; :<asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" style="margin-left: 23px" Width="224px" />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Submit" />
                <br />
                <br />
                <br />
                <br />
            </asp:View>
            <br />
            <br />
            <asp:View ID="EducationDetails" runat="server">
                Enter the Educational Details
            </asp:View>
            <br />
            <br />
            <br />
            <asp:View ID="BankDetails" runat="server">
                Enter the Bank Details
            </asp:View>
            <br />
            <br />
            <br />
        </asp:MultiView>
    </form>
</body>
</html>
