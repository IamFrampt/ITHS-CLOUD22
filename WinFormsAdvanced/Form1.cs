namespace WinFormsAdvanced
{
    public partial class Form1 : Form
    {
        DataGridViewCell activeCell;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my application v1.0", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUser AddUser = new();

            if (AddUser.ShowDialog() == DialogResult.OK)
            {
                addUSER(AddUser.FirstName, AddUser.LastName, AddUser.UserActivated);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addUSER("Mikael", "Eriksson", true);
            addUSER("Paulina", "Jonsson", true);
        }

        private void addUSER(string firstName, string lastName, bool isActive)
        {
            int rowIndex = dataGridViewUsers.Rows.Add();
            dataGridViewUsers.Rows[rowIndex].Cells["FirstName"].Value = firstName;
            dataGridViewUsers.Rows[rowIndex].Cells["LastName"].Value = lastName;
            dataGridViewUsers.Rows[rowIndex].Cells["IsActive"].Value = isActive;

        }

        private void dataGridViewUsers_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitData = dataGridViewUsers.HitTest(e.X, e.Y);
                if (hitData.ColumnIndex < 0 || hitData.RowIndex < 0) return;
                activeCell = dataGridViewUsers.Rows[hitData.RowIndex].Cells[hitData.ColumnIndex];
                dataGridViewUsers.Rows[activeCell.RowIndex].Selected = true;
                contextMenuStrip1.Show(dataGridViewUsers, e.Location);
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.RemoveAt(activeCell.RowIndex);
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new();
            DataGridViewRow activeRow = dataGridViewUsers.Rows[activeCell.RowIndex];
            formAddUser.FirstName = activeRow.Cells["FirstName"].Value.ToString();
            formAddUser.LastName = activeRow.Cells["LastName"].Value.ToString();
            formAddUser.UserActivated = (bool)activeRow.Cells["IsActive"].Value;
            formAddUser.editMode = true;

            if (formAddUser.ShowDialog() == DialogResult.OK)
            {
                activeRow.Cells["FirstName"].Value = formAddUser.FirstName;
                activeRow.Cells["LastName"].Value = formAddUser.LastName;
                activeRow.Cells["IsActive"].Value = formAddUser.UserActivated;
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}