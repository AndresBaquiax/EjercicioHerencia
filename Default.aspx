<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjercicioHerencia._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Alumnos</h2>
            <p>
                Ingrese su carne</p>
            <p>
                <asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
            </p>
            <p>
                Nombre</p>
            <p>
                <asp:TextBox ID="TextBoxNombreAlumnos" runat="server"></asp:TextBox>
            </p>
            <p>
                Apellido</p>
            <p>
                <asp:TextBox ID="TextBoxApellidosAlumnos" runat="server"></asp:TextBox>
            </p>
            <p>
                Direccion</p>
            <p>
                <asp:TextBox ID="TextBoxDireccionAlumnos" runat="server"></asp:TextBox>
            </p>
            <p>
                Fecha de nacimiento</p>
            <p>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </p>
            <p>
                Ingrese la nota del alumno</p>
            <p>
                <asp:TextBox ID="TextBoxNota" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;<asp:Button ID="ButtonEdadAlumnos" runat="server" Text="Guardar" OnClick="ButtonEdadAlumnos_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Profesores</h2>
            <p>
                &nbsp;Nombre</p>
            <p>
                <asp:TextBox ID="TextBoxNombreProf" runat="server"></asp:TextBox>
            </p>
            <p>
                Apellido</p>
            <p>
                <asp:TextBox ID="TextBoxApellidoProf" runat="server"></asp:TextBox>
            </p>
            <p>
                Direccion</p>
            <p>
                <asp:TextBox ID="TextBoxDireccionProf" runat="server"></asp:TextBox>
            </p>
            <p>
                Ingrese su titulo</p>
            <p>
                <asp:TextBox ID="TextBoxTitulo" runat="server"></asp:TextBox>
            </p>
            <p>
                Fecha de nacimiento</p>
            <p>
                <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            </p>
            <p>
                &nbsp;<asp:Button ID="ButtonEdadProf" runat="server" Text="Guardar" OnClick="ButtonEdadProf_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Abrir Grids" />
            </h2>
            <p>
                ALUMNOS:</p>
            <p>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </p>
            <p>
                PROFESORES:</p>
            <p>
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </p>
        </div>
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
