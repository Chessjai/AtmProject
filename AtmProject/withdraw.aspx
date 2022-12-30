<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="withdraw.aspx.cs" Inherits="AtmProject.withdraw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1 style="text-align:center">XPay Life Bank</h1>
            <h2 style="text-align:center">Withdraw</h2>
            <p style="text-align:center">
    <asp:Label id="label1" runat="server" Text="Label"></asp:Label>
            </p>
           
            <p style="text-align:center; background-color: #FF0000;">
         
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/download.jpg" OnClick="ImageButton1_Click1" />
            </p>
            <table>
                <tr>
                    <td style="background-color: #FFFF00">Withdraw amount</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr> <div>
            <td id="error" runat="server" style="color:red">

            </td>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Withdraw" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="back" />
 </form>
</body>
</html>
