<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/LayoutBlank.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Kanban.Registro" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container-registro">
        <h3>Sing up</h3>
        <form class="row">
            <div class="col-12 col-sm-12 col-md-12">
                <div class="form-group">
                    <label>Nombre</label>
                    <input type="text" name="txtNombre" id="txtNombre" class="form-control" />
                </div>
            </div>
            <div class="col-12 col-sm-12 col-md-12">
                <div class="form-group">
                    <label>Email</label>
                    <input type="text" name="txtEmail" id="txtEmail" class="form-control" />
                </div>
            </div>
            <div class="col-12 col-sm-6 col-md-6">
                <div class="form-group">
                    <label>Usuario</label>
                    <input type="text" name="txtUsuario" id="txtUsuario" class="form-control" />
                </div>
            </div>
            <div class="col-12 col-sm-6 col-md-6">
                <div class="form-group">
                    <label>Password</label>
                    <input type="password" name="txtPassword" id="txtPassword" class="form-control" />
                </div>
            </div>
            <div class="col-12 col-sm-12 col-md-12">
                <button type="submit" class="btn-block" data-action="Registrar">registrar</button>
            </div>
        </form>
    </section>
</asp:Content>