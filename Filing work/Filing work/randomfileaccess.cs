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
    public partial class randomfileaccess : Form
    {
        public randomfileaccess()
        {
            InitializeComponent();
        }

        private void randomfileaccess_Load(object sender, EventArgs e)
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
                char[] f = new char[1000];
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                fs.Seek(10, SeekOrigin.Begin);

                fs.Read(b, 0, b.Length);
                Decoder d = Encoding.UTF8.GetDecoder();
                d.GetChars(b, 0, b.Length, c, 0, true);
                string s = new string(c);
                richTextBox1.Text = s;
                fs.Close();
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
