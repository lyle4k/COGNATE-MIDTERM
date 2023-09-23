using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSprinkler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Sched_Click(object sender, EventArgs e)
        {
            pnl_Schedule.Visible = false;
            pnl_Insertsched.Visible = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            
            pnl_Schedule.Visible = true;
        }
    }
}
