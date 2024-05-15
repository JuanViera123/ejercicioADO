<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ejercicioADO._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
         <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text ="Titulo" Value = 1 />
            <asp:ListItem Text ="Año" Value = 2 />
            <asp:ListItem Text ="Autor" Value = 3 />
        </asp:DropDownList>
        <asp:TextBox ID="busqueda" runat="server"></asp:TextBox>
        <asp:Button ID="BBuscar" runat="server" OnClick="BBuscar_Click" Text="Buscar Libro" />
    &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar autor"  />
          
             <br />
           
    </div> 
        <div>
         <asp:GridView ID="GridView2" runat="server">
             </asp:GridView>
            </div>
    </main>

</asp:Content>
