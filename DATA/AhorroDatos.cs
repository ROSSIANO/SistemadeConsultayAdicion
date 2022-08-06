using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DATA
{
    public class AhorroDatos
    {
        BANCARIOEntities db = new BANCARIOEntities();
        public void SetAhorro(AHORRO a)
        {
            db.AHORRO.Add(a);
            db.SaveChanges();
        }

        public List<AHORRO> Leer()
        {
            return db.AHORRO.ToList();
        }
        public AHORRO Buscar(int id)
        {
            return db.AHORRO.Find(id);
        }
        public void Actualizar(AHORRO c)
        {
            var data = db.AHORRO.FirstOrDefault(a => a.ID == c.ID);
            data.MONTO = c.MONTO;
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
