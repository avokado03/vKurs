namespace Hotel
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hotelDataSet1 = new Hotel.hotelDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.BackColor = System.Drawing.Color.White;
            this.pictureBoxHide.Location = new System.Drawing.Point(701, 24);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(32, 3);
            this.pictureBoxHide.TabIndex = 5;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = global::Hotel.Properties.Resources.krestik;
            this.pictureBoxClose.Location = new System.Drawing.Point(744, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(28, 17);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 4;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "HeaderFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::Hotel.Properties.Settings.Default.HeaderFont;
            this.label1.Location = new System.Drawing.Point(155, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Финансовый отчет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "AccientFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "TransparentColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::Hotel.Properties.Settings.Default.AccientFont;
            this.label2.ForeColor = global::Hotel.Properties.Settings.Default.TransparentColor;
            this.label2.Location = new System.Drawing.Point(217, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 70);
            this.label2.TabIndex = 7;
            this.label2.Text = "Создайте отчет о прибыли\r\nна определенный день";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.signInButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.signInButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.signInButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.signInButton.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.signInButton.Location = new System.Drawing.Point(50, 426);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(126, 42);
            this.signInButton.TabIndex = 12;
            this.signInButton.Text = "Создать";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.button1.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.button1.Location = new System.Drawing.Point(50, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 58);
            this.label3.TabIndex = 15;
            this.label3.Text = "Выберите\r\nдату";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewReport.Location = new System.Drawing.Point(203, 183);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewReport.Size = new System.Drawing.Size(569, 285);
            this.dataGridViewReport.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 37);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(23, 348);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 37);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "По";
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "hotelDataSet";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Hotel.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHide);
            this.Controls.Add(this.pictureBoxClose);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report";
            this.Text = "Report";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignIn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private hotelDataSet hotelDataSet1;
    }
}