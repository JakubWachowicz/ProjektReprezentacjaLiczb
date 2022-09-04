using JakubWachowiczProjektReprezentacjaLiczb.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb.CommonClasses
{
    class BitToDecConvertAction
    {
        public static void StartConvert()
        {
            string userCmd = "";
            

            CommonMessages.CodingMethods();
            userCmd = Console.ReadLine();
            string numbertoConvert = chooseBinNumber();
            switch (userCmd)
            {
                case "1":
                    BinToDec dec = new BinToDec();
                    int x = dec.Convert(numbertoConvert);
                    Console.WriteLine(x);
                    break;
                case "2":
                    U2ToDec decToU2 = new U2ToDec();
                    Console.WriteLine(decToU2.Convert(numbertoConvert)); 
                    break;
                case "3":
                    IEE75432BitToDec floatNumber = new IEE75432BitToDec(numbertoConvert);
                    Console.WriteLine(floatNumber.Calculate()); 
                    break;



            }


        }
        private static string chooseBinNumber()
        {
            Console.WriteLine("Podaj liczbę binarną");
            string retVal = Console.ReadLine();
            return retVal;
        }
       
    }
}
