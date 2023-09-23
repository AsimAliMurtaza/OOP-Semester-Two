namespace BusinessApp
{
    partial class frmAddProductAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProductAdmin));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblHeaderApp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProductQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.rbtnFruit = new System.Windows.Forms.RadioButton();
            this.rbtnVegetable = new System.Windows.Forms.RadioButton();
            this.rbtnDairy = new System.Windows.Forms.RadioButton();
            this.rbtnMeat = new System.Windows.Forms.RadioButton();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Brown;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHeader, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblHeaderApp, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 526);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(3, 429);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(100, 23);
            this.lblHeader.TabIndex = 0;
            // 
            // lblHeaderApp
            // 
            this.lblHeaderApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderApp.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderApp.ForeColor = System.Drawing.Color.White;
            this.lblHeaderApp.Location = new System.Drawing.Point(3, 0);
            this.lblHeaderApp.Name = "lblHeaderApp";
            this.lblHeaderApp.Size = new System.Drawing.Size(274, 157);
            this.lblHeaderApp.TabIndex = 15;
            this.lblHeaderApp.Text = "Add Product";
            this.lblHeaderApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.rbtnFruit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbtnVegetable, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbtnDairy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbtnMeat, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbtnOther, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProductQuantity, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtProductPrice, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtProductName, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtProductID, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 5, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(280, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.50113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.87302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.92517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.92517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 526);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Animated = true;
            this.txtProductQuantity.BorderColor = System.Drawing.Color.Brown;
            this.txtProductQuantity.BorderRadius = 15;
            this.txtProductQuantity.BorderThickness = 2;
            this.txtProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductQuantity.DefaultText = "";
            this.txtProductQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductQuantity.FillColor = System.Drawing.Color.Snow;
            this.txtProductQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductQuantity.Location = new System.Drawing.Point(327, 388);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductQuantity.PlaceholderText = "quantity";
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.Size = new System.Drawing.Size(102, 41);
            this.txtProductQuantity.TabIndex = 19;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Animated = true;
            this.txtProductPrice.BorderColor = System.Drawing.Color.Brown;
            this.txtProductPrice.BorderRadius = 15;
            this.txtProductPrice.BorderThickness = 2;
            this.txtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice.DefaultText = "";
            this.txtProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductPrice.FillColor = System.Drawing.Color.Snow;
            this.txtProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductPrice.Location = new System.Drawing.Point(327, 331);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductPrice.PlaceholderText = "price";
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.Size = new System.Drawing.Size(102, 47);
            this.txtProductPrice.TabIndex = 21;
            // 
            // txtProductName
            // 
            this.txtProductName.Animated = true;
            this.txtProductName.BorderColor = System.Drawing.Color.Brown;
            this.txtProductName.BorderRadius = 15;
            this.txtProductName.BorderThickness = 2;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FillColor = System.Drawing.Color.Snow;
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(327, 277);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductName.PlaceholderText = "name";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(102, 44);
            this.txtProductName.TabIndex = 20;
            // 
            // txtProductID
            // 
            this.txtProductID.Animated = true;
            this.txtProductID.BorderColor = System.Drawing.Color.Brown;
            this.txtProductID.BorderRadius = 15;
            this.txtProductID.BorderThickness = 2;
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductID.DefaultText = "";
            this.txtProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.FillColor = System.Drawing.Color.Snow;
            this.txtProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Location = new System.Drawing.Point(327, 223);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductID.PlaceholderText = "product id";
            this.txtProductID.SelectedText = "";
            this.txtProductID.Size = new System.Drawing.Size(102, 43);
            this.txtProductID.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 19;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FillColor2 = System.Drawing.Color.Brown;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(111, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 41);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 19;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.FillColor2 = System.Drawing.Color.Brown;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(543, 444);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 41);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnFruit
            // 
            this.rbtnFruit.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnFruit.AutoSize = true;
            this.rbtnFruit.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFruit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtnFruit.BackgroundImage")));
            this.rbtnFruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnFruit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnFruit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnFruit.Location = new System.Drawing.Point(111, 66);
            this.rbtnFruit.Name = "rbtnFruit";
            this.rbtnFruit.Size = new System.Drawing.Size(102, 80);
            this.rbtnFruit.TabIndex = 1;
            this.rbtnFruit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnFruit.UseVisualStyleBackColor = false;
            // 
            // rbtnVegetable
            // 
            this.rbtnVegetable.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnVegetable.AutoSize = true;
            this.rbtnVegetable.BackColor = System.Drawing.Color.Transparent;
            this.rbtnVegetable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtnVegetable.BackgroundImage")));
            this.rbtnVegetable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtnVegetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnVegetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnVegetable.Location = new System.Drawing.Point(219, 66);
            this.rbtnVegetable.Name = "rbtnVegetable";
            this.rbtnVegetable.Size = new System.Drawing.Size(102, 80);
            this.rbtnVegetable.TabIndex = 2;
            this.rbtnVegetable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnVegetable.UseVisualStyleBackColor = false;
            // 
            // rbtnDairy
            // 
            this.rbtnDairy.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnDairy.AutoSize = true;
            this.rbtnDairy.BackColor = System.Drawing.Color.Transparent;
            this.rbtnDairy.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__5_;
            this.rbtnDairy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnDairy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnDairy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnDairy.Location = new System.Drawing.Point(327, 66);
            this.rbtnDairy.Name = "rbtnDairy";
            this.rbtnDairy.Size = new System.Drawing.Size(102, 80);
            this.rbtnDairy.TabIndex = 3;
            this.rbtnDairy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnDairy.UseVisualStyleBackColor = false;
            // 
            // rbtnMeat
            // 
            this.rbtnMeat.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnMeat.AutoSize = true;
            this.rbtnMeat.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMeat.BackgroundImage = global::BusinessApp.Properties.Resources._2224259;
            this.rbtnMeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnMeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnMeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnMeat.Location = new System.Drawing.Point(435, 66);
            this.rbtnMeat.Name = "rbtnMeat";
            this.rbtnMeat.Size = new System.Drawing.Size(102, 80);
            this.rbtnMeat.TabIndex = 4;
            this.rbtnMeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnMeat.UseVisualStyleBackColor = false;
            // 
            // rbtnOther
            // 
            this.rbtnOther.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.BackColor = System.Drawing.Color.Transparent;
            this.rbtnOther.BackgroundImage = global::BusinessApp.Properties.Resources.applicationsother_103414;
            this.rbtnOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtnOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnOther.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnOther.Location = new System.Drawing.Point(543, 66);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(102, 80);
            this.rbtnOther.TabIndex = 0;
            this.rbtnOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnOther.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 266);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddProductAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddProductAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddProductAdmin_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbtnFruit;
        private System.Windows.Forms.RadioButton rbtnVegetable;
        private System.Windows.Forms.RadioButton rbtnDairy;
        private System.Windows.Forms.RadioButton rbtnMeat;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.Label lblHeaderApp;
        private Guna.UI2.WinForms.Guna2TextBox txtProductID;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtProductPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtProductQuantity;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
    }
}