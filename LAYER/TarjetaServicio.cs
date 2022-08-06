using DATA;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYER
{
    public class TarjetaServicio
    {
        TarjetaDatos eData = new TarjetaDatos();
        public void SetTarjeta(TARJETA p)
        {
            eData.SetTarjeta(p);
        }

        public List<TARJETA> Leer()
        {
            return eData.Leer();
        }
        public TARJETA Busca(int id)
        {
            return eData.Buscar(id);

        }
        public void Actualizar(TARJETA t)
        {

            eData.Actualizar(t);
        }
        public void Borrar(int id)
        {
            eData.Borrar(id);

        }
    }
}
