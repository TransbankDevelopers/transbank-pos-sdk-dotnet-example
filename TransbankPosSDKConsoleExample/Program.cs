using System;
using Transbank.POS;
using Transbank.POS.Utils;

namespace TransbankPosSDKConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string portName = "COM4";

            POS pos = new POS();

            pos.OpenPort(portName, TbkBaudrate.TBK_115200);
            Console.WriteLine("Serial Port succesfuly opend");
            Console.WriteLine("Showing Menu");
            ConsoleKeyInfo key = ShowMenu();
            Console.WriteLine("\n");
            do
            {
                switch (key.KeyChar)
                {
                    case '1':
                        if (pos.Polling())
                            Console.WriteLine("Pos Connected");
                        else
                            Console.WriteLine("Pos NOT Connected");
                            break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                key = ShowMenu();
                Console.WriteLine("\n");
            } while (!key.KeyChar.Equals('0'));
        }
 
        public static ConsoleKeyInfo ShowMenu()
        {
            Console.WriteLine(
                "Seleccione un commando:\n" +
                "\t(1)\t Polling\n" +
                "\t(0)\t Exit\n"
                );
            return Console.ReadKey();
        }
    }
}
