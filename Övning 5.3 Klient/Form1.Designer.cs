namespace Övning_5._3_Klient
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
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonAnslut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUtkorg = new System.Windows.Forms.TextBox();
            this.buttonSkicka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-Adress";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(115, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 1;
            // 
            // buttonAnslut
            // 
            this.buttonAnslut.Location = new System.Drawing.Point(221, 12);
            this.buttonAnslut.Name = "buttonAnslut";
            this.buttonAnslut.Size = new System.Drawing.Size(75, 23);
            this.buttonAnslut.TabIndex = 2;
            this.buttonAnslut.Text = "Anslut";
            this.buttonAnslut.UseVisualStyleBackColor = true;
            this.buttonAnslut.Click += new System.EventHandler(this.buttonAnslut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Utkorg";
            // 
            // textBoxUtkorg
            // 
            this.textBoxUtkorg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUtkorg.Location = new System.Drawing.Point(12, 74);
            this.textBoxUtkorg.Multiline = true;
            this.textBoxUtkorg.Name = "textBoxUtkorg";
            this.textBoxUtkorg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUtkorg.Size = new System.Drawing.Size(284, 110);
            this.textBoxUtkorg.TabIndex = 4;
            // 
            // buttonSkicka
            // 
            this.buttonSkicka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSkicka.Enabled = false;
            this.buttonSkicka.Location = new System.Drawing.Point(12, 190);
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
            this.ClientSize = new System.Drawing.Size(310, 224);
            this.Controls.Add(this.buttonSkicka);
            this.Controls.Add(this.textBoxUtkorg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAnslut);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonAnslut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUtkorg;
        private System.Windows.Forms.Button buttonSkicka;
    }
}

