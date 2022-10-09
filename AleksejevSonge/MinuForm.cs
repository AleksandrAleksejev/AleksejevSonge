using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AleksejevSonge
{
    public class MinuForm : Form1
    {

        public MinuForm() { }

        public MinuForm(string Pealkiri)
        {
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Text = Pealkiri;
            Button nupp = new Button
            {
                Text = String.Format("Vajuta"),
                Location = new System.Drawing.Point(150, 0),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp.Click += Nupp_Click;

            Button nupp1 = new Button
            {
                Text = String.Format("Vajuta"),
                Location = new System.Drawing.Point(150, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp1.Click += Nupp_Click1;
            Button nupp2 = new Button
            {
                Text = String.Format("Vajuta"),
                Location = new System.Drawing.Point(150, 100),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp2.Click += Nupp_Click2;

            Label failisnimi = new Label
            {
                Text = String.Format("BoyWithUke-Long Drive"),
                Location = new System.Drawing.Point(250, 10),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            Label failisnimi1 = new Label
            {
                Text = String.Format("kaito shoma-scary garry_"),
                Location = new System.Drawing.Point(250, 60),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            Label failisnimi2 = new Label
            {
                Text = String.Format("plenka-when you find me "),
                Location = new System.Drawing.Point(250, 110),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            Label praegune = new Label
            {
                Text = String.Format(" "),
                Location = new System.Drawing.Point(450, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            this.Controls.Add(nupp);
            this.Controls.Add(failisnimi);
            this.Controls.Add(nupp1);
            this.Controls.Add(failisnimi1);
            this.Controls.Add(nupp2);
            this.Controls.Add(failisnimi2);
            this.Controls.Add(praegune);
        }



        private void Nupp_Click(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\boy.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("BoyWithUke");
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
            this.Controls.Add(nupp_sender);
        }
        private void Nupp_Click1(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\kaito.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Kaito Shoma");

                }
            }
            else
            {
                MessageBox.Show(":(");
            }
            this.Controls.Add(nupp_sender);
        }
        private void Nupp_Click2(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\plenka.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Plenka");
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
            this.Controls.Add(nupp_sender);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MinuForm
            // 
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Name = "MinuForm";
            this.Load += new System.EventHandler(this.MinuVorm_Load);
            this.ResumeLayout(false);

        }

        private void MinuVorm_Load(object sender, EventArgs e)
        {

        }
    }
}
