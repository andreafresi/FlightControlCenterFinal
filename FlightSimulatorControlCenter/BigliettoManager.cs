using FlightSimulatorControlCenter.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulatorControlCenter
{
    public partial class BigliettoManager : Form
    {
        RicercaBiglietto formRicercaBiglietto;
        public BigliettoManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // RICERCA
        {
            // Apro la form di creazione
            if (!FormUtils.FormIsOpen("RicercaBiglietto"))
            {
                formRicercaBiglietto = new RicercaBiglietto();
                //formRicercaBiglietto.FleetCreateReq += (string nomeFlotta) => {
                //    // Creo la request
                //    var req = new CreateFlottaRequest();
                //    req.Nome = nomeFlotta;

                //    // Eseguo la chiamata
                //    var flottaApi = _externalService.FlottaPOSTAsync(req);

                //    // converto il modello 
                //    var flottaBlCreata = _conversionService.ConvertToBl(flottaApi);

                //    // Mando l'evento
                //    this.FleetSelected(flottaBlCreata);

                //    // Chiudo la form
                //    formCreazioneFlotta.Close();

                //    // Richiedo l'aggiornamento della tabella
                //    RetrieveAndUpdateFleetData();
                //};
                formRicercaBiglietto.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) // RICERCA PER VOLO
        {

        }
    }
}
