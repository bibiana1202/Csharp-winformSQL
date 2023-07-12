using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat_Soft.S_Forms
{
    public partial class In_Letters_De : Form
    {
        public In_Letters_De()
        {
            InitializeComponent();
        }

        private void In_Letters_De_Load(object sender, EventArgs e)
        {
            //-----------------------
           
            is_del_clicked = false;
            //-----------------------
            enable_add_edit_del_butt();
            //------------------------
            //this.sa_In_LettersTableAdapter1.FillBy_id_desc(this.letters1.Sa_In_Letters);
            try
            {
                long id;
                long.TryParse(this.id_label5.Text, out id);
                //---------
                //-------------
                //to do
                this.sa_In_LettersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.sa_In_LettersTableAdapter1.FillBy_ID(this.letters1.Sa_In_Letters, id);
                //-------------------------
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
            //-----------------------
            //TO DO: Uncomment this before publishing!
             object_perm_loader();
            //------------------------
        }

        void object_perm_loader()
        {
            Secretariat_Soft.MyClasses.ComClass MyClass = new MyClasses.ComClass();
            //-----------load the permissions by col name -----------------
            this.add_butt.Enabled = MyClass.get_permission_by_col_name("In_de_b1");// new
            this.edit_butt.Enabled = MyClass.get_permission_by_col_name("In_de_b2");//edit
            this.del_butt.Enabled = MyClass.get_permission_by_col_name("In_de_b3");//del
            this.print_butt.Enabled = MyClass.get_permission_by_col_name("In_de_b4");//print                               //-------------------------------------------------------------
            //-----------
            if (Secretariat_Soft.Properties.Settings.Default.User_Id == Secretariat_Soft.Properties.Settings.Default.admin_user_id)
            {
                //this.usersToolStripMenuItem.Enabled = true;
            }
        }
        void enable_add_edit_del_butt()
        {
            this.main_gbox.Enabled= false;
            //-----------------------
            this.cancel_butt.Enabled = false;
            this.save_butt.Enabled = false;
            //-----------------------
            this.add_butt.Enabled = true;
            this.edit_butt.Enabled = true;
            this.del_butt.Enabled = true;
            //-----------------------
            //-----------------------
            //TO DO: Uncomment this before publishing!
             object_perm_loader();
            //------------------------

        }

        void disable_add_edit_del_butt()
        {
            this.main_gbox.Enabled = true;
            //-----------------------
            this.cancel_butt.Enabled = true;
            this.save_butt.Enabled = true;
            //-----------------------
            this.add_butt.Enabled = false;
            this.edit_butt.Enabled = false;
            this.del_butt.Enabled = false;
            //-----------------------
            //-----------------------
           
        }

        void disable_del_butt()
        {
            this.main_gbox.Enabled = false;
            //-----------------------
            this.cancel_butt.Enabled = true;
            this.save_butt.Enabled = true;
            //-----------------------
            this.add_butt.Enabled = false;
            this.edit_butt.Enabled = false;
            this.del_butt.Enabled = false;
            //-----------------------
            //-----------------------
          
        }


        void sys_date_time()
        {
            this.sys_time_lbl.Text = System.DateTime.Now.ToString("HH:mm:ss");
            this.sys_date_lbl.Text = System.DateTime.Now.ToString("yyyy/MM/dd");
            //-----------------------
            this.user_name_lbl.Text = Secretariat_Soft.Properties.Settings.Default.User_name;
            this.user_id_lbl.Text = Secretariat_Soft.Properties.Settings.Default.User_Id.ToString();
            //-----------------------
        }

        private void add_butt_Click(object sender, EventArgs e)
        {

            disable_add_edit_del_butt();
            //-----------------------
            this.bindingSource1.AddNew();
            sys_date_time();
            //-------
            this.letter_time_maskedTextBox1.Text=System.DateTime.Now.ToShortTimeString();
            this.priority_comboBox1.SelectedIndex = 1;
            this.page_count_numericUpDown1.Value = 2;
            //-----------------------
            this.reg_date_maskedTextBox1.Text = new System.DateTime(2010, 10, 21).ToShortDateString();
            this.letter_time_maskedTextBox1.Text = new System.DateTime(2000, 1, 1, 23, 40, 50).ToShortTimeString();
            //-----------------------
            is_del_clicked = false;
        }

        private void edit_butt_Click(object sender, EventArgs e)
        {
            disable_add_edit_del_butt();
            //-----------------------
            sys_date_time();
            //-----------------------
            is_del_clicked = false;
        }

        bool is_del_clicked = false;
        private void del_butt_Click(object sender, EventArgs e)
        {
            disable_del_butt();
            //---------------------------
            this.bindingSource1.RemoveCurrent();
            //---------------------------
            is_del_clicked=true;
        }

        private void save_butt_Click(object sender, EventArgs e)
        {
            try
            {
                if (is_del_clicked==false)
                {
                    //=======================================================
                    //------------Validator------
                    DateTime rr;
                    bool b;
                    b = DateTime.TryParse(this.reg_date_maskedTextBox1.Text, out rr);
                    //-----
                    if (b == false)
                    {
                        System.Windows.Forms.MessageBox.Show("Reg date is not valid!");
                        return;
                    }
                    //====================
                    if (this.res_date_maskedTextBox2.Text != "__/__/____")
                    {
                        b = DateTime.TryParse(this.res_date_maskedTextBox2.Text, out rr);
                        //-----
                        if (b == false)
                        {
                            System.Windows.Forms.MessageBox.Show("Res date is not valid!");
                            return;
                        }
                    }
                    //=======================================================
                }
                
               
                //---------------------------
                //---------------------------
                this.bindingSource1.EndEdit();
                //---------------------------
                int r;
                //-------------
                //to do
                this.sa_In_LettersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                r = this.sa_In_LettersTableAdapter1.Update(this.letters1.Sa_In_Letters);
                //---------------------------
                if (r>0)
                {
                    System.Windows.Forms.MessageBox.Show("Saved! Count: " + r.ToString() );
                    if (is_del_clicked == true)
                    {
                        this.DialogResult= DialogResult.OK;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Not Saved! " );
                }
                //---------------------------
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
            //---------------------------
            enable_add_edit_del_butt();
            //---------------------------
        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            enable_add_edit_del_butt();
            //------------------------
            this.bindingSource1.CancelEdit();
            this.letters1.Sa_In_Letters.RejectChanges();
            //------------------------
        }

        private void today_reg_date_button1_Click(object sender, EventArgs e)
        {
            this.reg_date_maskedTextBox1.Text = System.DateTime.Now.ToShortDateString();
        }

        private void today_res_date_button1_Click(object sender, EventArgs e)
        {
            this.res_date_maskedTextBox2.Text = System.DateTime.Now.ToShortDateString();
        }

        private void today_deadline_button1_Click(object sender, EventArgs e)
        {
            this.deadline_maskedTextBox3.Text = System.DateTime.Now.ToShortDateString();
        }

        private void print_butt_Click(object sender, EventArgs e)
        {
            string fn, xml_fn;
            //---------------
            xml_fn = Application.StartupPath + "Data\\Reps\\help.mp3";
            this.letters1.WriteXml(xml_fn);
            //---------------
            fn = Application.StartupPath + "MyRep.exe";
            System.Diagnostics.Process.Start(fn, "InputSingle.rpt");
        }

        private void In_Letters_De_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (this.add_butt.Enabled == true)
                    {
                        add_butt_Click(sender, e);
                    }
                    //-------
                    break;

                case Keys.F3:
                    if (this.edit_butt.Enabled == true)
                    {
                        edit_butt_Click(sender, e);
                    }
                    //-----------
                    break;

                case Keys.F4:
                    if (this.del_butt.Enabled == true)
                    {
                        del_butt_Click(sender, e);
                    }
                    //----------
                    break;

                case Keys.F5:
                    if (this.save_butt.Enabled == true)
                    {
                        save_butt_Click(sender, e);
                    }
                    //-----------
                    break;

                case Keys.F6:
                    if (this.cancel_butt.Enabled == true)
                    {
                        cancel_butt_Click(sender, e);
                    }
                    //-----------
                    break;

                case Keys.F9:
                    if (this.print_butt.Enabled == true)
                    {
                        print_butt_Click(sender, e);
                    }
                    //-----------
                    break;
                default:
                    break;
            }
        }
    }
}
