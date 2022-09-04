using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb
{
    class U2ToDec
    {
        public int Convert(string bin)
        {
            int retval = 0;
            for (int i = 1; i <= bin.Length; i++) if (bin[^i].ToString() == "1") if (i != bin.Length) retval += (int)Math.Pow(2, i - 1); else retval -= (int)Math.Pow(2, i - 1);

            return retval;
        }
    }
}
