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
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int broj_sloga = 0;
        public Raspodela()
        {
            InitializeComponent();
        }
        private void Load_data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }
        private void Raspodela_Load(object sender, EventArgs e)
        {
            Load_data();
            ComboFill();

        }
        private void ComboFill()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter;
            DataTable dt_godina, dt_nastavnik, dt_predmet, dt_odeljenje;
            dt_godina = new DataTable();
            dt_nastavnik = new DataTable();
            dt_predmet = new DataTable();
            dt_odeljenje = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);          
            adapter.Fill(dt_godina);
            adapter = new SqlDataAdapter("SELECT id, ime + ' ' + prezime as naziv FROM osoba WHERE uloga =2", veza);
            adapter.Fill(dt_nastavnik);
            adapter = new SqlDataAdapter("SELECT id, naziv FROM predmet", veza);
            adapter.Fill(dt_predmet);
            adapter = new SqlDataAdapter("SELECT id, LTRIM(STR(razred) + '-' + indeks) as naziv FROM odeljenje", veza);
            adapter.Fill(dt_odeljenje);

            cb_godina.DataSource = dt_godina;
            cb_godina.ValueMember = "id";
            cb_godina.DisplayMember = "naziv";
            cb_godina.SelectedValue = raspodela.Rows[broj_sloga]["godina_id"];

            cb_Nastavnik.DataSource = dt_nastavnik;
            cb_Nastavnik.ValueMember = "id";
            cb_Nastavnik.DisplayMember = "naziv";
            cb_Nastavnik.SelectedValue = raspodela.Rows[broj_sloga]["nastavnik_id"];

            cb_predmet.DataSource = dt_predmet;
            cb_predmet.ValueMember = "id";
            cb_predmet.DisplayMember = "naziv";
            cb_predmet.SelectedValue = raspodela.Rows[broj_sloga]["predmet_id"];

            cb_odeljenje.DataSource = dt_odeljenje;
            cb_odeljenje.ValueMember = "id";
            cb_odeljenje.DisplayMember = "naziv";
            cb_odeljenje.SelectedValue = raspodela.Rows[broj_sloga]["odeljenje_id"];

            tbID.Text = raspodela.Rows[broj_sloga]["id"].ToString();

            if (raspodela.Rows.Count == 0)
            {
                cb_godina.SelectedValue = -1;
                cb_Nastavnik.SelectedValue = -1;
                cb_predmet.SelectedValue = -1;
                cb_odeljenje.SelectedValue = -1;
            }
            else
            {
                cb_godina.SelectedValue = raspodela.Rows[broj_sloga]["godina_id"];
                cb_Nastavnik.SelectedValue = raspodela.Rows[broj_sloga]["nastavnik_id"];
                cb_predmet.SelectedValue = raspodela.Rows[broj_sloga]["predmet_id"];
                cb_odeljenje.SelectedValue = raspodela.Rows[broj_sloga]["odeljenje_id"];
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
            if (broj_sloga == raspodela.Rows.Count - 1)
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

        private void btPrvi_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            ComboFill();
        }

        private void btPrethodni_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            ComboFill();
        }

        private void btSledeci_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            ComboFill();
        }

        private void btPoslednji_Click(object sender, EventArgs e)
        {
            broj_sloga = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            string Naredba = "DELETE FROM raspodela WHERE id = " + tbID.Text;
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
            if (Brisano)
            {
                Load_data();
                if (broj_sloga > 0) broj_sloga--;
                ComboFill();
            }
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id) VALUES('");
            Naredba.Append(cb_godina.SelectedValue + "', '");
            Naredba.Append(cb_Nastavnik.SelectedValue + "', '");
            Naredba.Append(cb_predmet.SelectedValue + "', '");
            Naredba.Append(cb_odeljenje.SelectedValue + "')");
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
            Load_data();
            broj_sloga = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE raspodela SET ");
            Naredba.Append("godina_id = '" + cb_godina.SelectedValue + "', ");
            Naredba.Append("nastavnik_id = '" + cb_Nastavnik.SelectedValue + "', ");
            Naredba.Append("predmet_id = '" + cb_predmet.SelectedValue + "', ");
            Naredba.Append("odeljenje_id = '" + cb_odeljenje.SelectedValue + "' ");       
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
            Load_data();
            ComboFill();
        }
    }
}
