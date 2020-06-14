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
    public partial class FrmOperators : Form
    {
        public FrmOperators()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtp.Text);
            double b = Convert.ToDouble(txtq.Text);
            double c = Convert.ToDouble(txtr.Text);
            double Disc = Math.Pow(b, 2) - 4 * a * c;
            //formula
           double res = (-b + Math.Sqrt(Disc)) / (2 * a);//x1
           double res2 = (-b - Math.Sqrt(Disc)) / (2 * a);//x2


            //display result
            
            LblRes.Text = "x1:\t" + Convert.ToString(res);
            LblRes.Text = LblRes.Text + "\n\n" + "x2:\t" + Convert.ToString(res2);



        }
    }
}
