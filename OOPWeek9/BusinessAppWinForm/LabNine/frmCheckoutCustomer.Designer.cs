namespace BusinessApp
{
    partial class frmCheckoutCustomer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblHeaderCustomer = new System.Windows.Forms.Label();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalItems = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalTax = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalAmountDue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgViewCart = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHeaderCustomer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbLogo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 569);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 22;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.FillColor2 = System.Drawing.Color.LightCoral;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.MintCream;
            this.btnBack.Location = new System.Drawing.Point(3, 520);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(272, 46);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeaderCustomer
            // 
            this.lblHeaderCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderCustomer.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderCustomer.ForeColor = System.Drawing.Color.White;
            this.lblHeaderCustomer.Location = new System.Drawing.Point(3, 0);
            this.lblHeaderCustomer.Name = "lblHeaderCustomer";
            this.lblHeaderCustomer.Size = new System.Drawing.Size(272, 186);
            this.lblHeaderCustomer.TabIndex = 0;
            this.lblHeaderCustomer.Text = "Checkout";
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
            this.pbLogo.Location = new System.Drawing.Point(3, 189);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(272, 267);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.SeaShell;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.79012F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.93827F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.34568F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalItems, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalTax, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalAmountDue, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalPrice, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalDiscount, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnPay, 3, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(278, 308);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(854, 261);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 87);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Amount Due:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 87);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Tax:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Items:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(391, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 87);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(391, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 87);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Discount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Animated = true;
            this.txtTotalItems.BorderColor = System.Drawing.Color.BurlyWood;
            this.txtTotalItems.BorderRadius = 15;
            this.txtTotalItems.BorderThickness = 2;
            this.txtTotalItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalItems.DefaultText = "";
            this.txtTotalItems.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalItems.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalItems.FillColor = System.Drawing.Color.Snow;
            this.txtTotalItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalItems.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalItems.Location = new System.Drawing.Point(159, 25);
            this.txtTotalItems.Margin = new System.Windows.Forms.Padding(3, 25, 3, 4);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.PasswordChar = '\0';
            this.txtTotalItems.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotalItems.PlaceholderText = "total items";
            this.txtTotalItems.ReadOnly = true;
            this.txtTotalItems.SelectedText = "";
            this.txtTotalItems.Size = new System.Drawing.Size(226, 42);
            this.txtTotalItems.TabIndex = 26;
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Animated = true;
            this.txtTotalTax.BorderColor = System.Drawing.Color.BurlyWood;
            this.txtTotalTax.BorderRadius = 15;
            this.txtTotalTax.BorderThickness = 2;
            this.txtTotalTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalTax.DefaultText = "";
            this.txtTotalTax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalTax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalTax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalTax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalTax.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalTax.FillColor = System.Drawing.Color.Snow;
            this.txtTotalTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalTax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalTax.Location = new System.Drawing.Point(159, 112);
            this.txtTotalTax.Margin = new System.Windows.Forms.Padding(3, 25, 3, 4);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.PasswordChar = '\0';
            this.txtTotalTax.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotalTax.PlaceholderText = "tax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.SelectedText = "";
            this.txtTotalTax.Size = new System.Drawing.Size(226, 42);
            this.txtTotalTax.TabIndex = 27;
            // 
            // txtTotalAmountDue
            // 
            this.txtTotalAmountDue.Animated = true;
            this.txtTotalAmountDue.BorderColor = System.Drawing.Color.BurlyWood;
            this.txtTotalAmountDue.BorderRadius = 15;
            this.txtTotalAmountDue.BorderThickness = 2;
            this.txtTotalAmountDue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmountDue.DefaultText = "";
            this.txtTotalAmountDue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAmountDue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAmountDue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmountDue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmountDue.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalAmountDue.FillColor = System.Drawing.Color.Snow;
            this.txtTotalAmountDue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmountDue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalAmountDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalAmountDue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmountDue.Location = new System.Drawing.Point(159, 199);
            this.txtTotalAmountDue.Margin = new System.Windows.Forms.Padding(3, 25, 3, 4);
            this.txtTotalAmountDue.Name = "txtTotalAmountDue";
            this.txtTotalAmountDue.PasswordChar = '\0';
            this.txtTotalAmountDue.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotalAmountDue.PlaceholderText = "payable amount";
            this.txtTotalAmountDue.ReadOnly = true;
            this.txtTotalAmountDue.SelectedText = "";
            this.txtTotalAmountDue.Size = new System.Drawing.Size(226, 42);
            this.txtTotalAmountDue.TabIndex = 28;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Animated = true;
            this.txtTotalPrice.BorderColor = System.Drawing.Color.BurlyWood;
            this.txtTotalPrice.BorderRadius = 15;
            this.txtTotalPrice.BorderThickness = 2;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalPrice.FillColor = System.Drawing.Color.Snow;
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(599, 25);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 25, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotalPrice.PlaceholderText = "total price";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(252, 42);
            this.txtTotalPrice.TabIndex = 30;
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Animated = true;
            this.txtTotalDiscount.BorderColor = System.Drawing.Color.BurlyWood;
            this.txtTotalDiscount.BorderRadius = 15;
            this.txtTotalDiscount.BorderThickness = 2;
            this.txtTotalDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDiscount.DefaultText = "";
            this.txtTotalDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalDiscount.FillColor = System.Drawing.Color.Snow;
            this.txtTotalDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDiscount.Location = new System.Drawing.Point(599, 112);
            this.txtTotalDiscount.Margin = new System.Windows.Forms.Padding(3, 25, 3, 4);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.PasswordChar = '\0';
            this.txtTotalDiscount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotalDiscount.PlaceholderText = "discount";
            this.txtTotalDiscount.ReadOnly = true;
            this.txtTotalDiscount.SelectedText = "";
            this.txtTotalDiscount.Size = new System.Drawing.Size(252, 42);
            this.txtTotalDiscount.TabIndex = 29;
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BorderRadius = 39;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.FillColor = System.Drawing.Color.PaleTurquoise;
            this.btnPay.FillColor2 = System.Drawing.Color.NavajoWhite;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnPay.Location = new System.Drawing.Point(599, 177);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(252, 81);
            this.btnPay.TabIndex = 31;
            this.btnPay.Text = "Pay";
            this.btnPay.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgViewCart, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(278, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.42707F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(854, 308);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // dgViewCart
            // 
            this.dgViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgViewCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dgViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewCart.Location = new System.Drawing.Point(3, 3);
            this.dgViewCart.Name = "dgViewCart";
            this.dgViewCart.ReadOnly = true;
            this.dgViewCart.RowHeadersWidth = 51;
            this.dgViewCart.RowTemplate.Height = 24;
            this.dgViewCart.Size = new System.Drawing.Size(848, 302);
            this.dgViewCart.TabIndex = 11;
            // 
            // frmCheckoutCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 569);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCheckoutCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckoutCustomer";
            this.Load += new System.EventHandler(this.frmCheckoutCustomer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.Label lblHeaderCustomer;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalItems;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalTax;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmountDue;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgViewCart;
        private Guna.UI2.WinForms.Guna2GradientButton btnPay;
    }
}