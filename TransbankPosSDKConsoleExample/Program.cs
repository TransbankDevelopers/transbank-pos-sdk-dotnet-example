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

            string menu = Console.ReadLine();
            int.TryParse(menu, out int selected);
            if (selected >= 0 && selected <= i) {
                portName = ports[selected];
            }
            else
            {
                return;
            }

            POS.Instance.OpenPort(portName);
            Console.WriteLine("\nSerial port opened successfully");
            Console.WriteLine("Showing Menu");
            int key = ShowMenu();
            Console.WriteLine("\n");
            bool print = false;
            do
            {
                switch (key)
                {
                    case 1:
                        if (POS.Instance.Poll())
                            Console.WriteLine("Pos Connected");
                        else
                            Console.WriteLine("Pos NOT Connected");
                            break;

                    case 2:
                        try
                        {
                            Transbank.POS.Responses.LoadKeysResponse response = POS.Instance.LoadKeys();
                            Console.WriteLine(response);
                            break;
                        }catch(Exception)
                        {
                            throw;
                        }

                    case 3:
                        try
                        {
                            Transbank.POS.Responses.CloseResponse response = POS.Instance.Close();
                            Console.WriteLine(response);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            break;
                        }

                    case 4:
                        try
                        {
                            Console.WriteLine("Select 0 to send intermediate messages or any to continue without intermediate messages:\n");
                            print = Console.ReadKey().KeyChar.Equals("0");
                            Transbank.POS.Responses.SaleResponse response = POS.Instance.Sale(2500, "101010", print);
                            Console.WriteLine(response);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            break;
                        }

                    case 5:
                        try
                        {
                            Transbank.POS.Responses.TotalsResponse response = POS.Instance.Totals();
                            Console.WriteLine(response);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            throw;
                        }

                    case 6:
                        try
                        {
                            Transbank.POS.Responses.LastSaleResponse response = POS.Instance.LastSale();
                            Console.WriteLine(response);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            throw;
                        }

                    case 7:
                        Console.WriteLine("Insert Operation ID:\n");
                        string op = Console.ReadLine();
                        try
                        {
                            Transbank.POS.Responses.RefundResponse response = POS.Instance.Refund(Convert.ToInt32(op));
                            Console.WriteLine(response);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            throw;
                        }
                        break;

                    case 8:
                        Console.WriteLine("Select 0 to print on pos or any other to get data from pos:\n");
                        print = Console.ReadKey().KeyChar.Equals("0");
                        try
                        {
                            List<Transbank.POS.Responses.DetailResponse> details = POS.Instance.Details(print);
                            foreach (Transbank.POS.Responses.DetailResponse detail in details)
                            {
                                Console.WriteLine("Tipo de Tarjeta : " + detail.CardType + " Total : " + detail.Amount);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            throw;
                        }
                        break;
                    case 9:
                        try
                        {
                            Console.WriteLine("Select 0 to send intermediate messages or any to continue without intermediate messages:\n");
                            print = Console.ReadKey().KeyChar.Equals("0");
                            Transbank.POS.Responses.MultiCodeSaleResponse response = POS.Instance.MultiCodeSale(6750, "101010", 597029414300, print);
                            Console.WriteLine(response);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            break;
                        }
                    case 10:
                        try
                        {
                            Console.WriteLine("Select 0 to get Voucher indo from POS or any to continue without voucher:\n");
                            print = Console.ReadKey().KeyChar.Equals("0");
                            Transbank.POS.Responses.MultiCodeLastSaleResponse response = POS.Instance.MultiCodeLastSale(true);
                            Console.WriteLine(response);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            break;
                        }
                    case 11:
                        Console.WriteLine("Select 0 to print on pos or any other to get data from pos:\n");
                        print = Console.ReadKey().KeyChar.Equals("0");

                        try
                        {
                            List<Transbank.POS.Responses.DetailResponse> details = POS.Instance.Details(print);
                            foreach (Transbank.POS.Responses.DetailResponse detail in details)
                            {
                                Console.WriteLine("Tipo de Tarjeta : " + detail.CardType + " Total : " + detail.Amount);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                            throw;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                key = ShowMenu();
                Console.WriteLine("\n");
                print = false;
            } while (key != 0);
        }

        public static int ShowMenu()
        {
            Console.WriteLine(
                "Seleccione un commando:\n" +
                "\t(1)\t Poll\n" +
                "\t(2)\t Load Keys\n" +
                "\t(3)\t Close\n" +
                "\t(4)\t Sample Sale\n" +
                "\t(5)\t Get Totals\n" +
                "\t(6)\t Get the Last Sale\n" +
                "\t(7)\t Refund\n" +
                "\t(8)\t Sales detail\n" +
                "\t(9)\t Multicode Sale\n" +
                "\t(10)\t Multicode LastSale\n" +
                "\t(11)\t Multicode Sale Details\n" +
                "\t(0)\t Exit\n"
                );
            int.TryParse(Console.ReadLine(), out int selected);
            return selected;
        }
    }
}
