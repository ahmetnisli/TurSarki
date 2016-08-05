using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sarkici
    {
        public int SarkiciID { get; set; }
        public int SarkiciTurID { get; set; }
        public string SarkiciAdi { get; set; }
        public string SarkiciSoyadi { get; set; }

        public override string ToString()
        {
            return SarkiciAdi+" " +SarkiciSoyadi;
        }
    }
}