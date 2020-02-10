namespace Övning_5._2_Klient
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
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAnslut = new System.Windows.Forms.Button();
            this.textBoxMeddelande = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSkicka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(70, 9);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(116, 20);
            this.textBoxIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP-Adress";
            // 
            // buttonAnslut
            // 
            this.buttonAnslut.Location = new System.Drawing.Point(192, 9);
            this.buttonAnslut.Name = "buttonAnslut";
            this.buttonAnslut.Size = new System.Drawing.Size(75, 23);
            this.buttonAnslut.TabIndex = 2;
            this.buttonAnslut.Text = "Anslut";
            this.buttonAnslut.UseVisualStyleBackColor = true;
            this.buttonAnslut.Click += new System.EventHandler(this.buttonAnslut_Click);
            // 
            // textBoxMeddelande
            // 
            this.textBoxMeddelande.Location = new System.Drawing.Point(15, 66);
            this.textBoxMeddelande.Multiline = true;
            this.textBoxMeddelande.Name = "textBoxMeddelande";
            this.textBoxMeddelande.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMeddelande.Size = new System.Drawing.Size(252, 64);
            this.textBoxMeddelande.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meddelande";
            // 
            // buttonSkicka
            // 
            this.buttonSkicka.Enabled = false;
            this.buttonSkicka.Location = new System.Drawing.Point(192, 136);
            this.buttonSkicka.Name = "buttonSkicka";
            this.buttonSkicka.Size = new System.Drawing.Size(75, 23);
            this.buttonSkicka.TabIndex = 5;
            this.buttonSkicka.Text = "Skicka";
            this.buttonSkicka.UseVisualStyleBackColor = true;
            this.buttonSkicka.Click += new System.EventHandler(this.buttonSkicka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 172);
            this.Controls.Add(this.buttonSkicka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMeddelande);
            this.Controls.Add(this.buttonAnslut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIP);
            this.Name = "Form1";
            this.Text = "Klient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnslut;
        private System.Windows.Forms.TextBox textBoxMeddelande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSkicka;
    }
}

