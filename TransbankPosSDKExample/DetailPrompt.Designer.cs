namespace TransbankPosSDKExample
{
    partial class DetailPrompt
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
            this.infoDetailPrompt = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.noPrintBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoDetailPrompt
            // 
            this.infoDetailPrompt.AutoSize = true;
            this.infoDetailPrompt.Location = new System.Drawing.Point(87, 31);
            this.infoDetailPrompt.Name = "infoDetailPrompt";
            this.infoDetailPrompt.Size = new System.Drawing.Size(162, 13);
            this.infoDetailPrompt.TabIndex = 0;
            this.infoDetailPrompt.Text = "Obtener listado de transacciones";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(108, 70);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(120, 23);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Imprimir en POS";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printToPOS_Click);
            // 
            // noPrintBtn
            // 
            this.noPrintBtn.Location = new System.Drawing.Point(108, 109);
            this.noPrintBtn.Name = "noPrintBtn";
            this.noPrintBtn.Size = new System.Drawing.Size(120, 23);
            this.noPrintBtn.TabIndex = 2;
            this.noPrintBtn.Text = "No imprimir";
            this.noPrintBtn.UseVisualStyleBackColor = true;
            this.noPrintBtn.Click += new System.EventHandler(this.noPrintBtn_Click);
            // 
            // DetailPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 188);
            this.Controls.Add(this.noPrintBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.infoDetailPrompt);
            this.Name = "DetailPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Ventas";
            this.Load += new System.EventHandler(this.DetailPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoDetailPrompt;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button noPrintBtn;
    }
}