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
            SuspendLayout();
            // 
            // Score
            // 
            Score.AutoSize = true;
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
            timer3.Interval = 2000;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1262, 977);
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
    }
}