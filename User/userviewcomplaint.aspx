<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="userviewcomplaint.aspx.cs" Inherits="application_nest.User.userviewcomplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/userviewcomplaint.css" rel="stylesheet" />
    <center>
        <h1>Complaints</h1>
    <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AutoGenerateColumns="False" >
    <Columns>
        <asp:BoundField DataField="c_Id" HeaderText="Complaint ID" />
        <asp:BoundField DataField="product" HeaderText="Product" />
        <asp:BoundField DataField="cmpl" HeaderText="Complaint" />
        <asp:BoundField DataField="date" HeaderText="Date" />
        <asp:BoundField DataField="status" HeaderText="Status" />

    </Columns>
        
</asp:GridView>
        </center>
</asp:Content>
