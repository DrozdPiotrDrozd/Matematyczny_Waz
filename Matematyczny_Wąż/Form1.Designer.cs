namespace Matematyczny_Wąż
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
            Score = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            tmrrownania = new System.Windows.Forms.Timer(components);
            look = new System.Windows.Forms.Timer(components);
            stopgencount = new System.Windows.Forms.Timer(components);
            kloda_timer = new System.Windows.Forms.Timer(components);
            poziomy = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ruchpoz = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            stopgenkrok = new System.Windows.Forms.Timer(components);
            stopgenkloda = new System.Windows.Forms.Timer(components);
            krokodylgen = new System.Windows.Forms.Timer(components);
            pauza = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Score
            // 
            Score.AutoEllipsis = true;
            Score.AutoSize = true;
            Score.BackColor = Color.Khaki;
            Score.BorderStyle = BorderStyle.Fixed3D;
            Score.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Score.ForeColor = SystemColors.WindowText;
            Score.Location = new Point(1099, 18);
            Score.Name = "Score";
            Score.Size = new Size(103, 33);
            Score.TabIndex = 4;
            Score.Text = "Score: 0";
            Score.Click += label1_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 3000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 2500;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Enabled = true;
            timer4.Interval = 20;
            timer4.Tick += Update;
            // 
            // timer5
            // 
            timer5.Enabled = true;
            timer5.Interval = 15;
            timer5.Tick += timer5_Tick;
            // 
            // tmrrownania
            // 
            tmrrownania.Enabled = true;
            tmrrownania.Interval = 10000;
            tmrrownania.Tick += tmrrownania_Tick;
            // 
            // look
            // 
            look.Enabled = true;
            look.Interval = 20;
            look.Tick += look_Tick_1;
            // 
            // stopgencount
            // 
            stopgencount.Enabled = true;
            stopgencount.Interval = 1000;
            stopgencount.Tick += stopgencount_Tick;
            // 
            // kloda_timer
            // 
            kloda_timer.Enabled = true;
            kloda_timer.Interval = 4000;
            kloda_timer.Tick += kloda_timer_Tick;
            // 
            // poziomy
            // 
            poziomy.Enabled = true;
            poziomy.Interval = 5;
            poziomy.Tick += poziomy_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.Click += label1_Click_1;
            // 
            // ruchpoz
            // 
            ruchpoz.Enabled = true;
            ruchpoz.Interval = 15;
            ruchpoz.Tick += ruchpoz_Tick;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // stopgenkrok
            // 
            stopgenkrok.Enabled = true;
            stopgenkrok.Interval = 15;
            stopgenkrok.Tick += timer6_Tick;
            // 
            // stopgenkloda
            // 
            stopgenkloda.Enabled = true;
            stopgenkloda.Interval = 1000;
            stopgenkloda.Tick += stopgenkloda_Tick;
            // 
            // krokodylgen
            // 
            krokodylgen.Enabled = true;
            krokodylgen.Interval = 6500;
            krokodylgen.Tick += krokodylgen_Tick;
            // 
            // pauza
            // 
            pauza.Enabled = true;
            pauza.Interval = 10;
            pauza.Tick += pauza_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.reset;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(467, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 257);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.retmenu;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(467, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(303, 265);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1262, 977);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Score);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += ruch;
            KeyUp += keyup;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Score;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer tmrrownania;
        private System.Windows.Forms.Timer look;
        private System.Windows.Forms.Timer stopgencount;
        public System.Windows.Forms.Timer kloda_timer;
        private System.Windows.Forms.Timer poziomy;
        private Label label1;
        private System.Windows.Forms.Timer ruchpoz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer stopgenkrok;
        private System.Windows.Forms.Timer stopgenkloda;
        private System.Windows.Forms.Timer krokodylgen;
        private System.Windows.Forms.Timer pauza;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}