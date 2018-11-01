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
            dataTable = DBhelper.read("select * from patient where wname='" + ward + "'");
            grid_patient_ward.DataSource = dataTable;
        }
    }
}
