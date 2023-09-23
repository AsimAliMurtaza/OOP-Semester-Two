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
            this.cbListLoad = new System.Windows.Forms.ComboBox();
            this.txtOldProductQuantity = new System.Windows.Forms.TextBox();
            this.txtOldProductPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtNewProductQuantity = new System.Windows.Forms.TextBox();
            this.txtNewProductPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
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
            this.lblHeader.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.layout_UpdateDetails.Controls.Add(this.cbListLoad, 2, 1);
            this.layout_UpdateDetails.Controls.Add(this.txtOldProductQuantity, 1, 2);
            this.layout_UpdateDetails.Controls.Add(this.txtOldProductPrice, 1, 3);
            this.layout_UpdateDetails.Controls.Add(this.btnAdd, 1, 4);
            this.layout_UpdateDetails.Controls.Add(this.btnBack, 1, 6);
            this.layout_UpdateDetails.Controls.Add(this.txtNewProductQuantity, 3, 2);
            this.layout_UpdateDetails.Controls.Add(this.txtNewProductPrice, 3, 3);
            this.layout_UpdateDetails.Controls.Add(this.btnUpdateDetails, 3, 4);
            this.layout_UpdateDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_UpdateDetails.Location = new System.Drawing.Point(248, 0);
            this.layout_UpdateDetails.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.layout_UpdateDetails.Name = "layout_UpdateDetails";
            this.layout_UpdateDetails.RowCount = 7;
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.layout_UpdateDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.layout_UpdateDetails.Size = new System.Drawing.Size(806, 524);
            this.layout_UpdateDetails.TabIndex = 14;
            // 
            // cbListLoad
            // 
            this.cbListLoad.BackColor = System.Drawing.Color.PaleGreen;
            this.cbListLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbListLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListLoad.FormattingEnabled = true;
            this.cbListLoad.Location = new System.Drawing.Point(304, 77);
            this.cbListLoad.Name = "cbListLoad";
            this.cbListLoad.Size = new System.Drawing.Size(194, 33);
            this.cbListLoad.TabIndex = 16;
            // 
            // txtOldProductQuantity
            // 
            this.txtOldProductQuantity.BackColor = System.Drawing.Color.MistyRose;
            this.txtOldProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldProductQuantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldProductQuantity.Location = new System.Drawing.Point(118, 173);
            this.txtOldProductQuantity.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtOldProductQuantity.Name = "txtOldProductQuantity";
            this.txtOldProductQuantity.Size = new System.Drawing.Size(180, 35);
            this.txtOldProductQuantity.TabIndex = 8;
            this.txtOldProductQuantity.Text = "Old Quantity";
            // 
            // txtOldProductPrice
            // 
            this.txtOldProductPrice.BackColor = System.Drawing.Color.MistyRose;
            this.txtOldProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldProductPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldProductPrice.Location = new System.Drawing.Point(118, 247);
            this.txtOldProductPrice.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtOldProductPrice.Name = "txtOldProductPrice";
            this.txtOldProductPrice.Size = new System.Drawing.Size(180, 35);
            this.txtOldProductPrice.TabIndex = 7;
            this.txtOldProductPrice.Text = "Old Price";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__9_;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(118, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 68);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnGetOldDetails_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__6_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(118, 447);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 74);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtNewProductQuantity
            // 
            this.txtNewProductQuantity.BackColor = System.Drawing.Color.MistyRose;
            this.txtNewProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewProductQuantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewProductQuantity.Location = new System.Drawing.Point(504, 173);
            this.txtNewProductQuantity.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtNewProductQuantity.Name = "txtNewProductQuantity";
            this.txtNewProductQuantity.Size = new System.Drawing.Size(180, 35);
            this.txtNewProductQuantity.TabIndex = 17;
            this.txtNewProductQuantity.Text = "Enter New Quantity";
            // 
            // txtNewProductPrice
            // 
            this.txtNewProductPrice.BackColor = System.Drawing.Color.MistyRose;
            this.txtNewProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewProductPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewProductPrice.Location = new System.Drawing.Point(504, 247);
            this.txtNewProductPrice.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.txtNewProductPrice.Name = "txtNewProductPrice";
            this.txtNewProductPrice.Size = new System.Drawing.Size(180, 35);
            this.txtNewProductPrice.TabIndex = 18;
            this.txtNewProductPrice.Text = "Enter New Price";
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateDetails.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__7_;
            this.btnUpdateDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.Location = new System.Drawing.Point(504, 299);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(180, 68);
            this.btnUpdateDetails.TabIndex = 19;
            this.btnUpdateDetails.UseVisualStyleBackColor = false;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // frmUpdateProductDetailsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 524);
            this.Controls.Add(this.layout_UpdateDetails);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmUpdateProductDetailsAdmin";
            this.Text = "Update Product Details";
            this.Load += new System.EventHandler(this.frmUpdateProductDetailsAdmin_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layout_UpdateDetails.ResumeLayout(false);
            this.layout_UpdateDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel layout_UpdateDetails;
        private System.Windows.Forms.ComboBox cbListLoad;
        private System.Windows.Forms.TextBox txtOldProductQuantity;
        private System.Windows.Forms.TextBox txtOldProductPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtNewProductQuantity;
        private System.Windows.Forms.TextBox txtNewProductPrice;
        private System.Windows.Forms.Button btnUpdateDetails;
    }
}