namespace Secretariat_Soft.S_Forms
{
    partial class In_Letters_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Top_Toolstrip = new System.Windows.Forms.ToolStrip();
            this.add_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.print_butt = new System.Windows.Forms.ToolStripDropDownButton();
            this.incomingLettersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomingLetersDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.search_butt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Bottom_Toolstrip = new System.Windows.Forms.ToolStrip();
            this.First_butt = new System.Windows.Forms.ToolStripButton();
            this.prev_butt = new System.Windows.Forms.ToolStripButton();
            this.position_tbox = new System.Windows.Forms.ToolStripTextBox();
            this.total_records_lbl = new System.Windows.Forms.ToolStripLabel();
            this.next_butt = new System.Windows.Forms.ToolStripButton();
            this.last_butt = new System.Windows.Forms.ToolStripButton();
            this.in_letters_bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.letters1 = new Secretariat_Soft.Ds.Letters();
            this.sa_In_LettersTableAdapter1 = new Secretariat_Soft.Ds.LettersTableAdapters.Sa_In_LettersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letterNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letterTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letterTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docSummaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SysTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_panel2 = new System.Windows.Forms.Panel();
            this.date_search_button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.second_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.first_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.subject_search_butt = new System.Windows.Forms.Button();
            this.subject_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search_id_butt = new System.Windows.Forms.Button();
            this.id_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_panel1 = new System.Windows.Forms.Panel();
            this.id_label5 = new System.Windows.Forms.Label();
            this.Top_Toolstrip.SuspendLayout();
            this.Bottom_Toolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_letters_bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letters1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.search_panel2.SuspendLayout();
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
            this.toolStripSeparator2,
            this.print_butt,
            this.toolStripSeparator4,
            this.search_butt,
            this.toolStripSeparator3});
            this.Top_Toolstrip.Location = new System.Drawing.Point(0, 0);
            this.Top_Toolstrip.Name = "Top_Toolstrip";
            this.Top_Toolstrip.Size = new System.Drawing.Size(932, 61);
            this.Top_Toolstrip.TabIndex = 0;
            this.Top_Toolstrip.Text = "toolStrip1";
            // 
            // add_butt
            // 
            this.add_butt.Image = global::Secretariat_Soft.Properties.Resources.butt_edit_32;
            this.add_butt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_butt.Name = "add_butt";
            this.add_butt.Size = new System.Drawing.Size(180, 58);
            this.add_butt.Text = "Add | Edit Document F2";
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
            // print_butt
            // 
            this.print_butt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.print_butt.AutoSize = false;
            this.print_butt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomingLettersListToolStripMenuItem,
            this.incomingLetersDetailsToolStripMenuItem});
            this.print_butt.Image = global::Secretariat_Soft.Properties.Resources.butt_print_32;
            this.print_butt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.print_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_butt.Name = "print_butt";
            this.print_butt.Size = new System.Drawing.Size(90, 58);
            this.print_butt.Text = "Print F4";
            this.print_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.print_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.print_butt.Click += new System.EventHandler(this.print_butt_Click);
            // 
            // incomingLettersListToolStripMenuItem
            // 
            this.incomingLettersListToolStripMenuItem.Name = "incomingLettersListToolStripMenuItem";
            this.incomingLettersListToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.incomingLettersListToolStripMenuItem.Text = "Incoming Letters List";
            this.incomingLettersListToolStripMenuItem.Click += new System.EventHandler(this.incomingLettersListToolStripMenuItem_Click);
            // 
            // incomingLetersDetailsToolStripMenuItem
            // 
            this.incomingLetersDetailsToolStripMenuItem.Name = "incomingLetersDetailsToolStripMenuItem";
            this.incomingLetersDetailsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.incomingLetersDetailsToolStripMenuItem.Text = "Incoming Leters Details";
            this.incomingLetersDetailsToolStripMenuItem.Click += new System.EventHandler(this.incomingLetersDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 61);
            // 
            // search_butt
            // 
            this.search_butt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.search_butt.AutoSize = false;
            this.search_butt.Image = global::Secretariat_Soft.Properties.Resources.butt_search_32;
            this.search_butt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.search_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search_butt.Name = "search_butt";
            this.search_butt.Size = new System.Drawing.Size(100, 58);
            this.search_butt.Text = "Search F3";
            this.search_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.search_butt.Click += new System.EventHandler(this.search_butt_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 61);
            // 
            // Bottom_Toolstrip
            // 
            this.Bottom_Toolstrip.AutoSize = false;
            this.Bottom_Toolstrip.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.Bottom_Toolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bottom_Toolstrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Toolstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Bottom_Toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.First_butt,
            this.prev_butt,
            this.position_tbox,
            this.total_records_lbl,
            this.next_butt,
            this.last_butt});
            this.Bottom_Toolstrip.Location = new System.Drawing.Point(0, 470);
            this.Bottom_Toolstrip.Name = "Bottom_Toolstrip";
            this.Bottom_Toolstrip.Size = new System.Drawing.Size(932, 36);
            this.Bottom_Toolstrip.TabIndex = 1;
            this.Bottom_Toolstrip.Text = "toolStrip2";
            // 
            // First_butt
            // 
            this.First_butt.AutoSize = false;
            this.First_butt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.First_butt.Image = global::Secretariat_Soft.Properties.Resources.nav_first;
            this.First_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.First_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.First_butt.Name = "First_butt";
            this.First_butt.Size = new System.Drawing.Size(32, 32);
            this.First_butt.Text = "toolStripButton1";
            this.First_butt.Click += new System.EventHandler(this.First_butt_Click);
            // 
            // prev_butt
            // 
            this.prev_butt.AutoSize = false;
            this.prev_butt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prev_butt.Image = global::Secretariat_Soft.Properties.Resources.nav_previous;
            this.prev_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prev_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prev_butt.Name = "prev_butt";
            this.prev_butt.Size = new System.Drawing.Size(32, 32);
            this.prev_butt.Text = "toolStripButton1";
            this.prev_butt.Click += new System.EventHandler(this.prev_butt_Click);
            // 
            // position_tbox
            // 
            this.position_tbox.Name = "position_tbox";
            this.position_tbox.Size = new System.Drawing.Size(50, 36);
            this.position_tbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_records_lbl
            // 
            this.total_records_lbl.Name = "total_records_lbl";
            this.total_records_lbl.Size = new System.Drawing.Size(17, 33);
            this.total_records_lbl.Text = "0";
            // 
            // next_butt
            // 
            this.next_butt.AutoSize = false;
            this.next_butt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.next_butt.Image = global::Secretariat_Soft.Properties.Resources.nav_next;
            this.next_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.next_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.next_butt.Name = "next_butt";
            this.next_butt.Size = new System.Drawing.Size(32, 32);
            this.next_butt.Text = "toolStripButton1";
            this.next_butt.Click += new System.EventHandler(this.next_butt_Click);
            // 
            // last_butt
            // 
            this.last_butt.AutoSize = false;
            this.last_butt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.last_butt.Image = global::Secretariat_Soft.Properties.Resources.nav_last;
            this.last_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.last_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.last_butt.Name = "last_butt";
            this.last_butt.Size = new System.Drawing.Size(32, 32);
            this.last_butt.Text = "toolStripButton1";
            this.last_butt.Click += new System.EventHandler(this.last_butt_Click);
            // 
            // in_letters_bindingSource1
            // 
            this.in_letters_bindingSource1.DataMember = "Sa_In_Letters";
            this.in_letters_bindingSource1.DataSource = this.letters1;
            // 
            // letters1
            // 
            this.letters1.DataSetName = "Letters";
            this.letters1.Namespace = "http://tempuri.org/Letters.xsd";
            this.letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sa_In_LettersTableAdapter1
            // 
            this.sa_In_LettersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.letterNumberDataGridViewTextBoxColumn,
            this.letterTimeDataGridViewTextBoxColumn,
            this.receiveDateDataGridViewTextBoxColumn,
            this.letterTypeDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.recipientDataGridViewTextBoxColumn,
            this.receiveMethodDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.pageCountDataGridViewTextBoxColumn,
            this.deadlineDataGridViewTextBoxColumn,
            this.refDocDataGridViewTextBoxColumn,
            this.docSummaryDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.sysDateDataGridViewTextBoxColumn,
            this.SysTime});
            this.dataGridView1.DataSource = this.in_letters_bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(912, 403);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "RegDate";
            this.regDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            this.regDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.regDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectDataGridViewTextBoxColumn.Width = 250;
            // 
            // letterNumberDataGridViewTextBoxColumn
            // 
            this.letterNumberDataGridViewTextBoxColumn.DataPropertyName = "LetterNumber";
            this.letterNumberDataGridViewTextBoxColumn.HeaderText = "Letter Num";
            this.letterNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.letterNumberDataGridViewTextBoxColumn.Name = "letterNumberDataGridViewTextBoxColumn";
            this.letterNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.letterNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // letterTimeDataGridViewTextBoxColumn
            // 
            this.letterTimeDataGridViewTextBoxColumn.DataPropertyName = "Letter_Time";
            this.letterTimeDataGridViewTextBoxColumn.HeaderText = "Letter Time";
            this.letterTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.letterTimeDataGridViewTextBoxColumn.Name = "letterTimeDataGridViewTextBoxColumn";
            this.letterTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.letterTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiveDateDataGridViewTextBoxColumn
            // 
            this.receiveDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiveDate";
            this.receiveDateDataGridViewTextBoxColumn.HeaderText = "ReceiveDate";
            this.receiveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiveDateDataGridViewTextBoxColumn.Name = "receiveDateDataGridViewTextBoxColumn";
            this.receiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiveDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // letterTypeDataGridViewTextBoxColumn
            // 
            this.letterTypeDataGridViewTextBoxColumn.DataPropertyName = "LetterType";
            this.letterTypeDataGridViewTextBoxColumn.HeaderText = "LetterType";
            this.letterTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.letterTypeDataGridViewTextBoxColumn.Name = "letterTypeDataGridViewTextBoxColumn";
            this.letterTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.letterTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.senderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderDataGridViewTextBoxColumn.Width = 125;
            // 
            // recipientDataGridViewTextBoxColumn
            // 
            this.recipientDataGridViewTextBoxColumn.DataPropertyName = "Recipient";
            this.recipientDataGridViewTextBoxColumn.HeaderText = "Recipient";
            this.recipientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recipientDataGridViewTextBoxColumn.Name = "recipientDataGridViewTextBoxColumn";
            this.recipientDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipientDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiveMethodDataGridViewTextBoxColumn
            // 
            this.receiveMethodDataGridViewTextBoxColumn.DataPropertyName = "Receive_Method";
            this.receiveMethodDataGridViewTextBoxColumn.HeaderText = "Receive_Method";
            this.receiveMethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiveMethodDataGridViewTextBoxColumn.Name = "receiveMethodDataGridViewTextBoxColumn";
            this.receiveMethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiveMethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // pageCountDataGridViewTextBoxColumn
            // 
            this.pageCountDataGridViewTextBoxColumn.DataPropertyName = "PageCount";
            this.pageCountDataGridViewTextBoxColumn.HeaderText = "PageCount";
            this.pageCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pageCountDataGridViewTextBoxColumn.Name = "pageCountDataGridViewTextBoxColumn";
            this.pageCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.pageCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // deadlineDataGridViewTextBoxColumn
            // 
            this.deadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.HeaderText = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
            this.deadlineDataGridViewTextBoxColumn.ReadOnly = true;
            this.deadlineDataGridViewTextBoxColumn.Width = 125;
            // 
            // refDocDataGridViewTextBoxColumn
            // 
            this.refDocDataGridViewTextBoxColumn.DataPropertyName = "Ref_Doc";
            this.refDocDataGridViewTextBoxColumn.HeaderText = "Ref_Doc";
            this.refDocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refDocDataGridViewTextBoxColumn.Name = "refDocDataGridViewTextBoxColumn";
            this.refDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.refDocDataGridViewTextBoxColumn.Width = 125;
            // 
            // docSummaryDataGridViewTextBoxColumn
            // 
            this.docSummaryDataGridViewTextBoxColumn.DataPropertyName = "DocSummary";
            this.docSummaryDataGridViewTextBoxColumn.HeaderText = "DocSummary";
            this.docSummaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.docSummaryDataGridViewTextBoxColumn.Name = "docSummaryDataGridViewTextBoxColumn";
            this.docSummaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.docSummaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sysDateDataGridViewTextBoxColumn
            // 
            this.sysDateDataGridViewTextBoxColumn.DataPropertyName = "SysDate";
            this.sysDateDataGridViewTextBoxColumn.HeaderText = "SysDate";
            this.sysDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sysDateDataGridViewTextBoxColumn.Name = "sysDateDataGridViewTextBoxColumn";
            this.sysDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sysDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // SysTime
            // 
            this.SysTime.DataPropertyName = "SysTime";
            this.SysTime.HeaderText = "Sys Time";
            this.SysTime.MinimumWidth = 6;
            this.SysTime.Name = "SysTime";
            this.SysTime.ReadOnly = true;
            this.SysTime.Width = 125;
            // 
            // search_panel2
            // 
            this.search_panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.search_panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_panel2.Controls.Add(this.date_search_button1);
            this.search_panel2.Controls.Add(this.label4);
            this.search_panel2.Controls.Add(this.second_dateTimePicker2);
            this.search_panel2.Controls.Add(this.first_dateTimePicker1);
            this.search_panel2.Controls.Add(this.label3);
            this.search_panel2.Controls.Add(this.subject_search_butt);
            this.search_panel2.Controls.Add(this.subject_textBox1);
            this.search_panel2.Controls.Add(this.label2);
            this.search_panel2.Controls.Add(this.search_id_butt);
            this.search_panel2.Controls.Add(this.id_textBox1);
            this.search_panel2.Controls.Add(this.label1);
            this.search_panel2.Location = new System.Drawing.Point(435, 102);
            this.search_panel2.Name = "search_panel2";
            this.search_panel2.Size = new System.Drawing.Size(390, 226);
            this.search_panel2.TabIndex = 3;
            this.search_panel2.Visible = false;
            // 
            // date_search_button1
            // 
            this.date_search_button1.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.date_search_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.date_search_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_search_button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_search_button1.Image = global::Secretariat_Soft.Properties.Resources.butt_search2_32;
            this.date_search_button1.Location = new System.Drawing.Point(258, 140);
            this.date_search_button1.Name = "date_search_button1";
            this.date_search_button1.Size = new System.Drawing.Size(124, 40);
            this.date_search_button1.TabIndex = 12;
            this.date_search_button1.Text = "Search";
            this.date_search_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.date_search_button1.UseVisualStyleBackColor = true;
            this.date_search_button1.Click += new System.EventHandler(this.date_search_button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "To:";
            // 
            // second_dateTimePicker2
            // 
            this.second_dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.second_dateTimePicker2.Location = new System.Drawing.Point(136, 167);
            this.second_dateTimePicker2.Name = "second_dateTimePicker2";
            this.second_dateTimePicker2.Size = new System.Drawing.Size(119, 27);
            this.second_dateTimePicker2.TabIndex = 10;
            // 
            // first_dateTimePicker1
            // 
            this.first_dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.first_dateTimePicker1.Location = new System.Drawing.Point(136, 123);
            this.first_dateTimePicker1.Name = "first_dateTimePicker1";
            this.first_dateTimePicker1.Size = new System.Drawing.Size(119, 27);
            this.first_dateTimePicker1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reg Date From:";
            // 
            // subject_search_butt
            // 
            this.subject_search_butt.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.subject_search_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subject_search_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subject_search_butt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subject_search_butt.Image = global::Secretariat_Soft.Properties.Resources.butt_search2_32;
            this.subject_search_butt.Location = new System.Drawing.Point(259, 64);
            this.subject_search_butt.Name = "subject_search_butt";
            this.subject_search_butt.Size = new System.Drawing.Size(124, 40);
            this.subject_search_butt.TabIndex = 7;
            this.subject_search_butt.Text = "Search";
            this.subject_search_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subject_search_butt.UseVisualStyleBackColor = true;
            this.subject_search_butt.Click += new System.EventHandler(this.subject_search_butt_Click);
            // 
            // subject_textBox1
            // 
            this.subject_textBox1.Location = new System.Drawing.Point(134, 69);
            this.subject_textBox1.Name = "subject_textBox1";
            this.subject_textBox1.Size = new System.Drawing.Size(121, 27);
            this.subject_textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject Like:";
            // 
            // search_id_butt
            // 
            this.search_id_butt.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.search_id_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_id_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_id_butt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_id_butt.Image = global::Secretariat_Soft.Properties.Resources.butt_search2_32;
            this.search_id_butt.Location = new System.Drawing.Point(259, 13);
            this.search_id_butt.Name = "search_id_butt";
            this.search_id_butt.Size = new System.Drawing.Size(124, 40);
            this.search_id_butt.TabIndex = 4;
            this.search_id_butt.Text = "Search ID";
            this.search_id_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.search_id_butt.UseVisualStyleBackColor = true;
            this.search_id_butt.Click += new System.EventHandler(this.search_id_butt_Click);
            // 
            // id_textBox1
            // 
            this.id_textBox1.Location = new System.Drawing.Point(134, 18);
            this.id_textBox1.Name = "id_textBox1";
            this.id_textBox1.Size = new System.Drawing.Size(121, 27);
            this.id_textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID = ";
            // 
            // search_panel1
            // 
            this.search_panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.search_panel1.BackgroundImage = global::Secretariat_Soft.Properties.Resources.down_icon;
            this.search_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_panel1.Location = new System.Drawing.Point(717, 64);
            this.search_panel1.Name = "search_panel1";
            this.search_panel1.Size = new System.Drawing.Size(108, 38);
            this.search_panel1.TabIndex = 4;
            this.search_panel1.Visible = false;
            // 
            // id_label5
            // 
            this.id_label5.AutoSize = true;
            this.id_label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.in_letters_bindingSource1, "ID", true));
            this.id_label5.Location = new System.Drawing.Point(935, 134);
            this.id_label5.Name = "id_label5";
            this.id_label5.Size = new System.Drawing.Size(50, 20);
            this.id_label5.TabIndex = 5;
            this.id_label5.Text = "label5";
            // 
            // In_Letters_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(932, 506);
            this.Controls.Add(this.id_label5);
            this.Controls.Add(this.search_panel1);
            this.Controls.Add(this.search_panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bottom_Toolstrip);
            this.Controls.Add(this.Top_Toolstrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "In_Letters_List";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Letters List";
            this.Load += new System.EventHandler(this.In_Letters_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.In_Letters_List_KeyDown);
            this.Top_Toolstrip.ResumeLayout(false);
            this.Top_Toolstrip.PerformLayout();
            this.Bottom_Toolstrip.ResumeLayout(false);
            this.Bottom_Toolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_letters_bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letters1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.search_panel2.ResumeLayout(false);
            this.search_panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip Top_Toolstrip;
        private ToolStrip Bottom_Toolstrip;
        private Ds.Letters letters1;
        private BindingSource in_letters_bindingSource1;
        private Ds.LettersTableAdapters.Sa_In_LettersTableAdapter sa_In_LettersTableAdapter1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn letterNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn letterTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn letterTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pageCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn refDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docSummaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sysDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SysTime;
        private ToolStripButton First_butt;
        private ToolStripButton prev_butt;
        private ToolStripTextBox position_tbox;
        private ToolStripButton next_butt;
        private ToolStripButton last_butt;
        private ToolStripLabel total_records_lbl;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton search_butt;
        private ToolStripSeparator toolStripSeparator3;
        private Panel search_panel2;
        private Panel search_panel1;
        private TextBox id_textBox1;
        private Label label1;
        private Button search_id_butt;
        private Button subject_search_butt;
        private TextBox subject_textBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker first_dateTimePicker1;
        private Label label4;
        private DateTimePicker second_dateTimePicker2;
        private Button date_search_button1;
        private Label id_label5;
        private ToolStripDropDownButton print_butt;
        private ToolStripMenuItem incomingLettersListToolStripMenuItem;
        private ToolStripMenuItem incomingLetersDetailsToolStripMenuItem;
        public ToolStripButton add_butt;
    }
}