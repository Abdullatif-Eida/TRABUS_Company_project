using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABUS_Company_project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateI_stanbul_Card istanbul = new CreateI_stanbul_Card();
              istanbul.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Create_BlueCard istanbul = new Create_BlueCard();
            istanbul.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Create_ElectronicCard elec = new Create_ElectronicCard();
            elec.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Istanbul_Card_List Istanbullist = new Istanbul_Card_List();
            Istanbullist.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Blue_Card_List blue = new Blue_Card_List();
            blue.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Electronic_Card_List electronic = new Electronic_Card_List();
            electronic.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
