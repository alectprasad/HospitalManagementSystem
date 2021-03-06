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
    public partial class ui_reception_landing : Form
    {
        String r_id, name;
        DataTable dataTable;
        public ui_reception_landing(String id)
        {
            InitializeComponent();
            r_id = id;
            dataTable = DBhelper.read("select * from receptionist where r_id='" + r_id + "'");
            DataRow dataRow = dataTable.Rows[0];
            name = dataRow["RNAME"].ToString();
            lbl_recep_name.Text = name;
            this.Text = r_id;
            loadPatients();
        }

        private void btn_new_patient_Click(object sender, EventArgs e)
        {
            new ui_add_patient(r_id, name).Show();
        }

        private void btn_avail_doc_Click(object sender, EventArgs e)
        {
            DBhelper.execute("display_available_doctor");
            dataTable = DBhelper.read("select d_id,deptname from doctor where d_id not in (select d_id from doc_patient)");
            string res = string.Join(Environment.NewLine, dataTable.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            MessageBox.Show(res);
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            if (grid_patient_reception.SelectedCells.Count > 0)
            {
                int selectedrowindex = grid_patient_reception.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_patient_reception.Rows[selectedrowindex];
                string patient = Convert.ToString(selectedRow.Cells["ID"].Value);
                dataTable = DBhelper.read("select * from administration where p_id='" + patient + "'");
                string res = string.Join(Environment.NewLine, dataTable.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
                MessageBox.Show(res);
            }
        }

        void loadPatients()
        {
            dataTable = DBhelper.read("select patient.p_id as ID,pname as NAME,age,symptoms,occupation,num_of_days_admitted as STAY,appoint_date as APPOINTMENT_DATE,wname as WARD,status " +
                                      "from patient,appointment,ward_table " +
                                      "where patient.p_id=appointment.p_id and patient.p_id=ward_table.p_id and r_id='" + r_id + "'");
            if (dataTable != null)
            {
                grid_patient_reception.DataSource = dataTable;
            }
        }
    }
}
