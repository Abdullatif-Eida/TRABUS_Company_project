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
    public partial class Blue_Card_Form : Form
    {
        public static int count = 0;

        public Blue_Card_Form()
        {
            InitializeComponent();
        }

        private void Blue_Card_Form_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-V9AF34JG\SQLEXPRESS;
                Initial Catalog=Company; Integrated Security=true;");

            DataTable dtt = new DataTable();
            SqlDataAdapter getid = new SqlDataAdapter("select * from BlueCard", connect);
            getid.Fill(dtt);
            comboBox1.DataSource = dtt;
            comboBox1.DisplayMember = "Card_id";

            textBox5.DataBindings.Add("Text", dtt, "Customer_name");
            textBox1.DataBindings.Add("Text", dtt, "Customer_Type");
            textBox7.DataBindings.Add("Text", dtt, "Points");
            textBox8.DataBindings.Add("Text", dtt, "Customer_ID");

            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount = 9;
            dataGridView1.Columns[0].Name = "Card ID";
            dataGridView1.Columns[1].Name = "Customer ID";
            dataGridView1.Columns[2].Name = "Customer Name";
            dataGridView1.Columns[3].Name = " Customer Type ";
            dataGridView1.Columns[4].Name = "Deducted Amount";
            dataGridView1.Columns[5].Name = "New Card points";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            int card_id, customer_id, transfernumber, stopsnumber, points;
            string customer_type, vehicle_type, customer_name;
            double Deducted_amount;
            card_id = Convert.ToInt32(comboBox1.Text);
            customer_id = Convert.ToInt32(textBox8.Text);
            customer_name = textBox5.Text;
            customer_type = textBox1.Text;
            vehicle_type = comboBox3.Text;
            points = Convert.ToInt32(textBox7.Text);
            Blue_Card BlueCard = new Blue_Card(card_id, customer_id, customer_name ,customer_type, points);
            if (vehicle_type == "Bus")
            {
                transfernumber = Convert.ToInt32(comboBox4.Text);
                Deducted_amount = BlueCard.transfer(transfernumber);
            }
            else if (vehicle_type == "Metrobus")
            {
                stopsnumber = Convert.ToInt32(textBox2.Text);
                Deducted_amount = BlueCard.metrobus(stopsnumber);
            }
            else
            {
                MessageBox.Show("Please Choise Vehicle Type");
                Deducted_amount = 0;
            }
            textBox9.Text = Deducted_amount.ToString();
            textBox6.Text = BlueCard.Points.ToString();

            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-V9AF34JG\SQLEXPRESS;
                Initial Catalog=Company; Integrated Security=true;");
            connect.Open();
            int cardid = int.Parse(comboBox1.Text);
            SqlCommand command1 =
                new SqlCommand("update BlueCard SET Points='" + textBox6.Text + "' where Card_id='" + cardid + "'", connect);
            command1.ExecuteNonQuery();
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int card_id, customer_id, transfernumber, stopsnumber, points;
            string customer_type, vehicle_type, customer_name;
            double Deducted_amount;
            card_id = Convert.ToInt32(comboBox1.Text);
            customer_id = Convert.ToInt32(textBox8.Text);
            customer_name = textBox5.Text;
            customer_type = textBox1.Text;
            vehicle_type = comboBox3.Text;
            points = Convert.ToInt32(textBox7.Text);
            Blue_Card BlueCard = new Blue_Card(card_id, customer_id, customer_name, customer_type, points);
            if (vehicle_type == "Bus")
            {
                transfernumber = Convert.ToInt32(comboBox4.Text);
                Deducted_amount = BlueCard.transfer(transfernumber);
            }
            else if (vehicle_type == "Metrobus")
            {
                stopsnumber = Convert.ToInt32(textBox2.Text);
                Deducted_amount = BlueCard.metrobus(stopsnumber);
            }
            else
            {
                MessageBox.Show("Please Choise Vehicle Type");
                Deducted_amount = 0;
            }
            dataGridView1.Rows[count].Cells[0].Value = BlueCard.Card_id.ToString();
            dataGridView1.Rows[count].Cells[1].Value = BlueCard.Customer_id;
            dataGridView1.Rows[count].Cells[2].Value = BlueCard.Customer_name.ToString();
            dataGridView1.Rows[count].Cells[3].Value = BlueCard.Customer_type.ToString();
            dataGridView1.Rows[count].Cells[4].Value = Deducted_amount.ToString();
            dataGridView1.Rows[count].Cells[5].Value = BlueCard.Points.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Istanbul_Card_Form istanbul = new Istanbul_Card_Form();
            istanbul.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Electronic_card_form electronic = new Electronic_card_form();
            electronic.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
