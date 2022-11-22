<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="complaints.aspx.cs" Inherits="application_nest.User.complaints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/Product.css" rel="stylesheet" />
        <div class="login-form">
        <h1>Add Complaints</h1>
   <table>
       <tr>
           <td>Select Product</td>
           <td>
               <asp:DropDownList ID="DropDownList1" class="drop" runat="server" AutoPostBack="True"></asp:DropDownList>
           </td>
       </tr>

       <tr>
           <td>Add Complaints</td>
           <td>
               <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" ></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
               <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click1" />
           </td>
       </tr>
   </table>
</div>
</asp:Content>
