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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.All = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_example = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_columncount = new System.Windows.Forms.TextBox();
            this.txt_rowcount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMB_Port
            // 
            this.CMB_Port.FormattingEnabled = true;
            this.CMB_Port.Location = new System.Drawing.Point(10, 32);
            this.CMB_Port.Name = "CMB_Port";
            this.CMB_Port.Size = new System.Drawing.Size(93, 21);
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
            this.CMB_BR.Location = new System.Drawing.Point(109, 32);
            this.CMB_BR.Name = "CMB_BR";
            this.CMB_BR.Size = new System.Drawing.Size(93, 21);
            this.CMB_BR.TabIndex = 1;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(6, 70);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(135, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_DC
            // 
            this.btn_DC.Location = new System.Drawing.Point(6, 99);
            this.btn_DC.Name = "btn_DC";
            this.btn_DC.Size = new System.Drawing.Size(135, 23);
            this.btn_DC.TabIndex = 3;
            this.btn_DC.Text = "Disconnect";
            this.btn_DC.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Data_Logger_V1._1.Properties.Resources.red;
            this.pictureBox1.Location = new System.Drawing.Point(170, 90);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 16);
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
            this.groupBox2.Controls.Add(this.txt_rowcount);
            this.groupBox2.Controls.Add(this.txt_columncount);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.All);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_example);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(231, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 128);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inputs";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(235, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Set to All";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(235, 34);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(68, 17);
            this.All.TabIndex = 11;
            this.All.Text = "Set to All";
            this.All.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Int",
            "String"});
            this.comboBox1.Location = new System.Drawing.Point(312, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Row:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Column:";
            // 
            // btn_example
            // 
            this.btn_example.Location = new System.Drawing.Point(9, 99);
            this.btn_example.Name = "btn_example";
            this.btn_example.Size = new System.Drawing.Size(486, 23);
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
            // txt_columncount
            // 
            this.txt_columncount.Location = new System.Drawing.Point(9, 32);
            this.txt_columncount.Name = "txt_columncount";
            this.txt_columncount.Size = new System.Drawing.Size(100, 20);
            this.txt_columncount.TabIndex = 13;
            // 
            // txt_rowcount
            // 
            this.txt_rowcount.Location = new System.Drawing.Point(9, 73);
            this.txt_rowcount.Name = "txt_rowcount";
            this.txt_rowcount.Size = new System.Drawing.Size(100, 20);
            this.txt_rowcount.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 386);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox All;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt_rowcount;
        private System.Windows.Forms.TextBox txt_columncount;
    }
}

