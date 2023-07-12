namespace Secretariat_Soft.CommForms
{
    partial class About_Us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Us));
            this.product_name_label1 = new System.Windows.Forms.Label();
            this.Company_Name_label1 = new System.Windows.Forms.Label();
            this.version_label1 = new System.Windows.Forms.Label();
            this.copy_right_label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // product_name_label1
            // 
            this.product_name_label1.BackColor = System.Drawing.Color.Transparent;
            this.product_name_label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.product_name_label1.Location = new System.Drawing.Point(12, 57);
            this.product_name_label1.Name = "product_name_label1";
            this.product_name_label1.Size = new System.Drawing.Size(385, 33);
            this.product_name_label1.TabIndex = 0;
            this.product_name_label1.Text = "Product Name";
            this.product_name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Company_Name_label1
            // 
            this.Company_Name_label1.BackColor = System.Drawing.Color.Transparent;
            this.Company_Name_label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Company_Name_label1.Location = new System.Drawing.Point(12, 14);
            this.Company_Name_label1.Name = "Company_Name_label1";
            this.Company_Name_label1.Size = new System.Drawing.Size(385, 33);
            this.Company_Name_label1.TabIndex = 1;
            this.Company_Name_label1.Text = "Company Name";
            this.Company_Name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // version_label1
            // 
            this.version_label1.BackColor = System.Drawing.Color.Transparent;
            this.version_label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.version_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.version_label1.Location = new System.Drawing.Point(12, 104);
            this.version_label1.Name = "version_label1";
            this.version_label1.Size = new System.Drawing.Size(385, 33);
            this.version_label1.TabIndex = 2;
            this.version_label1.Text = "Version";
            this.version_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copy_right_label1
            // 
            this.copy_right_label1.BackColor = System.Drawing.Color.Transparent;
            this.copy_right_label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copy_right_label1.Location = new System.Drawing.Point(12, 280);
            this.copy_right_label1.Name = "copy_right_label1";
            this.copy_right_label1.Size = new System.Drawing.Size(385, 33);
            this.copy_right_label1.TabIndex = 3;
            this.copy_right_label1.Text = "Copy Right";
            this.copy_right_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-15, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 1);
            this.panel1.TabIndex = 4;
            // 
            // About_Us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.copy_right_label1);
            this.Controls.Add(this.version_label1);
            this.Controls.Add(this.Company_Name_label1);
            this.Controls.Add(this.product_name_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About_Us";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.Load += new System.EventHandler(this.About_Us_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label product_name_label1;
        private Label Company_Name_label1;
        private Label version_label1;
        private Label copy_right_label1;
        private Panel panel1;
    }
}