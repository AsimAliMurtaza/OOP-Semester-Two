namespace BusinessApp
{
    partial class frmCustomerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerMenu));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblHeaderCustomer = new System.Windows.Forms.Label();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbAddToCart = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbViewCart = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbDeleteFromCart = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbCheckout = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnManageAccount = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddToCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteFromCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblHeaderCustomer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbLogo, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 517);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 25;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FillColor = System.Drawing.Color.MistyRose;
            this.btnBack.FillColor2 = System.Drawing.Color.Turquoise;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(3, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(272, 52);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Logout";
            this.btnBack.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnBack.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblHeaderCustomer
            // 
            this.lblHeaderCustomer.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderCustomer.ForeColor = System.Drawing.Color.White;
            this.lblHeaderCustomer.Location = new System.Drawing.Point(3, 0);
            this.lblHeaderCustomer.Name = "lblHeaderCustomer";
            this.lblHeaderCustomer.Size = new System.Drawing.Size(272, 134);
            this.lblHeaderCustomer.TabIndex = 0;
            this.lblHeaderCustomer.Text = "Customer Menu";
            this.lblHeaderCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__17_;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.FillColor = System.Drawing.Color.Transparent;
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(3, 137);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(272, 267);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SeaShell;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.40576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.40576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.002401F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0072F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.Controls.Add(this.pbAddToCart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbViewCart, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pbDeleteFromCart, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbCheckout, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnManageAccount, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(278, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.88975F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.547389F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.05029F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.547389F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.47002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.96325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 517);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pbAddToCart
            // 
            this.pbAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.pbAddToCart.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__18_;
            this.pbAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddToCart.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbAddToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAddToCart.FillColor = System.Drawing.Color.Transparent;
            this.pbAddToCart.ImageRotate = 0F;
            this.pbAddToCart.Location = new System.Drawing.Point(122, 67);
            this.pbAddToCart.Name = "pbAddToCart";
            this.pbAddToCart.Size = new System.Drawing.Size(113, 102);
            this.pbAddToCart.TabIndex = 4;
            this.pbAddToCart.TabStop = false;
            this.pbAddToCart.Click += new System.EventHandler(this.pbAddToCart_Click);
            // 
            // pbViewCart
            // 
            this.pbViewCart.BackColor = System.Drawing.Color.Transparent;
            this.pbViewCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbViewCart.BackgroundImage")));
            this.pbViewCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbViewCart.FillColor = System.Drawing.Color.Transparent;
            this.pbViewCart.ImageRotate = 0F;
            this.pbViewCart.Location = new System.Drawing.Point(122, 305);
            this.pbViewCart.Name = "pbViewCart";
            this.pbViewCart.Size = new System.Drawing.Size(113, 105);
            this.pbViewCart.TabIndex = 7;
            this.pbViewCart.TabStop = false;
            this.pbViewCart.Click += new System.EventHandler(this.pbViewCart_Click);
            // 
            // pbDeleteFromCart
            // 
            this.pbDeleteFromCart.BackColor = System.Drawing.Color.Transparent;
            this.pbDeleteFromCart.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__19_;
            this.pbDeleteFromCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDeleteFromCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDeleteFromCart.FillColor = System.Drawing.Color.Transparent;
            this.pbDeleteFromCart.ImageRotate = 0F;
            this.pbDeleteFromCart.Location = new System.Drawing.Point(122, 185);
            this.pbDeleteFromCart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pbDeleteFromCart.Name = "pbDeleteFromCart";
            this.pbDeleteFromCart.Size = new System.Drawing.Size(113, 106);
            this.pbDeleteFromCart.TabIndex = 6;
            this.pbDeleteFromCart.TabStop = false;
            this.pbDeleteFromCart.Click += new System.EventHandler(this.pbDeleteFromCart_Click);
            // 
            // pbCheckout
            // 
            this.pbCheckout.AutoRoundedCorners = true;
            this.pbCheckout.BackColor = System.Drawing.Color.Transparent;
            this.pbCheckout.BackgroundImage = global::BusinessApp.Properties.Resources._1000_F_115313920_TVwZOyScG4llRi8DalVeYTyOpsyo0ZwK;
            this.pbCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCheckout.BorderRadius = 50;
            this.pbCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCheckout.FillColor = System.Drawing.Color.Transparent;
            this.pbCheckout.ImageRotate = 0F;
            this.pbCheckout.Location = new System.Drawing.Point(290, 67);
            this.pbCheckout.Name = "pbCheckout";
            this.pbCheckout.Size = new System.Drawing.Size(143, 102);
            this.pbCheckout.TabIndex = 5;
            this.pbCheckout.TabStop = false;
            this.pbCheckout.Click += new System.EventHandler(this.pbCheckout_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnManageAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageAccount.BackgroundImage")));
            this.btnManageAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnManageAccount.ImageRotate = 0F;
            this.btnManageAccount.Location = new System.Drawing.Point(290, 183);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(143, 108);
            this.btnManageAccount.TabIndex = 8;
            this.btnManageAccount.TabStop = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // frmCustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMenu";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddToCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteFromCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHeaderCustomer;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbAddToCart;
        private Guna.UI2.WinForms.Guna2PictureBox pbViewCart;
        private Guna.UI2.WinForms.Guna2PictureBox pbDeleteFromCart;
        private Guna.UI2.WinForms.Guna2PictureBox pbCheckout;
        private Guna.UI2.WinForms.Guna2PictureBox btnManageAccount;
    }
}