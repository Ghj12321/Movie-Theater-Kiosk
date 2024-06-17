using Microsoft.VisualBasic.Devices;
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
    public partial class Form2 : Form
    {
        Form1 frm1;
        
        public Form2()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Tile;
        }
        public Form2(Form1 fr1)
        {
            InitializeComponent();
            frm1 = fr1;
            this.BackgroundImageLayout = ImageLayout.Tile;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\C#\MiniProject1\bin\Movie4.jpg");
            pictureBox2.Load(@"C:\C#\MiniProject1\bin\Movie2.jpg");
            pictureBox3.Load(@"C:\C#\MiniProject1\bin\Movie3.jpg");

        }

        private void btn_Movie1Time1_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3(this);
            form3.Show();
            form3.Get_Moive1_1(btn_Movie1Time1.Text);
            this.Hide();
        }

        private void btn_Movie1Time2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("좌석이 마감됬습니다.");
        }

        private void btn_Movie2Time1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void btn_Movie2Time2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("좌석이 마감됬습니다.");
        }

        private void btn_Movie3Time1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Close();
        }

        private void btn_Movie3Time2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("좌석이 마감됬습니다.");
        }

    }
}
