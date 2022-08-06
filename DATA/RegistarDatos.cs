using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class RegistarDatos
    {
        BANCARIOEntities db = new BANCARIOEntities();
        public void SetRegistarC(REGISTRARC c)
        {
            db.REGISTRARC.Add(c);
            db.SaveChanges();
        }
        public void SetRegistarE(REGISTRARE c)
        {
            db.REGISTRARE.Add(c);
            db.SaveChanges();
        }
    }
}
