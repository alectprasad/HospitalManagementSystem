namespace HMS
{
    partial class ui_reception_landing
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
            this.lbl_recep_name = new System.Windows.Forms.Label();
            this.grid_patient_reception = new System.Windows.Forms.DataGridView();
            this.btn_new_patient = new System.Windows.Forms.Button();
            this.btn_avail_doc = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient_reception)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_recep_name
            // 
            this.lbl_recep_name.AutoSize = true;
            this.lbl_recep_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recep_name.Location = new System.Drawing.Point(13, 13);
            this.lbl_recep_name.Name = "lbl_recep_name";
            this.lbl_recep_name.Size = new System.Drawing.Size(73, 29);
            this.lbl_recep_name.TabIndex = 0;
            this.lbl_recep_name.Text = "name";
            // 
            // grid_patient_reception
            // 
            this.grid_patient_reception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_patient_reception.Location = new System.Drawing.Point(17, 182);
            this.grid_patient_reception.Name = "grid_patient_reception";
            this.grid_patient_reception.RowTemplate.Height = 28;
            this.grid_patient_reception.Size = new System.Drawing.Size(1683, 256);
            this.grid_patient_reception.TabIndex = 2;
            // 
            // btn_new_patient
            // 
            this.btn_new_patient.Location = new System.Drawing.Point(1539, 23);
            this.btn_new_patient.Name = "btn_new_patient";
            this.btn_new_patient.Size = new System.Drawing.Size(161, 54);
            this.btn_new_patient.TabIndex = 3;
            this.btn_new_patient.Text = "New Patient";
            this.btn_new_patient.UseVisualStyleBackColor = true;
            this.btn_new_patient.Click += new System.EventHandler(this.btn_new_patient_Click);
            // 
            // btn_avail_doc
            // 
            this.btn_avail_doc.Location = new System.Drawing.Point(1539, 100);
            this.btn_avail_doc.Name = "btn_avail_doc";
            this.btn_avail_doc.Size = new System.Drawing.Size(161, 54);
            this.btn_avail_doc.TabIndex = 4;
            this.btn_avail_doc.Text = "Find available doctor";
            this.btn_avail_doc.UseVisualStyleBackColor = true;
            this.btn_avail_doc.Click += new System.EventHandler(this.btn_avail_doc_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.Location = new System.Drawing.Point(1365, 100);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(140, 54);
            this.btn_bill.TabIndex = 5;
            this.btn_bill.Text = "Display bill";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // ui_reception_landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 450);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.btn_avail_doc);
            this.Controls.Add(this.btn_new_patient);
            this.Controls.Add(this.grid_patient_reception);
            this.Controls.Add(this.lbl_recep_name);
            this.Name = "ui_reception_landing";
            this.Text = "ui_reception_landing";
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient_reception)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_recep_name;
        private System.Windows.Forms.DataGridView grid_patient_reception;
        private System.Windows.Forms.Button btn_new_patient;
        private System.Windows.Forms.Button btn_avail_doc;
        private System.Windows.Forms.Button btn_bill;
    }
}