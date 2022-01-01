<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PlagiarismChecker.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 76px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%; height: 748px;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Document 1: "></asp:Label>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                </td>
                <td class="auto-style1"></td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Document 2: "></asp:Label>
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Compare" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
