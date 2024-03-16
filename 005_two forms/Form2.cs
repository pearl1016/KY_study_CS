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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ClientSize = new Size(300, 200);
            button1.Width = 100;
            button1.Height = 50;
            button1.Location = new Point(100, 75);
            button1.Text = "Close Form2";
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          CenterToParent();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
