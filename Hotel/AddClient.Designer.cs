namespace Hotel
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.textBoxPatr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(134, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавление жильца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "AccientFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "TransparentColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::Hotel.Properties.Settings.Default.AccientFont;
            this.label2.ForeColor = global::Hotel.Properties.Settings.Default.TransparentColor;
            this.label2.Location = new System.Drawing.Point(110, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 70);
            this.label2.TabIndex = 7;
            this.label2.Text = "Добавьте клиента,\r\nчтобы зарегистрировать его как постояльца";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фамилия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(139, 171);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(633, 37);
            this.textBoxFname.TabIndex = 10;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(139, 230);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(633, 37);
            this.textBoxLname.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.AddButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AddButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AddButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.AddButton.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.AddButton.Location = new System.Drawing.Point(139, 480);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(141, 42);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.backButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.backButton.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.backButton.Location = new System.Drawing.Point(301, 480);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 42);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // textBoxPatr
            // 
            this.textBoxPatr.Location = new System.Drawing.Point(139, 286);
            this.textBoxPatr.Name = "textBoxPatr";
            this.textBoxPatr.Size = new System.Drawing.Size(633, 37);
            this.textBoxPatr.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Отчество";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(139, 375);
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(633, 37);
            this.textBoxSeries.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Серия";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(139, 429);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(633, 37);
            this.textBoxNumber.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Номер";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Паспорт";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.button1.Location = new System.Drawing.Point(453, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Редактировать клиента";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Hotel.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPatr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignIn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox textBoxPatr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}