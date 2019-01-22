using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Harcosok
{
    public partial class Harcosok : Form
    {

        const string AdatLetrehozasSql = "create table if not exists felhasznalo(id integer auto_increment primary key, nev varchar(80) not null unique, jelszo varchar(100) not null, regdatum date not null)";

        MySqlConnection conn;

        public Harcosok()
        {
            InitializeComponent();

            try
            {
                conn = new MySqlConnection("Server=localhost;Database=harcosokapp;Uid=root;Pwd=;");
                conn.Open();
                var letrehozas = conn.CreateCommand();
                letrehozas.CommandText = AdatLetrehozasSql;
                letrehozas.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Adatbázis hiba: " + e);
            }
            
        }
        

        private void letrehozasButton_Click(object sender, EventArgs e)
        {
            string nev = harcosNeveTextBox.Text;

            var ellenorzes = conn.CreateCommand();
            ellenorzes.CommandText = "SELECT COUNT(*) FROM harcosok WHERE nev = @nev";
            ellenorzes.Parameters.AddWithValue("@nev", nev);
            var darab = (long)ellenorzes.ExecuteScalar();
            if (darab != 0)
            {
                MessageBox.Show("A név már létezik!");
                return;
            }

            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO `felhasznalo`(`nev`, `leirasTextBox`) VALUES (@nev,@leiras)";
            command.Parameters.AddWithValue("@nev", kepessegNeveTextBox);
            command.Parameters.AddWithValue("@leiras", leirasTextBox);
            int erintettSorok = command.ExecuteNonQuery();

            var harcosok = conn.CreateCommand();
            harcosok.CommandText = "SELECT nev FROM harcosok ORDER BY nev";
            using (var reader = harcosok.ExecuteReader())
            {
                harcosokListbox.Items.Clear();
                while (reader.Read())
                {
                    var nev = reader.GetString("nev");
                    harcosokListbox.Items.Add(nev);
                }
            }
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            var command = conn.CreateCommand();
            command.CommandText = "DELETE FROM `kepessegek` WHERE nev = @nev";
            command.Parameters.AddWithValue("@nev", kepessegekListBox);
            command.ExecuteNonQuery();
        }

        private void modositButton_Click(object sender, EventArgs e)
        {

            var command = conn.CreateCommand();
            command.CommandText = "UPDATE `kepessegek` SET leiras = @leiras WHERE nev = @nev";
            command.Parameters.AddWithValue("@nev", kepessegekListBox);
            command.Parameters.AddWithValue("@leiras", kepessegekLeirasaTextBox.Text);
            command.ExecuteNonQuery();

        }
    }
}
