<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration Form.aspx.cs" Inherits="PlagiarismChecker.Registration_Form" %>

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
            margin-top: 50px;
            margin-left: 3%; 
        }        

        .auto-style10 {
            width: 157px;
            color:black;

        }
        .auto-style11 {
            width: 193px;
            color:black;
            font-size:large;
        }
        .auto-style12 {
            height: 61px;
            color:black;
            align-self:center;

        }
        .auto-style14 {
            width: 445px;
            height: 25px;
        }
        .login{
            color:black;

        }
        .already{
            color:black;
        }
        .auto-style17 {
            width: 445px;
            height: 50px;
        }
        .auto-style23 {
            width: 445px;
            height: 20px;
        }
        .auto-style24 {
            height: 110px;
        }

        .auto-style25 {
            margin-left: 0px;
        }

    </style>
</head>
<body style="height: 608px" >
    <form id="form1" runat="server">
        <div class="auto-style1" >
            <table class="tg">
                <thead>
                  <tr>
                    <th class="auto-style12" colspan="2"><h1>Registration</h1></th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td class="auto-style11" rowspan="2">Username</td>
                    <td class="auto-style10" rowspan="2"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td class="auto-style14"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor ="Red" ControlToValidate="TextBox1" ErrorMessage="* This Field is required *"></asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td class="auto-style14">
                      <!  <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator></td> >
                  </tr>
                  <tr>
                    <td class="auto-style11">Password</td>
                    <td class="auto-style10"> <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td class="auto-style17"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ForeColor ="Red" ControlToValidate="TextBox2" ErrorMessage="* This Field is required *"></asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td class="auto-style11" rowspan="2">Confirm Password</td>
                    <td class="auto-style10" rowspan="2"><asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td class="auto-style14"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ForeColor ="Red" ControlToValidate="TextBox3" ErrorMessage="* This Field is required *"></asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td class="auto-style14"><asp:CompareValidator ID="CompareValidator1" runat="server"  ForeColor ="Red" ErrorMessage="* Password and confirm password does not match *" Type="String" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Operator="Equal" ></asp:CompareValidator></td>
                  </tr>

                  <tr>
                      <td></td>
                    <td class="auto-style24" >
                        &nbsp; &nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Sign Up" Width="170px" CssClass="auto-style25" OnClick="Button1_Click"  /></td>
                  </tr>
                  <tr>
                    <td></td>
                    <td class="already">Already Have An Account</td>
                    <td ></td>
                  </tr>
                  <tr>
                    <td></td>
                    <td class="login">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login Form.aspx">Sign In</asp:HyperLink></td>
                    <td ></td>
                  </tr>
              </tbody>
          </table>
        </div>
    </form>
</body>
</html>
