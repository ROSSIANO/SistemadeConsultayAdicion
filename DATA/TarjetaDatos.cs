using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class TarjetaDatos
    {
        BANCARIOEntities db = new BANCARIOEntities();
        public void SetTarjeta(TARJETA t)
        {
            db.TARJETA.Add(t);
            db.SaveChanges();
        }

        public List<TARJETA> Leer()
        {
            return db.TARJETA.ToList();
        }
        public TARJETA Buscar(int id)
        {
            return db.TARJETA.Find(id);
        }
        public void Actualizar(TARJETA c)
        {
            var data = db.TARJETA.FirstOrDefault(a => a.ID == c.ID);
            data.SALDOD = c.SALDOD;
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Borrar(int id)
        {
            var data = db.TARJETA.Find(id);
            db.TARJETA.Remove(data);
            db.SaveChanges();
        }
    }
}
