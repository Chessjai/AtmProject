<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="passbook.aspx.cs" Inherits="AtmProject.passbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1 style="text-align:center">
                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                     <Columns>
                         <asp:BoundField DataField="transaction_remark" HeaderText="transaction_remark" SortExpression="transaction_remark" />
                         <asp:BoundField DataField="user_id" HeaderText="user_id" SortExpression="user_id" />
                         <asp:BoundField DataField="transaction_id" HeaderText="transaction_id" SortExpression="transaction_id" />
                         <asp:BoundField DataField="transaction_amount" HeaderText="transaction_amount" SortExpression="transaction_amount" />
                         <asp:BoundField DataField="current_balance" HeaderText="current_balance" SortExpression="current_balance" />
                     </Columns>
                 </asp:GridView>
                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jaiatmproject1ConnectionString %>" SelectCommand="SELECT [transaction_remark], [user_id], [transaction_id], [transaction_amount], [current_balance] FROM [tbl_passbook_master]"></asp:SqlDataSource>
                 XPay Life Bank</h1>
            <h2 style="text-align:center">Welcome</h2>
             <p style="text-align:center">
                 <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
             </p>
             <table>
                <tr>
                    <td>
                     User_id
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        A/C Balance</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                                  
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" Text="back" />
    </form>
</body>
</html>
