namespace Övning_5._2_Server
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
            this.textBoxInkorg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.buttonTaEmot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInkorg
            // 
            this.textBoxInkorg.Location = new System.Drawing.Point(12, 71);
            this.textBoxInkorg.Multiline = true;
            this.textBoxInkorg.Name = "textBoxInkorg";
            this.textBoxInkorg.ReadOnly = true;
            this.textBoxInkorg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInkorg.Size = new System.Drawing.Size(355, 109);
            this.textBoxInkorg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inkorg";
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Location = new System.Drawing.Point(12, 12);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(129, 23);
            this.buttonStartServer.TabIndex = 2;
            this.buttonStartServer.Text = "Starta server";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // buttonTaEmot
            // 
            this.buttonTaEmot.Enabled = false;
            this.buttonTaEmot.Location = new System.Drawing.Point(12, 186);
            this.buttonTaEmot.Name = "buttonTaEmot";
            this.buttonTaEmot.Size = new System.Drawing.Size(355, 23);
            this.buttonTaEmot.TabIndex = 3;
            this.buttonTaEmot.Text = "Ta emot meddelande";
            this.buttonTaEmot.UseVisualStyleBackColor = true;
            this.buttonTaEmot.Click += new System.EventHandler(this.buttonTaEmot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 219);
            this.Controls.Add(this.buttonTaEmot);
            this.Controls.Add(this.buttonStartServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInkorg);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInkorg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Button buttonTaEmot;
    }
}

