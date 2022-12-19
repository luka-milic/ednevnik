
namespace ednevnik
{
    partial class Raspodela
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
            this.cb_Nastavnik = new System.Windows.Forms.ComboBox();
            this.cb_godina = new System.Windows.Forms.ComboBox();
            this.cb_predmet = new System.Windows.Forms.ComboBox();
            this.cb_odeljenje = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNastavnik = new System.Windows.Forms.Label();
            this.lbOdeljenje = new System.Windows.Forms.Label();
            this.lbGodina = new System.Windows.Forms.Label();
            this.lbPredmet = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btPoslednji = new System.Windows.Forms.Button();
            this.btSledeci = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btPrethodni = new System.Windows.Forms.Button();
            this.btPrvi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Nastavnik
            // 
            this.cb_Nastavnik.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nastavnik.FormattingEnabled = true;
            this.cb_Nastavnik.Location = new System.Drawing.Point(142, 123);
            this.cb_Nastavnik.Name = "cb_Nastavnik";
            this.cb_Nastavnik.Size = new System.Drawing.Size(183, 21);
            this.cb_Nastavnik.TabIndex = 0;
            // 
            // cb_godina
            // 
            this.cb_godina.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_godina.FormattingEnabled = true;
            this.cb_godina.Location = new System.Drawing.Point(142, 72);
            this.cb_godina.Name = "cb_godina";
            this.cb_godina.Size = new System.Drawing.Size(183, 21);
            this.cb_godina.TabIndex = 1;
            // 
            // cb_predmet
            // 
            this.cb_predmet.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_predmet.FormattingEnabled = true;
            this.cb_predmet.Location = new System.Drawing.Point(142, 174);
            this.cb_predmet.Name = "cb_predmet";
            this.cb_predmet.Size = new System.Drawing.Size(183, 21);
            this.cb_predmet.TabIndex = 2;
            // 
            // cb_odeljenje
            // 
            this.cb_odeljenje.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_odeljenje.FormattingEnabled = true;
            this.cb_odeljenje.Location = new System.Drawing.Point(142, 225);
            this.cb_odeljenje.Name = "cb_odeljenje";
            this.cb_odeljenje.Size = new System.Drawing.Size(183, 21);
            this.cb_odeljenje.TabIndex = 3;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(82, 25);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 14);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "ID";
            // 
            // lbNastavnik
            // 
            this.lbNastavnik.AutoSize = true;
            this.lbNastavnik.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNastavnik.Location = new System.Drawing.Point(55, 127);
            this.lbNastavnik.Name = "lbNastavnik";
            this.lbNastavnik.Size = new System.Drawing.Size(70, 14);
            this.lbNastavnik.TabIndex = 13;
            this.lbNastavnik.Text = "NASTAVNIK";
            // 
            // lbOdeljenje
            // 
            this.lbOdeljenje.AutoSize = true;
            this.lbOdeljenje.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOdeljenje.Location = new System.Drawing.Point(55, 229);
            this.lbOdeljenje.Name = "lbOdeljenje";
            this.lbOdeljenje.Size = new System.Drawing.Size(70, 14);
            this.lbOdeljenje.TabIndex = 14;
            this.lbOdeljenje.Text = "ODELJENJE";
            // 
            // lbGodina
            // 
            this.lbGodina.AutoSize = true;
            this.lbGodina.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGodina.Location = new System.Drawing.Point(62, 76);
            this.lbGodina.Name = "lbGodina";
            this.lbGodina.Size = new System.Drawing.Size(49, 14);
            this.lbGodina.TabIndex = 15;
            this.lbGodina.Text = "GODINA";
            // 
            // lbPredmet
            // 
            this.lbPredmet.AutoSize = true;
            this.lbPredmet.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPredmet.Location = new System.Drawing.Point(62, 178);
            this.lbPredmet.Name = "lbPredmet";
            this.lbPredmet.Size = new System.Drawing.Size(56, 14);
            this.lbPredmet.TabIndex = 16;
            this.lbPredmet.Text = "PREDMET";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(142, 22);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(183, 20);
            this.tbID.TabIndex = 17;
            // 
            // btPoslednji
            // 
            this.btPoslednji.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPoslednji.Location = new System.Drawing.Point(355, 282);
            this.btPoslednji.Name = "btPoslednji";
            this.btPoslednji.Size = new System.Drawing.Size(31, 25);
            this.btPoslednji.TabIndex = 29;
            this.btPoslednji.TabStop = false;
            this.btPoslednji.Text = ">|";
            this.btPoslednji.UseVisualStyleBackColor = true;
            this.btPoslednji.Click += new System.EventHandler(this.btPoslednji_Click);
            // 
            // btSledeci
            // 
            this.btSledeci.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSledeci.Location = new System.Drawing.Point(324, 282);
            this.btSledeci.Name = "btSledeci";
            this.btSledeci.Size = new System.Drawing.Size(25, 25);
            this.btSledeci.TabIndex = 28;
            this.btSledeci.TabStop = false;
            this.btSledeci.Text = ">";
            this.btSledeci.UseVisualStyleBackColor = true;
            this.btSledeci.Click += new System.EventHandler(this.btSledeci_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrisi.Location = new System.Drawing.Point(243, 282);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(75, 25);
            this.btBrisi.TabIndex = 27;
            this.btBrisi.TabStop = false;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIzmeni.Location = new System.Drawing.Point(162, 282);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(75, 25);
            this.btIzmeni.TabIndex = 26;
            this.btIzmeni.TabStop = false;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDodaj.Location = new System.Drawing.Point(81, 282);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 25);
            this.btDodaj.TabIndex = 25;
            this.btDodaj.TabStop = false;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btPrethodni
            // 
            this.btPrethodni.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrethodni.Location = new System.Drawing.Point(50, 282);
            this.btPrethodni.Name = "btPrethodni";
            this.btPrethodni.Size = new System.Drawing.Size(25, 25);
            this.btPrethodni.TabIndex = 24;
            this.btPrethodni.TabStop = false;
            this.btPrethodni.Text = "<";
            this.btPrethodni.UseVisualStyleBackColor = true;
            this.btPrethodni.Click += new System.EventHandler(this.btPrethodni_Click);
            // 
            // btPrvi
            // 
            this.btPrvi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrvi.Location = new System.Drawing.Point(14, 282);
            this.btPrvi.Name = "btPrvi";
            this.btPrvi.Size = new System.Drawing.Size(30, 25);
            this.btPrvi.TabIndex = 23;
            this.btPrvi.TabStop = false;
            this.btPrvi.Text = "|<";
            this.btPrvi.UseVisualStyleBackColor = true;
            this.btPrvi.Click += new System.EventHandler(this.btPrvi_Click);
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 321);
            this.Controls.Add(this.btPoslednji);
            this.Controls.Add(this.btSledeci);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btPrethodni);
            this.Controls.Add(this.btPrvi);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbPredmet);
            this.Controls.Add(this.lbGodina);
            this.Controls.Add(this.lbOdeljenje);
            this.Controls.Add(this.lbNastavnik);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.cb_odeljenje);
            this.Controls.Add(this.cb_predmet);
            this.Controls.Add(this.cb_godina);
            this.Controls.Add(this.cb_Nastavnik);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Nastavnik;
        private System.Windows.Forms.ComboBox cb_godina;
        private System.Windows.Forms.ComboBox cb_predmet;
        private System.Windows.Forms.ComboBox cb_odeljenje;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNastavnik;
        private System.Windows.Forms.Label lbOdeljenje;
        private System.Windows.Forms.Label lbGodina;
        private System.Windows.Forms.Label lbPredmet;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btPoslednji;
        private System.Windows.Forms.Button btSledeci;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btPrethodni;
        private System.Windows.Forms.Button btPrvi;
    }
}