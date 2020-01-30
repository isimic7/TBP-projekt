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
    public partial class FormaCTG : Form
    {
        public string konekcija = null;
        public FormaCTG(string konek)
        {
            InitializeComponent();
            konekcija = konek;
        }

        public NpgsqlConnection conn;
        private DataTable tablica;
        private NpgsqlCommand naredba;
        private string sql = null;


        private void prikaziLijecnike()
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

        private void dohvatiSveCTG()
        {
            conn = new NpgsqlConnection(konekcija);
            conn.Open();
            dgvCTG.DataSource = null;
            sql = @"select * from dohvati_ctge()";
            naredba = new NpgsqlCommand(sql, conn);
            tablica = new DataTable();
            tablica.Load(naredba.ExecuteReader());
            dgvCTG.DataSource = tablica;
            dgvCTG.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            conn.Close();
        }

        private void provjeriZaCTG()
        {
            conn = new NpgsqlConnection(konekcija);
            conn.Open();
            dgvSpremnCTG.DataSource = null;
            sql = @"select * from provjeri_potrebu_ctg()";
            naredba = new NpgsqlCommand(sql, conn);
            tablica = new DataTable();
            tablica.Load(naredba.ExecuteReader());
            dgvSpremnCTG.DataSource = tablica;
            conn.Close();
        }

       

        private int OznaciTrudnicu()
        {
            string idTrudnica = null;
            int index = -1;

            
                index = dgvSpremnCTG.SelectedRows[0].Index;
                if (index != -1)
                {
                    idTrudnica = dgvSpremnCTG.SelectedRows[0].Cells["trudnica_id"].Value.ToString();
                }

            return int.Parse(idTrudnica);
        }

        private void naruciCTGZaOdabranu()
        {
            conn.Open();
            //dgvCTG.DataSource = null;
            sql = @"select * from naruci_ctg(@_datum,@_trudnica)";

            naredba = new NpgsqlCommand(sql, conn);

            naredba.Parameters.Add(new NpgsqlParameter("@_datum", dateTimePicker1.Value));
            naredba.Parameters.Add(new NpgsqlParameter("@_trudnica", OznaciTrudnicu()));
            naredba.ExecuteNonQuery();

            /*tablica = new DataTable();
            tablica.Load(naredba.ExecuteReader());
            dgvCTG.DataSource = tablica;*/
            conn.Close();
        }

        void dopuniCTG()
        {
            string lijecnik = dgvLijecnici.SelectedRows[0].Cells[0].Value.ToString();
            string ctg = dgvCTG.SelectedRows[0].Cells[0].Value.ToString();
            if (lijecnik!=null && ctg!=null && richOPIS.Text.Length!=0)
            {
                conn.Open();
                sql = @"select * from dopuni_ctg(@_ctg, @_lijecnik, @_opis)";
                naredba = new NpgsqlCommand(sql, conn);
                naredba.Parameters.Add(new NpgsqlParameter("@_ctg",int.Parse(ctg)));
                naredba.Parameters.Add(new NpgsqlParameter("@_lijecnik",int.Parse(lijecnik)));
                naredba.Parameters.Add(new NpgsqlParameter("@_opis",richOPIS.Text));
                naredba.ExecuteNonQuery();
                prikaziLijecnike();
                richOPIS.Clear();
                conn.Close();
            }
            
        }

       

        private void FormaCTG_Load(object sender, EventArgs e)
        {        
            provjeriZaCTG();
            dohvatiSveCTG();
            prikaziLijecnike();
        }

        private void btnNaruciCTG_Click(object sender, EventArgs e)
        {
            naruciCTGZaOdabranu();
            dohvatiSveCTG();
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dopuniCTG();
            dohvatiSveCTG();
        }
    }
}
