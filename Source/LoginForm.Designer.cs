using System.Drawing;
using System.Windows.Forms;

namespace Task5_V2
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.timerLable = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.Thistle;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(72, 91);
            this.LoginTextBox.MaxLength = 25;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(123, 26);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Thistle;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(72, 162);
            this.PasswordTextBox.MaxLength = 25;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(105, 26);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вход в систему";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label2.Location = new System.Drawing.Point(112, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label3.Location = new System.Drawing.Point(106, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LemonChiffon;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Location = new System.Drawing.Point(93, 224);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(84, 39);
            this.Login.TabIndex = 5;
            this.Login.Text = "Войти";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // timerLable
            // 
            this.timerLable.AutoSize = true;
            this.timerLable.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLable.Location = new System.Drawing.Point(20, 200);
            this.timerLable.Name = "timerLable";
            this.timerLable.Size = new System.Drawing.Size(38, 20);
            this.timerLable.TabIndex = 6;
            this.timerLable.Text = "timer";
            this.timerLable.Visible = false;
            // 
            // showPassword
            // 
            this.showPassword.BackColor = System.Drawing.Color.LemonChiffon;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showPassword.Location = new System.Drawing.Point(175, 162);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(30, 26);
            this.showPassword.TabIndex = 7;
            this.showPassword.UseVisualStyleBackColor = false;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(267, 275);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.timerLable);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Форма Входа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Login;
        private Label timerLable;
        private Button showPassword;
    }
}

