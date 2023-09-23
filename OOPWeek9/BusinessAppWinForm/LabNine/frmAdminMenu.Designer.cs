namespace BusinessApp
{
    partial class frmAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMenu));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbLogoAdmin = new System.Windows.Forms.PictureBox();
            this.layoutAdminMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pbAddProduct = new System.Windows.Forms.PictureBox();
            this.pbDeleteProduct = new System.Windows.Forms.PictureBox();
            this.pbUpdateProduct = new System.Windows.Forms.PictureBox();
            this.pbViewAllProducts = new System.Windows.Forms.PictureBox();
            this.pbViewUser = new System.Windows.Forms.PictureBox();
            this.pbAdminSignUp = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAdmin)).BeginInit();
            this.layoutAdminMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Brown;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbLogoAdmin, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 516);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 32;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FillColor = System.Drawing.Color.Tan;
            this.btnBack.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(3, 446);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(275, 67);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Logout";
            this.btnBack.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(275, 147);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Admin Menu";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogoAdmin
            // 
            this.pbLogoAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogoAdmin.BackgroundImage")));
            this.pbLogoAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogoAdmin.Location = new System.Drawing.Point(3, 150);
            this.pbLogoAdmin.Name = "pbLogoAdmin";
            this.pbLogoAdmin.Size = new System.Drawing.Size(275, 278);
            this.pbLogoAdmin.TabIndex = 9;
            this.pbLogoAdmin.TabStop = false;
            // 
            // layoutAdminMenu
            // 
            this.layoutAdminMenu.BackColor = System.Drawing.Color.Transparent;
            this.layoutAdminMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.layoutAdminMenu.ColumnCount = 7;
            this.layoutAdminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.84058F));
            this.layoutAdminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.5745F));
            this.layoutAdminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.055409F));
            this.layoutAdminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.88151F));
            this.layoutAdminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.941748F));
            this.layoutAdminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.layoutAdminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.layoutAdminMenu.Controls.Add(this.pbAddProduct, 1, 1);
            this.layoutAdminMenu.Controls.Add(this.pbDeleteProduct, 1, 3);
            this.layoutAdminMenu.Controls.Add(this.pbUpdateProduct, 1, 5);
            this.layoutAdminMenu.Controls.Add(this.pbViewAllProducts, 3, 1);
            this.layoutAdminMenu.Controls.Add(this.pbViewUser, 3, 5);
            this.layoutAdminMenu.Controls.Add(this.pbAdminSignUp, 3, 3);
            this.layoutAdminMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutAdminMenu.Location = new System.Drawing.Point(281, 0);
            this.layoutAdminMenu.Name = "layoutAdminMenu";
            this.layoutAdminMenu.RowCount = 7;
            this.layoutAdminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.layoutAdminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.34884F));
            this.layoutAdminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.682171F));
            this.layoutAdminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.76744F));
            this.layoutAdminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.294574F));
            this.layoutAdminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.18605F));
            this.layoutAdminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.34884F));
            this.layoutAdminMenu.Size = new System.Drawing.Size(758, 516);
            this.layoutAdminMenu.TabIndex = 12;
            // 
            // pbAddProduct
            // 
            this.pbAddProduct.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__1_;
            this.pbAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAddProduct.Location = new System.Drawing.Point(108, 76);
            this.pbAddProduct.Name = "pbAddProduct";
            this.pbAddProduct.Size = new System.Drawing.Size(220, 98);
            this.pbAddProduct.TabIndex = 6;
            this.pbAddProduct.TabStop = false;
            this.pbAddProduct.Click += new System.EventHandler(this.pbAddProduct_Click);
            // 
            // pbDeleteProduct
            // 
            this.pbDeleteProduct.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__2_;
            this.pbDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDeleteProduct.Location = new System.Drawing.Point(108, 198);
            this.pbDeleteProduct.Name = "pbDeleteProduct";
            this.pbDeleteProduct.Size = new System.Drawing.Size(220, 95);
            this.pbDeleteProduct.TabIndex = 7;
            this.pbDeleteProduct.TabStop = false;
            this.pbDeleteProduct.Click += new System.EventHandler(this.pbDeleteProduct_Click);
            // 
            // pbUpdateProduct
            // 
            this.pbUpdateProduct.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__3_;
            this.pbUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUpdateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUpdateProduct.Location = new System.Drawing.Point(108, 315);
            this.pbUpdateProduct.Name = "pbUpdateProduct";
            this.pbUpdateProduct.Size = new System.Drawing.Size(220, 92);
            this.pbUpdateProduct.TabIndex = 8;
            this.pbUpdateProduct.TabStop = false;
            this.pbUpdateProduct.Click += new System.EventHandler(this.pbUpdateProduct_Click);
            // 
            // pbViewAllProducts
            // 
            this.pbViewAllProducts.BackgroundImage = global::BusinessApp.Properties.Resources.list_ingredients_512_removebg_preview__1_;
            this.pbViewAllProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbViewAllProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbViewAllProducts.Location = new System.Drawing.Point(339, 76);
            this.pbViewAllProducts.Name = "pbViewAllProducts";
            this.pbViewAllProducts.Size = new System.Drawing.Size(205, 98);
            this.pbViewAllProducts.TabIndex = 9;
            this.pbViewAllProducts.TabStop = false;
            this.pbViewAllProducts.Click += new System.EventHandler(this.pbViewAllProducts_Click);
            // 
            // pbViewUser
            // 
            this.pbViewUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbViewUser.BackgroundImage")));
            this.pbViewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbViewUser.Location = new System.Drawing.Point(339, 315);
            this.pbViewUser.Name = "pbViewUser";
            this.pbViewUser.Size = new System.Drawing.Size(205, 92);
            this.pbViewUser.TabIndex = 10;
            this.pbViewUser.TabStop = false;
            this.pbViewUser.Click += new System.EventHandler(this.pbViewUser_Click);
            // 
            // pbAdminSignUp
            // 
            this.pbAdminSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pbAdminSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdminSignUp.BackgroundImage")));
            this.pbAdminSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAdminSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAdminSignUp.Location = new System.Drawing.Point(339, 198);
            this.pbAdminSignUp.Name = "pbAdminSignUp";
            this.pbAdminSignUp.Size = new System.Drawing.Size(205, 95);
            this.pbAdminSignUp.TabIndex = 12;
            this.pbAdminSignUp.TabStop = false;
            this.pbAdminSignUp.Click += new System.EventHandler(this.pbAdminSignUp_Click);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 516);
            this.Controls.Add(this.layoutAdminMenu);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome, Admin";
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAdmin)).EndInit();
            this.layoutAdminMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminSignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbLogoAdmin;
        private System.Windows.Forms.TableLayoutPanel layoutAdminMenu;
        private System.Windows.Forms.PictureBox pbAddProduct;
        private System.Windows.Forms.PictureBox pbDeleteProduct;
        private System.Windows.Forms.PictureBox pbUpdateProduct;
        private System.Windows.Forms.PictureBox pbViewAllProducts;
        private System.Windows.Forms.PictureBox pbViewUser;
        private System.Windows.Forms.PictureBox pbAdminSignUp;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
    }
}