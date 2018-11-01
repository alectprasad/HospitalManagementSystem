namespace HMS
{
    partial class ui_nurse_landing
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
            this.lbl_nurse_name = new System.Windows.Forms.Label();
            this.lbl_nurse_ward = new System.Windows.Forms.Label();
            this.grid_patient_ward = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient_ward)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nurse_name
            // 
            this.lbl_nurse_name.AutoSize = true;
            this.lbl_nurse_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nurse_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_nurse_name.Name = "lbl_nurse_name";
            this.lbl_nurse_name.Size = new System.Drawing.Size(73, 29);
            this.lbl_nurse_name.TabIndex = 0;
            this.lbl_nurse_name.Text = "name";
            // 
            // lbl_nurse_ward
            // 
            this.lbl_nurse_ward.AutoSize = true;
            this.lbl_nurse_ward.Location = new System.Drawing.Point(13, 38);
            this.lbl_nurse_ward.Name = "lbl_nurse_ward";
            this.lbl_nurse_ward.Size = new System.Drawing.Size(43, 20);
            this.lbl_nurse_ward.TabIndex = 1;
            this.lbl_nurse_ward.Text = "ward";
            // 
            // grid_patient_ward
            // 
            this.grid_patient_ward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_patient_ward.Location = new System.Drawing.Point(12, 166);
            this.grid_patient_ward.Name = "grid_patient_ward";
            this.grid_patient_ward.RowTemplate.Height = 28;
            this.grid_patient_ward.Size = new System.Drawing.Size(1252, 289);
            this.grid_patient_ward.TabIndex = 2;
            // 
            // ui_nurse_landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 467);
            this.Controls.Add(this.grid_patient_ward);
            this.Controls.Add(this.lbl_nurse_ward);
            this.Controls.Add(this.lbl_nurse_name);
            this.Name = "ui_nurse_landing";
            this.Text = "ui_nurse_landing";
            ((System.ComponentModel.ISupportInitialize)(this.grid_patient_ward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nurse_name;
        private System.Windows.Forms.Label lbl_nurse_ward;
        private System.Windows.Forms.DataGridView grid_patient_ward;
    }
}