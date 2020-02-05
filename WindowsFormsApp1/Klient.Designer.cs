namespace Övning_5_2
{
    partial class Klient
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
            this.textBoxIPAdress = new System.Windows.Forms.TextBox();
            this.buttonAnslut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMeddelande = new System.Windows.Forms.TextBox();
            this.buttonSkicka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP-Adress";
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAdress.Location = new System.Drawing.Point(70, 11);
            this.textBoxIPAdress.Name = "textBoxIPAdress";
            this.textBoxIPAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPAdress.TabIndex = 1;
            // 
            // buttonAnslut
            // 
            this.buttonAnslut.Location = new System.Drawing.Point(176, 9);
            this.buttonAnslut.Name = "buttonAnslut";
            this.buttonAnslut.Size = new System.Drawing.Size(75, 23);
            this.buttonAnslut.TabIndex = 2;
            this.buttonAnslut.Text = "Anslut";
            this.buttonAnslut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meddelande";
            // 
            // textBoxMeddelande
            // 
            this.textBoxMeddelande.Location = new System.Drawing.Point(12, 58);
            this.textBoxMeddelande.Multiline = true;
            this.textBoxMeddelande.Name = "textBoxMeddelande";
            this.textBoxMeddelande.Size = new System.Drawing.Size(308, 124);
            this.textBoxMeddelande.TabIndex = 4;
            // 
            // buttonSkicka
            // 
            this.buttonSkicka.Location = new System.Drawing.Point(245, 188);
            this.buttonSkicka.Name = "buttonSkicka";
            this.buttonSkicka.Size = new System.Drawing.Size(75, 23);
            this.buttonSkicka.TabIndex = 5;
            this.buttonSkicka.Text = "Skicka";
            this.buttonSkicka.UseVisualStyleBackColor = true;
            this.buttonSkicka.Click += new System.EventHandler(this.buttonSkicka_Click);
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 233);
            this.Controls.Add(this.buttonSkicka);
            this.Controls.Add(this.textBoxMeddelande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAnslut);
            this.Controls.Add(this.textBoxIPAdress);
            this.Controls.Add(this.label1);
            this.Name = "Klient";
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIPAdress;
        private System.Windows.Forms.Button buttonAnslut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMeddelande;
        private System.Windows.Forms.Button buttonSkicka;
    }
}

