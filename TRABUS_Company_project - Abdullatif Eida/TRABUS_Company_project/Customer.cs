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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Istanbul_Card_Form istanbul = new Istanbul_Card_Form();
            istanbul.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Blue_Card_Form blue = new Blue_Card_Form();
            blue.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Electronic_card_form electronic = new Electronic_card_form();
            electronic.Show();

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
