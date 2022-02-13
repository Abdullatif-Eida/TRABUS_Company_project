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


namespace TRABUS_Company_project
{
    public partial class Create_ElectronicCard : Form
    {
        public Create_ElectronicCard()
        {
            InitializeComponent();
        }

        private void Create_ElectronicCard_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-V9AF34JG\SQLEXPRESS;
                Initial Catalog=Company; Integrated Security=true;");

            connect.Open();
            SqlCommand command1 = new SqlCommand("Select max(Card_id)+1 from ElectronicCard", connect);
            SqlDataReader reader = command1.ExecuteReader();
            reader.Read();
            textBox15.Text = reader[0].ToString();
            connect.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-V9AF34JG\SQLEXPRESS;
                Initial Catalog=Company; Integrated Security=true;");
            connect.Open();
            SqlCommand command1 =
                new SqlCommand("Insert into ElectronicCard(Points)" +
                "values('" + textBox5.Text + "')", connect);
            command1.ExecuteNonQuery();
            MessageBox.Show("Adding Card done Successfully...");
            textBox5.Text = "";
            String id = textBox15.Text;
            int newid = int.Parse(id) + 1;
            textBox15.Text = newid.ToString();
            connect.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateI_stanbul_Card istanbul = new CreateI_stanbul_Card();
            istanbul.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Create_BlueCard blue = new Create_BlueCard();
            blue.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Create_ElectronicCard elec = new Create_ElectronicCard();
            elec.Show();
        }
    }

}
