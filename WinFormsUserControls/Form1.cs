namespace WinFormsUserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void newPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newPage = new("Pew pew.");
            tabControl1.TabPages.Add(newPage);
            UserControl1 myUserControl = new UserControl1();
            newPage.Controls.Add(myUserControl);
            myUserControl.Dock = DockStyle.Fill;
        }
    }
}