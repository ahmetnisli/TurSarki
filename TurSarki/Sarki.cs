using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurSarki
{
    class Sarki
    {
        public int SarkiID { get; set; }
        public int AlbumID { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string SarkiAdi { get; set; }
        public string SarkiSozleri { get; set; }
        public string Besteci { get; set; }
        public string SozYazari { get; set; }
        public override string ToString()
        {
            return SarkiAdi;
        }
    }
}
