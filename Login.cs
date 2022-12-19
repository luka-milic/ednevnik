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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(tbIme.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Unesite email i lozinku");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("Select * FROM osoba WHERE email = @username", veza);
                    komanda.Parameters.AddWithValue("@username", tbIme.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int br = tabela.Rows.Count;
                    if (br == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), tbPassword.Text) == 0)
                        {
                            MessageBox.Show("Uspesno logovanje");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"]; ;
                            this.Hide();
                            Glavna frm_Glavna = new Glavna();
                            frm_Glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Lozinka nije tacna");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci E-mail");
                    }
                }
                catch(Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
