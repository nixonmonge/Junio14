<%@ Page Language="C#" 
    AutoEventWireup="true" CodeBehind="WebDiccionario.aspx.cs" 
    ValidateRequest = "False"
    Inherits="Junio14.WebDiccionario" %>

<%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hola Mundo:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Height="81px" TextMode="MultiLine" Width="378px"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" Height="98px" TextMode="Date" Width="173px"></asp:TextBox>
            <br />
            <br />
            <FTB:FreeTextBox ID="FreeTextBox1" runat="server">
            </FTB:FreeTextBox>
        </div>
    </form>
    <a href="WebDiccionario.aspx">Ir a la misma Pagina</a><br />
    <a href="WebDiccionario.aspx?id=click">id ahora es click</a><br />
</body>
</html>
