using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ednevnik
{
    public partial class Osoba : Form
    {
        int broj_sloga = 0;
        DataTable tabela;
        public Osoba()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void Tb_Load()
        {
            if (tabela.Rows.Count == 0)
            {
                tbID.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbAdresa.Text = "";
                tbJMBG.Text = "";
                tbEmail.Text = "";
                tbPassword.Text = "";
                tbUloga.Text = "";
                btBrisi.Enabled = false;
            }
            else
            { 
                tbID.Text = tabela.Rows[broj_sloga]["id"].ToString();
                tbIme.Text = tabela.Rows[broj_sloga]["ime"].ToString();
                tbPrezime.Text = tabela.Rows[broj_sloga]["prezime"].ToString();
                tbAdresa.Text = tabela.Rows[broj_sloga]["adresa"].ToString();
                tbJMBG.Text = tabela.Rows[broj_sloga]["jmbg"].ToString();
                tbEmail.Text = tabela.Rows[broj_sloga]["email"].ToString();
                tbPassword.Text = tabela.Rows[broj_sloga]["pass"].ToString();
                tbUloga.Text = tabela.Rows[broj_sloga]["uloga"].ToString();
                btBrisi.Enabled = true;
            }
            if (broj_sloga == 0)
            {
                btPrvi.Enabled = false;
                btPrethodni.Enabled = false;
            }
            else
            {
                btPrvi.Enabled = true;
                btPrethodni.Enabled = true;
            }
            if (broj_sloga == tabela.Rows.Count-1)
            {
                btPoslednji.Enabled = false;
                btSledeci.Enabled = false;
            }
            else
            {
                btPoslednji.Enabled = true;
                btSledeci.Enabled = true;
            }
        }
        private void Osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            Tb_Load();

        }

        private void btPrvi_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Tb_Load();
        }

        private void btPrethodni_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Tb_Load();
        }

        private void btSledeci_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Tb_Load();
        }

        private void btPoslednji_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            Tb_Load();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO osoba (ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('");
            Naredba.Append(tbIme.Text + "', '");
            Naredba.Append(tbPrezime.Text + "', '");
            Naredba.Append(tbAdresa.Text + "', '");
            Naredba.Append(tbJMBG.Text + "', '");
            Naredba.Append(tbEmail.Text + "', '");
            Naredba.Append(tbPassword.Text + "', '");
            Naredba.Append(tbUloga.Text + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Load_Data();
            broj_sloga = tabela.Rows.Count - 1;
            Tb_Load();

        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE osoba SET ");
            Naredba.Append("Ime = '" + tbIme.Text + "', ");
            Naredba.Append("Prezime = '" + tbPrezime.Text + "', ");
            Naredba.Append("Adresa = '" + tbAdresa.Text + "', ");
            Naredba.Append("JMBG = '" + tbJMBG.Text + "', ");
            Naredba.Append("Email = '" + tbEmail.Text + "', ");
            Naredba.Append("Pass = '" + tbPassword.Text + "', ");
            Naredba.Append("Uloga = '" + tbUloga.Text + "' ");
            Naredba.Append("WHERE id = " + tbID.Text);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Load_Data();
            Tb_Load();
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            string Naredba = "DELETE FROM osoba WHERE id = " + tbID.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba, veza);
            Boolean Brisano = false;
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
                Brisano = true;
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            if(Brisano)
            {
                Load_Data();
                if (broj_sloga > 0) broj_sloga--;
                Tb_Load();
            }                     
        }
    }
}
