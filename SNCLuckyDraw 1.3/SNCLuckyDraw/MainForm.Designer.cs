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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.thirdPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.firstPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.secondPrisePictureBox = new System.Windows.Forms.PictureBox();
            this.firtfrizedoc = new System.Windows.Forms.Label();
            this.seconprizedoc = new System.Windows.Forms.Label();
            this.thirdfrizedoc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPrisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPrisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPrisePictureBox)).BeginInit();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.90158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.09843F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 733);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(339, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1013, 729);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPictureBox.BackgroundImage = global::SNCLuckyDraw.Properties.Resources._2c_1548258833_width1068height580_kspd;
            this.mainPictureBox.Location = new System.Drawing.Point(77, 83);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(858, 644);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStart.Location = new System.Drawing.Point(918, 2);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 77);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.thirdPrisePictureBox, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.secondPrisePictureBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.seconprizedoc, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.firstPrisePictureBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.thirdfrizedoc, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.firtfrizedoc, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.303303F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03003F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.303303F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03003F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.303303F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03003F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 729);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // thirdPrisePictureBox
            // 
            this.thirdPrisePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thirdPrisePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdPrisePictureBox.BackgroundImage")));
            this.thirdPrisePictureBox.Location = new System.Drawing.Point(9, 413);
            this.thirdPrisePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.thirdPrisePictureBox.Name = "thirdPrisePictureBox";
            this.thirdPrisePictureBox.Size = new System.Drawing.Size(230, 173);
            this.thirdPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdPrisePictureBox.TabIndex = 6;
            this.thirdPrisePictureBox.TabStop = false;
            // 
            // firstPrisePictureBox
            // 
            this.firstPrisePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstPrisePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstPrisePictureBox.BackgroundImage")));
            this.firstPrisePictureBox.Location = new System.Drawing.Point(9, 19);
            this.firstPrisePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstPrisePictureBox.Name = "firstPrisePictureBox";
            this.firstPrisePictureBox.Size = new System.Drawing.Size(230, 173);
            this.firstPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstPrisePictureBox.TabIndex = 4;
            this.firstPrisePictureBox.TabStop = false;
            // 
            // secondPrisePictureBox
            // 
            this.secondPrisePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondPrisePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondPrisePictureBox.BackgroundImage")));
            this.secondPrisePictureBox.Location = new System.Drawing.Point(9, 219);
            this.secondPrisePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.secondPrisePictureBox.Name = "secondPrisePictureBox";
            this.secondPrisePictureBox.Size = new System.Drawing.Size(230, 173);
            this.secondPrisePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondPrisePictureBox.TabIndex = 2;
            this.secondPrisePictureBox.TabStop = false;
            // 
            // firtfrizedoc
            // 
            this.firtfrizedoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firtfrizedoc.AutoSize = true;
            this.firtfrizedoc.Location = new System.Drawing.Point(198, 2);
            this.firtfrizedoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firtfrizedoc.Name = "firtfrizedoc";
            this.firtfrizedoc.Size = new System.Drawing.Size(101, 13);
            this.firtfrizedoc.TabIndex = 7;
            this.firtfrizedoc.Text = "NGƯỜI THỨ NHẤT";
            this.firtfrizedoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seconprizedoc
            // 
            this.seconprizedoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seconprizedoc.AutoSize = true;
            this.seconprizedoc.Location = new System.Drawing.Point(204, 199);
            this.seconprizedoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seconprizedoc.Name = "seconprizedoc";
            this.seconprizedoc.Size = new System.Drawing.Size(89, 13);
            this.seconprizedoc.TabIndex = 8;
            this.seconprizedoc.Text = "NGƯỜI THỨ HAI";
            // 
            // thirdfrizedoc
            // 
            this.thirdfrizedoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thirdfrizedoc.AutoSize = true;
            this.thirdfrizedoc.Location = new System.Drawing.Point(206, 390);
            this.thirdfrizedoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thirdfrizedoc.Name = "thirdfrizedoc";
            this.thirdfrizedoc.Size = new System.Drawing.Size(85, 13);
            this.thirdfrizedoc.TabIndex = 9;
            this.thirdfrizedoc.Text = "NGƯỜI THỨ BA";
            // 
            // changeimages1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "changeimages1";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPrisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPrisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPrisePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private readonly EventHandler bar1_Click;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox thirdPrisePictureBox;
        private System.Windows.Forms.PictureBox firstPrisePictureBox;
        private System.Windows.Forms.PictureBox secondPrisePictureBox;
        private System.Windows.Forms.Label firtfrizedoc;
        private System.Windows.Forms.Label seconprizedoc;
        private System.Windows.Forms.Label thirdfrizedoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button btnStart;
    }
}