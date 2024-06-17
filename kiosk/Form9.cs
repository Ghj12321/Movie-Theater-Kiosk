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
    public partial class Form9 : Form
    {
        Form3 frm3;
        Form5 frm5;
        Form7 frm7;
        public Form9()
        {
            InitializeComponent();

        }

        public Form9(Form3 fr3)
        {
            InitializeComponent();
            this.frm3 = fr3;
        }
        public Form9(Form5 fr5)
        {
            InitializeComponent();
            this.frm5 = fr5;
        }
        public Form9(Form7 fr7)
        {
            InitializeComponent();
            this.frm7 = fr7;
        }
        public void Val(string Price)
        {
            lb_Pay.Text = Price;
            lb_FinalPay.Text = lb_Pay.Text;
        }
        
        private void btnPay_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            if(cb_PayWay.Text == "" && cb_PayInfo.Text =="")
            {
                MessageBox.Show("결제정보를 다시 입력해주세요");
                return;
            }
            if (radioAgree.Checked == true)
            {
                if (double.Parse(tb_Point.Text) < 1000 || ((double.Parse(tb_Point.Text) % 10) != 0))
                {
                    MessageBox.Show("포인트 이용안내를 읽어주시고 다시 입력해주세요");
                    return;
                }
                else
                {
                    MessageBox.Show(cb_PayWay.Text + " (으)로 " + cb_PayInfo.Text + " 을 " + "\n 선택하셧습니다," + "\n 결제금액은" + lb_FinalPay.Text + "원 입니다.");
                    form1.Show();
                    this.Close();
                    Form3.i1_1 = 0;
                    Form3.buttons_Select1_1.Clear();
                    Form3.i_seatcount1_1 = 0;
                    Form3.i_Adult1_1 = 0;
                    Form3.i_Teen1_1 = 0;
                    foreach (var item in Form3.buttons_Select1_1)
                    {
                        item.Enabled = false;
                    }
                }
            }
            else if (radioDisAgree.Checked == true)
            {
                MessageBox.Show(cb_PayWay.Text + " (으)로 " + cb_PayInfo.Text + " 을 " + "\n 선택하셧습니다," + "\n 결제금액은" + lb_FinalPay.Text + "원 입니다.");
                form1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("포인트 사용 여부를 결정해주세요");
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            
            if (Form3.movie1_1 == true)
            {
                frm3.Show();
                this.Close();
                
            }
            if (Form5.movie2_1 == true)
            {
                this.Hide();
                frm5.Show();
                foreach (var item in Form5.movie2_1_buttons_Clear)
                {
                    item.Enabled = true;
                    item.BackColor = Color.Red;
                }
            }
            if (Form7.movie3_1 == true)
            {
                this.Hide();
                frm7.Show();
                foreach (var item in Form7.movie3_1_buttons_Clear)
                {
                    item.Enabled = true;
                    item.BackColor = Color.Red;
                }
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void cb_PayWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_PayInfo.Items.Clear();
            if (cb_PayWay.SelectedIndex == 0)
            {
                cb_PayInfo.Items.Add("기업은행");
                cb_PayInfo.Items.Add("농협은행");
                cb_PayInfo.Items.Add("국민은행");
                cb_PayInfo.Items.Add("신한은행");
            }
            if (cb_PayWay.SelectedIndex == 1)
            {
                cb_PayInfo.Items.Add("SSGPAY");
                cb_PayInfo.Items.Add("카카오페이");
                cb_PayInfo.Items.Add("PAYCO");

            }
        }
        double? Point = 0;

        private void radioAgree_CheckedChanged(object sender, EventArgs e)
        {
            Point = 0;
            tb_Point.Text = string.Format("{0}", Point);

        }

        private void radioDisAgree_CheckedChanged(object sender, EventArgs e)
        {
            Point = 0;
            tb_Point.Text ="0";
        }

        private void tb_Point_TextChanged(object sender, EventArgs e)
        {
            Point = double.Parse(tb_Point.Text);
            lb_Point.Text = Point.ToString();
            lb_FinalPay.Text = (double.Parse(lb_Pay.Text) - Point).ToString();
            
        }
    }
}
