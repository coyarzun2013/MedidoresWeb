using MedidoresWebModel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> ObtenerLecturas();
        void AgregarLectura(Lectura lectura);
        void Eliminar(int id);
    }
}
