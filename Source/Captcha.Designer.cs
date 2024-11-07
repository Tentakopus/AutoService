namespace Task5_V2
{
    partial class Captcha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Captcha));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeCaptcha = new System.Windows.Forms.Button();
            this.enterCaptcha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(44, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 29);
            this.textBox1.TabIndex = 1;
            // 
            // changeCaptcha
            // 
            this.changeCaptcha.BackColor = System.Drawing.Color.LemonChiffon;
            this.changeCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeCaptcha.Font = new System.Drawing.Font("Arial Narrow", 12.25F);
            this.changeCaptcha.Location = new System.Drawing.Point(19, 133);
            this.changeCaptcha.Name = "changeCaptcha";
            this.changeCaptcha.Size = new System.Drawing.Size(85, 37);
            this.changeCaptcha.TabIndex = 2;
            this.changeCaptcha.Text = "Заменить";
            this.changeCaptcha.UseVisualStyleBackColor = false;
            this.changeCaptcha.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterCaptcha
            // 
            this.enterCaptcha.BackColor = System.Drawing.Color.LemonChiffon;
            this.enterCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterCaptcha.Font = new System.Drawing.Font("Arial Narrow", 12.25F);
            this.enterCaptcha.Location = new System.Drawing.Point(119, 133);
            this.enterCaptcha.Name = "enterCaptcha";
            this.enterCaptcha.Size = new System.Drawing.Size(85, 37);
            this.enterCaptcha.TabIndex = 3;
            this.enterCaptcha.Text = "Ввести";
            this.enterCaptcha.UseVisualStyleBackColor = false;
            this.enterCaptcha.Click += new System.EventHandler(this.button2_Click);
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(221, 191);
            this.Controls.Add(this.enterCaptcha);
            this.Controls.Add(this.changeCaptcha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Captcha";
            this.Text = "CAPTCHA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changeCaptcha;
        private System.Windows.Forms.Button enterCaptcha;
    }
}