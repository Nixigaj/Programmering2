namespace PROV_KAP_1_ERIK_JUNSVED
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxObjektnummer = new System.Windows.Forms.TextBox();
            this.tbxBoyta = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.cbxBostadstyp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxBostäder = new System.Windows.Forms.ListBox();
            this.buttonLäggTill = new System.Windows.Forms.Button();
            this.buttonÅngra = new System.Windows.Forms.Button();
            this.buttonVisaAlla = new System.Windows.Forms.Button();
            this.buttonVisaLägenheter = new System.Windows.Forms.Button();
            this.buttonHögstPrisPerKVM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Objektnummer";
            // 
            // tbxObjektnummer
            // 
            this.tbxObjektnummer.Location = new System.Drawing.Point(95, 13);
            this.tbxObjektnummer.Name = "tbxObjektnummer";
            this.tbxObjektnummer.Size = new System.Drawing.Size(121, 20);
            this.tbxObjektnummer.TabIndex = 1;
            // 
            // tbxBoyta
            // 
            this.tbxBoyta.Location = new System.Drawing.Point(95, 40);
            this.tbxBoyta.Name = "tbxBoyta";
            this.tbxBoyta.Size = new System.Drawing.Size(121, 20);
            this.tbxBoyta.TabIndex = 2;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(95, 67);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(121, 20);
            this.tbxPris.TabIndex = 3;
            // 
            // cbxBostadstyp
            // 
            this.cbxBostadstyp.FormattingEnabled = true;
            this.cbxBostadstyp.Location = new System.Drawing.Point(95, 94);
            this.cbxBostadstyp.Name = "cbxBostadstyp";
            this.cbxBostadstyp.Size = new System.Drawing.Size(121, 21);
            this.cbxBostadstyp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boyta (KVM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pris (SEK)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bostadstyp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bostäder till salu:";
            // 
            // lbxBostäder
            // 
            this.lbxBostäder.FormattingEnabled = true;
            this.lbxBostäder.Location = new System.Drawing.Point(223, 33);
            this.lbxBostäder.Name = "lbxBostäder";
            this.lbxBostäder.Size = new System.Drawing.Size(322, 82);
            this.lbxBostäder.TabIndex = 9;
            // 
            // buttonLäggTill
            // 
            this.buttonLäggTill.Location = new System.Drawing.Point(15, 121);
            this.buttonLäggTill.Name = "buttonLäggTill";
            this.buttonLäggTill.Size = new System.Drawing.Size(201, 23);
            this.buttonLäggTill.TabIndex = 10;
            this.buttonLäggTill.Text = "Lägg till objekt";
            this.buttonLäggTill.UseVisualStyleBackColor = true;
            this.buttonLäggTill.Click += new System.EventHandler(this.ButtonLäggTill_Click);
            // 
            // buttonÅngra
            // 
            this.buttonÅngra.Location = new System.Drawing.Point(15, 151);
            this.buttonÅngra.Name = "buttonÅngra";
            this.buttonÅngra.Size = new System.Drawing.Size(201, 23);
            this.buttonÅngra.TabIndex = 11;
            this.buttonÅngra.Text = "Ångra";
            this.buttonÅngra.UseVisualStyleBackColor = true;
            // 
            // buttonVisaAlla
            // 
            this.buttonVisaAlla.Location = new System.Drawing.Point(222, 121);
            this.buttonVisaAlla.Name = "buttonVisaAlla";
            this.buttonVisaAlla.Size = new System.Drawing.Size(161, 23);
            this.buttonVisaAlla.TabIndex = 12;
            this.buttonVisaAlla.Text = "Visa alla";
            this.buttonVisaAlla.UseVisualStyleBackColor = true;
            // 
            // buttonVisaLägenheter
            // 
            this.buttonVisaLägenheter.Location = new System.Drawing.Point(389, 121);
            this.buttonVisaLägenheter.Name = "buttonVisaLägenheter";
            this.buttonVisaLägenheter.Size = new System.Drawing.Size(156, 23);
            this.buttonVisaLägenheter.TabIndex = 13;
            this.buttonVisaLägenheter.Text = "Visa lägenheter";
            this.buttonVisaLägenheter.UseVisualStyleBackColor = true;
            // 
            // buttonHögstPrisPerKVM
            // 
            this.buttonHögstPrisPerKVM.Location = new System.Drawing.Point(223, 151);
            this.buttonHögstPrisPerKVM.Name = "buttonHögstPrisPerKVM";
            this.buttonHögstPrisPerKVM.Size = new System.Drawing.Size(322, 23);
            this.buttonHögstPrisPerKVM.TabIndex = 14;
            this.buttonHögstPrisPerKVM.Text = "Högst pris per kvadratmeter";
            this.buttonHögstPrisPerKVM.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 187);
            this.Controls.Add(this.buttonHögstPrisPerKVM);
            this.Controls.Add(this.buttonVisaLägenheter);
            this.Controls.Add(this.buttonVisaAlla);
            this.Controls.Add(this.buttonÅngra);
            this.Controls.Add(this.buttonLäggTill);
            this.Controls.Add(this.lbxBostäder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxBostadstyp);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.tbxBoyta);
            this.Controls.Add(this.tbxObjektnummer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxObjektnummer;
        private System.Windows.Forms.TextBox tbxBoyta;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.ComboBox cbxBostadstyp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxBostäder;
        private System.Windows.Forms.Button buttonLäggTill;
        private System.Windows.Forms.Button buttonÅngra;
        private System.Windows.Forms.Button buttonVisaAlla;
        private System.Windows.Forms.Button buttonVisaLägenheter;
        private System.Windows.Forms.Button buttonHögstPrisPerKVM;
    }
}

