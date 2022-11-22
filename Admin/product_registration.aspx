<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="product_registration.aspx.cs" Inherits="application_nest.Admin.product_registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/userviewcomplaint.css" rel="stylesheet" />
    <center>
    <div>
    <table allign="center">
        <tr>
            <td>
                <asp:Label ID="lblp_id" runat="server" Text="Product"></asp:Label>
            </td>
             <td>
                 <asp:TextBox ID="txtpro" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
             <td>
                 <asp:Button ID="Btn_reg" runat="server" Text="Register" OnClick="Btn_reg_Click" />
            </td>
        </tr>
    </table>
        <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AutoGenerateColumns="False" DataKeyNames="p_Id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="p_Id" HeaderText="Product ID" />
                <asp:BoundField DataField="product" HeaderText="Product Name" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
   </div>
        </center>
</asp:Content>
