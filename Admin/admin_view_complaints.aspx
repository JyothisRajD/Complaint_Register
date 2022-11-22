<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="admin_view_complaints.aspx.cs" Inherits="application_nest.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/userviewcomplaint.css" rel="stylesheet" />
    <center>
    <div>
        <table>
           <tr>
               <th>Complaints</th>
               <td>
                   <asp:DropDownList ID="day" runat="server"></asp:DropDownList>
               </td>
               <td>
                   <asp:DropDownList ID="Month" runat="server"></asp:DropDownList>
               </td>
               <td>
                   <asp:DropDownList ID="year" runat="server"></asp:DropDownList>
               </td>
               <td></td>
               <th>
                   To
               </th>
               <td></td>
               <td>
                   <asp:DropDownList ID="Today" runat="server"></asp:DropDownList>
               </td>
               <td>
                   <asp:DropDownList ID="Tomonth" runat="server"></asp:DropDownList>
               </td>
               <td>
                   <asp:DropDownList ID="Toyear" runat="server"></asp:DropDownList>
               </td>
               <td></td>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" /></td>
           </tr>
       </table>
        </div>

    <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AutoGenerateColumns="False" DataKeyNames="c_Id" Width="778px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="cmpl" HeaderText="Complaints" />
            <asp:BoundField DataField="product" HeaderText="Product Name" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:BoundField DataField="c_Id" HeaderText="Complaint ID" />
            <asp:BoundField DataField="username" HeaderText="Name" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
                </center>
        </asp:Content>
