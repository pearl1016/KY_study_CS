using System;
using System.Windows.Forms;

namespace _004_hello
{
    public partial class Form1 : Form
    {
        private bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false) {
                label1.Text = "Hello! windows Forms Allplication!";
                flag = true;
            }
            else {
                label1.Text = "";
                flag = false;
            }
            
        }

        //click을 한번누르면 문장이 생기고, 두번 누르면 문장이 사라지는 프로그램

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
