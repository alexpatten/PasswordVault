using System;
using System.Configuration;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class PasswordListForm : Form
    {
        private Crypt c = new Crypt();
        public PasswordListForm()
        {
            InitializeComponent();
        }

        private void EditPasswordsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vDBDataSet.VDB' table. You can move, or remove it, as needed.
            this.vDBTableAdapter.Fill(this.vDBDataSet.VDB);
        }

        private void copyPassBtn_Click(object sender, EventArgs e)
        {
            string value = vDBDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Clipboard.SetText(c.Decrypt(value,ConfigurationManager.AppSettings["dcy"]));
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in vDBDataGridView.SelectedRows)
                    if (!row.IsNewRow) vDBDataGridView.Rows.Remove(row);
                this.Validate(); // Validate
                this.vDBBindingSource.EndEdit(); // End DB edit
                this.tableAdapterManager.UpdateAll(this.vDBDataSet); // Update DB
            }            
        }
    }
}
