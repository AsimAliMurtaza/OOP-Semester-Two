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
            this.btnBack = new System.Windows.Forms.Button();
            this.pbAdminSignUp = new System.Windows.Forms.PictureBox();
            this.pbCustomerSignUp = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.layoutRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Brown;
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
            this.lblHeader.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.layoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.78036F));
            this.layoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.30809F));
            this.layoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.99656F));
            this.layoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.layoutRegister.Controls.Add(this.btnBack, 0, 2);
            this.layoutRegister.Controls.Add(this.pbAdminSignUp, 1, 1);
            this.layoutRegister.Controls.Add(this.pbCustomerSignUp, 2, 1);
            this.layoutRegister.Controls.Add(this.lblAdmin, 1, 0);
            this.layoutRegister.Controls.Add(this.lblCustomer, 2, 0);
            this.layoutRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRegister.Location = new System.Drawing.Point(289, 0);
            this.layoutRegister.Name = "layoutRegister";
            this.layoutRegister.RowCount = 3;
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.69721F));
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.9761F));
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12749F));
            this.layoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutRegister.Size = new System.Drawing.Size(821, 533);
            this.layoutRegister.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__6_;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(3, 438);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 86);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbAdminSignUp
            // 
            this.pbAdminSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pbAdminSignUp.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__11_;
            this.pbAdminSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAdminSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAdminSignUp.Location = new System.Drawing.Point(121, 140);
            this.pbAdminSignUp.Name = "pbAdminSignUp";
            this.pbAdminSignUp.Size = new System.Drawing.Size(285, 292);
            this.pbAdminSignUp.TabIndex = 11;
            this.pbAdminSignUp.TabStop = false;
            this.pbAdminSignUp.Click += new System.EventHandler(this.pbAdminSignUp_Click);
            // 
            // pbCustomerSignUp
            // 
            this.pbCustomerSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pbCustomerSignUp.BackgroundImage = global::BusinessApp.Properties.Resources.image_removebg_preview__10_;
            this.pbCustomerSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCustomerSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCustomerSignUp.Location = new System.Drawing.Point(412, 140);
            this.pbCustomerSignUp.Name = "pbCustomerSignUp";
            this.pbCustomerSignUp.Size = new System.Drawing.Size(290, 292);
            this.pbCustomerSignUp.TabIndex = 12;
            this.pbCustomerSignUp.TabStop = false;
            this.pbCustomerSignUp.Click += new System.EventHandler(this.pbCustomerSignUp_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdmin.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(121, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(285, 137);
            this.lblAdmin.TabIndex = 13;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Font = new System.Drawing.Font("Berlin Sans FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(412, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(290, 137);
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
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.layoutRegister.ResumeLayout(false);
            this.layoutRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerSignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel layoutRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbAdminSignUp;
        private System.Windows.Forms.PictureBox pbCustomerSignUp;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblCustomer;
    }
}