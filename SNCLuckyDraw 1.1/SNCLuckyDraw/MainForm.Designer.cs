using System;

namespace SNCLuckyDraw
{
    partial class changeimages1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeimages1));
            this.btnStart = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.secondPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.lblSecondPrise = new System.Windows.Forms.Label();
            this.lblFirstPrise = new System.Windows.Forms.Label();
            this.firstPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.lblThirdPrise = new System.Windows.Forms.Label();
            this.thirdPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPrisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPrisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPrisePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStart.Location = new System.Drawing.Point(1037, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 106);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainPictureBox.Location = new System.Drawing.Point(1, 155);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1150, 538);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            // 
            // secondPrisePictureBox
            // 
            this.secondPrisePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondPrisePictureBox.Location = new System.Drawing.Point(174, 12);
            this.secondPrisePictureBox.Name = "secondPrisePictureBox";
            this.secondPrisePictureBox.Size = new System.Drawing.Size(187, 106);
            this.secondPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondPrisePictureBox.TabIndex = 2;
            this.secondPrisePictureBox.TabStop = false;
            // 
            // lblSecondPrise
            // 
            this.lblSecondPrise.AutoSize = true;
            this.lblSecondPrise.Location = new System.Drawing.Point(245, 135);
            this.lblSecondPrise.Name = "lblSecondPrise";
            this.lblSecondPrise.Size = new System.Drawing.Size(61, 17);
            this.lblSecondPrise.TabIndex = 3;
            this.lblSecondPrise.Text = "GIẢI NHÌ";
            // 
            // lblFirstPrise
            // 
            this.lblFirstPrise.AutoSize = true;
            this.lblFirstPrise.Location = new System.Drawing.Point(529, 135);
            this.lblFirstPrise.Name = "lblFirstPrise";
            this.lblFirstPrise.Size = new System.Drawing.Size(76, 17);
            this.lblFirstPrise.TabIndex = 5;
            this.lblFirstPrise.Text = "GIẢI NHẤT";
            // 
            // firstPrisePictureBox
            // 
            this.firstPrisePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstPrisePictureBox.Location = new System.Drawing.Point(462, 12);
            this.firstPrisePictureBox.Name = "firstPrisePictureBox";
            this.firstPrisePictureBox.Size = new System.Drawing.Size(187, 106);
            this.firstPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstPrisePictureBox.TabIndex = 4;
            this.firstPrisePictureBox.TabStop = false;
            // 
            // lblThirdPrise
            // 
            this.lblThirdPrise.AutoSize = true;
            this.lblThirdPrise.Location = new System.Drawing.Point(819, 135);
            this.lblThirdPrise.Name = "lblThirdPrise";
            this.lblThirdPrise.Size = new System.Drawing.Size(56, 17);
            this.lblThirdPrise.TabIndex = 7;
            this.lblThirdPrise.Text = "GIẢI BA";
            // 
            // thirdPrisePictureBox
            // 
            this.thirdPrisePictureBox.Location = new System.Drawing.Point(743, 12);
            this.thirdPrisePictureBox.Name = "thirdPrisePictureBox";
            this.thirdPrisePictureBox.Size = new System.Drawing.Size(187, 106);
            this.thirdPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdPrisePictureBox.TabIndex = 6;
            this.thirdPrisePictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip2.BackgroundImage")));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1163, 705);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // changeimages1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1163, 705);
            this.Controls.Add(this.lblThirdPrise);
            this.Controls.Add(this.thirdPrisePictureBox);
            this.Controls.Add(this.lblFirstPrise);
            this.Controls.Add(this.firstPrisePictureBox);
            this.Controls.Add(this.lblSecondPrise);
            this.Controls.Add(this.secondPrisePictureBox);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip2);
            this.Name = "changeimages1";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPrisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPrisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPrisePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.PictureBox secondPrisePictureBox;
        private System.Windows.Forms.Label lblSecondPrise;
        private System.Windows.Forms.Label lblFirstPrise;
        private System.Windows.Forms.PictureBox firstPrisePictureBox;
        private System.Windows.Forms.Label lblThirdPrise;
        private System.Windows.Forms.PictureBox thirdPrisePictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private readonly EventHandler bar1_Click;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}