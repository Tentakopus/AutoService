namespace Task5_V2
{
    partial class Requests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.RequestsView = new System.Windows.Forms.DataGridView();
            this.CreateRequest = new System.Windows.Forms.Button();
            this.SearchMode = new System.Windows.Forms.RadioButton();
            this.FiltreMode = new System.Windows.Forms.RadioButton();
            this.CarModelFilter = new System.Windows.Forms.ComboBox();
            this.CarTypeFilter = new System.Windows.Forms.ComboBox();
            this.StatusFilter = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.columnSearch = new System.Windows.Forms.ComboBox();
            this.RequestCountLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestsView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RequestsView.BackgroundColor = System.Drawing.Color.Thistle;
            this.RequestsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsView.GridColor = System.Drawing.Color.Thistle;
            this.RequestsView.Location = new System.Drawing.Point(12, 28);
            this.RequestsView.Name = "RequestsView";
            this.RequestsView.Size = new System.Drawing.Size(776, 358);
            this.RequestsView.TabIndex = 0;
            this.RequestsView.DataSourceChanged += new System.EventHandler(this.RequestsView_DataSourceChanged);
            this.RequestsView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestsView_CellDoubleClick);
            // 
            // CreateRequest
            // 
            this.CreateRequest.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.CreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRequest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateRequest.Location = new System.Drawing.Point(462, 467);
            this.CreateRequest.Name = "CreateRequest";
            this.CreateRequest.Size = new System.Drawing.Size(181, 42);
            this.CreateRequest.TabIndex = 1;
            this.CreateRequest.Text = "Сформитровать Заявку";
            this.CreateRequest.UseVisualStyleBackColor = false;
            this.CreateRequest.Visible = false;
            this.CreateRequest.Click += new System.EventHandler(this.CreateRequest_Click);
            // 
            // SearchMode
            // 
            this.SearchMode.AutoSize = true;
            this.SearchMode.Location = new System.Drawing.Point(20, 18);
            this.SearchMode.Name = "SearchMode";
            this.SearchMode.Size = new System.Drawing.Size(64, 24);
            this.SearchMode.TabIndex = 2;
            this.SearchMode.TabStop = true;
            this.SearchMode.Text = "Поиск";
            this.SearchMode.UseVisualStyleBackColor = true;
            this.SearchMode.CheckedChanged += new System.EventHandler(this.SearchMode_CheckedChanged);
            // 
            // FiltreMode
            // 
            this.FiltreMode.AutoSize = true;
            this.FiltreMode.Location = new System.Drawing.Point(125, 18);
            this.FiltreMode.Name = "FiltreMode";
            this.FiltreMode.Size = new System.Drawing.Size(72, 24);
            this.FiltreMode.TabIndex = 3;
            this.FiltreMode.TabStop = true;
            this.FiltreMode.Text = "Фильтр";
            this.FiltreMode.UseVisualStyleBackColor = true;
            this.FiltreMode.CheckedChanged += new System.EventHandler(this.FiltreMode_CheckedChanged);
            // 
            // CarModelFilter
            // 
            this.CarModelFilter.BackColor = System.Drawing.Color.Thistle;
            this.CarModelFilter.FormattingEnabled = true;
            this.CarModelFilter.Location = new System.Drawing.Point(59, 56);
            this.CarModelFilter.Name = "CarModelFilter";
            this.CarModelFilter.Size = new System.Drawing.Size(145, 28);
            this.CarModelFilter.TabIndex = 4;
            this.CarModelFilter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // CarTypeFilter
            // 
            this.CarTypeFilter.BackColor = System.Drawing.Color.Thistle;
            this.CarTypeFilter.FormattingEnabled = true;
            this.CarTypeFilter.Location = new System.Drawing.Point(59, 96);
            this.CarTypeFilter.Name = "CarTypeFilter";
            this.CarTypeFilter.Size = new System.Drawing.Size(145, 28);
            this.CarTypeFilter.TabIndex = 5;
            this.CarTypeFilter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // StatusFilter
            // 
            this.StatusFilter.BackColor = System.Drawing.Color.Thistle;
            this.StatusFilter.FormattingEnabled = true;
            this.StatusFilter.Location = new System.Drawing.Point(59, 137);
            this.StatusFilter.Name = "StatusFilter";
            this.StatusFilter.Size = new System.Drawing.Size(145, 28);
            this.StatusFilter.TabIndex = 6;
            this.StatusFilter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Thistle;
            this.SearchTextBox.Location = new System.Drawing.Point(7, 55);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(115, 26);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // columnSearch
            // 
            this.columnSearch.BackColor = System.Drawing.Color.Thistle;
            this.columnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.columnSearch.FormattingEnabled = true;
            this.columnSearch.Location = new System.Drawing.Point(130, 55);
            this.columnSearch.Name = "columnSearch";
            this.columnSearch.Size = new System.Drawing.Size(156, 28);
            this.columnSearch.TabIndex = 8;
            // 
            // RequestCountLable
            // 
            this.RequestCountLable.AutoSize = true;
            this.RequestCountLable.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestCountLable.Location = new System.Drawing.Point(731, 7);
            this.RequestCountLable.Name = "RequestCountLable";
            this.RequestCountLable.Size = new System.Drawing.Size(35, 16);
            this.RequestCountLable.TabIndex = 9;
            this.RequestCountLable.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.columnSearch);
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Controls.Add(this.StatusFilter);
            this.groupBox1.Controls.Add(this.FiltreMode);
            this.groupBox1.Controls.Add(this.CarTypeFilter);
            this.groupBox1.Controls.Add(this.SearchMode);
            this.groupBox1.Controls.Add(this.CarModelFilter);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 184);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(678, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Back_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RequestCountLable);
            this.Controls.Add(this.CreateRequest);
            this.Controls.Add(this.RequestsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Requests";
            this.Text = "Заявки";
            ((System.ComponentModel.ISupportInitialize)(this.RequestsView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RequestsView;
        private System.Windows.Forms.Button CreateRequest;
        private System.Windows.Forms.RadioButton SearchMode;
        private System.Windows.Forms.RadioButton FiltreMode;
        private System.Windows.Forms.ComboBox CarModelFilter;
        private System.Windows.Forms.ComboBox CarTypeFilter;
        private System.Windows.Forms.ComboBox StatusFilter;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox columnSearch;
        private System.Windows.Forms.Label RequestCountLable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}