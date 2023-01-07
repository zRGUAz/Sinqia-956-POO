using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    public class TV
    {
        public int Canal { get; set; }
        public int Volume { get; set; }
        public bool Ligada { get; set; }

        TV(int canal, int volume, bool ligada)
        {
            Canal = canal;
            Volume = volume;
            Ligada = ligada;
        }

        public void Liga() { }

        public void Desliga() { }

        public void MudaDeCanal() { }

        public void AumentaVolume() { }

        public void DiminuiVolume() { }
    }
}
