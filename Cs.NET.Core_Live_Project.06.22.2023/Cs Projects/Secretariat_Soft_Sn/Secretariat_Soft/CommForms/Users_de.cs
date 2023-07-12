using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat_Soft.CommForms
{
    public partial class Users_de : Form
    {
        public Users_de()
        {
            InitializeComponent();
        }

        bool is_del_clicked = false;

        private void Users_de_Load(object sender, EventArgs e)
        {
            //------------------------
            is_del_clicked = false;
            //-----------------------
            enable_add_edit_del_butt();
            //------------------------
            try
            {
                Int32 id;
                Int32.TryParse(this.id_label5.Text, out id);
                //---------
                //-------------
                this.appUsersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.appUsersTableAdapter1.FillBy_id(this.letters1.AppUsers, id);
                //-------------------------
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
            //------------------------
            object_perm_loader();
            //-----------------------
        }


        void object_perm_loader()
        {
            Secretariat_Soft.MyClasses.ComClass MyClass = new MyClasses.ComClass();
            //-----------load the permissions by col name -----------------
            this.add_butt.Enabled = MyClass.get_permission_by_col_name("User_de_b1");// new
            this.edit_butt.Enabled = MyClass.get_permission_by_col_name("User_de_b2");//edit
            this.del_butt.Enabled = MyClass.get_permission_by_col_name("User_de_b3");//del
             //-------------------------------------------------------------
            //-----------
            if (Secretariat_Soft.Properties.Settings.Default.User_Id == Secretariat_Soft.Properties.Settings.Default.admin_user_id)
            {
                 this.add_butt.Enabled = true;
                 this.edit_butt.Enabled = true;
                 this.del_butt.Enabled = true;
            }
        }

        void enable_add_edit_del_butt()
        {
            this.main_gbox.Enabled = false;
            //-----------------------
            this.cancel_butt.Enabled = false;
            this.save_butt.Enabled = false;
            //-----------------------
            this.add_butt.Enabled = true;
            this.edit_butt.Enabled = true;
            this.del_butt.Enabled = true;
            //-----------------------
            //------------------------
            object_perm_loader();
            //-----------------------
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
            //------------------------
             
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
            //------------------------
           
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
            this.appusers_bindingSource1.AddNew();
            sys_date_time();
             //-----------------------
            is_del_clicked = false;
            this.pass_repeat_textBox1.Text = "";
        }

        private void edit_butt_Click(object sender, EventArgs e)
        {
            disable_add_edit_del_butt();
            //-----------------------
            sys_date_time();
            //-----------------------
            is_del_clicked = false;
            this.pass_repeat_textBox1.Text = "";
        }

        private void del_butt_Click(object sender, EventArgs e)
        {
            //---------------------------
            if (this.id_label21.Text==Secretariat_Soft.Properties.Settings.Default.admin_user_id.ToString())//is admin user
            {
                System.Windows.Forms.MessageBox.Show("Can't delete the admin user!");
                return;
            }
            //---------------------------
            disable_del_butt();
            //---------------------------
            this.appusers_bindingSource1.RemoveCurrent();
            //---------------------------
            is_del_clicked = true;
        }

        private void save_butt_Click(object sender, EventArgs e)
        {
            try
            {
                if (is_del_clicked == false)
                {
                    //=======================================================
                    //------------Validator------
                    if (this.pass_textBox2.Text == "")
                    {
                        System.Windows.Forms.MessageBox.Show("The password can not be empty!");
                        return;
                    }
                    //-----------
                    if (this.pass_textBox2.Text != this.pass_repeat_textBox1.Text)
                    {
                        System.Windows.Forms.MessageBox.Show("The password and it's repeat should be similar!");
                        return;
                    }
                    //====================

                    //=======================================================
                }


                //---------------------------
                //---------------------------
                this.appusers_bindingSource1.EndEdit();
                //---------------------------
                int r;
                //-------------
                this.appUsersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                r = this.appUsersTableAdapter1.Update(this.letters1.AppUsers);
                //---------------------------
                if (r > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Saved! Count: " + r.ToString());
                    if (is_del_clicked == true)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Not Saved! ");
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
            this.appusers_bindingSource1.CancelEdit();
            this.letters1.AppUsers.RejectChanges();
            //------------------------
        }

        private void browse_button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //---------------
            DialogResult dr;
            //---filter----
            dlg.Filter = "Jpg Files|*.jpg|Png Files|*.png";
            //-------------
            dr= dlg.ShowDialog();
            //-----------
            if (dr==DialogResult.OK)
            {
                string fn;
                fn=dlg.FileName;
                //--------
                this.user_pictureBox1.LoadAsync(fn);
            }
        }

        private void Users_de_KeyDown(object sender, KeyEventArgs e)
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
 
                default:
                    break;
            }
        }
    }
}
