<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio20.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Tabla de Multiplicar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; margin-top: 50px;">
            <h1>Generar Tabla de Multiplicar</h1>
            <asp:Label ID="lblNumero" runat="server" Text="Ingrese un número:"></asp:Label>
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Tabla" OnClick="btnGenerar_Click" />
            <br /><br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            <br />
            <asp:Panel ID="pnlResultado" runat="server" Visible="false">
                <asp:Literal ID="litTabla" runat="server"></asp:Literal>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
