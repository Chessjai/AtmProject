<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="AtmProject.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>     
            <h1 style="text-align:center">XPay Life Bank</h1>
            <h2 style="text-align:center">Welcome</h2>
            <p style="text-align:center">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/download.jpg" OnClick="ImageButton1_Click" />
            </p>
            <p style="text-align:center">&nbsp;</p>
            <table>
                <tr >
                    <td >
                            <asp:Label ID="Label1" runat="server" Text="UserName" Width="89%"></asp:Label>
                     
                    </td>
                     <td>
                                <asp:TextBox ID="txtuserName" runat="server"></asp:TextBox>  

                     </td>
               
                </tr>
                 <tr>
                    <td>
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                     
                    </td>
                     <td>
                                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>  

                     </td>
               
                </tr>
                <tr>
                    <td>

                        &nbsp;</td>
                    <td>

                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Button1_Click" />
                     
                    </td>
                     <td>
                         
                              <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Register" />

                     </td>
                     <td>
                         <asp:Button ID="btnforgot" runat="server" Text="Forgot password" OnClick="Button3_Click" />
                     </td>
               
                </tr>


            </table>
        </div>
        <div>
            <td id="error" runat="server" style="color:red">

            </td>
        <p>

                        <asp:Label ID="Label3" runat="server" ></asp:Label>

                    </p>
    </form>
</body>
</html>
