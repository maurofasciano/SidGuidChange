using SidGuidChange.Methods;
using System; 
using Microsoft.Win32;

namespace SidGuidChange
{
    class Program
    {
        static void Main(string[] args)
        {
            char tm = '\u00A9';
            Console.Clear();
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine($"|- Developed by Faggiano's Software {tm} -|");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome to SiD and GuiD Tools, writen and developed by Faggiano for Windows 10 {tm}." +
                "\nHere you can list your Ids, change them for deploy cloned OS on Active Direcory, and save to file.");
            Console.WriteLine();
            Console.WriteLine("IMPORTANT NOTICE !\nRemeber to rename your machine before config changes, so you'll have" +
                "\na complete list of Ids associated to hostnames.  --- ENJOY! ---");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue....");
            Console.ReadLine();


            while (true)
                {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("|----------------------------------------------|");
                Console.WriteLine("|---- What'u wanna do with Machine's Ids ? ----|");
                Console.WriteLine("|----------------------------------------------|");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-- SELECT OPTIONS: -- ");
                Console.WriteLine("|----------------------------------------------|");
                Console.WriteLine("|------ 1) Read SID & GUID Of your OS ---------|");
                Console.WriteLine("|------ 2) Change OS' SID  --------------------|");
                Console.WriteLine("|-------3) Change OS' GUID --------------------|");
                Console.WriteLine("|-------4) Change Both    ---------------------|");
                Console.WriteLine("|-------5) Quit Program   ---------------------|");
                Console.WriteLine("|----------------------------------------------|");

                string risposta = Console.ReadLine();
                bool rispostaUtente = int.TryParse(risposta, out int rispostaUtenteInt);

                if (rispostaUtente == false)
                {
                    Console.Clear();

                    Console.WriteLine("");
                    Console.WriteLine("|---------------------------------------|");
                    Console.WriteLine("|- Invalid Args, Integer accepted only -|");
                    Console.WriteLine("|------ Press ENTER to continue --------|");
                    Console.WriteLine("|---------------------------------------|");
                    Console.WriteLine("");
                    Console.ReadLine();

                    continue;

                }

                switch(rispostaUtenteInt)               
                {
                    case 1:
                        Functions.SidGuidRead();
                        break;

                    case 2:
                        Functions.SidChanger();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("|---------------------------------------|");
                        Console.WriteLine("|- Selected QUIT, press ENTER to Close -|");
                        Console.WriteLine("|---------------------------------------|");
                        Console.WriteLine("");
                        Console.ReadLine();
                        Environment.Exit(0);
                        return;

                    default:
                        Functions.InvalidRequest();
                        break;

                }
                

            }








        }
    }
}
