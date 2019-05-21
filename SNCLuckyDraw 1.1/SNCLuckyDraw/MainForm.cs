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
    public partial class changeimages1 : Form
    {
        ArrayList images;
        int pressCount = 0;
        ArrayList imagePaths;
        Image selectedImage;
        bool isFirstTime = true;
        public changeimages1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }
        
        private void BtnStart_Click(object sender, EventArgs e)
        {
            int imageIndex = 0;
            if (!timer1.Enabled)
            {
                if (isFirstTime) {
                    
                    isFirstTime = false;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Có mặt ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No) {

                    }
                    else
                    {
                        pressCount++;
                        switch (pressCount)
                        {
                            case 1:
                                firstPrisePictureBox.Image = selectedImage;
                                break;
                            case 2:
                                secondPrisePictureBox.Image = selectedImage;
                                break;
                            case 3:
                                thirdPrisePictureBox.Image = selectedImage;
                                break;
                            default:
                                break;
                        }
                    }
                }
                timer1.Start();
            } 
            else
            {
                timer1.Stop();
                
                for (int i = 0; i < images.Count; i++)
                {
                    if (selectedImage == (Image)images[i])
                    {
                        MessageBox.Show((String)imagePaths[i]);
                        imageIndex = i;
                    }
                }

                images.RemoveAt(imageIndex);
                imagePaths.RemoveAt(imageIndex);
                MessageBox.Show(imagePaths.Count.ToString());
            }  
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();

            selectedImage = (Image)images[rd.Next(images.Count)];
            mainPictureBox.Image = selectedImage;
        }

        private void BackgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            images = new ArrayList();
            imagePaths = new ArrayList();
            int count = 0;
            string[] images_path = Directory.GetFiles(@"D:\images", "*.JPG");
            foreach (string file in images_path)
            {
                Image img = Image.FromFile(file);
                images.Add(img);
                imagePaths.Add(file);
                count++;
                backgroundWorker1.ReportProgress((int)((float)count / images_path.Length) * 100);
            }
        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
                Image myimage = new Bitmap(@"C:\Users\nguyen anh duc\Pictures\Saved Pictures");
                this.BackgroundImage = myimage;
            
        }
    }
}
