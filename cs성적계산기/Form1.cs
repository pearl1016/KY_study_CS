namespace cs성적계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void score_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            double sum = Double.Parse(Korea.Text)
                + Double.Parse(Math.Text)
                + Double.Parse(English.Text);

            double Avg = sum / 3;

            txtsum.Text = sum.ToString();
            txtAvg.Text = Avg.ToString("0.0");
        }
    }
}