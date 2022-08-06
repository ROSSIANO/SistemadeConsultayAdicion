using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class PrestamoDatos
    {
        BANCARIOEntities db = new BANCARIOEntities();
        public void SetPrestamo(PRESTAMO p)
        {
            db.PRESTAMO.Add(p);
            db.SaveChanges();
        }

        public List<PRESTAMO> Leer()
        {
            return db.PRESTAMO.ToList();
        }
        public PRESTAMO Buscar(int id)
        {
            return db.PRESTAMO.Find(id);
        }
        public void Actualizar(PRESTAMO c)
        {
            var data = db.PRESTAMO.FirstOrDefault(a => a.ID == c.ID);
            data.MONTOA = c.MONTOA;
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Borrar(int id)
        {
            var data = db.PRESTAMO.Find(id);
            db.PRESTAMO.Remove(data);
            db.SaveChanges();
        }
    }
}
