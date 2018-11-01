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
    public partial class ui_login : Form
    {
        String loginType;
        public ui_login(String loginType)
        {
            InitializeComponent();
            this.loginType = loginType;
            lbl_logintype.Text = loginType;
            this.Text = loginType + " login";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (DBhelper.login(loginType, tb_login.Text))
            {
                switch (loginType)
                {
                    case "Doctor":
                        new ui_doctor_landing(tb_login.Text).Show();
                        break;
                    case "Nurse":
                        new ui_nurse_landing(tb_login.Text).Show();
                        break;
                    case "Receptionist":
                        new ui_reception_landing(tb_login.Text).Show();
                        break;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No Records Found");
            }
        }

        private void btn_login_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
