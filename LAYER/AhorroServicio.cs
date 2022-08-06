
using DATA;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYER
{
    public class AhorroServicio
    {
        AhorroDatos eData = new AhorroDatos();
        public void SetAhorro(AHORRO a)
        {
            eData.SetAhorro(a);
        }
        
        public List<AHORRO> Leer()
        {
            return eData.Leer();
        }
        public AHORRO Busca(int id)
        {
            return eData.Buscar(id);

        }
        public void Actualizar(AHORRO a)
        {

            eData.Actualizar(a);
        }
        public void Borrar(int id)
        {
            eData.Borrar(id);

        }
    }
}
