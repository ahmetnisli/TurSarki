using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurSarki
{
    class Tur
    {
        public int TurID { get; set; }
        public string TurAdi { get; set; }
        public string TurAciklama { get; set; }

        public override string ToString()
        {
            return TurAdi;
        }
    }
}
