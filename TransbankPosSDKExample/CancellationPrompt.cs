using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Transbank.POS;
using Transbank.POS.Exceptions;
using Transbank.POS.Utils;
using Transbank.POS.Responses;

namespace TransbankPosSDKExample
{
    public partial class CancellationPrompt : Form
    {
        public CancellationPrompt()
        {
            InitializeComponent();
        }

        private void CancellationPrompt_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            int op = Convert.ToInt32(opInputText.Text);
            try
            {
                CancellResponse response = POS.Instance.Cancellation(op);
                if (response.Success)
                {
                    MessageBox.Show(response.ToString(), "Cancellation Success.");
                    this.Close();
                }
            }
            catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
