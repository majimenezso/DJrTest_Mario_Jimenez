<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Aplicativo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
    <h1 class="display-4">Registrar Tarea</h1>
</div>


    <div class="text-center">
        <label>Nombre</label>
    </div>
    <div class="text-center">
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
    </div>
    <div class="text-center">
        <label>Prioridad</label>
    </div>
    <div class="text-center">
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
    </div>
    
    <div class="text-center">
        <asp:Button ID="btn1" runat="server" Text="Registrar" OnClick="btn1_Click" />
    </div>



</asp:Content>
