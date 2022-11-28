using System.Diagnostics;

namespace WinFormsControls
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "My MessageBox");
            labelvirus.Text = "You got virus. Congratulations!!";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Fatal Error!", "Fatal Error");
            linkLabel1.LinkVisited = true;
            Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.ithsdistans.se/") { UseShellExecute = true });

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = checkBox1.Checked;
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = "Red";
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                textBox1.ForeColor = Color.Blue;
                textBox1.Text = "Blue";
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
        }
        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked)
            {
                textBox1.ForeColor = Color.Green;
                textBox1.Text = "Green";
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
        }

        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "Black";
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox2.SelectedItem.ToString();
        }


        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Text = comboBox2.Text;

                if (!comboBox2.Items.Contains(comboBox2.Text))
                {
                    comboBox2.Items.Add(comboBox2.Text);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = string.Empty;
            foreach (var item in listBox1.SelectedItems)
                text += item.ToString() + Environment.NewLine;
            textBox2.Text = text;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)numericUpDown1.Value;
            textBox1.Text = new string('X', count);
            progressBar1.Value = 5 * count;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}