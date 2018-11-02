namespace HMS
{
    partial class ui_doctor_landing
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
            this.lbl_doc_name = new System.Windows.Forms.Label();
            this.lbl_doc_dept = new System.Windows.Forms.Label();
            this.grid_patients_dept = new System.Windows.Forms.DataGridView();
            this.btn_discharge_doc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_patients_dept)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_doc_name
            // 
            this.lbl_doc_name.AutoSize = true;
            this.lbl_doc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doc_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_doc_name.Name = "lbl_doc_name";
            this.lbl_doc_name.Size = new System.Drawing.Size(73, 29);
            this.lbl_doc_name.TabIndex = 0;
            this.lbl_doc_name.Text = "name";
            // 
            // lbl_doc_dept
            // 
            this.lbl_doc_dept.AutoSize = true;
            this.lbl_doc_dept.Location = new System.Drawing.Point(13, 38);
            this.lbl_doc_dept.Name = "lbl_doc_dept";
            this.lbl_doc_dept.Size = new System.Drawing.Size(91, 20);
            this.lbl_doc_dept.TabIndex = 1;
            this.lbl_doc_dept.Text = "department";
            // 
            // grid_patients_dept
            // 
            this.grid_patients_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_patients_dept.Location = new System.Drawing.Point(12, 147);
            this.grid_patients_dept.Name = "grid_patients_dept";
            this.grid_patients_dept.RowTemplate.Height = 28;
            this.grid_patients_dept.Size = new System.Drawing.Size(776, 291);
            this.grid_patients_dept.TabIndex = 2;
            // 
            // btn_discharge_doc
            // 
            this.btn_discharge_doc.Location = new System.Drawing.Point(668, 74);
            this.btn_discharge_doc.Name = "btn_discharge_doc";
            this.btn_discharge_doc.Size = new System.Drawing.Size(120, 50);
            this.btn_discharge_doc.TabIndex = 3;
            this.btn_discharge_doc.Text = "Discharge";
            this.btn_discharge_doc.UseVisualStyleBackColor = true;
            this.btn_discharge_doc.Click += new System.EventHandler(this.btn_discharge_doc_Click);
            // 
            // ui_doctor_landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_discharge_doc);
            this.Controls.Add(this.grid_patients_dept);
            this.Controls.Add(this.lbl_doc_dept);
            this.Controls.Add(this.lbl_doc_name);
            this.Name = "ui_doctor_landing";
            this.Text = "ui_doctor_landing";
            ((System.ComponentModel.ISupportInitialize)(this.grid_patients_dept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_doc_name;
        private System.Windows.Forms.Label lbl_doc_dept;
        private System.Windows.Forms.DataGridView grid_patients_dept;
        private System.Windows.Forms.Button btn_discharge_doc;
    }
}