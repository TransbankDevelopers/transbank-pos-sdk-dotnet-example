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
    public partial class DetailPrompt : Form
    {
        public DetailPrompt()
        {
            InitializeComponent();
        }

        private void DetailPrompt_Load(object sender, EventArgs e)
        {

        }

        private void printToPOS_Click(object sender, EventArgs e)
        {
            try
            {
                var details = POS.Instance.Details(0);
                MessageBox.Show("Impreso en POS", "Resultado Detalle de venta.");
                this.Close();
            }
            catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void noPrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string response = "";
                var details = POS.Instance.Details(1);
                foreach (Transbank.POS.Responses.DetailResponse detail in details)
                {
                    response += "Tipo de Tarjeta : " + detail.CardType + " Total : " + detail.Amount + "\n";
                }
                MessageBox.Show(response, "Resultado Detalle de venta.");
                this.Close();
            }
            catch (TransbankException a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
