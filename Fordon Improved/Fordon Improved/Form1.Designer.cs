namespace Fordon_Improved
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regNrBox = new System.Windows.Forms.TextBox();
            this.märkeBox = new System.Windows.Forms.TextBox();
            this.modellBox = new System.Windows.Forms.TextBox();
            this.typComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registreraButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.visaMCButton = new System.Windows.Forms.RadioButton();
            this.visaBilarButton = new System.Windows.Forms.RadioButton();
            this.visaAllaButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ångraButton = new System.Windows.Forms.Button();
            this.listViewRegister = new System.Windows.Forms.ListView();
            this.columnRegNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMärke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.buttonÄndra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // regNrBox
            // 
            this.regNrBox.Location = new System.Drawing.Point(58, 86);
            this.regNrBox.Name = "regNrBox";
            this.regNrBox.Size = new System.Drawing.Size(100, 20);
            this.regNrBox.TabIndex = 2;
            // 
            // märkeBox
            // 
            this.märkeBox.Location = new System.Drawing.Point(58, 112);
            this.märkeBox.Name = "märkeBox";
            this.märkeBox.Size = new System.Drawing.Size(100, 20);
            this.märkeBox.TabIndex = 3;
            // 
            // modellBox
            // 
            this.modellBox.Location = new System.Drawing.Point(58, 138);
            this.modellBox.Name = "modellBox";
            this.modellBox.Size = new System.Drawing.Size(100, 20);
            this.modellBox.TabIndex = 4;
            // 
            // typComboBox
            // 
            this.typComboBox.FormattingEnabled = true;
            this.typComboBox.Location = new System.Drawing.Point(58, 164);
            this.typComboBox.Name = "typComboBox";
            this.typComboBox.Size = new System.Drawing.Size(100, 21);
            this.typComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reg-nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Märke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Typ";
            // 
            // registreraButton
            // 
            this.registreraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registreraButton.Location = new System.Drawing.Point(58, 192);
            this.registreraButton.Name = "registreraButton";
            this.registreraButton.Size = new System.Drawing.Size(100, 46);
            this.registreraButton.TabIndex = 10;
            this.registreraButton.Text = "Registrera";
            this.registreraButton.UseVisualStyleBackColor = true;
            this.registreraButton.Click += new System.EventHandler(this.registreraButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.visaMCButton);
            this.groupBox1.Controls.Add(this.visaBilarButton);
            this.groupBox1.Controls.Add(this.visaAllaButton);
            this.groupBox1.Location = new System.Drawing.Point(181, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(41, 151);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visa";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Alla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "MC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bilar";
            // 
            // visaMCButton
            // 
            this.visaMCButton.AutoSize = true;
            this.visaMCButton.Location = new System.Drawing.Point(9, 119);
            this.visaMCButton.Name = "visaMCButton";
            this.visaMCButton.Size = new System.Drawing.Size(14, 13);
            this.visaMCButton.TabIndex = 2;
            this.visaMCButton.TabStop = true;
            this.visaMCButton.UseVisualStyleBackColor = true;
            this.visaMCButton.CheckedChanged += new System.EventHandler(this.VisaMCButton_CheckedChanged);
            // 
            // visaBilarButton
            // 
            this.visaBilarButton.AutoSize = true;
            this.visaBilarButton.Location = new System.Drawing.Point(9, 69);
            this.visaBilarButton.Name = "visaBilarButton";
            this.visaBilarButton.Size = new System.Drawing.Size(14, 13);
            this.visaBilarButton.TabIndex = 1;
            this.visaBilarButton.TabStop = true;
            this.visaBilarButton.UseVisualStyleBackColor = true;
            this.visaBilarButton.CheckedChanged += new System.EventHandler(this.VisaBilarButton_CheckedChanged);
            // 
            // visaAllaButton
            // 
            this.visaAllaButton.AutoSize = true;
            this.visaAllaButton.Checked = true;
            this.visaAllaButton.Location = new System.Drawing.Point(9, 19);
            this.visaAllaButton.Name = "visaAllaButton";
            this.visaAllaButton.Size = new System.Drawing.Size(14, 13);
            this.visaAllaButton.TabIndex = 0;
            this.visaAllaButton.TabStop = true;
            this.visaAllaButton.UseVisualStyleBackColor = true;
            this.visaAllaButton.CheckedChanged += new System.EventHandler(this.VisaAllaButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Register";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(9, 67);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(82, 13);
            this.errorMessageLabel.TabIndex = 15;
            this.errorMessageLabel.Text = "Felmeddelande:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(414, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // ångraButton
            // 
            this.ångraButton.Location = new System.Drawing.Point(395, 78);
            this.ångraButton.Name = "ångraButton";
            this.ångraButton.Size = new System.Drawing.Size(49, 22);
            this.ångraButton.TabIndex = 19;
            this.ångraButton.Text = "Ångra";
            this.ångraButton.UseVisualStyleBackColor = true;
            this.ångraButton.Click += new System.EventHandler(this.ÅngraButton_Click);
            // 
            // listViewRegister
            // 
            this.listViewRegister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRegNr,
            this.columnMärke,
            this.columnModell,
            this.columnTyp});
            this.listViewRegister.HideSelection = false;
            this.listViewRegister.Location = new System.Drawing.Point(231, 106);
            this.listViewRegister.Name = "listViewRegister";
            this.listViewRegister.Size = new System.Drawing.Size(213, 132);
            this.listViewRegister.TabIndex = 20;
            this.listViewRegister.UseCompatibleStateImageBehavior = false;
            this.listViewRegister.View = System.Windows.Forms.View.Details;
            // 
            // columnRegNr
            // 
            this.columnRegNr.Text = "Reg-Nr";
            this.columnRegNr.Width = 49;
            // 
            // columnMärke
            // 
            this.columnMärke.Text = "Märke";
            this.columnMärke.Width = 65;
            // 
            // columnModell
            // 
            this.columnModell.Text = "Modell";
            this.columnModell.Width = 65;
            // 
            // columnTyp
            // 
            this.columnTyp.Text = "Typ";
            this.columnTyp.Width = 30;
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(340, 78);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(49, 22);
            this.buttonTaBort.TabIndex = 21;
            this.buttonTaBort.Text = "Ta bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            // 
            // buttonÄndra
            // 
            this.buttonÄndra.Location = new System.Drawing.Point(285, 78);
            this.buttonÄndra.Name = "buttonÄndra";
            this.buttonÄndra.Size = new System.Drawing.Size(49, 22);
            this.buttonÄndra.TabIndex = 22;
            this.buttonÄndra.Text = "Ändra";
            this.buttonÄndra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 253);
            this.Controls.Add(this.buttonÄndra);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.listViewRegister);
            this.Controls.Add(this.ångraButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registreraButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typComboBox);
            this.Controls.Add(this.modellBox);
            this.Controls.Add(this.märkeBox);
            this.Controls.Add(this.regNrBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox regNrBox;
        private System.Windows.Forms.TextBox märkeBox;
        private System.Windows.Forms.TextBox modellBox;
        private System.Windows.Forms.ComboBox typComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registreraButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton visaMCButton;
        private System.Windows.Forms.RadioButton visaBilarButton;
        private System.Windows.Forms.RadioButton visaAllaButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ångraButton;
        private System.Windows.Forms.ListView listViewRegister;
        private System.Windows.Forms.ColumnHeader columnRegNr;
        private System.Windows.Forms.ColumnHeader columnMärke;
        private System.Windows.Forms.ColumnHeader columnModell;
        private System.Windows.Forms.ColumnHeader columnTyp;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Button buttonÄndra;
    }
}

