using System;
using System.Windows.Forms;
using Transbank.POS;
using Transbank.POS.Utils;
using Transbank.POS.Responses;

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
            pos.ClosePort();
            portName_lbl.Text = "";
        }

        private void loadKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
             LoadKeysResponse rsp = pos.LoadKeys();
            if (rsp.Sucess)
            {
                MessageBox.Show("Commerce Code \t: " + rsp.CommerceCode + "\n" +
                                "Terminal Id \t: " + rsp.TerminalId + "\n" +
                                "Result \t\t: " + rsp.Result + "\n", "Keys Loaded Successfully.");
            }
        }

        private void registerCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterCloseResponse rsp = pos.RegisterClose();
            if (rsp.Sucess)
            {
                MessageBox.Show("Commerce Code \t: " + rsp.CommerceCode + "\n" +
                                "Terminal Id \t: " + rsp.TerminalId + "\n" +
                                "Result \t\t: " + rsp.Result + "\n", "Keys Loaded Successfully.");
            }
        }
    }
}
