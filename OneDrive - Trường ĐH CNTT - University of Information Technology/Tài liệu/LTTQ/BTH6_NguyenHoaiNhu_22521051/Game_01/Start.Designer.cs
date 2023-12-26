namespace Game_01
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.button_HuongDan = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_HuongDan
            // 
            this.button_HuongDan.BackColor = System.Drawing.Color.Cyan;
            this.button_HuongDan.Font = new System.Drawing.Font("UTM Hanzel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HuongDan.Location = new System.Drawing.Point(54, 319);
            this.button_HuongDan.Name = "button_HuongDan";
            this.button_HuongDan.Size = new System.Drawing.Size(123, 30);
            this.button_HuongDan.TabIndex = 0;
            this.button_HuongDan.Text = "Hướng dẫn";
            this.button_HuongDan.UseVisualStyleBackColor = false;
            this.button_HuongDan.Click += new System.EventHandler(this.button_HuongDan_Click);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_Start.Font = new System.Drawing.Font("SVN-Cookies", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(304, 277);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(191, 72);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Bắt đầu";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 398);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_HuongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_HuongDan;
        private System.Windows.Forms.Button button_Start;
    }
}