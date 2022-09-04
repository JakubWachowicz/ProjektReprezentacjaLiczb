using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb.Converters
{
    public class IEE75432BitToDec:BinToDec
    {
        
        public IEE75432BitToDec(string bin)
        {
            this.bin = bin;
           if(bin == "01111111100000000000000000000000")
            {
                Console.WriteLine("Nieskończoność");
            }
            if (bin.Substring(0,8) == "011111111" && bin.Substring(9,23) != "00000000000000000000000")
            {
                Console.WriteLine("NaN");
            }
        }
        public decimal Calculate()
        {
         
            string sign = bin[0].ToString();
            string exponent = bin.Substring(1,8).ToString();
            string mantysa = bin.Substring(9, 23);
            int exponentInt = Convert(exponent) - 127;
            decimal mantysaDecimal = MantysaConvert(mantysa);
            decimal retVal =(decimal)Math.Pow(-1, int.Parse(sign)) * (1+mantysaDecimal) * (decimal)Math.Pow(2,exponentInt);
            return retVal;
        }
        private decimal MantysaConvert(string mantysa)
        {
            float retval = 0;
            

            for (int i = 0; i < mantysa.Length; i++)
            {
                if (mantysa[i].ToString() == "1")
                {
                    retval +=(float) Math.Pow(2, -(i + 1));
                }
            }
         
            return (decimal) retval;
            
        }
    }
}
