using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQL_Empleat.Models
{
    public class Empleat
    {
        private EmpleatContext context;
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Cognom { get; set; }
        public string Carrec { get; set; }
        public int Sou { get; set; }
    }
}
