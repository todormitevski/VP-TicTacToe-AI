using System;
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
            this.musicOffBtn = new System.Windows.Forms.Button();
            this.musicOnBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIC-TAC-TOE";
            // 
            // btnVsCpu
            // 
            this.btnVsCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsCpu.Location = new System.Drawing.Point(129, 171);
            this.btnVsCpu.Name = "btnVsCpu";
            this.btnVsCpu.Size = new System.Drawing.Size(227, 47);
            this.btnVsCpu.TabIndex = 1;
            this.btnVsCpu.Text = "Play vs CPU";
            this.btnVsCpu.UseVisualStyleBackColor = true;
            this.btnVsCpu.Click += new System.EventHandler(this.btnVsCpu_Click);
            this.btnVsCpu.MouseEnter += new System.EventHandler(this.buttonsContainer_MouseEnter);
            this.btnVsCpu.MouseLeave += new System.EventHandler(this.buttonsContainer_MouseLeave);
            // 
            // btnVsPlayer
            // 
            this.btnVsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsPlayer.Location = new System.Drawing.Point(129, 233);
            this.btnVsPlayer.Name = "btnVsPlayer";
            this.btnVsPlayer.Size = new System.Drawing.Size(227, 47);
            this.btnVsPlayer.TabIndex = 1;
            this.btnVsPlayer.Text = "Play vs Player";
            this.btnVsPlayer.UseVisualStyleBackColor = true;
            this.btnVsPlayer.Click += new System.EventHandler(this.btnVsPlayer_Click);
            this.btnVsPlayer.MouseEnter += new System.EventHandler(this.buttonsContainer_MouseEnter);
            this.btnVsPlayer.MouseLeave += new System.EventHandler(this.buttonsContainer_MouseLeave);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(129, 295);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(227, 47);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseEnter += new System.EventHandler(this.buttonsContainer_MouseEnter);
            this.btnOptions.MouseLeave += new System.EventHandler(this.buttonsContainer_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(129, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.buttonsContainer_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.buttonsContainer_MouseLeave);
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
            // musicOffBtn
            // 
            this.musicOffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicOffBtn.Location = new System.Drawing.Point(144, 262);
            this.musicOffBtn.Name = "musicOffBtn";
            this.musicOffBtn.Size = new System.Drawing.Size(197, 38);
            this.musicOffBtn.TabIndex = 1;
            this.musicOffBtn.Text = "Music OFF";
            this.musicOffBtn.UseVisualStyleBackColor = true;
            this.musicOffBtn.Visible = false;
            this.musicOffBtn.Click += new System.EventHandler(this.musicOff);
            this.musicOffBtn.MouseEnter += new System.EventHandler(this.buttonsContainer_MouseEnter);
            this.musicOffBtn.MouseLeave += new System.EventHandler(this.buttonsContainer_MouseLeave);
            // 
            // musicOnBtn
            // 
            this.musicOnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicOnBtn.Location = new System.Drawing.Point(144, 203);
            this.musicOnBtn.Name = "musicOnBtn";
            this.musicOnBtn.Size = new System.Drawing.Size(197, 38);
            this.musicOnBtn.TabIndex = 1;
            this.musicOnBtn.Text = "Music ON";
            this.musicOnBtn.UseVisualStyleBackColor = true;
            this.musicOnBtn.Visible = false;
            this.musicOnBtn.Click += new System.EventHandler(this.musicOn);
            this.musicOnBtn.MouseEnter += new System.EventHandler(this.buttonsContainer_MouseEnter);
            this.musicOnBtn.MouseLeave += new System.EventHandler(this.buttonsContainer_MouseLeave);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(129, 461);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(227, 38);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.back);
            this.backBtn.MouseEnter += new System.EventHandler(this.buttonsContainer_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.buttonsContainer_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::TicTacToe.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.musicOnBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.musicOffBtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnVsPlayer);
            this.Controls.Add(this.btnVsCpu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
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
        private Button musicOffBtn;
        private Button musicOnBtn;
        private Button backBtn;
    }
}

