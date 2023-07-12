namespace Secretariat_Soft.CommForms
{
    partial class RestoreForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit_button3 = new System.Windows.Forms.Button();
            this.restore_button2 = new System.Windows.Forms.Button();
            this.file_name_textBox1 = new System.Windows.Forms.TextBox();
            this.browse_button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prog_panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.prog_panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit_button3);
            this.groupBox1.Controls.Add(this.restore_button2);
            this.groupBox1.Controls.Add(this.file_name_textBox1);
            this.groupBox1.Controls.Add(this.browse_button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // exit_button3
            // 
            this.exit_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button3.Image = global::Secretariat_Soft.Properties.Resources.bk_exit;
            this.exit_button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_button3.Location = new System.Drawing.Point(467, 117);
            this.exit_button3.Name = "exit_button3";
            this.exit_button3.Size = new System.Drawing.Size(85, 47);
            this.exit_button3.TabIndex = 9;
            this.exit_button3.Text = "Exit";
            this.exit_button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_button3.UseVisualStyleBackColor = true;
            this.exit_button3.Click += new System.EventHandler(this.exit_button3_Click);
            // 
            // restore_button2
            // 
            this.restore_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restore_button2.Image = global::Secretariat_Soft.Properties.Resources.bk_database_32;
            this.restore_button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restore_button2.Location = new System.Drawing.Point(102, 117);
            this.restore_button2.Name = "restore_button2";
            this.restore_button2.Size = new System.Drawing.Size(134, 47);
            this.restore_button2.TabIndex = 8;
            this.restore_button2.Text = "Start Restore";
            this.restore_button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restore_button2.UseVisualStyleBackColor = true;
            this.restore_button2.Click += new System.EventHandler(this.restore_button2_Click);
            // 
            // file_name_textBox1
            // 
            this.file_name_textBox1.Location = new System.Drawing.Point(99, 48);
            this.file_name_textBox1.Name = "file_name_textBox1";
            this.file_name_textBox1.ReadOnly = true;
            this.file_name_textBox1.Size = new System.Drawing.Size(457, 27);
            this.file_name_textBox1.TabIndex = 7;
            // 
            // browse_button1
            // 
            this.browse_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse_button1.Location = new System.Drawing.Point(13, 47);
            this.browse_button1.Name = "browse_button1";
            this.browse_button1.Size = new System.Drawing.Size(79, 29);
            this.browse_button1.TabIndex = 6;
            this.browse_button1.Text = "Browse";
            this.browse_button1.UseVisualStyleBackColor = true;
            this.browse_button1.Click += new System.EventHandler(this.browse_button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 62);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. No error should be displayed when backing up. An error means no backups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Be sure to see a message of success after the backup, if not there is a proble" +
    "m.";
            // 
            // prog_panel4
            // 
            this.prog_panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.prog_panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prog_panel4.Controls.Add(this.label8);
            this.prog_panel4.Controls.Add(this.label7);
            this.prog_panel4.Location = new System.Drawing.Point(175, 48);
            this.prog_panel4.Name = "prog_panel4";
            this.prog_panel4.Size = new System.Drawing.Size(250, 125);
            this.prog_panel4.TabIndex = 11;
            this.prog_panel4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Restoring the data...";
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
            // RestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(592, 231);
            this.ControlBox = false;
            this.Controls.Add(this.prog_panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestoreForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.prog_panel4.ResumeLayout(false);
            this.prog_panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button exit_button3;
        private Button restore_button2;
        private TextBox file_name_textBox1;
        private Button browse_button1;
        private Panel prog_panel4;
        private Label label8;
        private Label label7;
    }
}