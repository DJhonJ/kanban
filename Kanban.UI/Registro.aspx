<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/LayoutBlank.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Kanban.Registro" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container-register">
        <form method="post">
            <div class="form-register">
                <div class="row">
                    <div class="col-12 col-md-12">
                        <h1>Registrarse</h1>
                    </div>
                    <div class="col-12 col-sm-12 col-md-12">
                        <div class="form-group">
                            <label>Nombre</label>
                            <input type="text" name="txtNombre" id="txtNombre" class="form-control" data-action-name="nombre" autofocus />
                        </div>
                    </div>
                    <div class="col-12 col-sm-12 col-md-12">
                        <div class="form-group">
                            <label>Email</label>
                            <input type="text" name="txtEmail" id="txtEmail" class="form-control" data-action-name="email" />
                        </div>
                    </div>
                    <div class="col-12 col-sm-6 col-md-6">
                        <div class="form-group">
                            <label>Usuario</label>
                            <input type="text" name="txtUsuario" id="txtUsuario" class="form-control" data-action-name="username" />
                        </div>
                    </div>
                    <div class="col-12 col-sm-6 col-md-6">
                        <div class="form-group">
                            <label>Password</label>
                            <input type="password" name="txtPassword" id="txtPassword" class="form-control" data-action-name="password" />
                        </div>
                    </div>
                    <div class="col-12 col-sm-12 col-md-12">
                        <div class="form-group">
                            <button type="submit" class="btn-block btn-black" data-action="Register">Registrar</button>
                        </div>
                    </div>
                </div>
                <div class="call-auth-login">
                    <a href="Login.aspx">Iniciar sesión</a>
                </div>
            </div>
        </form>
    </section>
</asp:Content>
