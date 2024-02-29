using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Contracts
{
    public interface ISiparis
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int HazirlamaSuresi { get; set; }
    }
}
