namespace MenuStrip_orenek__304
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kalınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşlemToolStripMenuItem
            // 
            this.öğrenciİşlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.öğrenciİşlemToolStripMenuItem.Name = "öğrenciİşlemToolStripMenuItem";
            this.öğrenciİşlemToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.öğrenciİşlemToolStripMenuItem.Text = "Öğrenci İşlem";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(12, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 277);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalınToolStripMenuItem,
            this.ptToolStripMenuItem,
            this.ptToolStripMenuItem1,
            this.ptToolStripMenuItem2,
            this.ogrenciEkleToolStripMenuItem,
            this.formuKapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 158);
            // 
            // kalınToolStripMenuItem
            // 
            this.kalınToolStripMenuItem.Name = "kalınToolStripMenuItem";
            this.kalınToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kalınToolStripMenuItem.Text = "Kalın";
            this.kalınToolStripMenuItem.Click += new System.EventHandler(this.kalınToolStripMenuItem_Click);
            // 
            // ptToolStripMenuItem
            // 
            this.ptToolStripMenuItem.Name = "ptToolStripMenuItem";
            this.ptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ptToolStripMenuItem.Text = "12pt";
            this.ptToolStripMenuItem.Click += new System.EventHandler(this.ptToolStripMenuItem_Click);
            // 
            // ptToolStripMenuItem1
            // 
            this.ptToolStripMenuItem1.Name = "ptToolStripMenuItem1";
            this.ptToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ptToolStripMenuItem1.Text = "15pt";
            this.ptToolStripMenuItem1.Click += new System.EventHandler(this.ptToolStripMenuItem1_Click);
            // 
            // ptToolStripMenuItem2
            // 
            this.ptToolStripMenuItem2.Name = "ptToolStripMenuItem2";
            this.ptToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.ptToolStripMenuItem2.Text = "20pt";
            this.ptToolStripMenuItem2.Click += new System.EventHandler(this.ptToolStripMenuItem2_Click);
            // 
            // ogrenciEkleToolStripMenuItem
            // 
            this.ogrenciEkleToolStripMenuItem.Name = "ogrenciEkleToolStripMenuItem";
            this.ogrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ogrenciEkleToolStripMenuItem.Text = "OgrenciEkle";
            this.ogrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.ogrenciEkleToolStripMenuItem_Click);
            // 
            // formuKapatToolStripMenuItem
            // 
            this.formuKapatToolStripMenuItem.Name = "formuKapatToolStripMenuItem";
            this.formuKapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formuKapatToolStripMenuItem.Text = "Formu Kapat";
            this.formuKapatToolStripMenuItem.Click += new System.EventHandler(this.formuKapatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kalınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ogrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuKapatToolStripMenuItem;
    }
}

