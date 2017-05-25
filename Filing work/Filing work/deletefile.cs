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
    public partial class deletefile : Form
    {
        public deletefile()
        {
            InitializeComponent();
        }

        private void deletefile_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            String spath = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;
            
            if (File.Exists(spath))
            {
                File.Delete(spath);
                MessageBox.Show("File deleted");
            }
            else
            {
              

                MessageBox.Show("File does not exists");
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
