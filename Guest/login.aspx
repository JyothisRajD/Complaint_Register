<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="application_nest.Guest.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/login.css" rel="stylesheet" />
   <div class="login-form">
       <h1>Login Form</h1>
            <table align="center" class="style">
            <tr>
                <td><p>Username</p></td>
             <td>
            <asp:TextBox ID="Name" runat="server" class="textbox" ></asp:TextBox></td>
            </tr>
            <tr>
                <td><p>Password</p></td>
                <td><asp:TextBox ID="pwd" runat="server" class="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" class="button"/></td>
            </tr>
        </table>
       </div>
</asp:Content>
