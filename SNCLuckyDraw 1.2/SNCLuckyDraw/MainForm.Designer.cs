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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.thirdPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.firstPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.secondPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.firtfrizedoc = new System.Windows.Forms.Label();
            this.seconprizedoc = new System.Windows.Forms.Label();
            this.thirdfrizedoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPrisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPrisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPrisePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(729, 94);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
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
            // mainPictureBox
            // 
            this.mainPictureBox.BackgroundImage = global::SNCLuckyDraw.Properties.Resources._2c_1548258833_width1068height580_kspd;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(3, 103);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(729, 725);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.34976F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.65024F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1461, 837);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.mainPictureBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(723, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(735, 831);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.thirdPrisePictureBox, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.firstPrisePictureBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.secondPrisePictureBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.firtfrizedoc, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.seconprizedoc, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.thirdfrizedoc, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.888087F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.9639F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.971119F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.64019F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.730445F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.68592F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 831);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // thirdPrisePictureBox
            // 
            this.thirdPrisePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdPrisePictureBox.BackgroundImage")));
            this.thirdPrisePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdPrisePictureBox.Location = new System.Drawing.Point(3, 578);
            this.thirdPrisePictureBox.Name = "thirdPrisePictureBox";
            this.thirdPrisePictureBox.Size = new System.Drawing.Size(708, 250);
            this.thirdPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdPrisePictureBox.TabIndex = 6;
            this.thirdPrisePictureBox.TabStop = false;
            // 
            // firstPrisePictureBox
            // 
            this.firstPrisePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstPrisePictureBox.BackgroundImage")));
            this.firstPrisePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPrisePictureBox.Location = new System.Drawing.Point(3, 27);
            this.firstPrisePictureBox.Name = "firstPrisePictureBox";
            this.firstPrisePictureBox.Size = new System.Drawing.Size(708, 243);
            this.firstPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstPrisePictureBox.TabIndex = 4;
            this.firstPrisePictureBox.TabStop = false;
            // 
            // secondPrisePictureBox
            // 
            this.secondPrisePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondPrisePictureBox.BackgroundImage")));
            this.secondPrisePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondPrisePictureBox.Location = new System.Drawing.Point(3, 309);
            this.secondPrisePictureBox.Name = "secondPrisePictureBox";
            this.secondPrisePictureBox.Size = new System.Drawing.Size(708, 232);
            this.secondPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondPrisePictureBox.TabIndex = 2;
            this.secondPrisePictureBox.TabStop = false;
            // 
            // firtfrizedoc
            // 
            this.firtfrizedoc.AutoSize = true;
            this.firtfrizedoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firtfrizedoc.Location = new System.Drawing.Point(3, 0);
            this.firtfrizedoc.Name = "firtfrizedoc";
            this.firtfrizedoc.Size = new System.Drawing.Size(708, 24);
            this.firtfrizedoc.TabIndex = 7;
            this.firtfrizedoc.Text = "NGƯỜI THỨ NHẤT";
            // 
            // seconprizedoc
            // 
            this.seconprizedoc.AutoSize = true;
            this.seconprizedoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seconprizedoc.Location = new System.Drawing.Point(3, 273);
            this.seconprizedoc.Name = "seconprizedoc";
            this.seconprizedoc.Size = new System.Drawing.Size(708, 33);
            this.seconprizedoc.TabIndex = 8;
            this.seconprizedoc.Text = "NGƯỜI THỨ HAI";
            // 
            // thirdfrizedoc
            // 
            this.thirdfrizedoc.AutoSize = true;
            this.thirdfrizedoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdfrizedoc.Location = new System.Drawing.Point(3, 544);
            this.thirdfrizedoc.Name = "thirdfrizedoc";
            this.thirdfrizedoc.Size = new System.Drawing.Size(708, 31);
            this.thirdfrizedoc.TabIndex = 9;
            this.thirdfrizedoc.Text = "NGƯỜI THỨ BA";
            // 
            // changeimages1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1461, 837);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "changeimages1";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPrisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPrisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPrisePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private readonly EventHandler bar1_Click;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox thirdPrisePictureBox;
        private System.Windows.Forms.PictureBox firstPrisePictureBox;
        private System.Windows.Forms.PictureBox secondPrisePictureBox;
        private System.Windows.Forms.Label firtfrizedoc;
        private System.Windows.Forms.Label seconprizedoc;
        private System.Windows.Forms.Label thirdfrizedoc;
    }
}