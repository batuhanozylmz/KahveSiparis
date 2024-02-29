using CLKahveSipariş.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Entities
{
    public class Envanter : IEnvanter
    {
        public int SurupMiktari { get; set; }
        public int SogukSutMiktari { get; set; }
        public int SicakSutMiktari { get; set; }
    }
}
