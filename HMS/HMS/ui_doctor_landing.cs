﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class ui_doctor_landing : Form
    {
        String d_id, name, dept, queue;
        DataTable dataTable;

        private void btn_stay_Click(object sender, EventArgs e)
        {
            if (grid_patients_dept.SelectedCells.Count > 0)
            {
                int selectedrowindex = grid_patients_dept.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_patients_dept.Rows[selectedrowindex];
                string patient = Convert.ToString(selectedRow.Cells["ID"].Value);
                DBhelper.update("update patient set num_of_days_admitted=num_of_days_admitted+1 where p_id='" + patient + "'");
                loadPatients();
            }
        }

        private void btn_discharge_doc_Click(object sender, EventArgs e)
        {
            if (grid_patients_dept.SelectedCells.Count > 0)
            {
                int selectedrowindex = grid_patients_dept.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_patients_dept.Rows[selectedrowindex];
                string dischargedPatient = Convert.ToString(selectedRow.Cells["ID"].Value);
                DialogResult dialogResult = MessageBox.Show("Discharge " + dischargedPatient + "?", "Confirm discharge", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    DBhelper.discharge_doc(dischargedPatient, dept);
                    lbl_patient_queue.Text = (int.Parse(lbl_patient_queue.Text) - 1).ToString();
                    DBhelper.update("update doctor set assigned_patients=assigned_patients-1 where d_id='" + d_id + "'");
                    loadPatients();
                }
            }
        }

        public ui_doctor_landing(String id)
        {
            InitializeComponent();
            d_id = id;
            dataTable = DBhelper.read("select * from doctor where d_id='" + d_id + "'");
            DataRow dataRow = dataTable.Rows[0];
            name = dataRow["NAME"].ToString();
            dept = dataRow["DEPTNAME"].ToString();
            queue = dataRow["ASSIGNED_PATIENTS"].ToString();
            lbl_doc_name.Text = name;
            lbl_doc_dept.Text = dept;
            lbl_patient_queue.Text = queue;
            this.Text = d_id;
            loadPatients();
        }

        void loadPatients() {
            dataTable = DBhelper.read("select patient.P_ID as ID,PNAME as Name,AGE as Age,SYMPTOMS as Symptoms,NUM_OF_DAYS_ADMITTED as Days_admitted, STATUS as status " +
                                      "from patient " +
                                      "where patient.department='" + dept + "' and status='admitted'");
            if (dataTable != null)
            {
                grid_patients_dept.DataSource = dataTable;
            }
        }
    }
}
