namespace Game_01
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.textBox_Intro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Intro
            // 
            this.textBox_Intro.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_Intro.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Intro.ForeColor = System.Drawing.Color.Bisque;
            this.textBox_Intro.Location = new System.Drawing.Point(172, 104);
            this.textBox_Intro.Multiline = true;
            this.textBox_Intro.Name = "textBox_Intro";
            this.textBox_Intro.Size = new System.Drawing.Size(511, 213);
            this.textBox_Intro.TabIndex = 0;
            this.textBox_Intro.Text = resources.GetString("textBox_Intro.Text");
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_01.Properties.Resources.Background_Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Intro);
            this.MaximizeBox = false;
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Intro;
    }
}