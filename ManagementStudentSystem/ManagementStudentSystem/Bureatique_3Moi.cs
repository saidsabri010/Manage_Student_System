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
    public partial class Bureatique_3Moi : Form
    {
        public Bureatique_3Moi()
        {
            InitializeComponent();
        }
      
        SqlConnection con =
new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bureatique3Mois;Integrated Security=True;Pooling=False");

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bureatique_3Mois", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Bureatique_3Mois WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Successfully Deleted!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Bureatique_3Mois WHERE Nom=@Nom", con);
            cmd.Parameters.AddWithValue("@Nom", textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con =
           new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bureatique3Mois;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Bureatique_3Mois VALUES (@Prénom,@Nom,@Date_de_Naissance,@LeGroup,@Date_Dentre,@Validation)", con);
            cmd.Parameters.AddWithValue("@Prénom", textBox1.Text);
            cmd.Parameters.AddWithValue("@Nom", textBox2.Text);
            cmd.Parameters.AddWithValue("@Date_De_Naissance", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            cmd.Parameters.AddWithValue("@Date_Dentre", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
            cmd.Parameters.AddWithValue("@LeGroup", textBox3.Text);
            cmd.Parameters.AddWithValue("@Validation", textBox7.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.Refresh();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Successfully Inserted!!");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con =
          new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bureatique3Mois;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Bureatique_3Mois SET Prénom=@Prénom, Nom=@Nom,Date_De_Naissance=@Date_De_Naissance,LeGroup=@LeGroup,Date_Dentre=@Date_Dentre,Validation=@Validation WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Prénom", textBox1.Text);
            cmd.Parameters.AddWithValue("@Nom", textBox2.Text);
            cmd.Parameters.AddWithValue("@Date_De_Naissance", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            cmd.Parameters.AddWithValue("@LeGroup", textBox3.Text);
            cmd.Parameters.AddWithValue("@Date_Dentre", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
            cmd.Parameters.AddWithValue("@Validation", textBox7.Text);
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Successfully Updated!!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Bureatique_3Mois_Paimentcs p = new Bureatique_3Mois_Paimentcs();
            p.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bureatique b = new Bureatique();
            b.Show();
        }

        private void button8_Click(object sender, EventArgs e)
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
