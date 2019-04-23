namespace TransbankPosSDKExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cofee = new System.Windows.Forms.PictureBox();
            this.juice = new System.Windows.Forms.PictureBox();
            this.cookies = new System.Windows.Forms.PictureBox();
            this.icecream = new System.Windows.Forms.PictureBox();
            this.pizza = new System.Windows.Forms.PictureBox();
            this.donut = new System.Windows.Forms.PictureBox();
            this.burger = new System.Windows.Forms.PictureBox();
            this.salad = new System.Windows.Forms.PictureBox();
            this.fries = new System.Windows.Forms.PictureBox();
            this.port_ddown = new System.Windows.Forms.ComboBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.connectedPort_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.total_price_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.portName_lbl = new System.Windows.Forms.Label();
            this.carroCompra_lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pollingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNormalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.CarroCompraList = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.clean_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cofee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icecream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fries)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cofee
            // 
            this.cofee.Image = ((System.Drawing.Image)(resources.GetObject("cofee.Image")));
            this.cofee.Location = new System.Drawing.Point(3, 3);
            this.cofee.MaximumSize = new System.Drawing.Size(142, 94);
            this.cofee.MinimumSize = new System.Drawing.Size(142, 94);
            this.cofee.Name = "cofee";
            this.cofee.Size = new System.Drawing.Size(142, 94);
            this.cofee.TabIndex = 0;
            this.cofee.TabStop = false;
            this.cofee.Click += new System.EventHandler(this.Cofee_Click);
            // 
            // juice
            // 
            this.juice.Image = ((System.Drawing.Image)(resources.GetObject("juice.Image")));
            this.juice.Location = new System.Drawing.Point(151, 3);
            this.juice.Name = "juice";
            this.juice.Size = new System.Drawing.Size(142, 94);
            this.juice.TabIndex = 1;
            this.juice.TabStop = false;
            this.juice.Click += new System.EventHandler(this.Juice_Click);
            // 
            // cookies
            // 
            this.cookies.Image = ((System.Drawing.Image)(resources.GetObject("cookies.Image")));
            this.cookies.Location = new System.Drawing.Point(299, 3);
            this.cookies.Name = "cookies";
            this.cookies.Size = new System.Drawing.Size(142, 94);
            this.cookies.TabIndex = 2;
            this.cookies.TabStop = false;
            this.cookies.Click += new System.EventHandler(this.Cookies_Click);
            // 
            // icecream
            // 
            this.icecream.Image = ((System.Drawing.Image)(resources.GetObject("icecream.Image")));
            this.icecream.Location = new System.Drawing.Point(3, 103);
            this.icecream.Name = "icecream";
            this.icecream.Size = new System.Drawing.Size(142, 94);
            this.icecream.TabIndex = 3;
            this.icecream.TabStop = false;
            this.icecream.Click += new System.EventHandler(this.Icecream_Click);
            // 
            // pizza
            // 
            this.pizza.Image = ((System.Drawing.Image)(resources.GetObject("pizza.Image")));
            this.pizza.Location = new System.Drawing.Point(151, 103);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(142, 94);
            this.pizza.TabIndex = 4;
            this.pizza.TabStop = false;
            this.pizza.Click += new System.EventHandler(this.Pizza_Click);
            // 
            // donut
            // 
            this.donut.Image = ((System.Drawing.Image)(resources.GetObject("donut.Image")));
            this.donut.Location = new System.Drawing.Point(299, 103);
            this.donut.Name = "donut";
            this.donut.Size = new System.Drawing.Size(142, 94);
            this.donut.TabIndex = 5;
            this.donut.TabStop = false;
            this.donut.Click += new System.EventHandler(this.Donut_Click);
            // 
            // burger
            // 
            this.burger.Image = ((System.Drawing.Image)(resources.GetObject("burger.Image")));
            this.burger.Location = new System.Drawing.Point(3, 203);
            this.burger.Name = "burger";
            this.burger.Size = new System.Drawing.Size(142, 94);
            this.burger.TabIndex = 6;
            this.burger.TabStop = false;
            this.burger.Click += new System.EventHandler(this.Burger_Click);
            // 
            // salad
            // 
            this.salad.Image = ((System.Drawing.Image)(resources.GetObject("salad.Image")));
            this.salad.Location = new System.Drawing.Point(151, 203);
            this.salad.Name = "salad";
            this.salad.Size = new System.Drawing.Size(142, 94);
            this.salad.TabIndex = 7;
            this.salad.TabStop = false;
            this.salad.Click += new System.EventHandler(this.Salad_Click);
            // 
            // fries
            // 
            this.fries.Image = ((System.Drawing.Image)(resources.GetObject("fries.Image")));
            this.fries.Location = new System.Drawing.Point(299, 203);
            this.fries.Name = "fries";
            this.fries.Size = new System.Drawing.Size(142, 94);
            this.fries.TabIndex = 8;
            this.fries.TabStop = false;
            this.fries.Click += new System.EventHandler(this.Fries_Click);
            // 
            // port_ddown
            // 
            this.port_ddown.FormattingEnabled = true;
            this.port_ddown.Items.AddRange(new object[] {
            "COM4"});
            this.port_ddown.Location = new System.Drawing.Point(36, 36);
            this.port_ddown.Name = "port_ddown";
            this.port_ddown.Size = new System.Drawing.Size(101, 21);
            this.port_ddown.TabIndex = 9;
            this.port_ddown.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(143, 34);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 10;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cofee);
            this.flowLayoutPanel1.Controls.Add(this.juice);
            this.flowLayoutPanel1.Controls.Add(this.cookies);
            this.flowLayoutPanel1.Controls.Add(this.icecream);
            this.flowLayoutPanel1.Controls.Add(this.pizza);
            this.flowLayoutPanel1.Controls.Add(this.donut);
            this.flowLayoutPanel1.Controls.Add(this.burger);
            this.flowLayoutPanel1.Controls.Add(this.salad);
            this.flowLayoutPanel1.Controls.Add(this.fries);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 109);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(445, 302);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // connectedPort_lbl
            // 
            this.connectedPort_lbl.AutoSize = true;
            this.connectedPort_lbl.Location = new System.Drawing.Point(33, 60);
            this.connectedPort_lbl.Name = "connectedPort_lbl";
            this.connectedPort_lbl.Size = new System.Drawing.Size(84, 13);
            this.connectedPort_lbl.TabIndex = 12;
            this.connectedPort_lbl.Text = "Connected Port:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.total_price_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.total_lbl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(479, 331);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(157, 39);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // total_price_lbl
            // 
            this.total_price_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total_price_lbl.AutoSize = true;
            this.total_price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price_lbl.Location = new System.Drawing.Point(109, 11);
            this.total_price_lbl.Name = "total_price_lbl";
            this.total_price_lbl.Size = new System.Drawing.Size(16, 17);
            this.total_price_lbl.TabIndex = 16;
            this.total_price_lbl.Text = "0";
            this.total_price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_lbl
            // 
            this.total_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(3, 7);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(72, 25);
            this.total_lbl.TabIndex = 2;
            this.total_lbl.Text = "Total $";
            this.total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // portName_lbl
            // 
            this.portName_lbl.AutoSize = true;
            this.portName_lbl.Location = new System.Drawing.Point(140, 60);
            this.portName_lbl.Name = "portName_lbl";
            this.portName_lbl.Size = new System.Drawing.Size(31, 13);
            this.portName_lbl.TabIndex = 14;
            this.portName_lbl.Text = "none";
            // 
            // carroCompra_lbl
            // 
            this.carroCompra_lbl.AutoSize = true;
            this.carroCompra_lbl.Location = new System.Drawing.Point(476, 34);
            this.carroCompra_lbl.Name = "carroCompra_lbl";
            this.carroCompra_lbl.Size = new System.Drawing.Size(88, 13);
            this.carroCompra_lbl.TabIndex = 16;
            this.carroCompra_lbl.Text = "Lista de Compras";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pollingToolStripMenuItem,
            this.loadKeysToolStripMenuItem,
            this.registerCloseToolStripMenuItem,
            this.setNormalModeToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.connectionToolStripMenuItem.Text = "POS";
            // 
            // pollingToolStripMenuItem
            // 
            this.pollingToolStripMenuItem.Name = "pollingToolStripMenuItem";
            this.pollingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pollingToolStripMenuItem.Text = "Check Connection";
            this.pollingToolStripMenuItem.Click += new System.EventHandler(this.PollingToolStripMenuItem_Click);
            // 
            // loadKeysToolStripMenuItem
            // 
            this.loadKeysToolStripMenuItem.Name = "loadKeysToolStripMenuItem";
            this.loadKeysToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadKeysToolStripMenuItem.Text = "Load Keys";
            this.loadKeysToolStripMenuItem.Click += new System.EventHandler(this.LoadKeysToolStripMenuItem_Click);
            // 
            // registerCloseToolStripMenuItem
            // 
            this.registerCloseToolStripMenuItem.Name = "registerCloseToolStripMenuItem";
            this.registerCloseToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.registerCloseToolStripMenuItem.Text = "Register Close";
            this.registerCloseToolStripMenuItem.Click += new System.EventHandler(this.RegisterCloseToolStripMenuItem_Click);
            // 
            // setNormalModeToolStripMenuItem
            // 
            this.setNormalModeToolStripMenuItem.Name = "setNormalModeToolStripMenuItem";
            this.setNormalModeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.setNormalModeToolStripMenuItem.Text = "Set Normal Mode";
            this.setNormalModeToolStripMenuItem.Click += new System.EventHandler(this.SetNormalModeToolStripMenuItem_Click);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Location = new System.Drawing.Point(224, 34);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(75, 23);
            this.disconnect_btn.TabIndex = 18;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.Disconnect_btn_Click);
            // 
            // CarroCompraList
            // 
            this.CarroCompraList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.precio});
            this.CarroCompraList.FullRowSelect = true;
            this.CarroCompraList.GridLines = true;
            this.CarroCompraList.Location = new System.Drawing.Point(479, 76);
            this.CarroCompraList.Name = "CarroCompraList";
            this.CarroCompraList.Size = new System.Drawing.Size(157, 249);
            this.CarroCompraList.TabIndex = 19;
            this.CarroCompraList.UseCompatibleStateImageBehavior = false;
            this.CarroCompraList.View = System.Windows.Forms.View.Details;
            this.CarroCompraList.SelectedIndexChanged += new System.EventHandler(this.CarroCompraList_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label1.Location = new System.Drawing.Point(477, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "* Haga click en un elemento de la lista para eliminarlo";
            // 
            // pay_btn
            // 
            this.pay_btn.Location = new System.Drawing.Point(566, 383);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(67, 28);
            this.pay_btn.TabIndex = 21;
            this.pay_btn.Text = "Pagar";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            // 
            // clean_btn
            // 
            this.clean_btn.Location = new System.Drawing.Point(479, 383);
            this.clean_btn.Name = "clean_btn";
            this.clean_btn.Size = new System.Drawing.Size(67, 28);
            this.clean_btn.TabIndex = 22;
            this.clean_btn.Text = "Limpiar Carro";
            this.clean_btn.UseVisualStyleBackColor = true;
            this.clean_btn.Click += new System.EventHandler(this.Clean_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 421);
            this.Controls.Add(this.clean_btn);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarroCompraList);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.carroCompra_lbl);
            this.Controls.Add(this.portName_lbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.connectedPort_lbl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.port_ddown);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cofee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icecream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fries)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox cofee;
        private System.Windows.Forms.PictureBox juice;
        private System.Windows.Forms.PictureBox cookies;
        private System.Windows.Forms.PictureBox icecream;
        private System.Windows.Forms.PictureBox pizza;
        private System.Windows.Forms.PictureBox donut;
        private System.Windows.Forms.PictureBox burger;
        private System.Windows.Forms.PictureBox salad;
        private System.Windows.Forms.PictureBox fries;

        private System.Windows.Forms.ComboBox port_ddown;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.Label connectedPort_lbl;
        private System.Windows.Forms.Label portName_lbl;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label carroCompra_lbl;

        private System.Windows.Forms.Label total_price_lbl;
        private System.Windows.Forms.Label total_lbl;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pollingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNormalModeToolStripMenuItem;
        private System.Windows.Forms.ListView CarroCompraList;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button clean_btn;
    }
}

