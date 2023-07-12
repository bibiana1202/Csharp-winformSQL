namespace Secretariat_Soft.CommForms
{
    partial class LoginFrm
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
            this.components = new System.ComponentModel.Container();
            this.ok_button1 = new System.Windows.Forms.Button();
            this.cancel_button2 = new System.Windows.Forms.Button();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appusers_bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.letters1 = new Secretariat_Soft.Ds.Letters();
            this.user_name_comboBox1 = new System.Windows.Forms.ComboBox();
            this.user_pass_textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appUsersTableAdapter1 = new Secretariat_Soft.Ds.LettersTableAdapters.AppUsersTableAdapter();
            this.id_label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correct_textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sett_button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appusers_bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letters1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok_button1
            // 
            this.ok_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_button1.Location = new System.Drawing.Point(231, 250);
            this.ok_button1.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button1.Name = "ok_button1";
            this.ok_button1.Size = new System.Drawing.Size(163, 33);
            this.ok_button1.TabIndex = 0;
            this.ok_button1.Text = "Ok ( Enter )";
            this.ok_button1.UseVisualStyleBackColor = true;
            this.ok_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_button2
            // 
            this.cancel_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button2.Image = global::Secretariat_Soft.Properties.Resources.bk_exit;
            this.cancel_button2.Location = new System.Drawing.Point(503, 288);
            this.cancel_button2.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_button2.Name = "cancel_button2";
            this.cancel_button2.Size = new System.Drawing.Size(53, 44);
            this.cancel_button2.TabIndex = 1;
            this.cancel_button2.UseVisualStyleBackColor = true;
            this.cancel_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_pictureBox1
            // 
            this.user_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.appusers_bindingSource1, "Photo", true));
            this.user_pictureBox1.Location = new System.Drawing.Point(231, 13);
            this.user_pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(117, 122);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pictureBox1.TabIndex = 87;
            this.user_pictureBox1.TabStop = false;
            // 
            // appusers_bindingSource1
            // 
            this.appusers_bindingSource1.DataMember = "AppUsers";
            this.appusers_bindingSource1.DataSource = this.letters1;
            // 
            // letters1
            // 
            this.letters1.DataSetName = "Letters";
            this.letters1.Namespace = "http://tempuri.org/Letters.xsd";
            this.letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_name_comboBox1
            // 
            this.user_name_comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_name_comboBox1.DataSource = this.appusers_bindingSource1;
            this.user_name_comboBox1.DisplayMember = "User_Name";
            this.user_name_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_name_comboBox1.FormattingEnabled = true;
            this.user_name_comboBox1.Location = new System.Drawing.Point(87, 21);
            this.user_name_comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.user_name_comboBox1.Name = "user_name_comboBox1";
            this.user_name_comboBox1.Size = new System.Drawing.Size(163, 28);
            this.user_name_comboBox1.TabIndex = 88;
            // 
            // user_pass_textBox2
            // 
            this.user_pass_textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_pass_textBox2.Location = new System.Drawing.Point(87, 59);
            this.user_pass_textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.user_pass_textBox2.MaxLength = 10;
            this.user_pass_textBox2.Name = "user_pass_textBox2";
            this.user_pass_textBox2.PasswordChar = '*';
            this.user_pass_textBox2.Size = new System.Drawing.Size(163, 34);
            this.user_pass_textBox2.TabIndex = 90;
            this.user_pass_textBox2.Text = "111";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "User:";
            // 
            // appUsersTableAdapter1
            // 
            this.appUsersTableAdapter1.ClearBeforeFill = true;
            // 
            // id_label21
            // 
            this.id_label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_label21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appusers_bindingSource1, "id", true));
            this.id_label21.Location = new System.Drawing.Point(764, 37);
            this.id_label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label21.Name = "id_label21";
            this.id_label21.Size = new System.Drawing.Size(56, 29);
            this.id_label21.TabIndex = 94;
            this.id_label21.Text = "-";
            this.id_label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "User ID:";
            // 
            // correct_textBox1
            // 
            this.correct_textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appusers_bindingSource1, "Password", true));
            this.correct_textBox1.Location = new System.Drawing.Point(764, 80);
            this.correct_textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.correct_textBox1.Name = "correct_textBox1";
            this.correct_textBox1.ReadOnly = true;
            this.correct_textBox1.Size = new System.Drawing.Size(56, 27);
            this.correct_textBox1.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Password:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.user_pass_textBox2);
            this.panel2.Controls.Add(this.user_name_comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(143, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 153);
            this.panel2.TabIndex = 97;
            // 
            // sett_button1
            // 
            this.sett_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sett_button1.Image = global::Secretariat_Soft.Properties.Resources.settings;
            this.sett_button1.Location = new System.Drawing.Point(-3, 1);
            this.sett_button1.Margin = new System.Windows.Forms.Padding(2);
            this.sett_button1.Name = "sett_button1";
            this.sett_button1.Size = new System.Drawing.Size(38, 38);
            this.sett_button1.TabIndex = 98;
            this.sett_button1.UseVisualStyleBackColor = true;
            this.sett_button1.Click += new System.EventHandler(this.sett_button1_Click);
            // 
            // LoginFrm
            // 
            this.AcceptButton = this.ok_button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Secretariat_Soft.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancel_button2;
            this.ClientSize = new System.Drawing.Size(565, 336);
            this.ControlBox = false;
            this.Controls.Add(this.ok_button1);
            this.Controls.Add(this.sett_button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.correct_textBox1);
            this.Controls.Add(this.user_pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_label21);
            this.Controls.Add(this.cancel_button2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appusers_bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letters1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ok_button1;
        private Button cancel_button2;
        private TextBox user_pass_textBox2;
        private Label label9;
        private Label label1;
        private BindingSource appusers_bindingSource1;
        private Ds.LettersTableAdapters.AppUsersTableAdapter appUsersTableAdapter1;
        private Label label2;
        private TextBox correct_textBox1;
        private Label label3;
        public PictureBox user_pictureBox1;
        public ComboBox user_name_comboBox1;
        public Label id_label21;
        public Ds.Letters letters1;
        private Panel panel2;
        private Button sett_button1;
    }
}