using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int sum = Add(num1, num2);
            MessageBox.Show("Sum: " + sum ,"Result");


        }


        public int Add(int a, int b)
        {
            return a + b;
        }


    }
}
