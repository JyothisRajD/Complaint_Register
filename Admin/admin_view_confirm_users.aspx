<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="admin_view_confirm_users.aspx.cs" Inherits="application_nest.Admin.admin_confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/userviewcomplaint.css" rel="stylesheet" />
    <center>
    <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="user_id" >
        <Columns>
            <asp:BoundField DataField="user_id" HeaderText="User ID" />
            <asp:BoundField DataField="name" HeaderText="Name" />
            <asp:BoundField DataField="user_email" HeaderText="E-Mail" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
            <asp:BoundField DataField="username" HeaderText="User Name" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:BoundField DataField="role" HeaderText="Role" />
            <asp:CommandField DeleteText="Confirm" HeaderText="Confirm" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
        </center>
</asp:Content>
