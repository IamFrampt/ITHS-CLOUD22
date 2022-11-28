using WinFormsControls;

namespace WinFormsMultiForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to install virus on your computer?", "Caption", MessageBoxButtons.YesNo);
            int count = 0;
            if (result == DialogResult.Yes)
            {
                progressBar1.Visible = true;
                while (progressBar1.Value < 10000)
                {
                    progressBar1.Value++;
                }
            }

            if (result == DialogResult.No)
            {
                FormEnterName form = new FormEnterName();

                DialogResult NameName = form.ShowDialog();
                if(NameName == DialogResult.OK)
                {
                    labelName.Text = $"Hello {form.name}, we took your money!";
                    labelName.Visible = true;
                }
                else
                {
                    labelName.Text = "Please give me name!!!";
                    labelName.Visible = true;
                }
            }

            if (progressBar1.Value == 10000)
            {
                labelText.Visible = true;
                labelText.Text = "Install Complete.";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button myButton = new Button();
            myButton.Text = "Mu btn";
            myButton.Size = new Size(100, 30);
            myButton.Location = new Point(690,400);
            this.Controls.Add(myButton);
        }
    }
}