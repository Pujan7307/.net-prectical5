<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calendar.aspx.cs"
Inherits="practical5.calendar" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:Calendar ID="Calendar1" runat="server"
OnSelectionChanged="Calendar1_SelectionChanged">
</asp:Calendar>
</div>
<asp:TextBox ID="TextBox1" runat="server"
OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
<p>
<asp:Button ID="Button1" runat="server" Text="Apply Leave"
OnClick="Button1_Click" />
</p>
</form>
</body>
</html>