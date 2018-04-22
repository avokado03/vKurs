namespace Hotel
{
    partial class AdmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmMenu));
            this.addRoomButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.regClientButton = new System.Windows.Forms.Button();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
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
            this.addRoomButton.Location = new System.Drawing.Point(12, 98);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(360, 42);
            this.addRoomButton.TabIndex = 17;
            this.addRoomButton.Text = "Добавить постояльца";
            this.addRoomButton.UseVisualStyleBackColor = false;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = global::Hotel.Properties.Settings.Default.MainColor;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "TransparentColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Verdana", 15F);
            this.label1.ForeColor = global::Hotel.Properties.Settings.Default.TransparentColor;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Меню администратора гостиницы";
            // 
            // regClientButton
            // 
            this.regClientButton.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.regClientButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.regClientButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.regClientButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.regClientButton.FlatAppearance.BorderSize = 0;
            this.regClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regClientButton.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.regClientButton.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.regClientButton.Location = new System.Drawing.Point(14, 192);
            this.regClientButton.Name = "regClientButton";
            this.regClientButton.Size = new System.Drawing.Size(360, 42);
            this.regClientButton.TabIndex = 18;
            this.regClientButton.Text = "Регистрация постояльца";
            this.regClientButton.UseVisualStyleBackColor = false;
            this.regClientButton.Click += new System.EventHandler(this.editRoomButton_Click);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.BackColor = System.Drawing.Color.White;
            this.pictureBoxHide.Location = new System.Drawing.Point(301, 24);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(32, 3);
            this.pictureBoxHide.TabIndex = 21;
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
            this.pictureBoxClose.TabIndex = 20;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
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
            this.exitButton.Location = new System.Drawing.Point(12, 293);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(360, 42);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources.blabla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBoxHide);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.regClientButton);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdmMenu";
            this.Text = "AdmMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdmMenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regClientButton;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Button exitButton;
    }
}