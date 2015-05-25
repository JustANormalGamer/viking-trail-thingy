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
        //ludvig
        //bool upb = false;
        //bool downb = false;
        //bool rightb = false;
        //bool leftb = false;
        //int liv = 50;
        //int nedtelling = 45;
        //int pengerMax = 420;
        //int PengerHar = 0;

        public Form1()
        {
            InitializeComponent();
            //KeyDown += new KeyEventHandler(Form1_KeyDown);
            //KeyUp += new KeyEventHandler(Form1_KeyUp);
            //timer1.Start();
            //CountDown.Start();
            //timer2.Start();
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
                case 1:
                    {
                        buttonNW.Visible = true;
                        break;
                    }
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
                        DialogResult dialogResult = MessageBox.Show("Vil du Avslutte?", "Eventyret tar slutt", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        break;
                    }
                case "Reise":
                    {
                        kartpos("Lindesfarne");
                        CurrentBy = 1;
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Plyndre, Lindefarne":
                    {
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Peace, Lindefarne":
                    {
                        CurrentGold = ma.GoldAdd(CurrentGold,0, 0, bI[CurrentBy].PeaceOfferingVerdi);
                        pengerLabel.Text = Convert.ToString(CurrentGold);
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Reise, N, Lindefarne":
                    {
                        kartpos("Edinburgh");
                        CurrentBy = 3;
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Reise, S, Lindefarne":
                    {
                        kartpos("York");
                        CurrentBy = 2;
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Plyndre, York":
                    {
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Peace, York":
                    {
                        CurrentGold = ma.GoldAdd(CurrentGold, 0, 0, bI[CurrentBy].PeaceOfferingVerdi);
                        pengerLabel.Text = Convert.ToString(CurrentGold);
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Plyndre, Edinburgh":
                    {
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Peace, Edinburgh":
                    {
                        CurrentGold = ma.GoldAdd(CurrentGold, 0, 0, bI[CurrentBy].PeaceOfferingVerdi);
                        pengerLabel.Text = Convert.ToString(CurrentGold);
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Reise, N, Edinburgh":
                    {
                        kartpos("Aberdeen");
                        CurrentBy = 6;
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Reise, S, Edinburgh":
                    {
                        kartpos("Skegness");
                        CurrentBy = 7;
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Plyndre, Aberdeen":
                    {
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Peace, Aberdeen":
                    {
                        CurrentGold = ma.GoldAdd(CurrentGold, 0, 0, bI[CurrentBy].PeaceOfferingVerdi);
                        pengerLabel.Text = Convert.ToString(CurrentGold);
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Plyndre, Skegness":
                    {
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Peace, Skegness":
                    {
                        CurrentGold = ma.GoldAdd(CurrentGold, 0, 0, bI[CurrentBy].PeaceOfferingVerdi);
                        pengerLabel.Text = Convert.ToString(CurrentGold);
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Reise, N, Skegness":
                    {
                        kartpos("Shetland");
                        CurrentBy = 4;
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Reise, S, Skegness":
                    {
                        kartpos("London");
                        CurrentBy = 8;
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Plyndre, Shetland":
                    {
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Peace, Shetland":
                    {
                        CurrentGold = ma.GoldAdd(CurrentGold, 0, 0, bI[CurrentBy].PeaceOfferingVerdi);
                        pengerLabel.Text = Convert.ToString(CurrentGold);
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Plyndre, London":
                    {
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Peace, London":
                    {
                        CurrentGold = ma.GoldAdd(CurrentGold, 0, 0, bI[CurrentBy].PeaceOfferingVerdi);
                        pengerLabel.Text = Convert.ToString(CurrentGold);
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Reise, Paris":
                    {
                        kartpos("Paris");
                        CurrentBy = 9;
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        break;
                    }
                case "Plyndre, Paris":
                    {
                        pb_Reise.Visible = true;
                        pictureBox3.Visible = false;
                        timer1.Start();
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        MessageBox.Show("Du har vunnet! din score er" + Convert.ToString(CurrentGold));
                        break;
                    }
                case "Peace, Paris":
                    {
                        CurrentGold = ma.GoldAdd(CurrentGold, 0, 0, bI[CurrentBy].PeaceOfferingVerdi);
                        pengerLabel.Text = Convert.ToString(CurrentGold);
                        leggTilDag();
                        tidLabel.Text = Convert.ToString(tid[0]);
                        MessageBox.Show("Du har vunnet! din score er" + Convert.ToString(CurrentGold));
                        break;
                    }
                case "Slutt":
                    {
                        DialogResult dialogResult = MessageBox.Show("Vil du Avslutte?", "Eventyret tar slutt", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
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
            bI[0] = new ByInfo("Bergen", 866, 190, 0, 0);
            bI[1] = new ByInfo("Lindesfarne", 781, 249, 40, 150);
            bI[2] = new ByInfo("York", 776, 272, 30, 130);
            bI[3] = new ByInfo("Edinburgh", 772, 238, 35, 140);
            bI[4] = new ByInfo("Shetland", 813, 162, 20, 90);
            bI[5] = new ByInfo("Orkenøyene", 803, 182, 25, 100);
            bI[6] = new ByInfo("Aberdeen", 783, 229, 40, 130);
            bI[7] = new ByInfo("Skegness", 788, 302, 40, 140);
            bI[8] = new ByInfo("London", 773, 340, 50, 200);
            bI[9] = new ByInfo("Paris", 791, 393, 70, 250);
            bI[10] = new ByInfo("Amsterdam", 834, 333, 60, 230);
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
            if (under == 1)
            {
                pb_Reise.Visible = false;
                pictureBox3.Visible = true;
                timer1.Stop();
                under = 0;
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

        //Ludvig sine funksjoner
        #region Ludvig

        //     //  PictureBox[] p = new PictureBox[20];

        // private void Form1_KeyDown(object sender, KeyEventArgs e)
        // {


        //     if (e.KeyCode == Keys.Right) rightb = true;
        //     if (e.KeyCode == Keys.Left) leftb = true;
        //     if (e.KeyCode == Keys.Up) upb = true;
        //     if (e.KeyCode == Keys.Down) downb = true;


        // }

        // private void Form1_KeyUp(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Right) rightb = false;
        //     if (e.KeyCode == Keys.Left) leftb = false;
        //     if (e.KeyCode == Keys.Up) upb = false;
        //     if (e.KeyCode == Keys.Down) downb = false;
        // }

        // private void timer1_Tick(object sender, EventArgs e)
        // {
        //     int x = pictureBox1.Location.X;
        //     int y = pictureBox1.Location.Y;



        //     if (upb == true) y -= 1;
        //     else if (downb == true) y += 1;
        //     else if (rightb == true) x += 1;
        //     else if (leftb == true) x -= 1;
        //     pictureBox1.Location = new Point(x, y);
        //     kollisjonTest(x, y);
        //     kiste();

        // }

        // private void kollisjonTest(int x, int y)
        // {


        //     if (pictureBox1.Bounds.IntersectsWith(pB1.Bounds))
        //   {
        //       if (upb == true)
        //           y += 1;
        //       else if (downb == true)
        //           y -= 1;
        //       else if (leftb == true)
        //           x += 1;
        //       else if (rightb == true)
        //           x -= 1;
        //   }

        //     else if (pictureBox1.Bounds.IntersectsWith(pB2.Bounds))
        //     {
        //         if (upb == true)
        //             y += 1;
        //         else if (downb == true)
        //             y -= 1;
        //         else if (leftb == true)
        //             x += 1;
        //         else if (rightb == true)
        //             x -= 1;
        //     }
        //     else if (pictureBox1.Bounds.IntersectsWith(pB3.Bounds))
        //     {
        //         if (upb == true)
        //             y += 1;
        //         else if (downb == true)
        //             y -= 1;
        //         else if (leftb == true)
        //             x += 1;
        //         else if (rightb == true)
        //             x -= 1;
        //     }

        //     else if (pictureBox1.Bounds.IntersectsWith(pB4.Bounds))
        //     {
        //         if (upb == true)
        //             y += 1;
        //         else if (downb == true)
        //             y -= 1;
        //         else if (leftb == true)
        //             x += 1;
        //         else if (rightb == true)
        //             x -= 1;
        //     }

        //     else if (pictureBox1.Bounds.IntersectsWith(pB5.Bounds))
        //     {
        //         if (upb == true)
        //             y += 1;
        //         else if (downb == true)
        //             y -= 1;
        //         else if (leftb == true)
        //             x += 1;
        //         else if (rightb == true)
        //             x -= 1;
        //     }

        //     else if (pictureBox1.Bounds.IntersectsWith(pB6.Bounds))
        //     {
        //         if (upb == true)
        //             y += 1;
        //         else if (downb == true)
        //             y -= 1;
        //         else if (leftb == true)
        //             x += 1;
        //         else if (rightb == true)
        //             x -= 1;
        //     }
        //     else if (pictureBox1.Bounds.IntersectsWith(pictureBoxL1.Bounds))
        //     {
        //         liv -= 1;
        //     }
        //     else if (pictureBox1.Bounds.IntersectsWith(pictureBoxL2.Bounds))
        //     {
        //         liv -= 1;
        //     }
        //     else if (pictureBox1.Bounds.IntersectsWith(pictureBoxR1.Bounds))
        //     {
        //         liv -= 1;
        //     }
        //     else if (pictureBox1.Bounds.IntersectsWith(pictureBoxR2.Bounds))
        //     {
        //         liv -= 1;
        //     }



        //     lbLiv.Text = Convert.ToString(liv);
        //     pictureBox1.Location = new Point(x, y);

        // }

        //       private void kiste()
        // {
        //     if (pictureBox1.Bounds.IntersectsWith(pBKiste.Bounds))
        //     {
        //         Random rnd = new Random();
        //         int spawn = rnd.Next(1, 9);

        //       if (spawn == 1)
        //       {
        //           pBKiste.Location = new Point(101, 117);
        //       }
        //       else if (spawn == 2)
        //       {
        //           pBKiste.Location = new Point(427, 117);

        //       }
        //       else if (spawn == 3)
        //       {
        //           pBKiste.Location = new Point(427, 236);
        //       }
        //       else if (spawn == 4)
        //       {
        //           pBKiste.Location = new Point( 101, 236);
        //       }
        //       else if (spawn == 5)
        //       {
        //           pBKiste.Location = new Point(101, 348);
        //       }

        //       else if (spawn == 6)
        //       {
        //           pBKiste.Location = new Point(427, 348);
        //       }
        //       else if (spawn == 7)
        //       {
        //           pBKiste.Location = new Point(101, 0);
        //       }
        //       else if (spawn == 8)
        //       {
        //           pBKiste.Location = new Point(427, 0);
        //       }
        //       else if (spawn == 9)
        //       {
        //           pBKiste.Location = new Point(259, 173);
        //       }
        //       PengerHar += pengerMax / 10;
        //       lBpenger.Text = Convert.ToString(PengerHar);
        //     }

        // }

        // //private void Form1_Load(object sender, EventArgs e)
        // //{
        // //    int x = 50;
        // //    int y = 50;
        // //    for (int i = 0; i < 25; i++)
        // //    {
        // //        p[i] = new PictureBox();
        // //        p[i].Location = new Point(x, y);
        // //        p[i].Size = new Size(100, 50);
        // //        p[i].BackColor = Color.Red;
        // //        p[i].Name = Convert.ToString(i);
        // //        this.Controls.Add(p[i]);
        // //    }
        // //}

        // private void pB1_Click(object sender, EventArgs e)
        // {

        // }

        // private void CountDown_Tick(object sender, EventArgs e)
        // {
        //     nedtelling -= 1;
        //     label1.Text = Convert.ToString(nedtelling);
        //     if (nedtelling == 0)
        //     {
        //         timer1.Stop();
        //         CountDown.Stop();
        //         upb = false;
        //         downb = false;
        //         rightb = false;
        //         leftb = false;
        //         MessageBox.Show("tid over");  
        //     }
        //     else if (liv <1)
        //     {
        //         timer1.Stop();
        //         CountDown.Stop();
        //         upb = false;
        //         downb = false;
        //         rightb = false;
        //         leftb = false;
        //         MessageBox.Show("Du døde"); 
        //     }
        // }

        // private void label1_Click(object sender, EventArgs e)
        // {

        // }


        //// pilene

        // private async void timer2_Tick(object sender, EventArgs e)
        // {
        //     Random rnd = new Random();
        //     int y = rnd.Next(2, 372); // generer et tilfeldig tall mellom 2 and 372
        //     int yh = rnd.Next(2, 372);
        //     int yv = rnd.Next(2, 372);
        //     int yh2 = rnd.Next(2, 372);

        //     int x = pictureBoxL1.Location.X;
        //     int xh = pictureBoxR1.Location.X;
        //     int xv = pictureBoxL2.Location.X;
        //     int xh2 = pictureBoxR2.Location.X;


        //     y = pictureBoxL1.Location.Y;
        //     x += 5; 

        //     yh = pictureBoxR1.Location.Y;
        //     xh -= 5;

        //     yv = pictureBoxL2.Location.Y;
        //     xv += 5;

        //     yh2 = pictureBoxR2.Location.Y;
        //     xh2 -= 5;
        //                               // farten til pilene


        //     pictureBoxL1.Location = new Point(x, y);
        //     pictureBoxR1.Location = new Point(xh, yh);
        //     pictureBoxL2.Location = new Point(xv, yv);
        //     pictureBoxR2.Location = new Point(xh2, yh2);


        //     if (x == 492) 
        //     {
        //         y = rnd.Next(2, 372);
        //         yv = rnd.Next(2, 372);
        //         pictureBoxL1.Location = new Point(2, y);
        //         pictureBoxL2.Location = new Point(2, yv);

        //     }

        //     if (xh == 2)
        //     {
        //         //await Task.Delay(200);
        //         yh = rnd.Next(2, 372);
        //         yh2 = rnd.Next(2, 372);
        //         pictureBoxR1.Location = new Point(492, yh);
        //         pictureBoxR2.Location = new Point(492, yh2);

        //     }

        // }

        // private void Form1_Load(object sender, EventArgs e)
        // {

        // }
        //       
        #endregion
    }
}
