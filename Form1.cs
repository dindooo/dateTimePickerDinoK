using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimePickerDino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            DateTime odabranDatum = dateTimePickerDatum.Value;
            DateTime odabranoVrijeme = dateTimePickerVrijeme.Value;

            string poruka1 = $"Vaš datum leta je : {odabranDatum.ToShortDateString()}.\n";
            string poruka2 = $"Vaše vrijeme polaska je : {odabranoVrijeme.ToShortTimeString()}.";

            richTextBox1.Text = poruka1 + "\n" + poruka2;


        }
    }
}
