namespace Övning_5_2
{
    partial class Server
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
            this.buttonTaEmot = new System.Windows.Forms.Button();
            this.buttonStartaServer = new System.Windows.Forms.Button();
            this.listBoxMeddelande = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTaEmot
            // 
            this.buttonTaEmot.Location = new System.Drawing.Point(12, 222);
            this.buttonTaEmot.Name = "buttonTaEmot";
            this.buttonTaEmot.Size = new System.Drawing.Size(363, 23);
            this.buttonTaEmot.TabIndex = 7;
            this.buttonTaEmot.Text = "Ta emot meddelande";
            this.buttonTaEmot.UseVisualStyleBackColor = true;
            // 
            // buttonStartaServer
            // 
            this.buttonStartaServer.Location = new System.Drawing.Point(12, 12);
            this.buttonStartaServer.Name = "buttonStartaServer";
            this.buttonStartaServer.Size = new System.Drawing.Size(118, 23);
            this.buttonStartaServer.TabIndex = 6;
            this.buttonStartaServer.Text = "Starta server";
            this.buttonStartaServer.UseVisualStyleBackColor = true;
            this.buttonStartaServer.Click += new System.EventHandler(this.buttonStartaServer_Click);
            // 
            // listBoxMeddelande
            // 
            this.listBoxMeddelande.FormattingEnabled = true;
            this.listBoxMeddelande.Location = new System.Drawing.Point(12, 69);
            this.listBoxMeddelande.Name = "listBoxMeddelande";
            this.listBoxMeddelande.Size = new System.Drawing.Size(363, 147);
            this.listBoxMeddelande.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inkorg";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 256);
            this.Controls.Add(this.buttonTaEmot);
            this.Controls.Add(this.buttonStartaServer);
            this.Controls.Add(this.listBoxMeddelande);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTaEmot;
        private System.Windows.Forms.Button buttonStartaServer;
        private System.Windows.Forms.ListBox listBoxMeddelande;
        private System.Windows.Forms.Label label1;
    }
}