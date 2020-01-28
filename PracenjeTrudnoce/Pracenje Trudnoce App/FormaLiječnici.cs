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
    public partial class FormaLiječnici : Form
    {
        public string konekcija = null;
        public FormaLiječnici(string kon)
        {
            InitializeComponent();
            konekcija = kon;
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

        private void FormaLiječnici_Load(object sender, EventArgs e)
        {
            prikaziLijecnike();
        }

        private void btnUnesiLijecnika_Click(object sender, EventArgs e)
        {
            FormaUnosLijecnika forma = new FormaUnosLijecnika(konekcija);
            forma.ShowDialog();
            prikaziLijecnike();
        }
    }
}
