namespace _29.DB_Connection
{
    partial class Form1
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.connectionDataSet = new _29.DB_Connection.ConnectionDataSet();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentsTableAdapter = new _29.DB_Connection.ConnectionDataSetTableAdapters.tblStudentsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(126, 339);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(126, 399);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(272, 399);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(412, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(412, 399);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(570, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(570, 399);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(81, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(81, 128);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(81, 173);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(167, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(167, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "Age", true));
            this.txtAge.Location = new System.Drawing.Point(167, 167);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(130, 22);
            this.txtAge.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tblStudentsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(337, 44);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(427, 236);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // connectionDataSet
            // 
            this.connectionDataSet.DataSetName = "ConnectionDataSet";
            this.connectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "tblStudents";
            this.tblStudentsBindingSource.DataSource = this.connectionDataSet;
            // 
            // tblStudentsTableAdapter
            // 
            this.tblStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnAddNew);
            this.Name = "Form1";
            this.Text = "Database Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DataGridView dataGridView;
        private ConnectionDataSet connectionDataSet;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private ConnectionDataSetTableAdapters.tblStudentsTableAdapter tblStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}

