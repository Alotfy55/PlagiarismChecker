<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Analyze.aspx.cs" Inherits="PlagiarismChecker.Guide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .cent {
            margin:auto;
        }
        body {
            background-image: url('XO.png');
            background-size: cover; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cent">
            &nbsp;<asp:GridView ID="GridView1" runat="server" ShowHeader="False">
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server" ShowHeader="False">
            </asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
