using System;
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
    public partial class ui_nurse_landing : Form
    {
        String n_id, name, ward;
        DataTable dataTable;

        private void btn_discharge_Click(object sender, EventArgs e)
        {
            if (grid_patient_ward.SelectedCells.Count > 0)
            {
                int selectedrowindex = grid_patient_ward.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_patient_ward.Rows[selectedrowindex];
                string dischargedPatient = Convert.ToString(selectedRow.Cells["ID"].Value);
                DialogResult dialogResult = MessageBox.Show("Discharge " + dischargedPatient + "?", "Confirm discharge", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    DBhelper.discharge(dischargedPatient, ward);
                    loadPatients();
                }
            }
        }

        public ui_nurse_landing(String id)
        {
            InitializeComponent();
            n_id = id;
            dataTable = DBhelper.read("select * from nurse where n_id='" + n_id + "'");
            DataRow dataRow = dataTable.Rows[0];
            name = dataRow["NNAME"].ToString();
            ward = dataRow["WNAME"].ToString();
            lbl_nurse_name.Text = name;
            lbl_nurse_ward.Text = ward;
            this.Text = id;
            loadPatients();
        }
        void loadPatients()
        {
            dataTable = DBhelper.read("select patient.P_ID as ID,PNAME as Name,AGE as Age,SYMPTOMS as Symptoms,NUM_OF_DAYS_ADMITTED as Days_admitted, STATUS as status " +
                                      "from patient,ward_table,ward " +
                                      "where patient.p_id=ward_table.p_id and ward_table.wname=ward.wname and ward.wname='" + ward + "' and status='admitted'");
            if (dataTable != null)
            {
                grid_patient_ward.DataSource = dataTable;
            }
        }
    }
}
