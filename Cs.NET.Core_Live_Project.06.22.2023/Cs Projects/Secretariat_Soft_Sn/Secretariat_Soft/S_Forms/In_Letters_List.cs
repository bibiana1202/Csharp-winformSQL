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
    public partial class In_Letters_List : Form
    {
        public In_Letters_List()
        {
            InitializeComponent();
        }

        private void In_Letters_Form_Load(object sender, EventArgs e)
        {
            //TO DO: Uncomment this before publishing!
            //------------------
             object_perm_loader();
            //------------------
            try
            {
                //-------------
                //to do
                this.sa_In_LettersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.sa_In_LettersTableAdapter1.Fill(this.letters1.Sa_In_Letters);
                //------------------------
                record_position();
                //-------------------------
            }
            catch (Exception  ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
        }

        void object_perm_loader()
        {
            Secretariat_Soft.MyClasses.ComClass MyClass = new MyClasses.ComClass();
            //-----------load the permissions by col name -----------------
            this.add_butt.Enabled = MyClass.get_permission_by_col_name("In_List_b1");// add
            this.search_butt.Enabled = MyClass.get_permission_by_col_name("In_List_b2");//search
             this.print_butt.Enabled = MyClass.get_permission_by_col_name("In_List_b3");//print
           //-------------------------------------------------------------
            if (Secretariat_Soft.Properties.Settings.Default.User_Id == Secretariat_Soft.Properties.Settings.Default.admin_user_id)
            {
                //this.usersToolStripMenuItem.Enabled = true;
            }
        }
        void record_position()
        {
             int p;
            p = this.in_letters_bindingSource1.Position;
            p = p + 1;
            this.position_tbox.Text =p.ToString();
            //-----------
            this.total_records_lbl.Text=" of "+ this.in_letters_bindingSource1.Count.ToString();
        }
        private void First_butt_Click(object sender, EventArgs e)
        {
            this.in_letters_bindingSource1.MoveFirst();
            //------------------------
            record_position();
            //-------------------------
        }

        private void prev_butt_Click(object sender, EventArgs e)
        {
            this.in_letters_bindingSource1.MovePrevious();
            //------------------------
            record_position();
            //-------------------------
        }

        private void next_butt_Click(object sender, EventArgs e)
        {
            this.in_letters_bindingSource1.MoveNext();
            //------------------------
            record_position();
            //-------------------------
        }

        private void last_butt_Click(object sender, EventArgs e)
        {
            this.in_letters_bindingSource1.MoveLast();
            //------------------------
            record_position();
            //-------------------------
        }

        private void search_butt_Click(object sender, EventArgs e)
        {
            this.search_panel1.Visible = !this.search_panel1.Visible;
            this.search_panel2.Visible = !this.search_panel2.Visible;
        }

        private void search_id_butt_Click(object sender, EventArgs e)
        {
            try
            {
                long id;
                long.TryParse(this.id_textBox1.Text, out id);
                //-------------
                this.sa_In_LettersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.sa_In_LettersTableAdapter1.FillBy_ID(this.letters1.Sa_In_Letters,id);
                //------------------------
                record_position();
                //-------------------------
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void subject_search_butt_Click(object sender, EventArgs e)
        {
            try
            {
                string sb;
                sb = "%" + this.subject_textBox1.Text + "%";
                //---------------
                //-------------
                this.sa_In_LettersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.sa_In_LettersTableAdapter1.FillBy_subject_like(this.letters1.Sa_In_Letters,sb);
                //------------------------
                record_position();
                //-------------------------
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
          
        }

        private void date_search_button1_Click(object sender, EventArgs e)
        {
            try
            {
                string d1,d2;
                d1 = this.first_dateTimePicker1.Value.ToString();
                d2 = this.second_dateTimePicker2.Value.ToString();
                //---------------
                //-------------
                this.sa_In_LettersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.sa_In_LettersTableAdapter1.FillBy_regdate(this.letters1.Sa_In_Letters,d1,d2);
                //------------------------
                record_position();
                //-------------------------
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void add_butt_Click(object sender, EventArgs e)
        {
          
            try
            {
                Secretariat_Soft.S_Forms.In_Letters_De frm=new In_Letters_De();
                frm.id_label5.Text = this.id_label5.Text;
                frm.ShowDialog();
                //--------------------
                //-------------
                //to do
                this.sa_In_LettersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.sa_In_LettersTableAdapter1.Fill(this.letters1.Sa_In_Letters);
                //------------------------
                //record_position();
                //-------------------------
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
            //--------------------
        }

        private void print_butt_Click(object sender, EventArgs e)
        {
           
        }

        private void incomingLettersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fn, xml_fn;
            //---------------
            xml_fn = Application.StartupPath + "Data\\Reps\\help.mp3";
            this.letters1.WriteXml(xml_fn);
            //---------------
            fn = Application.StartupPath + "MyRep.exe";
            System.Diagnostics.Process.Start(fn, "InputList.rpt");
        }

        private void incomingLetersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fn, xml_fn;
            //---------------
            xml_fn = Application.StartupPath + "Data\\Reps\\help.mp3";
            this.letters1.WriteXml(xml_fn);
            //---------------
            fn = Application.StartupPath + "MyRep.exe";
            System.Diagnostics.Process.Start(fn, "InputSingle.rpt");
        }

        private void In_Letters_List_KeyDown(object sender, KeyEventArgs e)
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
                    if (this.search_butt.Enabled == true)
                    {
                        search_butt_Click(sender, e);
                    }
                    //-----------
                    break;

                case Keys.F4:
                    if (this.print_butt.Enabled == true)
                    {
                        this.print_butt.ShowDropDown();
                    }
                    //----------
                    break;

                

                default:
                    break;
            }
        }
    }
}
