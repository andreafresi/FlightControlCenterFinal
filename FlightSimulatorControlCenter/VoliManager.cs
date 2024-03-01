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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
