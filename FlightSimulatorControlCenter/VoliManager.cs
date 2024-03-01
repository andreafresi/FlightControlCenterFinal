using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Volo;
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
    public partial class VoliManager : Form
    {
        AggiungiVoli aggiungiVoliForm;
        RicercaVoli ricercaVoliForm;
        CancellaVoli cancellaVoliForm;
        ModificaVoli modificaVoliForm;

        private IValidationUserInputService _validationService;
        private IExternalServicesService _externalService;
        private IConversionModelService _conversionService;
        public VoliManager(IValidationUserInputService validationService, IExternalServicesService externalService, IConversionModelService conversionService)
        {
            InitializeComponent();
            _validationService = validationService;
            _externalService = externalService;
            _conversionService = conversionService;

        }

        private void button1_Click(object sender, EventArgs e)//Bottone Aggiungi
        {
            if (!FormUtils.FormIsOpen("AggiungiVoli"))
            {
                aggiungiVoliForm = new AggiungiVoli();
                aggiungiVoliForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)//Bottone Ricerca
        {
            if (!FormUtils.FormIsOpen("RicercaVoli"))
            {
                ricercaVoliForm = new RicercaVoli();
                ricercaVoliForm.Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("CancellaVoli"))
            {
                cancellaVoliForm = new CancellaVoli();
                cancellaVoliForm.Show();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("ModificaVoli"))
            {
                modificaVoliForm = new ModificaVoli();
                modificaVoliForm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void InitalizeAereiDataGridFromDBModel()
        {
            var result = new BindingList<VoloBl>();

            foreach (var a in flottaAttiva.Aerei)
            {
                result.Add(a);
            }

            var source = new BindingSource(result, null);

            // Binding data source
            tabellaAerei.DataSource = source;

            // Fit colonne a size tabella
            tabellaAerei.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaAerei.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Cambio label tabella
            tabellaAerei.Columns[0].HeaderText = "Id Aereo";
            tabellaAerei.Columns[0].Name = "IdAereo";

            tabellaAerei.Columns[1].HeaderText = "Cod Aereo";
            tabellaAerei.Columns[1].Name = "Codice";

            tabellaAerei.Columns[2].HeaderText = "Colore";
            tabellaAerei.Columns[2].Name = "Colore";

            tabellaAerei.Columns[3].HeaderText = "Num. Posti";
            tabellaAerei.Columns[3].Name = "NumeroDiPosti";
        }
    }
}
