using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstlogg_og_menyvalg_test
{
    class MartinGoldClass
    {
        public int GoldAdd(int Gold,int AntallKister,int KisteVerdi, int PeaceTreaty) 
        {
            if (AntallKister == 0 && KisteVerdi == 0) 
            {
                
                return Gold += PeaceTreaty;
            }
            else if (PeaceTreaty == 0)
            {

                return Gold = +(AntallKister * KisteVerdi);
            }
            else
            {
                return 0;
            }
        }
    }
}
