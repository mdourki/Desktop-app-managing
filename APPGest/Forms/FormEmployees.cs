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
    public partial class FormEmployees : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-F8FCMSR\SQLEXPRESS;Initial Catalog=MagasinDB;Integrated Security=True");
        public FormEmployees()
        {
            InitializeComponent();
            cnx.Open();
            string requete = "select no_emp as No_Employé , nom as Nom , prenom as Prénom , tel as Tél ,";
            requete += "adresse as Adresse , date_entree as Date_Entrée , no_srv as No_Service from employe";
            SqlDataAdapter SDA = new SqlDataAdapter(requete, cnx);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
