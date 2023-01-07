using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class TV
    {
        public int Canal { get; set; }
        public int Volume { get; set; }
        public bool Ligada { get; set; }

        public void Liga() { }

        public void Desliga() { }

        public void MudaDeCanal() { }

        public void AumentaVolume() { }

        public void DiminuiVolume() { }
    }
}
