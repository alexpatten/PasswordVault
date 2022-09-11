using System;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vDBDataSet.VDB' table. You can move, or remove it, as needed.
            //this.vDBTableAdapter.Fill(this.vDBDataSet.VDB);

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Form checkForm1 = Application.OpenForms["CreateForm"]; // Check if form is open
            Form checkForm2 = Application.OpenForms["PasswordListForm"]; // Check if form is open

            if (checkForm1 == null && checkForm2 == null) // If both forms is not open
            {
                CreateForm createForm = new CreateForm(); // Create object for CreateForm
                createForm.Show(); // Open form
            } 
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            Form checkForm1 = Application.OpenForms["CreateForm"]; // Check if form is open
            Form checkForm2 = Application.OpenForms["PasswordListForm"]; // Check if form is open
            
            if (checkForm2 == null && checkForm1 == null) // If both forms are not open
            {
                PasswordListForm epForm = new PasswordListForm(); // Create object for EditPasswordsForm
                epForm.Show(); // Open form
            }   
        }
    }
}
