<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio203.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Gestión de Productos</title>
    <style>
        .container {
            margin: 50px auto;
            width: 50%;
            text-align: center;
        }

        table {
            margin: 20px auto;
            border-collapse: collapse;
        }

        table, th, td {
            border: 1px solid black;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Gestión de Productos</h1>
            <label for="tstId">Buscar por ID:</label>
            <asp:TextBox ID="tstId" runat="server"></asp:TextBox>
            <asp:Button ID="tsbBuscar" runat="server" Text="Buscar" OnClick="tsbBuscar_Click" />
            <br /><br />

            <label>ID:</label>
            <asp:TextBox ID="txtId" runat="server" Enabled="false"></asp:TextBox>
            <br /><br />
            <label>Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br /><br />
            <label>Precio:</label>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <br /><br />
            <label>Stock:</label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="tsbNuevo" runat="server" Text="Nuevo" OnClick="tsbNuevo_Click" />
            <asp:Button ID="tsbGuardar" runat="server" Text="Guardar" OnClick="tsbGuardar_Click" Enabled="false" />
            <asp:Button ID="tsbCancelar" runat="server" Text="Cancelar" OnClick="tsbCancelar_Click" Enabled="false" />
            <asp:Button ID="tsbEliminar" runat="server" Text="Eliminar" OnClick="tsbEliminar_Click" Enabled="false" />
        </div>
    </form>
</body>
</html>
