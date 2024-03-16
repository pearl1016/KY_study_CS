using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmiForms
{
    public partial class Form1 : Form //form을 상속받는 form1
    {
        public Form1() //생성자 함수
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float h = float.Parse(textBox1.Text)/ 100;
            float w = float.Parse(textBox2.Text);
            float bmi = w / (h * h);

        }
    }
}
