using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Logger_V1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[,] lbls = new string[5, 5];
        public byte[] sent = new byte[10];
        List<TextBox> example = new List<TextBox> ();
        public int col=0, row=0;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            example[0].Text = "hello";
            
        }
        #region Default_mode
        private void btn_2_Click(object sender, EventArgs e)
        {
            col = 2;
            row = 2;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            col = 3;
            row = 3;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            col = 4;
            row = 4;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            col = 5;
            row = 5;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            col = 6;
            row = 6;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            col = 7;
            row = 7;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            col = 8;
            row = 8;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            col = 9;
            row = 9;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            col = 10;
            row = 10;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            col = 11;
            row = 11;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            col = 12;
            row = 12;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            col = 13;
            row = 13;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
            col = 14;
            row = 14;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_15_Click(object sender, EventArgs e)
        {
            col = 15;
            row = 15;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_16_Click(object sender, EventArgs e)
        {
            col = 16;
            row = 16;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            col = 23;
            row = 17;
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" + i.ToString() + k.ToString();
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for (int j = 0; j < row * col; j++)
                flowLayoutPanel1.Controls.Add(example[j]);
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            sent = new byte[example.Count];
            for(int z=0;z<example.Count;z++)
            {
                if(string.IsNullOrWhiteSpace(example[z].Text))
                {
                    MessageBox.Show("PLZ fill the " + example[z].Name);
                }
                else
                {
                    switch (example[z].Text)
                    {
                        case "int32":
                            sent[z] = 0x32;
                            break;
                        case "int64":
                            sent[z] = 0x64;
                            break;
                        case "string":
                            sent[z] = 0x88;
                            break;
                        default:
                            break;
                    }

                }
            }
            
        }

        private void btn_example_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_columncount.Text) && !string.IsNullOrWhiteSpace(txt_rowcount.Text))
            {
                col = Convert.ToInt32(txt_columncount.Text);
                row = Convert.ToInt32(txt_rowcount.Text);
            }
            for(int i=0;i<col;i++)
            {
                for(int k=0;k<row;k++)
                {
                    TextBox txt = new TextBox();
                    txt.Height = 20;
                    txt.Width = 50;
                    txt.Name = "TextBox" +i.ToString()+k.ToString();
                    txt.CharacterCasing = CharacterCasing.Lower;
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for(int j=0;j<row*col;j++)
                flowLayoutPanel1.Controls.Add(example[j]);
            
        }
    }
}
