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
    public partial class createfolder : Form
    {
        public createfolder()
        {
            InitializeComponent();
        }

        private void createfolder_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            /*this.BackColor = Color.PaleTurquoise;
            label1.Font = new Font("Bold", 18, FontStyle.Bold);
            label1.ForeColor = Color.DeepSkyBlue;
            label2.Font = new Font("Bold", 18, FontStyle.Bold);
            label2.ForeColor = Color.DeepSkyBlue;
            label3.Font = new Font("Bold", 18, FontStyle.Bold);
            label3.ForeColor = Color.DeepSkyBlue;
            button1.BackColor = Color.DarkSlateBlue;
            button1.ForeColor = Color.DeepSkyBlue;
            button1.Size = new Size(116, 40);
            button1.Font = new Font("Bold", 14, FontStyle.Bold);
            button3.Click+=new EventHandler(button3_Click);*/
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
            string path = comboBox1.Text + "\\" + comboBox2.Text;
            DirectoryInfo d = new DirectoryInfo(path);
            try
            {
                d.CreateSubdirectory(textBox1.Text);
                MessageBox.Show("Directory Is Created");
            }
            catch (IOException) { MessageBox.Show("Directory Is Already Created"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
