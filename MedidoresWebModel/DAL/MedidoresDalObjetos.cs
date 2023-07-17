using MedidoresWebModel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public class MedidoresDalObjetos : IMedidoresDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        public void AgregarMedidores(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public void Eliminar(int numero)
        {
            Medidor eliminado = medidores.Find(c => c.Numero == numero);
            medidores.Remove(eliminado);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }

        public List<TipoMedidor> ObtenerTipos()
        {
            return new List<TipoMedidor>
            {
                new TipoMedidor()
                {
                    Id = 1,
                    Name = "Digital",
                },
                new TipoMedidor()
                {
                    Id = 2,
                    Name = "Mecánico"
                }
            };
        }
    }
}
