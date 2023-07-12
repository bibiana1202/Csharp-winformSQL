namespace Secretariat_Soft.CommForms
{
    partial class SQL_Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.server_name_textBox1 = new System.Windows.Forms.TextBox();
            this.db_name_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.win_radioButton1 = new System.Windows.Forms.RadioButton();
            this.sql_radioButton2 = new System.Windows.Forms.RadioButton();
            this.user_name_textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.auth_panel1 = new System.Windows.Forms.Panel();
            this.exit_button3 = new System.Windows.Forms.Button();
            this.backup_button2 = new System.Windows.Forms.Button();
            this.test_button1 = new System.Windows.Forms.Button();
            this.prog_panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.auth_panel1.SuspendLayout();
            this.prog_panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // server_name_textBox1
            // 
            this.server_name_textBox1.Location = new System.Drawing.Point(166, 50);
            this.server_name_textBox1.Name = "server_name_textBox1";
            this.server_name_textBox1.Size = new System.Drawing.Size(207, 27);
            this.server_name_textBox1.TabIndex = 1;
            // 
            // db_name_textBox1
            // 
            this.db_name_textBox1.Location = new System.Drawing.Point(166, 94);
            this.db_name_textBox1.Name = "db_name_textBox1";
            this.db_name_textBox1.Size = new System.Drawing.Size(207, 27);
            this.db_name_textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Name:";
            // 
            // win_radioButton1
            // 
            this.win_radioButton1.AutoSize = true;
            this.win_radioButton1.Checked = true;
            this.win_radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.win_radioButton1.Location = new System.Drawing.Point(166, 158);
            this.win_radioButton1.Name = "win_radioButton1";
            this.win_radioButton1.Size = new System.Drawing.Size(192, 24);
            this.win_radioButton1.TabIndex = 4;
            this.win_radioButton1.TabStop = true;
            this.win_radioButton1.Text = "Windows Authentication";
            this.win_radioButton1.UseVisualStyleBackColor = true;
            // 
            // sql_radioButton2
            // 
            this.sql_radioButton2.AutoSize = true;
            this.sql_radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sql_radioButton2.Location = new System.Drawing.Point(166, 191);
            this.sql_radioButton2.Name = "sql_radioButton2";
            this.sql_radioButton2.Size = new System.Drawing.Size(202, 24);
            this.sql_radioButton2.TabIndex = 5;
            this.sql_radioButton2.Text = "SQL Server Authentication";
            this.sql_radioButton2.UseVisualStyleBackColor = true;
            this.sql_radioButton2.CheckedChanged += new System.EventHandler(this.sql_radioButton2_CheckedChanged);
            // 
            // user_name_textBox2
            // 
            this.user_name_textBox2.Location = new System.Drawing.Point(113, 12);
            this.user_name_textBox2.Name = "user_name_textBox2";
            this.user_name_textBox2.Size = new System.Drawing.Size(174, 27);
            this.user_name_textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name:";
            // 
            // pass_textBox3
            // 
            this.pass_textBox3.Location = new System.Drawing.Point(113, 50);
            this.pass_textBox3.Name = "pass_textBox3";
            this.pass_textBox3.PasswordChar = 'X';
            this.pass_textBox3.Size = new System.Drawing.Size(174, 27);
            this.pass_textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // auth_panel1
            // 
            this.auth_panel1.Controls.Add(this.pass_textBox3);
            this.auth_panel1.Controls.Add(this.label4);
            this.auth_panel1.Controls.Add(this.user_name_textBox2);
            this.auth_panel1.Controls.Add(this.label3);
            this.auth_panel1.Location = new System.Drawing.Point(58, 227);
            this.auth_panel1.Name = "auth_panel1";
            this.auth_panel1.Size = new System.Drawing.Size(315, 106);
            this.auth_panel1.TabIndex = 10;
            this.auth_panel1.Visible = false;
            // 
            // exit_button3
            // 
            this.exit_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button3.Image = global::Secretariat_Soft.Properties.Resources.bk_exit;
            this.exit_button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_button3.Location = new System.Drawing.Point(377, 375);
            this.exit_button3.Name = "exit_button3";
            this.exit_button3.Size = new System.Drawing.Size(85, 47);
            this.exit_button3.TabIndex = 12;
            this.exit_button3.Text = "Exit";
            this.exit_button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_button3.UseVisualStyleBackColor = true;
            this.exit_button3.Click += new System.EventHandler(this.exit_button3_Click);
            // 
            // backup_button2
            // 
            this.backup_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup_button2.Image = global::Secretariat_Soft.Properties.Resources.de_save_butt;
            this.backup_button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backup_button2.Location = new System.Drawing.Point(27, 375);
            this.backup_button2.Name = "backup_button2";
            this.backup_button2.Size = new System.Drawing.Size(126, 47);
            this.backup_button2.TabIndex = 11;
            this.backup_button2.Text = "Save && Exit";
            this.backup_button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backup_button2.UseVisualStyleBackColor = true;
            this.backup_button2.Click += new System.EventHandler(this.backup_button2_Click);
            // 
            // test_button1
            // 
            this.test_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_button1.Image = global::Secretariat_Soft.Properties.Resources.globe_01_32;
            this.test_button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.test_button1.Location = new System.Drawing.Point(171, 375);
            this.test_button1.Name = "test_button1";
            this.test_button1.Size = new System.Drawing.Size(155, 47);
            this.test_button1.TabIndex = 13;
            this.test_button1.Text = "Test Connection";
            this.test_button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.test_button1.UseVisualStyleBackColor = true;
            this.test_button1.Click += new System.EventHandler(this.test_button1_Click);
            // 
            // prog_panel4
            // 
            this.prog_panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.prog_panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prog_panel4.Controls.Add(this.label8);
            this.prog_panel4.Controls.Add(this.label7);
            this.prog_panel4.Location = new System.Drawing.Point(108, 152);
            this.prog_panel4.Name = "prog_panel4";
            this.prog_panel4.Size = new System.Drawing.Size(250, 125);
            this.prog_panel4.TabIndex = 14;
            this.prog_panel4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Testing the connection...";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(30, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 1);
            this.panel1.TabIndex = 15;
            // 
            // SQL_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(498, 439);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prog_panel4);
            this.Controls.Add(this.test_button1);
            this.Controls.Add(this.exit_button3);
            this.Controls.Add(this.backup_button2);
            this.Controls.Add(this.auth_panel1);
            this.Controls.Add(this.sql_radioButton2);
            this.Controls.Add(this.win_radioButton1);
            this.Controls.Add(this.db_name_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.server_name_textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SQL_Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server Settings";
            this.Load += new System.EventHandler(this.SQL_Settings_Load);
            this.auth_panel1.ResumeLayout(false);
            this.auth_panel1.PerformLayout();
            this.prog_panel4.ResumeLayout(false);
            this.prog_panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox server_name_textBox1;
        private TextBox db_name_textBox1;
        private Label label2;
        private RadioButton win_radioButton1;
        private RadioButton sql_radioButton2;
        private TextBox user_name_textBox2;
        private Label label3;
        private TextBox pass_textBox3;
        private Label label4;
        private Panel auth_panel1;
        private Button exit_button3;
        private Button backup_button2;
        private Button test_button1;
        private Panel prog_panel4;
        private Label label8;
        private Label label7;
        private Panel panel1;
    }
}