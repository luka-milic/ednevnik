﻿
namespace ednevnik
{
    partial class Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jedanBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedanSaFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskeGodineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaSaFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUser = new System.Windows.Forms.Label();
            this.ocenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedanBezToolStripMenuItem,
            this.jedanSaFKToolStripMenuItem,
            this.tabelaBezToolStripMenuItem,
            this.tabelaSaFKToolStripMenuItem,
            this.izvestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jedanBezToolStripMenuItem
            // 
            this.jedanBezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobeToolStripMenuItem});
            this.jedanBezToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jedanBezToolStripMenuItem.Name = "jedanBezToolStripMenuItem";
            this.jedanBezToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.jedanBezToolStripMenuItem.Text = "Jedan Bez";
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobeToolStripMenuItem.Text = "Osobe";
            this.osobeToolStripMenuItem.Click += new System.EventHandler(this.osobeToolStripMenuItem_Click);
            // 
            // jedanSaFKToolStripMenuItem
            // 
            this.jedanSaFKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspodelaToolStripMenuItem});
            this.jedanSaFKToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jedanSaFKToolStripMenuItem.Name = "jedanSaFKToolStripMenuItem";
            this.jedanSaFKToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.jedanSaFKToolStripMenuItem.Text = "Jedan Sa FK";
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            this.raspodelaToolStripMenuItem.Click += new System.EventHandler(this.raspodelaToolStripMenuItem_Click);
            // 
            // tabelaBezToolStripMenuItem
            // 
            this.tabelaBezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smeroviToolStripMenuItem,
            this.skolskeGodineToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.osobeToolStripMenuItem1});
            this.tabelaBezToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaBezToolStripMenuItem.Name = "tabelaBezToolStripMenuItem";
            this.tabelaBezToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.tabelaBezToolStripMenuItem.Text = "Tabela Bez";
            // 
            // smeroviToolStripMenuItem
            // 
            this.smeroviToolStripMenuItem.Name = "smeroviToolStripMenuItem";
            this.smeroviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smeroviToolStripMenuItem.Text = "Smerovi";
            this.smeroviToolStripMenuItem.Click += new System.EventHandler(this.smeroviToolStripMenuItem_Click);
            // 
            // skolskeGodineToolStripMenuItem
            // 
            this.skolskeGodineToolStripMenuItem.Name = "skolskeGodineToolStripMenuItem";
            this.skolskeGodineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.skolskeGodineToolStripMenuItem.Text = "Skolske godine";
            this.skolskeGodineToolStripMenuItem.Click += new System.EventHandler(this.skolskeGodineToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            this.predmetiToolStripMenuItem.Click += new System.EventHandler(this.predmetiToolStripMenuItem_Click);
            // 
            // osobeToolStripMenuItem1
            // 
            this.osobeToolStripMenuItem1.Name = "osobeToolStripMenuItem1";
            this.osobeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.osobeToolStripMenuItem1.Text = "Osobe";
            this.osobeToolStripMenuItem1.Click += new System.EventHandler(this.osobeToolStripMenuItem1_Click);
            // 
            // tabelaSaFKToolStripMenuItem
            // 
            this.tabelaSaFKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocenaToolStripMenuItem});
            this.tabelaSaFKToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaSaFKToolStripMenuItem.Name = "tabelaSaFKToolStripMenuItem";
            this.tabelaSaFKToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.tabelaSaFKToolStripMenuItem.Text = "Tabela Sa FK";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(682, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(49, 15);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "lbUser";
            // 
            // ocenaToolStripMenuItem
            // 
            this.ocenaToolStripMenuItem.Name = "ocenaToolStripMenuItem";
            this.ocenaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ocenaToolStripMenuItem.Text = "Ocena";
            this.ocenaToolStripMenuItem.Click += new System.EventHandler(this.ocenaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jedanBezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedanSaFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaBezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaSaFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ToolStripMenuItem smeroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskeGodineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocenaToolStripMenuItem;
    }
}