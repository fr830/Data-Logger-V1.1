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
        List<TextBox> example = new List<TextBox> ();
        public int col=0, row=0;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            example[0].Text = "hello";
            
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
                    example.Add(txt);
                }
            }
            flowLayoutPanel1.Size = new System.Drawing.Size(col * 57, row * 30);
            for(int j=0;j<row*col;j++)
                flowLayoutPanel1.Controls.Add(example[j]);
            
        }
    }
}
