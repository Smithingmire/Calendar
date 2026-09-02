<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveForm.aspx.cs" Inherits="Calendar.LeaveForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Application</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px"">
            <h1>LEAVE APPLICATION</h1>
            Employee Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /> <br />

            Leave Date:
            <asp:Label ID="lblLeaveDate" runat="server" Text="Label"></asp:Label>
            <br />
            <br />

            Leave Type:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Select Type</asp:ListItem>
                <asp:ListItem>Personal</asp:ListItem>
                <asp:ListItem>Mediacl Leave</asp:ListItem>
                <asp:ListItem>Emergency Leave</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />

            Reason: 
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="5" Columns="30"></asp:TextBox>
            <br />
            <br />

            Remember Name:
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember My Name..." />
            <br /><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit Leave" OnClick="btnSubmit_Click" />
            <br />
            <br />

            <asp:Label ID="lblmssg" runat="server"></asp:Label>
 
            </div>
    </form>
</body>
</html>
