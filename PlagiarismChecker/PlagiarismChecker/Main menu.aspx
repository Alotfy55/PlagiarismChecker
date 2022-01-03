<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main menu.aspx.cs" Inherits="PlagiarismChecker.Main_menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 541px;
            margin-right: 0px;
        }
        .auto-style3 {
            height: 100px;
            width: 551px;
            margin:auto;

            
        }
        .cent{
            margin: auto;
            margin-top: 8%;
            width: 37%;
            border: 3px solid;
            padding: 10px;
        }
        body {
            background-image: url('XO.png');
            background-size: cover; 
        }
        .auto-style7{
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
            font-size: larger;
            color:white;
            background-color:cornflowerblue;
            Height: 58px; 
            Width: 379px;
            Height: 58px;
            Width: 379px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="cent">
            <table class="auto-style1">                
                  <tr>
                    <th class="auto-style3" >
                        <asp:Button  class="auto-style7" ID="Button1" runat="server" Text="Compare Two Files" OnClick="Button1_Click" /></th>
                  </tr>
                  <tr>
                    <th class="auto-style3" >
                        <asp:Button class="auto-style7" ID="Button2" runat="server" Text="Check File" OnClick="Button2_Click"/></th>
                  </tr>
                  <tr>
                    <th class="auto-style3" >
                        <asp:Button  class="auto-style7" ID="Button3" runat="server" Text="History" OnClick="Button3_Click"   /></th>
                  </tr>
                  <tr>
                    <th class="auto-style3">
                        <asp:Button  class="auto-style7" ID="Button4" runat="server" Text="How To Use" OnClick="Button4_Click" /></th>
                  </tr>
                  <tr>
                    <th class="auto-style3">
                        <asp:Button  class="auto-style7" ID="Button5" runat="server" Text="Profile" OnClick="Button5_Click" /></th>
                  </tr>
                
             </table>
        </div>
    </form>
</body>
</html>
