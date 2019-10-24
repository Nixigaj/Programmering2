namespace Övning_2._8
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
            this.listViewInköpslista = new System.Windows.Forms.ListView();
            this.labelVara = new System.Windows.Forms.Label();
            this.labelPris = new System.Windows.Forms.Label();
            this.labelMängd = new System.Windows.Forms.Label();
            this.groupBoxVarutyp = new System.Windows.Forms.GroupBox();
            this.radioButtonStycksak = new System.Windows.Forms.RadioButton();
            this.radioButtonLösvikt = new System.Windows.Forms.RadioButton();
            this.buttonLäggTill = new System.Windows.Forms.Button();
            this.labelSumma = new System.Windows.Forms.Label();
            this.textBoxSumma = new System.Windows.Forms.TextBox();
            this.textBoxVara = new System.Windows.Forms.TextBox();
            this.textBoxPris = new System.Windows.Forms.TextBox();
            this.textBoxMängd = new System.Windows.Forms.TextBox();
            this.columnHeaderVara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAntal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEnkelpris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxVarutyp.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewInköpslista
            // 
            this.listViewInköpslista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewInköpslista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAntal,
            this.columnHeaderVara,
            this.columnHeaderTyp,
            this.columnHeaderEnkelpris,
            this.columnHeaderPris});
            this.listViewInköpslista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewInköpslista.Location = new System.Drawing.Point(246, 17);
            this.listViewInköpslista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewInköpslista.Name = "listViewInköpslista";
            this.listViewInköpslista.Size = new System.Drawing.Size(460, 568);
            this.listViewInköpslista.TabIndex = 0;
            this.listViewInköpslista.UseCompatibleStateImageBehavior = false;
            this.listViewInköpslista.View = System.Windows.Forms.View.Details;
            // 
            // labelVara
            // 
            this.labelVara.AutoSize = true;
            this.labelVara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVara.Location = new System.Drawing.Point(18, 21);
            this.labelVara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVara.Name = "labelVara";
            this.labelVara.Size = new System.Drawing.Size(38, 18);
            this.labelVara.TabIndex = 1;
            this.labelVara.Text = "Vara";
            // 
            // labelPris
            // 
            this.labelPris.AutoSize = true;
            this.labelPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPris.Location = new System.Drawing.Point(18, 57);
            this.labelPris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPris.Name = "labelPris";
            this.labelPris.Size = new System.Drawing.Size(34, 18);
            this.labelPris.TabIndex = 2;
            this.labelPris.Text = "Pris";
            // 
            // labelMängd
            // 
            this.labelMängd.AutoSize = true;
            this.labelMängd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMängd.Location = new System.Drawing.Point(18, 93);
            this.labelMängd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMängd.Name = "labelMängd";
            this.labelMängd.Size = new System.Drawing.Size(53, 18);
            this.labelMängd.TabIndex = 3;
            this.labelMängd.Text = "Mängd";
            // 
            // groupBoxVarutyp
            // 
            this.groupBoxVarutyp.Controls.Add(this.radioButtonStycksak);
            this.groupBoxVarutyp.Controls.Add(this.radioButtonLösvikt);
            this.groupBoxVarutyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVarutyp.Location = new System.Drawing.Point(87, 125);
            this.groupBoxVarutyp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVarutyp.Name = "groupBoxVarutyp";
            this.groupBoxVarutyp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVarutyp.Size = new System.Drawing.Size(150, 93);
            this.groupBoxVarutyp.TabIndex = 4;
            this.groupBoxVarutyp.TabStop = false;
            this.groupBoxVarutyp.Text = "Varutyp";
            // 
            // radioButtonStycksak
            // 
            this.radioButtonStycksak.AutoSize = true;
            this.radioButtonStycksak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStycksak.Location = new System.Drawing.Point(9, 58);
            this.radioButtonStycksak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonStycksak.Name = "radioButtonStycksak";
            this.radioButtonStycksak.Size = new System.Drawing.Size(87, 22);
            this.radioButtonStycksak.TabIndex = 1;
            this.radioButtonStycksak.Text = "Stycksak";
            this.radioButtonStycksak.UseVisualStyleBackColor = true;
            // 
            // radioButtonLösvikt
            // 
            this.radioButtonLösvikt.AutoSize = true;
            this.radioButtonLösvikt.Checked = true;
            this.radioButtonLösvikt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLösvikt.Location = new System.Drawing.Point(9, 26);
            this.radioButtonLösvikt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonLösvikt.Name = "radioButtonLösvikt";
            this.radioButtonLösvikt.Size = new System.Drawing.Size(73, 22);
            this.radioButtonLösvikt.TabIndex = 0;
            this.radioButtonLösvikt.TabStop = true;
            this.radioButtonLösvikt.Text = "Lösvikt";
            this.radioButtonLösvikt.UseVisualStyleBackColor = true;
            // 
            // buttonLäggTill
            // 
            this.buttonLäggTill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLäggTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLäggTill.Location = new System.Drawing.Point(18, 590);
            this.buttonLäggTill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLäggTill.Name = "buttonLäggTill";
            this.buttonLäggTill.Size = new System.Drawing.Size(112, 32);
            this.buttonLäggTill.TabIndex = 5;
            this.buttonLäggTill.Text = "Lägg till";
            this.buttonLäggTill.UseVisualStyleBackColor = true;
            // 
            // labelSumma
            // 
            this.labelSumma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumma.AutoSize = true;
            this.labelSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumma.Location = new System.Drawing.Point(454, 598);
            this.labelSumma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSumma.Name = "labelSumma";
            this.labelSumma.Size = new System.Drawing.Size(91, 18);
            this.labelSumma.TabIndex = 6;
            this.labelSumma.Text = "Summa (kr):";
            // 
            // textBoxSumma
            // 
            this.textBoxSumma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSumma.Location = new System.Drawing.Point(558, 594);
            this.textBoxSumma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSumma.Name = "textBoxSumma";
            this.textBoxSumma.ReadOnly = true;
            this.textBoxSumma.Size = new System.Drawing.Size(148, 24);
            this.textBoxSumma.TabIndex = 7;
            // 
            // textBoxVara
            // 
            this.textBoxVara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVara.Location = new System.Drawing.Point(87, 17);
            this.textBoxVara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxVara.Name = "textBoxVara";
            this.textBoxVara.Size = new System.Drawing.Size(148, 24);
            this.textBoxVara.TabIndex = 8;
            // 
            // textBoxPris
            // 
            this.textBoxPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPris.Location = new System.Drawing.Point(87, 53);
            this.textBoxPris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPris.Name = "textBoxPris";
            this.textBoxPris.Size = new System.Drawing.Size(148, 24);
            this.textBoxPris.TabIndex = 9;
            // 
            // textBoxMängd
            // 
            this.textBoxMängd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMängd.Location = new System.Drawing.Point(87, 89);
            this.textBoxMängd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMängd.Name = "textBoxMängd";
            this.textBoxMängd.Size = new System.Drawing.Size(148, 24);
            this.textBoxMängd.TabIndex = 10;
            // 
            // columnHeaderVara
            // 
            this.columnHeaderVara.Text = "Vara";
            this.columnHeaderVara.Width = 172;
            // 
            // columnHeaderTyp
            // 
            this.columnHeaderTyp.Text = "Typ";
            this.columnHeaderTyp.Width = 78;
            // 
            // columnHeaderAntal
            // 
            this.columnHeaderAntal.Text = "Antal";
            this.columnHeaderAntal.Width = 63;
            // 
            // columnHeaderEnkelpris
            // 
            this.columnHeaderEnkelpris.Text = "Enkelpris";
            this.columnHeaderEnkelpris.Width = 73;
            // 
            // columnHeaderPris
            // 
            this.columnHeaderPris.Text = "Pris";
            this.columnHeaderPris.Width = 69;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 638);
            this.Controls.Add(this.textBoxMängd);
            this.Controls.Add(this.textBoxPris);
            this.Controls.Add(this.textBoxVara);
            this.Controls.Add(this.textBoxSumma);
            this.Controls.Add(this.labelSumma);
            this.Controls.Add(this.buttonLäggTill);
            this.Controls.Add(this.groupBoxVarutyp);
            this.Controls.Add(this.labelMängd);
            this.Controls.Add(this.labelPris);
            this.Controls.Add(this.labelVara);
            this.Controls.Add(this.listViewInköpslista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(440, 320);
            this.Name = "FormStart";
            this.Text = "Inköpslistan";
            this.groupBoxVarutyp.ResumeLayout(false);
            this.groupBoxVarutyp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewInköpslista;
        private System.Windows.Forms.Label labelVara;
        private System.Windows.Forms.Label labelPris;
        private System.Windows.Forms.Label labelMängd;
        private System.Windows.Forms.GroupBox groupBoxVarutyp;
        private System.Windows.Forms.RadioButton radioButtonStycksak;
        private System.Windows.Forms.RadioButton radioButtonLösvikt;
        private System.Windows.Forms.Button buttonLäggTill;
        private System.Windows.Forms.Label labelSumma;
        private System.Windows.Forms.TextBox textBoxSumma;
        private System.Windows.Forms.TextBox textBoxVara;
        private System.Windows.Forms.TextBox textBoxPris;
        private System.Windows.Forms.TextBox textBoxMängd;
        private System.Windows.Forms.ColumnHeader columnHeaderAntal;
        private System.Windows.Forms.ColumnHeader columnHeaderVara;
        private System.Windows.Forms.ColumnHeader columnHeaderTyp;
        private System.Windows.Forms.ColumnHeader columnHeaderEnkelpris;
        private System.Windows.Forms.ColumnHeader columnHeaderPris;
    }
}

