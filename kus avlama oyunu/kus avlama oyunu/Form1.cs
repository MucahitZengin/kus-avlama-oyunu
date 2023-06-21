using System;
using System.Windows.Forms;

namespace kus_avlama_oyunu
{
    public partial class Form1 : Form
    {
        private PictureBox[] leftBirds;
        private PictureBox[] rightBirds;
        private Random rnd;
        private int score;

        public Form1()
        {
            InitializeComponent();

            rnd = new Random();
            score = 0;
            leftBirds = new PictureBox[] { leftBird1, leftBird2, leftBird3 };
            rightBirds = new PictureBox[] { rightBird1, rightBird2, rightBird3 };

            rightBird1.Visible = false;
            rightBird2.Visible = false;
            rightBird3.Visible = false;
            leftBird1.Visible = false;
            leftBird2.Visible = false;
            leftBird3.Visible = false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            InitializeBirdLocation();
            timer1.Start();
        }

        private void InitializeBirdLocation() 
        {
            foreach (PictureBox bird in leftBirds) //sol kuþlar ekranýn solunda baþlýyor
            {
                bird.Location = new Point(rnd.Next(-300, -50), rnd.Next(0, 350));
                bird.Visible = true;
            }

            foreach (PictureBox bird in rightBirds) //sað kuþlar ekranýn saðýnda baþlýyor
            {
                bird.Location = new Point(rnd.Next(ClientSize.Width, ClientSize.Width + 300), rnd.Next(0, 350));
                bird.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateBirdLocation();
        }

        private void UpdateBirdLocation()
        {
            foreach (PictureBox bird in leftBirds)
            {
                if (bird.Location.X > ClientSize.Width) //kuþ ekrandan çýktýysa bi daha baþlýyor
                {
                    bird.Location = new Point(rnd.Next(-300, -bird.Width), rnd.Next(0, ClientSize.Height - bird.Height));
                }
                else //aksi takdirde 10 piksel ilerliyor
                {
                    bird.Location = new Point(bird.Location.X + 10, bird.Location.Y);
                }
            }

            foreach (PictureBox bird in rightBirds)
            {
                if (bird.Location.X + bird.Width < 0) //kuþ ekrandan çýktýysa bi daha baþlýyor
                {
                    bird.Location = new Point(rnd.Next(ClientSize.Width, ClientSize.Width + 300), rnd.Next(0, ClientSize.Height - bird.Height));
                }
                else //aksi takdirde 10 piksel ilerliyor
                {
                    bird.Location = new Point(bird.Location.X - 10, bird.Location.Y);
                }
            }

            lblScore.Text = "Score: " + score.ToString();
        }

        private void LeftBirdClick(object sender, EventArgs e)
        {
            //kuþun üszerine týklandýðýnda kuþ kayboluyor ve skor artýyor 
            PictureBox bird = (PictureBox)sender;
            bird.Visible = false;
            score++;

            //sonra tekrar konum alýyor
            bird.Location = new Point(rnd.Next(-300, -bird.Width), rnd.Next(0, 350));
            bird.Visible = true;
        }

        private void RightBirdClick(object sender, EventArgs e)
        {
            //kuþun üszerine týklandýðýnda kuþ kayboluyor ve skor artýyor 
            PictureBox bird = (PictureBox)sender;
            bird.Visible = false;
            score++;

            //sonra tekrar konum alýyor
            bird.Location = new Point(rnd.Next(ClientSize.Width, ClientSize.Width + 300), rnd.Next(0, 350));
            bird.Visible = true;
        }
    }
}
