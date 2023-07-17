<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="MedidoresWeb.Paginas.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Ver Lecturas
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
     <div class="row mt-4">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="card-header" >
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body col-md-12" >
                    <div class="mensaje">
                        <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
                    </div>
                    <div class="form-group mb-3">
                        <label >Tipo</label>
                        <asp:DropDownList runat="server" ID="medidoresDbl" CssClass="form-select form-select-sm" AutoPostBack="true" AppendDataBoundItems="true">
                            <asp:ListItem Text="Seleccione Una Opción" ></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" AutoGenerateColumns="false" ID="grillaLecturas">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="ID Lectura" />
                            <asp:BoundField DataField="Medidor.numero" HeaderText="Numero de Medidor" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha Lectura" />
                            <asp:BoundField DataField="Hora" HeaderText="Hora Lectura" />
                            <asp:BoundField DataField="Consumo" HeaderText="Consumo Registrado" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="elimina" CommandArgument='<%# Eval("Id") %>'
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