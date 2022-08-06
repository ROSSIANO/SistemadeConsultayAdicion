using DATA;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYER
{
    public class RegistrarServicio
    {
        RegistarDatos eData = new RegistarDatos();
        public void SetRegistarC(REGISTRARC c)
        {
            eData.SetRegistarC(c);
        }
        public void SetRegistarE(REGISTRARE c)
        {
            eData.SetRegistarE(c);
        }
    }
}
