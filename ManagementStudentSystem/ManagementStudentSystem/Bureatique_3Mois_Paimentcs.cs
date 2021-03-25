using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStudentSystem
{
    public partial class Bureatique_3Mois_Paimentcs : Form
    {
        public Bureatique_3Mois_Paimentcs()
        {
            InitializeComponent();
        }
        SqlConnection con =
new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bureatique3Mois;Integrated Security=True;Pooling=False");

        private void Bureatique_3Mois_Paimentcs_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bureatique3mois_Paiment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
