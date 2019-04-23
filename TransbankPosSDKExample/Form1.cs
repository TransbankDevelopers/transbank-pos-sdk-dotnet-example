using System;
using System.Windows.Forms;
using Transbank.POS;
using Transbank.POS.Utils;
using Transbank.POS.Responses;
using System.Collections.Generic;

namespace TransbankPosSDKExample
{
    public partial class Form1 : Form
    {
        private string portName = "";
        private int total = 0;
        private List<Product> buyItems;

        public Form1()
        {
            CenterToScreen();
            InitializeComponent();

            portName_lbl.Text = portName;
            port_ddown.DataSource = Serial.ListPorts();
            portName = port_ddown.SelectedItem.ToString();
            total_price_lbl.Text = total.ToString();
            buyItems = new List<Product>();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = port_ddown.SelectedItem.ToString();
        }

        private void PollingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (POS.Instance.Polling())
            {
                MessageBox.Show("POS is connected.", "Polling the POS");
            }
            else
            {
                MessageBox.Show("POS is NOT connected.", "Polling the POS");
            }
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            POS.Instance.OpenPort(portName, TbkBaudrate.TBK_115200);
            portName_lbl.Text = portName;
        }

        private void Disconnect_btn_Click(object sender, EventArgs e)
        {
            POS.Instance.ClosePort();
            portName_lbl.Text = "";
        }

        private void LoadKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
             LoadKeysResponse rsp = POS.Instance.LoadKeys();
            if (rsp.Success)
            {
                MessageBox.Show("Commerce Code \t: " + rsp.CommerceCode + "\n" +
                                "Terminal Id \t: " + rsp.TerminalId + "\n" +
                                "Result \t\t: " + rsp.ResponseMessage + "\n", "Keys Loaded Successfully.");
            }
        }

        private void RegisterCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterCloseResponse response = POS.Instance.RegisterClose();
            if (response.Success)
            {
                MessageBox.Show("Commerce Code \t: " + response.CommerceCode + "\n" +
                                "Terminal Id \t: " + response.TerminalId + "\n" +
                                "Result \t\t: " + response.ResponseMessage + "\n", "Keys Loaded Successfully.");
            }
        }

        private void SetNormalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Setting Normal Mode will disconect the POS\n Are You sure?", "Set Normal Mode", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                POS.Instance.SetNormalMode();
                Disconnect_btn_Click(sender, e);
            }
        }

        private void Cofee_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Café",
                Price = 3000
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Juice_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Jugo",
                Price = 2500
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Cookies_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Galletas",
                Price = 1000
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Icecream_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Helado",
                Price = 2150
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Pizza",
                Price = 8650
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Donut_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Dona",
                Price = 1500
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Burger_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Hamburguesa",
                Price = 9860
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Salad_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Ensalada",
                Price = 8674
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Fries_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = "Papas fritas",
                Price = 3600
            };

            ListViewItem item = new ListViewItem(p.Row)
            {
                Tag = p
            };
            CarroCompraList.Items.Add(item);

            total += p.Price;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void CarroCompraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection remove = CarroCompraList.SelectedItems;

            foreach (ListViewItem item in remove)
            {
                total -= ((Product)item.Tag).Price;
                CarroCompraList.Items.Remove(item);

                total_price_lbl.Text = total.ToString();
                total_price_lbl.Refresh();
            }
        }

        private void Clean_btn_Click(object sender, EventArgs e)
        {
            CarroCompraList.Items.Clear();
            total = 0;
            total_price_lbl.Text = total.ToString();
            total_price_lbl.Refresh();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            if (total > 0 && CarroCompraList.Items.Count > 0)
            {
                int ticket = new Random().Next(1, 999999);
                SaleResponse response = POS.Instance.Sale(total, ticket);

                if (response.Success)
                {
                    MessageBox.Show(response.ToString());
                    Clean_btn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error Procesando el Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No hay elementos para cobrar o el total es 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
