using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABUS_Company_project
{
    class Blue_Card:Card
    {
        private int customer_id;
        private String customer_name;
        private String customer_type;
        private int points;

        public Blue_Card(int card_id, int customer_id, string customer_name, string customer_type, int points = 0)
            : base(card_id)
        {
            this.customer_id = customer_id;
            this.customer_name = customer_name;
            this.customer_type = customer_type;
            this.points = points;
        }

        public int Customer_id { get => customer_id; set => customer_id = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        public string Customer_type { get => customer_type; set => customer_type = value; }
        public int Points { get => points; set => points = value; }

        public override double transfer(int transfer)
        {
            points -= 1;
            return 1;
        }

        public override double metrobus(int metrobus_stops)
        {
            int amount;
            if (metrobus_stops <= 3)
                amount = 1;
            else
                amount = 2;

            points -= amount;
            return amount;

        }
        public override string ToString()
        {
            return base.ToString() + "Customer ID= " + customer_id + " \r\n "
                + "Customer Name= " + customer_name + " \r\n " + "Customer Type= " 
                + customer_type + " \r\n " + "Card Points= " + points + " \r\n -- The other cards -- \r\n"; 
        }
    }
}
