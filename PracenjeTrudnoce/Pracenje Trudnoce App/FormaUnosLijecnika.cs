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
    public partial class FormaUnosLijecnika : Form
    {
        public string konekcija = null;
        public FormaUnosLijecnika(string kon)
        {
            InitializeComponent();
            konekcija = kon;
        }

        public NpgsqlConnection conn;
        private NpgsqlCommand naredba;
        private string sql = null;

        private void UnesiLijecnika()
        {
            conn = new NpgsqlConnection(konekcija);
            conn.Open();
            if (txtIme.Text!=null && txtPrezime.Text!=null)
            {
                NpgsqlCommand naredba = new NpgsqlCommand(@"insert into lijecnik (ime,prezime) values(@ime,@prezime)", conn);
                naredba.Parameters.AddWithValue("@ime", txtIme.Text);
                naredba.Parameters.AddWithValue("@prezime", txtPrezime.Text);
                naredba.ExecuteNonQuery();
                
            }
            conn.Close();

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            UnesiLijecnika();
            this.Close();
        }
    }
}
