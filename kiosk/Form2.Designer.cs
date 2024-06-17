namespace MiniProject1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btn_Home = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            imageList2 = new System.Windows.Forms.ImageList(components);
            btn_Movie1Time1 = new System.Windows.Forms.Button();
            btn_Movie1Time2 = new System.Windows.Forms.Button();
            btn_Movie2Time1 = new System.Windows.Forms.Button();
            btn_Movie2Time2 = new System.Windows.Forms.Button();
            btn_Movie3Time1 = new System.Windows.Forms.Button();
            btn_Movie3Time2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_Home
            // 
            btn_Home.ImageIndex = 0;
            btn_Home.ImageList = imageList1;
            btn_Home.Location = new System.Drawing.Point(615, 47);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new System.Drawing.Size(43, 44);
            btn_Home.TabIndex = 0;
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Home.png");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            imageList2.Images.SetKeyName(0, "Movie1.jpg");
            imageList2.Images.SetKeyName(1, "Movie2.jpg");
            imageList2.Images.SetKeyName(2, "Movie3.jpg");
            imageList2.Images.SetKeyName(3, "Movie4.jpg");
            imageList2.Images.SetKeyName(4, "Movie1.jpg");
            imageList2.Images.SetKeyName(5, "Movie2.jpg");
            imageList2.Images.SetKeyName(6, "Movie3.jpg");
            imageList2.Images.SetKeyName(7, "Movie4.jpg");
            // 
            // btn_Movie1Time1
            // 
            btn_Movie1Time1.Location = new System.Drawing.Point(460, 149);
            btn_Movie1Time1.Name = "btn_Movie1Time1";
            btn_Movie1Time1.Size = new System.Drawing.Size(75, 50);
            btn_Movie1Time1.TabIndex = 1;
            btn_Movie1Time1.Text = "16:40";
            btn_Movie1Time1.UseVisualStyleBackColor = true;
            btn_Movie1Time1.Click += btn_Movie1Time1_Click;
            // 
            // btn_Movie1Time2
            // 
            btn_Movie1Time2.Location = new System.Drawing.Point(330, 149);
            btn_Movie1Time2.Name = "btn_Movie1Time2";
            btn_Movie1Time2.Size = new System.Drawing.Size(75, 50);
            btn_Movie1Time2.TabIndex = 1;
            btn_Movie1Time2.Text = "13:50";
            btn_Movie1Time2.UseVisualStyleBackColor = true;
            btn_Movie1Time2.Click += btn_Movie1Time2_Click;
            // 
            // btn_Movie2Time1
            // 
            btn_Movie2Time1.Location = new System.Drawing.Point(460, 420);
            btn_Movie2Time1.Name = "btn_Movie2Time1";
            btn_Movie2Time1.Size = new System.Drawing.Size(75, 50);
            btn_Movie2Time1.TabIndex = 1;
            btn_Movie2Time1.Text = "17:00";
            btn_Movie2Time1.UseVisualStyleBackColor = true;
            btn_Movie2Time1.Click += btn_Movie2Time1_Click;
            // 
            // btn_Movie2Time2
            // 
            btn_Movie2Time2.Location = new System.Drawing.Point(330, 420);
            btn_Movie2Time2.Name = "btn_Movie2Time2";
            btn_Movie2Time2.Size = new System.Drawing.Size(75, 50);
            btn_Movie2Time2.TabIndex = 1;
            btn_Movie2Time2.Text = "15:30";
            btn_Movie2Time2.UseVisualStyleBackColor = true;
            btn_Movie2Time2.Click += btn_Movie2Time2_Click;
            // 
            // btn_Movie3Time1
            // 
            btn_Movie3Time1.Location = new System.Drawing.Point(460, 690);
            btn_Movie3Time1.Name = "btn_Movie3Time1";
            btn_Movie3Time1.Size = new System.Drawing.Size(75, 50);
            btn_Movie3Time1.TabIndex = 1;
            btn_Movie3Time1.Text = "18:10";
            btn_Movie3Time1.UseVisualStyleBackColor = true;
            btn_Movie3Time1.Click += btn_Movie3Time1_Click;
            // 
            // btn_Movie3Time2
            // 
            btn_Movie3Time2.Location = new System.Drawing.Point(330, 690);
            btn_Movie3Time2.Name = "btn_Movie3Time2";
            btn_Movie3Time2.Size = new System.Drawing.Size(75, 50);
            btn_Movie3Time2.TabIndex = 1;
            btn_Movie3Time2.Text = "14:00";
            btn_Movie3Time2.UseVisualStyleBackColor = true;
            btn_Movie3Time2.Click += btn_Movie3Time2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(737, 898);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(10, 15);
            label1.TabIndex = 2;
            label1.Text = ".";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(33, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(260, 239);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(33, 320);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(260, 239);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new System.Drawing.Point(33, 592);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(260, 239);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(460, 213);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(247, 15);
            label2.TabIndex = 4;
            label2.Text = "예매완료후 돌아오면 저장되어있는건 미구현";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(781, 655);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_Movie3Time2);
            Controls.Add(btn_Movie2Time2);
            Controls.Add(btn_Movie1Time2);
            Controls.Add(btn_Movie3Time1);
            Controls.Add(btn_Movie2Time1);
            Controls.Add(btn_Movie1Time1);
            Controls.Add(btn_Home);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btn_Movie1Time2;
        private System.Windows.Forms.Button btn_Movie2Time1;
        private System.Windows.Forms.Button btn_Movie2Time2;
        private System.Windows.Forms.Button btn_Movie3Time1;
        private System.Windows.Forms.Button btn_Movie3Time2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_Movie1Time1;
    }
}