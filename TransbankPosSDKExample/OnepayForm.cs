using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Transbank.POS;
using Transbank.POS.Model;

namespace TransbankPosSDKExample
{
    public partial class OnepayForm : Form
    {
        public OnepayPayment Pay { get; set; }

        public OnepayForm(int total)
        {
            InitializeComponent();

            int ticket = new Random().Next(1, 999999);
            Pay = new OnepayPayment(ticket, total);

            //Subscribe to events
            Pay.OnConnect += (sender, e) => UpdateWSStatus("Web Socket Conectado");
            Pay.OnDisconnect += (sender, e) => UpdateWSStatus("Web Socket Desconectado");
            Pay.OnNewMessage += UpdateStatus;
            Pay.OnSuccessfulPayment += ProcessPaymentResult;

            //Get the QR and start the payment on Onepay
            OnepayCreateResponse response = Pay.StarPayment();

            //draw the base64 image
            byte[] imageBytes = Convert.FromBase64String(response.QrCodeAsBase64);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                img_qr.Image = Image.FromStream(ms);
            }
            txt_ott.Text = response.Ott;

            //Connect to Websocket and wait for response
            _ = Pay.WatchPayment(response);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void ProcessPaymentResult( object sender, SuccessfulPaymentEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Succesful Sale");

            //Close this form from the thread woh created it
            _ = Invoke((MethodInvoker)delegate { Close(); });
        }

        public void UpdateStatus(object sender, NewMessageEventArgs e)
        {
            //Update label in the corresponding thread
            if (lbl_status_message.InvokeRequired)
            {
                _ = lbl_status_message.BeginInvoke((MethodInvoker)delegate () {
                    lbl_status_message.Text = e.Status;
                    lbl_status_description_message.Text = e.Description;
                });
            }
            else
            {
                lbl_status_message.Text = e.Status;
                lbl_status_description_message.Text = e.Description;
            }
        }

        public void UpdateWSStatus(string message)
        {
            if (lbl_ws_status_message.InvokeRequired)
            {
                _ = lbl_ws_status_message.BeginInvoke((MethodInvoker)delegate () {
                    lbl_ws_status_message.Text = message;
                });
            }
            else
            {
                lbl_ws_status_message.Text = message;
            }

        }
    }
}
