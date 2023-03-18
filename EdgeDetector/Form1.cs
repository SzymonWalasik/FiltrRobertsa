using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using EdgeDetectorC;
using System.Diagnostics;
using System.IO;

namespace EdgeDetector
{
    public partial class Form1 : Form
    {
        private Image mainSourceImage = null;
        private Image mainResultImage = null;


        public Form1()
        {
            InitializeComponent();
            threadsTrackBar.Value = Environment.ProcessorCount;
            threadsTrackBar.Maximum = 64;
            threadsTrackBar.Minimum = 1;
            threadsTrackBar.ValueChanged += trackBar2_ValueChanged;
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadButtonClick(object sender, EventArgs e)
        {
            openSourceFileDialog.ShowDialog();
            string filePath = openSourceFileDialog.FileName;
            if (filePath != "")
            {
                mainSourceImage = Image.FromFile(filePath);
                sourcePictureBox.Image = resizeImage(mainSourceImage, new Size(320, 180));

            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void saveButtonClick(object sender, EventArgs e)
        {
            saveResultFileDialog.Filter = "Bitmap Image|*.bmp";
            saveResultFileDialog.Title = "Zapisz zdjêcie";
            saveResultFileDialog.ShowDialog();
            if (saveResultFileDialog.FileName != "")
            {
                string filePath = saveResultFileDialog.FileName;
                System.IO.FileStream fs = (System.IO.FileStream)saveResultFileDialog.OpenFile();
                mainResultImage.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                fs.Close();
            }
        }

        private void runButtonClick(object sender, EventArgs e)
        {   
            List<Thread> threads = new List<Thread>();
            List<Bitmap> bmps = new List<Bitmap>();

            int widthPerThread = mainSourceImage.Width / threadsTrackBar.Value;
            int widthRest = mainSourceImage.Width % threadsTrackBar.Value;

            int currentWidth = 0;
            for (int i = 0; i < threadsTrackBar.Value; i++)
            {
                if (widthRest != 0)
                {
                    bmps.Add(((Bitmap)mainSourceImage).Clone(new Rectangle(currentWidth, 0, widthPerThread + 2, mainSourceImage.Height), mainSourceImage.PixelFormat));
                    widthRest--;
                    currentWidth += widthPerThread + 1;
                }
                else
                {
                    if (mainSourceImage.Width < currentWidth + widthPerThread + 1)
                    {
                        bmps.Add(((Bitmap)mainSourceImage).Clone(new Rectangle(currentWidth, 0, widthPerThread, mainSourceImage.Height), mainSourceImage.PixelFormat));
                        currentWidth += widthPerThread;
                    }
                    else
                    {
                        bmps.Add(((Bitmap)mainSourceImage).Clone(new Rectangle(currentWidth, 0, widthPerThread + 1, mainSourceImage.Height), mainSourceImage.PixelFormat));
                        currentWidth += widthPerThread;
                    }
                }
            }

            if (mainSourceImage != null && csRadioButton.Checked)
            {

                int j = 0;
                for (int i = 0; i < threadsTrackBar.Value; i++)
                {
                    threads.Add(new Thread(() => Wrap.Run(bmps[j++], false)));
                }
 
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                foreach (Thread thread in threads)
                {
                    thread.Start();
                }

                threads[0].Join();
                bmps[0] = bmps[0].Clone(new Rectangle(0, 0, bmps[0].Width - 1, bmps[0].Height - 1), bmps[0].PixelFormat);
                for (int i = 1; i < threadsTrackBar.Value; i++)
                {
                    threads[i].Join();
                    bmps[i] = bmps[i].Clone(new Rectangle(0, 0, bmps[i].Width - 1, bmps[i].Height - 1), bmps[i].PixelFormat);
                    bmps[0] = MergeImages(bmps[0], bmps[i]);
                }
                stopwatch.Stop();
                mainResultImage = bmps[0];
                resultPictureBox.Image = resizeImage(mainResultImage, new Size(320, 180));
                String time = stopwatch.ElapsedMilliseconds.ToString();

                File.AppendAllText(@"C:\Users\LEGION\source\repos\Projekt_JA\EdgeDetector\Pomiary\mediumc64.txt", time + Environment.NewLine);


                    resultTimeLabel.Text = stopwatch.ElapsedMilliseconds.ToString() + "ms";
            
            }
            else if (mainSourceImage != null && asmRadioButton.Checked)
            {
                int j = 0;
                for (int i = 0; i < threadsTrackBar.Value; i++)
                {
                    threads.Add(new Thread(() => Wrap.Run(bmps[j++], true)));
                }

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                foreach (Thread thread in threads)
                {
                    thread.Start();
                }

                threads[0].Join();
                bmps[0] = bmps[0].Clone(new Rectangle(0, 0, bmps[0].Width - 1, bmps[0].Height - 1), bmps[0].PixelFormat);
                for (int i = 1; i < threadsTrackBar.Value; i++)
                {
                    threads[i].Join();
                    bmps[i] = bmps[i].Clone(new Rectangle(0, 0, bmps[i].Width - 1, bmps[i].Height - 1), bmps[i].PixelFormat);
                    bmps[0] = MergeImages(bmps[0], bmps[i]);
                }
            
                stopwatch.Stop();
                mainResultImage = bmps[0];
                resultPictureBox.Image = resizeImage(mainResultImage, new Size(320, 180));
 

                string time = stopwatch.ElapsedMilliseconds.ToString();

                File.AppendAllText(@"C:\Users\LEGION\source\repos\Projekt_JA\EdgeDetector\Pomiary\mediuma64.txt", time + Environment.NewLine);
                resultTimeLabel.Text = stopwatch.ElapsedMilliseconds.ToString() + "ms";
            }
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = threadsTrackBar.Value.ToString();
        }

        private Bitmap MergeImages(Image image1, Image image2)
        {
            Bitmap bitmap = new Bitmap(image1.Width + image2.Width, Math.Max(image1.Height, image2.Height));
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(image1, new Rectangle(new Point(), image1.Size), new Rectangle(new Point(), image1.Size), GraphicsUnit.Pixel);
                g.DrawImage(image2, new Rectangle(new Point(image1.Width, 0), image2.Size), new Rectangle(new Point(), image2.Size), GraphicsUnit.Pixel);
            }

            return bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}