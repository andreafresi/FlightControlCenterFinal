using FlightSimulatorControlCenter.Model.Event;
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
    public partial class RicercaBiglietto : Form
    {
        public event RicercaBigliettoEvent e;
        public RicercaBiglietto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var e_arg = new BigliettoEventArgs(textBox1.Text);
            //this.e(textBox1.Text);
            //this.Close();
        }
    }
}
