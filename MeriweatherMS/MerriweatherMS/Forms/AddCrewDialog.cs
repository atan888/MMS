using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS
{
    public partial class AddCrewDialog : Form
    {
        string m_CustomerJobID = "";
        DateTime SelectedDate = DateTime.Now;

        public bool AssignDate
        {
            get { return AssignDateCheckBox.Checked; }
            set
            {
                AssignDateCheckBox.Checked = value;
            }
        }

        public DateTime selecteddate
        {
            get { return SelectedDate; }
            set
            {
                SelectedDate = value;
            }
        }


        public AddCrewDialog(string JobID)
        {
            m_CustomerJobID = JobID;
            InitializeComponent();
        }        

        private void AddCrewDialog_Load(object sender, EventArgs e)
        {
            this.crewTableAdapter.Fill(this.mMSDataSet.Crew);
            this.employeeTableAdapter.FillBy(this.mMSDataSet.Employee, true);

            //initialize the selected crew if jobid is provided
            if (m_CustomerJobID.Length > 0)
            {
                InitializeSelection();
            }

            AssignDateCheckBox.Checked = true;
            JobDateTimePicker.Enabled = AssignDateCheckBox.Checked;
        }

        private void InitializeSelection()
        {
            System.Windows.Forms.MMS.Data.MMSDataSet.CrewDataTable myDataTable = new System.Windows.Forms.MMS.Data.MMSDataSet.CrewDataTable();
            crewTableAdapter.FillBy(myDataTable,Convert.ToInt32(m_CustomerJobID));
            
            foreach (DataRow dRow in myDataTable.Rows)
            {
                string empId = dRow["EmployeeID"].ToString();
                int rowCount = employeeDataGridView.RowCount;
                for (int row = 0; row < rowCount; row++)
                {
                    if (this.employeeDataGridView.Rows[row].Cells[0].Value.ToString() == empId)
                    {
                        this.employeeDataGridView.Rows[row].Cells[3].Value = true;
                        break;
                    }
                }
            }
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                employeeBindingSource.Filter = "Contractor > 0";
            else
                employeeBindingSource.Filter = "Contractor < 1";

        }

        private void okButton_Click(object sender, EventArgs e)
        {

            SelectedDate = JobDateTimePicker.Value;
            this.Close();
        }

        public string UpdateCreateCrew(string szCustomerJobID)
        {
            string szCrewKey = "";

            //clear crew for the jobid
            crewTableAdapter.DeleteJobIDQuery(Convert.ToInt32(szCustomerJobID));            

            //traverse throught the datatable and see which one is selected
            int rowCount = employeeDataGridView.RowCount;
            for (int row = 0; row < rowCount; row++)
            {
                if ((this.employeeDataGridView.Rows[row].Cells[3].Value != null) &&
                    (this.employeeDataGridView.Rows[row].Cells[3].Value.ToString() == "True"))
                {
                    //get the selected employee id
                    string employeeID = employeeDataGridView.Rows[row].Cells[0].Value.ToString();                    
                    crewTableAdapter.Insert(Convert.ToInt32(employeeID), Convert.ToInt32(szCustomerJobID));

                    string szFName = employeeDataGridView.Rows[row].Cells[1].Value.ToString();  //fname
                    szFName = szFName.Remove(1);
                    string szLName = employeeDataGridView.Rows[row].Cells[2].Value.ToString();  //name
                    szLName = szLName.Remove(2);
                    szCrewKey += (szFName + szLName + ",");
                }                
            }
            if (szCrewKey.Length > 0)
                szCrewKey = szCrewKey.Remove(szCrewKey.Length - 1);

            return szCrewKey;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            JobDateTimePicker.Enabled = AssignDateCheckBox.Checked;
        }
    }
}
