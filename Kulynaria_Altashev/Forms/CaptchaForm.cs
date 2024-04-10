using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulynaria_Altashev.Forms
{
    public partial class CaptchaForm : Form
    {
        private string captchaText;
        Random random = new Random();
        string[] ar = { "captcha123", "practise", "lose", "win" };
        int check = 0;
        public CaptchaForm()
        {
            InitializeComponent();
        }
        private void ShowCaptcha()
        {
          
            Bitmap captchaImage = GenerateCaptchaImage(captchaText);
            pictureBox1.Image = captchaImage;
        }

        private Bitmap GenerateCaptchaImage(string captchaText)
        {
            
            Bitmap image = new Bitmap(200, 50);
            Pen redPen = new Pen(Color.Red, 3);
            Graphics g = Graphics.FromImage(image);
            Brush textBrush = new SolidBrush(Color.Black);
            g.DrawString(captchaText, new Font("Arial", 12), textBrush, new PointF(10, 10));

            int coord1 = random.Next(0, 100);
            int coord4 = random.Next(0, 100);
            int coord2 = random.Next(0, 100);
            int coord3 = random.Next(0, 100);
            Brush textBrus = new SolidBrush(Color.Black);
         

          
            Rectangle rect = new Rectangle(0, 0, coord2, coord3);
            Rectangle rect2 = new Rectangle(0, 0, coord1, coord4);
        
            float startAngle = -45.0F;
            float sweepAngle = 45.0F;

            
            g.DrawPie(redPen, rect, startAngle, sweepAngle);
            g.DrawPie(redPen, rect2, startAngle, sweepAngle);
            return image;
        }

        private void CaptchaForm_Load(object sender, EventArgs e)
        {
            int index = random.Next(0, ar.Length);
            captchaText = ar[index];
            ShowCaptcha();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int index = random.Next(0, ar.Length);
            captchaText = ar[index];
            ShowCaptcha();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tb_vvod.Text == captchaText)
            {
                MessageBox.Show("Капча введена правильно");
                check = 1;
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Капча введена неправильно");
            }
        }

        private void CaptchaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check == 0)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
