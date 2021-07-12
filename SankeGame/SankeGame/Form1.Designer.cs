
namespace SankeGame
{
    partial class Form1
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
            this.GamTimer = new System.Windows.Forms.Timer(this.components);
            this.apple = new System.Windows.Forms.PictureBox();
            this.Body = new System.Windows.Forms.PictureBox();
            this.Head = new System.Windows.Forms.PictureBox();
            this.Score_Text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).BeginInit();
            this.SuspendLayout();
            // 
            // GamTimer
            // 
            this.GamTimer.Enabled = true;
            this.GamTimer.Interval = 20;
            this.GamTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // apple
            // 
            this.apple.Image = global::SankeGame.Properties.Resources.apple;
            this.apple.Location = new System.Drawing.Point(164, 332);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(20, 20);
            this.apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apple.TabIndex = 2;
            this.apple.TabStop = false;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.Lime;
            this.Body.Location = new System.Drawing.Point(413, 230);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(20, 20);
            this.Body.TabIndex = 1;
            this.Body.TabStop = false;
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.Color.Red;
            this.Head.Image = global::SankeGame.Properties.Resources.HeadPaint;
            this.Head.Location = new System.Drawing.Point(413, 250);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(20, 20);
            this.Head.TabIndex = 0;
            this.Head.TabStop = false;
            // 
            // Score_Text
            // 
            this.Score_Text.AutoSize = true;
            this.Score_Text.Location = new System.Drawing.Point(12, 9);
            this.Score_Text.Name = "Score_Text";
            this.Score_Text.Size = new System.Drawing.Size(46, 17);
            this.Score_Text.TabIndex = 3;
            this.Score_Text.Text = "label1";
            this.Score_Text.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.Score_Text);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Head);
            this.Name = "Form1";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Head)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Head;
        private System.Windows.Forms.PictureBox Body;
        private System.Windows.Forms.Timer GamTimer;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.Label Score_Text;
    }
}

