using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tekstlogg_og_menyvalg_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //julian
        ByInfo[] bI = new ByInfo[11];

        //martin sin button funksjon
        #region martin
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
        #endregion

        //Sander sin button fuksjon
        private void Antall_Button(int a)
        {
            buttonNW.Visible = false;
            buttonNE.Visible = false;
            buttonSW.Visible = false;
            buttonSE.Visible = false;

            switch (a)
            {
                case 2:
                    {
                        buttonNW.Visible = true;
                        buttonNE.Visible = true;
                        break;
                    }
                case 3:
                    {
                        buttonNW.Visible = true;
                        buttonNE.Visible = true;
                        buttonSW.Visible = true;
                        break;
                    }
                case 4:
                    {
                        buttonNW.Visible = true;
                        buttonNE.Visible = true;
                        buttonSW.Visible = true;
                        buttonSE.Visible = true;
                        break;
                    }
            }
        }
        private void Dialog_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Dialog(b.Text, label2.Text);
        }

        private void Dialog(string buttonPressed, string labelText)
        {
            string[] Dialog = new string[7];
            var m = new Sander();
            Dialog = m.Dialogg(buttonPressed, labelText);
            label2.Text = Dialog[0];
            buttonNW.Text = Dialog[1];
            buttonNE.Text = Dialog[2];
            buttonSW.Text = Dialog[3];
            buttonSE.Text = Dialog[4];
            Antall_Button(Convert.ToInt16(Dialog[6]));
            switch (Dialog[5])
            {
                case "Avslutt":
                    {
                        DialogResult dialogResult = MessageBox.Show("Vil du Avslutte?","Eventyret tar slutt", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        break;
                    }
                case "Reise":
                    {

                        break;
                    }
            }
        }

        #region Julian
        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(Properties.Resources.ByInfo);
            try
            {
                using (StreamReader sr = File.OpenText(Properties.Resources.ByInfo))
                {
                    string s = "";
                    int i = 0;
                    while (((s = sr.ReadLine()) != null))
                    {
                        string[] info = s.Split(';');
                        bI[i].ByNavn = info[0];
                        bI[i].ByPosX = Convert.ToInt16(info[1]);
                        bI[i].ByPosY = Convert.ToInt16(info[2]);
                        bI[i].PeaceOfferingVerdi = Convert.ToInt16(info[3]);
                        bI[i].PlyndringVerdi = Convert.ToInt16(info[4]);
                        i++;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        #endregion


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
        ////knappen for å bytte bakgrunn
        //private void btBy_Click(object sender, EventArgs e)
        //{
        //    bytteBakgrunn();
        //}
    }
}
