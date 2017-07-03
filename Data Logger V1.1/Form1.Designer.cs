namespace Data_Logger_V1._1
{
    partial class Form1
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
            this.CMB_Port = new System.Windows.Forms.ComboBox();
            this.CMB_BR = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_DC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_rowcount = new System.Windows.Forms.TextBox();
            this.txt_columncount = new System.Windows.Forms.TextBox();
            this.btn_example = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_16 = new System.Windows.Forms.Button();
            this.btn_15 = new System.Windows.Forms.Button();
            this.btn_14 = new System.Windows.Forms.Button();
            this.btn_13 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMB_Port
            // 
            this.CMB_Port.FormattingEnabled = true;
            this.CMB_Port.Location = new System.Drawing.Point(10, 32);
            this.CMB_Port.Name = "CMB_Port";
            this.CMB_Port.Size = new System.Drawing.Size(118, 21);
            this.CMB_Port.TabIndex = 0;
            // 
            // CMB_BR
            // 
            this.CMB_BR.AutoCompleteCustomSource.AddRange(new string[] {
            "4800",
            "9600",
            "16800",
            "115200"});
            this.CMB_BR.FormattingEnabled = true;
            this.CMB_BR.Location = new System.Drawing.Point(143, 32);
            this.CMB_BR.Name = "CMB_BR";
            this.CMB_BR.Size = new System.Drawing.Size(121, 21);
            this.CMB_BR.TabIndex = 1;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(6, 70);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(187, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_DC
            // 
            this.btn_DC.Location = new System.Drawing.Point(6, 99);
            this.btn_DC.Name = "btn_DC";
            this.btn_DC.Size = new System.Drawing.Size(187, 23);
            this.btn_DC.TabIndex = 3;
            this.btn_DC.Text = "Disconnect";
            this.btn_DC.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Data_Logger_V1._1.Properties.Resources.red;
            this.pictureBox1.Location = new System.Drawing.Point(232, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CMB_Port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.CMB_BR);
            this.groupBox1.Controls.Add(this.btn_DC);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Location = new System.Drawing.Point(12, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_rowcount);
            this.groupBox2.Controls.Add(this.txt_columncount);
            this.groupBox2.Controls.Add(this.btn_example);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(288, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 128);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inputs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 106);
            this.button1.TabIndex = 15;
            this.button1.Text = "Program Board";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_rowcount
            // 
            this.txt_rowcount.Location = new System.Drawing.Point(9, 73);
            this.txt_rowcount.Name = "txt_rowcount";
            this.txt_rowcount.Size = new System.Drawing.Size(150, 20);
            this.txt_rowcount.TabIndex = 14;
            // 
            // txt_columncount
            // 
            this.txt_columncount.Location = new System.Drawing.Point(9, 32);
            this.txt_columncount.Name = "txt_columncount";
            this.txt_columncount.Size = new System.Drawing.Size(150, 20);
            this.txt_columncount.TabIndex = 13;
            // 
            // btn_example
            // 
            this.btn_example.Location = new System.Drawing.Point(9, 99);
            this.btn_example.Name = "btn_example";
            this.btn_example.Size = new System.Drawing.Size(150, 23);
            this.btn_example.TabIndex = 4;
            this.btn_example.Text = "Make Table";
            this.btn_example.UseVisualStyleBackColor = true;
            this.btn_example.Click += new System.EventHandler(this.btn_example_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of Rows:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Columns:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(720, 227);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_max);
            this.groupBox3.Controls.Add(this.btn_16);
            this.groupBox3.Controls.Add(this.btn_15);
            this.groupBox3.Controls.Add(this.btn_14);
            this.groupBox3.Controls.Add(this.btn_13);
            this.groupBox3.Controls.Add(this.btn_12);
            this.groupBox3.Controls.Add(this.btn_11);
            this.groupBox3.Controls.Add(this.btn_10);
            this.groupBox3.Controls.Add(this.btn_9);
            this.groupBox3.Controls.Add(this.btn_8);
            this.groupBox3.Controls.Add(this.btn7);
            this.groupBox3.Controls.Add(this.btn_6);
            this.groupBox3.Controls.Add(this.btn_5);
            this.groupBox3.Controls.Add(this.btn_4);
            this.groupBox3.Controls.Add(this.btn_3);
            this.groupBox3.Controls.Add(this.btn_2);
            this.groupBox3.Location = new System.Drawing.Point(617, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 128);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fast Modes";
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(324, 103);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(100, 23);
            this.btn_max.TabIndex = 20;
            this.btn_max.Text = "23*17";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_16
            // 
            this.btn_16.Location = new System.Drawing.Point(324, 74);
            this.btn_16.Name = "btn_16";
            this.btn_16.Size = new System.Drawing.Size(100, 23);
            this.btn_16.TabIndex = 19;
            this.btn_16.Text = "16*16";
            this.btn_16.UseVisualStyleBackColor = true;
            this.btn_16.Click += new System.EventHandler(this.btn_16_Click);
            // 
            // btn_15
            // 
            this.btn_15.Location = new System.Drawing.Point(324, 45);
            this.btn_15.Name = "btn_15";
            this.btn_15.Size = new System.Drawing.Size(100, 23);
            this.btn_15.TabIndex = 18;
            this.btn_15.Text = "15*15";
            this.btn_15.UseVisualStyleBackColor = true;
            this.btn_15.Click += new System.EventHandler(this.btn_15_Click);
            // 
            // btn_14
            // 
            this.btn_14.Location = new System.Drawing.Point(324, 16);
            this.btn_14.Name = "btn_14";
            this.btn_14.Size = new System.Drawing.Size(100, 23);
            this.btn_14.TabIndex = 17;
            this.btn_14.Text = "14*14";
            this.btn_14.UseVisualStyleBackColor = true;
            this.btn_14.Click += new System.EventHandler(this.btn_14_Click);
            // 
            // btn_13
            // 
            this.btn_13.Location = new System.Drawing.Point(218, 103);
            this.btn_13.Name = "btn_13";
            this.btn_13.Size = new System.Drawing.Size(100, 23);
            this.btn_13.TabIndex = 16;
            this.btn_13.Text = "13*13";
            this.btn_13.UseVisualStyleBackColor = true;
            this.btn_13.Click += new System.EventHandler(this.btn_13_Click);
            // 
            // btn_12
            // 
            this.btn_12.Location = new System.Drawing.Point(218, 74);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(100, 23);
            this.btn_12.TabIndex = 15;
            this.btn_12.Text = "12*12";
            this.btn_12.UseVisualStyleBackColor = true;
            this.btn_12.Click += new System.EventHandler(this.btn_12_Click);
            // 
            // btn_11
            // 
            this.btn_11.Location = new System.Drawing.Point(218, 45);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(100, 23);
            this.btn_11.TabIndex = 14;
            this.btn_11.Text = "11*11";
            this.btn_11.UseVisualStyleBackColor = true;
            this.btn_11.Click += new System.EventHandler(this.btn_11_Click);
            // 
            // btn_10
            // 
            this.btn_10.Location = new System.Drawing.Point(218, 16);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(100, 23);
            this.btn_10.TabIndex = 13;
            this.btn_10.Text = "10*10";
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(112, 103);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(100, 23);
            this.btn_9.TabIndex = 12;
            this.btn_9.Text = "9*9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(112, 74);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(100, 23);
            this.btn_8.TabIndex = 11;
            this.btn_8.Text = "8*8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(112, 45);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 23);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7*7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(112, 16);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(100, 23);
            this.btn_6.TabIndex = 9;
            this.btn_6.Text = "6*6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(6, 103);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 23);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5*5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(6, 74);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 23);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4*4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(6, 45);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 23);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "3*3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(6, 16);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 23);
            this.btn_2.TabIndex = 5;
            this.btn_2.Text = "2*2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(1066, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 128);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Memory";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(115, 45);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(103, 77);
            this.button19.TabIndex = 2;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(6, 44);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(103, 77);
            this.button18.TabIndex = 1;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CMB_Port;
        private System.Windows.Forms.ComboBox CMB_BR;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_DC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_example;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt_rowcount;
        private System.Windows.Forms.TextBox txt_columncount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_13;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_16;
        private System.Windows.Forms.Button btn_15;
        private System.Windows.Forms.Button btn_14;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox1;
    }
}

