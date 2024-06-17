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
    public partial class Form7 : Form
    {
        Form2 frm2;
        Form9 frm9;
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(Form2 frm2)
        {
            InitializeComponent();
            this.frm2 = frm2;
            frm9 = new Form9(this);
        }
        int i_count = 0;
        int i_seatcount = 0;
        int i_FullSeat = 48;
        public static bool movie3_1 = false;
        List<Button> buttonList = new List<Button>();
        public static List<Button> movie3_1_buttons_Clear = new List<Button>();
        double d_allsum = 0;
        int i_people = 0;
        Button button;

        private void btn_A1_H13_Click(object sender, EventArgs e)
        {
            button = (Button)sender;

            if (i_people > i_seatcount)
            {
                if (button.Enabled == true)
                {
                    button.BackColor = Color.Red;
                    i_seatcount++;
                    movie3_1_buttons_Clear.Add(button);
                }
            }
            else
            {
                MessageBox.Show("인원수 보다 더 많은 자리를 예약은 못합니다.");
            }
        }
        public void Get_Moive3_1(string time)
        {
            lb_movie1_1_time.Text = time;
        }
        private void SeatListAdd()
        {
            buttonList.Add(btn_A1);
            buttonList.Add(btn_A2);
            buttonList.Add(btn_A3);
            buttonList.Add(btn_A4);
            buttonList.Add(btn_A5);
            buttonList.Add(btn_A6);
            buttonList.Add(btn_A7);
            buttonList.Add(btn_A8);
            buttonList.Add(btn_A9);
            buttonList.Add(btn_A10);
            buttonList.Add(btn_A11);
            buttonList.Add(btn_A12);
            buttonList.Add(btn_B1);
            buttonList.Add(btn_B2);
            buttonList.Add(btn_B3);
            buttonList.Add(btn_B4);
            buttonList.Add(btn_B5);
            buttonList.Add(btn_B6);
            buttonList.Add(btn_B7);
            buttonList.Add(btn_B8);
            buttonList.Add(btn_B9);
            buttonList.Add(btn_B10);
            buttonList.Add(btn_B11);
            buttonList.Add(btn_B12);
            buttonList.Add(btn_C1);
            buttonList.Add(btn_C2);
            buttonList.Add(btn_C3);
            buttonList.Add(btn_C4);
            buttonList.Add(btn_C5);
            buttonList.Add(btn_C6);
            buttonList.Add(btn_C7);
            buttonList.Add(btn_C8);
            buttonList.Add(btn_C9);
            buttonList.Add(btn_C10);
            buttonList.Add(btn_C11);
            buttonList.Add(btn_C12);
            buttonList.Add(btn_D1);
            buttonList.Add(btn_D2);
            buttonList.Add(btn_D3);
            buttonList.Add(btn_D4);
            buttonList.Add(btn_D5);
            buttonList.Add(btn_D6);
            buttonList.Add(btn_D7);
            buttonList.Add(btn_D8);
            buttonList.Add(btn_D9);
            buttonList.Add(btn_D10);
            buttonList.Add(btn_D11);
            buttonList.Add(btn_D12);
        }
        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            movie3_1 = true;
            foreach (var item in buttonList)         //각각 예매가 완료되서 비활성화된 버튼 검출
            {
                if (item.BackColor == Color.Red)
                {
                    item.BackColor = SystemColors.Control;
                    item.Enabled = false;
                }

            }
            i_FullSeat -= i_Adult + i_Teen;                  //남은 좌석 계산
            lb_seats.Text = i_FullSeat.ToString();
            i_Adult = 0;
            i_Teen = 0;

            this.Hide();

            frm9.Val(lb_Pay.Text);
            frm9.Show();

        }

        private double sum(double x, double y)
        {
            return x * 11000 + y * 8000;
        }
        int i_Adult;
        int i_Teen;
        private void numericUpDown_Adult_ValueChanged(object sender, EventArgs e)
        {
            i_Adult = (int)numericUpDown_Adult.Value;
            i_Teen = (int)numericUpDown_Teen.Value;
            i_people = i_Adult + i_Teen;
            lb_Pay_Adult.Text = string.Format("{0}", i_Adult * 11000);
            d_allsum = sum(i_Adult, i_Teen);
            lb_Pay.Text = string.Format("{0}", d_allsum);
            if (i_people < movie3_1_buttons_Clear.Count)
            {
                movie3_1_buttons_Clear[movie3_1_buttons_Clear.Count - 1].BackColor = SystemColors.Control;
                movie3_1_buttons_Clear.RemoveAt(movie3_1_buttons_Clear.Count - 1);
                i_seatcount--;
            }

        }

        private void numericUpDown_Teen_ValueChanged(object sender, EventArgs e)
        {
            i_Adult = (int)numericUpDown_Adult.Value;
            i_Teen = (int)numericUpDown_Teen.Value;
            i_people = i_Adult + i_Teen;
            lb_Pay_Teen.Text = string.Format("{0}", i_Teen * 8000);
            d_allsum = sum(i_Adult, i_Teen);
            lb_Pay.Text = string.Format("{0}", d_allsum);
            if (i_people < movie3_1_buttons_Clear.Count)
            {
                movie3_1_buttons_Clear[movie3_1_buttons_Clear.Count - 1].BackColor = SystemColors.Control;
                movie3_1_buttons_Clear.RemoveAt(movie3_1_buttons_Clear.Count - 1);
                i_seatcount--;
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            foreach (var item in movie3_1_buttons_Clear)
            {
                item.Enabled = true;
                item.BackColor = SystemColors.Control;
            }
            numericUpDown_Adult.Value = 0;
            numericUpDown_Teen.Value = 0;
            i_seatcount = 0;
            i_count = 0;
            movie3_1_buttons_Clear.Clear();
            buttonList.Clear();
            this.Hide();
            frm2.Show();

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SeatListAdd();

            foreach (var item in buttonList)         //각각 예매가 완료되서 비활성화된 버튼 검출
            {
                if (item.Enabled == false)
                {
                    i_count++;
                }
            }
            i_FullSeat -= i_count;                  //남은 좌석 계산
            lb_seats.Text = i_FullSeat.ToString();
            pictureBox1.Load(@"C:\C#\MiniProject1\bin\Movie3.jpg");
        }
    }
}
