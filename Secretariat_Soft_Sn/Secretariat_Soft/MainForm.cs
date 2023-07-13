using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
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

        private void min_butt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //------------------- load date -------------------
            get_date_cal();
            //-------------------------------------------------
        }
        
        void get_date_cal()
        {
            this.Year_num_lbl.Text = System.DateTime.Now.Year.ToString();
            int mn = System.DateTime.Now.Month; // 7월이면 숫자 7 로 나옴
            string month_name;
            month_name = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mn);
            this.month_name_lbl.Text = month_name;
            //this.month_name_lbl.Text = System.DateTime.Now.Month.ToString();
            this.day_month_lbl.Text = System.DateTime.Now.Day.ToString();
            this.day_week_lbl.Text = System.DateTime.Now.DayOfWeek.ToString();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
