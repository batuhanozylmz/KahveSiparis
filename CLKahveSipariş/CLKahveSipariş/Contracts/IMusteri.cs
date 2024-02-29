using CLKahveSipariş.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Contracts
{
    public interface IMusteri
    {
        event HaberTipi BenGeldim;
        public string AdiSoyadi { get; set; }

    }
}
