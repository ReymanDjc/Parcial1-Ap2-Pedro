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
                               &nbsp&nbsp <asp:Button ID="BuscarButton" runat="server" class="btn btn-danger" Text="Buscar" />
                           </td>
                       </tr>

                   </table>                
               </div> 
                <div>
                    <strong><asp:Label ID="Label2" runat="server" Text="Fecha:"></asp:Label></strong>
                    <asp:TextBox ID="FechaTextBox" TextMode="Date" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
               </div> 
                <div>
                    <strong><asp:Label ID="Label3" runat="server" Text="Descripcion:"></asp:Label></strong>
                    <asp:TextBox ID="DescripcionTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
               </div> 
                <div>
                    <strong><asp:Label ID="Label4" runat="server" Text="Monto:"></asp:Label></strong>
                    <asp:TextBox ID="MontoTextBox" runat="server" class="form-control" Height="30"  Width="300"></asp:TextBox>
               </div>
                
                <div>
                <br />
                    <asp:Button ID="NuevoButton" runat="server" class="btn btn-danger" Text="Nuevo" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="GuardarButton" runat="server" class="btn btn-danger" Text="Guardar" OnClick="GuardarButton_Click" />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="EliminarButton" runat="server" class="btn btn-danger" Text="Eliminar" />
                    
                </div>

            </div>



        </div>
    </form>
</body>
</html>
