using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABUS_Company_project
{
    class Istanbul_Card:Card
    {
       private int customer_id;
       private String customer_type;
       private double balance;

        public Istanbul_Card(int card_id, int customer_id, string customer_type, double balance = 0)
           : base(card_id)
        {
            this.customer_id = customer_id;
            this.customer_type = customer_type;
            this.balance = balance;
        }

        public int Customer_id { get => customer_id; set => customer_id = value; }
        public string Customer_type { get => customer_type; set => customer_type = value; }
        public double Balance { get => balance; set => balance = value; }


        public override double transfer(int transfer)
        {
            double amount;
            switch(customer_type)
            {
                case "FullFare":
                    switch (transfer)
                    {
                        case 0: amount = 2.6;
                            break;
                        case 1: amount = 1.85;
                            break;
                        case 2: amount = 1.40;
                            break;
                        case 3: case 4: case 5: amount = 0.90; 
                            break;
                        default: amount = 0; break;
                    }
                    break;

                case "Student":
                    switch (transfer)
                    {
                        case 0: amount = 1.25; 
                            break;
                        case 1: amount = 0.55; 
                            break;
                        case 2: amount = 0.50; 
                            break;
                        case 3: case 4: case 5: amount = 0.45; 
                            break;
                        default: amount = 0; 
                            break;
                    }
                    break;

                case "Teacher":
                    switch (transfer)
                    {
                        case 0: amount = 1.85; 
                            break;
                        case 1: amount = 1.10;
                            break;
                        case 2: amount = 0.85;
                            break;
                        case 3: case 4: case 5: amount = 0.55;
                            break;
                        default: amount = 0; 
                            break;
                    }
                    break;
                default: amount = 0; 
                    break;

            }
            balance -= amount;
            return amount;

        }

        public override double metrobus(int metrobus_stops)
        {
            double amount;
            switch (customer_type)
            {
                case "FullFare":
                    if (metrobus_stops <= 3)
                        amount = 1.95;
                    else if (metrobus_stops <= 9)
                        amount = 3.00;
                    else if (metrobus_stops <= 15)
                        amount = 3.25;
                    else if (metrobus_stops <= 21)
                        amount = 3.40;
                    else if (metrobus_stops <= 27)
                        amount = 3.50;
                    else if (metrobus_stops <= 33)
                        amount = 3.60;
                    else
                        amount = 3.85;
                    break;

                case "Student":
                    if (metrobus_stops <= 3)
                        amount = 1.10;
                    else if (metrobus_stops <= 9)
                        amount = 1.20;
                    else
                        amount = 1.25;
                    break;

                case "Teacher":
                    if (metrobus_stops <= 3)
                        amount = 1.45;
                    else if (metrobus_stops <= 9)
                        amount = 1.85;
                    else if (metrobus_stops <= 15)
                        amount = 1.9;
                    else if (metrobus_stops <= 27)
                        amount = 2.00;
                    else
                        amount = 2.10;
                    break;

                default:amount = 0;break;
            }
            balance -= amount;
            return amount;
        }
        public override string ToString()
        {
            return base.ToString() + "Customer ID=" + customer_id + " \r\n " + "Customer Type=" + customer_type +
                " \r\n " + " Balance In TL=" + balance + " \r\n -- The other cards -- \r\n";
        }
    }
}
