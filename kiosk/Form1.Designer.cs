namespace MiniProject1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Reserve = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lb_RealTime = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_Reserve
            // 
            btn_Reserve.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Reserve.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btn_Reserve.ImageIndex = 0;
            btn_Reserve.ImageList = imageList1;
            btn_Reserve.Location = new System.Drawing.Point(89, 124);
            btn_Reserve.Name = "btn_Reserve";
            btn_Reserve.Size = new System.Drawing.Size(266, 249);
            btn_Reserve.TabIndex = 0;
            btn_Reserve.Text = "티켓 구매";
            btn_Reserve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_Reserve.UseVisualStyleBackColor = true;
            btn_Reserve.Click += btn_Reserve_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Ticket1.jpg");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "땡땡영화관";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(56, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(317, 37);
            label2.TabIndex = 2;
            label2.Text = "무엇을 하고 싶으신가요?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(101, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "현재 시간:";
            // 
            // lb_RealTime
            // 
            lb_RealTime.AutoSize = true;
            lb_RealTime.Location = new System.Drawing.Point(169, 28);
            lb_RealTime.Name = "lb_RealTime";
            lb_RealTime.Size = new System.Drawing.Size(12, 15);
            lb_RealTime.TabIndex = 4;
            lb_RealTime.Text = "-";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(431, 485);
            Controls.Add(lb_RealTime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Reserve);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_RealTime;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_Reserve;
    }
}
