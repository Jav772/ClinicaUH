<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClinicaUH Web.aspx.cs" Inherits="ClinicaUH.Capa_Web.ClinicaUH_Web" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ClinicaUH - Gestión de Consultas</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Bienvenido!</h2>
        <h2>Gestión de Consultas en ClínicaUH</h2>

        <label>Cedula:</label>
        <asp:TextBox ID="txtCedula" runat="server" required></asp:TextBox><br />

        <label>Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server" required></asp:TextBox><br />

        <label>Apellido:</label>
        <asp:TextBox ID="txtApellido" runat="server" required></asp:TextBox><br />

        <label>Telefono:</label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox><br />

        <label>Fecha de Nacimiento:</label>
        <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox><br />

        <label>Especialidad:</label>
        <asp:TextBox ID="txtEspecialidad" runat="server"></asp:TextBox><br />

        <label>ID de la Consulta:</label>
        <asp:TextBox ID="txtConsultaID" runat="server" required></asp:TextBox><br />

        <label>Fecha de Atención:</label>
        <asp:TextBox ID="txtFechaAtencion" runat="server" TextMode="Date"></asp:TextBox><br />

        <label>Hora de Atención:</label>
        <asp:TextBox ID="txtHoraAtencion" runat="server" TextMode="Time"></asp:TextBox><br />

        <label>Medico:</label>
        <asp:TextBox ID="txtMedico" runat="server"></asp:TextBox><br />

        <label>Consultorio:</label>
        <asp:TextBox ID="txtConsultorio" runat="server"></asp:TextBox><br />

        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />

       <label>
       <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="330px" Width="526px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
           <AlternatingRowStyle BackColor="#DCDCDC" />
           <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
           <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
           <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
           <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
           <SortedAscendingCellStyle BackColor="#F1F1F1" />
           <SortedAscendingHeaderStyle BackColor="#0000A9" />
           <SortedDescendingCellStyle BackColor="#CAC9C9" />
           <SortedDescendingHeaderStyle BackColor="#000065" />
       </asp:GridView>
   </label>
    </form>
</body>
</html>
