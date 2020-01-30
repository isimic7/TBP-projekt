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
    public partial class FormaUltrazvuk : Form
    {
        public string konekcija = null;
        public FormaUltrazvuk(string konek)
        {
            InitializeComponent();
            konekcija = konek;
        }

        public NpgsqlConnection conn;
        private DataTable tablica;
        private NpgsqlCommand naredba;
        private string sql = null;

        private void ucitajUltrazvuke()
        {
            conn = new NpgsqlConnection(konekcija);
            dgvUltrazvuci.DataSource = null;
            conn.Open();
            sql = $"SELECT * FROM dohvati_ultrazvuke()";
            naredba = new NpgsqlCommand(sql, conn);
            tablica = new DataTable();
            tablica.Load(naredba.ExecuteReader());
            dgvUltrazvuci.DataSource = tablica;

            dgvUltrazvuci.Columns[4].Visible = false;
            richTextBox1.Clear();
            foreach (DataGridViewRow item in this.dgvUltrazvuci.SelectedRows)
            {
                richTextBox1.Text += item.Cells["napomene"].Value.ToString(); 
            }

            conn.Close();
        }

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

        private int OznaciUltrazvuk()
        {
            string idUltrazvuk = null;
            int index = -1;

            index = dgvUltrazvuci.SelectedRows[0].Index;
            if (index != -1)
            {
                idUltrazvuk = dgvUltrazvuci.SelectedRows[0].Cells["ultrazvuk_id"].Value.ToString();
            }

            return int.Parse(idUltrazvuk);
        }

        private int oznaciLijecnika()
        {
            string idLijecnik = null;
            int index = -1;

            index = dgvLijecnici.SelectedRows[0].Index;
            if(index != -1)
            {
                idLijecnik = dgvLijecnici.SelectedRows[0].Cells["lijecnik_id"].Value.ToString();
            }

            return int.Parse(idLijecnik);
        }

        private void dopuniUltrazvuk()
        {
            //int rezultat = 0;


            if (cmbSat.SelectedIndex != -1 && cmbMinute.SelectedIndex != -1 &&
                cmbSpol.SelectedIndex != -1 && richNapomenaPopuni.Text.Length != 0 && oznaciLijecnika() != 0 &&
                OznaciUltrazvuk() != 0)
            {

                string vrijeme_konvert = cmbSat.SelectedItem.ToString() + ":" + cmbMinute.SelectedItem.ToString();
                DateTime vrijemee = DateTime.Parse(vrijeme_konvert);



                conn.Open();

                sql = @"select * from dopuni_ultrazvuk(@ult_id, @_vrijeme, @_napomene,@_spol, @lijecnik)";
                naredba = new NpgsqlCommand(sql, conn);
                naredba.Parameters.Add(new NpgsqlParameter("@ult_id", OznaciUltrazvuk()));
                naredba.Parameters.Add(new NpgsqlParameter("@_vrijeme", vrijemee));
                naredba.Parameters.Add(new NpgsqlParameter("@_napomene", richNapomenaPopuni.Text));
                naredba.Parameters.Add(new NpgsqlParameter("@_spol", cmbSpol.SelectedItem.ToString()));
                naredba.Parameters.Add(new NpgsqlParameter("@lijecnik", oznaciLijecnika()));

                naredba.ExecuteNonQuery();
                // rezultat = naredba.ExecuteNonQuery();

                cmbMinute.SelectedIndex = -1;
                cmbSat.SelectedIndex = -1;
                cmbSpol.SelectedIndex = -1;
                richNapomenaPopuni.Clear();
                conn.Close();
            }
        }

        private void obrisiUltrazvuk()
        {
            conn.Open();
            sql = "delete from ultrazvuk where ultrazvuk_id = :_ultrazvuk";
            naredba = new NpgsqlCommand(sql, conn);
            naredba.Parameters.Add(new NpgsqlParameter(":_ultrazvuk", OznaciUltrazvuk()));
            conn.Close();
        }

        private void FormaUltrazvuk_Load(object sender, EventArgs e)
        {
            ucitajUltrazvuke();
            prikaziLijecnike();
        }

        private void dgvUltrazvuci_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (DataGridViewRow item in this.dgvUltrazvuci.SelectedRows)
            {
                
                richTextBox1.Text += item.Cells["napomene"].Value.ToString(); 
            }
        }

        private void btnDopuniUltrazvuk_Click(object sender, EventArgs e)
        {
            dopuniUltrazvuk();
            
            ucitajUltrazvuke();
        }

        private void btnObrisiUltrazvuk_Click(object sender, EventArgs e)
        {
            obrisiUltrazvuk();
            ucitajUltrazvuke();
        }
    }
}
