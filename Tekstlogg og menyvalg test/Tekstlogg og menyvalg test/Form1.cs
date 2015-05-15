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
using System.Threading;


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

        //martin sine funksjoner
        #region martin

        int CurrentGold = 0;
        int CurrentBy = 0;
        int[] tid = new int[2];

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
        private void leggTilDag()
        {
            tid[0] += 1;
            if (tid[0] == 8) 
            {
                tid[0] = 1;
                tid[1] += 1;
                tidLabel.Text = "Dag " + tid[0] + "\t";
                if (tid[1] > 0)
                {
                    tidLabel.Text += "Uke " + tid[1];
                }
            }
        }
        #endregion

        //Sander sine funksjoner
        #region Sander
        
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
            var ma = new MartinGoldClass();
            Dialog = m.Dialogg(buttonPressed, labelText);
            label2.Text = Dialog[0];
            buttonNW.Text = Dialog[1];
            buttonNE.Text = Dialog[2];
            buttonSW.Text = Dialog[3];
            buttonSE.Text = Dialog[4];
            Antall_Button(Convert.ToInt16(Dialog[6]));
            //CurrentGold = ma.GoldAdd(CurrentGold, (antall kister etter plyndring), bI[CurrentBy].PlyndringVerdi, bI[CurrentBy].PeaceOfferingVerdi);
            //pengerLabel.Text = CurrentGold;
            //leggTilDag();
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
                        kartpos("Lindesfarne");
                        pictureBox3.Visible = true;
                        break;
                    }
                case "Plyndre":
                    {
                        pb_Reise.Visible = true;
                        timer1.Start();
                        break;
                    }
            }
        }

        #endregion

        //julian sine funksjoner
        #region Julian
        private void Form1_Load(object sender, EventArgs e)
        {
            tid[0] = 1;
            tid[1] = 0;
            bI[0] = new ByInfo("Bergen",866,190,0,0);
            bI[1] = new ByInfo("Lindesfarne", 781, 249, 40, 150);
            bI[2] = new ByInfo("York",776,272,30,130);
            bI[3] = new ByInfo("Edinburgh",772,238,35,140);
            bI[4] = new ByInfo("Shetland",813,162,20,90);
            bI[5] = new ByInfo("Orkenøyene",803,182,25,100);
            bI[6] = new ByInfo("Aberdeen",783,229,40,130);
            bI[7] = new ByInfo("Skegness",788,302,40,140);
            bI[8] = new ByInfo("London",773,340,50,200);
            bI[9] = new ByInfo("Paris",791,393,70,250);
            bI[10] = new ByInfo("Amsterdam",834,333,60,230);
            pictureBox3.Visible = true;
            kartpos("Bergen");
        }
        private void kartpos(string bynavn)
        {
            for (int i = 0; i < 11; i++)
            {
                if (bI[i].ByNavn == bynavn)
                {
                    pictureBox3.Location = new Point(bI[i].ByPosX, bI[i].ByPosY);
                    CurrentBy = i;
                }
            }
        }
        #endregion

        //kunn for demo
        int under = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            under++;
            if(under == 2)
            {
                pb_Reise.Visible = false;
                timer1.Stop();
            }
        }

        

        //Inam sine funksjoner
        #region Inam
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
        #endregion

        //Eirik sine funskjoner
        #region Eirik
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
        #endregion Eirik
    }
}
