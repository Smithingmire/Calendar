<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="Calendar.Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />
        <br />
        <asp:Label ID="lblselectedDt" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnApplyLeave" runat="server" Text="Apply Leave" OnClick="btnApplyLeave_Click" />
    </form>
</body>
</html>
