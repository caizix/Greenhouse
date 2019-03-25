namespace Monitoring_System
{
    partial class login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.liang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(104, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "温室大棚";
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(89, 100);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(80, 23);
            this.label36.TabIndex = 93;
            this.label36.Text = "账号：";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(89, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 94;
            this.label1.Text = "密码：";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(157, 100);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(62, 21);
            this.user.TabIndex = 95;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(157, 150);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(62, 21);
            this.password.TabIndex = 96;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // liang
            // 
            this.liang.Location = new System.Drawing.Point(157, 188);
            this.liang.Name = "liang";
            this.liang.Size = new System.Drawing.Size(67, 25);
            this.liang.TabIndex = 97;
            this.liang.Text = "登录";
            this.liang.UseVisualStyleBackColor = true;
            this.liang.Click += new System.EventHandler(this.liang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "XX大学-XX-XXXXX";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liang);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label3);
            this.Name = "login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button liang;
        private System.Windows.Forms.Label label2;
    }
}