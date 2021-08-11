<%@ Page Title="" Language="C#" MasterPageFile="~/layout/LayoutBlank.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kanban.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-login">
        <div class="form-group">
            <label>Usuario</label>
            <input type="text" class="form-control" name="txtUsuario" id="txtUsuario" autofocus />
        </div>
        <div class="form-group">
            <label>Clave</label>
            <input type="text" class="form-control" name="txtPassword" id="txtPassword" />
        </div>
        <div class="acciones-login">
            <div class="form-group">
                <asp:Button runat="server" ID="buttonIngresar" ClientIDMode="Static" Text="Ingresasr" OnClick="Ingresar" />
            </div>
            <div class="form-group">
                <a href="Registro.aspx">registrarse</a>
            </div>
        </div>
    </div>
</asp:Content>
