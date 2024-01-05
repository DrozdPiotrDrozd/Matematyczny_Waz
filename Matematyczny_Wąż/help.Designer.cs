namespace Matematyczny_Wąż
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            label1 = new Label();
            waz1 = new waz();
            kloda1 = new kloda();
            stone1 = new Stone();
            krokodyl1 = new krokodyl();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)waz1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kloda1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stone1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)krokodyl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 288);
            label1.MinimumSize = new Size(100, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 96);
            label1.TabIndex = 1;
            label1.Text = "Sterowanie\r\n\r\n\r\n";
            // 
            // waz1
            // 
            waz1.BackColor = Color.Transparent;
            waz1.Image = (Image)resources.GetObject("waz1.Image");
            waz1.Location = new Point(133, 398);
            waz1.Name = "waz1";
            waz1.Size = new Size(86, 281);
            waz1.SizeMode = PictureBoxSizeMode.Zoom;
            waz1.TabIndex = 2;
            waz1.TabStop = false;
            // 
            // kloda1
            // 
            kloda1.BackColor = Color.Transparent;
            kloda1.Image = (Image)resources.GetObject("kloda1.Image");
            kloda1.Location = new Point(926, 398);
            kloda1.Name = "kloda1";
            kloda1.Size = new Size(298, 91);
            kloda1.SizeMode = PictureBoxSizeMode.Zoom;
            kloda1.TabIndex = 3;
            kloda1.TabStop = false;
            // 
            // stone1
            // 
            stone1.BackColor = Color.Transparent;
            stone1.Image = (Image)resources.GetObject("stone1.Image");
            stone1.Location = new Point(484, 362);
            stone1.Name = "stone1";
            stone1.Size = new Size(211, 155);
            stone1.SizeMode = PictureBoxSizeMode.Zoom;
            stone1.TabIndex = 4;
            stone1.TabStop = false;
            // 
            // krokodyl1
            // 
            krokodyl1.BackColor = Color.Transparent;
            krokodyl1.Image = (Image)resources.GetObject("krokodyl1.Image");
            krokodyl1.Location = new Point(721, 617);
            krokodyl1.Name = "krokodyl1";
            krokodyl1.Size = new Size(224, 220);
            krokodyl1.SizeMode = PictureBoxSizeMode.Zoom;
            krokodyl1.TabIndex = 5;
            krokodyl1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(642, 288);
            label2.Name = "label2";
            label2.Size = new Size(395, 32);
            label2.TabIndex = 6;
            label2.Text = "Utrata punktów przy zderzeniu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1020, 540);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 7;
            label3.Text = "-100 pkt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(536, 540);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 8;
            label4.Text = "-50 pkt";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(677, 862);
            label5.Name = "label5";
            label5.Size = new Size(317, 32);
            label5.TabIndex = 9;
            label5.Text = "Natychmiastowa śmierć";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.retmenu;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(466, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 212);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // help
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(1262, 977);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(krokodyl1);
            Controls.Add(stone1);
            Controls.Add(kloda1);
            Controls.Add(waz1);
            Controls.Add(label1);
            Name = "help";
            Text = "help";
            ((System.ComponentModel.ISupportInitialize)waz1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kloda1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stone1).EndInit();
            ((System.ComponentModel.ISupportInitialize)krokodyl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private waz waz1;
        private kloda kloda1;
        private Stone stone1;
        private krokodyl krokodyl1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}