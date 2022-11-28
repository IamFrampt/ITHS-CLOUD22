namespace WinFormsAdvanced
{
    public partial class FormAddUser : Form
    {
        private bool _editMode = false;

        public bool editMode
        {
            get { return _editMode; }
            set 
            { 
                _editMode = value; 
                buttonAdd.Text = _editMode ? "Save" : "Add";
                this.Text = _editMode ? "Edit User" : "Add User";
            }
        }

        public string FirstName
        {
            get { return textBoxFirstName.Text; }
            set { textBoxFirstName.Text = value; }
        }

        public string LastName
        {
            get { return textBoxLastName.Text; }
            set { textBoxLastName.Text = value; }
        }

        public bool UserActivated
        {
            get { return checkBoxActivated.Checked; }
            set { checkBoxActivated.Checked = value; }
        }

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
