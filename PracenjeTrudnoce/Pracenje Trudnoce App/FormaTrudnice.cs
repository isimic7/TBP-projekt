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
        private string konekcija = null;
        public FormaTrudnice(string konek)
        {
            InitializeComponent();
            konekcija = konek;
        }

        public NpgsqlConnection conn;
        private DataTable tablica;
        private NpgsqlCommand naredba;
        private string sql = null;

        private void FormaTrudnice_Load(object sender, EventArgs e)
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
    }
}
