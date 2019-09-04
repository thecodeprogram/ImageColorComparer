using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace RenkKarsilastir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Please select an image";
        }

        string filePath;
        int firstSize = 0;
        int secondSize = 0;

        public void resimkarsilastir()
        {
            StreamReader first_read = File.OpenText(filePath + "\\first_image.txt");
            StreamReader second_read = File.OpenText(filePath + "\\second_image.txt");

            StreamWriter same_write = File.AppendText(filePath + "\\same_codes.txt");
            StreamWriter firstDiff = File.AppendText(filePath + "\\differences_of_first.txt");
            StreamWriter secondDiff = File.AppendText(filePath + "\\differences_os_seconds.txt");

            string m1;
            string m2;

            try
            {
                m1 = first_read.ReadLine();
                m2 = second_read.ReadLine();

                int same_codes = 0;
                int first_codes = 0;
                int second_codes = 0;

                for (int i = 0; i < Math.Max(firstSize, secondSize); i++)
                {
                    if (m1 == m2)
                    {
                        same_write.WriteLine(m1);
                        same_codes++;
                    }
                    else if (m1 != m2)
                    {
                        firstDiff.WriteLine(m1);
                        first_codes++;
                        secondDiff.WriteLine(m2);
                        second_codes++;
                    }
                    m1 = first_read.ReadLine();
                    m2 = second_read.ReadLine();

                }
                for (int i = 0; i < 5; i++)
                {
                    same_write.WriteLine();
                    firstDiff.WriteLine();
                    secondDiff.WriteLine();
                }
                same_write.WriteLine();
                firstDiff.WriteLine();
                secondDiff.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    same_write.WriteLine();
                    firstDiff.WriteLine();
                    secondDiff.WriteLine();
                }

                firstDiff.WriteLine();

                StreamWriter reporting = File.AppendText(filePath + "\\sonuc.txt");
                reporting.WriteLine("DOSYA KARŞILAŞTIRMA RAPORU");
                reporting.WriteLine();
                reporting.WriteLine((same_codes - 100).ToString() + " SAME CODE..");
                reporting.WriteLine();
                reporting.WriteLine("IN FIRST FILE " + (first_codes - 100).ToString() + " DIFFERENT CODE...");
                reporting.WriteLine();
                reporting.WriteLine("IN SECOND FILE " + (second_codes - 100).ToString() + " DIFFERENT CODE...");
                reporting.WriteLine();
                reporting.WriteLine("IN FIRST FILE " + (firstSize).ToString() + " COLOR CODES...");
                reporting.WriteLine();
                reporting.WriteLine("IN SECOND FILE " + (secondSize).ToString() + " COLOR CODES...");
                reporting.WriteLine();
                reporting.WriteLine("AS A RESULT FROM THESE VALUES THE DIFFERENCES : %" + Convert.ToString((100 * first_codes) / firstSize));
                reporting.Close();


                same_write.Close();
                first_read.Close();
                second_read.Close();

            }
            catch (Exception errr) { MessageBox.Show("An error occuered :  " + errr.ToString()); }
            finally { }

        }
        public void get_image2()
        {
            if (r1.Image != null && r2.Image != null)
            {

                Bitmap my_image = new System.Drawing.Bitmap(r2.Image);
                Color my_color;
                int i, j;
                secondSize = my_image.Height * my_image.Width + 100;
                progressBar1.Maximum = my_image.Width * my_image.Height;
                StreamWriter wrtr = File.AppendText(filePath + "\\second_image.txt");
                for (i = 0; i <= my_image.Width - 1; i++)
                {
                    for (j = 0; j <= my_image.Height - 1; j++)
                    {
                        my_color = my_image.GetPixel(i, j);

                        wrtr.WriteLine("(" + j.ToString() + "," + i.ToString() + ")" + " - " + my_color.ToString());

                        if ((i % 1) == 0)
                        {
                            progressBar1.Value = i * my_image.Height + j;
                        }

                    }
                }
                wrtr.Close();
                r1.Image = my_image;
            }
            else
            {
                MessageBox.Show("Select An Image");
            }
        }

        public void get_image1()
        {
            
            if (r1.Image != null && r2.Image!= null)
            {
                Bitmap my_image = new System.Drawing.Bitmap(r1.Image);
                Color my_color;
                int i, j;
                firstSize = my_image.Height * my_image.Width;
                progressBar1.Maximum = my_image.Width * my_image.Height + 100;
                StreamWriter wrtr= File.AppendText(filePath + "\\first_image.txt");
                for (i = 0; i <= my_image.Width - 1; i++)
                {
                    for (j = 0; j <= my_image.Height - 1; j++)
                    {
                        my_color = my_image.GetPixel(i, j);

                        wrtr.WriteLine("(" + j.ToString() + "," + i.ToString() + ")" + " - " + my_color.ToString());

                        if ((i % 1) == 0)
                        {
                            progressBar1.Value = i * my_image.Height + j;
                        }

                    }
                }
                wrtr.Close();
                r1.Image = my_image;
            }
            else
            {
               MessageBox.Show("Select An Image");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (k.ShowDialog() == DialogResult.OK)
            {
                filePath = k.SelectedPath.ToString();
                label2.Text = "First image encoding...";
                get_image1();
                label2.Text = "Second image encoding...";
                get_image2();
                label2.Text = "Comparing...";
                resimkarsilastir();
                MessageBox.Show("Completed", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void r1_Click(object sender, EventArgs e)
        {
            f1.FileName = "";
            f1.Title = "Please select an image";
            f1.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.bmp)|*.bmp";
            f1.Multiselect = false;
            if (f1.ShowDialog() == DialogResult.OK)
            {
                r1.ImageLocation = f1.FileName.ToString();
            }
        }

        private void r2_Click(object sender, EventArgs e)
        {
            f2.FileName = "";
            f2.Title = "Please select an image";
            f1.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.bmp)|*.bmp";
            f2.Multiselect = false;
            if (f2.ShowDialog() == DialogResult.OK)
            {
                r2.ImageLocation = f2.FileName.ToString();
            }
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
