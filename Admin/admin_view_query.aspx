<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="admin_view_query.aspx.cs" Inherits="application_nest.Admin.admin_view_query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/userviewcomplaint.css" rel="stylesheet" />
    <center>
    <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="qry_Id" HeaderText="Query ID" />
            <asp:BoundField DataField="product" HeaderText="Product Name" />
            <asp:BoundField DataField="qry" HeaderText="Query" />
            <asp:BoundField DataField="reply" HeaderText="Reply" />
            <asp:HyperLinkField DataNavigateUrlFields="qry_Id" DataNavigateUrlFormatString="admin_query_reply.aspx?qry_Id={0}" HeaderText="Reply" Text="Reply" />
        </Columns>
    </asp:GridView>
        </center>
</asp:Content>
