using MedidoresWebModel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public class LecturasDalObjetos : ILecturaDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }
        public void Eliminar(int id)
        {
            Lectura eliminado = lecturas.Find(x => x.Id == id);
            lecturas.Remove(eliminado);
        }
        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }
    }
}
