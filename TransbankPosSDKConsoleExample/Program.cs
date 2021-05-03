using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Transbank.POSIntegrado;
using Transbank.Responses.CommonResponses;
using Transbank.Responses.IntegradoResponses;

namespace TransbankPosSDKConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ports = POSIntegrado.Instance.ListPorts();
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

            POSIntegrado.Instance.OpenPort(portName);
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
                        Task<bool> pollResult = POSIntegrado.Instance.Poll();
                        pollResult.Wait();

                        if (pollResult.Result)
                            Console.WriteLine("Pos Connected");
                        else
                            Console.WriteLine("Pos NOT Connected");
                            break;

                    case 2:
                        try
                        {
                            Task<LoadKeysResponse> response = POSIntegrado.Instance.LoadKeys();
                            response.Wait();
                            Console.WriteLine(response.Result);
                            break;
                        }catch(Exception)
                        {
                            throw;
                        }

                    case 3:
                        try
                        {
                            Task<CloseResponse> response = POSIntegrado.Instance.Close();
                            response.Wait();
                            Console.WriteLine(response.Result);
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
                            Task<SaleResponse> response = POSIntegrado.Instance.Sale(2500, "101010", print);
                            response.Wait();
                            Console.WriteLine(response.Result);
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
                            Task<TotalsResponse> response = POSIntegrado.Instance.Totals();
                            response.Wait();
                            Console.WriteLine(response.Result);
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
                            Task<LastSaleResponse> response = POSIntegrado.Instance.LastSale();
                            response.Wait();
                            Console.WriteLine(response.Result);
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
                            Task<RefundResponse> response = POSIntegrado.Instance.Refund(Convert.ToInt32(op));
                            response.Wait();
                            Console.WriteLine(response.Result);
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
                            Task<List<DetailResponse>> details = POSIntegrado.Instance.Details(print);
                            details.Wait();
                            foreach (DetailResponse detail in details.Result)
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
                            Task<MultiCodeSaleResponse> response = POSIntegrado.Instance.MultiCodeSale(6750, "101010", 597029414300, print);
                            response.Wait();
                            Console.WriteLine(response.Result);
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
                            Task<MultiCodeLastSaleResponse> response = POSIntegrado.Instance.MultiCodeLastSale(true);
                            response.Wait();
                            Console.WriteLine(response.Result);
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
                            Task<List<DetailResponse>> details = POSIntegrado.Instance.Details(print);
                            details.Wait();
                            foreach (DetailResponse detail in details.Result)
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
