using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb
{
    public class BinToDec
    {

        protected string bin;
        public int result;
        
        public int Convert(string bin)
        {
            int retval = 0;
            for(int i = 1; i<=bin.Length;i++)if(bin[^i].ToString() == "1")retval +=(int)Math.Pow(2,i-1);

            return retval;
        }
        
    }
}
