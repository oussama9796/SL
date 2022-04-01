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
    public partial class Form1 : Form
    {
        public Gebruiker gebruiker { get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\31614\source\repos\SL\SL\Database1.mdf;Integrated Security=True"))
                {

                }
                    
            }
            
        }

        private bool isValid()
        {
            if (txtProduct.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Product is leeg", "Error");
                return false;
            }
            return true;

        }
    }
}
