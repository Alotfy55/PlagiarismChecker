<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login Form.aspx.cs" Inherits="PlagiarismChecker.Login_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
         body {
            background-image: url('XO.png');
        }
        .auto-style1 {
            height: 70px;
        }
        .auto-style2 {
            height: 35px;
        }
        .auto-style3 {
            height: 67px;
            width: 193px;
        }
        .auto-style4 {
            width: 240px;
            color:black;
        }
        .auto-style5 {
            height: 70px;
            width: 240px;
        }
        .auto-style6 {
            height: 67px;
            width: 240px;
        }
        .auto-style7 {
            width: 193px;
            color: black;
            font-size: large;
        }

        .auto-style12{
            margin-left:100px;
            width: 193px;
            color:black;
            align-self :center;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
        <div>
             <table class="tg">
                <thead>
                  <tr>
                    <th class="auto-style12" colspan="2" ><h1>Login</h1></th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td class="auto-style7" rowspan="2">Username</td>
                    <td class="auto-style4" rowspan="2"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td class="auto-style14"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor ="Red" ControlToValidate="TextBox1" ErrorMessage="* This Field is required *"></asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td class="auto-style2">
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td>
                  </tr>
                  <tr>
                      
                    <td class="auto-style7">Password</td>
                    <td class="auto-style5"> <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td class="auto-style1"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ForeColor ="Red" ControlToValidate="TextBox2" ErrorMessage="* This Field is required *"></asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                      <td class="auto-style3"></td>
                    <td class="auto-style6" >
                        <asp:Button ID="Button1" runat="server" Text="LOGIN" Width="170px" CssClass="auto-style25" OnClick="Button1_Click"  /></td>
                  </tr>
                  <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style4">Haven't Got An Account Yet ?</td>
                    <td ></td>
                  </tr>
                  <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style4">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration Form.aspx">Sign Up</asp:HyperLink></td>
                    <td ></td>
                  </tr>
                </tbody>
                </table>
        </div>
    </form>
</body>
</html>
