namespace Task5_V2
{
    partial class MasterFomr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterFomr));
            this.Title = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.CarModel = new System.Windows.Forms.Label();
            this.CarType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repairDetails = new System.Windows.Forms.RichTextBox();
            this.AddDetailTextBox = new System.Windows.Forms.TextBox();
            this.AddDetail = new System.Windows.Forms.Button();
            this.Comments = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.AddComment = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(10, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(72, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "label1";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDate.Location = new System.Drawing.Point(13, 63);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(52, 23);
            this.StartDate.TabIndex = 1;
            this.StartDate.Text = "label2";
            // 
            // CarModel
            // 
            this.CarModel.AutoSize = true;
            this.CarModel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarModel.Location = new System.Drawing.Point(12, 107);
            this.CarModel.Name = "CarModel";
            this.CarModel.Size = new System.Drawing.Size(52, 23);
            this.CarModel.TabIndex = 2;
            this.CarModel.Text = "label1";
            // 
            // CarType
            // 
            this.CarType.AutoSize = true;
            this.CarType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarType.Location = new System.Drawing.Point(12, 153);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(52, 23);
            this.CarType.TabIndex = 3;
            this.CarType.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(417, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Используемые детали:";
            // 
            // repairDetails
            // 
            this.repairDetails.BackColor = System.Drawing.Color.Thistle;
            this.repairDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repairDetails.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repairDetails.Location = new System.Drawing.Point(420, 420);
            this.repairDetails.Name = "repairDetails";
            this.repairDetails.ReadOnly = true;
            this.repairDetails.Size = new System.Drawing.Size(332, 136);
            this.repairDetails.TabIndex = 5;
            this.repairDetails.Text = "";
            // 
            // AddDetailTextBox
            // 
            this.AddDetailTextBox.BackColor = System.Drawing.Color.Thistle;
            this.AddDetailTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDetailTextBox.Location = new System.Drawing.Point(420, 572);
            this.AddDetailTextBox.Name = "AddDetailTextBox";
            this.AddDetailTextBox.Size = new System.Drawing.Size(174, 29);
            this.AddDetailTextBox.TabIndex = 6;
            this.AddDetailTextBox.TextChanged += new System.EventHandler(this.AddDetailTextBox_TextChanged);
            // 
            // AddDetail
            // 
            this.AddDetail.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AddDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDetail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDetail.Location = new System.Drawing.Point(604, 570);
            this.AddDetail.Name = "AddDetail";
            this.AddDetail.Size = new System.Drawing.Size(106, 32);
            this.AddDetail.TabIndex = 7;
            this.AddDetail.Text = "Добавить";
            this.AddDetail.UseVisualStyleBackColor = false;
            this.AddDetail.Click += new System.EventHandler(this.AddDetail_Click);
            // 
            // Comments
            // 
            this.Comments.BackColor = System.Drawing.Color.Thistle;
            this.Comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comments.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comments.Location = new System.Drawing.Point(16, 420);
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Size = new System.Drawing.Size(347, 136);
            this.Comments.TabIndex = 8;
            this.Comments.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Комментарии:";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.BackColor = System.Drawing.Color.Thistle;
            this.CommentTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentTextBox.Location = new System.Drawing.Point(16, 575);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(160, 29);
            this.CommentTextBox.TabIndex = 10;
            this.CommentTextBox.TextChanged += new System.EventHandler(this.CommentTextBox_TextChanged);
            // 
            // AddComment
            // 
            this.AddComment.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AddComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddComment.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddComment.Location = new System.Drawing.Point(182, 573);
            this.AddComment.Name = "AddComment";
            this.AddComment.Size = new System.Drawing.Size(102, 32);
            this.AddComment.TabIndex = 11;
            this.AddComment.Text = "Добавить";
            this.AddComment.UseVisualStyleBackColor = false;
            this.AddComment.Click += new System.EventHandler(this.AddComment_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(17, 637);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(212, 45);
            this.Edit.TabIndex = 12;
            this.Edit.Text = "Сформировать отчет";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.Thistle;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(16, 231);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(347, 141);
            this.Description.TabIndex = 13;
            this.Description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Описание проблемы:";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(636, 637);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(116, 45);
            this.Back.TabIndex = 15;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MasterFomr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 694);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddComment);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.AddDetail);
            this.Controls.Add(this.AddDetailTextBox);
            this.Controls.Add(this.repairDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.CarModel);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterFomr";
            this.Text = "Формирование отчета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label CarModel;
        private System.Windows.Forms.Label CarType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox repairDetails;
        private System.Windows.Forms.TextBox AddDetailTextBox;
        private System.Windows.Forms.Button AddDetail;
        private System.Windows.Forms.RichTextBox Comments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Button AddComment;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back;
    }
}