using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Event
{
    public class BigliettoEventArgs : EventArgs {
        public string? Codice { get; set; }
        public BigliettoEventArgs(string? codice)
        {
            Codice = codice;
        }
    }
    public delegate void RicercaBigliettoEvent(long bigliettoId);
    public delegate void RicercaPerVoloBigliettoEvent(long voloId);
    public delegate void BigliettoAggiorna();
    //public delegate void CancellaBigliettoEvent(long bigliettoId);





}
