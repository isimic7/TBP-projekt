using Npgsql;
using System;
using System.Windows.Forms;


namespace Pracenje_Trudnoce_App
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        public NpgsqlConnection conn;



        public string connString = String.Format("Server={0};Port={1};" +
            "userID={2};Password={3};Database={4};", "localhost", "5432", "postgres", "postgres", "TBP-Projekt");

        private void btnTrudnice_Click(object sender, EventArgs e)
        {
            FormaTrudnice forma = new FormaTrudnice(connString);
            forma.ShowDialog();
        }
    }
}
