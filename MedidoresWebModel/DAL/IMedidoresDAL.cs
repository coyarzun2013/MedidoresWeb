using MedidoresWebModel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public interface IMedidoresDAL
    {
        List<TipoMedidor> ObtenerTipos();
        List<Medidor> ObtenerMedidores();
        void AgregarMedidores(Medidor medidor);
        void Eliminar(int id);

    }
}
