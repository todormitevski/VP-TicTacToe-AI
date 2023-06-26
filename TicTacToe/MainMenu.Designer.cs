﻿using System;
using System.Windows.Forms;

namespace TicTacToe
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVsCpu = new System.Windows.Forms.Button();
            this.btnVsPlayer = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gang of Three", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIC-TAC-TOE";
            //
            // allButtons
            //
            this.btnVsCpu.MouseEnter += new EventHandler(buttonsContainer_MouseEnter);
            this.btnVsCpu.MouseLeave += new EventHandler(buttonsContainer_MouseLeave);
            this.btnVsPlayer.MouseEnter += new EventHandler(buttonsContainer_MouseEnter);
            this.btnVsPlayer.MouseLeave += new EventHandler(buttonsContainer_MouseLeave);
            this.btnOptions.MouseEnter += new EventHandler(buttonsContainer_MouseEnter);
            this.btnOptions.MouseLeave += new EventHandler(buttonsContainer_MouseLeave);
            this.btnExit.MouseEnter += new EventHandler(buttonsContainer_MouseEnter);
            this.btnExit.MouseLeave += new EventHandler(buttonsContainer_MouseLeave);
            // 
            // btnVsCpu
            // 
            this.btnVsCpu.Font = new System.Drawing.Font("Gang of Three", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsCpu.Location = new System.Drawing.Point(129, 171);
            this.btnVsCpu.Name = "btnVsCpu";
            this.btnVsCpu.Size = new System.Drawing.Size(227, 47);
            this.btnVsCpu.TabIndex = 1;
            this.btnVsCpu.Text = "Play vs CPU";
            this.btnVsCpu.UseVisualStyleBackColor = true;
            // 
            // btnVsPlayer
            // 
            this.btnVsPlayer.Font = new System.Drawing.Font("Gang of Three", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsPlayer.Location = new System.Drawing.Point(129, 233);
            this.btnVsPlayer.Name = "btnVsPlayer";
            this.btnVsPlayer.Size = new System.Drawing.Size(227, 47);
            this.btnVsPlayer.TabIndex = 1;
            this.btnVsPlayer.Text = "Play vs Player";
            this.btnVsPlayer.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Gang of Three", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(129, 295);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(227, 47);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Gang of Three", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(129, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::TicTacToe.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnVsPlayer);
            this.Controls.Add(this.btnVsCpu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVsCpu;
        private System.Windows.Forms.Button btnVsPlayer;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
