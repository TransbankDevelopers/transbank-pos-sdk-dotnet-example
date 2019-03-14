using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transbank.pos;

namespace TransbankPosSDKConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            transbank.print_ports();

            string portName = "COM4";

            int retval = transbank.select_port(portName);
            if (retval == transbank.TBK_OK)
            {
                Console.WriteLine("Open and configure port:" + transbank.get_configured_port_name());
                retval = transbank.open_configured_port();
                if (retval == transbank.TBK_OK)
                {
                    Console.WriteLine("Serial Port succesfuly opend");
                    if (transbank.configure_port() == transbank.TBK_OK)
                    {
                        Console.WriteLine("Showing Menu");
                        ConsoleKeyInfo key = ShowMenu();
                        Console.WriteLine("\n");
                        do
                        {
                            switch (key.KeyChar)
                            {
                                case '1':
                                    if (transbank.polling() == transbank.TBK_OK)
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
                }
            }
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
