namespace Secretariat_Soft.CommForms
{
    partial class UserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Top_Toolstrip = new System.Windows.Forms.ToolStrip();
            this.add_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sysUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appusers_bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.letters1 = new Secretariat_Soft.Ds.Letters();
            this.appUsersTableAdapter1 = new Secretariat_Soft.Ds.LettersTableAdapters.AppUsersTableAdapter();
            this.id_label5 = new System.Windows.Forms.Label();
            this.Top_Toolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appusers_bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letters1)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_Toolstrip
            // 
            this.Top_Toolstrip.AutoSize = false;
            this.Top_Toolstrip.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.Top_Toolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Top_Toolstrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Top_Toolstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Top_Toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_butt,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.Top_Toolstrip.Location = new System.Drawing.Point(0, 0);
            this.Top_Toolstrip.Name = "Top_Toolstrip";
            this.Top_Toolstrip.Size = new System.Drawing.Size(651, 61);
            this.Top_Toolstrip.TabIndex = 1;
            this.Top_Toolstrip.Text = "toolStrip1";
            // 
            // add_butt
            // 
            this.add_butt.Image = global::Secretariat_Soft.Properties.Resources.butt_edit_32;
            this.add_butt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_butt.Name = "add_butt";
            this.add_butt.Size = new System.Drawing.Size(146, 58);
            this.add_butt.Text = "Add | Edit Users F2";
            this.add_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add_butt.Click += new System.EventHandler(this.add_butt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 61);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.sysUserDataGridViewTextBoxColumn,
            this.sysUserIdDataGridViewTextBoxColumn,
            this.sysDateDataGridViewTextBoxColumn,
            this.sysTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appusers_bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.Size = new System.Drawing.Size(634, 358);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photoDataGridViewImageColumn.MinimumWidth = 6;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            this.photoDataGridViewImageColumn.Width = 90;
            // 
            // sysUserDataGridViewTextBoxColumn
            // 
            this.sysUserDataGridViewTextBoxColumn.DataPropertyName = "Sys_User";
            this.sysUserDataGridViewTextBoxColumn.HeaderText = "Sys User";
            this.sysUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sysUserDataGridViewTextBoxColumn.Name = "sysUserDataGridViewTextBoxColumn";
            this.sysUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.sysUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // sysUserIdDataGridViewTextBoxColumn
            // 
            this.sysUserIdDataGridViewTextBoxColumn.DataPropertyName = "Sys_UserId";
            this.sysUserIdDataGridViewTextBoxColumn.HeaderText = "Sys User Id";
            this.sysUserIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sysUserIdDataGridViewTextBoxColumn.Name = "sysUserIdDataGridViewTextBoxColumn";
            this.sysUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sysUserIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sysDateDataGridViewTextBoxColumn
            // 
            this.sysDateDataGridViewTextBoxColumn.DataPropertyName = "SysDate";
            this.sysDateDataGridViewTextBoxColumn.HeaderText = "Sys Date";
            this.sysDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sysDateDataGridViewTextBoxColumn.Name = "sysDateDataGridViewTextBoxColumn";
            this.sysDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sysDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sysTimeDataGridViewTextBoxColumn
            // 
            this.sysTimeDataGridViewTextBoxColumn.DataPropertyName = "SysTime";
            this.sysTimeDataGridViewTextBoxColumn.HeaderText = "Sys Time";
            this.sysTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sysTimeDataGridViewTextBoxColumn.Name = "sysTimeDataGridViewTextBoxColumn";
            this.sysTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sysTimeDataGridViewTextBoxColumn.Width = 125;
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
            // appUsersTableAdapter1
            // 
            this.appUsersTableAdapter1.ClearBeforeFill = true;
            // 
            // id_label5
            // 
            this.id_label5.AutoSize = true;
            this.id_label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appusers_bindingSource1, "id", true));
            this.id_label5.Location = new System.Drawing.Point(691, 107);
            this.id_label5.Name = "id_label5";
            this.id_label5.Size = new System.Drawing.Size(50, 20);
            this.id_label5.TabIndex = 6;
            this.id_label5.Text = "label5";
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(651, 434);
            this.Controls.Add(this.id_label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Top_Toolstrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User List";
            this.Load += new System.EventHandler(this.UserList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserList_KeyDown);
            this.Top_Toolstrip.ResumeLayout(false);
            this.Top_Toolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appusers_bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letters1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip Top_Toolstrip;
        private ToolStripButton add_butt;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridView dataGridView1;
        private BindingSource appusers_bindingSource1;
        private Ds.Letters letters1;
        private Ds.LettersTableAdapters.AppUsersTableAdapter appUsersTableAdapter1;
        private Label id_label5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewImageColumn photoDataGridViewImageColumn;
        private DataGridViewTextBoxColumn sysUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sysUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sysDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sysTimeDataGridViewTextBoxColumn;
    }
}