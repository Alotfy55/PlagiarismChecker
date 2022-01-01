<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComapreWithDatabase.aspx.cs" Inherits="PlagiarismChecker.ComapreWithDatabase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="compare" />
        </div>
    </form>
</body>
</html>
