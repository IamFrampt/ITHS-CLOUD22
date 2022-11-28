namespace WinFormsLoadFile
{
    public partial class Form1 : Form
    {
        private string? currentFilePath = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnsavedChanges();
        }

        private void UnsavedChanges()
        {
            string fileName = Path.GetFileName(currentFilePath ?? "New File");
            var result = MessageBox.Show($"Do you want to save unsaved changes to '{fileName}'", "Save Changes?", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (!SaveFile()) return;
            }
            if (result == DialogResult.No)
            {
                this.Text = "New File";
                currentFilePath = null;
                textBox1.Text = String.Empty;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = fileDialog.FileName;
                this.Text = currentFilePath;

                using (StreamReader reader = new StreamReader(currentFilePath))
                    textBox1.Text = reader.ReadToEnd();
                //while(!reader.EndOfStream)
                //{
                //    textBox1.Text += reader.ReadLine() + Environment.NewLine;
                //}
            }

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closing();
        }

        private bool ShowSaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(currentFilePath ?? String.Empty);
            saveFileDialog.FileName = Path.GetFileName(currentFilePath ?? String.Empty);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                this.Text = currentFilePath;
                saveFileAs(currentFilePath);
                return true;
            }
            return false;
        }

        private void closing()
        {
            string fileName = Path.GetFileName(currentFilePath ?? "New File");
            var result = MessageBox.Show($"Do you want to save unsaved changes to '{fileName}'", "Save Changes?", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (!SaveFile()) return;
                Close();
            }
            if (result == DialogResult.No)
            {
                Close();
            }
        }

        private bool SaveFile()
        {
            if (currentFilePath is null)
            {
                return ShowSaveFileDialog();
            }
            else
            {
                saveFileAs(currentFilePath);
                return true;
            }
        }


        private void saveFileAs(string fileName)
        {
            textBox1.Modified = false;
            this.Text = currentFilePath;

            using (StreamWriter writer = new(fileName))
                writer.Write(textBox1.Text);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = (currentFilePath ?? "New File") + (textBox1.Modified ? "*" : "");
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    closing();
        //}
    }
}