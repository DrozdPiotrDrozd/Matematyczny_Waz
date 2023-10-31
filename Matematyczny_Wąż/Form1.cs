using System.Windows.Forms;
using System.Xml.Serialization;

namespace Matematyczny_Wąż
{
    public partial class Form1 : Form
    {
        waz gracz = new waz();
        public static int punkty = 0;
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        bool czyprawo = false, czylewo = false;
        int szybkosctla;
        Random rnd;
        PictureBox[] kamienie;
        int szybkosc_kamieni;
        public Form1()
        {
            InitializeComponent();
            myTimer.Interval = 5; // Ustaw interwał
            myTimer.Tick += new EventHandler(Timer_Tick); // Przypisz obsługę zdarzenia Tick
            myTimer.Start(); // Rozpocznij działanie timera
            gracz.Location = new Point(463, 400);
            Controls.Add(gracz);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ruch(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                czylewo = true;

            }
            else if (e.KeyCode == Keys.Right)
            {
                czyprawo = true;

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Stone s in StoneList)
            {
                s.Location = new Point(s.Location.X, s.Location.Y + 3);
            }



            if (czylewo)
            {
                gracz.Location = new Point(gracz.Location.X - 10, gracz.Location.Y);

            }
            else if (czyprawo)
            {
                gracz.Location = new Point(gracz.Location.X + 10, gracz.Location.Y);

            }
        }


        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                czylewo = false;

            }
            else if (e.KeyCode == Keys.Right)
            {
                czyprawo = false;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static List<Stone> StoneList = new List<Stone>();
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            Stone s = new Stone();
            StoneList.Add(s);
            Random randomY = new Random();

            int rY = -150;
            Random randomX = new Random();
            int rx = randomX.Next(400, 800);
            this.Controls.Add(s);
            s.BringToFront();
            s.Location = new Point(rx, rY);








        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Stone s = new Stone();
            StoneList.Add(s);
            Random randomY = new Random();

            int rY = -150;
            Random randomX = new Random();
            int rx = randomX.Next(30, 350);
            this.Controls.Add(s);
            s.BringToFront();
            s.Location = new Point(rx, rY);





        }
        void AddPunkty()
        {
            punkty--;
            Score.Text = $"Score: {punkty}";
        }

        private void Update(object sender, EventArgs e)
        {
            try
            {
                foreach (Stone s in StoneList)
                {
                    foreach (waz w in Controls.OfType<waz>())
                    {
                        if (w.Bounds.IntersectsWith(s.Bounds))
                        {
                            StoneList.Remove(s);
                            AddPunkty();
                            Controls.Remove(s);

                        }
                    }
                }
            }
            catch { }
        }
    }
}