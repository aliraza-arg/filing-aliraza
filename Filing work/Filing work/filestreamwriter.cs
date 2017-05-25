using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class filestreamwriter : Form
    {
        public filestreamwriter()
        {
            InitializeComponent();
        }

        private void filestreamwriter_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            comboBox2.Items.Clear();
            foreach (DirectoryInfo di in d)
            {
                comboBox2.Items.Add(di.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String spath = comboBox1.Text + comboBox2.Text;
            DirectoryInfo Dir = new DirectoryInfo(spath);
            FileInfo[] f = Dir.GetFiles();
            comboBox3.Items.Clear();
            foreach (FileInfo fi in f)
            {
                this.comboBox3.Items.Add(fi.Name.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text; 
            if (File.Exists(path))
            {
                byte[] b = new byte[1000];
                char[] c = new char[1000];
                FileStream fs = new FileStream(path, FileMode.Append);
                c = richTextBox1.Text.ToCharArray();
                Encoder en = Encoding.UTF8.GetEncoder();
                en.GetBytes(c, 0, c.Length, b, 0, true);
                fs.Write(b, 0, b.Length);
                fs.Close();
                MessageBox.Show("File Edited");
            }
            else
                MessageBox.Show("File not found.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
