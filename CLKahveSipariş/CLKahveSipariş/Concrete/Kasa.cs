using CLKahveSipariş.Contracts;
using CLKahveSipariş.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Concrete
{
    internal class Kasa : IKasa
    {
        public ISiparis İslemeAlinanSiparis { get; set; }

        public event SiparisHaberTipi SiparisiAldim;
        public event HaberTipi Musaitim;      

        public void Islem()
        {
            SiparisiAldim(İslemeAlinanSiparis);
            Musaitim(this);
        }
      
    }
}
