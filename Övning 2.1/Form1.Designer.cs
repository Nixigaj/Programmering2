namespace Övning_2._1
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.labelUpplösning = new System.Windows.Forms.Label();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.labelLängd = new System.Windows.Forms.Label();
            this.labelTitel = new System.Windows.Forms.Label();
            this.buttonRegistreraSpara = new System.Windows.Forms.Button();
            this.listViewBibliotek = new System.Windows.Forms.ListView();
            this.columnHeaderTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLängd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUpplösning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMedietyp = new System.Windows.Forms.GroupBox();
            this.radioButtonFilm = new System.Windows.Forms.RadioButton();
            this.radioButtonLjudspår = new System.Windows.Forms.RadioButton();
            this.radioButtonBok = new System.Windows.Forms.RadioButton();
            this.comboBoxUpplösning = new System.Windows.Forms.ComboBox();
            this.pictureBoxEJ = new System.Windows.Forms.PictureBox();
            this.pictureBoxDivider = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogga = new System.Windows.Forms.PictureBox();
            this.labelTitelTomFel = new System.Windows.Forms.Label();
            this.numericUpDownSidorLrTimmar = new System.Windows.Forms.NumericUpDown();
            this.labelTimmar = new System.Windows.Forms.Label();
            this.numericUpDownMinuter = new System.Windows.Forms.NumericUpDown();
            this.labelMinuter = new System.Windows.Forms.Label();
            this.numericUpDownSekunder = new System.Windows.Forms.NumericUpDown();
            this.labelSekunder = new System.Windows.Forms.Label();
            this.buttonRedigera = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.buttonÅngra = new System.Windows.Forms.Button();
            this.checkBoxRensa = new System.Windows.Forms.CheckBox();
            this.groupBoxMedietyp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSidorLrTimmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSekunder)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUpplösning
            // 
            this.labelUpplösning.AutoSize = true;
            this.labelUpplösning.Enabled = false;
            this.labelUpplösning.Location = new System.Drawing.Point(12, 67);
            this.labelUpplösning.Name = "labelUpplösning";
            this.labelUpplösning.Size = new System.Drawing.Size(60, 13);
            this.labelUpplösning.TabIndex = 0;
            this.labelUpplösning.Text = "Upplösning";
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(78, 12);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(120, 20);
            this.textBoxTitel.TabIndex = 4;
            // 
            // labelLängd
            // 
            this.labelLängd.AutoSize = true;
            this.labelLängd.Location = new System.Drawing.Point(12, 41);
            this.labelLängd.Name = "labelLängd";
            this.labelLängd.Size = new System.Drawing.Size(31, 13);
            this.labelLängd.TabIndex = 5;
            this.labelLängd.Text = "Sidor";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(12, 15);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(27, 13);
            this.labelTitel.TabIndex = 6;
            this.labelTitel.Text = "Titel";
            // 
            // buttonRegistreraSpara
            // 
            this.buttonRegistreraSpara.Location = new System.Drawing.Point(78, 91);
            this.buttonRegistreraSpara.Name = "buttonRegistreraSpara";
            this.buttonRegistreraSpara.Size = new System.Drawing.Size(102, 23);
            this.buttonRegistreraSpara.TabIndex = 7;
            this.buttonRegistreraSpara.Text = "Registrera bok";
            this.buttonRegistreraSpara.UseVisualStyleBackColor = true;
            this.buttonRegistreraSpara.Click += new System.EventHandler(this.buttonRegistreraSpara_Click);
            // 
            // listViewBibliotek
            // 
            this.listViewBibliotek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitel,
            this.columnHeaderTyp,
            this.columnHeaderLängd,
            this.columnHeaderUpplösning});
            this.listViewBibliotek.HideSelection = false;
            this.listViewBibliotek.Location = new System.Drawing.Point(15, 167);
            this.listViewBibliotek.Name = "listViewBibliotek";
            this.listViewBibliotek.Size = new System.Drawing.Size(244, 312);
            this.listViewBibliotek.TabIndex = 3;
            this.listViewBibliotek.UseCompatibleStateImageBehavior = false;
            this.listViewBibliotek.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitel
            // 
            this.columnHeaderTitel.Text = "Titel på mediet";
            this.columnHeaderTitel.Width = 89;
            // 
            // columnHeaderTyp
            // 
            this.columnHeaderTyp.DisplayIndex = 2;
            this.columnHeaderTyp.Text = "Typ";
            this.columnHeaderTyp.Width = 32;
            // 
            // columnHeaderLängd
            // 
            this.columnHeaderLängd.DisplayIndex = 1;
            this.columnHeaderLängd.Text = "Längd";
            // 
            // columnHeaderUpplösning
            // 
            this.columnHeaderUpplösning.Text = "Uppl.";
            this.columnHeaderUpplösning.Width = 42;
            // 
            // groupBoxMedietyp
            // 
            this.groupBoxMedietyp.Controls.Add(this.radioButtonFilm);
            this.groupBoxMedietyp.Controls.Add(this.radioButtonLjudspår);
            this.groupBoxMedietyp.Controls.Add(this.radioButtonBok);
            this.groupBoxMedietyp.Location = new System.Drawing.Point(186, 64);
            this.groupBoxMedietyp.Name = "groupBoxMedietyp";
            this.groupBoxMedietyp.Size = new System.Drawing.Size(73, 97);
            this.groupBoxMedietyp.TabIndex = 8;
            this.groupBoxMedietyp.TabStop = false;
            this.groupBoxMedietyp.Text = "Medietyp";
            // 
            // radioButtonFilm
            // 
            this.radioButtonFilm.AutoSize = true;
            this.radioButtonFilm.Location = new System.Drawing.Point(6, 65);
            this.radioButtonFilm.Name = "radioButtonFilm";
            this.radioButtonFilm.Size = new System.Drawing.Size(43, 17);
            this.radioButtonFilm.TabIndex = 5;
            this.radioButtonFilm.Text = "Film";
            this.radioButtonFilm.UseVisualStyleBackColor = true;
            this.radioButtonFilm.CheckedChanged += new System.EventHandler(this.radioButtonFilm_CheckedChanged);
            // 
            // radioButtonLjudspår
            // 
            this.radioButtonLjudspår.AutoSize = true;
            this.radioButtonLjudspår.Location = new System.Drawing.Point(6, 42);
            this.radioButtonLjudspår.Name = "radioButtonLjudspår";
            this.radioButtonLjudspår.Size = new System.Drawing.Size(65, 17);
            this.radioButtonLjudspår.TabIndex = 4;
            this.radioButtonLjudspår.Text = "Ljudspår";
            this.radioButtonLjudspår.UseVisualStyleBackColor = true;
            this.radioButtonLjudspår.CheckedChanged += new System.EventHandler(this.radioButtonLjudspår_CheckedChanged);
            // 
            // radioButtonBok
            // 
            this.radioButtonBok.AutoSize = true;
            this.radioButtonBok.Checked = true;
            this.radioButtonBok.Location = new System.Drawing.Point(6, 19);
            this.radioButtonBok.Name = "radioButtonBok";
            this.radioButtonBok.Size = new System.Drawing.Size(44, 17);
            this.radioButtonBok.TabIndex = 3;
            this.radioButtonBok.TabStop = true;
            this.radioButtonBok.Text = "Bok";
            this.radioButtonBok.UseVisualStyleBackColor = true;
            this.radioButtonBok.CheckedChanged += new System.EventHandler(this.radioButtonBok_CheckedChanged);
            // 
            // comboBoxUpplösning
            // 
            this.comboBoxUpplösning.Enabled = false;
            this.comboBoxUpplösning.FormattingEnabled = true;
            this.comboBoxUpplösning.Location = new System.Drawing.Point(78, 64);
            this.comboBoxUpplösning.Name = "comboBoxUpplösning";
            this.comboBoxUpplösning.Size = new System.Drawing.Size(102, 21);
            this.comboBoxUpplösning.TabIndex = 9;
            // 
            // pictureBoxEJ
            // 
            this.pictureBoxEJ.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEJ.Image")));
            this.pictureBoxEJ.Location = new System.Drawing.Point(146, 485);
            this.pictureBoxEJ.Name = "pictureBoxEJ";
            this.pictureBoxEJ.Size = new System.Drawing.Size(115, 22);
            this.pictureBoxEJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEJ.TabIndex = 13;
            this.pictureBoxEJ.TabStop = false;
            this.pictureBoxEJ.Click += new System.EventHandler(this.pictureBoxEJ_Click);
            // 
            // pictureBoxDivider
            // 
            this.pictureBoxDivider.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDivider.Image")));
            this.pictureBoxDivider.Location = new System.Drawing.Point(15, 120);
            this.pictureBoxDivider.Name = "pictureBoxDivider";
            this.pictureBoxDivider.Size = new System.Drawing.Size(166, 11);
            this.pictureBoxDivider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDivider.TabIndex = 12;
            this.pictureBoxDivider.TabStop = false;
            // 
            // pictureBoxLogga
            // 
            this.pictureBoxLogga.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogga.Image")));
            this.pictureBoxLogga.Location = new System.Drawing.Point(15, 137);
            this.pictureBoxLogga.Name = "pictureBoxLogga";
            this.pictureBoxLogga.Size = new System.Drawing.Size(166, 24);
            this.pictureBoxLogga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogga.TabIndex = 11;
            this.pictureBoxLogga.TabStop = false;
            // 
            // labelTitelTomFel
            // 
            this.labelTitelTomFel.AutoSize = true;
            this.labelTitelTomFel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelTitelTomFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitelTomFel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelTitelTomFel.Location = new System.Drawing.Point(79, 15);
            this.labelTitelTomFel.Name = "labelTitelTomFel";
            this.labelTitelTomFel.Size = new System.Drawing.Size(116, 13);
            this.labelTitelTomFel.TabIndex = 14;
            this.labelTitelTomFel.Text = "Får ej lämnas tomt    ❌";
            this.labelTitelTomFel.Visible = false;
            this.labelTitelTomFel.Click += new System.EventHandler(this.labelTitelTomFel_Click);
            // 
            // numericUpDownSidorLrTimmar
            // 
            this.numericUpDownSidorLrTimmar.Location = new System.Drawing.Point(78, 38);
            this.numericUpDownSidorLrTimmar.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSidorLrTimmar.Name = "numericUpDownSidorLrTimmar";
            this.numericUpDownSidorLrTimmar.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSidorLrTimmar.TabIndex = 15;
            // 
            // labelTimmar
            // 
            this.labelTimmar.AutoSize = true;
            this.labelTimmar.Enabled = false;
            this.labelTimmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimmar.Location = new System.Drawing.Point(121, 41);
            this.labelTimmar.Name = "labelTimmar";
            this.labelTimmar.Size = new System.Drawing.Size(13, 13);
            this.labelTimmar.TabIndex = 16;
            this.labelTimmar.Text = "h";
            // 
            // numericUpDownMinuter
            // 
            this.numericUpDownMinuter.Enabled = false;
            this.numericUpDownMinuter.Location = new System.Drawing.Point(140, 38);
            this.numericUpDownMinuter.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinuter.Name = "numericUpDownMinuter";
            this.numericUpDownMinuter.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMinuter.TabIndex = 17;
            // 
            // labelMinuter
            // 
            this.labelMinuter.AutoSize = true;
            this.labelMinuter.Enabled = false;
            this.labelMinuter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinuter.Location = new System.Drawing.Point(183, 41);
            this.labelMinuter.Name = "labelMinuter";
            this.labelMinuter.Size = new System.Drawing.Size(15, 13);
            this.labelMinuter.TabIndex = 18;
            this.labelMinuter.Text = "m";
            // 
            // numericUpDownSekunder
            // 
            this.numericUpDownSekunder.Enabled = false;
            this.numericUpDownSekunder.Location = new System.Drawing.Point(204, 38);
            this.numericUpDownSekunder.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSekunder.Name = "numericUpDownSekunder";
            this.numericUpDownSekunder.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSekunder.TabIndex = 19;
            // 
            // labelSekunder
            // 
            this.labelSekunder.AutoSize = true;
            this.labelSekunder.Enabled = false;
            this.labelSekunder.Location = new System.Drawing.Point(247, 41);
            this.labelSekunder.Name = "labelSekunder";
            this.labelSekunder.Size = new System.Drawing.Size(12, 13);
            this.labelSekunder.TabIndex = 20;
            this.labelSekunder.Text = "s";
            // 
            // buttonRedigera
            // 
            this.buttonRedigera.Enabled = false;
            this.buttonRedigera.Location = new System.Drawing.Point(15, 485);
            this.buttonRedigera.Name = "buttonRedigera";
            this.buttonRedigera.Size = new System.Drawing.Size(58, 21);
            this.buttonRedigera.TabIndex = 21;
            this.buttonRedigera.Text = "Redigera";
            this.buttonRedigera.UseVisualStyleBackColor = true;
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Enabled = false;
            this.buttonTaBort.Location = new System.Drawing.Point(78, 485);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(58, 21);
            this.buttonTaBort.TabIndex = 22;
            this.buttonTaBort.Text = "Ta bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            // 
            // buttonÅngra
            // 
            this.buttonÅngra.Enabled = false;
            this.buttonÅngra.Location = new System.Drawing.Point(15, 91);
            this.buttonÅngra.Name = "buttonÅngra";
            this.buttonÅngra.Size = new System.Drawing.Size(57, 23);
            this.buttonÅngra.TabIndex = 23;
            this.buttonÅngra.Text = "Ångra";
            this.buttonÅngra.UseVisualStyleBackColor = true;
            // 
            // checkBoxRensa
            // 
            this.checkBoxRensa.AutoSize = true;
            this.checkBoxRensa.Checked = true;
            this.checkBoxRensa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRensa.Location = new System.Drawing.Point(204, 14);
            this.checkBoxRensa.Name = "checkBoxRensa";
            this.checkBoxRensa.Size = new System.Drawing.Size(57, 17);
            this.checkBoxRensa.TabIndex = 24;
            this.checkBoxRensa.Text = "Rensa";
            this.checkBoxRensa.UseVisualStyleBackColor = true;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 515);
            this.Controls.Add(this.checkBoxRensa);
            this.Controls.Add(this.buttonÅngra);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.buttonRedigera);
            this.Controls.Add(this.labelSekunder);
            this.Controls.Add(this.numericUpDownSekunder);
            this.Controls.Add(this.labelMinuter);
            this.Controls.Add(this.numericUpDownMinuter);
            this.Controls.Add(this.labelTimmar);
            this.Controls.Add(this.numericUpDownSidorLrTimmar);
            this.Controls.Add(this.labelTitelTomFel);
            this.Controls.Add(this.pictureBoxEJ);
            this.Controls.Add(this.pictureBoxDivider);
            this.Controls.Add(this.pictureBoxLogga);
            this.Controls.Add(this.buttonRegistreraSpara);
            this.Controls.Add(this.comboBoxUpplösning);
            this.Controls.Add(this.groupBoxMedietyp);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.labelLängd);
            this.Controls.Add(this.listViewBibliotek);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.labelUpplösning);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.Text = "Biblioteket";
            this.groupBoxMedietyp.ResumeLayout(false);
            this.groupBoxMedietyp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSidorLrTimmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSekunder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.Label labelUpplösning;
        private System.Windows.Forms.Button buttonRegistreraSpara;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelLängd;
        private System.Windows.Forms.ListView listViewBibliotek;
        private System.Windows.Forms.ColumnHeader columnHeaderTitel;
        private System.Windows.Forms.ColumnHeader columnHeaderLängd;
        private System.Windows.Forms.GroupBox groupBoxMedietyp;
        private System.Windows.Forms.ComboBox comboBoxUpplösning;
        private System.Windows.Forms.RadioButton radioButtonFilm;
        private System.Windows.Forms.RadioButton radioButtonLjudspår;
        private System.Windows.Forms.RadioButton radioButtonBok;
        private System.Windows.Forms.PictureBox pictureBoxLogga;
        private System.Windows.Forms.PictureBox pictureBoxDivider;
        private System.Windows.Forms.PictureBox pictureBoxEJ;
        private System.Windows.Forms.Label labelTitelTomFel;
        private System.Windows.Forms.NumericUpDown numericUpDownSidorLrTimmar;
        private System.Windows.Forms.Label labelTimmar;
        private System.Windows.Forms.NumericUpDown numericUpDownMinuter;
        private System.Windows.Forms.Label labelMinuter;
        private System.Windows.Forms.NumericUpDown numericUpDownSekunder;
        private System.Windows.Forms.Label labelSekunder;
        private System.Windows.Forms.Button buttonRedigera;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Button buttonÅngra;
        private System.Windows.Forms.ColumnHeader columnHeaderTyp;
        private System.Windows.Forms.ColumnHeader columnHeaderUpplösning;
        private System.Windows.Forms.CheckBox checkBoxRensa;
    }
}

