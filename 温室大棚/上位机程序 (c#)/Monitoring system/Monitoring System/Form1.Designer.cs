namespace Monitoring_System
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.open = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.liang = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.botelu = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.ports = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(22, 197);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(57, 23);
            this.open.TabIndex = 5;
            this.open.Text = "开";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(120, 198);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(58, 23);
            this.close.TabIndex = 6;
            this.close.Text = "关";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // liang
            // 
            this.liang.Location = new System.Drawing.Point(33, 85);
            this.liang.Name = "liang";
            this.liang.Size = new System.Drawing.Size(67, 25);
            this.liang.TabIndex = 7;
            this.liang.Text = "参数下发";
            this.liang.UseVisualStyleBackColor = true;
            this.liang.Click += new System.EventHandler(this.clone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(34, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "温度（℃）：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 21);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 21);
            this.textBox3.TabIndex = 37;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(30, 50);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(139, 21);
            this.label26.TabIndex = 35;
            this.label26.Text = "湿度 ( % )：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(30, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "烟雾（ppm)：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 21);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(175, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.botelu);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.ports);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.open);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.close);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 228);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(91, 168);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(87, 20);
            this.comboBox3.TabIndex = 93;
            // 
            // botelu
            // 
            this.botelu.FormattingEnabled = true;
            this.botelu.Location = new System.Drawing.Point(91, 69);
            this.botelu.Name = "botelu";
            this.botelu.Size = new System.Drawing.Size(87, 20);
            this.botelu.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 135);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(87, 20);
            this.comboBox2.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "波特率：";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(6, 168);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(80, 23);
            this.label34.TabIndex = 90;
            this.label34.Text = "校验位：";
            // 
            // ports
            // 
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(91, 39);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(87, 20);
            this.ports.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 20);
            this.comboBox1.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "串口：";
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(7, 136);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 23);
            this.label35.TabIndex = 91;
            this.label35.Text = "停止位：";
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(8, 102);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(80, 23);
            this.label36.TabIndex = 92;
            this.label36.Text = "数据位：";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(35, 49);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(62, 21);
            this.textBox7.TabIndex = 57;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(6, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 21);
            this.label18.TabIndex = 56;
            this.label18.Text = "湿度下限：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(187, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 21);
            this.label20.TabIndex = 62;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(205, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 116);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "终端1测量值";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.liang);
            this.groupBox3.Location = new System.Drawing.Point(457, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 116);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置值";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Location = new System.Drawing.Point(457, 132);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 109);
            this.groupBox6.TabIndex = 68;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "设置值";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(1, -23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 21);
            this.label11.TabIndex = 56;
            this.label11.Text = "光照下限：";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(30, 40);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(62, 21);
            this.textBox6.TabIndex = 57;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(187, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 21);
            this.label12.TabIndex = 62;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "参数下发";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.textBox10);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.textBox12);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Location = new System.Drawing.Point(206, 149);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(246, 88);
            this.groupBox9.TabIndex = 65;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "终端2测量值";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(29, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "光照（Lx）：";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(176, 16);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(62, 21);
            this.textBox10.TabIndex = 30;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(49, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 20);
            this.label21.TabIndex = 40;
            this.label21.Text = "大棚安全：";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(176, 53);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(62, 21);
            this.textBox12.TabIndex = 41;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(175, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 21);
            this.label22.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "光照下限：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 248);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "上位机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button liang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox botelu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label3;

    }
}

