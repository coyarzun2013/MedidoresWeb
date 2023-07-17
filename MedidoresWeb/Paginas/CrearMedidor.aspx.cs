using MedidoresWebModel.DAL;
using MedidoresWebModel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb.Paginas
{
    public partial class CrearMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDalObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<TipoMedidor> tipos = medidoresDAL.ObtenerTipos();
                this.medidoresDbl.DataSource = tipos;
                this.medidoresDbl.DataTextField = "Name";
                this.medidoresDbl.DataValueField = "Id";
                this.medidoresDbl.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                List<TipoMedidor> tiposMedidores = medidoresDAL.ObtenerTipos();
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                int numero = Convert.ToInt32(this.numerotxt.Text);
                string rutCliente = this.ruttxt.Text;
                int tipoTexto = Convert.ToInt32(this.medidoresDbl.SelectedValue);
                TipoMedidor tipomedObj = tiposMedidores.Find(b => b.Id == tipoTexto);
                Medidor medidorObj = medidores.Find(b => b.Numero == numero);

                if(medidorObj == null)
                {
                    Medidor medidor = new Medidor()
                    {
                        Numero = numero,
                        RutCliente = rutCliente,
                        Tipo = tipoTexto,
                        TipoMedidor = tipomedObj,
                    };
                    medidoresDAL.AgregarMedidores(medidor);
                    this.mensajesLbl.Text = "Medidor Agregado correctamente.";
                    Response.Redirect("VerMedidores.aspx");
                } else
                {
                    this.mensajesLbl.Text = "El Medidor con ese numero ya existe.";
                }

            }
        }

    }
}