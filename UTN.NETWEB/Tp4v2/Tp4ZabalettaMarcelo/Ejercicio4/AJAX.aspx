<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAX.aspx.cs" Inherits="Ejercicio4.AJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        * {
            background-color: darkgray;
            text-align: center;

        }
    </style>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tp4 .NetWeb Zabaletta Marcelo</title>
</head>
    <body>
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <br />
            <h1>Trabajo Practico N 4 <br />
            Zabaletta Marcelo</h1>
            <asp:Label ID="Label1" runat="server" Text="Label fuera del updatepanel">Esta informacion esta fuera del panel actualizable </asp:Label>
            <br />
            <br />
            <div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="Label2" runat="server" Text="Label dentro del updatepanel">Esta informacion se tendria que actualizar si presiona actualizar datos</asp:Label>
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Actualizar Datos"  OnClick="Button1_Click"/>
                        <asp:Button ID="Button2" runat="server" Text="Limpiar Actualizacion" OnClick="Button2_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </form>
    </body>
</html>
