using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29.DB_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'connectionDataSet.tblStudents' table. You can move, or remove it, as needed.
            this.tblStudentsTableAdapter.Fill(this.connectionDataSet.tblStudents);
            Opacity = 0.95;
            CenterToParent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tblStudentsBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tblStudentsBindingSource.EndEdit();
            //tblStudentsTableAdapter.Update(connectionDataSet.tblStudents);
            try
            {
                tblStudentsTableAdapter.Update(connectionDataSet.tblStudents);
                MessageBox.Show("Record saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tblStudentsBindingSource.RemoveCurrent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblStudentsBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblStudentsBindingSource.MoveLast();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tblStudentsBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblStudentsBindingSource.MoveNext();
        }
    }
}
