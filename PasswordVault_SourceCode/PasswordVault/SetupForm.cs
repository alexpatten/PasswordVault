using System;
using System.Configuration;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Crypt c = new Crypt();
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["epw"].Value = c.Encrypt(pwTextBox.Text, ConfigurationManager.AppSettings["dcy"]); ;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
            this.Dispose();
        }
    }
}
