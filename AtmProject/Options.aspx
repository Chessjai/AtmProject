<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Options.aspx.cs" Inherits="AtmProject.Options" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center">XPay Life Bank</h1>
            <h2 style="text-align:center">Options</h2>
            <p style="text-align:center">&nbsp;</p>
            <p style="text-align:center">
                <asp:Label ID="Label6" runat="server" Text="userName"></asp:Label>
            </p>

            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Withdraw" OnClick="Button1_Click" />
                    </td>
                      <td>
                          <asp:Button ID="Button2" runat="server" Text="Deposit" OnClick="Button2_Click" />
                    </td>
                      <td>
                          <asp:Button ID="Button3" runat="server" Text="Check Balance" />
                    </td>
                      <td>
                          <asp:Button ID="Button4" runat="server" Text="Show Passbook"  OnClick="Button4_Click" />
                    </td>
                      <td>
                          <asp:Button ID="Button5" runat="server" Text="Log Out" OnClick="Button5_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
