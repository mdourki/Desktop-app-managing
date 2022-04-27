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
    public partial class FormProduct : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-F8FCMSR\SQLEXPRESS;Initial Catalog=MagasinDB;Integrated Security=True");
        public FormProduct()
        {
            InitializeComponent();
            LoadTheme();
            cnx.Open();
            string requete = "select no_prdt as No_du_produit , nom as Nom , description as Description ,";
            requete += "prix as Prix , no_cmd as No_du_Commande from produit";
            SqlDataAdapter SDA = new SqlDataAdapter(requete, cnx);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void LoadTheme()
        {
            //dataGridView1.RowsDefaultCellStyle.BackColor = themeColor.PrimaryColor;
            //dataGridView1.RowsDefaultCellStyle.SelectionBackColor = themeColor.SecondaryColor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
