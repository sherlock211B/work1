using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstwork
{
    public partial class question : Form
    {
        public question()
        {
            InitializeComponent();
        }

        private void srA_Click(object sender, EventArgs e)
        {

        }
        int a, b,num,grade,count;

        string op;

        int result;
        Random rnd = new Random();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtresult.BackColor = Color.FromArgb(255, 255, 255);
            a = rnd.Next(9) + 1;

            b = rnd.Next(9) + 1;

            int c = rnd.Next(4);

            switch (c)
            {
                case 0: op = "+"; result = a + b; break;

                case 1: op = "-"; result = a - b; break;

                case 2: op = "*"; result = a * b; break;

                case 3: op = "/"; result = a / b; break;

            }

            lblA.Text = a.ToString();

            lblB.Text = b.ToString();

            lblop.Text = op;

            txtresult.Text = "";
            count++;

        }

        private void btngrade_Click(object sender, EventArgs e)
        {
           
            if (num > (count/2) )
            {
                txtgradebb.Text = "很棒！答对" + num + "题，得分：" + grade ;
                MessageBox.Show("很棒！答对" + num + "题，得分：" + grade);
               
            }
            else
            {
                txtgradebb.Text = "还要努力哦！答对" + num + "题，得分：" + grade;

            }
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            string str = txtresult.Text;

            double d = double.Parse(str);

            string disp = "" + a + op + b + "=" + str + " ";

            if (d == result) // if( Math.Abs(d-result)< 1e-3 )
            {
                disp += "√";
                txtresult.BackColor = Color.FromArgb(0, 255, 0);
                num++;
            }
            else
            {
                disp += "╳";
                txtresult.BackColor = Color.FromArgb(255, 0, 0);
            }

            grade = num * 2;
            lblgrade.Text = grade.ToString();
            lstresult.Items.Add(disp);

        }

    }

}
