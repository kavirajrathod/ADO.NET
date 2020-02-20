<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DpInsert.aspx.cs" Inherits="DemoDp2.DpInsert" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotran">

        <asp:Label ID="Label1" runat="server" Text="Label">EmpId</asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label">EmpName</asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Label">EmpCity</asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Insert" onclick="Button1_click"/>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    </div>

</asp:Content>
