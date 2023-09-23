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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblHeaderApp = new System.Windows.Forms.Label();
            this.rbtnFruit = new System.Windows.Forms.RadioButton();
            this.rbtnVegetable = new System.Windows.Forms.RadioButton();
            this.rbtnDairy = new System.Windows.Forms.RadioButton();
            this.rbtnMeat = new System.Windows.Forms.RadioButton();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.txtProductID, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtProductName, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtProductPrice, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtProductQuantity, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 5, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(280, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 526);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.Color.White;
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductID.Location = new System.Drawing.Point(327, 175);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(102, 22);
            this.txtProductID.TabIndex = 5;
            this.txtProductID.Text = "Product ID";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(327, 250);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(102, 22);
            this.txtProductName.TabIndex = 6;
            this.txtProductName.Text = "Product Name";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BackColor = System.Drawing.Color.White;
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductPrice.Location = new System.Drawing.Point(327, 325);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(102, 22);
            this.txtProductPrice.TabIndex = 7;
            this.txtProductPrice.Text = "Price";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.BackColor = System.Drawing.Color.White;
            this.txtProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductQuantity.Location = new System.Drawing.Point(327, 400);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(102, 22);
            this.txtProductQuantity.TabIndex = 8;
            this.txtProductQuantity.Text = "Quantity";
            // 
            // lblHeaderApp
            // 
            this.lblHeaderApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderApp.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderApp.ForeColor = System.Drawing.Color.White;
            this.lblHeaderApp.Location = new System.Drawing.Point(3, 0);
            this.lblHeaderApp.Name = "lblHeaderApp";
            this.lblHeaderApp.Size = new System.Drawing.Size(274, 157);
            this.lblHeaderApp.TabIndex = 15;
            this.lblHeaderApp.Text = "Add Product";
            this.lblHeaderApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.rbtnFruit.Location = new System.Drawing.Point(111, 78);
            this.rbtnFruit.Name = "rbtnFruit";
            this.rbtnFruit.Size = new System.Drawing.Size(102, 69);
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
            this.rbtnVegetable.Location = new System.Drawing.Point(219, 78);
            this.rbtnVegetable.Name = "rbtnVegetable";
            this.rbtnVegetable.Size = new System.Drawing.Size(102, 69);
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
            this.rbtnDairy.Location = new System.Drawing.Point(327, 78);
            this.rbtnDairy.Name = "rbtnDairy";
            this.rbtnDairy.Size = new System.Drawing.Size(102, 69);
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
            this.rbtnMeat.Location = new System.Drawing.Point(435, 78);
            this.rbtnMeat.Name = "rbtnMeat";
            this.rbtnMeat.Size = new System.Drawing.Size(102, 69);
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
            this.rbtnOther.Location = new System.Drawing.Point(543, 78);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(102, 69);
            this.rbtnOther.TabIndex = 0;
            this.rbtnOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnOther.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MistyRose;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.Location = new System.Drawing.Point(111, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 70);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(543, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 70);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Name = "frmAddProductAdmin";
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
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHeaderApp;
    }
}