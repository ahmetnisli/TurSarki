using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurSarki
{
    class Album
    {
        public int AlbumID { get; set; }
        public int AlbumSarkiciID { get; set; }
        public string AlbumAdi { get; set; }
        public string AlbumAciklama { get; set; }
        public override string ToString()
        {
            return AlbumAdi;
        }
    }
}
