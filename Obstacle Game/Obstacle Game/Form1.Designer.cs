using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Obstacle_Game
{
    partial class Form1:Form
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
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.CSharp = new System.Windows.Forms.PictureBox();
            this.Amit = new System.Windows.Forms.PictureBox();
            this.Shlomi = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CSharp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shlomi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(13, 13);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(102, 31);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "Score:0";
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // CSharp
            // 
            this.CSharp.Image = global::Obstacle_Game.Properties.Resources.c__logo;
            this.CSharp.Location = new System.Drawing.Point(534, 400);
            this.CSharp.Name = "CSharp";
            this.CSharp.Size = new System.Drawing.Size(50, 50);
            this.CSharp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CSharp.TabIndex = 10;
            this.CSharp.TabStop = false;
            this.CSharp.Tag = "obstacle";
            this.CSharp.Click += new System.EventHandler(this.CSharp_Click);
            // 
            // Amit
            // 
            this.Amit.Image = global::Obstacle_Game.Properties.Resources.fatma;
            this.Amit.Location = new System.Drawing.Point(386, 400);
            this.Amit.Name = "Amit";
            this.Amit.Size = new System.Drawing.Size(67, 55);
            this.Amit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Amit.TabIndex = 8;
            this.Amit.TabStop = false;
            this.Amit.Tag = "obstacle";
            this.Amit.Click += new System.EventHandler(this.Amit_Click);
            // 
            // Shlomi
            // 
            this.Shlomi.Image = global::Obstacle_Game.Properties.Resources.shlomi;
            this.Shlomi.Location = new System.Drawing.Point(40, 395);
            this.Shlomi.Name = "Shlomi";
            this.Shlomi.Size = new System.Drawing.Size(44, 60);
            this.Shlomi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shlomi.TabIndex = 7;
            this.Shlomi.TabStop = false;
            this.Shlomi.Tag = "ShlomiTag";
            this.Shlomi.Click += new System.EventHandler(this.shlomi2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 456);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2065, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1279, 458);
            this.Controls.Add(this.Shlomi);
            this.Controls.Add(this.Amit);
            this.Controls.Add(this.CSharp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Tag = "CppTag";
            this.Text = "Obstacle game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.CSharp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shlomi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox Shlomi;
        private PictureBox Amit;
        private PictureBox CSharp;
    }
}

