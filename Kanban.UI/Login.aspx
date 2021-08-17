<%@ Page Title="" Language="C#" MasterPageFile="~/layout/LayoutBlank.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kanban.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-login">
            <div class="form-group">
                <label>Usuario</label>
                <input type="text" class="form-control" name="txtUsuario" id="txtUsuario" data-action-name="user" autofocus="" />
            </div>
            <div class="form-group">
                <label>Clave</label>
                <input type="password" class="form-control" name="txtPassword" id="txtPassword" data-action-name="password" />
            </div>
            <div class="acciones-login">
                <div class="form-group">
                    <button type="button" data-action="Ingresar">Ingresar</button>
                </div>
                <div class="form-group">
                    <a href="Registro.aspx">registrarse</a>
                </div>
            </div>
        </div>
</asp:Content>
