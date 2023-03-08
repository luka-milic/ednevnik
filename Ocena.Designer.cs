
namespace ednevnik
{
    partial class Ocena
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
            this.cb_godina = new System.Windows.Forms.ComboBox();
            this.cb_profesor = new System.Windows.Forms.ComboBox();
            this.cb_predmet = new System.Windows.Forms.ComboBox();
            this.cb_odeljenje = new System.Windows.Forms.ComboBox();
            this.cb_ucenik = new System.Windows.Forms.ComboBox();
            this.cb_ocena = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_godina = new System.Windows.Forms.Label();
            this.lb_profesor = new System.Windows.Forms.Label();
            this.lb_predmet = new System.Windows.Forms.Label();
            this.lb_odeljenje = new System.Windows.Forms.Label();
            this.lb_ucenik = new System.Windows.Forms.Label();
            this.lb_Ocena = new System.Windows.Forms.Label();
            this.lb_datum = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.btBrisi = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_godina
            // 
            this.cb_godina.FormattingEnabled = true;
            this.cb_godina.Location = new System.Drawing.Point(44, 36);
            this.cb_godina.Name = "cb_godina";
            this.cb_godina.Size = new System.Drawing.Size(121, 21);
            this.cb_godina.TabIndex = 0;
            this.cb_godina.SelectedValueChanged += new System.EventHandler(this.cb_godina_SelectedValueChanged);
            // 
            // cb_profesor
            // 
            this.cb_profesor.FormattingEnabled = true;
            this.cb_profesor.Location = new System.Drawing.Point(189, 36);
            this.cb_profesor.Name = "cb_profesor";
            this.cb_profesor.Size = new System.Drawing.Size(121, 21);
            this.cb_profesor.TabIndex = 1;
            this.cb_profesor.SelectedValueChanged += new System.EventHandler(this.cb_profesor_SelectedValueChanged);
            // 
            // cb_predmet
            // 
            this.cb_predmet.FormattingEnabled = true;
            this.cb_predmet.Location = new System.Drawing.Point(336, 36);
            this.cb_predmet.Name = "cb_predmet";
            this.cb_predmet.Size = new System.Drawing.Size(121, 21);
            this.cb_predmet.TabIndex = 1;
            this.cb_predmet.SelectedValueChanged += new System.EventHandler(this.cb_predmet_SelectedValueChanged);
            // 
            // cb_odeljenje
            // 
            this.cb_odeljenje.FormattingEnabled = true;
            this.cb_odeljenje.Location = new System.Drawing.Point(483, 36);
            this.cb_odeljenje.Name = "cb_odeljenje";
            this.cb_odeljenje.Size = new System.Drawing.Size(121, 21);
            this.cb_odeljenje.TabIndex = 2;
            this.cb_odeljenje.SelectedValueChanged += new System.EventHandler(this.cb_odeljenje_SelectedValueChanged);
            // 
            // cb_ucenik
            // 
            this.cb_ucenik.FormattingEnabled = true;
            this.cb_ucenik.Location = new System.Drawing.Point(622, 36);
            this.cb_ucenik.Name = "cb_ucenik";
            this.cb_ucenik.Size = new System.Drawing.Size(121, 21);
            this.cb_ucenik.TabIndex = 3;
            // 
            // cb_ocena
            // 
            this.cb_ocena.FormattingEnabled = true;
            this.cb_ocena.Location = new System.Drawing.Point(44, 83);
            this.cb_ocena.Name = "cb_ocena";
            this.cb_ocena.Size = new System.Drawing.Size(121, 21);
            this.cb_ocena.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lb_godina
            // 
            this.lb_godina.AutoSize = true;
            this.lb_godina.Location = new System.Drawing.Point(44, 13);
            this.lb_godina.Name = "lb_godina";
            this.lb_godina.Size = new System.Drawing.Size(41, 13);
            this.lb_godina.TabIndex = 11;
            this.lb_godina.Text = "Godina";
            // 
            // lb_profesor
            // 
            this.lb_profesor.AutoSize = true;
            this.lb_profesor.Location = new System.Drawing.Point(186, 20);
            this.lb_profesor.Name = "lb_profesor";
            this.lb_profesor.Size = new System.Drawing.Size(46, 13);
            this.lb_profesor.TabIndex = 12;
            this.lb_profesor.Text = "Profesor";
            // 
            // lb_predmet
            // 
            this.lb_predmet.AutoSize = true;
            this.lb_predmet.Location = new System.Drawing.Point(363, 13);
            this.lb_predmet.Name = "lb_predmet";
            this.lb_predmet.Size = new System.Drawing.Size(46, 13);
            this.lb_predmet.TabIndex = 13;
            this.lb_predmet.Text = "Predmet";
            // 
            // lb_odeljenje
            // 
            this.lb_odeljenje.AutoSize = true;
            this.lb_odeljenje.Location = new System.Drawing.Point(502, 13);
            this.lb_odeljenje.Name = "lb_odeljenje";
            this.lb_odeljenje.Size = new System.Drawing.Size(51, 13);
            this.lb_odeljenje.TabIndex = 14;
            this.lb_odeljenje.Text = "Odeljenje";
            // 
            // lb_ucenik
            // 
            this.lb_ucenik.AutoSize = true;
            this.lb_ucenik.Location = new System.Drawing.Point(633, 13);
            this.lb_ucenik.Name = "lb_ucenik";
            this.lb_ucenik.Size = new System.Drawing.Size(41, 13);
            this.lb_ucenik.TabIndex = 15;
            this.lb_ucenik.Text = "Ucenik";
            // 
            // lb_Ocena
            // 
            this.lb_Ocena.AutoSize = true;
            this.lb_Ocena.Location = new System.Drawing.Point(107, 67);
            this.lb_Ocena.Name = "lb_Ocena";
            this.lb_Ocena.Size = new System.Drawing.Size(39, 13);
            this.lb_Ocena.TabIndex = 16;
            this.lb_Ocena.Text = "Ocena";
            // 
            // lb_datum
            // 
            this.lb_datum.AutoSize = true;
            this.lb_datum.Location = new System.Drawing.Point(266, 67);
            this.lb_datum.Name = "lb_datum";
            this.lb_datum.Size = new System.Drawing.Size(38, 13);
            this.lb_datum.TabIndex = 17;
            this.lb_datum.Text = "Datum";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(392, 67);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 18;
            this.lb_id.Text = "ID";
            // 
            // btBrisi
            // 
            this.btBrisi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrisi.Location = new System.Drawing.Point(654, 85);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(75, 25);
            this.btBrisi.TabIndex = 23;
            this.btBrisi.TabStop = false;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIzmeni.Location = new System.Drawing.Point(573, 85);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(75, 25);
            this.btIzmeni.TabIndex = 22;
            this.btIzmeni.TabStop = false;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDodaj.Location = new System.Drawing.Point(492, 85);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 25);
            this.btDodaj.TabIndex = 21;
            this.btDodaj.TabStop = false;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_datum);
            this.Controls.Add(this.lb_Ocena);
            this.Controls.Add(this.lb_ucenik);
            this.Controls.Add(this.lb_odeljenje);
            this.Controls.Add(this.lb_predmet);
            this.Controls.Add(this.lb_profesor);
            this.Controls.Add(this.lb_godina);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_ocena);
            this.Controls.Add(this.cb_ucenik);
            this.Controls.Add(this.cb_odeljenje);
            this.Controls.Add(this.cb_predmet);
            this.Controls.Add(this.cb_profesor);
            this.Controls.Add(this.cb_godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_godina;
        private System.Windows.Forms.ComboBox cb_profesor;
        private System.Windows.Forms.ComboBox cb_predmet;
        private System.Windows.Forms.ComboBox cb_odeljenje;
        private System.Windows.Forms.ComboBox cb_ucenik;
        private System.Windows.Forms.ComboBox cb_ocena;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_godina;
        private System.Windows.Forms.Label lb_profesor;
        private System.Windows.Forms.Label lb_predmet;
        private System.Windows.Forms.Label lb_odeljenje;
        private System.Windows.Forms.Label lb_ucenik;
        private System.Windows.Forms.Label lb_Ocena;
        private System.Windows.Forms.Label lb_datum;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btDodaj;
    }
}