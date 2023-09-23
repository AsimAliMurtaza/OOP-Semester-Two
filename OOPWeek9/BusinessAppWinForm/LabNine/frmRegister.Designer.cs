namespace BusinessApp
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.layoutRegister = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pbCustomerSignUp = new System.Windows.Forms.PictureBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.layoutRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbLogo, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 533);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(283, 204);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Sign Up Page";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Location = new System.Drawing.Point(3, 238);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(283, 195);
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // layoutRegister
            // 
            this.layoutRegister.BackColor = System.Drawing.Color.Snow;
            this.layoutRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.layoutRegister.ColumnCount = 4;
            this.layoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58736F));
            this.layoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.42007F));
            this.layoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.03922F));
            this.layoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.layoutRegister.Controls.Add(this.btnBack, 0, 2);
            this.layoutRegister.Controls.Add(this.pbCustomerSignUp, 2, 1);
            this.layoutRegister.Controls.Add(this.lblCustomer, 2, 0);
            this.layoutRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRegister.Location = new System.Drawing.Point(289, 0);
            this.layoutRegister.Name = "layoutRegister";
            this.layoutRegister.RowCount = 4;
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.69721F));
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.42038F));
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8896F));
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutRegister.Size = new System.Drawing.Size(821, 533);
            this.layoutRegister.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 24;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.FillColor2 = System.Drawing.Color.DarkMagenta;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(3, 423);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 50);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbCustomerSignUp
            // 
            this.pbCustomerSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pbCustomerSignUp.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__10_;
            this.pbCustomerSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCustomerSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCustomerSignUp.Location = new System.Drawing.Point(229, 125);
            this.pbCustomerSignUp.Name = "pbCustomerSignUp";
            this.pbCustomerSignUp.Size = new System.Drawing.Size(306, 292);
            this.pbCustomerSignUp.TabIndex = 12;
            this.pbCustomerSignUp.TabStop = false;
            this.pbCustomerSignUp.Click += new System.EventHandler(this.pbCustomerSignUp_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(229, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(306, 122);
            this.lblCustomer.TabIndex = 14;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 533);
            this.Controls.Add(this.layoutRegister);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.layoutRegister.ResumeLayout(false);
            this.layoutRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerSignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel layoutRegister;
        private System.Windows.Forms.PictureBox pbCustomerSignUp;
        private System.Windows.Forms.Label lblCustomer;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
    }
}