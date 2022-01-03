<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="PlagiarismChecker.History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .tg{

            margin:auto;
        }
        table, th, td {
          border: 1px solid black;
          border-color: #96D4D4;
          border-radius: 10px;
          background-color:whitesmoke;

        }
        body {
            background-image: url('XO.png');
            background-size: cover; 
        }
        .auto-style1 {
            width: 370px;
        }
        .auto-style2 {
            margin: auto;
            width: 1287px;
            height: 192px;
        }
        .fontt{
            font-size:40px;
        }
        .auto-style3 {
            height: 88px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <table class="auto-style2">
                <thead>
                  <tr>
                    <th colspan="3" class="fontt"> History </th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <th >Document 1 Name</th>
                    <th >Document 2 Name</th>
                    <th class="auto-style1" >Similarity Percentage</th>
                  </tr>
                  <tr>
                    <td class="auto-style3" >
                        <asp:GridView ID="GridView1" runat="server" ShowHeader="False">
                        </asp:GridView>
                      </td>
                    <td class="auto-style3" >
                        <asp:GridView ID="GridView2" runat="server" ShowHeader="False">
                        </asp:GridView>
                      </td>
                    <td class="auto-style3" >
                        <asp:GridView ID="GridView3" runat="server" ShowHeader="False">
                        </asp:GridView>
                      </td>
                  </tr>
                </tbody>
              </table>           
        </div>
    </form>
</body>
</html>
