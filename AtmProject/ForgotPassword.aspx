<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="AtmProject.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <h1 style="text-align:center">
                  <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/download.jpg" OnClick="ImageButton1_Click" />
              </h1>
              <h1 style="text-align:center">XPay Life Bank</h1>
            <h2 style="text-align:center"> Password Reset Form</h2>
            <table>
                 <tr>
                    <td>
                        
                            <asp:Label ID="Label10" runat="server" Text="Select Question"></asp:Label>
                     
                    </td>
                     <td>
                               &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" AutoPostBack="True">
                                   <asp:ListItem Selected="True">what is your fav color?</asp:ListItem>
                                   <asp:ListItem>What is your DOB?</asp:ListItem>
                                   <asp:ListItem>What is your fav number?</asp:ListItem>
                                   <asp:ListItem>what is your fav car?</asp:ListItem>
                               </asp:DropDownList>

                     </td>
               
                </tr>
                   <tr>
                    <td>
                            <asp:Label ID="Label6" runat="server" Text=" Type the Answer"></asp:Label>
                     
                    </td>
                     <td>
                                <asp:TextBox ID="txtanswer" runat="server"   ></asp:TextBox><asp:RequiredFieldValidator runat="server" ControlToValidate="txtanswer" ErrorMessage="enter your answer"></asp:RequiredFieldValidator>  

                     </td>
               
                </tr>
                   <tr>
                    <td>
                            <asp:Label ID="Label1" runat="server" Text=" Enter Mobile No"></asp:Label>
                     
                    </td>
                     <td>
                                <asp:TextBox ID="txtmobileno" runat="server" ></asp:TextBox><asp:RequiredFieldValidator runat="server"  ControlToValidate="txtmobileno" ErrorMessage="enter your mobile"></asp:RequiredFieldValidator>  

                     </td>
               
                </tr>
                   <tr>
                    <td>
                            <asp:Label ID="Label2" runat="server" Text="Enter New Password"></asp:Label>
                     
                    </td>
                     <td>
                                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ControlToValidate="txtpassword" ErrorMessage="enter new password"></asp:RequiredFieldValidator>  

                     </td>
               
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
                <div>
                    <asp:HyperLink ID="back1" runat="server" Text="back" NavigateUrl="~/LogIn.aspx" >  </asp:HyperLink>           
                        </div>
                      <tr>
                    <td>
                                                <br />
                        <asp:Label ID="lblmsg" runat="server" Text="success"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
