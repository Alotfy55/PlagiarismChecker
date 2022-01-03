<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Analyze.aspx.cs" Inherits="PlagiarismChecker.Guide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .f{
            font-size:larger;
        }
        .cent {
            margin:auto;
        }
        body {
            background-image: url('XO.png');
            background-size: cover; 
        }
        .auto-style1 {
            margin: auto;
            height: 164px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <table class="auto-style1">
                <thead>
                  <tr>
                    <th colspan="2" class="f">Document Analysis</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td colspan="2"><asp:FileUpload ID="FileUpload1" runat="server" /></td>
                  </tr>
                  <tr>
                    <td colspan="2"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Analyze" /></td>
                  </tr>
                    <tr>
                    <th >Words</th>
                    <th >Count</th>
                  </tr>
                  <tr>
                    <td ><asp:GridView ID="GridView1" runat="server" ShowHeader="False" BackColor="WhiteSmoke"></asp:GridView></td>
                    <td ><asp:GridView ID="GridView2" runat="server" ShowHeader="False" BackColor="WhiteSmoke"></asp:GridView></td>
                  </tr>
                </tbody>
             </table>
        </div>
    </form>
</body>
</html>
