using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;

namespace Journal
{
    public partial class Form1 : Form
    {
        OleDbConnection kon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bossk\OneDrive\Desktop\Journal\Journal.accdb");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'journalDataSet.Pairs' table. You can move, or remove it, as needed.
            this.pairsTableAdapter.Fill(this.journalDataSet.Pairs);
            // TODO: This line of code loads data into the 'journalDataSet.Trades' table. You can move, or remove it, as needed.
            this.tradesTableAdapter.Fill(this.journalDataSet.Trades);
            azuriraj();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void azuriraj()
        {
            //Refresh svaki put kad se aplikacija pokrene
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT TradeID, PairID, DateTime, PnL FROM Trades";
                using (OleDbCommand cmd = new OleDbCommand(sql, kon))
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom osvežavanja: " + ex.Message);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        { // Dugme za statistiku
            Form2 druga = new Form2();
            druga.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {   // Dugme Uputstva

            MessageBox.Show("U prvom prozoru Journal aplikacije mozete da unesete Vas trade (Par, Datum, PnL)\n" +
                            "Da ga izmenite direktno iz aplikacije ili izbrisete ako pogresno unesete, takodje ce se baza azurirati i prikazati vam u prozoru ispod\n" +
                            "takodje pored je tabela sa Id-jem para koji ste trejdovali zbog lakseg unosa. \n" +
                            "Klikom na Statistics otvara se drugi prozor gde mozete da izaberete mesec u kom ste trejdovali da vidite statistiku ili vas uspeh/neuspeh\n" +
                            "Prikazace vam se Winrate, ukupan PnL, i grafikon sa podacima kojim danima ste najvise zaradjivali/gubili.\n" +
                            "Na dugme Exit napustate prozor/aplikaciju");
        }

        private void button5_Click(object sender, EventArgs e)
        { // Exit dugme
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { //Insert dugme

            try
            { 
                kon.Open();
                string sql = "INSERT INTO Trades (PairID, [DateTime], PnL) VALUES (?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(sql, kon))
                {
                    // Parsiranje pairID ako je broj
                    int PairIdValue;
                    if (!int.TryParse(textBox1.Text, out PairIdValue))
                    {
                        MessageBox.Show("Unesite ispravan broj za PairID");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@PairID", PairIdValue);

                    // Datum - samo datum bez vremena
                    cmd.Parameters.AddWithValue("@DateTime", dateTimePicker1.Value.Date);

                    // PnL - decimalni broj
                    double pnlValue;
                    if (!double.TryParse(textBox2.Text, out pnlValue))
                    {
                        MessageBox.Show("Unesite ispravan broj za PnL");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@PnL", pnlValue);
                    cmd.ExecuteNonQuery();
                    azuriraj();
                    kon.Close();
                    
                }
                
                MessageBox.Show("Uspešno dodat trade!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo selektujte red koji želite da izmenite.");
                    return;
                }

                // 1. Uzimanje TradeID iz selektovanog reda
                int tradeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // 2. Validacija unosa
                int pairId;
                if (!int.TryParse(textBox1.Text, out pairId))
                {
                    MessageBox.Show("Unesite validan broj za PairID.");
                    return;
                }

                double pnl;
                if (!double.TryParse(textBox2.Text.Replace(',', '.'), out pnl))
                {
                    MessageBox.Show("Unesite ispravan broj za PnL.");
                    return;
                }

                // 3. Priprema konekcije i komande
                kon.Open();
                string query = "UPDATE Trades SET PairID = ?, [DateTime] = ?, PnL = ? WHERE TradeID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, kon))
                {
                    cmd.Parameters.AddWithValue("?", pairId);
                    cmd.Parameters.AddWithValue("?", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("?", pnl);
                    cmd.Parameters.AddWithValue("?", tradeId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Uspešno izmenjeno!");
                azuriraj();
                kon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) {
                MessageBox.Show("Molimo selektujte red koji zelite obrisati.");
                return;
            }

            DialogResult rezultat = MessageBox.Show("Da li ste sigurni da zelite da obrisete selektovani red?",
                                                    "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {

                try
                {
                    int tradeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    kon.Open();
                    string query = "DELETE FROM Trades WHERE TradeID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, kon))
                    {
                        cmd.Parameters.AddWithValue("?", tradeID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Uspesno Obrisano!");
                    azuriraj();
                    kon.Close();

                }
                catch (Exception ex) {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Otkazano brisanje.");
            }
}}}