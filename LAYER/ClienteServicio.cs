using DATA;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYER
{
    public class ClienteServicio
    {
        ClienteDatos eData = new ClienteDatos();
        public void SetCliente(CLIENTE c)
        {
            eData.SetCliente(c);
        }
        public List<REGISTRARC> ValidarC(Validar validar)
        {
            return eData.ValidarC(validar);
        }
        public List<REGISTRARC> ValidarC2(Validar validar)
        {
            return eData.ValidarC2(validar);
        }

        public List<CLIENTE> Leer()
        {
            return eData.Leer();
        }
        public CLIENTE Busca(int id)
        {
            return eData.Buscar(id);

        }
        public void Actualizar(CLIENTE c)
        {

            eData.Actualizar(c);
        }
        public void Borrar(int id)
        {
            eData.Borrar(id);

        }
    }
}
