namespace CubHelper
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repet repet = new Repet();
            repet.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Study study = new Study();
            study.Show();
            this.Hide();
        }
    }
}