using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAO
{
    public class Lectura
    {
        private int id;
        private string hora;
        private string fecha;
        private int consumo;
        private Medidor medidor;

        public int Id { get => id; set => id = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Consumo { get => consumo; set => consumo = value; }
        public Medidor Medidor { get => medidor; set => medidor = value; }
    }
}
