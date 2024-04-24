namespace Amar_Cash
{
    partial class AdminLogin
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
            this.txtAdminNm = new System.Windows.Forms.TextBox();
            this.txtadmnpass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdminNm
            // 
            this.txtAdminNm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(165)))));
            this.txtAdminNm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminNm.Location = new System.Drawing.Point(659, 270);
            this.txtAdminNm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdminNm.Name = "txtAdminNm";
            this.txtAdminNm.Size = new System.Drawing.Size(304, 34);
            this.txtAdminNm.TabIndex = 0;
            this.txtAdminNm.Text = "admin";
            // 
            // txtadmnpass
            // 
            this.txtadmnpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(165)))));
            this.txtadmnpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadmnpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmnpass.Location = new System.Drawing.Point(659, 372);
            this.txtadmnpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtadmnpass.Name = "txtadmnpass";
            this.txtadmnpass.Size = new System.Drawing.Size(235, 34);
            this.txtadmnpass.TabIndex = 1;
            this.txtadmnpass.Text = "password";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(24, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(476, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 54);
            this.label3.TabIndex = 14;
            this.label3.Text = "  ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amar_Cash.Properties.Resources.admin_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtadmnpass);
            this.Controls.Add(this.txtAdminNm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminNm;
        private System.Windows.Forms.TextBox txtadmnpass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}