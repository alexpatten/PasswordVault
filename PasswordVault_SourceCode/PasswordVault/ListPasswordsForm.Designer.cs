namespace PasswordVault
{
    partial class PasswordListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vDBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDBDataSet = new PasswordVault.VDBDataSet();
            this.copyPassBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.vDBTableAdapter = new PasswordVault.VDBDataSetTableAdapters.VDBTableAdapter();
            this.tableAdapterManager = new PasswordVault.VDBDataSetTableAdapters.TableAdapterManager();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vDBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vDBDataGridView
            // 
            this.vDBDataGridView.AllowUserToAddRows = false;
            this.vDBDataGridView.AllowUserToDeleteRows = false;
            this.vDBDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vDBDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vDBDataGridView.DataSource = this.vDBBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vDBDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vDBDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vDBDataGridView.Name = "vDBDataGridView";
            this.vDBDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vDBDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vDBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vDBDataGridView.Size = new System.Drawing.Size(363, 144);
            this.vDBDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "USERNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PASSWORD";
            this.dataGridViewTextBoxColumn4.HeaderText = "PASSWORD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
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
            // copyPassBtn
            // 
            this.copyPassBtn.Location = new System.Drawing.Point(43, 162);
            this.copyPassBtn.Name = "copyPassBtn";
            this.copyPassBtn.Size = new System.Drawing.Size(93, 37);
            this.copyPassBtn.TabIndex = 2;
            this.copyPassBtn.Text = "Copy Password";
            this.copyPassBtn.UseVisualStyleBackColor = true;
            this.copyPassBtn.Click += new System.EventHandler(this.copyPassBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(241, 162);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(93, 37);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
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
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(142, 162);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(93, 37);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // PasswordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 211);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.copyPassBtn);
            this.Controls.Add(this.vDBDataGridView);
            this.Name = "PasswordListForm";
            this.Text = "Password List";
            this.Load += new System.EventHandler(this.EditPasswordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VDBDataSet vDBDataSet;
        private System.Windows.Forms.BindingSource vDBBindingSource;
        private VDBDataSetTableAdapters.VDBTableAdapter vDBTableAdapter;
        private VDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button copyPassBtn;
        public System.Windows.Forms.DataGridView vDBDataGridView;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button delBtn;
    }
}