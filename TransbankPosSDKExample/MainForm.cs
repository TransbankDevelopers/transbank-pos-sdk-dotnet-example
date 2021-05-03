using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Transbank.POSIntegrado;
using Transbank.Exceptions.CommonExceptions;
using Transbank.Exceptions.IntegradoExceptions;
using Transbank.Responses.CommonResponses;
using Transbank.Responses.IntegradoResponses;
using System.Threading.Tasks;

namespace TransbankPosSDKExample
{
    public partial class MainForm : Form
    {
        private string portName = "";
        private int total = 0;
        private readonly List<Product> internalItems = new List<Product>()
        {
            new Product { Name = "Café", Price = 50},
            new Product { Name = "Jugo", Price = 100},
            new Product { Name = "Galletas", Price = 10},
            new Product { Name = "Helado", Price = 1000},
            new Product { Name = "Donut", Price = 2000},
            new Product { Name = "Pizza", Price = 3000},
            new Product { Name = "Ensalada", Price = 1},
            new Product { Name = "Hamburguesa", Price = 2},
            new Product { Name = "Papitas", Price = 3}
        };

        public List<Product> BuyItems { get; }

        public MainForm()
        {
            CenterToScreen();
            InitializeComponent();

            PortName_lbl.Text = portName;
            Port_ddown.DataSource = POSIntegrado.Instance.ListPorts();
            portName = Port_ddown.SelectedItem.ToString();
            Price_lbl.Text = total.ToString();
            BuyItems = new List<Product>();
        }

        private void PortDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = Port_ddown.SelectedItem.ToString();
        }

        private void PollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Task<bool> pollResult = POSIntegrado.Instance.Poll();
                pollResult.Wait();

                if (pollResult.Result)
                {
                    MessageBox.Show("POS is connected.", "Polling the POS");
                }
                else
                {
                    MessageBox.Show("POS is NOT connected.", "Polling the POS");
                }
            } catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                POSIntegrado.Instance.OpenPort(portName);
                PortName_lbl.Text = portName;
            } catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Disconnect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                POSIntegrado.Instance.ClosePort();
                PortName_lbl.Text = "";
            } catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Task<LoadKeysResponse> response = POSIntegrado.Instance.LoadKeys();
                response.Wait();

                if (response.Result.Success)
                {
                    MessageBox.Show(response.ToString(), "Keys Loaded Successfully.");
                }
            } catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                Task<CloseResponse> response = POSIntegrado.Instance.Close();
                response.Wait();

                if (response.Result.Success)
                {
                    MessageBox.Show(response.ToString(), "Register Closed Successfully.");
                }
            }
            catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetNormalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Setting Normal Mode will disconect the POS\n Are You sure?", "Set Normal Mode", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    POSIntegrado.Instance.SetNormalMode();
                    Disconnect_btn_Click(sender, e);
                }
            } catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddItemToShoppingCart(Product product)
        {
            ListViewItem item = new ListViewItem(product.Row)
            {
                Tag = product
            };
            ShopingList_lst.Items.Add(item);

            total += product.Price;
            Price_lbl.Text = total.ToString();
            Price_lbl.Refresh();
        }

        private void Cofee_Click(object sender, EventArgs e)
        {
            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Café"));
        }

        private void Juice_Click(object sender, EventArgs e)
        {

            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Jugo"));
        }

        private void Cookies_Click(object sender, EventArgs e)
        {
            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Galletas"));
        }

        private void Icecream_Click(object sender, EventArgs e)
        {
            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Helado"));
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Pizza"));
        }

        private void Donut_Click(object sender, EventArgs e)
        {
            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Donut"));
        }

        private void Burger_Click(object sender, EventArgs e)
        {
            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Hamburguesa"));
        }

        private void Salad_Click(object sender, EventArgs e)
        {
            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Ensalada"));
        }

        private void Fries_Click(object sender, EventArgs e)
        {
            AddItemToShoppingCart(internalItems.Find(product => product.Name == "Papitas"));
        }

        private void CarroCompraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection remove = ShopingList_lst.SelectedItems;

            foreach (ListViewItem item in remove)
            {
                total -= ((Product)item.Tag).Price;
                ShopingList_lst.Items.Remove(item);

                Price_lbl.Text = total.ToString();
                Price_lbl.Refresh();
            }
        }

        private void Clean_btn_Click(object sender, EventArgs e)
        {
            ShopingList_lst.Items.Clear();
            total = 0;
            Price_lbl.Text = total.ToString();
            Price_lbl.Refresh();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            try{
                if (total > 0 && ShopingList_lst.Items.Count > 0)
                {
                   string ticket = new Random().Next(0, 999999).ToString("D6");
                   Task<SaleResponse> response = POSIntegrado.Instance.Sale(total, ticket);
                    response.Wait();

                   MessageBox.Show(response.Result.ToString());
                   Clean_btn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No hay elementos para cobrar o el total es 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (TransbankSaleException a)
            {
                MessageBox.Show("Error Procesando el Pago" + "\n" +
                        a.SaleResponse.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TransbankException a)
            {
                MessageBox.Show(a.Message + "\n" + a.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getTotalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Task<TotalsResponse> response = POSIntegrado.Instance.Totals();
                response.Wait();

                if (response.Result.Success)
                {
                    MessageBox.Show(response.ToString(), "Totals obtained Successfully.");
                }
            }
            catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lastSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Task<LastSaleResponse> response = POSIntegrado.Instance.LastSale();
                response.Wait();

                if (response.Result.Success)
                {
                    MessageBox.Show(response.ToString(), "Last Sale obtained Successfully.");
                }
            }
            catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form p = new RefundPrompt();
            p.Show();
            p.Focus();
        }

        private void salesDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form p = new DetailPrompt();
            p.Show();
            p.Focus();
        }
    }
}
