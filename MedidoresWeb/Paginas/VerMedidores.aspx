<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidoresWeb.Paginas.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Lista de Medidores
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="row mt-4">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="card-header" >
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body col-md-12" >
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" AutoGenerateColumns="false" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="Numero" HeaderText="Numero de Medidor" />
                            <asp:BoundField DataField="RutCliente" HeaderText="Rut Cliente" />
                            <asp:BoundField DataField="TipoMedidor.name" HeaderText="Tipo de Medidor" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="elimina" CommandArgument='<%# Eval("Numero") %>'
                                        runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div> 
    </div>
</asp:Content>