namespace BusinessApp
{
    partial class frmUpdateProductDetailsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateProductDetailsAdmin));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.layout_UpdateDetails = new System.Windows.Forms.TableLayoutPanel();
            this.cmbList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtOldProductQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOldProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewProductQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdateDetails = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.layout_UpdateDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Brown;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 524);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(242, 147);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Update Details";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 266);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // layout_UpdateDetails
            // 
            this.layout_UpdateDetails.BackColor = System.Drawing.Color.Snow;
            this.layout_UpdateDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.layout_UpdateDetails.ColumnCount = 5;
            this.layout_UpdateDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36493F));
            this.layout_UpdateDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.18287F));
            this.layout_UpdateDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.90012F));
            this.layout_UpdateDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.18716F));
            this.layout_UpdateDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36492F));
            this.layout_UpdateDetails.Controls.Add(this.cmbList, 2, 1);
            this.layout_UpdateDetails.Controls.Add(this.btnBack, 0, 7);
            this.layout_UpdateDetails.Controls.Add(this.txtOldProductQuantity, 2, 2);
            this.layout_UpdateDetails.Controls.Add(this.txtOldProductPrice, 2, 3);
            this.layout_UpdateDetails.Controls.Add(this.txtNewProductQuantity, 2, 4);
            this.layout_UpdateDetails.Controls.Add(this.txtNewProductPrice, 2, 5);
            this.layout_UpdateDetails.Controls.Add(this.btnUpdateDetails, 3, 7);
            this.layout_UpdateDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_UpdateDetails.Location = new System.Drawing.Point(248, 0);
            this.layout_UpdateDetails.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.layout_UpdateDetails.Name = "layout_UpdateDetails";
            this.layout_UpdateDetails.RowCount = 9;
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.40194F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35768F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.35013F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8539F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.59446F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.09824F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35768F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.layout_UpdateDetails.Size = new System.Drawing.Size(806, 524);
            this.layout_UpdateDetails.TabIndex = 14;
            // 
            // cmbList
            // 
            this.cmbList.AutoRoundedCorners = true;
            this.cmbList.BackColor = System.Drawing.Color.Transparent;
            this.cmbList.BorderColor = System.Drawing.Color.Brown;
            this.cmbList.BorderRadius = 17;
            this.cmbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbList.ItemHeight = 30;
            this.cmbList.Location = new System.Drawing.Point(304, 76);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(194, 36);
            this.cmbList.TabIndex = 20;
            this.cmbList.SelectedIndexChanged += new System.EventHandler(this.cmbList_SelectedIndexChanged);
            // 
            // txtOldProductQuantity
            // 
            this.txtOldProductQuantity.Animated = true;
            this.txtOldProductQuantity.BorderColor = System.Drawing.Color.Brown;
            this.txtOldProductQuantity.BorderRadius = 15;
            this.txtOldProductQuantity.BorderThickness = 2;
            this.txtOldProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldProductQuantity.DefaultText = "";
            this.txtOldProductQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldProductQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldProductQuantity.FillColor = System.Drawing.Color.Snow;
            this.txtOldProductQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldProductQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOldProductQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOldProductQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldProductQuantity.Location = new System.Drawing.Point(304, 134);
            this.txtOldProductQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldProductQuantity.Name = "txtOldProductQuantity";
            this.txtOldProductQuantity.PasswordChar = '\0';
            this.txtOldProductQuantity.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOldProductQuantity.PlaceholderText = "old quantity";
            this.txtOldProductQuantity.ReadOnly = true;
            this.txtOldProductQuantity.SelectedText = "";
            this.txtOldProductQuantity.Size = new System.Drawing.Size(194, 45);
            this.txtOldProductQuantity.TabIndex = 21;
            // 
            // txtOldProductPrice
            // 
            this.txtOldProductPrice.Animated = true;
            this.txtOldProductPrice.BorderColor = System.Drawing.Color.Brown;
            this.txtOldProductPrice.BorderRadius = 15;
            this.txtOldProductPrice.BorderThickness = 2;
            this.txtOldProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldProductPrice.DefaultText = "";
            this.txtOldProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldProductPrice.FillColor = System.Drawing.Color.Snow;
            this.txtOldProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldProductPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOldProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOldProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldProductPrice.Location = new System.Drawing.Point(304, 187);
            this.txtOldProductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldProductPrice.Name = "txtOldProductPrice";
            this.txtOldProductPrice.PasswordChar = '\0';
            this.txtOldProductPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOldProductPrice.PlaceholderText = "old price";
            this.txtOldProductPrice.ReadOnly = true;
            this.txtOldProductPrice.SelectedText = "";
            this.txtOldProductPrice.Size = new System.Drawing.Size(194, 47);
            this.txtOldProductPrice.TabIndex = 22;
            // 
            // txtNewProductQuantity
            // 
            this.txtNewProductQuantity.Animated = true;
            this.txtNewProductQuantity.BorderColor = System.Drawing.Color.Brown;
            this.txtNewProductQuantity.BorderRadius = 15;
            this.txtNewProductQuantity.BorderThickness = 2;
            this.txtNewProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewProductQuantity.DefaultText = "";
            this.txtNewProductQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewProductQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewProductQuantity.FillColor = System.Drawing.Color.Snow;
            this.txtNewProductQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewProductQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewProductQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewProductQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewProductQuantity.Location = new System.Drawing.Point(304, 242);
            this.txtNewProductQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewProductQuantity.Name = "txtNewProductQuantity";
            this.txtNewProductQuantity.PasswordChar = '\0';
            this.txtNewProductQuantity.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewProductQuantity.PlaceholderText = "new quantity";
            this.txtNewProductQuantity.SelectedText = "";
            this.txtNewProductQuantity.Size = new System.Drawing.Size(194, 42);
            this.txtNewProductQuantity.TabIndex = 23;
            // 
            // txtNewProductPrice
            // 
            this.txtNewProductPrice.Animated = true;
            this.txtNewProductPrice.BorderColor = System.Drawing.Color.Brown;
            this.txtNewProductPrice.BorderRadius = 15;
            this.txtNewProductPrice.BorderThickness = 2;
            this.txtNewProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewProductPrice.DefaultText = "";
            this.txtNewProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewProductPrice.FillColor = System.Drawing.Color.Snow;
            this.txtNewProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewProductPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewProductPrice.Location = new System.Drawing.Point(304, 292);
            this.txtNewProductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewProductPrice.Name = "txtNewProductPrice";
            this.txtNewProductPrice.PasswordChar = '\0';
            this.txtNewProductPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewProductPrice.PlaceholderText = "new price";
            this.txtNewProductPrice.SelectedText = "";
            this.txtNewProductPrice.Size = new System.Drawing.Size(194, 44);
            this.txtNewProductPrice.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 28;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FillColor2 = System.Drawing.Color.Brown;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(3, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 58);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Animated = true;
            this.btnUpdateDetails.AutoRoundedCorners = true;
            this.btnUpdateDetails.BorderRadius = 28;
            this.btnUpdateDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateDetails.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDetails.FillColor2 = System.Drawing.Color.Brown;
            this.btnUpdateDetails.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateDetails.Location = new System.Drawing.Point(504, 400);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(180, 58);
            this.btnUpdateDetails.TabIndex = 28;
            this.btnUpdateDetails.Text = "Update";
            this.btnUpdateDetails.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // frmUpdateProductDetailsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 524);
            this.Controls.Add(this.layout_UpdateDetails);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUpdateProductDetailsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Details";
            this.Load += new System.EventHandler(this.frmUpdateProductDetailsAdmin_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layout_UpdateDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel layout_UpdateDetails;
        private Guna.UI2.WinForms.Guna2ComboBox cmbList;
        private Guna.UI2.WinForms.Guna2TextBox txtNewProductQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtNewProductPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtOldProductQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtOldProductPrice;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateDetails;
    }
}