namespace MiniProject1
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            btnPay = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lb_Pay = new System.Windows.Forms.Label();
            imageList1 = new System.Windows.Forms.ImageList(components);
            btn_Back = new System.Windows.Forms.Button();
            btn_Home = new System.Windows.Forms.Button();
            cb_PayWay = new System.Windows.Forms.ComboBox();
            cb_PayInfo = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            tb_Point = new System.Windows.Forms.TextBox();
            radioAgree = new System.Windows.Forms.RadioButton();
            radioDisAgree = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lb_Point = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lb_FinalPay = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.Location = new System.Drawing.Point(409, 287);
            btnPay.Name = "btnPay";
            btnPay.Size = new System.Drawing.Size(109, 59);
            btnPay.TabIndex = 18;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(51, 56);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 15);
            label9.TabIndex = 16;
            label9.Text = "결제방법";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(402, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 15);
            label1.TabIndex = 21;
            label1.Text = "결제하실 금액";
            // 
            // lb_Pay
            // 
            lb_Pay.AutoSize = true;
            lb_Pay.Location = new System.Drawing.Point(402, 81);
            lb_Pay.Name = "lb_Pay";
            lb_Pay.Size = new System.Drawing.Size(12, 15);
            lb_Pay.TabIndex = 22;
            lb_Pay.Text = "-";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "BackImage.png");
            imageList1.Images.SetKeyName(1, "Home.png");
            // 
            // btn_Back
            // 
            btn_Back.ImageIndex = 0;
            btn_Back.ImageList = imageList1;
            btn_Back.Location = new System.Drawing.Point(402, 8);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new System.Drawing.Size(43, 40);
            btn_Back.TabIndex = 24;
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Home
            // 
            btn_Home.ImageIndex = 1;
            btn_Home.ImageList = imageList1;
            btn_Home.Location = new System.Drawing.Point(475, 9);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new System.Drawing.Size(43, 38);
            btn_Home.TabIndex = 25;
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // cb_PayWay
            // 
            cb_PayWay.FormattingEnabled = true;
            cb_PayWay.Items.AddRange(new object[] { "신용카드", "간편 결제" });
            cb_PayWay.Location = new System.Drawing.Point(55, 100);
            cb_PayWay.Name = "cb_PayWay";
            cb_PayWay.Size = new System.Drawing.Size(96, 23);
            cb_PayWay.TabIndex = 26;
            cb_PayWay.SelectedIndexChanged += cb_PayWay_SelectedIndexChanged;
            // 
            // cb_PayInfo
            // 
            cb_PayInfo.FormattingEnabled = true;
            cb_PayInfo.Location = new System.Drawing.Point(180, 100);
            cb_PayInfo.Name = "cb_PayInfo";
            cb_PayInfo.Size = new System.Drawing.Size(96, 23);
            cb_PayInfo.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(51, 151);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 16;
            label2.Text = "포인트";
            // 
            // tb_Point
            // 
            tb_Point.Location = new System.Drawing.Point(56, 214);
            tb_Point.Name = "tb_Point";
            tb_Point.Size = new System.Drawing.Size(126, 23);
            tb_Point.TabIndex = 27;
            tb_Point.TextChanged += tb_Point_TextChanged;
            // 
            // radioAgree
            // 
            radioAgree.AutoSize = true;
            radioAgree.Location = new System.Drawing.Point(57, 180);
            radioAgree.Name = "radioAgree";
            radioAgree.Size = new System.Drawing.Size(89, 19);
            radioAgree.TabIndex = 28;
            radioAgree.TabStop = true;
            radioAgree.Text = "포인트 사용";
            radioAgree.UseVisualStyleBackColor = true;
            radioAgree.CheckedChanged += radioAgree_CheckedChanged;
            // 
            // radioDisAgree
            // 
            radioDisAgree.AutoSize = true;
            radioDisAgree.Location = new System.Drawing.Point(180, 180);
            radioDisAgree.Name = "radioDisAgree";
            radioDisAgree.Size = new System.Drawing.Size(113, 19);
            radioDisAgree.TabIndex = 28;
            radioDisAgree.TabStop = true;
            radioDisAgree.Text = "포인트 사용안함";
            radioDisAgree.UseVisualStyleBackColor = true;
            radioDisAgree.CheckedChanged += radioDisAgree_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(55, 254);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(335, 15);
            label3.TabIndex = 29;
            label3.Text = "이용안내 포인트 사용은 1000P이상부터 10P단위로 사용가능";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(402, 108);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 21;
            label4.Text = "할인내역";
            // 
            // lb_Point
            // 
            lb_Point.AutoSize = true;
            lb_Point.Location = new System.Drawing.Point(402, 138);
            lb_Point.Name = "lb_Point";
            lb_Point.Size = new System.Drawing.Size(12, 15);
            lb_Point.TabIndex = 30;
            lb_Point.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(402, 169);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 15);
            label5.TabIndex = 21;
            label5.Text = "최종 결제 금액";
            // 
            // lb_FinalPay
            // 
            lb_FinalPay.AutoSize = true;
            lb_FinalPay.Location = new System.Drawing.Point(403, 197);
            lb_FinalPay.Name = "lb_FinalPay";
            lb_FinalPay.Size = new System.Drawing.Size(12, 15);
            lb_FinalPay.TabIndex = 31;
            lb_FinalPay.Text = "-";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(612, 450);
            Controls.Add(lb_FinalPay);
            Controls.Add(lb_Point);
            Controls.Add(label3);
            Controls.Add(radioDisAgree);
            Controls.Add(radioAgree);
            Controls.Add(tb_Point);
            Controls.Add(cb_PayInfo);
            Controls.Add(cb_PayWay);
            Controls.Add(btn_Home);
            Controls.Add(btn_Back);
            Controls.Add(lb_Pay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnPay);
            Controls.Add(label2);
            Controls.Add(label9);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Pay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.ComboBox cb_PayWay;
        private System.Windows.Forms.ComboBox cb_PayInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Point;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.RadioButton radioDisAgree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Point;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_FinalPay;
        private System.Windows.Forms.Timer timer1;
    }
}