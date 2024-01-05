using Matematyczny_Wąż.Properties;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;

namespace Matematyczny_Wąż
{
    public partial class Form1 : Form
    {
        StartScreen startScreen = new StartScreen();
        Startbtn startbtn = new Startbtn();
        Reset reset = new Reset();
        wygrana wyg = new wygrana();
        Przegrana przegrana = new Przegrana();
        Stone s = new Stone();
        krokodyl krokodyl = new krokodyl();
        kloda k = new kloda();
        poz1 poz1 = new poz1();
        poz2 poz2 = new poz2();
        poz3 poz3 = new poz3();
        koniec koniec = new koniec();
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
        int liczydlo = 0;
        int poziom3 = 0;
        int wygrana = 0;
        int rem = 0;
        int liczprzeg = 0;
        bool czypauza = false;
        public Form1()
        {
            InitializeComponent();

            gracz.Location = new Point(600, 700);
            resume.Location = new Point(540, 400);
            startbtn.Location = new Point(540, 400);
            returntomenu.Location = new Point(490, 200);
            reset.Location = new Point(540, 600);
            r.Location = new Point(600, 10);
            Controls.Add(r);
            Controls.Add(gracz);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            poziomy.Start();

            poz1List.Add(poz1);
            Controls.Add(poz1);
            poz1.Visible = true;

            stopgenkrok.Stop();

            stopgenkloda.Stop();
            stopgenkrok.Stop();
            timer3.Stop();
            timer2.Stop();
            timer3.Interval = 2500;
            timer2.Interval = 3000;
            tmrrownania.Stop();
            krokodylgen.Stop();
            stopgencount.Stop();
            kloda_timer.Stop();

            np1.Visible = false;
            np2.Visible = false;
            p.Visible = false;
            r.Visible = false;
            Score.Visible = false;

            timer1.Start();

            gracz.Visible = true;
            punkty = 0;



            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


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
                pictureBox1.Visible = true;

                pictureBox2.Visible = true;


                timer1.Stop();
                kloda_timer.Stop();
                poziomy.Stop();
                stopgenkrok.Stop();
                stopgenkloda.Stop();
                krokodylgen.Stop();

                timer5.Stop();
                timer4.Stop();
                timer3.Stop();
                timer2.Stop();
                kloda_timer.Stop();
                tmrrownania.Stop();
                look.Stop();
                stopgencount.Stop();
                gracz.Visible = false;
                np1.Visible = false;
                np2.Visible = false;
                p.Visible = false;
                r.Visible = false;
                Score.Visible = false;

                poz1.Visible = false;
                poz2.Visible = false;
                poz3.Visible = false;

                foreach (Stone s in StoneList)
                {

                    s.Visible = false;

                }

                foreach (kloda k in klodaList)
                {

                    k.Visible = false;

                }

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
        public static List<poz1> poz1List = new List<poz1>();
        public static List<poz2> poz2List = new List<poz2>();
        public static List<poz3> poz3List = new List<poz3>();
        public static List<Stone> StoneList = new List<Stone>();
        public static List<kloda> klodaList = new List<kloda>();
        public static List<krokodyl> krokodylList = new List<krokodyl>();
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
        private void kloda_timer_Tick(object sender, EventArgs e)
        {
            kloda k = new kloda();
            klodaList.Add(k);
            Random randomY = new Random();

            int rY = -250;
            Random randomX = new Random();
            int rx = randomX.Next(0, 1024);
            this.Controls.Add(k);

            k.Location = new Point(rx, rY);

        }

        private void Update(object sender, EventArgs e)
        {
            label1.Text = $"{ticks}";
            try
            {
                foreach (Stone s in StoneList)
                {

                    if (gracz.Bounds.IntersectsWith(s.Bounds))
                    {
                        StoneList.Remove(s);
                        Controls.Remove(s);
                        punkty = punkty - 1;
                        liczydlo = liczydlo - 1;
                        poziom3 = poziom3 - 1;
                        wygrana = wygrana - 1;
                        liczprzeg = liczprzeg - 1;

                        rem = rem - 1;
                        Score.Text = $"Score: {punkty}";
                        break;
                    }

                }
            }
            catch { }
            try
            {
                foreach (kloda k in klodaList)
                {

                    if (gracz.Bounds.IntersectsWith(k.Bounds))
                    {
                        klodaList.Remove(k);
                        Controls.Remove(k);
                        punkty = punkty - 10;
                        liczydlo = liczydlo - 10;
                        poziom3 = poziom3 - 10;
                        wygrana = wygrana - 10;

                        rem = rem - 10;

                        liczprzeg = liczprzeg - 10;
                        Score.Text = $"Score: {punkty}";
                        break;
                    }

                }
            }
            catch { }

            try
            {
                foreach (krokodyl krokodyl in krokodylList)
                {

                    if (gracz.Bounds.IntersectsWith(krokodyl.Bounds))
                    {
                        krokodylList.Remove(krokodyl);
                        Controls.Remove(krokodyl);
                        punkty = punkty - 100;
                        liczydlo = liczydlo - 100;
                        rem = rem - 100;
                        poziom3 = poziom3 - 100;
                        wygrana = wygrana - 100;

                        liczprzeg = liczprzeg - 100;
                        Score.Text = $"Score: {punkty}";

                        przegrana.Show();
                        this.Close();
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
                        npop1List.Remove(np1);
                        Controls.Remove(np1);
                        npop2List.Remove(np2);
                        Controls.Remove(np2);
                        punkty = punkty + 100;
                        liczydlo = liczydlo + 100;
                        rem = rem + 100;
                        poziom3 = poziom3 + 100;
                        wygrana = wygrana + 100;

                        liczprzeg = liczprzeg + 100;
                        Score.Text = $"Score: {punkty}";
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
                        popList.Remove(p);
                        Controls.Remove(p);
                        npop1List.Remove(np1);
                        Controls.Remove(np1);
                        npop2List.Remove(np2);
                        Controls.Remove(np2);
                        punkty = punkty - 100;
                        liczydlo = liczydlo - 100;
                        poziom3 = poziom3 - 100;
                        wygrana = wygrana - 100;
                        liczprzeg = liczprzeg - 100;
                        rem = rem - 100;
                        Score.Text = $"Score: {punkty}";
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
                        popList.Remove(p);
                        Controls.Remove(p);
                        npop1List.Remove(np1);
                        Controls.Remove(np1);
                        npop2List.Remove(np2);
                        Controls.Remove(np2);
                        punkty = punkty - 100;
                        liczydlo = liczydlo - 100;
                        poziom3 = poziom3 - 100;
                        wygrana = wygrana - 100;

                        liczprzeg = liczprzeg - 100;
                        rem = rem - 100;
                        Score.Text = $"Score: {punkty}";
                        break;
                    }

                }
            }
            catch { }

            try
            {
                foreach (poz1 poz1 in poz1List)
                {
                    if (gracz.Bounds.IntersectsWith(poz1.Bounds))
                    {
                        ticks = 0;
                        Controls.Remove(poz1);
                        gracz.Visible = true;
                        np1.Visible = true;
                        np2.Visible = true;
                        p.Visible = true;
                        r.Visible = true;
                        Score.Visible = true;

                        timer3.Interval = 2500;
                        timer2.Interval = 3000;
                        stopgencount.Interval = 1000;
                        punkty = 0;
                        timer5.Start();
                        timer4.Start();
                        timer3.Start();
                        timer2.Start();
                        stopgencount.Start();
                        liczprzeg = 0;
                        tmrrownania.Start();
                        look.Start();
                        Score.Text = $"Score: {punkty}";
                        break;


                    }


                }
            }
            catch { }
            try
            {
                foreach (poz2 poz2 in poz2List)
                {
                    if (gracz.Bounds.IntersectsWith(poz2.Bounds))
                    {
                        punkty = 0;
                        Score.Text = $"Score: {punkty}";
                        rem = 0;
                        Controls.Remove(poz2);
                        gracz.Visible = true;
                        np1.Visible = true;
                        np2.Visible = true;
                        p.Visible = true;
                        r.Visible = true;
                        Score.Visible = true;
                        ticks = 0;

                        timer3.Start();
                        timer2.Start();

                        kloda_timer.Start();



                        stopgencount.Start();
                        stopgenkloda.Start();

                        timer4.Start();

                        timer3.Interval = 2000;
                        timer2.Interval = 3500;
                        stopgencount.Interval = 1000;

                        tmrrownania.Interval = 10000;
                        tmrrownania.Start();

                        look.Start();

                        liczydlo = -100000;
                        liczprzeg = 0;
                        Score.Visible = true;
                        break;
                    }
                }
            }
            catch { }
            try
            {
                foreach (poz3 poz3 in poz3List)
                {
                    if (gracz.Bounds.IntersectsWith(poz3.Bounds))
                    {
                        punkty = 0;
                        Score.Text = $"Score: {punkty}";
                        rem = 0;
                        Controls.Remove(poz3);
                        gracz.Visible = true;
                        np1.Visible = true;
                        np2.Visible = true;
                        p.Visible = true;
                        r.Visible = true;
                        Score.Visible = true;
                        ticks = 0;

                        timer3.Start();
                        timer2.Start();

                        kloda_timer.Start();


                        krokodylgen.Start();
                        stopgencount.Start();
                        stopgenkrok.Start();
                        timer4.Start();

                        timer3.Interval = 3500;
                        timer2.Interval = 6000;
                        stopgencount.Interval = 1000;

                        tmrrownania.Interval = 10000;
                        tmrrownania.Start();

                        look.Start();


                        liczprzeg = 0;
                        poziom3 = -100000;
                        Score.Visible = true;
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
            foreach (kloda k in klodaList)
            {
                k.Location = new Point(k.Location.X, k.Location.Y + 3);
            }
            foreach (krokodyl krokodyl in krokodylList)
            {
                krokodyl.Location = new Point(krokodyl.Location.X, krokodyl.Location.Y + 3);
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
            Random falsz = new Random();
            int f1 = falsz.Next(1, 10);

            Random falsz2 = new Random();
            int f2 = falsz2.Next(1, 15);
            double odp;
            switch (z)
            {
                case 1:
                    r.Text = $"{z1} + {z2}";
                    odp = z1 + z2;
                    p.Text = $"{odp}";
                    rowList.Add(r);
                    Controls.Add(r);

                    np1.Text = $"{odp + f1}";
                    np2.Text = $"{odp - f2}";

                    break;
                case 2:
                    r.Text = $"{z1} - {z2}";
                    odp = z1 - z2;
                    p.Text = $"{odp}";
                    rowList.Add(r);
                    Controls.Add(r);
                    np1.Text = $"{odp + f1}";
                    np2.Text = $"{odp - f2}";
                    break;
                case 3:
                    r.Text = $"{z1} * {z2}";
                    odp = z1 * z2;
                    p.Text = $"{odp}";
                    rowList.Add(r);
                    Controls.Add(r);
                    np1.Text = $"{odp + f1}";
                    np2.Text = $"{odp - f2}";
                    break;
                case 4:
                    r.Text = $"{z1} / {z2}";
                    odp = z1 / z2;
                    p.Text = $"{odp}";
                    rowList.Add(r);
                    Controls.Add(r);
                    np1.Text = $"{odp + f1}";
                    np2.Text = $"{odp - f2}";
                    break;
            }


            r.BringToFront();

            Controls.Add(r);

            Random location = new Random();
            int l = location.Next(1, 7);
            switch (l)
            {
                case 1:
                    p.Location = new Point(20, -600);
                    np1.Location = new Point(440, -600);
                    np2.Location = new Point(860, -600);
                    break;
                case 2:
                    p.Location = new Point(20, -600);
                    np2.Location = new Point(440, -600);
                    np1.Location = new Point(860, -600);
                    break;
                case 3:
                    np1.Location = new Point(20, -600);
                    np2.Location = new Point(440, -600);
                    p.Location = new Point(860, -600);
                    break;
                case 4:
                    np1.Location = new Point(20, -600);
                    p.Location = new Point(440, -600);
                    np2.Location = new Point(860, -600);
                    break;
                case 5:
                    np2.Location = new Point(20, -600);
                    p.Location = new Point(440, -600);
                    np1.Location = new Point(860, -600);
                    break;
                case 6:
                    np2.Location = new Point(20, -600);
                    np1.Location = new Point(440, -600);
                    p.Location = new Point(860, -600);
                    break;
            }

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
            if (punkty <= 99)
            {
                gracz.Image = Resources.w6;
                gracz.Size = new Size(86, 123);
            }
            else if (punkty <= 199)
            {
                gracz.Image = Resources.w5;
                gracz.Size = new Size(86, 164);
            }
            else if (punkty <= 299)
            {
                gracz.Image = Resources.w4;
                gracz.Size = new Size(86, 185);
            }
            else if (punkty <= 399)
            {
                gracz.Image = Resources.w3;
                gracz.Size = new Size(86, 219);
            }
            else if (punkty <= 499)
            {
                gracz.Image = Resources.w2;
                gracz.Size = new Size(86, 251);
            }
            else
            {
                gracz.Image = Resources.w1;
                gracz.Size = new Size(86, 280);
            }

        }

        int ticks = 0;
        public void stopgencount_Tick(object sender, EventArgs e)
        {


            if (ticks == 9)
            {
                timer3.Stop();
                timer2.Stop();

            }
            else if (ticks == 11)
            {
                timer3.Start();
                timer2.Start();


                ticks = ticks - 10;
            }

            ticks++;

        }

        void returnto(Object sender, EventArgs e)

        {
            StartScreen start = new StartScreen();
            start.Show();
            this.Close();

        }
        public void poziomy_Tick(object sender, EventArgs e)
        {

            if (liczprzeg <= -100)
            {
                przegrana.Show();
                this.Close();
            }

            if (rem >= 500)
            {
                foreach (Stone s in StoneList)
                {
                    StoneList.Remove(s);
                    Controls.Remove(s);
                    s.Visible = false;
                    break;
                }

                foreach (poprawne p in popList)
                {
                    popList.Remove(p);
                    Controls.Remove(p);
                    break;
                }


                foreach (niepoprawne1 np1 in npop1List)
                {

                    npop1List.Remove(np1);
                    Controls.Remove(np1);
                    break;
                }

                foreach (niepoprawne2 np2 in npop2List)
                {
                    npop2List.Remove(np2);
                    Controls.Remove(np2);
                    break;
                }
                foreach (kloda k in klodaList)
                {
                    klodaList.Remove(k);
                    Controls.Remove(k);
                    k.Visible = false;
                    break;
                }
                foreach (krokodyl krokodyl in krokodylList)
                {
                    krokodylList.Remove(krokodyl);
                    Controls.Remove(krokodyl);
                    krokodyl.Visible = false;
                    break;
                }
            }
            if (liczydlo >= 500)
            {

                liczydlo = 0;

                poz2List.Add(poz2);
                Controls.Add(poz2);
                poz2.Visible = true;

                ruchpoz.Start();

                Score.Visible = false;
                Controls.Remove(r);

                Score.Text = $"Score: {punkty}";

                timer3.Stop();
                kloda_timer.Stop();
                timer2.Stop();
                tmrrownania.Stop();
                look.Stop();



            }
            if (poziom3 >= 1000)
            {

                poz3List.Add(poz3);
                Controls.Add(poz3);
                poz3.Visible = true;

                poziom3 = 0;
                stopgenkrok.Start();


                Score.Visible = false;
                Controls.Remove(r);

                Score.Text = $"Score: {punkty}";

                timer3.Stop();
                kloda_timer.Stop();
                timer2.Stop();
                tmrrownania.Stop();
                look.Stop();

            }
            if (wygrana >= 1500)
            {

                wyg.Show();
                this.Close();

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (poz1 p in poz1List)
            {
                p.Location = new Point(p.Location.X, p.Location.Y + 3);
            }
            foreach (poz2 p in poz2List)
            {
                p.Location = new Point(p.Location.X, p.Location.Y + 3);
            }
            foreach (poz3 p in poz3List)
            {
                p.Location = new Point(p.Location.X, p.Location.Y + 3);
            }
        }
        int tick = 0;
        private void stopgenkloda_Tick(object sender, EventArgs e)
        {
            if (tick == 8)
            {
                kloda_timer.Stop();

            }
            else if (tick == 10)
            {
                kloda_timer.Start();


                tick = tick - 10;
            }

            tick++;
        }
        int tiki = 0;
        private void krokodylgen_Tick(object sender, EventArgs e)
        {
            krokodyl krokodyl = new krokodyl();
            krokodylList.Add(krokodyl);
            Random randomY = new Random();

            int rY = -325;
            Random randomX = new Random();
            int rx = randomX.Next(0, 1024);
            this.Controls.Add(krokodyl);

            krokodyl.Location = new Point(rx, rY);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (tiki == 8)
            {
                krokodylgen.Stop();

            }
            else if (tick == 10)
            {
                krokodylgen.Start();


                tiki = tiki - 10;
            }

            tiki++;
        }

        private void ruchpoz_Tick(object sender, EventArgs e)
        {

        }

        private void pauza_Tick(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Resett reset = new Resett();
            reset.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StartScreen start = new StartScreen();
            start.Show();
            this.Close();
        }

    }


}