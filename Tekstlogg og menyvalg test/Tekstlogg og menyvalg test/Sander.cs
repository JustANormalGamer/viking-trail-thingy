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
            string[] dialog = new string[6];
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
                        dialog[5] = "Avslutt";
                        break;
                    }
                case "Handle":
                    {
                        labelText += "\nPlayer: Handle\nJulian: Ok hva da?";
                        dialog[0] = labelText;
                        dialog[1] = "Båt";
                        dialog[2] = "Horer";
                        break;
                    }
                case "Plyndre":
                    {
                        labelText += "\nPlayer: Plyndre!\nJulian: Hvordan da?\nVi har ikke lagt det inn ennå?";
                        dialog[0] = labelText;
                        dialog[1] = "Kjipt";
                        dialog[2] = "Hvem er ansvarlig?";
                        break;
                    }
                case "Over hva?":
                    {
                        labelText += "\nPlayer: Over hva?\nJulian: Programmering";
                        dialog[0] = labelText;
                        dialog[1] = "Sånn koding og shit?";
                        dialog[2] = "Lame!!";
                        break;
                    }
                case "Hvorfor det?":
                    {
                        labelText += "\nPlayer: Hvorfor det?\nJulian: Jeg er ble valgt";
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
