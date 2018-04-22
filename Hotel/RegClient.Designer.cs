namespace Hotel
{
    partial class RegClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegClient));
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.textBoxCoast = new System.Windows.Forms.TextBox();
            this.clientDataSet = new Hotel.clientDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Hotel.clientDataSetTableAdapters.ClientTableAdapter();
            this.roomDataSet = new Hotel.roomDataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new Hotel.roomDataSetTableAdapters.RoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Регистрация постояльца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "AccientFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "TransparentColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::Hotel.Properties.Settings.Default.AccientFont;
            this.label2.ForeColor = global::Hotel.Properties.Settings.Default.TransparentColor;
            this.label2.Location = new System.Drawing.Point(101, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Зарегистрируйте нового жильца в его комнате";
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
            this.signInButton.Location = new System.Drawing.Point(165, 454);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(180, 42);
            this.signInButton.TabIndex = 12;
            this.signInButton.Text = "Регистрация";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.buttonBack.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonBack.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonBack.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.buttonBack.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.buttonBack.Location = new System.Drawing.Point(361, 454);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 42);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.clientBindingSource;
            this.comboBoxClient.DisplayMember = "FirstName";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(165, 171);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(607, 37);
            this.comboBoxClient.TabIndex = 14;
            this.comboBoxClient.ValueMember = "Id_Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Комната";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "С";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "По";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Стоимость";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DataSource = this.roomsBindingSource;
            this.comboBoxRoom.DisplayMember = "Id_rooms";
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(165, 220);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(607, 37);
            this.comboBoxRoom.TabIndex = 20;
            this.comboBoxRoom.ValueMember = "Id_rooms";
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(165, 269);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(607, 37);
            this.dateTimePickerFrom.TabIndex = 21;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(165, 318);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(607, 37);
            this.dateTimePickerTo.TabIndex = 22;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // textBoxCoast
            // 
            this.textBoxCoast.Location = new System.Drawing.Point(165, 367);
            this.textBoxCoast.Name = "textBoxCoast";
            this.textBoxCoast.ReadOnly = true;
            this.textBoxCoast.Size = new System.Drawing.Size(607, 37);
            this.textBoxCoast.TabIndex = 23;
            // 
            // clientDataSet
            // 
            this.clientDataSet.DataSetName = "clientDataSet";
            this.clientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.clientDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // roomDataSet
            // 
            this.roomDataSet.DataSetName = "roomDataSet";
            this.roomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.roomDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // RegClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Hotel.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.textBoxCoast);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonBack);
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
            this.Name = "RegClient";
            this.Text = "RegClient";
            this.Load += new System.EventHandler(this.RegClient_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignIn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.TextBox textBoxCoast;
        private clientDataSet clientDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private clientDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private roomDataSet roomDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private roomDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
    }
}