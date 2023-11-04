using Matematyczny_Wąż.Properties;
using System;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Matematyczny_Wąż
{
    public partial class Form1 : Form
    {
        niepoprawne2 np2 = new niepoprawne2();
        niepoprawne1 np1 = new niepoprawne1();
        poprawne p = new poprawne();
        rownanie r = new rownanie();
        waz gracz = new waz();
        int punkty = 0;
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
            gracz.Location = new Point(424, 376);
            r.Location = new Point(440, 10);
            Controls.Add(r);
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
        public static List<poprawne> popList = new List<poprawne>();
        public static List<niepoprawne1> npop1List = new List<niepoprawne1>();
        public static List<niepoprawne2> npop2List = new List<niepoprawne2>();
        public static List<rownanie> rowList = new List<rownanie>();

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

            s.Location = new Point(rx, rY);





        }
        void subPunkty()
        {
            punkty = punkty - 1;
            Score.Text = $"Score: {punkty}";

        }
        void sub2Punkty()
        {
            punkty = punkty - 100;
            Score.Text = $"Score: {punkty}";
        }
        void AddPunkty()
        {
            punkty = punkty + 100;
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
                            Controls.Remove(s);
                            subPunkty();

                        }
                    }
                }
            }
            catch { }
            try
            {
                foreach (poprawne p in popList)
                {
                    foreach (waz w in Controls.OfType<waz>())
                    {
                        if (w.Bounds.IntersectsWith(p.Bounds))
                        {
                            popList.Remove(p);
                            Controls.Remove(p);
                            AddPunkty();

                        }
                    }
                }
            }
            catch { }
            try
            {
                foreach (niepoprawne1 np1 in npop1List)
                {
                    foreach (waz w in Controls.OfType<waz>())
                    {
                        if (w.Bounds.IntersectsWith(np1.Bounds))
                        {
                            npop1List.Remove(np1);
                            Controls.Remove(np1);
                            sub2Punkty();

                        }
                    }
                }
            }
            catch { }
            try
            {
                foreach (niepoprawne2 np2 in npop2List)
                {
                    foreach (waz w in Controls.OfType<waz>())
                    {
                        if (w.Bounds.IntersectsWith(np2.Bounds))
                        {
                            npop2List.Remove(np2);
                            Controls.Remove(np2);
                            sub2Punkty();


                        }
                    }
                }
            }
            catch { }
        }



        private void timer5_Tick(object sender, EventArgs e)
        {
            p.Location = new Point(p.Location.X, p.Location.Y + 3);
            np1.Location = new Point(np1.Location.X, np1.Location.Y + 3);
            np2.Location = new Point(np2.Location.X, np2.Location.Y + 3);
        }
        private void tmrrownania_Tick(object sender, EventArgs e)
        {

            Random zad1 = new Random();
            int z1 = zad1.Next(1, 15);
            Random zad2 = new Random();
            int z2 = zad2.Next(1, 10);
            Random znak = new Random();
            int z = znak.Next(1, 4);
            double odp;
            switch (z)
            {
                case 1:
                    r.Text = $"{z1} + {z2}";
                    odp = z1 + z2;
                    p.Text = $"{odp}";
                    rowList.Add(r);
                    Controls.Add(r);
                    break;
                case 2:
                    r.Text = $"{z1} - {z2}";
                    odp = z1 - z2;
                    p.Text = $"{odp}";
                    rowList.Add(r);
                    Controls.Add(r);
                    break;
                case 3:
                    r.Text = $"{z1} * {z2}";
                    odp = z1 * z2;
                    p.Text = $"{odp}";
                    rowList.Add(r);
                    Controls.Add(r);
                    break;
                case 4:
                    r.Text = $"{z1} / {z2}";
                    odp = z1 / z2;
                    p.Text = $"{odp}";
                    rowList.Add(r);
                    Controls.Add(r);
                    break;
            }


            r.BringToFront();

            Controls.Add(r);




        }



        private void ans_Tick(object sender, EventArgs e)
        {
            Random location = new Random();
            int l = location.Next(1, 6);
            switch (l)
            {
                case 1:
                    p.Location = new Point(10, -400);
                    np1.Location = new Point(400, -400);
                    np2.Location = new Point(700, -400);
                    break;
                case 2:
                    p.Location = new Point(10, -400);
                    np2.Location = new Point(400, -400);
                    np1.Location = new Point(700, -400);
                    break;
                case 3:
                    np1.Location = new Point(10, -400);
                    np2.Location = new Point(400, -400);
                    p.Location = new Point(700, -400);
                    break;
                case 4:
                    np1.Location = new Point(10, -400);
                    p.Location = new Point(400, -400);
                    np2.Location = new Point(700, -400);
                    break;
                case 5:
                    np2.Location = new Point(10, -400);
                    p.Location = new Point(400, -400);
                    np1.Location = new Point(700, -400);
                    break;
                case 6:
                    np2.Location = new Point(10, -400);
                    np1.Location = new Point(400, -400);
                    p.Location = new Point(700, -400);
                    break;
            }
            Random falsz = new Random();
            int f1 = location.Next(1, 60);
            Random falsz2 = new Random();
            int f2 = location.Next(1, 35);
            np1.Text = $"{f1}";
            np2.Text = $"{f2}";

            popList.Add(p);
            npop1List.Add(np1);
            npop2List.Add(np2);
            p.BringToFront();
            np1.BringToFront();
            np2.BringToFront();
            Controls.Add(p);
            Controls.Add(np1);
            Controls.Add(np2);
        }

        private void look_Tick_1(object sender, EventArgs e)
        {
            if (punkty <= 100)
            {
                gracz.Image = Resources.w6;
                gracz.Size = new Size(86, 123);
            }
            else if (punkty <= 200)
            {
                gracz.Image = Resources.w5;
                gracz.Size = new Size(86, 164);
            }
            else if (punkty <= 300)
            {
                gracz.Image = Resources.w4;
                gracz.Size = new Size(86, 185);
            }
            else if (punkty <= 400)
            {
                gracz.Image = Resources.w3;
                gracz.Size = new Size(86, 219);
            }
            else if (punkty <= 500)
            {
                gracz.Image = Resources.w2;
                gracz.Size = new Size(86, 251);
            }
            else
            {
                gracz.Image = Resources.w1;
                gracz.Size = new Size(69, 225);
            }

        }

        int ticks = 0;
        private void stopgencount_Tick(object sender, EventArgs e)
        {
       

            if (ticks == 10)
            {
                timer3.Stop();
                timer2.Stop();

            }
            else if (ticks == 11)
            {
                timer3.Start();
                timer2.Start();
                ticks = ticks - 11;
            }
            ticks++;

        }



    }


}