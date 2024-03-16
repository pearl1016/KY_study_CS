using System.Security.Cryptography.X509Certificates;

namespace cs.윈도우계산기
{
    public partial class Form1 : Form
    {
        private double saved;
        private bool opFlag = false;
        private char op;
        private bool calcFlag = false;
        private bool calcFalg;

        public Form1()
        {
            InitializeComponent();
            txtResult.Text = "0";
            btnMc.Enabled = false;
            btnMr.Enabled = false;
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            //숫자 버튼 : 0일때는 숫자로 바꾸고, 0이 아닐때는 숫자를 뒤에 붙여서 표시
            Button btn = (Button)sender;

            string s = btn.Text; //s=0

            if (txtResult.Text == "0" || opFlag == true || calcFalg == true)
            {
                txtResult.Text = s;
                opFlag = false;
               
            }
            else if (calcFlag == true)
            {
                txtResult.Text += s;
                txtexp.Text = "";
                calcFlag = false;
            }
            else
                txtResult.Text += s;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnce_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //소수점 버튼
            //소수점이 없으면 소수점을 추가해주고, 있으면 아무것도 하지 않는다.
            //String.Contains() : 어떤 문자열이 포함되어 있는지를 알 수 있는 함수
            if (txtResult.Text.Contains("."))
                return;
            else
                txtResult.Text += ".";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            // saved 값에 현재 txt.Result.Text 값을 op에 의해 연산한다
            // txtExp은 txtResult.Text와 "=" 을 연결한다

            double value = double.Parse(txtResult.Text);
            txtexp.Text += " " + txtResult.Text + " =";

            switch(op)
            {
                case '＋':
                    txtResult.Text = (saved + value).ToString();
                    break;
                case '－':
                    txtResult.Text = (saved - value).ToString();
                    break;
                case '×':
                    txtResult.Text = (saved * value).ToString();
                    break;
                case '÷':
                    txtResult.Text = (saved / value).ToString();
                    break;
            }
            calcFlag = true;
            txtexp.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
              txtResult.Text = "1";
            else
                txtResult.Text += "1";
        }

        private void btnPlusMius_Click(object sender, EventArgs e)
        {
            txtResult.Text = (-double.Parse(txtResult.Text)).ToString();
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            //사칙연산자 처리 함수
            //1.현재 텍스트창의 값을 saved변수에 저장하고
            //2.이후에 숫자버튼이 눌려지면 새로 써지게 한다 (opFlag)
            //3.클릭된 연산자가 4가지중 무엇인지 저장한다(op)

            Button btn = sender as Button;    // = (Button)sender 
            saved = double.Parse(txtResult.Text);
            opFlag = true;
            op = btn.Text[0];
            txtexp.Text = txtResult.Text + " " + btn.Text;
           


        }
    }
}