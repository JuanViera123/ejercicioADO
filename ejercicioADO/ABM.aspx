<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABM.aspx.cs" Inherits="ejercicioADO.ABM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Alta/Baja de autor" />
        <br />
        <br />

        <asp:Label ID="lbl_nombre" runat="server" Text="Nombre" Visible="False"></asp:Label>

    <asp:TextBox ID="txt_nombre" runat="server" Height="16px" Visible="False"></asp:TextBox>
        <asp:Label ID="lbl_apellido" runat="server" Text="Apellido" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txt_apellido" runat="server" Height="16px" Visible="False"></asp:TextBox>
        <asp:Label ID="fecnac" runat="server" Text="Fecha de nacimiento" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txt_nacimiento" runat="server" Height="16px" TextMode="Date" Visible="False"></asp:TextBox>
        <asp:Label ID="lbl_nacionalidad" runat="server" Text="Nacionalidad" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txt_nacionalidad" runat="server" Height="16px" Visible="False"></asp:TextBox>

    
    <asp:Button ID="ButtonAutor" runat="server" OnClick="ButtonAutor_Click" Text="Agregar autor" Visible="False" />
</div>
    <div>
        <asp:Label ID="lbl_busquedaAutor" runat="server" Text="Busca autor a eliminar" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txt_busquedaAutor" runat="server" Height="16px" Visible="False"></asp:TextBox>
          <asp:Button ID="ButtonBusquedaAutor" runat="server" Text="Buscar autor" OnClick="ButtonBusquedaAutor_Click" Visible="False" />

        <asp:GridView ID="GridAutores" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridAutores_SelectedIndexChanged" Visible="False">
             <Columns>
        <asp:BoundField DataField="id" HeaderText="id" 
            InsertVisible="False" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="nombre" HeaderText="nombre" 
            SortExpression="CompanyName" />
        <asp:BoundField DataField="apellido" HeaderText="apellido" 
            SortExpression="FirstName" />
        <asp:BoundField DataField="fecha_nac" HeaderText="fecha_nac" 
            SortExpression="LastName" />
        <asp:BoundField DataField="nacionalidad" HeaderText="nacionalidad" 
            SortExpression="nacionalidad" />
    </Columns>
        </asp:GridView>
        
        <br />
        <br />
 
        
    </div>
    <div> 
        <asp:Button ID="mostrar_ABLibro" runat="server" OnClick="mostrar_ABLibro_Click" Text="Alta/Baja libro" />
        <br />
        <div>     <asp:Label ID="lbl_titulo" runat="server" Text="Titulo" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txt_titulo" runat="server" Visible="False"></asp:TextBox></div>
     
       <div> 
&nbsp;<asp:Label ID="lbl_autor" runat="server" Text="Autor" Visible="False"></asp:Label>
&nbsp;<asp:GridView ID="list_autores" runat="server" AutoGenerateSelectButton="True" Visible="False">
        </asp:GridView>
       </div> 
        <div>
            &nbsp;<asp:Label ID="lbl_descripcion" runat="server" Text="Descripcion" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txt_descripcion" runat="server" Visible="False"></asp:TextBox>
        &nbsp;<asp:Label ID="lbl_year" runat="server" Text="Año de publicacion" Visible="False"></asp:Label>
        <asp:TextBox ID="txt_year" runat="server" Visible="False"></asp:TextBox>
&nbsp;<asp:Button ID="btn_agregarLibro" runat="server" OnClick="Button1_Click" Text="Agregar libro" Visible="False" /> 

        </div>
        <div>

            <asp:Label ID="Label1" runat="server" EnableTheming="True" Text="Busque libro a eliminar" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txt_busquedaLibro" runat="server" OnTextChanged="txt_busquedaLibro_TextChanged" Visible="False"></asp:TextBox>
            <br />
            <asp:GridView ID="GridLibros" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridLibros_SelectedIndexChanged" Visible="False">
            </asp:GridView>

        </div>
      

    </div>
</asp:Content>
