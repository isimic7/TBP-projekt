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
    public partial class FormKontrola : Form
    {
        public string konekcija = null;
        public FormKontrola(string kon)
        {
            InitializeComponent();
            konekcija = kon;
        }

        public NpgsqlConnection conn;
        private DataTable tablica;
        private NpgsqlCommand naredba;
        private string sql = null;

        private int oznaciKontrolu()
        {
            string idKont = null;
            int index = -1;

            index = dgvKontrola.SelectedRows[0].Index;
            if (index != -1)
            {
                idKont = dgvKontrola.SelectedRows[0].Cells["kontrola_id"].Value.ToString();
            }

            return int.Parse(idKont);
        }


        private void dohvatiKontrole()
        {
            conn = new NpgsqlConnection(konekcija);
            dgvKontrola.DataSource = null;
            conn.Open();
            sql = $"SELECT * from dohvati_kontrole()";
            naredba = new NpgsqlCommand(sql, conn);
            tablica = new DataTable();
            tablica.Load(naredba.ExecuteReader());
            dgvKontrola.DataSource = tablica;
            conn.Close();
        }

        private void dohvatiLijecnike()
        {
            conn = new NpgsqlConnection(konekcija);
            dgvLijecnici.DataSource = null;
            conn.Open();

            sql = $"SELECT * from dohvati_sve_lijecnike()";
            naredba = new NpgsqlCommand(sql, conn);
            tablica = new DataTable();
            tablica.Load(naredba.ExecuteReader());
            dgvLijecnici.DataSource = tablica;

            conn.Close();
        }

        private void dopuniKontrolu()
        {
            if (txtHematokrit.Text!=null && txtHemoglobin.Text != null 
                && txttSecer.Text != null && cmbSat.SelectedIndex != -1 && cmbMinute.SelectedIndex != -1 &&
                richSTANJE.Text != null)
            {
                string vrijeme_konvert = cmbSat.SelectedItem.ToString() + ":" + cmbMinute.SelectedItem.ToString();
                DateTime vrijem = DateTime.Parse(vrijeme_konvert);
                string kontrolaa = dgvKontrola.SelectedRows[0].Cells[0].Value.ToString();
                string lijecnikk = dgvLijecnici.SelectedRows[0].Cells[0].Value.ToString();

                conn.Open();
                //sql = @"select * from dopuni_kontrolu(@_kontrola,@_vrijeme,@_lijecnik,@_secer,@_hemoglobin, @_hematokrit,@_stanje)";
                sql = "update kontrola set vrijeme = :_vrijeme, pregledao = :_lijecnik, secer = :_secer, hemoglobin = :_hemoglobin, stanje = :_stanje where kontrola_id = :_kontrola";
                naredba = new NpgsqlCommand(sql, conn);

               
                naredba.Parameters.Add(new NpgsqlParameter(":_vrijeme", vrijem));
                naredba.Parameters.Add(new NpgsqlParameter(":_lijecnik", int.Parse(lijecnikk)));
                naredba.Parameters.Add(new NpgsqlParameter(":_secer", txttSecer.Text));
                naredba.Parameters.Add(new NpgsqlParameter(":_hemoglobin",txtHemoglobin.Text));
                naredba.Parameters.Add(new NpgsqlParameter(":_hematokrit", txtHematokrit.Text));
                naredba.Parameters.Add(new NpgsqlParameter(":_stanje", richSTANJE.Text));
                naredba.Parameters.Add(new NpgsqlParameter(":_kontrola", oznaciKontrolu()));


                naredba.ExecuteNonQuery();

                cmbMinute.SelectedIndex = -1;
                cmbSat.SelectedIndex = -1;
                richSTANJE.Clear();
                txttSecer.Clear();
                txtHemoglobin.Clear();
                txtHematokrit.Clear();

                conn.Close();
            }                         
        }



        private void FormKontrola_Load(object sender, EventArgs e)
        {
            dohvatiKontrole();
            dohvatiLijecnike();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dopuniKontrolu();
            dohvatiKontrole();
        }
    }
}
