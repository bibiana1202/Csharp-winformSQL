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
            TopPanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            min_butt = new Button();
            close_butt = new Button();
            side_panel = new Panel();
            panel1 = new Panel();
            day_week_lbl = new Label();
            day_month_lbl = new Label();
            month_name_lbl = new Label();
            Year_num_lbl = new Label();
            bottom_panel = new Panel();
            button6 = new Button();
            button5 = new Button();
            TopPanel.SuspendLayout();
            side_panel.SuspendLayout();
            panel1.SuspendLayout();
            bottom_panel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Silver;
            TopPanel.Controls.Add(button4);
            TopPanel.Controls.Add(button3);
            TopPanel.Controls.Add(button2);
            TopPanel.Controls.Add(button1);
            TopPanel.Controls.Add(min_butt);
            TopPanel.Controls.Add(close_butt);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(180, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(844, 75);
            TopPanel.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.butt_background;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = Properties.Resources.top_Help_butt;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(400, 3);
            button4.Name = "button4";
            button4.Size = new Size(124, 69);
            button4.TabIndex = 5;
            button4.Text = "Help F5";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.butt_background;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.top_Tools_butt;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(270, 3);
            button3.Name = "button3";
            button3.Size = new Size(124, 69);
            button3.TabIndex = 4;
            button3.Text = "Tools F4";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.butt_background;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.top_report_butt;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(140, 3);
            button2.Name = "button2";
            button2.Size = new Size(124, 69);
            button2.TabIndex = 3;
            button2.Text = "Reports F3";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.butt_background;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.top_input_butt;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(10, 3);
            button1.Name = "button1";
            button1.Size = new Size(124, 69);
            button1.TabIndex = 2;
            button1.Text = "Data Entry F2";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // min_butt
            // 
            min_butt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            min_butt.BackgroundImage = Properties.Resources.min_butt;
            min_butt.BackgroundImageLayout = ImageLayout.Zoom;
            min_butt.Cursor = Cursors.Hand;
            min_butt.Location = new Point(775, 3);
            min_butt.Name = "min_butt";
            min_butt.Size = new Size(30, 30);
            min_butt.TabIndex = 1;
            min_butt.UseVisualStyleBackColor = true;
            min_butt.Click += min_butt_Click;
            // 
            // close_butt
            // 
            close_butt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_butt.BackgroundImage = Properties.Resources.Close_butt;
            close_butt.BackgroundImageLayout = ImageLayout.Zoom;
            close_butt.Cursor = Cursors.Hand;
            close_butt.Location = new Point(811, 3);
            close_butt.Name = "close_butt";
            close_butt.Size = new Size(30, 30);
            close_butt.TabIndex = 0;
            close_butt.UseVisualStyleBackColor = true;
            close_butt.Click += close_butt_Click;
            // 
            // side_panel
            // 
            side_panel.BackColor = Color.Gainsboro;
            side_panel.Controls.Add(panel1);
            side_panel.Dock = DockStyle.Left;
            side_panel.Location = new Point(0, 0);
            side_panel.Name = "side_panel";
            side_panel.Size = new Size(180, 768);
            side_panel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.calendar;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(day_week_lbl);
            panel1.Controls.Add(day_month_lbl);
            panel1.Controls.Add(month_name_lbl);
            panel1.Controls.Add(Year_num_lbl);
            panel1.Location = new Point(-1, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 249);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // day_week_lbl
            // 
            day_week_lbl.BackColor = Color.Transparent;
            day_week_lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            day_week_lbl.ForeColor = Color.White;
            day_week_lbl.Location = new Point(0, 168);
            day_week_lbl.Name = "day_week_lbl";
            day_week_lbl.Size = new Size(180, 32);
            day_week_lbl.TabIndex = 3;
            day_week_lbl.Text = "Sunday";
            day_week_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // day_month_lbl
            // 
            day_month_lbl.BackColor = Color.Transparent;
            day_month_lbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            day_month_lbl.ForeColor = Color.White;
            day_month_lbl.Location = new Point(3, 96);
            day_month_lbl.Name = "day_month_lbl";
            day_month_lbl.Size = new Size(177, 92);
            day_month_lbl.TabIndex = 2;
            day_month_lbl.Text = "13";
            day_month_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // month_name_lbl
            // 
            month_name_lbl.AutoSize = true;
            month_name_lbl.BackColor = Color.Transparent;
            month_name_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            month_name_lbl.ForeColor = Color.White;
            month_name_lbl.Location = new Point(122, 70);
            month_name_lbl.Name = "month_name_lbl";
            month_name_lbl.Size = new Size(33, 15);
            month_name_lbl.TabIndex = 1;
            month_name_lbl.Text = "April";
            // 
            // Year_num_lbl
            // 
            Year_num_lbl.AutoSize = true;
            Year_num_lbl.BackColor = Color.Transparent;
            Year_num_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Year_num_lbl.ForeColor = Color.White;
            Year_num_lbl.Location = new Point(25, 70);
            Year_num_lbl.Name = "Year_num_lbl";
            Year_num_lbl.Size = new Size(35, 15);
            Year_num_lbl.TabIndex = 0;
            Year_num_lbl.Text = "2023";
            // 
            // bottom_panel
            // 
            bottom_panel.Controls.Add(button6);
            bottom_panel.Controls.Add(button5);
            bottom_panel.Dock = DockStyle.Bottom;
            bottom_panel.Location = new Point(180, 728);
            bottom_panel.Name = "bottom_panel";
            bottom_panel.Size = new Size(844, 40);
            bottom_panel.TabIndex = 3;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackgroundImage = Properties.Resources.butt_background;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Image = Properties.Resources.calc_butt;
            button6.Location = new Point(676, 4);
            button6.Name = "button6";
            button6.Size = new Size(35, 32);
            button6.TabIndex = 1;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackgroundImage = Properties.Resources.butt_background;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Image = Properties.Resources.background;
            button5.Location = new Point(717, 4);
            button5.Name = "button5";
            button5.Size = new Size(120, 32);
            button5.TabIndex = 0;
            button5.Text = "Background";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(TopPanel);
            Controls.Add(bottom_panel);
            Controls.Add(side_panel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1024, 768);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            TopPanel.ResumeLayout(false);
            side_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            bottom_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel side_panel;
        private Panel bottom_panel;
        private Button close_butt;
        private Button min_butt;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Label Year_num_lbl;
        private Label day_week_lbl;
        private Label day_month_lbl;
        private Label month_name_lbl;
    }
}