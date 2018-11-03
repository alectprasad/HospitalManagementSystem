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
    public partial class ui_add_patient : Form
    {
        String r_id, name;
        public ui_add_patient(String id, String name)
        {
            InitializeComponent();
            r_id = id;
            this.name = name;
            lbl_r_id.Text = r_id;
            this.Text = "New Patient";
            enableAdd();
            DataTable dataTable = DBhelper.read("select deptname from department");
            list_dept.DataSource = dataTable;
            list_dept.DisplayMember = "DEPTNAME";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void enableAdd()
        {
            btn_add_patient.Enabled = !(String.IsNullOrWhiteSpace(tb_age.Text)
                                     || String.IsNullOrWhiteSpace(tb_family.Text)
                                     || String.IsNullOrWhiteSpace(tb_name.Text)
                                     || String.IsNullOrWhiteSpace(tb_occupation.Text)
                                     || String.IsNullOrWhiteSpace(tb_relation.Text)
                                     || String.IsNullOrWhiteSpace(tb_symptom.Text)
                                     || String.IsNullOrWhiteSpace(tb_pid.Text)
                                     || list_dept.SelectedIndex == -1);
        }

        Boolean validate() {
            if (tb_age.Text.Length < 15
                && tb_family.Text.Length < 15
                && tb_name.Text.Length < 15
                && tb_relation.Text.Length < 15
                && tb_symptom.Text.Length < 15
                && tb_occupation.Text.Length < 15)
            {
                if (int.TryParse(tb_age.Text, out int n))
                {
                    return true;
                }
            }
            return false;
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void tb_age_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void tb_symptom_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void tb_occupation_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void tb_family_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void tb_relation_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void tb_pid_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void list_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                DataRowView dataRowView = (DataRowView)list_dept.SelectedItem;
                String dept = dataRowView["DEPTNAME"].ToString();
                int insertPatientSuccess = DBhelper.insert("insert into patient values('" + tb_pid.Text + "'," +
                                "'" + tb_name.Text + "'" +
                                "," + tb_age.Text +"," +
                                "'" + tb_symptom.Text + "'," +
                                "'" + tb_occupation.Text + "'," +
                                "0, 'admitted'," +
                                "'" + dept + "')");
                int insertFamilySuccess = DBhelper.insert("insert into family_members values('" + tb_pid.Text + "'," +
                                "'" + tb_family.Text + "'," +
                                "'" + tb_relation.Text + "')");
                int insertAppointmentSuccess = DBhelper.insert("insert into appointment values ('" + tb_pid.Text + "'," +
                                "'" + r_id + "'," +
                                "date '" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                int assignDocSuccess = DBhelper.assign_doc(tb_pid.Text);
                int addpatientSuccess = DBhelper.execute("add_patient_queue");
                if (insertPatientSuccess==0 && insertFamilySuccess==0 && insertAppointmentSuccess==0 && assignDocSuccess==0 && addpatientSuccess ==0)
                {
                    this.Close();
                }
            }
        }
    }
}
