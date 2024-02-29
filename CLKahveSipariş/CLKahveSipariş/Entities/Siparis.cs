using CLKahveSipariş.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Entities
{
    internal class Siparis : ISiparis
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int HazirlamaSuresi { get; set; }
    }
}
