namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private Game game = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Click(button1,0,label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Click(button2, 1, label1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.Click(button3, 2, label1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.Click(button4, 3, label1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game.Click(button5, 4, label1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            game.Click(button6, 5, label1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            game.Click(button7, 6, label1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            game.Click(button8, 7, label1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            game.Click(button9, 8, label1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
