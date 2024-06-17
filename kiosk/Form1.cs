using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    public partial class Form1 : Form
    {
        Form9 fr9;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form9 frm9)
        {
            InitializeComponent();
            fr9 = frm9;
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            this.Hide();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_RealTime.Text = DateTime.Now.ToString("F");
        }
    }
}
