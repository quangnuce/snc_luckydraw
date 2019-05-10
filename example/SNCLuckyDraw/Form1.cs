using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNCLuckyDraw
{
    public partial class Form1 : Form
    {
        ArrayList images;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
            lb_loading.Text = "loading...";
        }
        private void loadImages()
        {
            images = new ArrayList();
            int count = 0;
            string[] images_path= Directory.GetFiles(@"G:\Pictures\Wallpaper\wp", "*.JPEG");
            foreach (string file in images_path)
            {
                Image img = Image.FromFile(file);
                images.Add(img);
                count++;
                backgroundWorker1.ReportProgress((int)((float)count/images_path.Length)*100);
            }
           
        }
        
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Start();
            else
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pic_avatar.Image = (Image)images[rd.Next(images.Count)];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            loadImages();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bar_loadimage.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lb_loading.Text = "Done";
        }
    }
}
