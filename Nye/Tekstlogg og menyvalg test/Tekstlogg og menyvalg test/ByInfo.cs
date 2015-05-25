using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstlogg_og_menyvalg_test
{
    class ByInfo
    {
        public string ByNavn {get; set;}

        public int ByPosX { get; set; }

        public int ByPosY { get; set; }

        public int PeaceOfferingVerdi { get; set; }

        public int PlyndringVerdi { get; set; }

        public ByInfo (string byNavn, int byPosX, int byPosY, int peaceOfferingVerdi, int plyndringsVerdi)
        {
            ByNavn = byNavn;
            ByPosX = byPosX;
            ByPosY = byPosY;
            PeaceOfferingVerdi = peaceOfferingVerdi;
            PlyndringVerdi = plyndringsVerdi;
        }
    }
}
