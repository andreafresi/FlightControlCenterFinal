using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Service.Int;
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
        
        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;
        public BigliettoManager(IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;
            dataGridView1 = new DataGridView();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("ID Volo", "ID Volo");
            dataGridView1.Columns.Add("Numero Posti", "Posti");
            dataGridView1.Columns.Add("Importo", "Importo");
            dataGridView1.Columns.Add("Data Acq", "Data Acquisto");
        }
        
        RicercaBiglietto formRicercaBiglietto;
        RicercaPerVoloBiglietto formRicercaPerVoloBiglietto;
        AcquistoBiglietto formAcquistoBiglietto;
        CancellaBiglietto formCancellaBiglietto;
        private void button1_Click(object sender, EventArgs e) // RICERCA
        {
            // Apro la form di creazione
            if (!FormUtils.FormIsOpen("RicercaBiglietto"))
            {
                formRicercaBiglietto = new RicercaBiglietto();
                //formRicercaBiglietto.e += Ricerca;
                formRicercaBiglietto.Show();
            }
        }

        private void button2_Click(object sender, EventArgs i) // RICERCA PER VOLO
        {
            // Apro la form di creazione
            if (!FormUtils.FormIsOpen("RicercaPerVoloBiglietto"))
            {
                formRicercaPerVoloBiglietto = new RicercaPerVoloBiglietto();
                //formRicercaPerVoloBiglietto.i += Ricerca;
                formRicercaPerVoloBiglietto.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e) // ACQUISTA
        {
            // Apro la form di creazione
            if (!FormUtils.FormIsOpen("AcquistoBiglietto"))
            {
                formAcquistoBiglietto = new AcquistoBiglietto();
                // formAcquistoBiglietto.e += AggiornaLista;
                formAcquistoBiglietto.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e) // CANCELLA
        {
            // Apro la form di creazione
            if (!FormUtils.FormIsOpen("CancellaBiglietto"))
            {
                formCancellaBiglietto = new CancellaBiglietto();
                // formCancellaBiglietto.e += AggiornaLista;
                formCancellaBiglietto.Show();
            }
        }

        private void Ricerca(long id)
        {
            var biglietto = new {
                BigliettoId = id,
                VoloId = 1,
                NumeroPostiRichiesti = 2,
                ImportoTotale = 80,
                DataAcquisto = new DateTime(2020, 1, 1)

            };
            // Popoliamo la DataGrid
            string[] row_biglietto = {biglietto.BigliettoId.ToString(), biglietto.VoloId.ToString(), biglietto.NumeroPostiRichiesti.ToString(), biglietto.ImportoTotale.ToString(), biglietto.DataAcquisto.ToString() };
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(row_biglietto);
        }

        private void AggiornaLista() { 
        }

    }
}
