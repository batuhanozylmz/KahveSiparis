using CLKahveSipariş.Entities;
using CLKahveSipariş.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Contracts
{
    public interface ICalisan
    {
        event HaberTipi Bostayim;
        event HaberTipi Calisiyorum;
        public int CalisanId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public CalismaDurumu Durumu { get; set; }
        public CalismaYeri CalismaYeri { get; set; }
    }
}
