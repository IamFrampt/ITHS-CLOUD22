using System.Windows.Forms;

namespace WinFormsIntro
{
    public partial class Form1 : Form
    {
            string message;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnclickme.Text = Message.Text;
        }

        private void ExitClick(object sender, EventArgs e)
        {
           
        }
    }
}