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
    public partial class Blue_Card_List : Form
    {
        public Blue_Card_List()
        {
            InitializeComponent();
        }

        private void Blue_Card_List_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-V9AF34JG\SQLEXPRESS; Initial Catalog=Company; Integrated Security=true;");
                SqlCommand command1 = new SqlCommand("Select * from BlueCard", connect);
                {
                    connect.Open();
                    SqlDataReader reader = command1.ExecuteReader();
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                Card_List[] cardLists = new Card_List[1];
                cardLists[0] = new BlueCard_List();
                foreach (Card_List cardList in cardLists)
                {
                    foreach (Card card in cardList.Cardlist)
                    {
                        textBox1.Text += " " + card.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Istanbul_Card_List Istanbullist = new Istanbul_Card_List();
            Istanbullist.Show();
            this.Close();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Blue_Card_List blue = new Blue_Card_List();
            blue.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Electronic_Card_List electronic = new Electronic_Card_List();
            electronic.Show();
            this.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
