using DATA;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAYER
{
    public class RepositorioServicio
    {
        BANCARIOEntities db = new BANCARIOEntities();
        public void BuscarCliente(Validar v)
        {
            var data = db.REGISTRARC.FirstOrDefault(a => a.NUSUARIO == v.NUsuario);

            var datos = db.CLIENTE.FirstOrDefault(a => a.ID == data.IDCLIENTE);

            Repositorio.Instacia.cliente.Add(datos);

        }
    }
    
}
