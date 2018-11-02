namespace HMS
{
    partial class ui_add_patient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_occupation = new System.Windows.Forms.TextBox();
            this.tb_symptom = new System.Windows.Forms.TextBox();
            this.tb_family = new System.Windows.Forms.TextBox();
            this.tb_relation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add_patient = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_r_id = new System.Windows.Forms.Label();
            this.lbl_pid = new System.Windows.Forms.Label();
            this.tb_pid = new System.Windows.Forms.TextBox();
            this.list_dept = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Symptoms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Occupation";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(197, 193);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(366, 26);
            this.tb_name.TabIndex = 4;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(197, 247);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(366, 26);
            this.tb_age.TabIndex = 5;
            this.tb_age.TextChanged += new System.EventHandler(this.tb_age_TextChanged);
            // 
            // tb_occupation
            // 
            this.tb_occupation.Location = new System.Drawing.Point(197, 356);
            this.tb_occupation.Name = "tb_occupation";
            this.tb_occupation.Size = new System.Drawing.Size(366, 26);
            this.tb_occupation.TabIndex = 6;
            this.tb_occupation.TextChanged += new System.EventHandler(this.tb_occupation_TextChanged);
            // 
            // tb_symptom
            // 
            this.tb_symptom.Location = new System.Drawing.Point(197, 303);
            this.tb_symptom.Name = "tb_symptom";
            this.tb_symptom.Size = new System.Drawing.Size(366, 26);
            this.tb_symptom.TabIndex = 7;
            this.tb_symptom.TextChanged += new System.EventHandler(this.tb_symptom_TextChanged);
            // 
            // tb_family
            // 
            this.tb_family.Location = new System.Drawing.Point(197, 413);
            this.tb_family.Name = "tb_family";
            this.tb_family.Size = new System.Drawing.Size(366, 26);
            this.tb_family.TabIndex = 8;
            this.tb_family.TextChanged += new System.EventHandler(this.tb_family_TextChanged);
            // 
            // tb_relation
            // 
            this.tb_relation.Location = new System.Drawing.Point(197, 469);
            this.tb_relation.Name = "tb_relation";
            this.tb_relation.Size = new System.Drawing.Size(366, 26);
            this.tb_relation.TabIndex = 9;
            this.tb_relation.TextChanged += new System.EventHandler(this.tb_relation_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Family Member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Relation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 55);
            this.label7.TabIndex = 12;
            this.label7.Text = "NEW PATIENT";
            // 
            // btn_add_patient
            // 
            this.btn_add_patient.Location = new System.Drawing.Point(638, 418);
            this.btn_add_patient.Name = "btn_add_patient";
            this.btn_add_patient.Size = new System.Drawing.Size(123, 77);
            this.btn_add_patient.TabIndex = 13;
            this.btn_add_patient.Text = "Add";
            this.btn_add_patient.UseVisualStyleBackColor = true;
            this.btn_add_patient.Click += new System.EventHandler(this.btn_add_patient_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(638, 335);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(123, 77);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_r_id
            // 
            this.lbl_r_id.AutoSize = true;
            this.lbl_r_id.Location = new System.Drawing.Point(737, 9);
            this.lbl_r_id.Name = "lbl_r_id";
            this.lbl_r_id.Size = new System.Drawing.Size(21, 20);
            this.lbl_r_id.TabIndex = 15;
            this.lbl_r_id.Text = "id";
            // 
            // lbl_pid
            // 
            this.lbl_pid.AutoSize = true;
            this.lbl_pid.Location = new System.Drawing.Point(52, 138);
            this.lbl_pid.Name = "lbl_pid";
            this.lbl_pid.Size = new System.Drawing.Size(80, 20);
            this.lbl_pid.TabIndex = 16;
            this.lbl_pid.Text = "Patient ID";
            // 
            // tb_pid
            // 
            this.tb_pid.Location = new System.Drawing.Point(197, 132);
            this.tb_pid.Name = "tb_pid";
            this.tb_pid.Size = new System.Drawing.Size(366, 26);
            this.tb_pid.TabIndex = 17;
            this.tb_pid.TextChanged += new System.EventHandler(this.tb_pid_TextChanged);
            // 
            // list_dept
            // 
            this.list_dept.FormattingEnabled = true;
            this.list_dept.ItemHeight = 20;
            this.list_dept.Location = new System.Drawing.Point(596, 138);
            this.list_dept.Name = "list_dept";
            this.list_dept.Size = new System.Drawing.Size(192, 144);
            this.list_dept.TabIndex = 18;
            this.list_dept.SelectedIndexChanged += new System.EventHandler(this.list_dept_SelectedIndexChanged);
            // 
            // ui_add_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.list_dept);
            this.Controls.Add(this.tb_pid);
            this.Controls.Add(this.lbl_pid);
            this.Controls.Add(this.lbl_r_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add_patient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_relation);
            this.Controls.Add(this.tb_family);
            this.Controls.Add(this.tb_symptom);
            this.Controls.Add(this.tb_occupation);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ui_add_patient";
            this.Text = "ui_add_patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_occupation;
        private System.Windows.Forms.TextBox tb_symptom;
        private System.Windows.Forms.TextBox tb_family;
        private System.Windows.Forms.TextBox tb_relation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add_patient;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_r_id;
        private System.Windows.Forms.Label lbl_pid;
        private System.Windows.Forms.TextBox tb_pid;
        private System.Windows.Forms.ListBox list_dept;
    }
}