using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstlogg_og_menyvalg_test
{
    class Sander
    {
        public string[] Dialogg(string buttonPressed, string labelText)
        {
            string[] dialog = new string[7];
            //[0] = hva som skal stå i label [1]-[4] = Hva som skal stå på knappene [5] = hva som skal skje [6] = antall knapper som skal vises
            switch (buttonPressed)
            {

                case "Ja":
                    {
                        labelText += "\nPlayer: Ja\nViking: Kaptein jeg ser en by i det fjerne\nJeg tror det er Lindesfarne!";
                        dialog[0] = labelText;
                        dialog[1] = "Ta imot offer";
                        dialog[2] = "Plyndre";
                        dialog[3] = "Til sjøs";
                        dialog[5] = "Reise";
                        dialog[6] = "3";
                        break;
                    }

                case "Nei":
                    {
                        labelText += "\nPlayer: Nei";
                        dialog[0] = labelText;
                        dialog[1] = "Ja";
                        dialog[2] = "Nei";
                        dialog[5] = "Avslutt";
                        dialog[6] = "2";
                        break;
                    }
                case "Ta imot offer":
                    {
                        labelText += "\nLandsby Ordfører: Ikke angrip!!!\nPlayer: Gi oss penger så får vi se\nViking vil du gå nord eller sør?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord";
                        dialog[2] = "Sør";
                        dialog[5] = "Ta i mot offer, Lidesfarne";
                        break;
                    }
                case "Plyndre":
                    {
                        labelText += "\nPlayer: Plyndre!\nAngrip!!!!!";
                        dialog[0] = labelText;
                        dialog[1] = "Nord";
                        dialog[2] = "Sør";
                        dialog[5] = "Plyndre, Lindesfarne";
                        dialog[6] = "2";
                        break;
                    }
                case "Til sjøs":
                    {
                        labelText += "\nPlayer: Til sjøs\nVikingHvor vil du dra?\nNord eller Sør?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord";
                        dialog[2] = "Sør";
                        dialog[5] = "Reise, Lindesfarne";
                        dialog[6] = "2";
                        break;
                    }
                case "Nord":
                    {
                        labelText += "\nPlayer: Nord!\nViking: Der! jeg tror vi kan se Edinburgh!";
                        dialog[0] = labelText;
                        dialog[1] = "Dårlig valgt!";
                        dialog[2] = "Det skjønner jeg";
                        break;
                    }
            }


            return dialog;


        }
    }
}
