namespace SlumpaLösenord
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
            this.buttonLäggTill = new System.Windows.Forms.Button();
            this.buttonSkrivTillFil = new System.Windows.Forms.Button();
            this.textBoxAnvändarnamn = new System.Windows.Forms.TextBox();
            this.textBoxLösenord = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.labelAnvändarnamn = new System.Windows.Forms.Label();
            this.labelLösenord = new System.Windows.Forms.Label();
            this.listBoxInloggningar = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLäggTill
            // 
            this.buttonLäggTill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLäggTill.Location = new System.Drawing.Point(3, 49);
            this.buttonLäggTill.Name = "buttonLäggTill";
            this.buttonLäggTill.Size = new System.Drawing.Size(94, 21);
            this.buttonLäggTill.TabIndex = 0;
            this.buttonLäggTill.Text = "Lägg till";
            this.buttonLäggTill.UseVisualStyleBackColor = true;
            this.buttonLäggTill.Click += new System.EventHandler(this.buttonLäggTill_Click);
            // 
            // buttonSkrivTillFil
            // 
            this.buttonSkrivTillFil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkrivTillFil.Location = new System.Drawing.Point(103, 49);
            this.buttonSkrivTillFil.Name = "buttonSkrivTillFil";
            this.buttonSkrivTillFil.Size = new System.Drawing.Size(94, 21);
            this.buttonSkrivTillFil.TabIndex = 1;
            this.buttonSkrivTillFil.Text = "Skriv till fil";
            this.buttonSkrivTillFil.UseVisualStyleBackColor = true;
            this.buttonSkrivTillFil.Click += new System.EventHandler(this.buttonSkrivTillFil_Click);
            // 
            // textBoxAnvändarnamn
            // 
            this.textBoxAnvändarnamn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnvändarnamn.Location = new System.Drawing.Point(3, 23);
            this.textBoxAnvändarnamn.Name = "textBoxAnvändarnamn";
            this.textBoxAnvändarnamn.Size = new System.Drawing.Size(94, 20);
            this.textBoxAnvändarnamn.TabIndex = 2;
            // 
            // textBoxLösenord
            // 
            this.textBoxLösenord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLösenord.Location = new System.Drawing.Point(103, 23);
            this.textBoxLösenord.Name = "textBoxLösenord";
            this.textBoxLösenord.ReadOnly = true;
            this.textBoxLösenord.Size = new System.Drawing.Size(94, 20);
            this.textBoxLösenord.TabIndex = 3;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Controls.Add(this.textBoxAnvändarnamn, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.buttonSkrivTillFil, 1, 2);
            this.tableLayoutPanelTop.Controls.Add(this.textBoxLösenord, 1, 1);
            this.tableLayoutPanelTop.Controls.Add(this.buttonLäggTill, 0, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelAnvändarnamn, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelLösenord, 1, 0);
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 3;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(200, 74);
            this.tableLayoutPanelTop.TabIndex = 4;
            // 
            // labelAnvändarnamn
            // 
            this.labelAnvändarnamn.AutoSize = true;
            this.labelAnvändarnamn.Location = new System.Drawing.Point(3, 0);
            this.labelAnvändarnamn.Name = "labelAnvändarnamn";
            this.labelAnvändarnamn.Size = new System.Drawing.Size(79, 13);
            this.labelAnvändarnamn.TabIndex = 4;
            this.labelAnvändarnamn.Text = "Användarnamn";
            // 
            // labelLösenord
            // 
            this.labelLösenord.AutoSize = true;
            this.labelLösenord.Location = new System.Drawing.Point(103, 0);
            this.labelLösenord.Name = "labelLösenord";
            this.labelLösenord.Size = new System.Drawing.Size(51, 13);
            this.labelLösenord.TabIndex = 5;
            this.labelLösenord.Text = "Lösenord";
            // 
            // listBoxInloggningar
            // 
            this.listBoxInloggningar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInloggningar.FormattingEnabled = true;
            this.listBoxInloggningar.Location = new System.Drawing.Point(12, 92);
            this.listBoxInloggningar.Name = "listBoxInloggningar";
            this.listBoxInloggningar.Size = new System.Drawing.Size(200, 342);
            this.listBoxInloggningar.TabIndex = 5;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 447);
            this.Controls.Add(this.listBoxInloggningar);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Name = "FormStart";
            this.Text = "Inloggningar";
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLäggTill;
        private System.Windows.Forms.Button buttonSkrivTillFil;
        private System.Windows.Forms.TextBox textBoxAnvändarnamn;
        private System.Windows.Forms.TextBox textBoxLösenord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label labelAnvändarnamn;
        private System.Windows.Forms.Label labelLösenord;
        private System.Windows.Forms.ListBox listBoxInloggningar;
    }
}

