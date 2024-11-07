namespace Task5_V2
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.RequestsButton = new System.Windows.Forms.Button();
            this.LoginHistoryButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(238, 26);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 23);
            this.name.TabIndex = 1;
            this.name.Text = "Имя: ";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(238, 61);
            this.Surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(85, 23);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Фамилия: ";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Role.Location = new System.Drawing.Point(238, 97);
            this.Role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(54, 23);
            this.Role.TabIndex = 3;
            this.Role.Text = "Роль: ";
            // 
            // UserIcon
            // 
            this.UserIcon.Location = new System.Drawing.Point(12, 12);
            this.UserIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(204, 169);
            this.UserIcon.TabIndex = 0;
            this.UserIcon.TabStop = false;
            // 
            // RequestsButton
            // 
            this.RequestsButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.RequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestsButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestsButton.Location = new System.Drawing.Point(12, 201);
            this.RequestsButton.Name = "RequestsButton";
            this.RequestsButton.Size = new System.Drawing.Size(117, 48);
            this.RequestsButton.TabIndex = 4;
            this.RequestsButton.Text = "Заявки";
            this.RequestsButton.UseVisualStyleBackColor = false;
            this.RequestsButton.Click += new System.EventHandler(this.Requests_Click);
            // 
            // LoginHistoryButton
            // 
            this.LoginHistoryButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.LoginHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginHistoryButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginHistoryButton.Location = new System.Drawing.Point(146, 201);
            this.LoginHistoryButton.Name = "LoginHistoryButton";
            this.LoginHistoryButton.Size = new System.Drawing.Size(117, 48);
            this.LoginHistoryButton.TabIndex = 5;
            this.LoginHistoryButton.Text = "История входа";
            this.LoginHistoryButton.UseVisualStyleBackColor = false;
            this.LoginHistoryButton.Click += new System.EventHandler(this.LoginHistory_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LemonChiffon;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(281, 201);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(117, 48);
            this.Back.TabIndex = 6;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(425, 270);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LoginHistoryButton);
            this.Controls.Add(this.RequestsButton);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.UserIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Profile";
            this.Text = "Профиль пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserIcon;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Button RequestsButton;
        private System.Windows.Forms.Button LoginHistoryButton;
        private System.Windows.Forms.Button Back;
    }
}