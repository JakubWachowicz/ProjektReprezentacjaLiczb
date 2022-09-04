using JakubWachowiczProjektReprezentacjaLiczb.CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWachowiczProjektReprezentacjaLiczb
{
    class ConverterApp
    {
        public ConverterApp()
        {
            Start();
        }

        private void Start()
        {
            String userCmd = "";
            while (userCmd != "done")
            {
                try
                {

                    CommonMessages.ShowInstructions();
                    userCmd = Console.ReadLine();
                    switch (userCmd)
                    {
                        case "1":
                            DecToBinConvertAction.StartConvert();
                            break;
                        case "2":
                            BitToDecConvertAction.StartConvert();
                            break;
                        case "9":
                            userCmd = "done";
                            break;


                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("w aplikacji wystąpił błąd");
                }
            }
            
        }
    }
}
