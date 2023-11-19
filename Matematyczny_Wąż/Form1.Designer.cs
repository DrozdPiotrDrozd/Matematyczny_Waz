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
            timer6 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BackColor = Color.Khaki;
            Score.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Score.ForeColor = SystemColors.WindowText;
            Score.Location = new Point(1099, 18);
            Score.Name = "Score";
            Score.Size = new Size(101, 31);
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
            kloda_timer.Interval = 5000;
            kloda_timer.Tick += kloda_timer_Tick;
            // 
            // poziomy
            // 
            poziomy.Enabled = true;
            poziomy.Interval = 15;
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
            // timer6
            // 
            timer6.Enabled = true;
            timer6.Interval = 15;
            timer6.Tick += timer6_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1262, 977);
            Controls.Add(label1);
            Controls.Add(Score);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += ruch;
            KeyUp += keyup;
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
        private System.Windows.Forms.Timer timer6;
    }
}