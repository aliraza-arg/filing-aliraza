using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createfile cf = new createfile();
            cf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            searchfile sf = new searchfile();
            sf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            copyfile cp = new copyfile();
            cp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movefile mf = new movefile();
            mf.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deletefile df = new deletefile();
            df.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            createfolder cff = new createfolder();
            cff.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            filesindirectory fid = new filesindirectory();
            fid.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            streamreader sr = new streamreader();
            sr.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            streamwriter sw = new streamwriter();
            sw.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            filestreamreader fsr = new filestreamreader();
            fsr.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            filestreamwriter fsw = new filestreamwriter();
            fsw.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            randomfileaccess rfa = new randomfileaccess();
            rfa.Show();
            this.Hide();
        }
    }
}
