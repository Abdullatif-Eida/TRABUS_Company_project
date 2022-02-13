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
    public partial class Electronic_card_form : Form
    {
        public static int count = 0;
        public Electronic_card_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Electronic_card_form_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-V9AF34JG\SQLEXPRESS;
                Initial Catalog=Company; Integrated Security=true;");

            DataTable dtt = new DataTable();
            SqlDataAdapter getid = new SqlDataAdapter("select * from ElectronicCard", connect);
            getid.Fill(dtt);
            comboBox1.DataSource = dtt;
            comboBox1.DisplayMember = "Card_id";

            textBox7.DataBindings.Add("Text", dtt, "Points");

            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount = 9;
            dataGridView1.Columns[0].Name = "Card ID";
            dataGridView1.Columns[1].Name = "Points ";
            dataGridView1.Columns[2].Name = "New Card points";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int card_id, transfernumber, stopsnumber, points;
            string  vehicle_type;
            double Deducted_amount;
            card_id = Convert.ToInt32(comboBox1.Text);
            vehicle_type = comboBox3.Text;
            points = Convert.ToInt32(textBox7.Text);
            Electronic_Card ElectronicCard = new Electronic_Card(card_id, points);
            if (vehicle_type == "Bus")
            {
                transfernumber = Convert.ToInt32(comboBox4.Text);
                Deducted_amount = ElectronicCard.transfer(transfernumber);
            }
            else if (vehicle_type == "Metrobus")
            {
                stopsnumber = Convert.ToInt32(textBox2.Text);
                Deducted_amount = ElectronicCard.metrobus(stopsnumber);
            }
            else
            {
                MessageBox.Show("Please Choise Vehicle Type");
                Deducted_amount = 0;
            }
            textBox9.Text = Deducted_amount.ToString();
            textBox6.Text = ElectronicCard.Points.ToString();

            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-V9AF34JG\SQLEXPRESS;
                Initial Catalog=Company; Integrated Security=true;");
            connect.Open();
            int cardid = int.Parse(comboBox1.Text);
            SqlCommand command1 =
                new SqlCommand("update ElectronicCard SET Points='" + textBox6.Text + "' where Card_id='" + cardid + "'", connect);
            command1.ExecuteNonQuery();
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int card_id, transfernumber, stopsnumber, points;
            string vehicle_type;
            double Deducted_amount;
            card_id = Convert.ToInt32(comboBox1.Text);
            vehicle_type = comboBox3.Text;
            points = Convert.ToInt32(textBox7.Text);
            Electronic_Card ElectronicCard = new Electronic_Card(card_id, points);
            if (vehicle_type == "Bus")
            {
                transfernumber = Convert.ToInt32(comboBox4.Text);
                Deducted_amount = ElectronicCard.transfer(transfernumber);
            }
            else if (vehicle_type == "Metrobus")
            {
                stopsnumber = Convert.ToInt32(textBox2.Text);
                Deducted_amount = ElectronicCard.metrobus(stopsnumber);
            }
            else
            {
                MessageBox.Show("Please Choise Vehicle Type");
                Deducted_amount = 0;
            }
            dataGridView1.Rows[count].Cells[0].Value = ElectronicCard.Card_id.ToString();
            dataGridView1.Rows[count].Cells[1].Value = Deducted_amount.ToString();
            dataGridView1.Rows[count].Cells[2].Value = ElectronicCard.Points.ToString();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Blue_Card_Form blue = new Blue_Card_Form();
            blue.Show();
            this.Close();
        }
    }
}
