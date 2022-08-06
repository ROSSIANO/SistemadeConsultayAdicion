using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DATA
{
    public class ClienteDatos
    {
        BANCARIOEntities db = new BANCARIOEntities();
        public void SetCliente(CLIENTE c)
        {
            db.CLIENTE.Add(c);
            db.SaveChanges();
        }
        public List<REGISTRARC> ValidarC(Validar validar)
        {
            return db.REGISTRARC.Where(a => a.NUSUARIO == validar.NUsuario).ToList();


        }
        public List<REGISTRARC> ValidarC2(Validar validar)
        {
            return db.REGISTRARC.Where(a => a.CONTRASENA == validar.Contrasena).ToList();


        }

        public List<CLIENTE> Leer()
        {
            return db.CLIENTE.ToList();
        }
        public CLIENTE Buscar(int id)
        {
            return db.CLIENTE.Find(id);
        }
        public void Actualizar(CLIENTE c)
        {
            var data = db.CLIENTE.FirstOrDefault(a => a.ID == c.ID);
            data.NOMBRE = c.NOMBRE;
            
            data.DIRECCION = c.DIRECCION;
            data.TELEFONO = c.TELEFONO;
            data.CORREO = c.CORREO;
            data.IDESTATUS = c.IDESTATUS;
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Borrar(int id)
        {
            var data = db.CLIENTE.Find(id);
            db.CLIENTE.Remove(data);
            db.SaveChanges();
        }
    }
}
