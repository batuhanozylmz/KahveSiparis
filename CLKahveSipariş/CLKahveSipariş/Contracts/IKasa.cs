using CLKahveSipariş.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Contracts
{
    public interface IKasa
    {
        event HaberTipi Musaitim;

        event SiparisHaberTipi SiparisiAldim;
        ISiparis İslemeAlinanSiparis { get; set; }
        
        void Islem();

    }
}
