using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1845317_My_second_app
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void radoReed_CheckedChanged(object sender, EventArgs e)
        {
            radoReed.ForeColor = Color.FromName("red");
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
                rdoGreen.ForeColor = Color.FromName("green");
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            rdoBlue.ForeColor = Color.FromName("Blue");
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            rdoYellow.ForeColor = Color.FromName("Yellow");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoYellow.ForeColor = Color.FromName("Black");
            rdoBlue.ForeColor = Color.FromName("Black");
            rdoGreen.ForeColor = Color.FromName("Black");
            radoReed.ForeColor = Color.FromName("Black");
            radoReed2.ForeColor = Color.FromName("Black");
            rdoBlue2.ForeColor = Color.FromName("Black");
            rdoGreen2.ForeColor = Color.FromName("Black");
            rdoYellow2.ForeColor = Color.FromName("Black");


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen2.Checked == true)
             rdoGreen2.ForeColor = Color.FromName("green");
            radoReed2.ForeColor = Color.FromName("Black");
            rdoBlue2.ForeColor = Color.FromName("Black");
            rdoYellow2.ForeColor = Color.FromName("Black");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radoReed2.Checked == true)
                radoReed2.ForeColor = Color.FromName("red");
            rdoGreen2.ForeColor = Color.FromName("Black");
            rdoBlue2.ForeColor = Color.FromName("Black");
            rdoYellow2.ForeColor = Color.FromName("Black");

        }

        private void rdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue2.Checked == true)
                rdoBlue2.ForeColor = Color.FromName("Blue");
            rdoYellow2.ForeColor = Color.FromName("Black");
            radoReed2.ForeColor = Color.FromName("Black");
            rdoGreen2.ForeColor = Color.FromName("Black");

        }

        private void rdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow2.Checked == true)
                rdoYellow2.ForeColor = Color.FromName("Yellow");
            radoReed2.ForeColor = Color.FromName("Black");
            rdoBlue2.ForeColor = Color.FromName("Black");
            rdoGreen2.ForeColor = Color.FromName("Black");

        }
    }
}
