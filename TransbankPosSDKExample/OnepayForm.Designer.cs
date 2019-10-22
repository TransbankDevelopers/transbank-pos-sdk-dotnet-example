namespace TransbankPosSDKExample
{
    partial class OnepayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.img_qr = new System.Windows.Forms.PictureBox();
            this.txt_ott = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_ott = new System.Windows.Forms.Label();
            this.lbl_status_message = new System.Windows.Forms.Label();
            this.lbl_ws_status = new System.Windows.Forms.Label();
            this.lbl_ws_status_message = new System.Windows.Forms.Label();
            this.lbl_status_description = new System.Windows.Forms.Label();
            this.lbl_status_description_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // img_qr
            // 
            this.img_qr.Location = new System.Drawing.Point(128, 15);
            this.img_qr.Margin = new System.Windows.Forms.Padding(6);
            this.img_qr.Name = "img_qr";
            this.img_qr.Size = new System.Drawing.Size(452, 452);
            this.img_qr.TabIndex = 0;
            this.img_qr.TabStop = false;
            // 
            // txt_ott
            // 
            this.txt_ott.BackColor = this.BackColor;
            this.txt_ott.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ott.Location = new System.Drawing.Point(270, 483);
            this.txt_ott.Name = "txt_ott";
            this.txt_ott.ReadOnly = true;
            this.txt_ott.Size = new System.Drawing.Size(176, 24);
            this.txt_ott.TabIndex = 1;
            this.txt_ott.TabStop = false;
            this.txt_ott.Text = "OTT";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(167, 527);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(79, 25);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Status:";
            // 
            // lbl_ott
            // 
            this.lbl_ott.AutoSize = true;
            this.lbl_ott.Location = new System.Drawing.Point(186, 483);
            this.lbl_ott.Name = "lbl_ott";
            this.lbl_ott.Size = new System.Drawing.Size(60, 25);
            this.lbl_ott.TabIndex = 3;
            this.lbl_ott.Text = "OTT:";
            // 
            // lbl_status_message
            // 
            this.lbl_status_message.AutoSize = true;
            this.lbl_status_message.Location = new System.Drawing.Point(265, 527);
            this.lbl_status_message.Name = "lbl_status_message";
            this.lbl_status_message.Size = new System.Drawing.Size(147, 25);
            this.lbl_status_message.TabIndex = 4;
            this.lbl_status_message.Text = "Payment Start";
            // 
            // lbl_ws_status
            // 
            this.lbl_ws_status.AutoSize = true;
            this.lbl_ws_status.Location = new System.Drawing.Point(51, 614);
            this.lbl_ws_status.Name = "lbl_ws_status";
            this.lbl_ws_status.Size = new System.Drawing.Size(195, 25);
            this.lbl_ws_status.TabIndex = 5;
            this.lbl_ws_status.Text = "WebSocket Status:";
            // 
            // lbl_ws_status_message
            // 
            this.lbl_ws_status_message.AutoSize = true;
            this.lbl_ws_status_message.Location = new System.Drawing.Point(265, 614);
            this.lbl_ws_status_message.Name = "lbl_ws_status_message";
            this.lbl_ws_status_message.Size = new System.Drawing.Size(86, 25);
            this.lbl_ws_status_message.TabIndex = 6;
            this.lbl_ws_status_message.Text = "Starting";
            // 
            // lbl_status_description
            // 
            this.lbl_status_description.AutoSize = true;
            this.lbl_status_description.Location = new System.Drawing.Point(120, 568);
            this.lbl_status_description.Name = "lbl_status_description";
            this.lbl_status_description.Size = new System.Drawing.Size(126, 25);
            this.lbl_status_description.TabIndex = 7;
            this.lbl_status_description.Text = "Description:";
            // 
            // lbl_status_description_message
            // 
            this.lbl_status_description_message.AutoSize = true;
            this.lbl_status_description_message.Location = new System.Drawing.Point(265, 568);
            this.lbl_status_description_message.Name = "lbl_status_description_message";
            this.lbl_status_description_message.Size = new System.Drawing.Size(240, 50);
            this.lbl_status_description_message.TabIndex = 8;
            this.lbl_status_description_message.Text = "Description";
            // 
            // OnepayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 686);
            this.Controls.Add(this.lbl_status_description_message);
            this.Controls.Add(this.lbl_status_description);
            this.Controls.Add(this.lbl_ws_status_message);
            this.Controls.Add(this.lbl_ws_status);
            this.Controls.Add(this.lbl_status_message);
            this.Controls.Add(this.lbl_ott);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.txt_ott);
            this.Controls.Add(this.img_qr);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OnepayForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_qr;
        private System.Windows.Forms.TextBox txt_ott;
        private System.Windows.Forms.Label lbl_status_message;
        private System.Windows.Forms.Label lbl_ott;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_ws_status_message;
        private System.Windows.Forms.Label lbl_ws_status;
        private System.Windows.Forms.Label lbl_status_description_message;
        private System.Windows.Forms.Label lbl_status_description;
    }
}