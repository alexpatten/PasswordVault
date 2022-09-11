using System;
using System.Configuration;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class CreateForm : Form
    {
        private Crypt c = new Crypt();
        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vDBDataSet.VDB' table. You can move, or remove it, as needed.
            this.vDBTableAdapter.Fill(this.vDBDataSet.VDB);
            this.vDBBindingSource.AddNew();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.vDBBindingSource.RemoveCurrent(); // Remove last added row
            this.Validate(); // Validate
            this.vDBBindingSource.EndEdit(); // End DB edit
            this.tableAdapterManager.UpdateAll(this.vDBDataSet); // Update DB
            this.Dispose(); // Dispose CreateForm object
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // If all fields have text
            if(nAMETextBox.Text != "" && uSERNAMETextBox.Text != "" && pASSWORDTextBox.Text != "")
            {
                pASSWORDTextBox.Text = c.Encrypt(pASSWORDTextBox.Text, ConfigurationManager.AppSettings["dcy"]);
                this.Validate(); // Validate
                this.vDBBindingSource.EndEdit(); // End DB edit
                this.tableAdapterManager.UpdateAll(this.vDBDataSet); // Update DB
                this.Dispose(); // Dispose CreateForm object
            }
        }
    }
}
