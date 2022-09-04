using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb.CommonClasses
{
    class DecToBinConvertAction
    {
        public static void StartConvert()
        {
            CommonMessages.CodingMethods();


            string userCmd = "";
            userCmd = Console.ReadLine();
            int bitsNumber;
            int numberToConvert;

            
           
            switch (userCmd)
            {
                case "1":
                    DecToBin dec = new DecToBin();
                    bitsNumber = chooseNumberOfBits();
                    numberToConvert = chooseNumber();
                    Console.WriteLine(dec.Calculate(numberToConvert, bitsNumber)); 
                    break;
                case "2":
                    DecToU2 decu2 = new DecToU2();
                    bitsNumber = chooseNumberOfBits();
                    numberToConvert = chooseNumber();
                    Console.WriteLine(decu2.Calculate(numberToConvert, bitsNumber));
                    break;
                case "3":
                    DecToIEE754Bit floatNumber = new DecToIEE754Bit();
                    Console.WriteLine(floatNumber.Calculate());
                    break;
             


            }


            
        }
        private static int chooseNumberOfBits()
        {
            Console.WriteLine("Podaj liczbę bitów");
            int retVal = int.Parse(Console.ReadLine());
            return retVal;
        }

        private static int chooseNumber()
        {
            Console.WriteLine("Podaj liczbę");
            int retVal = int.Parse(Console.ReadLine());
            return retVal;
        }
       
    }
}
