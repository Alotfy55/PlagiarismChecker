<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PlagiarismChecker.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 84px;
        }
        body {
            background-image: url('XO.png');
        }
        .auto-style2 {
            height: 305px;
            width: 325px;
            margin:auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <thead>
                  <tr>
                    <th class="auto-style12" colspan="2"><h1>Profile</h1></th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td class="auto-style11" >Username</td>
                    <td class="auto-style10" ><asp:TextBox ID="TextBox1" runat="server" Enabled="false"></asp:TextBox></td>              
                  </tr>
                                
                  <tr>
                    <td class="auto-style11" >Age</td>
                    <td class="auto-style10" ><asp:TextBox ID="TextBox4" runat="server" Enabled="false"></asp:TextBox></td>                  
                  </tr>
                 
                  <tr>
                    <td class="auto-style1">Gender</td>
                    <td class="auto-style1"><asp:RadioButtonList ID="RadioButtonList1" runat="server" Enabled="False">
                                    <asp:ListItem >Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                    <asp:ListItem>Other</asp:ListItem>
                                    </asp:RadioButtonList></td>
    
                  </tr>              
               </tbody>
            </table>
        </div>
    </form>
</body>
</html>
