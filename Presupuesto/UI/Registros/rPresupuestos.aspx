<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rPresupuestos.aspx.cs" Inherits="Presupuesto.UI.Registros.rPresupuestos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container-fluid">

            <div class="col-12">
                <h2><strong>Registro de Presupuestos</strong></h2>
                <div>

                </div>
               <div>
                   <table>
                       <tr>
                           <td>
                               <strong><asp:Label ID="Label1" runat="server" Text="PresupuestoId:"></asp:Label></strong>
                           </td>
                           <td>
                               <asp:TextBox ID="PresupuestoIdTextBox" runat="server" class="form-control" Height="30"  Width="100"></asp:TextBox>
                           </td>
                           <td>
                               &nbsp&nbsp <asp:Button ID="BuscarButton" runat="server" class="btn btn-danger" Text="Buscar" OnClick="BuscarButton_Click" />
                           </td>
                       </tr>

                   </table>                
               </div> 
                <div>
                    <strong><asp:Label ID="Label2" runat="server" Text="Fecha:"></asp:Label></strong>
                    <asp:TextBox ID="FechaTextBox" TextMode="Date" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Llenar Campos Vacios" ForeColor="Red" ControlToValidate="FechaTextBox">*</asp:RequiredFieldValidator>
               </div> 
                <div>
                    <strong><asp:Label ID="Label3" runat="server" Text="Descripcion:"></asp:Label></strong>
                    <asp:TextBox ID="DescripcionTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="DescripcionTextBox" ForeColor="Red">*</asp:RequiredFieldValidator>
               </div> 
                <div>
                    <strong><asp:Label ID="Label4" runat="server" Text="Monto:"></asp:Label></strong>
                    <asp:TextBox ID="MontoTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Llenar Campos Vacios" ControlToValidate="MontoTextBox" ForeColor="Red">*</asp:RequiredFieldValidator>
               </div>
                
                <div>
                <br />
                    <asp:Button ID="NuevoButton" runat="server" class="btn btn-danger" Text="Nuevo" OnClick="NuevoButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="GuardarButton" runat="server" class="btn btn-danger" Text="Guardar" OnClick="GuardarButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="EliminarButton" runat="server" class="btn btn-danger" Text="Eliminar" OnClick="EliminarButton_Click" />         
                </div>

                <%--<asp:Panel CssClass="alert alert-success" ID="Panel1" runat="server">
                    <asp:Label ID="Label5" runat="server" Text="Guardado"></asp:Label>
                </asp:Panel>--%>
            </div>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="50px" />
    </form>
</body>
</html>
