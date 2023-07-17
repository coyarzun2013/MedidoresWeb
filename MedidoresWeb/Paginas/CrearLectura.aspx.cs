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
    
    public partial class CrearLectura : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDalObjetos();
        private ILecturaDAL lecturaDAL = new LecturasDalObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.medidoresDbl.DataSource = medidores;
                this.medidoresDbl.DataTextField = "Numero";
                this.medidoresDbl.DataValueField = "Numero";
                this.medidoresDbl.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int consumo = Convert.ToInt32(this.consumotxt.Text);
                int hora = Convert.ToInt32(this.horatxt.Text);
                int minuto = Convert.ToInt32(this.minutostxt.Text);
                string fecha = this.fechatxt.SelectedDate.ToString();
                int medidor = Convert.ToInt32(this.medidoresDbl.SelectedValue);
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                Medidor medidorObj = medidores.Find(b => b.Numero == medidor);
                String horaString = hora.ToString() + ":" + minuto.ToString();
                Lectura lectura = new Lectura()
                {
                    Consumo = consumo,
                    Fecha = fecha,
                    Hora = horaString,
                    Medidor = medidorObj
                };
                lecturaDAL.AgregarLectura(lectura);

                this.mensajesLbl.Text = "Lectura agregada correctamente";
                Response.Redirect("VerLecturas.aspx");
            }

        }

    }
}