<%@ Page Title="" Language="C#" MasterPageFile="~/layout/LayoutBlank.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kanban.Login" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container-login">
        <form method="post">
            <div class="form-auth">
                <h1>Iniciar sesión</h1>
                <div class="form-auth-body">
                    <div class="form-group">
                        <label>Usuario</label>
                        <div class="input-group">
                            <input type="text" class="form-control" name="txtUsuario" id="txtUsuario" data-action-name="username" autofocus="" autocomplete="username" />
                            <span class="icon-group material-icons md-24">cancel</span>
                        </div>
                    </div>
                    <div class="form-group">
                        <label>Clave</label>
                        <div class="input-group">
                            <input type="password" class="form-control" name="txtPassword" id="txtPassword" data-action-name="password" autocomplete="current-password" />
                            <span class="icon-group material-icons md-24">lock</span>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="form-check">
                            <input type="checkbox" name="remember" />
                            <span>Recordar credenciales</span>
                        </label>
                    </div>
                    <div class="form-group">
                        <button type="submit" data-action="Ingresar" class="btn-block">Ingresar</button>
                    </div>
                </div>
                <div class="call-register">
                    <a href="Registro.aspx">Crear una cuenta.</a>
                </div>
            </div>
        </form>
    </section>
</asp:Content>
