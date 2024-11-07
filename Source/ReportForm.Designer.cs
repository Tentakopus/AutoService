namespace Task5_V2
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.RequestNumber = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.MasterName = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Comments = new System.Windows.Forms.RichTextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.repairDetails = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.QRCode = new System.Windows.Forms.PictureBox();
            this.QRCodeLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestNumber
            // 
            this.RequestNumber.AutoSize = true;
            this.RequestNumber.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestNumber.Location = new System.Drawing.Point(12, 23);
            this.RequestNumber.Name = "RequestNumber";
            this.RequestNumber.Size = new System.Drawing.Size(89, 37);
            this.RequestNumber.TabIndex = 0;
            this.RequestNumber.Text = "label1";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientName.Location = new System.Drawing.Point(15, 82);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(52, 23);
            this.ClientName.TabIndex = 1;
            this.ClientName.Text = "label2";
            // 
            // MasterName
            // 
            this.MasterName.AutoSize = true;
            this.MasterName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasterName.Location = new System.Drawing.Point(15, 117);
            this.MasterName.Name = "MasterName";
            this.MasterName.Size = new System.Drawing.Size(52, 23);
            this.MasterName.TabIndex = 2;
            this.MasterName.Text = "label3";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDate.Location = new System.Drawing.Point(418, 117);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(52, 23);
            this.StartDate.TabIndex = 3;
            this.StartDate.Text = "label4";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDate.Location = new System.Drawing.Point(418, 159);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(52, 23);
            this.EndDate.TabIndex = 4;
            this.EndDate.Text = "label5";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.Location = new System.Drawing.Point(12, 159);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(52, 23);
            this.Model.TabIndex = 5;
            this.Model.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Описание проблемы:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Использованные детали:";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.Thistle;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(16, 290);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(312, 152);
            this.Description.TabIndex = 8;
            this.Description.Text = "";
            // 
            // Comments
            // 
            this.Comments.BackColor = System.Drawing.Color.Thistle;
            this.Comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comments.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comments.Location = new System.Drawing.Point(380, 290);
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Size = new System.Drawing.Size(326, 152);
            this.Comments.TabIndex = 9;
            this.Comments.Text = "";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(553, 528);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(132, 55);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.Location = new System.Drawing.Point(12, 204);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(52, 23);
            this.Type.TabIndex = 11;
            this.Type.Text = "label1";
            // 
            // repairDetails
            // 
            this.repairDetails.BackColor = System.Drawing.Color.Thistle;
            this.repairDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repairDetails.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repairDetails.Location = new System.Drawing.Point(16, 490);
            this.repairDetails.Name = "repairDetails";
            this.repairDetails.ReadOnly = true;
            this.repairDetails.Size = new System.Drawing.Size(312, 137);
            this.repairDetails.TabIndex = 13;
            this.repairDetails.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(378, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Комментарии автомеханика:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(419, 82);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(52, 23);
            this.Status.TabIndex = 14;
            this.Status.Text = "label3";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(400, 528);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(134, 55);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Отклонить Заявку";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(682, 599);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(97, 37);
            this.Back.TabIndex = 16;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // QRCode
            // 
            this.QRCode.Location = new System.Drawing.Point(385, 489);
            this.QRCode.Name = "QRCode";
            this.QRCode.Size = new System.Drawing.Size(120, 94);
            this.QRCode.TabIndex = 18;
            this.QRCode.TabStop = false;
            this.QRCode.Visible = false;
            // 
            // QRCodeLable
            // 
            this.QRCodeLable.AutoSize = true;
            this.QRCodeLable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QRCodeLable.Location = new System.Drawing.Point(362, 464);
            this.QRCodeLable.Name = "QRCodeLable";
            this.QRCodeLable.Size = new System.Drawing.Size(108, 23);
            this.QRCodeLable.TabIndex = 19;
            this.QRCodeLable.Text = "Оцените нас:";
            this.QRCodeLable.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.QRCodeLable);
            this.Controls.Add(this.QRCode);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.repairDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.MasterName);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.RequestNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Отчет";
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RequestNumber;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label MasterName;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.RichTextBox Comments;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.RichTextBox repairDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox QRCode;
        private System.Windows.Forms.Label QRCodeLable;
    }
}