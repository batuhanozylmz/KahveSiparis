using CLKahveSipariş.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Entities
{
    internal class Urun : IUrun
    {
        public string UrunAdi { get; set; }

        int _urunStokSayisi;
        
        public int UrunStokSayisi
        {
            get
            {
                return _urunStokSayisi;
            }
            set
            {
                if ( value<=0)
                {
                    throw new Exception("Stok bitmiştir bu ürünü vermeyiz.");
                    _urunStokSayisi = value;
                }
                
            }
        }

    }
}
