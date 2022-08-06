using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public sealed class Repositorio
    {
        public List<CLIENTE> cliente { get; set; } = new List<CLIENTE>();
        public static Repositorio Instacia { get; } = new Repositorio();
        private Repositorio()
        {

        }
    }
}
