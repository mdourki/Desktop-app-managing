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
    public partial class FormOrders : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-F8FCMSR\SQLEXPRESS;Initial Catalog=MagasinDB;Integrated Security=True");
        public FormOrders()
        {
            InitializeComponent();
            cnx.Open();
            string requete = "select no_cmd as No_du_Commande , date_commande as Date_de_commande";
            requete += " , date_livraison as Date_de_livraison ,no_clt as No_Client , no_emp as No_Employé from commande";
            SqlDataAdapter SDA = new SqlDataAdapter(requete, cnx);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
