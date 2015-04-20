using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstlogg_og_menyvalg_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNW_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSW_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNE_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSE_Click(object sender, EventArgs e)
        {
            
        }

        private void button_check(int a) 
        {
            // når du skal bruke denne for å velge antall knapper skriver du: button_check(); og inne i parantesen antall buttons du vil ha
            if (a == 2) 
            {
                buttonSW.Enabled = false;
                buttonSE.Enabled = false;
                buttonSW.Visible = false;
                buttonSE.Visible = false;
            }
            if (a == 3)
            {
                buttonSW.Enabled = true;
                buttonSE.Enabled = false;
                buttonSW.Visible = true;
                buttonSE.Visible = false;
            }
            if (a == 4)
            {
                buttonSW.Enabled = true;
                buttonSE.Enabled = true;
                buttonSW.Visible = true;
                buttonSE.Visible = true;
            }
            else
            {
                MessageBox.Show("feil på nummer for antall knapper");
            }
        }
    }
}
