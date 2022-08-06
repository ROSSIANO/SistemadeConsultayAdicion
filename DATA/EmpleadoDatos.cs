using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DATA
{
    public class EmpleadoDatos
    {
        BANCARIOEntities db = new BANCARIOEntities();
        public void SetEmpleado(EMPLEADO empledo)
        {
            db.EMPLEADO.Add(empledo);
            db.SaveChanges();
        }
        
        public List<REGISTRARE> ValidarE(Validar validar)
        {
            return db.REGISTRARE.Where(a => a.NUSUARIO == validar.NUsuario).ToList();


        }
        public List<REGISTRARE> ValidarE2(Validar validar)
        {
            return db.REGISTRARE.Where(a => a.CONTRASENA == validar.Contrasena).ToList();


        }

        public List<EMPLEADO> Leer()
        {
            return db.EMPLEADO.ToList();
        }
      
        public EMPLEADO Buscar(int id)
        {
            return db.EMPLEADO.Find(id);
        }
        public void Actualizar(EMPLEADO c)
        {
            var data = db.EMPLEADO.FirstOrDefault(a => a.ID == c.ID);
            data.NOMBRE = c.NOMBRE;
            
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
            
        }
        public void GuardarFoto(EMPLEADO c)
        {
            var data = db.EMPLEADO.FirstOrDefault(a => a.ID == c.ID);
            
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();

        }


        public void Borrar(int id)
        {
            var data = db.EMPLEADO.Find(id);
            db.EMPLEADO.Remove(data);
            db.SaveChanges();
        }


    }
}
