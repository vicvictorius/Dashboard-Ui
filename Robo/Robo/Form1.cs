namespace Robo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Enter Username";
                    return;

                }
                textBox1.ForeColor = Color.White;
                panel6.Visible = false;
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "Password";
                    return;
                }
                textBox2.ForeColor = Color.White;
                panel8.Visible = false;
            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Lime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                panel6.Visible = true;
                textBox1.Focus();
                return;

            }
            if (textBox2.Text == "Password Password")
            {
                panel8.Visible = true;
                textBox2.Focus();
                return;

            }

        }
    }
}

