namespace HMS
{
    partial class ui_login
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
            this.tb_login = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_login_back = new System.Windows.Forms.Button();
            this.lbl_logintype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(35, 124);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(244, 26);
            this.tb_login.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(355, 116);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 42);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_login_back
            // 
            this.btn_login_back.Location = new System.Drawing.Point(12, 12);
            this.btn_login_back.Name = "btn_login_back";
            this.btn_login_back.Size = new System.Drawing.Size(75, 35);
            this.btn_login_back.TabIndex = 2;
            this.btn_login_back.Text = "Back";
            this.btn_login_back.UseVisualStyleBackColor = true;
            this.btn_login_back.Click += new System.EventHandler(this.btn_login_back_Click);
            // 
            // lbl_logintype
            // 
            this.lbl_logintype.AutoSize = true;
            this.lbl_logintype.Location = new System.Drawing.Point(36, 91);
            this.lbl_logintype.Name = "lbl_logintype";
            this.lbl_logintype.Size = new System.Drawing.Size(72, 20);
            this.lbl_logintype.TabIndex = 3;
            this.lbl_logintype.Text = "logintype";
            // 
            // ui_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 269);
            this.Controls.Add(this.lbl_logintype);
            this.Controls.Add(this.btn_login_back);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_login);
            this.Name = "ui_login";
            this.Text = "ui_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_login_back;
        private System.Windows.Forms.Label lbl_logintype;
    }
}