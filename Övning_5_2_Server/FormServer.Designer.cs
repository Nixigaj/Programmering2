﻿namespace Övning_5_2_Server
{
    partial class FormServer
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
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labeMottagenData = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonTaEmot
            // 
            this.buttonTaEmot.Location = new System.Drawing.Point(370, 11);
            this.buttonTaEmot.Name = "buttonTaEmot";
            this.buttonTaEmot.Size = new System.Drawing.Size(72, 23);
            this.buttonTaEmot.TabIndex = 12;
            this.buttonTaEmot.Text = "Ta emot";
            this.buttonTaEmot.UseVisualStyleBackColor = true;
            this.buttonTaEmot.Click += new System.EventHandler(this.buttonTaEmot_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(244, 13);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(68, 20);
            this.textBoxPort.TabIndex = 10;
            // 
            // labeMottagenData
            // 
            this.labeMottagenData.AutoSize = true;
            this.labeMottagenData.Location = new System.Drawing.Point(12, 24);
            this.labeMottagenData.Name = "labeMottagenData";
            this.labeMottagenData.Size = new System.Drawing.Size(76, 13);
            this.labeMottagenData.TabIndex = 9;
            this.labeMottagenData.Text = "Mottagen data";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(130, 16);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(108, 13);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "Serverns Portnummer";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(15, 40);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(427, 115);
            this.textBoxData.TabIndex = 13;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 167);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonTaEmot);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labeMottagenData);
            this.Controls.Add(this.labelPort);
            this.Name = "FormServer";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTaEmot;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labeMottagenData;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxData;
    }
}

