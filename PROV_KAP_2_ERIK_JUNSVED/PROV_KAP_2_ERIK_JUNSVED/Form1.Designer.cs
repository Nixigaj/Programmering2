namespace PROV_KAP_2_ERIK_JUNSVED
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRadie = new System.Windows.Forms.TextBox();
            this.buttonAddCirkel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxHöjd = new System.Windows.Forms.TextBox();
            this.textBoxBredd = new System.Windows.Forms.TextBox();
            this.buttonAddRektangel = new System.Windows.Forms.Button();
            this.labelHöjd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSida = new System.Windows.Forms.TextBox();
            this.buttonAddKvadrat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonCirklar = new System.Windows.Forms.RadioButton();
            this.radioButtonRektanglar = new System.Windows.Forms.RadioButton();
            this.radioButtonAllaFig = new System.Windows.Forms.RadioButton();
            this.listBoxFigurbank = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSortera = new System.Windows.Forms.Button();
            this.buttonTaBortAlla = new System.Windows.Forms.Button();
            this.buttonBeräknaTotalOmkrets = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRadie);
            this.groupBox1.Controls.Add(this.buttonAddCirkel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cirkel";
            // 
            // textBoxRadie
            // 
            this.textBoxRadie.Location = new System.Drawing.Point(74, 19);
            this.textBoxRadie.Name = "textBoxRadie";
            this.textBoxRadie.Size = new System.Drawing.Size(120, 20);
            this.textBoxRadie.TabIndex = 4;
            // 
            // buttonAddCirkel
            // 
            this.buttonAddCirkel.Location = new System.Drawing.Point(74, 45);
            this.buttonAddCirkel.Name = "buttonAddCirkel";
            this.buttonAddCirkel.Size = new System.Drawing.Size(120, 23);
            this.buttonAddCirkel.TabIndex = 3;
            this.buttonAddCirkel.Text = "Lägg till cirkel";
            this.buttonAddCirkel.UseVisualStyleBackColor = true;
            this.buttonAddCirkel.Click += new System.EventHandler(this.ButtonAddCirkel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radie";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxHöjd);
            this.groupBox2.Controls.Add(this.textBoxBredd);
            this.groupBox2.Controls.Add(this.buttonAddRektangel);
            this.groupBox2.Controls.Add(this.labelHöjd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rektangel";
            // 
            // textBoxHöjd
            // 
            this.textBoxHöjd.Location = new System.Drawing.Point(74, 45);
            this.textBoxHöjd.Name = "textBoxHöjd";
            this.textBoxHöjd.Size = new System.Drawing.Size(120, 20);
            this.textBoxHöjd.TabIndex = 6;
            // 
            // textBoxBredd
            // 
            this.textBoxBredd.Location = new System.Drawing.Point(74, 18);
            this.textBoxBredd.Name = "textBoxBredd";
            this.textBoxBredd.Size = new System.Drawing.Size(120, 20);
            this.textBoxBredd.TabIndex = 5;
            // 
            // buttonAddRektangel
            // 
            this.buttonAddRektangel.Location = new System.Drawing.Point(74, 71);
            this.buttonAddRektangel.Name = "buttonAddRektangel";
            this.buttonAddRektangel.Size = new System.Drawing.Size(120, 23);
            this.buttonAddRektangel.TabIndex = 4;
            this.buttonAddRektangel.Text = "Lägg till rektangel";
            this.buttonAddRektangel.UseVisualStyleBackColor = true;
            this.buttonAddRektangel.Click += new System.EventHandler(this.ButtonAddRektangel_Click);
            // 
            // labelHöjd
            // 
            this.labelHöjd.AutoSize = true;
            this.labelHöjd.Location = new System.Drawing.Point(6, 48);
            this.labelHöjd.Name = "labelHöjd";
            this.labelHöjd.Size = new System.Drawing.Size(29, 13);
            this.labelHöjd.TabIndex = 3;
            this.labelHöjd.Text = "Höjd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bredd";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSida);
            this.groupBox3.Controls.Add(this.buttonAddKvadrat);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(13, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kvadrat";
            // 
            // textBoxSida
            // 
            this.textBoxSida.Location = new System.Drawing.Point(74, 19);
            this.textBoxSida.Name = "textBoxSida";
            this.textBoxSida.Size = new System.Drawing.Size(120, 20);
            this.textBoxSida.TabIndex = 7;
            // 
            // buttonAddKvadrat
            // 
            this.buttonAddKvadrat.Location = new System.Drawing.Point(74, 46);
            this.buttonAddKvadrat.Name = "buttonAddKvadrat";
            this.buttonAddKvadrat.Size = new System.Drawing.Size(120, 23);
            this.buttonAddKvadrat.TabIndex = 2;
            this.buttonAddKvadrat.Text = "Lägg till kvadrat";
            this.buttonAddKvadrat.UseVisualStyleBackColor = true;
            this.buttonAddKvadrat.Click += new System.EventHandler(this.ButtonAddKvadrat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sida";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonCirklar);
            this.groupBox4.Controls.Add(this.radioButtonRektanglar);
            this.groupBox4.Controls.Add(this.radioButtonAllaFig);
            this.groupBox4.Location = new System.Drawing.Point(239, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visa";
            // 
            // radioButtonCirklar
            // 
            this.radioButtonCirklar.AutoSize = true;
            this.radioButtonCirklar.Location = new System.Drawing.Point(7, 42);
            this.radioButtonCirklar.Name = "radioButtonCirklar";
            this.radioButtonCirklar.Size = new System.Drawing.Size(54, 17);
            this.radioButtonCirklar.TabIndex = 2;
            this.radioButtonCirklar.TabStop = true;
            this.radioButtonCirklar.Text = "Cirklar";
            this.radioButtonCirklar.UseVisualStyleBackColor = true;
            // 
            // radioButtonRektanglar
            // 
            this.radioButtonRektanglar.AutoSize = true;
            this.radioButtonRektanglar.Location = new System.Drawing.Point(7, 65);
            this.radioButtonRektanglar.Name = "radioButtonRektanglar";
            this.radioButtonRektanglar.Size = new System.Drawing.Size(77, 17);
            this.radioButtonRektanglar.TabIndex = 1;
            this.radioButtonRektanglar.TabStop = true;
            this.radioButtonRektanglar.Text = "Rektanglar";
            this.radioButtonRektanglar.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllaFig
            // 
            this.radioButtonAllaFig.AutoSize = true;
            this.radioButtonAllaFig.Location = new System.Drawing.Point(7, 19);
            this.radioButtonAllaFig.Name = "radioButtonAllaFig";
            this.radioButtonAllaFig.Size = new System.Drawing.Size(74, 17);
            this.radioButtonAllaFig.TabIndex = 0;
            this.radioButtonAllaFig.TabStop = true;
            this.radioButtonAllaFig.Text = "Alla figurer";
            this.radioButtonAllaFig.UseVisualStyleBackColor = true;
            // 
            // listBoxFigurbank
            // 
            this.listBoxFigurbank.FormattingEnabled = true;
            this.listBoxFigurbank.Location = new System.Drawing.Point(239, 31);
            this.listBoxFigurbank.Name = "listBoxFigurbank";
            this.listBoxFigurbank.Size = new System.Drawing.Size(549, 186);
            this.listBoxFigurbank.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FIGURBANK";
            // 
            // buttonSortera
            // 
            this.buttonSortera.Location = new System.Drawing.Point(461, 225);
            this.buttonSortera.Name = "buttonSortera";
            this.buttonSortera.Size = new System.Drawing.Size(327, 23);
            this.buttonSortera.TabIndex = 6;
            this.buttonSortera.Text = "Sortera figurer";
            this.buttonSortera.UseVisualStyleBackColor = true;
            // 
            // buttonTaBortAlla
            // 
            this.buttonTaBortAlla.Location = new System.Drawing.Point(461, 254);
            this.buttonTaBortAlla.Name = "buttonTaBortAlla";
            this.buttonTaBortAlla.Size = new System.Drawing.Size(327, 23);
            this.buttonTaBortAlla.TabIndex = 7;
            this.buttonTaBortAlla.Text = "Ta bort alla figurer";
            this.buttonTaBortAlla.UseVisualStyleBackColor = true;
            // 
            // buttonBeräknaTotalOmkrets
            // 
            this.buttonBeräknaTotalOmkrets.Location = new System.Drawing.Point(461, 283);
            this.buttonBeräknaTotalOmkrets.Name = "buttonBeräknaTotalOmkrets";
            this.buttonBeräknaTotalOmkrets.Size = new System.Drawing.Size(327, 23);
            this.buttonBeräknaTotalOmkrets.TabIndex = 8;
            this.buttonBeräknaTotalOmkrets.Text = "Total omkrets";
            this.buttonBeräknaTotalOmkrets.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.buttonBeräknaTotalOmkrets);
            this.Controls.Add(this.buttonTaBortAlla);
            this.Controls.Add(this.buttonSortera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFigurbank);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonCirklar;
        private System.Windows.Forms.RadioButton radioButtonRektanglar;
        private System.Windows.Forms.RadioButton radioButtonAllaFig;
        private System.Windows.Forms.ListBox listBoxFigurbank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSortera;
        private System.Windows.Forms.Button buttonTaBortAlla;
        private System.Windows.Forms.Button buttonBeräknaTotalOmkrets;
        private System.Windows.Forms.Label labelHöjd;
        private System.Windows.Forms.Button buttonAddCirkel;
        private System.Windows.Forms.Button buttonAddRektangel;
        private System.Windows.Forms.Button buttonAddKvadrat;
        private System.Windows.Forms.TextBox textBoxRadie;
        private System.Windows.Forms.TextBox textBoxHöjd;
        private System.Windows.Forms.TextBox textBoxBredd;
        private System.Windows.Forms.TextBox textBoxSida;
    }
}

