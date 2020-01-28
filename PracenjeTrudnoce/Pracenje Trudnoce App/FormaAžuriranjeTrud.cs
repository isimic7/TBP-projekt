using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Pracenje_Trudnoce_App
{
    public partial class FormaAžuriranjeTrud : Form
    {
        private string konekcija = null;
        public int idTrud = 0;
        public FormaAžuriranjeTrud(string kon, int ID)
        {
            InitializeComponent();
            konekcija = kon;
            idTrud = ID;
        }

        public NpgsqlConnection conn;
        private NpgsqlCommand naredba;
        private string sql = null;

        private void ažuriranjeTrudnice()
        {
            conn = new NpgsqlConnection(konekcija);
            
            conn.Open();
            if (txtEmail.Text.Length!=0 && txtIme.Text.Length!=0 && txtKontakt1.Text.Length!=0 && txtKontakt2.Text.Length!=0 
                && txtKontakt3.Text.Length!=0 && txtPrezime.Text.Length!=0)
            {
                string kontakt = txtKontakt1.Text + "-" + txtKontakt2.Text + "-" + txtKontakt3.Text;
                sql = @"select from azuriraj_trud(@idTr,@ime,@prezime,@kontakt,@email)";
                naredba = new NpgsqlCommand(sql, conn);
                naredba.Parameters.AddWithValue("@idTr",idTrud);
                naredba.Parameters.AddWithValue("@ime", txtIme.Text);
                naredba.Parameters.AddWithValue("@prezime", txtPrezime.Text);
                naredba.Parameters.AddWithValue("@kontakt", kontakt);
                naredba.Parameters.AddWithValue("@email", txtEmail.Text);
                naredba.ExecuteNonQuery();

                System.Threading.Thread.Sleep(500);
                this.Close();


                conn.Close();
            }
            else
            {
                MessageBox.Show("Prazna polja, neispravan unos!");
            }
            
        }

        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            ažuriranjeTrudnice();
        }
    }
}
