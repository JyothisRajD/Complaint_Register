<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="admin_query_reply.aspx.cs" Inherits="application_nest.Admin.admin_query_reply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <table>
        <tr>
            <td>
                Product
            </td>
            <td>
                <asp:TextBox ID="productBox" runat="server" ReadOnly="True" ></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Question
            </td>
            <td>
                <asp:TextBox ID="questionBox" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Reply
            </td>
            <td>
                <asp:TextBox ID="replyBox" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Reply" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
        </center>
</asp:Content>
