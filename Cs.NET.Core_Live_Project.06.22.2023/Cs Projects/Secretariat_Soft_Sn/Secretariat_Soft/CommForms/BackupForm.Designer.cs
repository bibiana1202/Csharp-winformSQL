namespace Secretariat_Soft.CommForms
{
    partial class BackupForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.browse_button1 = new System.Windows.Forms.Button();
            this.file_name_textBox1 = new System.Windows.Forms.TextBox();
            this.backup_button2 = new System.Windows.Forms.Button();
            this.exit_button3 = new System.Windows.Forms.Button();
            this.help_button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.prog_panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.prog_panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 137);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(496, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "4. In any coditions the responsibility for the loss of data is at your own risk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "3. Be sure to back up the data at different times";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. No error should be displayed when backing up. An error means no backups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Be sure to see a message of success after the backup, if not there is a proble" +
    "m.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consider the following while backing up:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 39);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(546, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Warning: Before changing Windows , copy the installation folder and keep it safe." +
    "";
            // 
            // browse_button1
            // 
            this.browse_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse_button1.Location = new System.Drawing.Point(27, 191);
            this.browse_button1.Name = "browse_button1";
            this.browse_button1.Size = new System.Drawing.Size(94, 29);
            this.browse_button1.TabIndex = 2;
            this.browse_button1.Text = "Browse";
            this.browse_button1.UseVisualStyleBackColor = true;
            this.browse_button1.Click += new System.EventHandler(this.browse_button1_Click);
            // 
            // file_name_textBox1
            // 
            this.file_name_textBox1.Location = new System.Drawing.Point(127, 191);
            this.file_name_textBox1.Name = "file_name_textBox1";
            this.file_name_textBox1.ReadOnly = true;
            this.file_name_textBox1.Size = new System.Drawing.Size(476, 27);
            this.file_name_textBox1.TabIndex = 3;
            // 
            // backup_button2
            // 
            this.backup_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup_button2.Image = global::Secretariat_Soft.Properties.Resources.bk_database_32;
            this.backup_button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backup_button2.Location = new System.Drawing.Point(27, 249);
            this.backup_button2.Name = "backup_button2";
            this.backup_button2.Size = new System.Drawing.Size(126, 47);
            this.backup_button2.TabIndex = 4;
            this.backup_button2.Text = "Backup";
            this.backup_button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backup_button2.UseVisualStyleBackColor = true;
            this.backup_button2.Click += new System.EventHandler(this.backup_button2_Click);
            // 
            // exit_button3
            // 
            this.exit_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button3.Image = global::Secretariat_Soft.Properties.Resources.bk_exit;
            this.exit_button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_button3.Location = new System.Drawing.Point(159, 249);
            this.exit_button3.Name = "exit_button3";
            this.exit_button3.Size = new System.Drawing.Size(85, 47);
            this.exit_button3.TabIndex = 5;
            this.exit_button3.Text = "Exit";
            this.exit_button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_button3.UseVisualStyleBackColor = true;
            this.exit_button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // help_button4
            // 
            this.help_button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_button4.Image = global::Secretariat_Soft.Properties.Resources.bk_Help_2_32;
            this.help_button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help_button4.Location = new System.Drawing.Point(514, 249);
            this.help_button4.Name = "help_button4";
            this.help_button4.Size = new System.Drawing.Size(89, 47);
            this.help_button4.TabIndex = 6;
            this.help_button4.Text = "Help";
            this.help_button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help_button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(6, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 1);
            this.panel3.TabIndex = 7;
            // 
            // prog_panel4
            // 
            this.prog_panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.prog_panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prog_panel4.Controls.Add(this.label8);
            this.prog_panel4.Controls.Add(this.label7);
            this.prog_panel4.Location = new System.Drawing.Point(208, 100);
            this.prog_panel4.Name = "prog_panel4";
            this.prog_panel4.Size = new System.Drawing.Size(250, 125);
            this.prog_panel4.TabIndex = 8;
            this.prog_panel4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Backing up the data...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(52, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Please Wait...";
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(630, 315);
            this.ControlBox = false;
            this.Controls.Add(this.prog_panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.help_button4);
            this.Controls.Add(this.exit_button3);
            this.Controls.Add(this.backup_button2);
            this.Controls.Add(this.file_name_textBox1);
            this.Controls.Add(this.browse_button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bacakup Data";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.prog_panel4.ResumeLayout(false);
            this.prog_panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button browse_button1;
        private TextBox file_name_textBox1;
        private Button backup_button2;
        private Button exit_button3;
        private Button help_button4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Panel panel3;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel prog_panel4;
        private Label label8;
        private Label label7;
    }
}