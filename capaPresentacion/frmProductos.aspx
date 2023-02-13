<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="capaPresentacion.frmProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Productos</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <h4 class="mt-4 text-primary">Productos</h4>
                </div>
                <div class="col-lg-6 col-sm-12 m-auto">
                    <div class="table-responsive">
                        <asp:GridView CssClass="table table-dark table-hover" ID="GridProductos" runat="server"></asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
