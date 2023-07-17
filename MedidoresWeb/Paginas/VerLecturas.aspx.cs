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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturasDalObjetos();
        private IMedidoresDAL medidoresDAL = new MedidoresDalObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(medidoresDbl.SelectedValue != "Seleccione Una Opción")
            {
                int medidor = Convert.ToInt32(medidoresDbl.SelectedValue);
                RecargarGrilla(medidor);
            } 
            else
            {
                if (!IsPostBack)
                {
                    CargarGrilla();
                }
            }            
        }

        protected void RecargarGrilla(int medidor)
        {
            List<Lectura> lecturas = lecturaDAL.ObtenerLecturas();
            
            lecturas = lecturas.FindAll(b => b.Medidor.Numero == medidor);
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }

        protected void CargarGrilla()
        {
            List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
            this.medidoresDbl.DataSource = medidores;
            this.medidoresDbl.DataTextField = "Numero";
            this.medidoresDbl.DataValueField = "Numero";
            this.medidoresDbl.DataBind();
            List<Lectura> lecturas = lecturaDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }
    }
}