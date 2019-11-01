using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace thready
{
    class KlasaWWatku
    {
        String wiadomosc;
        int min;

        public KlasaWWatku(String wiadomosc, int min)
        {
            this.wiadomosc = wiadomosc;
            this.min = min; // *60000;
        }
        public void run()
        {
            Thread.Sleep(min);
            MessageBox.Show(wiadomosc, "Wiadomość");
        }
    }
}
