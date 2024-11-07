using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_V2
{
    public partial class Captcha : Form
    {
        private string text = String.Empty;
        internal bool CaptchaCompleted = false;
        public Captcha()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 25);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.LightGray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 4; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            for (int i = 0; i < 4; i++)
            {
                g.DrawString(text[i].ToString(),
                          new Font("Arial", 15),
                          colors[rnd.Next(colors.Length)],
                          new PointF(Xpos + i * 10, Ypos + rnd.Next(-5, 5)));

            }
            //Добавим немного помех
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == text)
            {
                CaptchaCompleted = true;
                Close();
            }
            else
            {
                CaptchaCompleted = false;
                MessageBox.Show("Неверно, попробуйте ещё раз.", "Проверка не пройдена" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
