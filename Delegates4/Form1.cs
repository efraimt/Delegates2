using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates4
{
    public partial class Form1 : Form
    {
        int Add(int a, int b)
        {
            return a + b;
        }
        int Sub(int a, int b)
        {
            return a - b;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MathAction pointer = Add;
            //pointer(int.Parse(txtMain.Text), int.Parse(textBox2.Text));
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            MathAction pointer = Sub;
            //pointer(int.Parse(txtMain.Text), int.Parse(textBox2.Text));
        }

        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            /*
             A
             B=>A
             A a=new B();
             B b = a as B;
             */



            Button button = sender as Button;
            txtMain.Text += button.Text;
        }

        enum MathActionEnum
        {
            Empty, Add, Sub
        }

        MathActionEnum requestedAction;
        int a, b;


        private void btnActions_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case "-":
                    requestedAction = MathActionEnum.Sub;
                    break;
                case "+":
                    requestedAction = MathActionEnum.Add;
                    break;
                default:
                    break;
            }

            a = int.Parse(txtMain.Text);

            txtMain.Text = string.Empty;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            MathAction action = null;
            b = int.Parse(txtMain.Text);
            switch (requestedAction)
            {
                case MathActionEnum.Empty:
                    MessageBox.Show("Error");
                    break;
                case MathActionEnum.Add:
                    action = Add;
                    break;
                case MathActionEnum.Sub:
                    action = Sub;
                    break;
                default:
                    break;
            }
            txtMain.Text = action(a, b).ToString();
        }
    }
}
