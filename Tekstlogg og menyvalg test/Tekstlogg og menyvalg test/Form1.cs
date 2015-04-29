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
            button_check(4);
        }

        private void buttonSW_Click(object sender, EventArgs e)
        {
            button_check(2);
        }

        private void buttonNE_Click(object sender, EventArgs e)
        {
            button_check(3);
        }

        private void buttonSE_Click(object sender, EventArgs e)
        {
            button_check(1);
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
            else if (a == 3)
            {
                buttonSW.Enabled = true;
                buttonSE.Enabled = false;
                buttonSW.Visible = true;
                buttonSE.Visible = false;
            }
            else if (a == 4)
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

        private void Dialog_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Dialog(b.Text, label2.Text);
        }

        private void Dialog(string buttonPressed, string labelText)
        {
            string[] Dialog = new string[6];
            var m = new Sander();
            Dialog = m.Dialogg(buttonPressed, labelText);
            label2.Text = Dialog[0];
            buttonNW.Text = Dialog[1];
            buttonNE.Text = Dialog[2];
        }


        // funksjon for å bytte bakgrunn Forfatter: Inam
        // feks når du trykker på en by på menyvalget så skal bilde av byen dukke opp
        
        //PbBy.Visible = false;

        //public void bytteBakgrunn()
        //{
        //    if (PbBy.Visible == false)  //PbBy er da bakgrunnsbilde
        //    {
        //        PbBy.Visible = true;
        //    }
        //    else
        //    {
        //        PbBy.Visible = false;
        //    }
        //}
        // knappen for å bytte bakgrunn
        //private void btBy_Click(object sender, EventArgs e)
        //{
        //    bytteBakgrunn();
        //}
    }
}
