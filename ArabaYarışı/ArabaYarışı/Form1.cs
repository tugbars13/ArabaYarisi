using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
                // Kırmızı araba konumu
                int x1 = pictureBox1.Location.X;
                int y1 = pictureBox1.Location.Y;

                // Sarı araba konumu
                int x2 = pictureBox2.Location.X;
                int y2 = pictureBox2.Location.Y;

                // Kırmızı araba W tuşuyla hareket eder
                if (e.KeyCode == Keys.W) y1 -= 5;

                // Sarı araba Yukarı ok tuşuyla hareket eder
                if (e.KeyCode == Keys.Up) y2 -= 5;

                // Yeni konumları güncelle
                pictureBox1.Location = new Point(x1, y1);
                pictureBox2.Location = new Point(x2, y2);

            pictureBox1.BringToFront();
            pictureBox2.BringToFront();

            // Kazanma kontrolü
            if (y1 < 50)
                {
                    MessageBox.Show("Tebrikler kırmızı araba kazandı!");
                    ResetGame();
                }
                if (y2 < 50)
                {
                    MessageBox.Show("Tebrikler sarı araba kazandı!");
                    ResetGame();
                }
            }

            // Oyunu başa döndüren bir metod
            private void ResetGame()
            {
                pictureBox1.Location = new Point(42, 500);
                pictureBox2.Location = new Point(200, 500);
            }

        }
    }

