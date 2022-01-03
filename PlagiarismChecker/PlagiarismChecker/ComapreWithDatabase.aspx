<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComapreWithDatabase.aspx.cs" Inherits="PlagiarismChecker.ComapreWithDatabase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            background-image: url('XO.png');
            background-size: cover; 
        }
        .auto-style1 {
            width: 398px;
        }
        .auto-style2 {
            height: 279px;
            width: 423px;
            margin:auto;
            
        }
        .auto-style3 {
            width: 416px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
              <tr>
                <td class="auto-style1"><h1 class="auto-style3">Compare with Database</h1></td>
              </tr>
              <tr>
                <td class="auto-style1" ><asp:FileUpload ID="FileUpload1" runat="server" /></td>
              </tr>
                <tr>
                <td class="auto-style1" >
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Save to History" />
                    </td>
              </tr>
              <tr>
                <td class="auto-style1" ><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="compare" /></td>
              </tr>
              
              <tr>
                <td class="auto-style1" >Plagiarism Percentage % : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
              </tr>
            </table>          
        </div>
    </form>
</body>
</html>
