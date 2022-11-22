<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="queries.aspx.cs" Inherits="application_nest.User.queries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/userviewcomplaint.css" rel="stylesheet" />
    <link href="../css/dropdown.css" rel="stylesheet" />
    <center>

        <formview id="view" runat="server">
<section>
    <div class="color"></div>
    <div class="color"></div>
    <div class="color"></div>
    <div class="box">
        <div class="form">
        <div class="inputbox">
            <asp:DropDownList ID="DropDownList1" CssClass="style" runat="server"></asp:DropDownList>
        </div>
        <div class="inputbox">
            <asp:TextBox ID="TextBox3" runat="server" CssClass="style" TextMode="MultiLine" PlaceHolder="Type Here"></asp:TextBox>
        </div>
        <div class="inputbox">
            <asp:Button ID="Button1" runat="server" CssClass="button-4" Text="Send" OnClick="Button1_Click" />
        </div>


    <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows"  AutoGenerateColumns="False" DataKeyNames="qry_Id">
        <Columns>
            <asp:BoundField DataField="qry_Id" HeaderText="Query ID" />
            <asp:BoundField DataField="qry" HeaderText="Query" />
            <asp:BoundField DataField="product" HeaderText="Product Name" />
            <asp:HyperLinkField DataNavigateUrlFields="qry_Id" DataNavigateUrlFormatString="userviewquery.aspx?qry_Id={0}" HeaderText="Details" Text="View Reply" />
        </Columns>
        
    </asp:GridView>
    </div>
    </div>
</section>
        </formview>
        </center>
</asp:Content>
