using CLKahveSipariş.Contracts;
using CLKahveSipariş.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Entities
{
    internal class Calisan : ICalisan
    {
        public int CalisanId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public CalismaYeri CalismaYeri { get; set; }
        public CalismaDurumu Durumu { get; set; }


        public event HaberTipi Bostayim;
        public event HaberTipi Calisiyorum;
    }
}
