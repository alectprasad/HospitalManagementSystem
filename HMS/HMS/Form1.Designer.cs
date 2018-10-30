namespace HMS
{
    partial class ui_landing
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
            this.btn_login_doctor = new System.Windows.Forms.Button();
            this.btn_login_reception = new System.Windows.Forms.Button();
            this.btn_login_nurse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(995, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_login_doctor
            // 
            this.btn_login_doctor.Location = new System.Drawing.Point(844, 49);
            this.btn_login_doctor.Name = "btn_login_doctor";
            this.btn_login_doctor.Size = new System.Drawing.Size(139, 47);
            this.btn_login_doctor.TabIndex = 1;
            this.btn_login_doctor.Text = "Doctor";
            this.btn_login_doctor.UseVisualStyleBackColor = true;
            // 
            // btn_login_reception
            // 
            this.btn_login_reception.Location = new System.Drawing.Point(699, 49);
            this.btn_login_reception.Name = "btn_login_reception";
            this.btn_login_reception.Size = new System.Drawing.Size(139, 47);
            this.btn_login_reception.TabIndex = 2;
            this.btn_login_reception.Text = "Reception";
            this.btn_login_reception.UseVisualStyleBackColor = true;
            // 
            // btn_login_nurse
            // 
            this.btn_login_nurse.Location = new System.Drawing.Point(989, 49);
            this.btn_login_nurse.Name = "btn_login_nurse";
            this.btn_login_nurse.Size = new System.Drawing.Size(139, 47);
            this.btn_login_nurse.TabIndex = 3;
            this.btn_login_nurse.Text = "Nurse";
            this.btn_login_nurse.UseVisualStyleBackColor = true;
            // 
            // ui_landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 689);
            this.Controls.Add(this.btn_login_nurse);
            this.Controls.Add(this.btn_login_reception);
            this.Controls.Add(this.btn_login_doctor);
            this.Controls.Add(this.label1);
            this.Name = "ui_landing";
            this.Text = "Hospital Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btn_login_doctor;
        private System.Windows.Forms.Button btn_login_reception;
        private System.Windows.Forms.Button btn_login_nurse;
    }
}

