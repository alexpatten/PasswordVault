namespace PasswordVault
{
    partial class CreateForm
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
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label uSERNAMELabel;
            System.Windows.Forms.Label pASSWORDLabel;
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.vDBDataSet = new PasswordVault.VDBDataSet();
            this.vDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDBTableAdapter = new PasswordVault.VDBDataSetTableAdapters.VDBTableAdapter();
            this.tableAdapterManager = new PasswordVault.VDBDataSetTableAdapters.TableAdapterManager();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            nAMELabel = new System.Windows.Forms.Label();
            uSERNAMELabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(42, 19);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(41, 13);
            nAMELabel.TabIndex = 99;
            nAMELabel.Text = "NAME:";
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.Location = new System.Drawing.Point(12, 45);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(71, 13);
            uSERNAMELabel.TabIndex = 99;
            uSERNAMELabel.Text = "USERNAME:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(10, 71);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(73, 13);
            pASSWORDLabel.TabIndex = 99;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(87, 108);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 34);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "SUBMIT";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(168, 108);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 34);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // vDBDataSet
            // 
            this.vDBDataSet.DataSetName = "VDBDataSet";
            this.vDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDBBindingSource
            // 
            this.vDBBindingSource.DataMember = "VDB";
            this.vDBBindingSource.DataSource = this.vDBDataSet;
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
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDBBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(89, 12);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(220, 20);
            this.nAMETextBox.TabIndex = 0;
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDBBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(89, 38);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(220, 20);
            this.uSERNAMETextBox.TabIndex = 1;
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDBBindingSource, "PASSWORD", true));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(89, 64);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(220, 20);
            this.pASSWORDTextBox.TabIndex = 2;
            this.pASSWORDTextBox.UseSystemPasswordChar = true;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 158);
            this.Controls.Add(pASSWORDLabel);
            this.Controls.Add(this.pASSWORDTextBox);
            this.Controls.Add(uSERNAMELabel);
            this.Controls.Add(this.uSERNAMETextBox);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Name = "CreateForm";
            this.Text = "Add Credentials";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private VDBDataSet vDBDataSet;
        private System.Windows.Forms.BindingSource vDBBindingSource;
        private VDBDataSetTableAdapters.VDBTableAdapter vDBTableAdapter;
        private VDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
    }
}