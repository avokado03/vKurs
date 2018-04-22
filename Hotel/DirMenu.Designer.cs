namespace Hotel
{
    partial class DirMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirMenu));
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.BackColor = System.Drawing.Color.White;
            this.pictureBoxHide.Location = new System.Drawing.Point(301, 24);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(32, 3);
            this.pictureBoxHide.TabIndex = 7;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = global::Hotel.Properties.Resources.krestik;
            this.pictureBoxClose.Location = new System.Drawing.Point(344, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(28, 17);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 6;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = global::Hotel.Properties.Settings.Default.MainColor;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "TransparentColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.ForeColor = global::Hotel.Properties.Settings.Default.TransparentColor;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Меню директора гостиницы";
            // 
            // addRoomButton
            // 
            this.addRoomButton.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.addRoomButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addRoomButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addRoomButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addRoomButton.FlatAppearance.BorderSize = 0;
            this.addRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomButton.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.addRoomButton.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.addRoomButton.Location = new System.Drawing.Point(12, 92);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(360, 42);
            this.addRoomButton.TabIndex = 13;
            this.addRoomButton.Text = "Добавить комнату";
            this.addRoomButton.UseVisualStyleBackColor = false;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.reportButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reportButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reportButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.reportButton.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.reportButton.Location = new System.Drawing.Point(12, 189);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(360, 42);
            this.reportButton.TabIndex = 15;
            this.reportButton.Text = "Отчет о выручке";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.exitButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exitButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exitButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.exitButton.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.exitButton.Location = new System.Drawing.Point(12, 288);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(360, 42);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DirMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.BackgroundImage = global::Hotel.Properties.Resources.blabla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHide);
            this.Controls.Add(this.pictureBoxClose);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DirMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DirMenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button exitButton;
    }
}