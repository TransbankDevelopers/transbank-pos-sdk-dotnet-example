namespace TransbankPosSDKExample
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Cofee_img = new System.Windows.Forms.PictureBox();
            this.Juice_img = new System.Windows.Forms.PictureBox();
            this.Cookies_img = new System.Windows.Forms.PictureBox();
            this.Icecream_img = new System.Windows.Forms.PictureBox();
            this.Pizza_img = new System.Windows.Forms.PictureBox();
            this.Donut_img = new System.Windows.Forms.PictureBox();
            this.Burger_img = new System.Windows.Forms.PictureBox();
            this.Salad_img = new System.Windows.Forms.PictureBox();
            this.Fries_img = new System.Windows.Forms.PictureBox();
            this.Port_ddown = new System.Windows.Forms.ComboBox();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConnectedPort_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.PortName_lbl = new System.Windows.Forms.Label();
            this.ShopingList_lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNormalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Disconnect_btn = new System.Windows.Forms.Button();
            this.ShopingList_lst = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShopingListLeyend_lbl = new System.Windows.Forms.Label();
            this.Pay_btn = new System.Windows.Forms.Button();
            this.Clean_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cofee_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Juice_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookies_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icecream_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pizza_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Donut_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Burger_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salad_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fries_img)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // Cofee_img
            //
            this.Cofee_img.Image = ((System.Drawing.Image)(resources.GetObject("Cofee_img.Image")));
            this.Cofee_img.Location = new System.Drawing.Point(6, 6);
            this.Cofee_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Cofee_img.MaximumSize = new System.Drawing.Size(284, 181);
            this.Cofee_img.MinimumSize = new System.Drawing.Size(284, 181);
            this.Cofee_img.Name = "Cofee_img";
            this.Cofee_img.Size = new System.Drawing.Size(284, 181);
            this.Cofee_img.TabIndex = 0;
            this.Cofee_img.TabStop = false;
            this.Cofee_img.Click += new System.EventHandler(this.Cofee_Click);
            //
            // Juice_img
            //
            this.Juice_img.Image = ((System.Drawing.Image)(resources.GetObject("Juice_img.Image")));
            this.Juice_img.Location = new System.Drawing.Point(302, 6);
            this.Juice_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Juice_img.Name = "Juice_img";
            this.Juice_img.Size = new System.Drawing.Size(284, 181);
            this.Juice_img.TabIndex = 1;
            this.Juice_img.TabStop = false;
            this.Juice_img.Click += new System.EventHandler(this.Juice_Click);
            //
            // Cookies_img
            //
            this.Cookies_img.Image = ((System.Drawing.Image)(resources.GetObject("Cookies_img.Image")));
            this.Cookies_img.Location = new System.Drawing.Point(598, 6);
            this.Cookies_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Cookies_img.Name = "Cookies_img";
            this.Cookies_img.Size = new System.Drawing.Size(284, 181);
            this.Cookies_img.TabIndex = 2;
            this.Cookies_img.TabStop = false;
            this.Cookies_img.Click += new System.EventHandler(this.Cookies_Click);
            //
            // Icecream_img
            //
            this.Icecream_img.Image = ((System.Drawing.Image)(resources.GetObject("Icecream_img.Image")));
            this.Icecream_img.Location = new System.Drawing.Point(6, 199);
            this.Icecream_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Icecream_img.Name = "Icecream_img";
            this.Icecream_img.Size = new System.Drawing.Size(284, 181);
            this.Icecream_img.TabIndex = 3;
            this.Icecream_img.TabStop = false;
            this.Icecream_img.Click += new System.EventHandler(this.Icecream_Click);
            //
            // Pizza_img
            //
            this.Pizza_img.Image = ((System.Drawing.Image)(resources.GetObject("Pizza_img.Image")));
            this.Pizza_img.Location = new System.Drawing.Point(302, 199);
            this.Pizza_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pizza_img.Name = "Pizza_img";
            this.Pizza_img.Size = new System.Drawing.Size(284, 181);
            this.Pizza_img.TabIndex = 4;
            this.Pizza_img.TabStop = false;
            this.Pizza_img.Click += new System.EventHandler(this.Pizza_Click);
            //
            // Donut_img
            //
            this.Donut_img.Image = ((System.Drawing.Image)(resources.GetObject("Donut_img.Image")));
            this.Donut_img.Location = new System.Drawing.Point(598, 199);
            this.Donut_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Donut_img.Name = "Donut_img";
            this.Donut_img.Size = new System.Drawing.Size(284, 181);
            this.Donut_img.TabIndex = 5;
            this.Donut_img.TabStop = false;
            this.Donut_img.Click += new System.EventHandler(this.Donut_Click);
            //
            // Burger_img
            //
            this.Burger_img.Image = ((System.Drawing.Image)(resources.GetObject("Burger_img.Image")));
            this.Burger_img.Location = new System.Drawing.Point(6, 392);
            this.Burger_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Burger_img.Name = "Burger_img";
            this.Burger_img.Size = new System.Drawing.Size(284, 181);
            this.Burger_img.TabIndex = 6;
            this.Burger_img.TabStop = false;
            this.Burger_img.Click += new System.EventHandler(this.Burger_Click);
            //
            // Salad_img
            //
            this.Salad_img.Image = ((System.Drawing.Image)(resources.GetObject("Salad_img.Image")));
            this.Salad_img.Location = new System.Drawing.Point(302, 392);
            this.Salad_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Salad_img.Name = "Salad_img";
            this.Salad_img.Size = new System.Drawing.Size(284, 181);
            this.Salad_img.TabIndex = 7;
            this.Salad_img.TabStop = false;
            this.Salad_img.Click += new System.EventHandler(this.Salad_Click);
            //
            // Fries_img
            //
            this.Fries_img.Image = ((System.Drawing.Image)(resources.GetObject("Fries_img.Image")));
            this.Fries_img.Location = new System.Drawing.Point(598, 392);
            this.Fries_img.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Fries_img.Name = "Fries_img";
            this.Fries_img.Size = new System.Drawing.Size(284, 181);
            this.Fries_img.TabIndex = 8;
            this.Fries_img.TabStop = false;
            this.Fries_img.Click += new System.EventHandler(this.Fries_Click);
            //
            // Port_ddown
            //
            this.Port_ddown.FormattingEnabled = true;
            this.Port_ddown.Items.AddRange(new object[] {
            "COM4"});
            this.Port_ddown.Location = new System.Drawing.Point(72, 69);
            this.Port_ddown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Port_ddown.Name = "Port_ddown";
            this.Port_ddown.Size = new System.Drawing.Size(198, 33);
            this.Port_ddown.TabIndex = 9;
            this.Port_ddown.SelectedIndexChanged += new System.EventHandler(this.PortDropDown_SelectedIndexChanged);
            //
            // Connect_btn
            //
            this.Connect_btn.Location = new System.Drawing.Point(286, 65);
            this.Connect_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(150, 44);
            this.Connect_btn.TabIndex = 10;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            //
            // flowLayoutPanel1
            //
            this.flowLayoutPanel1.Controls.Add(this.Cofee_img);
            this.flowLayoutPanel1.Controls.Add(this.Juice_img);
            this.flowLayoutPanel1.Controls.Add(this.Cookies_img);
            this.flowLayoutPanel1.Controls.Add(this.Icecream_img);
            this.flowLayoutPanel1.Controls.Add(this.Pizza_img);
            this.flowLayoutPanel1.Controls.Add(this.Donut_img);
            this.flowLayoutPanel1.Controls.Add(this.Burger_img);
            this.flowLayoutPanel1.Controls.Add(this.Salad_img);
            this.flowLayoutPanel1.Controls.Add(this.Fries_img);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 210);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(890, 581);
            this.flowLayoutPanel1.TabIndex = 11;
            //
            // ConnectedPort_lbl
            //
            this.ConnectedPort_lbl.AutoSize = true;
            this.ConnectedPort_lbl.Location = new System.Drawing.Point(66, 115);
            this.ConnectedPort_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ConnectedPort_lbl.Name = "ConnectedPort_lbl";
            this.ConnectedPort_lbl.Size = new System.Drawing.Size(167, 25);
            this.ConnectedPort_lbl.TabIndex = 12;
            this.ConnectedPort_lbl.Text = "Connected Port:";
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Price_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Total_lbl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(958, 637);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 75);
            this.tableLayoutPanel1.TabIndex = 13;
            //
            // Price_lbl
            //
            this.Price_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.Location = new System.Drawing.Point(221, 22);
            this.Price_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(29, 31);
            this.Price_lbl.TabIndex = 16;
            this.Price_lbl.Text = "0";
            this.Price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Total_lbl
            //
            this.Total_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lbl.Location = new System.Drawing.Point(7, 14);
            this.Total_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(142, 46);
            this.Total_lbl.TabIndex = 2;
            this.Total_lbl.Text = "Total $";
            this.Total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // PortName_lbl
            //
            this.PortName_lbl.AutoSize = true;
            this.PortName_lbl.Location = new System.Drawing.Point(280, 115);
            this.PortName_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PortName_lbl.Name = "PortName_lbl";
            this.PortName_lbl.Size = new System.Drawing.Size(60, 25);
            this.PortName_lbl.TabIndex = 14;
            this.PortName_lbl.Text = "none";
            //
            // ShopingList_lbl
            //
            this.ShopingList_lbl.AutoSize = true;
            this.ShopingList_lbl.Location = new System.Drawing.Point(952, 65);
            this.ShopingList_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ShopingList_lbl.Name = "ShopingList_lbl";
            this.ShopingList_lbl.Size = new System.Drawing.Size(180, 25);
            this.ShopingList_lbl.TabIndex = 16;
            this.ShopingList_lbl.Text = "Lista de Compras";
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1296, 44);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            //
            // connectionToolStripMenuItem
            //
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pollToolStripMenuItem,
            this.loadKeysToolStripMenuItem,
            this.registerCloseToolStripMenuItem,
            this.setNormalModeToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.connectionToolStripMenuItem.Text = "POS";
            //
            // pollToolStripMenuItem
            //
            this.pollToolStripMenuItem.Name = "pollToolStripMenuItem";
            this.pollToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.pollToolStripMenuItem.Text = "Check Connection";
            this.pollToolStripMenuItem.Click += new System.EventHandler(this.PollToolStripMenuItem_Click);
            //
            // loadKeysToolStripMenuItem
            //
            this.loadKeysToolStripMenuItem.Name = "loadKeysToolStripMenuItem";
            this.loadKeysToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.loadKeysToolStripMenuItem.Text = "Load Keys";
            this.loadKeysToolStripMenuItem.Click += new System.EventHandler(this.LoadKeysToolStripMenuItem_Click);
            //
            // registerCloseToolStripMenuItem
            //
            this.registerCloseToolStripMenuItem.Name = "registerCloseToolStripMenuItem";
            this.registerCloseToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.registerCloseToolStripMenuItem.Text = "Register Close";
            this.registerCloseToolStripMenuItem.Click += new System.EventHandler(this.RegisterCloseToolStripMenuItem_Click);
            //
            // setNormalModeToolStripMenuItem
            //
            this.setNormalModeToolStripMenuItem.Name = "setNormalModeToolStripMenuItem";
            this.setNormalModeToolStripMenuItem.Size = new System.Drawing.Size(309, 38);
            this.setNormalModeToolStripMenuItem.Text = "Set Normal Mode";
            this.setNormalModeToolStripMenuItem.Click += new System.EventHandler(this.SetNormalModeToolStripMenuItem_Click);
            //
            // Disconnect_btn
            //
            this.Disconnect_btn.Location = new System.Drawing.Point(448, 65);
            this.Disconnect_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Disconnect_btn.Name = "Disconnect_btn";
            this.Disconnect_btn.Size = new System.Drawing.Size(150, 44);
            this.Disconnect_btn.TabIndex = 18;
            this.Disconnect_btn.Text = "Disconnect";
            this.Disconnect_btn.UseVisualStyleBackColor = true;
            this.Disconnect_btn.Click += new System.EventHandler(this.Disconnect_btn_Click);
            //
            // ShopingList_lst
            //
            this.ShopingList_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.precio});
            this.ShopingList_lst.FullRowSelect = true;
            this.ShopingList_lst.GridLines = true;
            this.ShopingList_lst.Location = new System.Drawing.Point(958, 146);
            this.ShopingList_lst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ShopingList_lst.Name = "ShopingList_lst";
            this.ShopingList_lst.Size = new System.Drawing.Size(310, 475);
            this.ShopingList_lst.TabIndex = 19;
            this.ShopingList_lst.UseCompatibleStateImageBehavior = false;
            this.ShopingList_lst.View = System.Windows.Forms.View.Details;
            this.ShopingList_lst.SelectedIndexChanged += new System.EventHandler(this.CarroCompraList_SelectedIndexChanged);
            //
            // Item
            //
            this.Item.Text = "Item";
            this.Item.Width = 74;
            //
            // precio
            //
            this.precio.Text = "Valor";
            //
            // ShopingListLeyend_lbl
            //
            this.ShopingListLeyend_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.ShopingListLeyend_lbl.Location = new System.Drawing.Point(954, 90);
            this.ShopingListLeyend_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ShopingListLeyend_lbl.Name = "ShopingListLeyend_lbl";
            this.ShopingListLeyend_lbl.Size = new System.Drawing.Size(312, 50);
            this.ShopingListLeyend_lbl.TabIndex = 20;
            this.ShopingListLeyend_lbl.Text = "* Haga click en un elemento de la lista para eliminarlo";
            //
            // Pay_btn
            //
            this.Pay_btn.Location = new System.Drawing.Point(1132, 737);
            this.Pay_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pay_btn.Name = "Pay_btn";
            this.Pay_btn.Size = new System.Drawing.Size(134, 54);
            this.Pay_btn.TabIndex = 21;
            this.Pay_btn.Text = "Pagar";
            this.Pay_btn.UseVisualStyleBackColor = true;
            this.Pay_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            //
            // Clean_btn
            //
            this.Clean_btn.Location = new System.Drawing.Point(958, 737);
            this.Clean_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Clean_btn.Name = "Clean_btn";
            this.Clean_btn.Size = new System.Drawing.Size(134, 54);
            this.Clean_btn.TabIndex = 22;
            this.Clean_btn.Text = "Limpiar Carro";
            this.Clean_btn.UseVisualStyleBackColor = true;
            this.Clean_btn.Click += new System.EventHandler(this.Clean_btn_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 810);
            this.Controls.Add(this.Clean_btn);
            this.Controls.Add(this.Pay_btn);
            this.Controls.Add(this.ShopingListLeyend_lbl);
            this.Controls.Add(this.ShopingList_lst);
            this.Controls.Add(this.Disconnect_btn);
            this.Controls.Add(this.ShopingList_lbl);
            this.Controls.Add(this.PortName_lbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ConnectedPort_lbl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.Port_ddown);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Cofee_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Juice_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookies_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icecream_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pizza_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Donut_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Burger_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salad_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fries_img)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Cofee_img;
        private System.Windows.Forms.PictureBox Juice_img;
        private System.Windows.Forms.PictureBox Cookies_img;
        private System.Windows.Forms.PictureBox Icecream_img;
        private System.Windows.Forms.PictureBox Pizza_img;
        private System.Windows.Forms.PictureBox Donut_img;
        private System.Windows.Forms.PictureBox Burger_img;
        private System.Windows.Forms.PictureBox Salad_img;
        private System.Windows.Forms.PictureBox Fries_img;

        private System.Windows.Forms.ComboBox Port_ddown;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Button Disconnect_btn;
        private System.Windows.Forms.Label ConnectedPort_lbl;
        private System.Windows.Forms.Label PortName_lbl;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ShopingList_lbl;

        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label Total_lbl;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNormalModeToolStripMenuItem;
        private System.Windows.Forms.ListView ShopingList_lst;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.Label ShopingListLeyend_lbl;
        private System.Windows.Forms.Button Pay_btn;
        private System.Windows.Forms.Button Clean_btn;
    }
}

