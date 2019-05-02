using System;
using System.Collections.Generic;
using Transbank.POS;
using Transbank.POS.Utils;

namespace TransbankPosSDKConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ports = Serial.ListPorts();
            string portName;

            int i = 0;
            Console.WriteLine("Select serial port to use:");
            foreach(string port in ports)
            {
                Console.WriteLine(i + ": " + port);
                i++;
            }

            ConsoleKeyInfo menu = Console.ReadKey();
            int selected = (int)char.GetNumericValue(menu.KeyChar);
            if (selected >= 0 && selected <= i) {
                portName = ports[selected];
            }
            else
            {
                return;
            }

            POS.Instance.OpenPort(portName, TbkBaudrate.TBK_115200);
            Console.WriteLine("\nSerial port opened successfully");
            Console.WriteLine("Showing Menu");
            ConsoleKeyInfo key = ShowMenu();
            Console.WriteLine("\n");
            do
            {
                switch (key.KeyChar)
                {
                    case '1':
                        if (POS.Instance.Poll())
                            Console.WriteLine("Pos Connected");
                        else
                            Console.WriteLine("Pos NOT Connected");
                            break;

                    case '2':
                        try
                        {
                            var response = POS.Instance.LoadKeys();
                            Console.WriteLine(response);
                            break;
                        }catch(Exception e)
                        {
                            throw;
                        }

                    case '3':
                        try
                        {
                            var response = POS.Instance.RegisterClose();
                            Console.WriteLine(response);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            break;
                        }

                    case '4':
                        try
                        {
                            var response = POS.Instance.Sale(2500, 1);
                            Console.WriteLine(response);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            break;
                        }

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
                "\t(1)\t Poll\n" +
                "\t(2)\t Load Keys\n" +
                "\t(3)\t Register Close\n" +
                "\t(4)\t Sample Sale\n" +
                "\t(0)\t Exit\n"
                );
            return Console.ReadKey();
        }
    }
}
