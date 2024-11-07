namespace Task5_V2
{
    partial class ClientRequestCreateAlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRequestCreateAlertForm));
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProblemDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.CreateRequest = new System.Windows.Forms.Button();
            this.CarModelComboBox = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(15, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(72, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модель машины:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Описание проблемы:";
            // 
            // ProblemDescriptionTextBox
            // 
            this.ProblemDescriptionTextBox.BackColor = System.Drawing.Color.Thistle;
            this.ProblemDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProblemDescriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemDescriptionTextBox.Location = new System.Drawing.Point(20, 176);
            this.ProblemDescriptionTextBox.Name = "ProblemDescriptionTextBox";
            this.ProblemDescriptionTextBox.Size = new System.Drawing.Size(521, 197);
            this.ProblemDescriptionTextBox.TabIndex = 6;
            this.ProblemDescriptionTextBox.Text = "";
            this.ProblemDescriptionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // CreateRequest
            // 
            this.CreateRequest.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.CreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRequest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateRequest.Location = new System.Drawing.Point(20, 399);
            this.CreateRequest.Name = "CreateRequest";
            this.CreateRequest.Size = new System.Drawing.Size(115, 45);
            this.CreateRequest.TabIndex = 7;
            this.CreateRequest.Text = "button1";
            this.CreateRequest.UseVisualStyleBackColor = false;
            this.CreateRequest.Click += new System.EventHandler(this.CreateRequest_Click);
            // 
            // CarModelComboBox
            // 
            this.CarModelComboBox.BackColor = System.Drawing.Color.Thistle;
            this.CarModelComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarModelComboBox.FormattingEnabled = true;
            this.CarModelComboBox.Location = new System.Drawing.Point(146, 91);
            this.CarModelComboBox.Name = "CarModelComboBox";
            this.CarModelComboBox.Size = new System.Drawing.Size(219, 28);
            this.CarModelComboBox.TabIndex = 9;
            this.CarModelComboBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(426, 399);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(115, 45);
            this.Back.TabIndex = 10;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ClientRequestCreateAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(572, 466);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CarModelComboBox);
            this.Controls.Add(this.CreateRequest);
            this.Controls.Add(this.ProblemDescriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientRequestCreateAlertForm";
            this.Text = "ClientRequestCreateAlertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ProblemDescriptionTextBox;
        private System.Windows.Forms.Button CreateRequest;
        private System.Windows.Forms.ComboBox CarModelComboBox;
        private System.Windows.Forms.Button Back;
    }
}