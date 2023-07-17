using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAO
{
    public class Medidor
    {
        private int numero;
        private string rutCliente;
        private int tipo;
        private TipoMedidor tipoMedidor;

        public int Numero { get => numero; set => numero = value; }
        public string RutCliente { get => rutCliente; set => rutCliente = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public TipoMedidor TipoMedidor { get => tipoMedidor; set => tipoMedidor = value; }
    }
}
