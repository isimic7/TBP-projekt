using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracenje_Trudnoce_App
{
    public partial class FormaTrudnice : Form
    {
        public string konekcija = null;
        public FormaTrudnice(string konek)
        {
            InitializeComponent();
            konekcija = konek;
        }

        public NpgsqlConnection conn;
        private DataTable tablica;
        private NpgsqlCommand naredba;
        private string sql = null;

        private void resetirajVrijednosti()
        {
            txtEmailAdresa.Clear();
            txtIme.Clear();
            txtKontakt1.Clear();
            txtKontakt2.Clear();
            txtKontakt3.Clear();
            txtPrezime.Clear();
            cmbKrvnaGrupa.SelectedIndex = -1;
            cmbKrvnaRHFaktor.SelectedIndex = -1;
            datePočetakTrudnoće.ResetText();
            dateRođenja.ResetText();
        }

        private void ucitajTrudnice()
        {
            conn = new NpgsqlConnection(konekcija);
            dgvTrudnice.DataSource = null;
            conn.Open();
            sql = $"SELECT * from dohvati_sve_trudnice()";
            naredba = new NpgsqlCommand(sql, conn);
            tablica = new DataTable();
            tablica.Load(naredba.ExecuteReader());
            dgvTrudnice.DataSource = tablica;
            conn.Close();
        }

        private int OznaciTrudnicu()
        {
            string idTrudnica = null;
            int index = -1;

            index = dgvTrudnice.SelectedRows[0].Index;
            if (index!=-1)
            {
                idTrudnica = dgvTrudnice.SelectedRows[0].Cells["trudnica_id"].Value.ToString();
            }

            return int.Parse(idTrudnica);
        }

        private void AzurirajTrudnicu()
        {
            
            if (txtEmailAdresa.Text.Length != 0 && txtIme.Text.Length != 0 && txtKontakt1.Text.Length != 0
                && txtKontakt2.Text.Length != 0 && txtKontakt3.Text.Length != 0 && txtPrezime.Text.Length != 0)
            {
               
                string kontakt = txtKontakt1.Text + "-" + txtKontakt2.Text + "-" + txtKontakt3.Text;
               
                conn.Open();
                int rezultat = 0;
                sql = @"update trudnica set ime = @ime, prezime = @prezime ,kontakt_broj = @kontakt ,email = @email where trudnica_id = @id";

                //sql = @"select from azuriraj_trud(@id,@ime,@prezime,@rodjenje,@kontakt,@email,@krvna_grupa)"; 

                naredba = new NpgsqlCommand(sql, conn);

                naredba.Parameters.Add(new NpgsqlParameter("@id", OznaciTrudnicu()));
                naredba.Parameters.Add(new NpgsqlParameter("@ime", txtIme.Text));
                naredba.Parameters.Add(new NpgsqlParameter("@prezime", txtPrezime.Text));
                //naredba.Parameters.Add(new NpgsqlParameter("@rodjenje", dateRođenja.Value));
                naredba.Parameters.Add(new NpgsqlParameter("@kontakt", kontakt));
                naredba.Parameters.Add(new NpgsqlParameter("@email", txtEmailAdresa.Text));
                //naredba.Parameters.Add(new NpgsqlParameter("@krvna_grupa", krv));
                // naredba.Parameters.Add(new NpgsqlParameter("@pocetak_trud", datePočetakTrudnoće.Value));

                naredba.ExecuteNonQuery();

                rezultat = naredba.ExecuteNonQuery();
                conn.Close();

                if (rezultat == 1)
                {
                    resetirajVrijednosti();
                    MessageBox.Show("Uspješno ažuriranje!");
                }
                else
                {
                    MessageBox.Show("Neuspješno ažuriranje!");
                }

               
            }
            else
            {
                MessageBox.Show("Prazna polja");
            }


        }

        private void ObrisiTrudnicu()
        {
            conn.Open();
            int rezultat = 0;
            sql = "select * from obrisi_trudnicu(:id)";
            naredba = new NpgsqlCommand(sql, conn);
            naredba.Parameters.AddWithValue(":id", OznaciTrudnicu());
            rezultat = naredba.ExecuteNonQuery();
            if (rezultat == 1)
            {
                MessageBox.Show("Trudnica maknuta iz evidencije!");
            }
            conn.Close();
        }

        private void unesiTrudnicuNoviNacin()
        {
            if (txtEmailAdresa.Text.Length != 0 && txtIme.Text.Length != 0 && txtKontakt1.Text.Length != 0
                && txtKontakt2.Text.Length != 0 && txtKontakt3.Text.Length != 0 && txtPrezime.Text.Length != 0
                && dateRođenja.Value != null && datePočetakTrudnoće.Value != null && cmbKrvnaGrupa.SelectedText != null)
            {

                string kontakt = txtKontakt1.Text + "-" + txtKontakt2.Text + "-" + txtKontakt3.Text;
                string krv = "";
                if (cmbKrvnaGrupa.SelectedItem.ToString() == "AB")
                {
                    krv = cmbKrvnaGrupa.SelectedItem.ToString();
                }
                else
                {
                    krv = cmbKrvnaGrupa.SelectedItem.ToString() + cmbKrvnaRHFaktor.SelectedItem.ToString();
                }
               

                conn.Open();

                int rezultat = 0;
                

                NpgsqlCommand naredba = new NpgsqlCommand("insert into trudnica (ime,prezime,datum_rodjenja,kontakt_broj,email,krvna_grupa,pocetak_trudnoce) values(:_ime,:_prezime,:_rodjenje,:_kontakt,:_email,:_krv,:_pocetak)", conn);

                naredba.Parameters.Add(new NpgsqlParameter("_ime", txtIme.Text));
                naredba.Parameters.Add(new NpgsqlParameter("_prezime", txtPrezime.Text));
                naredba.Parameters.Add(new NpgsqlParameter("_rodjenje", dateRođenja.Value));
                naredba.Parameters.Add(new NpgsqlParameter("_kontakt", kontakt));
                naredba.Parameters.Add(new NpgsqlParameter("_email", txtEmailAdresa.Text));
                naredba.Parameters.Add(new NpgsqlParameter("_krv", krv));
                naredba.Parameters.Add(new NpgsqlParameter("_pocetak", datePočetakTrudnoće.Value));

                rezultat = naredba.ExecuteNonQuery();
                conn.Close();
                //rezultat = naredba.ExecuteNonQuery();

                if (rezultat == 1)
                {
                    MessageBox.Show("Uspješan unos!");
                    resetirajVrijednosti();
                }
                else
                {
                    MessageBox.Show("Neuspješan unos!");
                    resetirajVrijednosti();
                }
            

            }
            else
            {
                MessageBox.Show("Prazna polja");
                //resetirajVrijednosti();
            }
        }

        private void naruciNoviUltrazvuk()
        {
            if(dgvTrudnice.SelectedRows[0].Index != 0)
            {
                conn.Open();

                sql = @"select * from naruci_sljedeci_ultrazvuk(@trudnica)";

                naredba = new NpgsqlCommand(sql, conn);
                naredba.Parameters.AddWithValue("@trudnica", OznaciTrudnicu());

                naredba.ExecuteScalar();

                conn.Close();
            }
        }

        private void naruciNovuKontrolu()
        {
            if (dgvTrudnice.SelectedRows[0].Index != 0)
            {
                //string trudnica = dgvTrudnice.SelectedRows[0].Cells[0].Value.ToString();
                conn.Open();

                sql = @"select * from naruci_novu_kontrolu(@trudnica)";

                naredba = new NpgsqlCommand(sql, conn);
                naredba.Parameters.AddWithValue("@trudnica", OznaciTrudnicu());

                naredba.ExecuteScalar();

                conn.Close();
            }
        }



        private void FormaTrudnice_Load(object sender, EventArgs e)
        {
            ucitajTrudnice();
        }

        private void btnUnosTrudnice_Click(object sender, EventArgs e)
        {
            unesiTrudnicuNoviNacin();
            ucitajTrudnice();
        }

        private void btnObrisiTrudnicu_Click(object sender, EventArgs e)
        {
            ObrisiTrudnicu();
            ucitajTrudnice();
        }

        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            //AzurirajTrudnicu();
            if (OznaciTrudnicu() != -1)
            {
                FormaAžuriranjeTrud forma = new FormaAžuriranjeTrud(konekcija, OznaciTrudnicu());
                forma.ShowDialog();
            }
            ucitajTrudnice();

        }

        private void btnFrmUltrazvuk_Click(object sender, EventArgs e)
        {
            FormaUltrazvuk forma = new FormaUltrazvuk(konekcija);
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            naruciNoviUltrazvuk();
            FormaUltrazvuk forma = new FormaUltrazvuk(konekcija);
            forma.ShowDialog();
        }

        private void btnPrikazSvihTrudnica_Click(object sender, EventArgs e)
        {
            ucitajTrudnice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaCTG forma = new FormaCTG(konekcija);
            forma.ShowDialog();

        }

        private void btnPrikazKontrola_Click(object sender, EventArgs e)
        {
            FormKontrola forma = new FormKontrola(konekcija);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            naruciNovuKontrolu();
            FormKontrola forma = new FormKontrola(konekcija);
            forma.ShowDialog();
        }
    }
}
