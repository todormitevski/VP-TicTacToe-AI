namespace TicTacToe
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusicOff = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMusicOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gang of Three", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Options";
            // 
            // btnMusicOff
            // 
            this.btnMusicOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicOff.Location = new System.Drawing.Point(56, 126);
            this.btnMusicOff.Name = "btnMusicOff";
            this.btnMusicOff.Size = new System.Drawing.Size(173, 42);
            this.btnMusicOff.TabIndex = 2;
            this.btnMusicOff.Text = "Turn music off";
            this.btnMusicOff.UseVisualStyleBackColor = true;
            this.btnMusicOff.Click += new System.EventHandler(this.btnMusicOff_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(56, 174);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(173, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMusicOn
            // 
            this.btnMusicOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicOn.Location = new System.Drawing.Point(56, 78);
            this.btnMusicOn.Name = "btnMusicOn";
            this.btnMusicOn.Size = new System.Drawing.Size(173, 42);
            this.btnMusicOn.TabIndex = 2;
            this.btnMusicOn.Text = "Turn music on";
            this.btnMusicOn.UseVisualStyleBackColor = true;
            this.btnMusicOn.Click += new System.EventHandler(this.btnMusicOn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMusicOn);
            this.Controls.Add(this.btnMusicOff);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusicOff;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMusicOn;
    }
}