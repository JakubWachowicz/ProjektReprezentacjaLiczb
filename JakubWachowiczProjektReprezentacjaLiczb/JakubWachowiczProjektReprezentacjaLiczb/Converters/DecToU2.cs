using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb
{
    class DecToU2:DecToBin
    {
        
        public override string Calculate(int dec, int bits)
        {
            this.bitSign = (dec >= 0) ? 0 : 1;
            this.dec = Math.Abs(dec);
            this.bits = bits;

            result = Convert(this.dec, bits);
           
            if (bitSign == 1)
            {
                result = ChangeToNegativeNumber(result);
            }
            return result ;
        }


        private string ChangeToNegativeNumber(string bin)
        {
            int checkForOne = 0;
            string retVal = "";
            for (int i = 1; i <= bin.Length; i++)
            {
                if (bin[^i].ToString() == "1")
                {
                    if (checkForOne == 1)
                    {
                        retVal += "0";
                        
                    }
                    else
                    {
                        retVal += "1";
                        checkForOne = 1;
                    }
                   

                }
                else
                {
                    if (checkForOne == 1)
                    {
                        retVal += "1";
                    }
                    else retVal += "0";
                }


             } 
            return Reverse(retVal);
        }
    }
}
