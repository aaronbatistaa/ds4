<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio202.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Matriz N x N</title>
    <style>
        table {
            margin: auto;
            border-collapse: collapse;
        }
        td {
            width: 40px;
            height: 40px;
            text-align: center;
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; margin-top: 50px;">
            <h1>Generar Matriz N x N</h1>
            <asp:Label ID="lblN" runat="server" Text="Ingrese el tamaño de la matriz (N):"></asp:Label>
            <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Matriz" OnClick="btnGenerar_Click" />
            <br /><br />
            <asp:Panel ID="pnlMatriz" runat="server" Visible="false">
                <asp:Literal ID="litMatriz" runat="server"></asp:Literal>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
