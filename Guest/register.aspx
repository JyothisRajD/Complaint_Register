<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Main.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="application_nest.Guest.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/StyleSheet1.css" rel="stylesheet" />
    <link href="../css/dropdown.css" rel="stylesheet" />
    <center>
        <div class="form">
    <table >
 <tr>
                    <td>
                        <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>

                        <asp:TextBox ID="txtname" class="t1" runat="server"></asp:TextBox>
                    </td>
                 </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lbluser" runat="server" Text="User"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblphone" runat="server" Text="Phone"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblpass" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server"  Text="Register" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
            </div>
        </center>
</asp:Content>
