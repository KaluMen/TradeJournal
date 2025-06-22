using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;


namespace Journal
{
    public partial class Form2 : Form
    {
        OleDbConnection kon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bossk\OneDrive\Desktop\Journal\Journal.accdb");

        public Form2()
        {
            InitializeComponent();
        }

        private void azuriraj()
        {
            //Refresh svaki put kad se forma pokrene
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'journalDataSet.Trades' table. You can move, or remove it, as needed.
            this.tradesTableAdapter.Fill(this.journalDataSet.Trades);
            azuriraj();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exit dugme
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        { //Dugme za filtriranje 

            int mesec = dateTimePicker1.Value.Month;
            int godina = dateTimePicker1.Value.Year;
            try
            {
                DataTable dt = new DataTable();
                kon.Open();
                string query = "SELECT * FROM Trades WHERE MONTH([DateTime]) = ? AND YEAR([DateTime]) = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, kon))
                {
                    cmd.Parameters.AddWithValue("?", mesec);
                    cmd.Parameters.AddWithValue("?", godina);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        adapter.Fill(dt);
                }
                dataGridView1.DataSource = dt;

                double ukupniPnL = 0;
                int win = 0, lose = 0, be = 0;

                Dictionary<DayOfWeek, List<double>> pnlPoDanu = new Dictionary<DayOfWeek, List<double>>();

                foreach (DataRow row in dt.Rows)
                {
                    double PnL = Convert.ToDouble(row["PnL"]);
                    DateTime datum = Convert.ToDateTime(row["DateTime"]);
                    DayOfWeek dan = datum.DayOfWeek;

                    ukupniPnL += PnL;

                    if (PnL > 0) win++;
                    else if (PnL < 0) lose++;
                    else be++;

                    if (dan >= DayOfWeek.Monday && dan <= DayOfWeek.Friday)
                    {
                        if (!pnlPoDanu.ContainsKey(dan))
                            pnlPoDanu[dan] = new List<double>();
                        pnlPoDanu[dan].Add(PnL);
                    }
                }

                int ukupno = win + lose + be;
                double winrate = ukupno > 0 ? (win * 100.0) / ukupno : 0;
                label3.Text = winrate.ToString("F2") + " %";
                label5.Text = ukupniPnL.ToString("F2") + " $";

                chart1.Series["PnL"].Points.Clear();

                var dani = new[] {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
            };
                foreach (var dan in dani)
                {
                    string oznake = "";

                    switch (dan)
                    {
                        case DayOfWeek.Monday:
                            oznake = "Pon"; break;
                        case DayOfWeek.Tuesday:
                            oznake = "Uto"; break;
                        case DayOfWeek.Wednesday:
                            oznake = "Sre"; break;
                        case DayOfWeek.Thursday:
                            oznake = "Čet"; break;
                        case DayOfWeek.Friday:
                            oznake = "Pet"; break;
                        default:
                            oznake = ""; break;
                    }

                    double prosek = pnlPoDanu.ContainsKey(dan)
                        ? pnlPoDanu[dan].Average()
                        : 0;
                    chart1.Series["PnL"].Points.AddXY(oznake, prosek);
                }
                kon.Close();
            }
            catch(Exception ex) {
                MessageBox.Show("Greska" + ex.Message);
            }

        }
    }
}
