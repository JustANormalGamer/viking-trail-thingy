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
                        labelText += "\nLandsby Ordfører: Ikke angrip!!!\nPlayer: Gi oss penger så får vi se\nViking: Hvilken retning vil du dra?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord";
                        dialog[2] = "Sør";
                        dialog[5] = "Peace, Lindefarne";
                        dialog[6] = "2";
                        break;
                    }
                case "Plyndre":
                    {
                        labelText += "\nPlayer: Plyndre!\nTil Angrep!!!!!";
                        dialog[0] = labelText;
                        dialog[1] = "Nord";
                        dialog[2] = "Sør";
                        dialog[5] = "Plyndre, Lindefarne";
                        dialog[6] = "2";
                        break;
                    }
                case "Til sjøs":
                    {
                        labelText += "\nPlaye: Til sjøs\nVikingHvor vil du dra?\nNord eller Sør?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord";
                        dialog[2] = "Sør";
                        dialog[6] = "2";
                        break;
                    }
                case "Nord":
                    {
                        labelText += "\nPlayer: Nord\nViking: Jeg tror jeg ser Edinburgh!";
                        dialog[0] = labelText;
                        dialog[1] = "Ta imot offer!!";
                        dialog[2] = "Plyndre!!";
                        dialog[3] = "Til sjøs!!";
                        dialog[5] = "Reise, N, Lindefarne";
                        dialog[6] = "3";
                        break;
                    }
                case "Sør":
                    {
                        labelText += "\nPlayer: Sør\nViking: Jeg tror jeg ser York!";
                        dialog[0] = labelText;
                        dialog[1] = "Ta imot offer!";
                        dialog[2] = "Plyndre!";
                        dialog[3] = "Til sjøs!";
                        dialog[5] = "Reise, S, Lindefarne";
                        dialog[6] = "3";
                        break;
                    }

                case "Ta imot offer!":
                    {
                        labelText += "\nLandsby Ordfører: Ikke angrip!!!\nPlayer: Gi oss penger så får vi se\nViking: Hvilken retning vil du dra?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!";
                        dialog[2] = "Sør!";
                        dialog[5] = "Peace, York";
                        dialog[6] = "2";
                        break;
                    }
                case "Plyndre!":
                    {
                        labelText += "\nPlayer: Plyndre!\nTil Angrep!!!!!";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!";
                        dialog[2] = "Sør!";
                        dialog[5] = "Plyndre, York";
                        dialog[6] = "2";
                        break;
                    }
                case "Til sjøs!":
                    {
                        labelText += "\nPlaye: Til sjøs\nVikingHvor vil du dra?\nNord eller Sør?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!";
                        dialog[2] = "Sør!";
                        dialog[6] = "2";
                        break;
                    }
                    
                case "Ta imot offer!!":
                    {
                        labelText += "\nLandsby Ordfører: Ikke angrip!!!\nPlayer: Gi oss penger så får vi se\nViking: Hvilken retning vil du dra?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!";
                        dialog[2] = "Sør!";
                        dialog[5] = "Peace, Edinburgh";
                        dialog[6] = "2";
                        break;
                    }
                case "Plyndre!!":
                    {
                        labelText += "\nPlayer: Plyndre!\nTil Angrep!!!!!";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!";
                        dialog[2] = "Sør!";
                        dialog[5] = "Plyndre, Edinburgh";
                        dialog[6] = "2";
                        break;
                    }
                case "Nord!":
                    {
                        labelText += "\nPlayer: Nord\nViking: Jeg tror jeg ser Aberdeen!";
                        dialog[0] = labelText;
                        dialog[1] = "Ta imot Offer";
                        dialog[2] = "Plyndre!!!!";
                        dialog[3] = "Til Sjøs";
                        dialog[5] = "Reise, N, Edinburgh";
                        dialog[6] = "3";
                        break;
                    }
                case "Sør!":
                    {
                        labelText += "\nPlayer: Nord\nViking: Jeg tror jeg ser Skegness!";
                        dialog[0] = labelText;
                        dialog[1] = "Ta imot Offer!";
                        dialog[2] = "Plyndre!!!";
                        dialog[3] = "Til Sjøs";
                        dialog[5] = "Reise, S, Edinburgh";
                        dialog[6] = "3";
                        break;
                    }
                    
                case "Ta imot Offer":
                    {
                        labelText += "\nLandsby Ordfører: Ikke angrip!!!\nPlayer: Gi oss penger så får vi se\nViking: Hvilken retning vil du dra?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!!";
                        dialog[2] = "Sør!!";
                        dialog[5] = "Peace, Aberdeen";
                        dialog[6] = "2";
                        break;
                    }
                case "Plyndre!!!!":
                    {
                        labelText += "\nPlayer: Plyndre!\nTil Angrep!!!!!";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!!";
                        dialog[2] = "Sør!!";
                        dialog[5] = "Plyndre, Aberdeen";
                        dialog[6] = "2";
                        break;
                    }
                case "Til Sjøs":
                    {
                        labelText += "\nPlaye: Til sjøs\nVikingHvor vil du dra?\nNord eller Sør?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!!";
                        dialog[2] = "Sør!!";
                        dialog[6] = "2";
                        break;
                    }

                    
                case "Ta imot Offer!":
                    {
                        labelText += "\nLandsby Ordfører: Ikke angrip!!!\nPlayer: Gi oss penger så får vi se\nViking: Hvilken retning vil du dra?";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!!";
                        dialog[2] = "Sør!!";
                        dialog[5] = "Peace, Skegness";
                        dialog[6] = "2";
                        break;
                    }
                case "Plyndre!!!":
                    {
                        labelText += "\nPlayer: Plyndre!\nTil Angrep!!!!!";
                        dialog[0] = labelText;
                        dialog[1] = "Nord!!";
                        dialog[2] = "Sør!!";
                        dialog[5] = "Plyndre, Skegness";
                        dialog[6] = "2";
                        break;
                    }
                    
               case "Nord!!":
                    {
                        labelText += "\nPlayer: Nord\nViking: Jeg tror jeg ser Shetland!";
                        dialog[0] = labelText;
                        dialog[1] = "Ta imot Offer!!";
                        dialog[2] = "PLYNDRE";
                        dialog[3] = "Til Sjøs!";
                        dialog[5] = "Reise, N, Skegness";
                        dialog[6] = "3";
                        break;
                    }
               case "Sør!!":
                    {
                        labelText += "\nPlayer: Nord\nViking: Jeg tror jeg ser Skegness!";
                        dialog[0] = labelText;
                        dialog[1] = "Ta imot Offer!!!";
                        dialog[2] = "PLYNDRE!";
                        dialog[3] = "Til Sjøs!";
                        dialog[5] = "Reise, S, Skegness";
                        dialog[6] = "3";
                        break;
                    }
                    
               case "Ta imot Offer!!":
                    {
                        labelText += "\nLandsby Ordfører: Ikke angrip!!!\nPlayer: Gi oss penger så får vi se\nViking: Hvor vil du dra nå, Kaptein?";
                        dialog[0] = labelText;
                        dialog[1] = "Til Paris!";
                        dialog[5] = "Peace, Shetland";
                        dialog[6] = "1";
                        break;
                    }
               case "PLYNDRE":
                    {
                        labelText += "\nPlayer: Plyndre!\nTil Angrep!!!!!\nViking: Hvor vil du dra nå, Kaptein?";
                        dialog[0] = labelText;
                        dialog[1] = "Til Paris!";
                        dialog[5] = "Plyndre, Shetland";
                        dialog[6] = "1";
                        break;
                    }
               case "Til Sjøs!":
                    {
                        labelText += "\nPlaye: Til sjøs\nViking: Hvor vil du dra nå, Kaptein?";
                        dialog[0] = labelText;
                        dialog[1] = "Til Paris!";
                        dialog[6] = "1";
                        break;
                    }

               
               case "Ta imot Offer!!!":
                    {
                        labelText += "\nLandsby Ordfører: Ikke angrip!!!\nPlayer: Gi oss penger så får vi se\nViking: Hvor hen nå Kapetein?";
                        dialog[0] = labelText;
                        dialog[1] = "Til Paris!";
                        dialog[5] = "Peace, London";
                        dialog[6] = "1";
                        break;
                    }
               case "Til Paris!":
                    {
                        labelText += "\nPlayer: Til Paris og til slutten!\nViking: Ay, Ay Kaptein!";
                        dialog[0] = labelText;
                        dialog[1] = "Plyndre og vinn";
                        dialog[2] = "pensjonere deg";
                        dialog[5] = "Reise, Paris";
                        dialog[6] = "2";
                        break;
                    }
                case "Plyndre og vinn":
                    {
                        labelText += "\nPlayer: Til Angrep!!!!\nViking: ARRRRRRGGGGGG";
                        dialog[0] = labelText;
                        dialog[5] = "Plyndre, Paris";
                        dialog[6] = "4";
                        break;
                    }
                case "pensjonere deg":
                    {
                        labelText += "\nPlayer: Bygg meg et fint hus!\nViking: Som du vil kaptein";
                        dialog[0] = labelText;
                        dialog[5] = "Slutt";
                        dialog[6] = "4";
                        break;
                    }

             }
            return dialog;
        }
    }
}
