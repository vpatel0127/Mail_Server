<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Internal Mail System</title>
    <link href="StyleSheet.css" rel="Stylesheet" />
    <style type="text/css">
        .style2
        {
            font-size: medium;
            font-weight: bold;
            color: #003300;
            text-align: right;
            font-family: Calibri;
            width: 138px;
        }
        .style3
        {
            width: 138px;
        }
        .style4
        {
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
            text-align: right;
            font-family: Calibri;
            width: 138px;
            height: 31px;
        }
        .style5
        {
            height: 31px;
        }
        .style6
        {
            color: #FFFFFF;
        }
        .style7
        {
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
            text-align: right;
            font-family: Calibri;
            width: 138px;
        }
    </style>
</head>
<body>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
    <div id="head">
    
        <span lang="en-us" 
            style="font-size: 55pt; color: #003300; font-family: Amaranth">&nbsp;</span><span lang="en-us" 
            style="font-size: 55pt; font-family: Amaranth" class="style6">&nbsp;&nbsp;&nbsp; Internal Mail System</span></div>
    <div id="login">
        <table class="tbll">
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    UserName :</td>
                <td align="left" class="style5">
                    <asp:TextBox ID="txtuname" runat="server" BorderColor="#003300" placeholder="Enter Name"
                        BorderStyle="Solid" BorderWidth="1px" Height="25px" Width="157px" 
                      ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtuname" ErrorMessage="Enter Email Id" 
                        Font-Bold="True" style="font-size: small"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Password :</td>
                <td align="left">
                    <asp:TextBox ID="txtupass" runat="server" BorderColor="#003300" placeholder="Enter Password"
                        BorderStyle="Solid" BorderWidth="1px" Height="25px" Width="157px" 
                        TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtupass" ErrorMessage="Enter Password" 
                        Font-Bold="True" style="font-size: small"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td align="left">
                    <asp:Button ID="btnlogin" runat="server" BorderColor="#006600" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" 
                        Height="30px" Text="Sign In" Width="65px" onclick="btnlogin_Click" 
                        CssClass="btnn" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td align="left">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
                        Font-Names="Calibri" ForeColor="#003300" PostBackUrl="~/Signup.aspx" 
                        CausesValidation="False">Create 
                    an Account ?</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td style="text-align: left">
                    <asp:Label ID="lblerror" runat="server" Font-Bold="False" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td style="text-align: left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td style="text-align: left">
                    <a href="admin/login.aspx">Admin Login</a></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
