namespace Secretariat_Soft
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Incoming Letters");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Outgoing Letters", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("My Letters", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("All Folders", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.help_butt = new System.Windows.Forms.Button();
            this.tools_butt = new System.Windows.Forms.Button();
            this.reports_butt = new System.Windows.Forms.Button();
            this.data_entry_butt = new System.Windows.Forms.Button();
            this.min_butt = new System.Windows.Forms.Button();
            this.close_butt = new System.Windows.Forms.Button();
            this.overlay_top_panel3 = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.User_name_lbl = new System.Windows.Forms.Label();
            this.User_image_Pic = new System.Windows.Forms.PictureBox();
            this.analogClock1 = new AnalogClock.AnalogClock();
            this.panel1 = new System.Windows.Forms.Panel();
            this.day_week_lbl = new System.Windows.Forms.Label();
            this.day_month_lbl = new System.Windows.Forms.Label();
            this.month_name_lbl = new System.Windows.Forms.Label();
            this.Year_num_lbl = new System.Windows.Forms.Label();
            this.overlay_side_panel2 = new System.Windows.Forms.Panel();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.bg_changer_button5 = new System.Windows.Forms.Button();
            this.overlay_bottom_panel0 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tree_panel = new System.Windows.Forms.Panel();
            this.collapse_butt = new System.Windows.Forms.Button();
            this.expand_butt = new System.Windows.Forms.Button();
            this.main_treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tools_cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.in_toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.out_toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.help_cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.help_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.about_toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bg_panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bg4_radioButton5 = new System.Windows.Forms.RadioButton();
            this.bg5_radioButton6 = new System.Windows.Forms.RadioButton();
            this.bg6_radioButton7 = new System.Windows.Forms.RadioButton();
            this.bg3_radioButton4 = new System.Windows.Forms.RadioButton();
            this.bg2_radioButton3 = new System.Windows.Forms.RadioButton();
            this.bg1_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browse_radioButton2 = new System.Windows.Forms.RadioButton();
            this.select_radioButton1 = new System.Windows.Forms.RadioButton();
            this.Top_Panel.SuspendLayout();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_image_Pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.tree_panel.SuspendLayout();
            this.tools_cm.SuspendLayout();
            this.reports_cm.SuspendLayout();
            this.help_cm.SuspendLayout();
            this.bg_panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.Silver;
            this.Top_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Top_Panel.Controls.Add(this.help_butt);
            this.Top_Panel.Controls.Add(this.tools_butt);
            this.Top_Panel.Controls.Add(this.reports_butt);
            this.Top_Panel.Controls.Add(this.data_entry_butt);
            this.Top_Panel.Controls.Add(this.min_butt);
            this.Top_Panel.Controls.Add(this.close_butt);
            this.Top_Panel.Controls.Add(this.overlay_top_panel3);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(210, 0);
            this.Top_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(814, 75);
            this.Top_Panel.TabIndex = 1;
            // 
            // help_butt
            // 
            this.help_butt.BackColor = System.Drawing.Color.Transparent;
            this.help_butt.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.help_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_butt.FlatAppearance.BorderSize = 0;
            this.help_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_butt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.help_butt.Image = global::Secretariat_Soft.Properties.Resources.top_Help_butt;
            this.help_butt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.help_butt.Location = new System.Drawing.Point(368, 3);
            this.help_butt.Name = "help_butt";
            this.help_butt.Size = new System.Drawing.Size(112, 69);
            this.help_butt.TabIndex = 5;
            this.help_butt.Text = "Help F5";
            this.help_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.help_butt.UseVisualStyleBackColor = false;
            this.help_butt.Click += new System.EventHandler(this.help_button4_Click);
            // 
            // tools_butt
            // 
            this.tools_butt.BackColor = System.Drawing.Color.Transparent;
            this.tools_butt.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.tools_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tools_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tools_butt.FlatAppearance.BorderSize = 0;
            this.tools_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tools_butt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tools_butt.Image = global::Secretariat_Soft.Properties.Resources.top_Tools_butt;
            this.tools_butt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tools_butt.Location = new System.Drawing.Point(250, 3);
            this.tools_butt.Name = "tools_butt";
            this.tools_butt.Size = new System.Drawing.Size(112, 69);
            this.tools_butt.TabIndex = 4;
            this.tools_butt.Text = "Tools F4";
            this.tools_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tools_butt.UseVisualStyleBackColor = false;
            this.tools_butt.Click += new System.EventHandler(this.button3_Click);
            // 
            // reports_butt
            // 
            this.reports_butt.BackColor = System.Drawing.Color.Transparent;
            this.reports_butt.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.reports_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reports_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reports_butt.FlatAppearance.BorderSize = 0;
            this.reports_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports_butt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reports_butt.Image = global::Secretariat_Soft.Properties.Resources.top_report_butt;
            this.reports_butt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reports_butt.Location = new System.Drawing.Point(132, 3);
            this.reports_butt.Name = "reports_butt";
            this.reports_butt.Size = new System.Drawing.Size(112, 69);
            this.reports_butt.TabIndex = 3;
            this.reports_butt.Text = "Reports F3";
            this.reports_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reports_butt.UseVisualStyleBackColor = false;
            this.reports_butt.Click += new System.EventHandler(this.reports_button2_Click);
            // 
            // data_entry_butt
            // 
            this.data_entry_butt.BackColor = System.Drawing.Color.Transparent;
            this.data_entry_butt.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.data_entry_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.data_entry_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_entry_butt.FlatAppearance.BorderSize = 0;
            this.data_entry_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.data_entry_butt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.data_entry_butt.Image = global::Secretariat_Soft.Properties.Resources.top_input_butt;
            this.data_entry_butt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.data_entry_butt.Location = new System.Drawing.Point(5, 3);
            this.data_entry_butt.Name = "data_entry_butt";
            this.data_entry_butt.Size = new System.Drawing.Size(120, 69);
            this.data_entry_butt.TabIndex = 2;
            this.data_entry_butt.Text = "Data Entry F2";
            this.data_entry_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.data_entry_butt.UseVisualStyleBackColor = false;
            this.data_entry_butt.Click += new System.EventHandler(this.data_entry_butt_Click);
            // 
            // min_butt
            // 
            this.min_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_butt.BackgroundImage = global::Secretariat_Soft.Properties.Resources.min_butt;
            this.min_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.min_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min_butt.Location = new System.Drawing.Point(745, 5);
            this.min_butt.Name = "min_butt";
            this.min_butt.Size = new System.Drawing.Size(30, 30);
            this.min_butt.TabIndex = 1;
            this.min_butt.UseVisualStyleBackColor = true;
            this.min_butt.Click += new System.EventHandler(this.min_butt_Click);
            // 
            // close_butt
            // 
            this.close_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_butt.BackgroundImage = global::Secretariat_Soft.Properties.Resources.Close_butt;
            this.close_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_butt.Location = new System.Drawing.Point(776, 5);
            this.close_butt.Name = "close_butt";
            this.close_butt.Size = new System.Drawing.Size(30, 30);
            this.close_butt.TabIndex = 0;
            this.close_butt.UseVisualStyleBackColor = true;
            this.close_butt.Click += new System.EventHandler(this.close_butt_Click);
            // 
            // overlay_top_panel3
            // 
            this.overlay_top_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlay_top_panel3.Location = new System.Drawing.Point(0, 0);
            this.overlay_top_panel3.Name = "overlay_top_panel3";
            this.overlay_top_panel3.Size = new System.Drawing.Size(814, 75);
            this.overlay_top_panel3.TabIndex = 6;
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.side_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.side_panel.Controls.Add(this.User_name_lbl);
            this.side_panel.Controls.Add(this.User_image_Pic);
            this.side_panel.Controls.Add(this.analogClock1);
            this.side_panel.Controls.Add(this.panel1);
            this.side_panel.Controls.Add(this.overlay_side_panel2);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Margin = new System.Windows.Forms.Padding(2);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(210, 728);
            this.side_panel.TabIndex = 2;
            // 
            // User_name_lbl
            // 
            this.User_name_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_name_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.User_name_lbl.Location = new System.Drawing.Point(40, 615);
            this.User_name_lbl.Name = "User_name_lbl";
            this.User_name_lbl.Size = new System.Drawing.Size(129, 25);
            this.User_name_lbl.TabIndex = 3;
            this.User_name_lbl.Text = "Musavi";
            this.User_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_image_Pic
            // 
            this.User_image_Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_image_Pic.Image = global::Secretariat_Soft.Properties.Resources.Default_user;
            this.User_image_Pic.Location = new System.Drawing.Point(40, 480);
            this.User_image_Pic.Name = "User_image_Pic";
            this.User_image_Pic.Size = new System.Drawing.Size(129, 134);
            this.User_image_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_image_Pic.TabIndex = 2;
            this.User_image_Pic.TabStop = false;
            // 
            // analogClock1
            // 
            this.analogClock1.DrawHourHand = true;
            this.analogClock1.DrawHourHandShadow = true;
            this.analogClock1.DrawMinuteHand = true;
            this.analogClock1.DrawMinuteHandShadow = true;
            this.analogClock1.DrawSecondHand = true;
            this.analogClock1.DropShadowColor = System.Drawing.Color.Black;
            this.analogClock1.DropShadowOffset = new System.Drawing.Point(0, 0);
            this.analogClock1.FaceColorHigh = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogClock1.FaceColorLow = System.Drawing.Color.Red;
            this.analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.analogClock1.FaceImage = null;
            this.analogClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.analogClock1.HourHandColor = System.Drawing.Color.Gainsboro;
            this.analogClock1.HourHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.Location = new System.Drawing.Point(12, 12);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock1.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.NumeralColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock1.RimColorHigh = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogClock1.RimColorLow = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.analogClock1.SecondHandColor = System.Drawing.Color.LightCoral;
            this.analogClock1.SecondHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.analogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
            this.analogClock1.Size = new System.Drawing.Size(188, 188);
            this.analogClock1.TabIndex = 1;
            this.analogClock1.Time = new System.DateTime(((long)(0)));
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Secretariat_Soft.Properties.Resources.calendar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.day_week_lbl);
            this.panel1.Controls.Add(this.day_month_lbl);
            this.panel1.Controls.Add(this.month_name_lbl);
            this.panel1.Controls.Add(this.Year_num_lbl);
            this.panel1.Location = new System.Drawing.Point(9, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 184);
            this.panel1.TabIndex = 0;
            // 
            // day_week_lbl
            // 
            this.day_week_lbl.BackColor = System.Drawing.Color.Transparent;
            this.day_week_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day_week_lbl.ForeColor = System.Drawing.Color.Black;
            this.day_week_lbl.Location = new System.Drawing.Point(19, 129);
            this.day_week_lbl.Name = "day_week_lbl";
            this.day_week_lbl.Size = new System.Drawing.Size(149, 36);
            this.day_week_lbl.TabIndex = 3;
            this.day_week_lbl.Text = "Sunday";
            this.day_week_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day_month_lbl
            // 
            this.day_month_lbl.BackColor = System.Drawing.Color.Transparent;
            this.day_month_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day_month_lbl.ForeColor = System.Drawing.Color.Black;
            this.day_month_lbl.Location = new System.Drawing.Point(19, 76);
            this.day_month_lbl.Name = "day_month_lbl";
            this.day_month_lbl.Size = new System.Drawing.Size(149, 41);
            this.day_month_lbl.TabIndex = 2;
            this.day_month_lbl.Text = "23";
            this.day_month_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // month_name_lbl
            // 
            this.month_name_lbl.AutoSize = true;
            this.month_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.month_name_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.month_name_lbl.ForeColor = System.Drawing.Color.White;
            this.month_name_lbl.Location = new System.Drawing.Point(122, 39);
            this.month_name_lbl.Name = "month_name_lbl";
            this.month_name_lbl.Size = new System.Drawing.Size(50, 23);
            this.month_name_lbl.TabIndex = 1;
            this.month_name_lbl.Text = "April";
            // 
            // Year_num_lbl
            // 
            this.Year_num_lbl.AutoSize = true;
            this.Year_num_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Year_num_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Year_num_lbl.ForeColor = System.Drawing.Color.White;
            this.Year_num_lbl.Location = new System.Drawing.Point(13, 39);
            this.Year_num_lbl.Name = "Year_num_lbl";
            this.Year_num_lbl.Size = new System.Drawing.Size(50, 23);
            this.Year_num_lbl.TabIndex = 0;
            this.Year_num_lbl.Text = "2022";
            // 
            // overlay_side_panel2
            // 
            this.overlay_side_panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlay_side_panel2.Location = new System.Drawing.Point(0, 0);
            this.overlay_side_panel2.Name = "overlay_side_panel2";
            this.overlay_side_panel2.Size = new System.Drawing.Size(210, 728);
            this.overlay_side_panel2.TabIndex = 4;
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottom_panel.Controls.Add(this.button6);
            this.bottom_panel.Controls.Add(this.bg_changer_button5);
            this.bottom_panel.Controls.Add(this.overlay_bottom_panel0);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(210, 688);
            this.bottom_panel.Margin = new System.Windows.Forms.Padding(2);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(814, 40);
            this.bottom_panel.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = global::Secretariat_Soft.Properties.Resources.calc_butt;
            this.button6.Location = new System.Drawing.Point(637, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 32);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bg_changer_button5
            // 
            this.bg_changer_button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_changer_button5.BackgroundImage = global::Secretariat_Soft.Properties.Resources.butt_background;
            this.bg_changer_button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg_changer_button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg_changer_button5.Image = global::Secretariat_Soft.Properties.Resources.background;
            this.bg_changer_button5.Location = new System.Drawing.Point(681, 3);
            this.bg_changer_button5.Name = "bg_changer_button5";
            this.bg_changer_button5.Size = new System.Drawing.Size(120, 32);
            this.bg_changer_button5.TabIndex = 0;
            this.bg_changer_button5.Text = "Background";
            this.bg_changer_button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bg_changer_button5.UseVisualStyleBackColor = true;
            this.bg_changer_button5.Click += new System.EventHandler(this.bg_changer_button5_Click);
            // 
            // overlay_bottom_panel0
            // 
            this.overlay_bottom_panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlay_bottom_panel0.Location = new System.Drawing.Point(0, 0);
            this.overlay_bottom_panel0.Name = "overlay_bottom_panel0";
            this.overlay_bottom_panel0.Size = new System.Drawing.Size(814, 40);
            this.overlay_bottom_panel0.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tree_panel
            // 
            this.tree_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tree_panel.Controls.Add(this.collapse_butt);
            this.tree_panel.Controls.Add(this.expand_butt);
            this.tree_panel.Controls.Add(this.main_treeView);
            this.tree_panel.Location = new System.Drawing.Point(214, 76);
            this.tree_panel.Name = "tree_panel";
            this.tree_panel.Size = new System.Drawing.Size(336, 463);
            this.tree_panel.TabIndex = 5;
            this.tree_panel.Visible = false;
            // 
            // collapse_butt
            // 
            this.collapse_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collapse_butt.Image = global::Secretariat_Soft.Properties.Resources.collapse;
            this.collapse_butt.Location = new System.Drawing.Point(295, 3);
            this.collapse_butt.Name = "collapse_butt";
            this.collapse_butt.Size = new System.Drawing.Size(31, 26);
            this.collapse_butt.TabIndex = 8;
            this.collapse_butt.UseVisualStyleBackColor = true;
            this.collapse_butt.Click += new System.EventHandler(this.collapse_butt_Click);
            // 
            // expand_butt
            // 
            this.expand_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expand_butt.Image = global::Secretariat_Soft.Properties.Resources.expand;
            this.expand_butt.Location = new System.Drawing.Point(262, 3);
            this.expand_butt.Name = "expand_butt";
            this.expand_butt.Size = new System.Drawing.Size(31, 26);
            this.expand_butt.TabIndex = 7;
            this.expand_butt.UseVisualStyleBackColor = true;
            this.expand_butt.Click += new System.EventHandler(this.expand_butt_Click);
            // 
            // main_treeView
            // 
            this.main_treeView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_treeView.ForeColor = System.Drawing.Color.Black;
            this.main_treeView.ImageIndex = 0;
            this.main_treeView.ImageList = this.imageList1;
            this.main_treeView.Indent = 40;
            this.main_treeView.ItemHeight = 45;
            this.main_treeView.Location = new System.Drawing.Point(3, 1);
            this.main_treeView.Name = "main_treeView";
            treeNode1.ImageKey = "review.png";
            treeNode1.Name = "Incoming_Letters";
            treeNode1.SelectedImageKey = "review.png";
            treeNode1.Text = "Incoming Letters";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Outgoing_Letters";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Outgoing Letters";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "My_Letters";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "My Letters";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "All_Folders";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "All Folders";
            this.main_treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.main_treeView.SelectedImageIndex = 0;
            this.main_treeView.Size = new System.Drawing.Size(328, 457);
            this.main_treeView.TabIndex = 0;
            this.main_treeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.main_treeView_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dep_1.png");
            this.imageList1.Images.SetKeyName(1, "kToolStripButton2.Image.png");
            this.imageList1.Images.SetKeyName(2, "RadMenuItem2.png");
            this.imageList1.Images.SetKeyName(3, "review.png");
            // 
            // tools_cm
            // 
            this.tools_cm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tools_cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.backupDataToolStripMenuItem,
            this.restoreDataToolStripMenuItem});
            this.tools_cm.Name = "tools_cm";
            this.tools_cm.Size = new System.Drawing.Size(181, 118);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::Secretariat_Soft.Properties.Resources.users_32;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // backupDataToolStripMenuItem
            // 
            this.backupDataToolStripMenuItem.Image = global::Secretariat_Soft.Properties.Resources.backup_32;
            this.backupDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
            this.backupDataToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.backupDataToolStripMenuItem.Text = "Backup Data";
            this.backupDataToolStripMenuItem.Click += new System.EventHandler(this.backupDataToolStripMenuItem_Click);
            // 
            // restoreDataToolStripMenuItem
            // 
            this.restoreDataToolStripMenuItem.Image = global::Secretariat_Soft.Properties.Resources.restore_32;
            this.restoreDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.restoreDataToolStripMenuItem.Name = "restoreDataToolStripMenuItem";
            this.restoreDataToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.restoreDataToolStripMenuItem.Text = "Restore Data";
            this.restoreDataToolStripMenuItem.Click += new System.EventHandler(this.restoreDataToolStripMenuItem_Click);
            // 
            // reports_cm
            // 
            this.reports_cm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.reports_cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.in_toolStripMenuItem2,
            this.out_toolStripMenuItem3});
            this.reports_cm.Name = "tools_cm";
            this.reports_cm.Size = new System.Drawing.Size(206, 80);
            // 
            // in_toolStripMenuItem2
            // 
            this.in_toolStripMenuItem2.Image = global::Secretariat_Soft.Properties.Resources.de_edit_butt_;
            this.in_toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.in_toolStripMenuItem2.Name = "in_toolStripMenuItem2";
            this.in_toolStripMenuItem2.Size = new System.Drawing.Size(205, 38);
            this.in_toolStripMenuItem2.Text = "Incoming Letters";
            this.in_toolStripMenuItem2.Click += new System.EventHandler(this.in_toolStripMenuItem2_Click);
            // 
            // out_toolStripMenuItem3
            // 
            this.out_toolStripMenuItem3.Image = global::Secretariat_Soft.Properties.Resources.butt_search2_32;
            this.out_toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.out_toolStripMenuItem3.Name = "out_toolStripMenuItem3";
            this.out_toolStripMenuItem3.Size = new System.Drawing.Size(205, 38);
            this.out_toolStripMenuItem3.Text = "Outgoing Letters";
            this.out_toolStripMenuItem3.Click += new System.EventHandler(this.out_toolStripMenuItem3_Click);
            // 
            // help_cm
            // 
            this.help_cm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.help_cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_toolStripMenuItem1,
            this.about_toolStripMenuItem2});
            this.help_cm.Name = "tools_cm";
            this.help_cm.Size = new System.Drawing.Size(136, 80);
            // 
            // help_toolStripMenuItem1
            // 
            this.help_toolStripMenuItem1.Image = global::Secretariat_Soft.Properties.Resources.backup_32;
            this.help_toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.help_toolStripMenuItem1.Name = "help_toolStripMenuItem1";
            this.help_toolStripMenuItem1.Size = new System.Drawing.Size(135, 38);
            this.help_toolStripMenuItem1.Text = "Help";
            // 
            // about_toolStripMenuItem2
            // 
            this.about_toolStripMenuItem2.Image = global::Secretariat_Soft.Properties.Resources.top_Help_butt;
            this.about_toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.about_toolStripMenuItem2.Name = "about_toolStripMenuItem2";
            this.about_toolStripMenuItem2.Size = new System.Drawing.Size(135, 38);
            this.about_toolStripMenuItem2.Text = "About";
            this.about_toolStripMenuItem2.Click += new System.EventHandler(this.about_toolStripMenuItem2_Click);
            // 
            // bg_panel3
            // 
            this.bg_panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bg_panel3.Controls.Add(this.button2);
            this.bg_panel3.Controls.Add(this.bg4_radioButton5);
            this.bg_panel3.Controls.Add(this.bg5_radioButton6);
            this.bg_panel3.Controls.Add(this.bg6_radioButton7);
            this.bg_panel3.Controls.Add(this.bg3_radioButton4);
            this.bg_panel3.Controls.Add(this.bg2_radioButton3);
            this.bg_panel3.Controls.Add(this.bg1_radioButton);
            this.bg_panel3.Controls.Add(this.groupBox1);
            this.bg_panel3.Location = new System.Drawing.Point(623, 402);
            this.bg_panel3.Name = "bg_panel3";
            this.bg_panel3.Size = new System.Drawing.Size(388, 284);
            this.bg_panel3.TabIndex = 7;
            this.bg_panel3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Secretariat_Soft.Properties.Resources.Close_butt;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(357, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bg4_radioButton5
            // 
            this.bg4_radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.bg4_radioButton5.BackgroundImage = global::Secretariat_Soft.Properties.Resources.calendar;
            this.bg4_radioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bg4_radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg4_radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.bg4_radioButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bg4_radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg4_radioButton5.Location = new System.Drawing.Point(16, 170);
            this.bg4_radioButton5.Name = "bg4_radioButton5";
            this.bg4_radioButton5.Size = new System.Drawing.Size(113, 95);
            this.bg4_radioButton5.TabIndex = 6;
            this.bg4_radioButton5.TabStop = true;
            this.bg4_radioButton5.UseVisualStyleBackColor = false;
            this.bg4_radioButton5.Click += new System.EventHandler(this.bg4_radioButton5_Click);
            // 
            // bg5_radioButton6
            // 
            this.bg5_radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.bg5_radioButton6.BackgroundImage = global::Secretariat_Soft.Properties.Resources.calendar;
            this.bg5_radioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bg5_radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg5_radioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.bg5_radioButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bg5_radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg5_radioButton6.Location = new System.Drawing.Point(139, 170);
            this.bg5_radioButton6.Name = "bg5_radioButton6";
            this.bg5_radioButton6.Size = new System.Drawing.Size(113, 95);
            this.bg5_radioButton6.TabIndex = 5;
            this.bg5_radioButton6.TabStop = true;
            this.bg5_radioButton6.UseVisualStyleBackColor = false;
            this.bg5_radioButton6.Click += new System.EventHandler(this.bg5_radioButton6_Click);
            // 
            // bg6_radioButton7
            // 
            this.bg6_radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.bg6_radioButton7.BackgroundImage = global::Secretariat_Soft.Properties.Resources.calendar;
            this.bg6_radioButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bg6_radioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg6_radioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.bg6_radioButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bg6_radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg6_radioButton7.Location = new System.Drawing.Point(260, 170);
            this.bg6_radioButton7.Name = "bg6_radioButton7";
            this.bg6_radioButton7.Size = new System.Drawing.Size(113, 95);
            this.bg6_radioButton7.TabIndex = 4;
            this.bg6_radioButton7.TabStop = true;
            this.bg6_radioButton7.UseVisualStyleBackColor = false;
            this.bg6_radioButton7.Click += new System.EventHandler(this.bg6_radioButton7_Click);
            // 
            // bg3_radioButton4
            // 
            this.bg3_radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.bg3_radioButton4.BackgroundImage = global::Secretariat_Soft.Properties.Resources.calendar;
            this.bg3_radioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bg3_radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg3_radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.bg3_radioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bg3_radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg3_radioButton4.Location = new System.Drawing.Point(260, 61);
            this.bg3_radioButton4.Name = "bg3_radioButton4";
            this.bg3_radioButton4.Size = new System.Drawing.Size(113, 95);
            this.bg3_radioButton4.TabIndex = 3;
            this.bg3_radioButton4.TabStop = true;
            this.bg3_radioButton4.UseVisualStyleBackColor = false;
            this.bg3_radioButton4.Click += new System.EventHandler(this.bg3_radioButton4_Click);
            // 
            // bg2_radioButton3
            // 
            this.bg2_radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.bg2_radioButton3.BackgroundImage = global::Secretariat_Soft.Properties.Resources.calendar;
            this.bg2_radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bg2_radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg2_radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.bg2_radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bg2_radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg2_radioButton3.Location = new System.Drawing.Point(139, 61);
            this.bg2_radioButton3.Name = "bg2_radioButton3";
            this.bg2_radioButton3.Size = new System.Drawing.Size(113, 95);
            this.bg2_radioButton3.TabIndex = 2;
            this.bg2_radioButton3.TabStop = true;
            this.bg2_radioButton3.UseVisualStyleBackColor = false;
            this.bg2_radioButton3.Click += new System.EventHandler(this.bg2_radioButton3_Click);
            // 
            // bg1_radioButton
            // 
            this.bg1_radioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.bg1_radioButton.BackgroundImage = global::Secretariat_Soft.Properties.Resources.calendar;
            this.bg1_radioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bg1_radioButton.Checked = true;
            this.bg1_radioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg1_radioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.bg1_radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bg1_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg1_radioButton.Location = new System.Drawing.Point(16, 61);
            this.bg1_radioButton.Name = "bg1_radioButton";
            this.bg1_radioButton.Size = new System.Drawing.Size(113, 95);
            this.bg1_radioButton.TabIndex = 1;
            this.bg1_radioButton.TabStop = true;
            this.bg1_radioButton.UseVisualStyleBackColor = false;
            this.bg1_radioButton.Click += new System.EventHandler(this.bg1_radioButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browse_radioButton2);
            this.groupBox1.Controls.Add(this.select_radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // browse_radioButton2
            // 
            this.browse_radioButton2.AutoSize = true;
            this.browse_radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse_radioButton2.Location = new System.Drawing.Point(202, 19);
            this.browse_radioButton2.Name = "browse_radioButton2";
            this.browse_radioButton2.Size = new System.Drawing.Size(121, 24);
            this.browse_radioButton2.TabIndex = 1;
            this.browse_radioButton2.TabStop = true;
            this.browse_radioButton2.Text = "Browse Mode";
            this.browse_radioButton2.UseVisualStyleBackColor = true;
            // 
            // select_radioButton1
            // 
            this.select_radioButton1.AutoSize = true;
            this.select_radioButton1.Checked = true;
            this.select_radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_radioButton1.Location = new System.Drawing.Point(21, 19);
            this.select_radioButton1.Name = "select_radioButton1";
            this.select_radioButton1.Size = new System.Drawing.Size(113, 24);
            this.select_radioButton1.TabIndex = 0;
            this.select_radioButton1.TabStop = true;
            this.select_radioButton1.Text = "Select Mode";
            this.select_radioButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 728);
            this.Controls.Add(this.bg_panel3);
            this.Controls.Add(this.tree_panel);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 728);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Top_Panel.ResumeLayout(false);
            this.side_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_image_Pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.tree_panel.ResumeLayout(false);
            this.tools_cm.ResumeLayout(false);
            this.reports_cm.ResumeLayout(false);
            this.help_cm.ResumeLayout(false);
            this.bg_panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Top_Panel;
        private Panel side_panel;
        private Panel bottom_panel;
        private Button close_butt;
        private Button min_butt;
        private Button data_entry_butt;
        private Button help_butt;
        private Button tools_butt;
        private Button reports_butt;
        private Button bg_changer_button5;
        private Button button6;
        private Panel panel1;
        private Label day_week_lbl;
        private Label day_month_lbl;
        private Label month_name_lbl;
        private Label Year_num_lbl;
        private AnalogClock.AnalogClock analogClock1;
        private System.Windows.Forms.Timer timer1;
        private Label User_name_lbl;
        private PictureBox User_image_Pic;
        private Panel tree_panel;
        private TreeView main_treeView;
        private Button expand_butt;
        private Button collapse_butt;
        private ImageList imageList1;
        private Button button1;
        private ContextMenuStrip tools_cm;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem backupDataToolStripMenuItem;
        private ToolStripMenuItem restoreDataToolStripMenuItem;
        private ContextMenuStrip reports_cm;
        private ToolStripMenuItem in_toolStripMenuItem2;
        private ToolStripMenuItem out_toolStripMenuItem3;
        private ContextMenuStrip help_cm;
        private ToolStripMenuItem help_toolStripMenuItem1;
        private ToolStripMenuItem about_toolStripMenuItem2;
        private Panel panel2;
        private RadioButton bg3_radioButton4;
        private RadioButton bg4_radioButton5;
        private RadioButton bg5_radioButton6;
        private RadioButton bg1_radioButton;
        private RadioButton browse_radioButton2;
        private RadioButton select_radioButton1;
        private GroupBox groupBox1;
        private RadioButton radioButton8;
        private RadioButton bg6_radioButton7;
        private Panel bg_panel3;
        private RadioButton bg2_radioButton3;
        private Button button2;
        private Panel overlay_top_panel3;
        private Panel overlay_side_panel2;
        private Panel overlay_bottom_panel0;
    }
}