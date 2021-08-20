<%@ Page Title="" Language="C#" MasterPageFile="~/layout/LayoutBlank.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kanban.Login" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container-login">
        <form>
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
                    <button type="submit" data-action="Ingresar">Ingresar</button>
                </div>
                <div class="form-group">
                    <a href="Registro.aspx">registrarse</a>
                </div>
            </div>
        </form>
    </section>
</asp:Content>
