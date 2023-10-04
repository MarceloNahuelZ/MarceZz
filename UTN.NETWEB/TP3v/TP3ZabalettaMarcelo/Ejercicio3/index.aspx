<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Ejercicio3.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
            <title>TP3 ZABALETTA MARCELO NAHUEL </title>
                <style> 
                    body{
                        background-color:bisque;
                        font-family:Arial, Helvetica, sans-serif;
                        text-align:center;
                        padding: 100px;
                    }
                    </style>
    </head>
    <body>
        <form runat="server">
            <h1>Bienvenidos al Tp3 .NetWeb</h1>
            <h2>Ingrese su nombre:</h2>
                <asp:TextBox runat="server" ID="txtNombre" Placeholder="Ej: Mauricio" ></asp:TextBox>
            <h2>Seleccione su producto: </h2>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200px" ></asp:DropDownList> <asp:Button ID="Button2" runat="server" Text="Agregar al carrito" OnClick="Button2_Click" /><br />
            <h2>Mi carrito de compras</h2>
                <asp:ListBox ID="ListBox1" runat="server" Width="300px" Height="150px"></asp:ListBox><br /><br />
        
                <asp:Button ID="btnFinalizarCompra" runat="server" Text="Comprar" OnClick="btnFinalizarCompra_Click" />
                <asp:Label runat="server" ID="lblMensajeCompra" Visible="false" ForeColor="Green"></asp:Label>

        </form><br /><br />
        <footer>Zabaletta Marcelo Nahuel</footer>
    </body>
    
</html>
