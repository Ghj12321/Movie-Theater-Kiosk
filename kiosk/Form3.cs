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
    public partial class Form3 : Form
    {
        Form2 frm2;
        //public static int i_count1_1 = 0;
        int i_count1_1 = 0;
        //public static int i_FullSeat1_1 = 48;
        int i_FullSeat1_1 = 48;
        public static int i_seatcount1_1 = 0;
        public static double d_allsum1_1 = 0;
        public static int i_people1_1 = 0;
        public static bool movie1_1 = false;
        public static int i_Adult1_1 = 0;
        public static int i_Teen1_1 = 0;
        public static List<Button> buttonList1_1 = new List<Button>();
        public static List<Button> buttons_Select1_1 = new List<Button>();
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 fr2)
        {
            InitializeComponent();
            this.frm2 = fr2;
        }

        public Button button1_1;
        private void btn_A1_H13_Click(object sender, EventArgs e)
        {

            button1_1 = (Button)sender;

            if (i_people1_1 > i_seatcount1_1)
            {
                if (button1_1.Enabled == true)
                {
                    button1_1.BackColor = Color.Red;
                    i_seatcount1_1++;
                    buttons_Select1_1.Add(button1_1);
                    
                }
            }
            else
            {
                MessageBox.Show("인원수 보다 더 많은 자리를 예약은 못합니다.");
            }
        }
        public void Get_Moive1_1(string time)
        {
            lb_movie1_1_time.Text = time;
        }
        private void SeatListAdd()
        {
            buttonList1_1.Add(btn_A1);
            buttonList1_1.Add(btn_A2);
            buttonList1_1.Add(btn_A3);
            buttonList1_1.Add(btn_A4);
            buttonList1_1.Add(btn_A5);
            buttonList1_1.Add(btn_A6);
            buttonList1_1.Add(btn_A7);
            buttonList1_1.Add(btn_A8);
            buttonList1_1.Add(btn_A9);
            buttonList1_1.Add(btn_A10);
            buttonList1_1.Add(btn_A11);
            buttonList1_1.Add(btn_A12);
            buttonList1_1.Add(btn_B1);
            buttonList1_1.Add(btn_B2);
            buttonList1_1.Add(btn_B3);
            buttonList1_1.Add(btn_B4);
            buttonList1_1.Add(btn_B5);
            buttonList1_1.Add(btn_B6);
            buttonList1_1.Add(btn_B7);
            buttonList1_1.Add(btn_B8);
            buttonList1_1.Add(btn_B9);
            buttonList1_1.Add(btn_B10);
            buttonList1_1.Add(btn_B11);
            buttonList1_1.Add(btn_B12);
            buttonList1_1.Add(btn_C1);
            buttonList1_1.Add(btn_C2);
            buttonList1_1.Add(btn_C3);
            buttonList1_1.Add(btn_C4);
            buttonList1_1.Add(btn_C5);
            buttonList1_1.Add(btn_C6);
            buttonList1_1.Add(btn_C7);
            buttonList1_1.Add(btn_C8);
            buttonList1_1.Add(btn_C9);
            buttonList1_1.Add(btn_C10);
            buttonList1_1.Add(btn_C11);
            buttonList1_1.Add(btn_C12);
            buttonList1_1.Add(btn_D1);
            buttonList1_1.Add(btn_D2);
            buttonList1_1.Add(btn_D3);
            buttonList1_1.Add(btn_D4);
            buttonList1_1.Add(btn_D5);
            buttonList1_1.Add(btn_D6);
            buttonList1_1.Add(btn_D7);
            buttonList1_1.Add(btn_D8);
            buttonList1_1.Add(btn_D9);
            buttonList1_1.Add(btn_D10);
            buttonList1_1.Add(btn_D11);
            buttonList1_1.Add(btn_D12);
        }
        public static int i1_1 = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            buttonList1_1.Clear();
            i_people1_1 = 0;
            numericUpDown_Adult.Value = i_Adult1_1;
            numericUpDown_Teen.Value = i_Teen1_1;
            
            SeatListAdd();

            i_count1_1 = 0;
            foreach (var item in buttonList1_1)         //각각 예매가 완료되서 비활성화된 버튼 검출
            {
                if (item.Enabled == false)
                {
                    i_count1_1++;
                }
            }
            if (i1_1 == 0)
            {
                i_FullSeat1_1 -= i_count1_1;                  //남은 좌석 계산
            }
            else
            {
                i_FullSeat1_1 = 48;
                i_FullSeat1_1 -= (buttons_Select1_1.Count + i_count1_1);
            }
            i1_1++;
            lb_seats.Text = i_FullSeat1_1.ToString();
            pictureBox1.Load(@"C:\C#\MiniProject1\bin\Movie4.jpg");
            
        }
        private double sum(double x, double y)
        {
            return x * 11000 + y * 8000;
        }
        
        private void numericUpDown_Adult_ValueChanged(object sender, EventArgs e)
        {
            i_Adult1_1 = (int)numericUpDown_Adult.Value;
            i_Teen1_1 = (int)numericUpDown_Teen.Value;
            i_people1_1 = i_Adult1_1 + i_Teen1_1;
            lb_Pay_Adult.Text = string.Format("{0}", i_Adult1_1 * 11000);
            d_allsum1_1 = sum(i_Adult1_1, i_Teen1_1);
            lb_Pay.Text = string.Format("{0}", d_allsum1_1);
            if(i_people1_1 < buttons_Select1_1.Count)
            {
                buttons_Select1_1[buttons_Select1_1.Count - 1].BackColor = SystemColors.Control;
                buttons_Select1_1.RemoveAt(buttons_Select1_1.Count - 1);
                i_seatcount1_1--;
            }
        }

        private void numericUpDown_Teen_ValueChanged(object sender, EventArgs e)
        {
            i_Adult1_1 = (int)numericUpDown_Adult.Value;
            i_Teen1_1 = (int)numericUpDown_Teen.Value;
            i_people1_1 = i_Adult1_1 + i_Teen1_1;
            lb_Pay_Teen.Text = string.Format("{0}", i_Teen1_1 * 8000);
            d_allsum1_1 = sum(i_Adult1_1, i_Teen1_1);
            lb_Pay.Text = string.Format("{0}", d_allsum1_1);
            if (i_people1_1 < buttons_Select1_1.Count)
            {
                buttons_Select1_1[buttons_Select1_1.Count - 1].BackColor = SystemColors.Control;
                buttons_Select1_1.RemoveAt(buttons_Select1_1.Count - 1);
                i_seatcount1_1--;
            }
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            movie1_1 = true;
            if(i_people1_1 > i_seatcount1_1)
            {
                MessageBox.Show("인원수 보다 좌석수가 적습니다.");
                return;
            }
            foreach (var item in buttons_Select1_1)         //각각 예매가 완료되서 비활성화된 버튼 검출
            {
                item.BackColor = Color.Red;
            }

            i_FullSeat1_1 -= i_Adult1_1 + i_Teen1_1;                  //남은 좌석 계산
            lb_seats.Text = i_FullSeat1_1.ToString();
            Form9 form9 = new Form9(this);
            form9.Show();
            form9.Val(lb_Pay.Text);
            this.Hide();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            foreach (var item in buttons_Select1_1)
            {
                item.Enabled = true;
                item.BackColor = SystemColors.Control;
            }
            numericUpDown_Adult.Value = 0;
            numericUpDown_Teen.Value = 0;
            i_seatcount1_1 = 0;
            i_count1_1 = 0;
            buttons_Select1_1.Clear();
            buttonList1_1.Clear();
            this.Close();
            frm2.Show();
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            i1_1 = 0;
            buttons_Select1_1.Clear();
            i_seatcount1_1 = 0;
            i_Adult1_1 = 0;
            i_Teen1_1 = 0;
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }
    }
}
