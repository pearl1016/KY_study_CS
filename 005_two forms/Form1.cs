using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_two_forms
{
    public partial class Form1 : Form //form으로부터 상속받은
    {
        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(500, 500);

            button1.Width = 100;
            button1.Height = 50;
            //button1.Location = new Point(500 / 2 - button1.Width / 2, 500 / 2 - button1.Height / 2);
            button1.Location = new Point(200, 225);
            button1.Text = "Form2 생성";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form f2 = new Form2();
            this.AddOwnedForm(f2);

            f2.Show();
        }
    } 
}
