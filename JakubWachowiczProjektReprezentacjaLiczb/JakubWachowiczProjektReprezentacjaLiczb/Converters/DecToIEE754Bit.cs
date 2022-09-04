using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb
{
    class DecToIEE754Bit:DecToBin
    {
        
        public decimal number;
        private decimal fractionPart;
        private int intPart;
        private string intPartBin;
        private string fractionPartBin;

        public DecToIEE754Bit()
        {
            Console.WriteLine("Podaj liczbę rzeczywistą");
            this.number = decimal.Parse(Console.ReadLine());
        }



        public string Calculate()
        {
          
            string sign = bitSign.ToString();
            string mantysa = Mantysa(number);
            string exponent = Exponent();
            string retVal = sign + exponent + mantysa;
            return retVal;
        }
         string ConvertFractionPart(decimal dec,int bitLimit)
        {
            string retVal = "";
            for (int i = 0; i < bitLimit; i++)
            {
                if(dec * 2 >= 1)
                {

                    retVal += "1";
                    dec = 2*dec - 1;
                }
                else
                {
                    retVal += "0";
                    dec = dec * 2;
                }
            }
            
            return retVal;
        }

        private string Mantysa(decimal doubleNumber)
        {
            fractionPart = doubleNumber - Math.Floor(doubleNumber);
            intPart = (int)doubleNumber;
           

            intPartBin = Convert(intPart, 0);
            intPartBin = intPartBin.Remove(0, 1);
            fractionPartBin = ConvertFractionPart(fractionPart, 23 - intPartBin.Length);

            return intPartBin + fractionPartBin;

        }
        private string Exponent()
        {
            int bias =(int) Math.Pow(2, 8 - 1) - 1;
            int x = (intPartBin.Length) + bias;
            string exponent = Convert(x, 8);
            return exponent;

        }

    }
}
