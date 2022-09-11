namespace PasswordVault
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createBtn = new System.Windows.Forms.Button();
            this.listBtn = new System.Windows.Forms.Button();
            this.vDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDBDataSet = new PasswordVault.VDBDataSet();
            this.vDBTableAdapter = new PasswordVault.VDBDataSetTableAdapters.VDBTableAdapter();
            this.tableAdapterManager = new PasswordVault.VDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 12);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(310, 41);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create Credentials";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(12, 59);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(310, 41);
            this.listBtn.TabIndex = 1;
            this.listBtn.Text = "Credential List";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // vDBBindingSource
            // 
            this.vDBBindingSource.DataMember = "VDB";
            this.vDBBindingSource.DataSource = this.vDBDataSet;
            // 
            // vDBDataSet
            // 
            this.vDBDataSet.DataSetName = "VDBDataSet";
            this.vDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDBTableAdapter
            // 
            this.vDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PasswordVault.VDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VDBTableAdapter = this.vDBTableAdapter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 117);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.createBtn);
            this.Name = "MainForm";
            this.Text = "Secure Offline Password Vault";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VDBDataSet vDBDataSet;
        private System.Windows.Forms.BindingSource vDBBindingSource;
        private VDBDataSetTableAdapters.VDBTableAdapter vDBTableAdapter;
        private VDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button listBtn;
    }
}

