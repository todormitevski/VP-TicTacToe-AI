namespace TicTacToe
{
    partial class Game
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 78);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 78);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 78);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 78);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(122, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 78);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(217, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 78);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 212);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 78);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(122, 212);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 78);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(217, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 78);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMove);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(136, 321);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 1;
            this.restart.Text = "button10";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label label1;
    }
}