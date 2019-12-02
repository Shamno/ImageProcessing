using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textBox1.Text))
            {
                Bitmap bitmap = new Bitmap(textBox1.Text);
                pictureBox1.Image = bitmap;
                button2.Enabled = true;

                openFileDialog1.Dispose();
            }
            else
            {
                MessageBox.Show("ファイル名が違います");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

                Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
                Bitmap bitmap2 = new Bitmap(bitmap1.Width, bitmap1.Height);

                for (int y = 0; y < bitmap1.Height; y++)
                {
                    for (int x = 0; x < bitmap1.Width; x++)
                    {
                        Color c = bitmap1.GetPixel(x, y);
                        int r = c.R * trackBar1.Value / 100;
                        int g = c.G * trackBar2.Value / 100;
                        int b = c.B * trackBar3.Value / 100;
                        Color c2 = Color.FromArgb(r, g, b);
                        bitmap2.SetPixel(x, y, c2);
                    }
                }
                pictureBox2.Image = bitmap2;
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "R=" + trackBar1.Value+"%";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = "G=" + trackBar2.Value+ "%";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = "B=" + trackBar3.Value+ "%";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            Bitmap bitmap2 = new Bitmap(bitmap1.Width,bitmap1.Height);

            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color c = bitmap1.GetPixel(x, y);
                    int r = 255-c.R;
                    int g = 255 - c.G;
                    int b = 255 -c.B;
                    Color c2 = Color.FromArgb(r, g, b);
                    bitmap2.SetPixel(x, y, c2);
                }
            }
            pictureBox2.Image = bitmap2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            Bitmap bitmap2 = new Bitmap(bitmap1.Width, bitmap1.Height);

            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color c = bitmap1.GetPixel(x, y);
                    int r = c.R/128 * 255;
                    int g = c.G/128 * 255;
                    int b = c.B/128 * 255;
                    Color c2 = Color.FromArgb(r, g, b);
                    bitmap2.SetPixel(x, y, c2);
                }
            }
            pictureBox2.Image = bitmap2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            Bitmap bitmap2 = new Bitmap(bitmap1.Width, bitmap1.Height);

            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color c = bitmap1.GetPixel(x, y);
                    int r = c.R /86*127;
                    int g = c.G /86*127;
                    int b = c.B /86*127;
                    Color c2 = Color.FromArgb(r, g, b);
                    bitmap2.SetPixel(x, y, c2);
                }
            }
            pictureBox2.Image = bitmap2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            Bitmap bitmap2 = new Bitmap(bitmap1.Width, bitmap1.Height);

            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color c = bitmap1.GetPixel(x, y);
                    int r = c.R / 32 * 36;
                    int g = c.G / 32 * 36;
                    int b = c.B / 64 * 85;
                    Color c2 = Color.FromArgb(r, g, b);
                    bitmap2.SetPixel(x, y, c2);
                }
            }
            pictureBox2.Image = bitmap2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            Bitmap bitmap2 = new Bitmap(bitmap1.Width, bitmap1.Height);


            if (trackBar4.Value == 0)
            {
                label5.Text = "数値0のままの実行は出来ません";
            }


            else
            {

                for (int y=0;y<bitmap1.Height;y=y+ trackBar4.Value)
                {
                    for(int x=0;x<bitmap1.Width;x=x+ trackBar4.Value)
                    {
                        int r = 0, g = 0, b = 0, cnt = 0;
                        for(int i = 0; i < trackBar4.Value && x + i < bitmap1.Width; i++)
                        {
                            for(int j = 0; j < trackBar4.Value && y + j < bitmap1.Height; j++)
                            {
                                Color c = bitmap1.GetPixel(x + i, y + j);
                                r = r + c.R;
                                g = g + c.G;
                                b = b + c.B;
                                cnt++;
                            }
                        }

                        Color c2 = Color.FromArgb(r / cnt, g / cnt, b/ cnt);

                            for (int i = 0; i < trackBar4.Value && x + i < bitmap1.Width; i++)
                            {
                                for (int j = 0; j < trackBar4.Value && y + j < bitmap1.Height; j++)
                                {
                                    bitmap2.SetPixel(x + i, y + j, c2);
                                }
                            }
                    }

                }
            }
            pictureBox2.Image = bitmap2;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar4.Value+"px";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bitmap2 = (Bitmap)pictureBox2.Image;

            if(System.IO.File.Exists(textBox1.Text))
            {
                if(MessageBox.Show(textBox1.Text+"を上書きしますか？","上書き確認",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    bitmap2.Save(textBox1.Text, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            else
            {
                if(pictureBox2.Image!=null)
                {
                    bitmap2.Save(textBox1.Text, System.Drawing.Imaging.ImageFormat.Jpeg);

                }
                else
                {
                    MessageBox.Show("保存できませんでした");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            Bitmap bitmap2 = new Bitmap(textBox1.Text);
            Bitmap bitmap3 = new Bitmap(bitmap1.Width, bitmap1.Height);

            for(int y=0;y<bitmap1.Height;y++)
            {
                for(int x=0;x<bitmap1.Width;x++)
                {
                    Color c1 = bitmap1.GetPixel(x, y);
                    Color c2 = bitmap2.GetPixel(x, y);
                    int r = (c1.R + c2.R) / 2;
                    int g = (c1.G + c2.G) / 2;
                    int b = (c1.B + c2.B) / 2;
                    bitmap3.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = bitmap3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            Bitmap bitmap2 = new Bitmap(textBox1.Text);
            Bitmap bitmap3 = new Bitmap(bitmap1.Width, bitmap1.Height);
            Color c = bitmap2.GetPixel(0, 0);
            for(int y=0;y<bitmap1.Height;y++)
            {
                for(int x=0;x<bitmap1.Width;x++)
                {
                    if (bitmap2.GetPixel(x,y)==c)
                    {
                        bitmap3.SetPixel(x, y, bitmap1.GetPixel(x, y));
                    }
                    else
                    {
                        bitmap3.SetPixel(x, y, bitmap2.GetPixel(x, y));
                    }
                }
            }
            pictureBox2.Image = bitmap3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            Bitmap bitmap2 = new Bitmap(textBox1.Text);
            Bitmap bitmap3 = new Bitmap(bitmap1.Width, bitmap1.Height);
            Bitmap bitmap4 = new Bitmap("mask.png");
            Color c = Color.FromArgb(255,255,255);
            Color d = Color.FromArgb(0,0,0);
            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    if (bitmap4.GetPixel(x, y) == c)
                    {
                        bitmap3.SetPixel(x, y, bitmap1.GetPixel(x, y));
                    }
                    else if (bitmap4.GetPixel(x, y) == d)
                    {
                        bitmap3.SetPixel(x, y, bitmap2.GetPixel(x, y));
                    }
                    else
                    {
                        bitmap3.SetPixel(x, y, bitmap4.GetPixel(x, y));
                    }
                }
            }

            pictureBox2.Image = bitmap3;
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "NewPic.jpg";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "jpgファイル(*.jpg;*.jpeg)|*.jpg;*.jpeg|pngファイル(*.png;)|*.png;|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text=(ofd.FileName);
                label5.Text = "読み込み成功　画像読み込みを押してください。";
            }
        }

        private void つくったひとToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作者：篠沢唯菜\n作開始日：2017年の夏くらい");
        }
    }

}
