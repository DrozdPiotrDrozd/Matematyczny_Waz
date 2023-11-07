using Matematyczny_Wąż.Properties;
using System;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;

namespace Matematyczny_Wąż
{
    public partial class Form1 : Form
    {
        StartScreen startScreen = new StartScreen();

        Reset reset = new Reset();
        Stone s = new Stone();

        Resume resume = new Resume();
        Returntomenu returntomenu = new Returntomenu();
        StartScreen startscreen = new StartScreen();
        niepoprawne2 np2 = new niepoprawne2();
        niepoprawne1 np1 = new niepoprawne1();
        poprawne p = new poprawne();
        rownanie r = new rownanie();
        waz gracz = new waz();
        int punkty = 0;
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        bool czyprawo = false, czylewo = false;

        public Form1()
        {
            InitializeComponent();
            //   myTimer.Interval = 5; // Ustaw interwał
            //   myTimer.Tick += new EventHandler(Timer_Tick); // Przypisz obsługę zdarzenia Tick
            //   myTimer.Start(); // Rozpocznij działanie timera
            gracz.Location = new Point(600, 700);
            resume.Location = new Point(610, 400);
            returntomenu.Location = new Point(550, 200);
            reset.Location = new Point(610, 600);
            r.Location = new Point(600, 10);
            Controls.Add(r);
            Controls.Add(gracz);
            

        }

        private void Form1_Load(object sender, EventArgs e)
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
            if (e.KeyCode == Keys.Escape)
            {

                Controls.Add(reset);
                reset.Click += resecik;

                Controls.Add(resume);
                resume.Click += res;

                Controls.Add(returntomenu);
                returntomenu.Click += ret;

                timer5.Stop();
                timer4.Stop();
                timer3.Stop();
                timer2.Stop();
                tmrrownania.Stop();
                look.Stop();
                stopgencount.Stop();
                gracz.Visible = false;
                np1.Visible = false;
                np2.Visible = false;
                p.Visible = false;
                r.Visible = false;
                Score.Visible = false;
                
                try
                {
                    foreach (Stone s in StoneList)
                    {

                        s.Visible = false;

                    }
                }
                catch { }
            }
            void resecik(Object sender, EventArgs e)

            {
                try
                {
                    foreach (Stone s in StoneList)
                    {
                            StoneList.Remove(s);
                            Controls.Remove(s);
                        break;
                    }
                }
                catch { }
                try
                {
                    foreach (poprawne p in popList)
                    {
                            popList.Remove(p);
                            Controls.Remove(p);
                        break;
                    }
                }
                catch { }
                try
                {
                    foreach (niepoprawne1 np1 in npop1List)
                    {

                            npop1List.Remove(np1);
                            Controls.Remove(np1);
                        break;
                    }
                }
                catch { }
                try
                {
                    foreach (niepoprawne2 np2 in npop2List)
                    {
                            npop2List.Remove(np2);
                            Controls.Remove(np2);
                        break;
                    }
                }
                catch { }
                Controls.Remove(r);
                punkty = 0;
                Score.Text = $"Score: {punkty}";
                timer5.Stop();
                timer4.Stop();
                timer3.Stop();
                timer2.Stop();
                tmrrownania.Stop();
                look.Stop();
                stopgencount.Stop();

                timer5.Start();
                timer4.Start();
                timer3.Start();
                timer2.Start();
                tmrrownania.Start();
                look.Start();
                stopgencount.Start();
                try
                {
                    foreach (Stone s in StoneList)
                    {

                        s.Visible = true;

                    }
                }
                catch { }
                gracz.Visible = true;
                np1.Visible = true;
                np2.Visible = true;
                p.Visible = true;
                r.Visible = true;
                Score.Visible = true;

                Controls.Remove(returntomenu);
                Controls.Remove(resume);
                Controls.Remove(reset);
            }
            void ret(Object sender, EventArgs e)

            {
                startscreen.Show();
                this.Close();
            }
            void res(Object sender, EventArgs e)

            {
                try
                {
                    foreach (Stone s in StoneList)
                    {

                        s.Visible = true;

                    }
                }
                catch { }
                gracz.Visible = true;
                np1.Visible = true;
                np2.Visible = true;
                p.Visible = true;
                r.Visible = true;
                Score.Visible = true;

                Controls.Remove(returntomenu);
                Controls.Remove(resume);
                Controls.Remove(reset);
                timer5.Start();
                timer4.Start();
                timer3.Start();
                timer2.Start();
                tmrrownania.Start();
                look.Start();
                stopgencount.Start();
            }
            //   else if (e.KeyCode == Keys.Right)
            //  {
            //      czyprawo = true;

            //  }

        }


        /*     private void Timer_Tick(object sender, EventArgs e)
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
             }*/


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



        public void timer2_Tick(object sender, EventArgs e)
        {
            Stone s = new Stone();
            StoneList.Add(s);
            Random randomY = new Random();

            int rY = -150;
            Random randomX = new Random();
            int rx = randomX.Next(800, 1024);
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
            int rx = randomX.Next(0, 600);
            this.Controls.Add(s);

            s.Location = new Point(rx, rY);





        }
        /* void subPunkty()
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
         }*/

        private void Update(object sender, EventArgs e)
        {
            try
            {
                foreach (Stone s in StoneList)
                {

                    if (gracz.Bounds.IntersectsWith(s.Bounds))
                    {
                        StoneList.Remove(s);
                        Controls.Remove(s);
                        punkty = punkty - 1;
                        Score.Text = $"Score: {punkty}";
                        // subPunkty();
                        break;
                    }

                }
            }
            catch { }
            try
            {
                foreach (poprawne p in popList)
                {

                    if (gracz.Bounds.IntersectsWith(p.Bounds))
                    {
                        popList.Remove(p);
                        Controls.Remove(p);
                        punkty = punkty + 100;
                        Score.Text = $"Score: {punkty}";
                        // AddPunkty();
                        break;
                    }

                }
            }
            catch { }
            try
            {
                foreach (niepoprawne1 np1 in npop1List)
                {

                    if (gracz.Bounds.IntersectsWith(np1.Bounds))
                    {
                        npop1List.Remove(np1);
                        Controls.Remove(np1);
                        punkty = punkty - 100;
                        Score.Text = $"Score: {punkty}";
                        //  sub2Punkty();
                        break;
                    }

                }
            }
            catch { }
            try
            {
                foreach (niepoprawne2 np2 in npop2List)
                {

                    if (gracz.Bounds.IntersectsWith(np2.Bounds))
                    {
                        npop2List.Remove(np2);
                        Controls.Remove(np2);
                        punkty = punkty - 100;
                        Score.Text = $"Score: {punkty}";
                        //  sub2Punkty();

                        break;
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

            if (p.Location.Y > 1000 || np1.Location.Y > 1000 || np2.Location.Y > 1000)
            {
                popList.Remove(p);
                Controls.Remove(p);
                npop1List.Remove(np1);
                Controls.Remove(np1);
                npop2List.Remove(np2);
                Controls.Remove(np2);
            }
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

            Random location = new Random();
            int l = location.Next(1, 6);
            switch (l)
            {
                case 1:
                    p.Location = new Point(100, -600);
                    np1.Location = new Point(600, -600);
                    np2.Location = new Point(1100, -600);
                    break;
                case 2:
                    p.Location = new Point(100, -600);
                    np2.Location = new Point(600, -600);
                    np1.Location = new Point(1100, -600);
                    break;
                case 3:
                    np1.Location = new Point(100, -600);
                    np2.Location = new Point(600, -600);
                    p.Location = new Point(1100, -600);
                    break;
                case 4:
                    np1.Location = new Point(100, -600);
                    p.Location = new Point(600, -600);
                    np2.Location = new Point(1100, -600);
                    break;
                case 5:
                    np2.Location = new Point(100, -600);
                    p.Location = new Point(600, -600);
                    np1.Location = new Point(1100, -600);
                    break;
                case 6:
                    np2.Location = new Point(100, -600);
                    np1.Location = new Point(600, -600);
                    p.Location = new Point(1100, -600);
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



        private void ans_Tick(object sender, EventArgs e)
        {

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
            else if (ticks == 12)
            {
                timer3.Start();
                timer2.Start();
                ticks = ticks - 10;
            }
            ticks++;

        }



    }


}