using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb
{
    class DecToBin
    {


        protected int dec;
        protected int bits;
        public string result;
        public int bitSign;
      
        public virtual string Calculate(int dec, int bits)
        {
            this.bitSign = (dec >= 0) ? 0 : 1;
            this.dec = Math.Abs(dec);
            this.bits = bits;

            result = Convert(this.dec, bits);
            return result;
        }
        protected void addToMaxBits(ref string bin,int bitLimit)
        {
            while (bin.Length < bitLimit)
            {
                bin += "0";
            }
            
        }
       
        public string Convert(int dec,int bits)
        {
           

            string retVal = "";

            while (dec != 0) 
            {
                retVal += dec % 2;
                dec /= 2;
            }
            addToMaxBits(ref retVal,bits);
            return Reverse(retVal);
        }

        protected string Reverse(string retVal)
        {
            char[] charArr = retVal.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

      

        
    }
}
