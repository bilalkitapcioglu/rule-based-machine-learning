namespace KuralTabanliVarlikIsmiTanimaProgrami
{
    partial class FormAna
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
            this.menuStripAna = new System.Windows.Forms.MenuStrip();
            this.analizEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxAna = new System.Windows.Forms.RichTextBox();
            this.panelAna = new System.Windows.Forms.Panel();
            this.progressBarAna = new System.Windows.Forms.ProgressBar();
            this.menuStripAna.SuspendLayout();
            this.panelAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAna
            // 
            this.menuStripAna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analizEtToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.menuStripAna.Location = new System.Drawing.Point(0, 0);
            this.menuStripAna.Name = "menuStripAna";
            this.menuStripAna.Size = new System.Drawing.Size(858, 24);
            this.menuStripAna.TabIndex = 0;
            this.menuStripAna.Text = "menuStripAna";
            // 
            // analizEtToolStripMenuItem
            // 
            this.analizEtToolStripMenuItem.Name = "analizEtToolStripMenuItem";
            this.analizEtToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.analizEtToolStripMenuItem.Text = "Analiz Et";
            this.analizEtToolStripMenuItem.Click += new System.EventHandler(this.analizEtToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // richTextBoxAna
            // 
            this.richTextBoxAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxAna.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxAna.Name = "richTextBoxAna";
            this.richTextBoxAna.Size = new System.Drawing.Size(858, 378);
            this.richTextBoxAna.TabIndex = 1;
            this.richTextBoxAna.Text = "";
            // 
            // panelAna
            // 
            this.panelAna.Controls.Add(this.progressBarAna);
            this.panelAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAna.Location = new System.Drawing.Point(0, 24);
            this.panelAna.Name = "panelAna";
            this.panelAna.Size = new System.Drawing.Size(858, 378);
            this.panelAna.TabIndex = 2;
            this.panelAna.Visible = false;
            // 
            // progressBarAna
            // 
            this.progressBarAna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarAna.Location = new System.Drawing.Point(12, 155);
            this.progressBarAna.Name = "progressBarAna";
            this.progressBarAna.Size = new System.Drawing.Size(834, 23);
            this.progressBarAna.TabIndex = 0;
            this.progressBarAna.Visible = false;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 402);
            this.Controls.Add(this.panelAna);
            this.Controls.Add(this.richTextBoxAna);
            this.Controls.Add(this.menuStripAna);
            this.MainMenuStrip = this.menuStripAna;
            this.Name = "FormAna";
            this.Text = "Kural Tabanlı Varlık İsmi Tanıma";
           this.Load += new System.EventHandler(this.FormAna_Load);
            this.Resize += new System.EventHandler(this.FormAna_Resize);
            this.menuStripAna.ResumeLayout(false);
            this.menuStripAna.PerformLayout();
            this.panelAna.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAna;
        private System.Windows.Forms.ToolStripMenuItem analizEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxAna;
        private System.Windows.Forms.Panel panelAna;
        private System.Windows.Forms.ProgressBar progressBarAna;
    }
}

