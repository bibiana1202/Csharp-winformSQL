using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat_Soft
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void con_string_loader()
        {
            //----load con string---------------
            string MyCon;
            MyCon = Secretariat_Soft.Properties.Settings.Default.main_con_text;
            //----------
            MyCon = NETCore.Encrypt.EncryptProvider.AESDecrypt(MyCon,Secretariat_Soft.MyClasses.ComClass.dfftrf);
            //----------
            Secretariat_Soft.MyClasses.ComClass.MyConn_String = MyCon;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //----------load and decrypt the con string-----------------------
            con_string_loader();
            //--------------------------------------------------------------------
            background_image_changer_all();
            transparent_panel();
            //----------------------------------
            Secretariat_Soft.CommForms.LoginFrm frm = new CommForms.LoginFrm();
            DialogResult dr;
            dr=frm.ShowDialog();
            //-------------
            if (dr==DialogResult.OK)
            {
                this.User_image_Pic.Image = frm.user_pictureBox1.Image;
                this.User_name_lbl.Text = frm.user_name_comboBox1.Text;
                //-------------
                //-----------------------
                Secretariat_Soft.Properties.Settings.Default.User_name= frm.user_name_comboBox1.Text;
                //-----
                long id;
                long.TryParse(frm.id_label21.Text, out id);
                //-----
                Secretariat_Soft.Properties.Settings.Default.User_Id=id;
                //--------------
                Secretariat_Soft.Properties.Settings.Default.Save();
                //--------------
                //===============================
                //-----------load date--------------
                get_date_cal();
                //------------Treeview ----------------------
                this.tree_panel.Visible = false;
                this.main_treeView.ExpandAll();
                //-------------------------------------------
                //============load permission data ====================
                Secretariat_Soft.MyClasses.ComClass MyClass = new MyClasses.ComClass();
                MyClass.user_perm_loader_from_db();
                //============= assign permissions to controls ========  
                //System.Windows.Forms.MessageBox.Show( MyClass.get_permission_by_col_name("main_b1").ToString() );
                object_perm_loader();
                //=====================================================
            }
            else
            {
                //-------Wrong password----
                System.Windows.Forms.MessageBox.Show("Nice day!");
                Application.Exit();
                //-------------------------
            }
           
        }

        public void object_perm_loader()
        {
            Secretariat_Soft.MyClasses.ComClass MyClass = new MyClasses.ComClass();
            //-----------load the permissions by col name -----------------
            this.data_entry_butt.Enabled = MyClass.get_permission_by_col_name("main_b1");// de
            //========report==============
            this.reports_butt.Enabled = MyClass.get_permission_by_col_name("main_b2");//reports
            //---
            this.in_toolStripMenuItem2.Enabled = MyClass.get_permission_by_col_name("main_b2_m1");//in
            this.out_toolStripMenuItem3.Enabled = MyClass.get_permission_by_col_name("main_b2_m2");//out
            //===========tools==================
            this.tools_butt.Enabled = MyClass.get_permission_by_col_name("main_b3");//tools
            //---
            this.usersToolStripMenuItem.Enabled = MyClass.get_permission_by_col_name("main_b3_m1");//users
            this.backupDataToolStripMenuItem.Enabled = MyClass.get_permission_by_col_name("main_b3_m2");//backup
            this.restoreDataToolStripMenuItem.Enabled = MyClass.get_permission_by_col_name("main_b3_m3");//restore
            //==============help =====================
            this.help_butt.Enabled = MyClass.get_permission_by_col_name("main_b4");//help
            //---
            this.help_toolStripMenuItem1.Enabled = MyClass.get_permission_by_col_name("main_b4_m1");//help
            this.about_toolStripMenuItem2.Enabled = MyClass.get_permission_by_col_name("main_b4_m2");//about

            //-------------------------------------------------------------
            if (Secretariat_Soft.Properties.Settings.Default.User_Id== Secretariat_Soft.Properties.Settings.Default.admin_user_id)
            {
                this.usersToolStripMenuItem.Enabled = true;
                this.tools_butt.Enabled = true;
            }
        }
        void get_date_cal()
        {
             this.Year_num_lbl.Text=System.DateTime.Now.Year.ToString();
            int mn = System.DateTime.Now.Month;
            string month_name;
            month_name= System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mn);
            this.month_name_lbl.Text =month_name;
            this.day_month_lbl.Text = System.DateTime.Now.Day.ToString();
            this.day_week_lbl.Text = System.DateTime.Now.DayOfWeek.ToString();
        }
        private void close_butt_Click(object sender, EventArgs e)
        {
         this.Close();
        }

        private void min_butt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.analogClock1.Time = System.DateTime.Now;
        }

        private void data_entry_butt_Click(object sender, EventArgs e)
        {
           this.tree_panel.Visible=!this.tree_panel.Visible;
        }

        private void collapse_butt_Click(object sender, EventArgs e)
        {
            this.main_treeView.CollapseAll();
        }

        private void expand_butt_Click(object sender, EventArgs e)
        {
            this.main_treeView.ExpandAll();
        }

        private void main_treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.main_treeView.SelectedNode!=null)
            {
                string node_name;
                node_name= this.main_treeView.SelectedNode.Name;
                //------------

                if (node_name== "Incoming_Letters")
                {
                    Secretariat_Soft.S_Forms.In_Letters_List frm = new S_Forms.In_Letters_List();
                    frm.MdiParent=this;
                    //-----------
                    frm.Show();
                    //--------
                    this.tree_panel.Visible=false;
                }

                //==================================
                if (node_name == "Outgoing_Letters")
                {
                    Secretariat_Soft.S_Forms.Out_Letters_List frm = new S_Forms.Out_Letters_List();
                    frm.MdiParent = this;
                    //-----------
                    frm.Show();
                    //--------
                    this.tree_panel.Visible = false;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y;
            x = this.side_panel.Width + this.tools_butt.Location.X;// x in screen
            y = this.tools_butt.Location.Y + this.tools_butt.Height;//y in screen
            //--------------------
            this.tools_cm.Show(new Point(x,y));//location on screen
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secretariat_Soft.CommForms.UserList frm = new CommForms.UserList();
            //frm.MdiParent = this;
            frm.ShowDialog();
            //----------------
            object_perm_loader();
            //-------------------
        }

        private void reports_button2_Click(object sender, EventArgs e)
        {
            int x, y;
            x = this.side_panel.Width + this.reports_butt.Location.X;// x in screen
            y = this.reports_butt.Location.Y + this.reports_butt.Height;//y in screen
            //--------------------
            this.reports_cm.Show(new Point(x, y));//location on screen
        }

        private void help_button4_Click(object sender, EventArgs e)
        {
            int x, y;
            x = this.side_panel.Width + this.help_butt.Location.X;// x in screen
            y = this.help_butt.Location.Y + this.help_butt.Height;//y in screen
            //--------------------
            this.help_cm.Show(new Point(x, y));//location on screen
        }

        private void backupDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secretariat_Soft.CommForms.BackupForm frm = new CommForms.BackupForm();
             frm.ShowDialog();
            //----------------
          
        }

        private void restoreDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secretariat_Soft.CommForms.RestoreForm frm = new CommForms.RestoreForm();
            frm.ShowDialog();
            //----------------
        }

        private void bg_changer_button5_Click(object sender, EventArgs e)
        {
            
            if (this.bg_panel3.Visible==false)
            {
                //--------------------------------
                selected_radiobutton_loader();
                //--------------------------------
                thumb_image_loader("0.jpg", "0_thumb.jpg", this.bg1_radioButton);
                thumb_image_loader("1.jpg", "1_thumb.jpg", this.bg2_radioButton3);
                thumb_image_loader("2.jpg", "2_thumb.jpg", this.bg3_radioButton4);
                thumb_image_loader("3.jpg", "3_thumb.jpg", this.bg4_radioButton5);
                thumb_image_loader("4.jpg", "4_thumb.jpg", this.bg5_radioButton6);
                thumb_image_loader("5.jpg", "5_thumb.jpg", this.bg6_radioButton7);
                //--------------------------------
            }
            //=============
            this.bg_panel3.Visible = !this.bg_panel3.Visible;
        }


        void selected_radiobutton_loader()
        {

            string sel_bg;
            sel_bg = Secretariat_Soft.Properties.Settings.Default.selected_bg_name;
            //----
            if (sel_bg == "0.jpg")//first radio button
            {
                this.bg1_radioButton.Checked = true;
            }
            //----
            if (sel_bg == "1.jpg")//2nd radio button
            {
                this.bg2_radioButton3.Checked = true;
            }
            //--------
            //----
            if (sel_bg == "2.jpg")//3rd radio button
            {
                this.bg3_radioButton4.Checked = true;
            }
            //--------
            //----
            if (sel_bg == "3.jpg")//4th radio button
            {
                this.bg4_radioButton5.Checked = true;
            }
            //--------
            //----
            if (sel_bg == "4.jpg")//5th radio button
            {
                this.bg5_radioButton6.Checked = true;
            }
            //--------
            //----
            if (sel_bg == "5.jpg")//6th radio button
            {
                this.bg6_radioButton7.Checked = true;
            }
            //--------
        }
        void thumb_image_loader(string org_file_name,string  thumb_file_name,
                                System.Windows.Forms.RadioButton image_rb_name )
        {
            try
            {
                
                string thumb_fn = Application.StartupPath + "Data\\Pics\\Bg\\"+ thumb_file_name;
                string fn = Application.StartupPath + "Data\\Pics\\Bg\\"+ org_file_name;
                //----------------check if thumbnail file exists------------------
                if (System.IO.File.Exists(thumb_fn) == false)
                {
                    //------------load original image in to filestream -------------
                    FileStream fs = new FileStream(fn, FileMode.Open);
                    //---------------------------
                    Image img = Image.FromStream(fs);
                    //--- 
                    fs.Close();
                    fs.Dispose();
                    //-----------------create thumb image and save it ---------------
                    img.GetThumbnailImage(100, 65, null, IntPtr.Zero).Save(thumb_fn, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //---------------------------------------------------------
                }
                //------------------load thumb image into radiobutton ---------------------------------------
                FileStream fs_thumb = new FileStream(thumb_fn, FileMode.Open);
                image_rb_name.BackgroundImage = Image.FromStream(fs_thumb);
                //---- 
                fs_thumb.Close();
                fs_thumb.Dispose();
                //----------------------------------------------------
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
        }


        void bg_image_loader(string org_file_name)
        {
            try
            {
                
                string fn = Application.StartupPath + "Data\\Pics\\Bg\\" + org_file_name;
                 string fn_resized = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_full_img.jpg" ;
                //----------------check if thumbnail file exists------------------
                if (System.IO.File.Exists(fn) == true)
                {
                    //------------load original image in to filestream -------------
                     Image img = image_loader_from_file(fn);
                    //---------------------------------------------------------
                    //==============resize image to screen size ===========================
                    Bitmap r_img = new Bitmap(img, new Size(this.Width,this.Height ));
                    r_img.Save(fn_resized,System.Drawing.Imaging.ImageFormat.Jpeg);

                    //==================crop sidepanel image=============================== 
                    Image im;
                    im = CropImage(r_img, this.side_panel.Location, this.side_panel.Size);
                    fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_side.jpg";
                    //--------
                    im.Save(fn, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //----
                    this.side_panel.BackgroundImage = im;
                    //==================crop top panel image===============================
                    
                    im = CropImage(r_img, this.Top_Panel.Location, this.Top_Panel.Size);
                    fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_top.jpg";
                    //--------
                    im.Save(fn, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //----
                    this.Top_Panel.BackgroundImage = im;
                    //==================crop bottom panel image============================ 
                 
                    im = CropImage(r_img, this.bottom_panel.Location, this.bottom_panel.Size);
                    fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_bottom.jpg";
                    //--------
                    im.Save(fn, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //----
                    this.bottom_panel.BackgroundImage = im;
                    //==================crop center panel image============================

                    Point main_point = new Point(this.Top_Panel.Location.X,
                                              this.Top_Panel.Location.Y + this.Top_Panel.Height);

                    Size main_size = new Size(this.Top_Panel.Width,
                                      this.Height - this.Top_Panel.Height - this.bottom_panel.Height);
                    //-------------
                    im = CropImage(r_img, main_point, main_size);
                    fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_center.jpg";
                    //--------
                    im.Save(fn, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //----
                    this.BackgroundImage = im;

                    //=====================================================================
                }
                //----------------------------------------------------
                Secretariat_Soft.Properties.Settings.Default.selected_bg_name = org_file_name;
                Secretariat_Soft.Properties.Settings.Default.Save();
                //----------------------------------------------------
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
        }

        void transparent_panel() 
        {
            this.overlay_side_panel2.BackColor = Color.FromArgb(40, Color.Black);
            this.Top_Panel.BackColor = Color.FromArgb(40, Color.Black);
            this.bottom_panel.BackColor = Color.FromArgb(40, Color.Black);
            //--------------------------------
            this.side_panel.BackColor = Color.FromArgb(40, Color.Black);
        }
          void background_image_changer_all()
        {
            string fn;
            Image im;
            //-------------------- sidebar bg loader ------------
            fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_side.jpg";
            //-------------
            if ( System.IO.File.Exists(fn)==true)
            {
                im=image_loader_from_file(fn);
                this.side_panel.BackgroundImage = im;
            }
            //------------------top panel bg loader ---------------------------
             fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_top.jpg";
            //-------------
            if ( System.IO.File.Exists(fn)==true)
            {
                im=image_loader_from_file(fn);
                this.Top_Panel.BackgroundImage = im;
            }
            //--------------------------------------------------------------
            //------------------bottom panel bg loader ---------------------------
            fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_bottom.jpg";
            //-------------
            if (System.IO.File.Exists(fn) == true)
            {
                im = image_loader_from_file(fn);
                this.bottom_panel.BackgroundImage = im;
            }
            //--------------------------------------------------------------
            //------------------center panel bg loader ---------------------------
            fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_center.jpg";
            //-------------
            if (System.IO.File.Exists(fn) == true)
            {
                im = image_loader_from_file(fn);
                this.BackgroundImage = im;
            }
            //--------------------------------------------------------------
        }

        Image image_loader_from_file(string image_file_name)
        {
            FileStream fs = new FileStream(image_file_name, FileMode.Open);
            //---------------------------
            Image img = Image.FromStream(fs);
            //--- 
            fs.Close();
            fs.Dispose();
            //-----
            return img;
        }

        public Image CropImage(Image SrcBmp, Point StartPoint, Size Crop_Size)
        {
            //=================================
            //------------------
            Bitmap DestBmp = new Bitmap(Crop_Size.Width, Crop_Size.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            //-----
            Graphics g = Graphics.FromImage(DestBmp);
            //-----------
            Rectangle SrcRect = new Rectangle(StartPoint, Crop_Size);
            //------------------
            Rectangle DestRect = new Rectangle(new Point(0, 0), Crop_Size);
            //------------------
            g.DrawImage(SrcBmp, DestRect, SrcRect, GraphicsUnit.Pixel);
            //-----------
            //================================
            return DestBmp;
        }

       void custom_image_chooser( string org_img_file_name, string thumb_img_file_name,
                                   System.Windows.Forms.RadioButton r_buttong  )
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //---------------
            DialogResult dr;
            //---filter----
            dlg.Filter = "Jpg Files|*.jpg";
            //-------------
            dr = dlg.ShowDialog();
            //-----------
            if (dr == DialogResult.OK)
            {
                string sfn,dfn,thumb_name;
                sfn = dlg.FileName;
                //--------copy custom image to app folder-------------------
                dfn = Application.StartupPath + "Data\\Pics\\Bg\\"+ org_img_file_name;
                System.IO.File.Copy(sfn, dfn, true);
                //-----------------------------------
                bg_image_loader(org_img_file_name);
                //---------load thumbnail --------------
                thumb_name = Application.StartupPath + "Data\\Pics\\Bg\\" + thumb_img_file_name;
                System.IO.File.Delete(thumb_name);
                //-----
                thumb_image_loader(org_img_file_name, thumb_img_file_name, r_buttong);
                //-------------------------------------
            }
        }
        
        private void bg1_radioButton_Click(object sender, EventArgs e)
        {
            if (this.select_radioButton1.Checked==true)
            {
                bg_image_loader("0.jpg");
            }
            else
            {
                custom_image_chooser("0.jpg", "0_thumb.jpg",this.bg1_radioButton);
            }
             
        }

        private void bg2_radioButton3_Click(object sender, EventArgs e)
        {
            if (this.select_radioButton1.Checked == true)
            {
                bg_image_loader("1.jpg");
            }
            else
            {
                custom_image_chooser("1.jpg", "1_thumb.jpg", this.bg2_radioButton3);
            }
        }

        private void bg3_radioButton4_Click(object sender, EventArgs e)
        {
            if (this.select_radioButton1.Checked == true)
            {
                bg_image_loader("2.jpg");
            }
            else
            {
                custom_image_chooser("2.jpg", "2_thumb.jpg", this.bg3_radioButton4);
            }
        }

        private void bg4_radioButton5_Click(object sender, EventArgs e)
        {
            if (this.select_radioButton1.Checked == true)
            {
                bg_image_loader("3.jpg");
            }
            else
            {
                custom_image_chooser("3.jpg", "3_thumb.jpg", this.bg4_radioButton5);
            }
        }

        private void bg5_radioButton6_Click(object sender, EventArgs e)
        {
            if (this.select_radioButton1.Checked == true)
            {
                bg_image_loader("4.jpg");
            }
            else
            {
                custom_image_chooser("4.jpg", "4_thumb.jpg", this.bg5_radioButton6);
            }
        }

        private void bg6_radioButton7_Click(object sender, EventArgs e)
        {
            if (this.select_radioButton1.Checked == true)
            {
                bg_image_loader("5.jpg");
            }
            else
            {
                custom_image_chooser("5.jpg", "5_thumb.jpg", this.bg6_radioButton7);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bg_changer_button5_Click(sender, e);
        }

        private void in_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Secretariat_Soft.S_Forms.In_Letters_List frm = new S_Forms.In_Letters_List();
            frm.MdiParent = this;
            //----------
            frm.add_butt.Visible = false;
            //-----------
            frm.Show();
        }

        private void out_toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Secretariat_Soft.S_Forms.Out_Letters_List frm = new S_Forms.Out_Letters_List();
            frm.MdiParent = this;
            //----------
            frm.add_butt.Visible = false;
            //-----------
            frm.Show();
        }

        private void about_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Secretariat_Soft.CommForms.About_Us frm = new CommForms.About_Us();
            //-----------
            frm.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //-------------------
            if (this.ActiveMdiChild!=null)
            {
                return;
            }
           //-------------------
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (this.data_entry_butt.Enabled==true )
                    {
                        data_entry_butt_Click(sender, e);
                    }
                   //-------
                    break;

                case Keys.F3:
                    if (  this.reports_butt.Enabled== true)
                    {
                        reports_button2_Click(sender, e);
                    }
                    //-----------
                    break;

                case Keys.F4:
                    if (this.tools_butt.Enabled == true)
                    {
                        button3_Click(sender, e);
                    }
                    //----------
                    break;

                case Keys.F5:
                    if (this.help_butt.Enabled == true)
                    {
                        help_button4_Click(sender, e);
                    }
                    //-----------
                    break;

                default:
                    break;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string fn;
                fn =Environment.GetFolderPath( Environment.SpecialFolder.System);
                System.Diagnostics.Process.Start(fn+"\\calc.exe");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
        }
    }
}
