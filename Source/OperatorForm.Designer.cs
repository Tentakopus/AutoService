namespace Task5_V2
{
    partial class OperatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorForm));
            this.Title = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.StatusLable = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.MasterLable = new System.Windows.Forms.Label();
            this.Master = new System.Windows.Forms.ComboBox();
            this.DescriptionLable = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.DeleteEndDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(9, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(72, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "label1";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientName.Location = new System.Drawing.Point(15, 69);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(52, 23);
            this.ClientName.TabIndex = 1;
            this.ClientName.Text = "label2";
            // 
            // ModelName
            // 
            this.ModelName.AutoSize = true;
            this.ModelName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelName.Location = new System.Drawing.Point(15, 111);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(52, 23);
            this.ModelName.TabIndex = 2;
            this.ModelName.Text = "label2";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.Location = new System.Drawing.Point(407, 69);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(52, 23);
            this.Type.TabIndex = 3;
            this.Type.Text = "label2";
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLable.Location = new System.Drawing.Point(17, 232);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(106, 23);
            this.StatusLable.TabIndex = 4;
            this.StatusLable.Text = "Автомеханик";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Thistle;
            this.Status.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(142, 170);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(219, 31);
            this.Status.TabIndex = 5;
            this.Status.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MasterLable
            // 
            this.MasterLable.AutoSize = true;
            this.MasterLable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasterLable.Location = new System.Drawing.Point(17, 170);
            this.MasterLable.Name = "MasterLable";
            this.MasterLable.Size = new System.Drawing.Size(119, 23);
            this.MasterLable.TabIndex = 6;
            this.MasterLable.Text = "Статус заявки: ";
            // 
            // Master
            // 
            this.Master.BackColor = System.Drawing.Color.Thistle;
            this.Master.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Master.FormattingEnabled = true;
            this.Master.Location = new System.Drawing.Point(141, 229);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(333, 31);
            this.Master.TabIndex = 7;
            this.Master.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // DescriptionLable
            // 
            this.DescriptionLable.AutoSize = true;
            this.DescriptionLable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLable.Location = new System.Drawing.Point(17, 293);
            this.DescriptionLable.Name = "DescriptionLable";
            this.DescriptionLable.Size = new System.Drawing.Size(167, 23);
            this.DescriptionLable.TabIndex = 8;
            this.DescriptionLable.Text = "Описание проблемы:";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.Thistle;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(19, 321);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(393, 151);
            this.Description.TabIndex = 9;
            this.Description.Text = "";
            this.Description.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(19, 509);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(165, 58);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Обработать заявку";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDate.Location = new System.Drawing.Point(407, 111);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(52, 23);
            this.StartDate.TabIndex = 11;
            this.StartDate.Text = "label2";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(578, 509);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(99, 58);
            this.Back.TabIndex = 12;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteEndDate
            // 
            this.DeleteEndDate.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.DeleteEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEndDate.Location = new System.Drawing.Point(205, 509);
            this.DeleteEndDate.Name = "DeleteEndDate";
            this.DeleteEndDate.Size = new System.Drawing.Size(165, 58);
            this.DeleteEndDate.TabIndex = 13;
            this.DeleteEndDate.Text = "Продлить срок выполнения";
            this.DeleteEndDate.UseVisualStyleBackColor = false;
            this.DeleteEndDate.Visible = false;
            this.DeleteEndDate.Click += new System.EventHandler(this.DeleteEndDate_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(710, 592);
            this.Controls.Add(this.DeleteEndDate);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DescriptionLable);
            this.Controls.Add(this.Master);
            this.Controls.Add(this.MasterLable);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ModelName);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperatorForm";
            this.Text = "Обработка заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label ModelName;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label MasterLable;
        private System.Windows.Forms.ComboBox Master;
        private System.Windows.Forms.Label DescriptionLable;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button DeleteEndDate;
    }
}