using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class CredentialsForm : Form
    {
        public CredentialsForm()
        {
            InitializeComponent();
        }

        private void setupBtn_Click(object sender, EventArgs e)
        {
            Form checkForm1 = Application.OpenForms["SetupForm"]; // Check if form is open

            if (checkForm1 == null && checkForm1 == null) // If both forms are not open
            {
                SetupForm sf = new SetupForm(); // Create object for EditPasswordsForm
                sf.Show(); // Open form
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // If password blank
            if(pwTextBox.Text == "") { errorLabel.Text = "Password cannot be blank."; }
            // If password is less than 12 characters
            else if(pwTextBox.Text.Length < 12) { errorLabel.Text = "Password must be 12 characters or longer."; }
            // If password passes
            else
            {
                Crypt c = new Crypt();
                string dcp = c.Decrypt(ConfigurationManager.AppSettings["epw"], ConfigurationManager.AppSettings["dcy"]);
                if(dcp == pwTextBox.Text)
                {
                    MainForm mf = new MainForm(); // Create object for EditPasswordsForm
                    mf.Show(); // Open form
                    this.Hide();
                }
                else { errorLabel.Text = "Inccorect password."; }
            }
        }
    }
}
