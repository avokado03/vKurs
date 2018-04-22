namespace Hotel
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(451, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 42);
            this.button1.TabIndex = 37;
            this.button1.Text = "Редактировать комнату";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(167, 358);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(603, 37);
            this.textBoxPrice.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Цена";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.backButton.Location = new System.Drawing.Point(299, 474);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 42);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
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
            this.AddButton.Location = new System.Drawing.Point(137, 474);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(141, 42);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(167, 264);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(603, 75);
            this.textBoxComment.TabIndex = 27;
            this.textBoxComment.UseSystemPasswordChar = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 205);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(603, 37);
            this.textBoxName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Описание";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Название";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "AccientFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "TransparentColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::Hotel.Properties.Settings.Default.AccientFont;
            this.label2.ForeColor = global::Hotel.Properties.Settings.Default.TransparentColor;
            this.label2.Location = new System.Drawing.Point(249, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 70);
            this.label2.TabIndex = 23;
            this.label2.Text = "Добавьте еще один номер\r\nв своей гостиннице";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "HeaderFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::Hotel.Properties.Settings.Default.HeaderFont;
            this.label1.Location = new System.Drawing.Point(132, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 59);
            this.label1.TabIndex = 22;
            this.label1.Text = "Добавление комнаты";
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Hotel.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxName);
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
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignIn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}