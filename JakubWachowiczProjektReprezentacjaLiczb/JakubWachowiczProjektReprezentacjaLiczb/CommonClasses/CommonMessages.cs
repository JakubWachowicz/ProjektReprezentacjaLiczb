using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb.CommonClasses
{
    class CommonMessages
    {

        public static void ShowInstructions()
        {
            Console.WriteLine("Aby zamienić liczbę dziesiętną na system binarny naciśnij: 1");
            Console.WriteLine("Aby zamienić liczbę binarną na postać dziesiętną: 2");
            Console.WriteLine("Aby wyjść: 9");
        }
        public static void CodingMethods()
        {
            Console.WriteLine("Wybierz sposób kodowania");
            Console.WriteLine("NKB: 1");
            Console.WriteLine("U2: 2");
            Console.WriteLine("IEE747 (32 bity): 3");
        }
    }
}
