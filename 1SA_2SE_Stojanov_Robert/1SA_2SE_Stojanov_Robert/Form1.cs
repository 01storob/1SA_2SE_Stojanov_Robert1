using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1SA_2SE_Stojanov_Robert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_autoerstellen_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel2.Enabled = true;
            txtb_tanken.Enabled = true;
            txtb_Fahren.Enabled = true;
            btn_Fahren.Enabled = true;
            btn_tanken.Enabled = true;

            Informationen.Text += "Marke: "+txtb_Marke.Text +"\n";
            Informationen.Text += "Farbe: " + comboBox1.Text + "\n";
            Informationen.Text += "PS: " + txtb_Marke.Text + "\n";
            Informationen.Text += "Tank: " + txtb_Marke.Text + "\n";
            Informationen.Text += "Verbrauch: " + txtb_Marke.Text + "\n";
        }

        private void btn_tanken_Click(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(txtb_tanken);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            txtb_tanken.Enabled = false;
            txtb_Fahren.Enabled = false;
            btn_Fahren.Enabled = false;
            btn_tanken.Enabled = false;
        }
    }
}
