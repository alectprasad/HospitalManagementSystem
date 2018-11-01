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
    public partial class ui_doctor_landing : Form
    {
        String d_id, name, dept;
        DataTable dataTable;
        public ui_doctor_landing(String id)
        {
            InitializeComponent();
            d_id = id;
            dataTable = DBhelper.read("select * from doctor where d_id='" + d_id + "'");
            DataRow dataRow = dataTable.Rows[0];
            name = dataRow["NAME"].ToString();
            dept = dataRow["DEPTNAME"].ToString();
            lbl_doc_name.Text = name;
            lbl_doc_dept.Text = dept;
            this.Text = d_id;
            loadPatients();
        }

        void loadPatients() {
            //TODO
        }
    }
}
