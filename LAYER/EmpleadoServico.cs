using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DATA;

namespace LAYER
{
    public class EmpleadoServico
    {
        EmpleadoDatos eData = new EmpleadoDatos();
        public void SetEmpleado(EMPLEADO e)
        {
            eData.SetEmpleado(e);
        }
        public List<REGISTRARE> ValidarE(Validar validar)
        {
            return eData.ValidarE(validar);
        }
        public List<REGISTRARE> ValidarE2(Validar validar)
        {
            return eData.ValidarE2(validar);
        }

        public List<EMPLEADO> Leer()
        {
            return eData.Leer();    
        }
       
        public EMPLEADO Busca(int id)
        {
             return eData.Buscar(id);    

        }
        public void Actualizar (EMPLEADO e)
        {

            eData.Actualizar(e);
        }
        public void GuardarFoto(EMPLEADO e)
        {

            eData.GuardarFoto(e);
        }
        public void Borrar (int id)
        {
            eData.Borrar(id);

        }

    }
}
