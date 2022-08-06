using DATA;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYER
{
    public class PrestamoServicio
    {
        PrestamoDatos eData = new PrestamoDatos();
        public void SetPrestamo(PRESTAMO p)
        {
            eData.SetPrestamo(p);
        }

        public List<PRESTAMO> Leer()
        {
            return eData.Leer();
        }
        public PRESTAMO Busca(int id)
        {
            return eData.Buscar(id);

        }
        public void Actualizar(PRESTAMO p)
        {

            eData.Actualizar(p);
        }
        public void Borrar(int id)
        {
            eData.Borrar(id);

        }
    }
}
