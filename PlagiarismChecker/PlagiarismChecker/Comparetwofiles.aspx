<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comparetwofiles.aspx.cs" Inherits="PlagiarismChecker.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
  
        body {
            background-image: url('XO.png');
            background-size: cover; 
        }
        .auto-style3 {
            width: 416px;
        }
        .auto-style2 {
            width: 622px;
            height: 306px;
            margin:auto;
          
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style2">
            <thead>
              <tr>
                <th colspan="2"><h1 class="auto-style3">Compare Two Files</h1></th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td >Document 1 :</td>
                <td ><asp:FileUpload ID="FileUpload1" runat="server" /></td>
              </tr>
              <tr>
                <td >Document 2 :</td>
                <td ><asp:FileUpload ID="FileUpload2" runat="server" /></td>
              </tr>
              <tr>
                <td  colspan="2"><asp:CheckBox ID="CheckBox1" runat="server" Text="Save to Database" /></td>
              </tr>
              <tr>
                <td  colspan="2"> <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Compare" /></td>
              </tr>
              <tr>
                <td >Plagiarism Percentage :</td>
                <td ><asp:TextBox ID="TextBox1" runat="server" BackColor="whitesmoke" ForeColor="Red" Enabled="false"></asp:TextBox></td>
              </tr>
            </tbody>
            </table>
        
    </form>
</body>
</html>
