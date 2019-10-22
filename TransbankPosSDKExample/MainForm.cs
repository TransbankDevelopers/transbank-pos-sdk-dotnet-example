using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Transbank.POS;
using Transbank.POS.Exceptions;
using Transbank.POS.Utils;
using Transbank.POS.Responses;

namespace TransbankPosSDKExample
{
    public partial class MainForm : Form
    {
        private string portName = "";
        private int total = 0;
        private readonly List<Product> internalItems = new List<Product>()
        {
            new Product { Name = "Café", Price = 1500},
            new Product { Name = "Jugo", Price = 2500},
            new Product { Name = "Galletas", Price = 1000},
            new Product { Name = "Helado", Price = 2150},
            new Product { Name = "Donut", Price = 1500},
            new Product { Name = "Pizza", Price = 8650},
            new Product { Name = "Ensalada", Price = 8674},
            new Product { Name = "Hamburguesa", Price = 9860},
            new Product { Name = "Papitas", Price = 3600}
        };

        public List<Product> BuyItems { get; }

        public MainForm()
        {
            CenterToScreen();
            InitializeComponent();

            PortName_lbl.Text = portName;
            Port_ddown.DataSource = Serial.ListPorts();
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
                if (POS.Instance.Poll())
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
                POS.Instance.OpenPort(portName);
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
                POS.Instance.ClosePort();
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
                LoadKeysResponse response = POS.Instance.LoadKeys();
                if (response.Success)
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
                CloseResponse response = POS.Instance.Close();
                if (response.Success)
                {
                    MessageBox.Show(response.ToString(), "Keys Loaded Successfully.");
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
                    POS.Instance.SetNormalMode();
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
                    int ticket = new Random().Next(1, 999999);
                    SaleResponse response = POS.Instance.Sale(total, ticket);

                   MessageBox.Show(response.ToString());
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
                TotalsResponse response = POS.Instance.Totals();
                if (response.Success)
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
                LastSaleResponse response = POS.Instance.LastSale();
                if (response.Success)
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

        private void Btn_onepay_Click(object sender, EventArgs e)
        {
            try
            {
                if (total > 0 && ShopingList_lst.Items.Count > 0)
                {
                    OnepayForm qr = new OnepayForm(total);
                    qr.Show();
                    qr.Focus();
                    Clean_btn_Click(sender,e);
                }
                else
                {
                    MessageBox.Show("No hay elementos para cobrar o el total es 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show("Error Procesando el Pago " + a.Message);
            }
        }
    }
}
