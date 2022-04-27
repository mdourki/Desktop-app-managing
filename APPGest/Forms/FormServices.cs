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

namespace APPGest.Forms
{
    public partial class FormServices : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-F8FCMSR\SQLEXPRESS;Initial Catalog=MagasinDB;Integrated Security=True");
        public FormServices()
        {
            InitializeComponent();
            cnx.Open();
            string requete = "select no_srv as No_Service , nom as Nom from Service";
            SqlDataAdapter SDA = new SqlDataAdapter(requete, cnx);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void FormServices_Load(object sender, EventArgs e)
        {

        }
    }
}
