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
    public partial class Ocena : Form
    {
        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            cmb_GodinaPopulate();
            cb_predmet.Enabled = false;
            cb_odeljenje.Enabled = false;
            cb_ucenik.Enabled = false;
            cb_ocena.Enabled = false;
            cb_ocena.Items.Add(1);
            cb_ocena.Items.Add(2);
            cb_ocena.Items.Add(3);
            cb_ocena.Items.Add(4);
            cb_ocena.Items.Add(5);
            
        }
        private void cmb_GodinaPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from skolska_godina", veza);
            DataTable dt_godina = new DataTable();
            adapter.Fill(dt_godina);
            cb_godina.DataSource = dt_godina;
            cb_godina.ValueMember = "id";
            cb_godina.DisplayMember = "naziv";
            cb_godina.SelectedValue = 2;
        }
        private void cb_godina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_godina.IsHandleCreated && cb_godina.Focused)
            {
                cmb_ProfesorPopulate();
            }
        }
        private void cmb_ProfesorPopulate()
        {
            
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba");
            naredba.Append(" JOIN raspodela ON osoba.id = nastavnik_id ");
            naredba.Append(" WHERE godina_id = " + cb_godina.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_profesor = new DataTable();
            adapter.Fill(dt_profesor);
            cb_profesor.DataSource = dt_profesor;
            cb_profesor.ValueMember = "id";
            cb_profesor.DisplayMember = "naziv";
            cb_profesor.SelectedValue = -1;
        }

        private void cb_profesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_profesor.IsHandleCreated && cb_profesor.Focused)
            {
                cmb_PredmetPopulate();
                cb_predmet.Enabled = true;
            }
        }
        private void cmb_PredmetPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT predmet.id AS id, naziv FROM predmet");
            naredba.Append(" JOIN raspodela ON predmet.id = predmet_id");
            naredba.Append(" WHERE godina_id =" + cb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cb_profesor.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_predmet = new DataTable();
            adapter.Fill(dt_predmet);
            cb_predmet.DataSource = dt_predmet;
            cb_predmet.ValueMember = "id";
            cb_predmet.DisplayMember = "naziv";
            cb_predmet.SelectedValue = -1;
        }
        private void cb_predmet_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_OdeljenjePopulate();
            cb_odeljenje.Enabled = true;
        }
        private void cmb_OdeljenjePopulate()
        {
            
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT odeljenje.id AS id, str(razred) + '-' + indeks AS naziv FROM odeljenje ");
            naredba.Append(" JOIN raspodela ON odeljenje.id = odeljenje_id ");
            naredba.Append(" WHERE raspodela.godina_id = " + cb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cb_profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cb_predmet.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);
            cb_odeljenje.DataSource = dt_odeljenje;
            cb_odeljenje.ValueMember = "id";
            cb_odeljenje.DisplayMember = "naziv";
            cb_odeljenje.SelectedValue = -1;
        }

        private void cb_odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_odeljenje.IsHandleCreated && cb_odeljenje.Focused)
            {
                cmb_UcenikPopulate();
                cb_ucenik.Enabled = true;

            }
        }
        private void cmb_UcenikPopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba ");
            naredba.Append(" JOIN upisnica ON osoba.id = osoba_id ");
            naredba.Append(" WHERE upisnica.odeljenje_id = " + cb_odeljenje.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Ucenik = new DataTable();
            cb_ucenik.DataSource = dt_Ucenik;
            cb_ucenik.ValueMember = "id";
            cb_ucenik.DisplayMember = "naziv";
            cb_ucenik.SelectedItem = -1;
        }
        public void GridPopulate()
        {
            StringBuilder command = new StringBuilder("select ocena.id as id, ime + ' ' + prezime as naziv, ocena, ucenik_id, datum from osoba ");
            command.Append("join ocena on osoba.id = ucenik_id ");
            command.Append("join raspodela on raspodela_id = raspodela.id ");
            command.Append("where raspodela_id = ");
            command.Append("(select id from raspodela ");
            command.Append("where godina_id = " + cb_godina.SelectedValue.ToString());
            command.Append(" and nastavnik_id = " + cb_profesor.SelectedValue.ToString());
            command.Append(" and predmet_id = " + cb_predmet.SelectedValue.ToString());
            command.Append(" and odeljenje_id = " + cb_odeljenje.SelectedValue.ToString() + ")");
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(command.ToString(), veza);
            dt_ocena = new DataTable();
            adapter.Fill(dt_ocena);
            dataGridView1.DataSource = dt_ocena;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["ucenik_id"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UcenikOcenaIDSet(e.RowIndex);
            }
        }
        DataTable dt_ocena;
        private void UcenikOcenaIDSet(int broj_sloga)
        {
            cb_ucenik.SelectedValue = dt_ocena.Rows[broj_sloga]["ucenik_id"];
            cb_ocena.SelectedItem = dt_ocena.Rows[broj_sloga]["ocena"];
            textBox1.Text = dt_ocena.Rows[broj_sloga]["id"].ToString();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder command = new StringBuilder("Select id from raspodela ");
            command.Append("where godina_id = " + cb_godina.SelectedValue.ToString());
            command.Append(" and nastavnik_id = " + cb_profesor.SelectedValue.ToString());
            command.Append(" and predmet_id = " + cb_predmet.SelectedValue.ToString());
            command.Append(" and odeljenje_id = " + cb_odeljenje.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlCommand order = new SqlCommand(command.ToString(), veza);
            int id_raspodela = 0;
            try
            {
                veza.Open();
                id_raspodela = (int)order.ExecuteScalar();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            if (id_raspodela > 0)
            {
                StringBuilder command2 = new StringBuilder("insert into ocena (datum, raspodela_id, ucenik_id, ocena) values( '");
                DateTime datum = dateTimePicker1.Value;
                command2.Append(datum.ToString("yyyy-MM-dd") + "', '");
                command2.Append(id_raspodela.ToString() + "', '");
                command2.Append(cb_ucenik.SelectedValue.ToString() + "', '");
                command2.Append(cb_ocena.SelectedItem.ToString() + "')");
                order = new SqlCommand(command2.ToString(), veza);
                try
                {
                    veza.Open();
                    order.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }

            GridPopulate();

        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 0)
            {
                DateTime datumce = dateTimePicker1.Value;
                StringBuilder build = new StringBuilder("update ocena set ");
                build.Append(" ucenik_id = '" + cb_ucenik.SelectedValue.ToString() + "', ");
                build.Append(" ocena = '" + cb_ocena.SelectedItem.ToString() + "', ");
                build.Append(" datum = '" + datumce.ToString("yyyy-MM-dd") + "' ");
                build.Append("where id = " + textBox1.Text);
                SqlConnection veza = Konekcija.Connect();
                SqlCommand order2 = new SqlCommand(build.ToString(), veza);
                try
                {
                    veza.Open();
                    order2.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
            GridPopulate();
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(textBox1.Text) > 0)
            {
                string delete = "delete from ocena where id = " + textBox1.Text;
                SqlConnection veza = Konekcija.Connect();
                SqlCommand komanda = new SqlCommand(delete.ToString(), veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                    GridPopulate();
                    UcenikOcenaIDSet(0);
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }
    }
}
