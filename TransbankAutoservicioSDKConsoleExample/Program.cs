using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Transbank.POSAutoservicio;
using Transbank.Responses.AutoservicioResponse;
using Transbank.Responses.CommonResponses;

namespace TransbankPosSDKConsoleExample
{
    class Program
    {
        const int DEFAULT_BAUDRATE = 115200;

        static void Main(string[] args)
        {
            string portName = SelectCom();
            int baudrate = DEFAULT_BAUDRATE;


            POSAutoservicio.Instance.OpenPort(portName, baudrate);
            Console.WriteLine("\nSerial port opened successfully");
            Console.WriteLine("Showing Menu");
            int key = ShowMenu();
            Console.WriteLine("\n");
            do
            {
                switch (key)
                {
                    case 1:
                        PollCommand();
                        break;
                    case 2:
                        LoadKeysCommand();
                        break;
                    case 3:
                        InitializationCommand();
                        break;
                    case 4:
                        InitializationResponseCommand();
                        break;
                    case 5:
                        SaleCommand();
                        break;
                    case 6:
                        MultiCodeSaleCommand();
                        break;
                    case 7:
                        LastSaleCommand();
                        break;
                    case 8:
                        CloseCommand();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                key = ShowMenu();
                Console.WriteLine("\n");
            } while (key != 0);
        }

        public static int ShowMenu()
        {
            Console.WriteLine(
                "Select a command:\n" +
                "\t(1)\t Poll\n" +
                "\t(2)\t Load Keys\n" +
                "\t(3)\t Initialization\n" +
                "\t(4)\t Initialization Response\n" +
                "\t(5)\t Sample Sale\n" +
                "\t(6)\t Multicode Sample Sale\n" +
                "\t(7)\t Get the Last Sale\n" +
                "\t(8)\t Close\n" +
                "\t(0)\t Exit\n"
                );
            int.TryParse(Console.ReadLine(), out int selected);
            return selected;
        }

        private static string SelectCom()
        {
            List<string> ports = POSAutoservicio.Instance.ListPorts();
            string portName = "";

            do
            {
                int i = 0;
                Console.WriteLine("Select serial port to use:");
                foreach (string port in ports)
                {
                    Console.WriteLine(i + ": " + port);
                    i++;
                }

                string menu = Console.ReadLine();
                int.TryParse(menu, out int selected);
                if (selected >= 0 && selected < ports.Count)
                {
                    portName = ports[selected];
                }
                else
                {
                    Console.WriteLine("Selected serial port is incorrect\n");
                }
            }
            while (!ports.Contains(portName));

            return portName;
        }

        private static long SelectCommerceCode()
        {
            long commerceCode = 0;

            do
            {
                Console.WriteLine(
                    "Select commerce code:\n" +
                    /*"\t(0)\t 597001600403\n" +*/
                    "\t(1)\t 597029414300\n" +
                    "\t(2)\t 597029414301\n" +
                    "\t(3)\t 597029414302\n" +
                    "\t(4)\t 597029414303\n" +
                    "\t(5)\t 597029414304\n" +
                    "\t(6)\t 597029414305\n" +
                    "\t(7)\t 597029414306\n" +
                    "\t(8)\t 597029414307\n" +
                    "\t(9)\t 597029414308"
                );

                int.TryParse(Console.ReadLine(), out int selected);

                switch (selected)
                {
                    /*case 0:
                        commerceCode = 597001600403;
                        break;*/
                    case 1:
                        commerceCode = 597029414300;
                        break;
                    case 2:
                        commerceCode = 597029414301;
                        break;
                    case 3:
                        commerceCode = 597029414302;
                        break;
                    case 4:
                        commerceCode = 597029414303;
                        break;
                    case 5:
                        commerceCode = 597029414304;
                        break;
                    case 6:
                        commerceCode = 597029414305;
                        break;
                    case 7:
                        commerceCode = 597029414306;
                        break;
                    case 8:
                        commerceCode = 597029414307;
                        break;
                    case 9:
                        commerceCode = 597029414308;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            while (commerceCode == 0);

            return commerceCode;
        }

        private static void PollCommand()
        {
            try
            {
                Task<bool> pollResult = POSAutoservicio.Instance.Poll();
                pollResult.Wait();

                if (pollResult.Result)
                    Console.WriteLine("Pos Connected");
                else
                    Console.WriteLine("Pos NOT Connected");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private static void LoadKeysCommand()
        {
            try
            {
                Task<LoadKeysResponse> loadKeyResponse = POSAutoservicio.Instance.LoadKeys();
                loadKeyResponse.Wait();
                Console.WriteLine(loadKeyResponse.Result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private static void InitializationCommand()
        {
            try
            {
                Task<bool> initializationResult = POSAutoservicio.Instance.Initialization();
                initializationResult.Wait();

                if (initializationResult.Result)
                    Console.WriteLine("Pos Initialized");
                else
                    Console.WriteLine("Pos NOT Initialized");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private static void InitializationResponseCommand()
        {
            try
            {
                Task<InitializationResponse> response = POSAutoservicio.Instance.InitializationResponse();
                response.Wait();
                Console.WriteLine(response.Result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private static void SaleCommand()
        {
            EventHandler<IntermediateResponse> intermediateResponseHandler = null;
            bool print = false;

            try
            {
                Console.WriteLine("Enter amount");
                int.TryParse(Console.ReadLine(), out int amount);
                Console.WriteLine("Enter ticket number");
                string ticket = Console.ReadLine();
                Console.WriteLine("Select 1 to send voucher in response or any to continue without voucher data:\n");
                bool voucher = Console.ReadKey().KeyChar == '1';
                Console.WriteLine();
                Console.WriteLine("Select 1 to send intermediate messages or any to continue without intermediate messages:\n");
                print = Console.ReadKey().KeyChar == '1';
                Console.WriteLine();

                intermediateResponseHandler = (sender, e) =>
                {
                    Console.WriteLine("Intermediate function code received: " + e.FunctionCode);
                    Console.WriteLine("Intermediate response code received: " + e.ResponseCode);
                    Console.WriteLine("Message received: " + e.ResponseMessage);
                };

                if (print)
                {
                    POSAutoservicio.Instance.IntermediateResponseChange += intermediateResponseHandler;
                }

                Console.WriteLine();
                Task<SaleResponse> response = POSAutoservicio.Instance.Sale(amount, ticket, voucher, print);
                response.Wait();
                Console.WriteLine(response.Result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (print && intermediateResponseHandler != null)
                {
                    POSAutoservicio.Instance.IntermediateResponseChange -= intermediateResponseHandler;
                }
            }
        }

        private static void MultiCodeSaleCommand()
        {
            EventHandler<IntermediateResponse> intermediateResponseHandler = null;
            bool print = false;

            try
            {
                Console.WriteLine("Enter amount");
                int.TryParse(Console.ReadLine(), out int amount);
                Console.WriteLine("Enter ticket number");
                string ticket = Console.ReadLine();
                long commerceCode = SelectCommerceCode();
                Console.WriteLine("Select 1 to send voucher in response or any to continue without voucher data:\n");
                bool voucher = Console.ReadKey().KeyChar == '1';
                Console.WriteLine();
                Console.WriteLine("Select 1 to send intermediate messages or any to continue without intermediate messages:\n");
                print = Console.ReadKey().KeyChar == '1';

                intermediateResponseHandler = (sender, e) =>
                {
                    Console.WriteLine("Intermediate function code received: " + e.FunctionCode);
                    Console.WriteLine("Intermediate response code received: " + e.ResponseCode);
                    Console.WriteLine("Message received: " + e.ResponseMessage);
                };

                if (print)
                {
                    POSAutoservicio.Instance.IntermediateResponseChange += intermediateResponseHandler;
                }

                Console.WriteLine();
                Task<MultiCodeSaleResponse> response = POSAutoservicio.Instance.MultiCodeSale(amount, ticket, commerceCode, voucher, print);
                response.Wait();
                Console.WriteLine(response.Result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (print && intermediateResponseHandler != null)
                {
                    POSAutoservicio.Instance.IntermediateResponseChange -= intermediateResponseHandler;
                }
            }
        }

        private static void LastSaleCommand()
        {
            try
            {
                Console.WriteLine("Select 1 to send voucher in response or any to continue without voucher data:\n");
                bool voucher = Console.ReadKey().KeyChar == '1';
                Console.WriteLine();
                Task<LastSaleResponse> response = POSAutoservicio.Instance.LastSale(voucher);
                response.Wait();
                Console.WriteLine(response.Result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private static void CloseCommand()
        {
            try
            {
                Console.WriteLine("Select 1 to send voucher in response or any to continue without voucher data:\n");
                bool voucher = Console.ReadKey().KeyChar == '1';
                Console.WriteLine();
                Task<CloseResponse> response = POSAutoservicio.Instance.Close(voucher);
                response.Wait();
                Console.WriteLine(response.Result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
