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

        public Form1()
        {
            CenterToScreen();
            InitializeComponent();

            portName_lbl.Text = portName;
            port_ddown.DataSource = Serial.ListPorts();
            portName = port_ddown.SelectedItem.ToString();
            total_price_lbl.Text = total.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = port_ddown.SelectedItem.ToString();
        }

        private void pollingToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void connect_btn_Click(object sender, EventArgs e)
        {
            POS.Instance.OpenPort(portName, TbkBaudrate.TBK_115200);
            portName_lbl.Text = portName;
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            POS.Instance.ClosePort();
            portName_lbl.Text = "";
        }

        private void loadKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
             LoadKeysResponse rsp = POS.Instance.LoadKeys();
            if (rsp.Sucess)
            {
                MessageBox.Show("Commerce Code \t: " + rsp.CommerceCode + "\n" +
                                "Terminal Id \t: " + rsp.TerminalId + "\n" +
                                "Result \t\t: " + rsp.Result + "\n", "Keys Loaded Successfully.");
            }
        }

        private void registerCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterCloseResponse rsp = POS.Instance.RegisterClose();
            if (rsp.Sucess)
            {
                MessageBox.Show("Commerce Code \t: " + rsp.CommerceCode + "\n" +
                                "Terminal Id \t: " + rsp.TerminalId + "\n" +
                                "Result \t\t: " + rsp.Result + "\n", "Keys Loaded Successfully.");
            }
        }

        private void setNormalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Setting Normal Mode will disconect the POS\n Are You sure?", "Set Normal Mode", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                POS.Instance.SetNormalMode();
                disconnect_btn_Click(sender, e);
            }
        }
    }
}
