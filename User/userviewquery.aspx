<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="userviewquery.aspx.cs" Inherits="application_nest.User.userviewquery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <table>
        <tr><td>
            Product
            </td>
            <td>
                <asp:TextBox ID="ProductBox" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Question
            </td>
            <td>
                <asp:TextBox ID="QuestionBox" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Reply
            </td>
            <td>
                <asp:TextBox ID="ReplyBox" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
    </table>
        </center>
</asp:Content>
