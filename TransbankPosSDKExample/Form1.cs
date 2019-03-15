using System;
using System.Windows.Forms;
using Transbank.POS;
using Transbank.POS.Utils;
namespace TransbankPosSDKExample
{
    public partial class Form1 : Form
    {
        private string portName = "";
        private int total = 0;
        private POS pos;

        public Form1()
        {
            CenterToScreen();
            InitializeComponent();

            portName_lbl.Text = portName;
            port_ddown.DataSource = Serial.ListPorts();
            portName = port_ddown.SelectedItem.ToString();
            total_price_lbl.Text = total.ToString();

            pos = new POS();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = port_ddown.SelectedItem.ToString();
        }

        private void pollingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pos.Polling())
            {
                MessageBox.Show("POS is connected.", "Polling the POS");
            }
            else
            {
                MessageBox.Show("POS is NOT connected.", "Polling the POS");
            }
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            pos.OpenPort(portName, TbkBaudrate.TBK_115200);
            portName_lbl.Text = portName;
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            TransbankWrap.close_port();
            portName_lbl.Text = "";
        }
    }
}
