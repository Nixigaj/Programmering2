namespace Övning_5._1_Klient
{
    partial class KlientForm
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
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonSkicka = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelSkickadData = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(15, 68);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(430, 110);
            this.textBoxData.TabIndex = 13;
            // 
            // buttonSkicka
            // 
            this.buttonSkicka.Location = new System.Drawing.Point(370, 39);
            this.buttonSkicka.Name = "buttonSkicka";
            this.buttonSkicka.Size = new System.Drawing.Size(75, 23);
            this.buttonSkicka.TabIndex = 12;
            this.buttonSkicka.Text = "Skicka";
            this.buttonSkicka.UseVisualStyleBackColor = true;
            this.buttonSkicka.Click += new System.EventHandler(this.buttonSkicka_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(115, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(330, 20);
            this.textBoxIP.TabIndex = 11;
            // 
            // labelSkickadData
            // 
            this.labelSkickadData.AutoSize = true;
            this.labelSkickadData.Location = new System.Drawing.Point(12, 52);
            this.labelSkickadData.Name = "labelSkickadData";
            this.labelSkickadData.Size = new System.Drawing.Size(111, 13);
            this.labelSkickadData.TabIndex = 10;
            this.labelSkickadData.Text = "Data som ska skickas";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 15);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(97, 13);
            this.labelIP.TabIndex = 9;
            this.labelIP.Text = "Serverns IP-Adress";
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 189);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonSkicka);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelSkickadData);
            this.Controls.Add(this.labelIP);
            this.Name = "KlientForm";
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonSkicka;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelSkickadData;
        private System.Windows.Forms.Label labelIP;
    }
}

