namespace Amar_Cash
{
    partial class Login
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
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtAccPass = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccNum
            // 
            this.txtAccNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.txtAccNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum.Location = new System.Drawing.Point(605, 232);
            this.txtAccNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(346, 34);
            this.txtAccNum.TabIndex = 0;
            this.txtAccNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAccPass
            // 
            this.txtAccPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.txtAccPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccPass.Location = new System.Drawing.Point(605, 320);
            this.txtAccPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccPass.Name = "txtAccPass";
            this.txtAccPass.Size = new System.Drawing.Size(346, 34);
            this.txtAccPass.TabIndex = 1;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Yellow;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(32, 27);
            this.backbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(102, 36);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(542, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 58);
            this.label3.TabIndex = 14;
            this.label3.Text = "  ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Amar_Cash.Properties.Resources.Logopit_1712771730275;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.txtAccPass);
            this.Controls.Add(this.txtAccNum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAccPass;
        private System.Windows.Forms.Button backbtn;
        public System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Label label3;
    }
}