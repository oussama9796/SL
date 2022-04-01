using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31614\source\repos\SL\SL\Database1.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM Gebruiker where gebruikersnaam = '" + txtGebruikersnaam.Text.Trim() +
                        "' AND wachtwoord = '" + txtWachtwoord.Text.Trim() + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query , conn);
                    DataTable dta = new DataTable();
                    adapter.Fill(dta);
                    Console.WriteLine(dta.TableName);
                    if (dta.Rows.Count == 1)
                    {
                        DataRow row = dta.AsEnumerable().FirstOrDefault();
                        Gebruiker gebruiker = new Gebruiker(row.Field<int>("Id"), row.Field<String>("gebruikersnaam"), row.Field<String>("wachtwoord"));
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.gebruiker = gebruiker;
                        form1.Show();
                    }
                }
            }
        }

        private bool isValid()
        {
            if (txtGebruikersnaam.Text.TrimStart() == string.Empty) 
            {
                MessageBox.Show("Gebruikersnaam ongeldig!", "Error");
                return false;
            }else if (txtWachtwoord.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Wachtwoord ongeldig!", "Error");
                return false;
            }
            return true;

        }
    }
}
