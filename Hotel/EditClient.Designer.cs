namespace Hotel
{
    partial class EditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClient));
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPatr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
            this.clientPasDataSet = new Hotel.ClientPasDataSet();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter1 = new Hotel.ClientPasDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
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
            // buttonEdit
            // 
            this.buttonEdit.BackColor = global::Hotel.Properties.Settings.Default.AccientColor;
            this.buttonEdit.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Hotel.Properties.Settings.Default, "AccientColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEdit.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "MainFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEdit.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Hotel.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = global::Hotel.Properties.Settings.Default.MainFont;
            this.buttonEdit.ForeColor = global::Hotel.Properties.Settings.Default.FontColor;
            this.buttonEdit.Location = new System.Drawing.Point(137, 480);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(319, 42);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Редактировать клиента";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Паспорт";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(137, 423);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(633, 37);
            this.textBoxNumber.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Номер";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(137, 369);
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(633, 37);
            this.textBoxSeries.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Серия";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPatr
            // 
            this.textBoxPatr.Location = new System.Drawing.Point(137, 280);
            this.textBoxPatr.Name = "textBoxPatr";
            this.textBoxPatr.Size = new System.Drawing.Size(633, 37);
            this.textBoxPatr.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Отчество";
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
            this.backButton.Location = new System.Drawing.Point(479, 480);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 42);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(137, 224);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(633, 37);
            this.textBoxLname.TabIndex = 27;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(137, 165);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(633, 37);
            this.textBoxFname.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Фамилия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Имя";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Hotel.Properties.Settings.Default, "HeaderFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::Hotel.Properties.Settings.Default.HeaderFont;
            this.label1.Location = new System.Drawing.Point(86, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 59);
            this.label1.TabIndex = 22;
            this.label1.Text = "Редактирование клиента";
            // 
            // comboBoxEdit
            // 
            this.comboBoxEdit.DataSource = this.clientBindingSource1;
            this.comboBoxEdit.DisplayMember = "SecondName";
            this.comboBoxEdit.FormattingEnabled = true;
            this.comboBoxEdit.Location = new System.Drawing.Point(74, 106);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Size = new System.Drawing.Size(659, 37);
            this.comboBoxEdit.TabIndex = 38;
            this.comboBoxEdit.ValueMember = "Id_Client";
            this.comboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientPasDataSet
            // 
            this.clientPasDataSet.DataSetName = "ClientPasDataSet";
            this.clientPasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.clientPasDataSet;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Hotel.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.comboBoxEdit);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPatr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Name = "EditClient";
            this.Text = "EditClient";
            this.Load += new System.EventHandler(this.EditClient_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignIn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPatr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private ClientPasDataSet clientPasDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private ClientPasDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
    }
}