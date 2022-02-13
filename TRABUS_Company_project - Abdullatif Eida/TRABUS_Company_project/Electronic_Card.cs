using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABUS_Company_project
{
    class Electronic_Card:Card
    {
        private int points;

        public Electronic_Card(int card_id ,int points)
            : base(card_id)
        {
            this.points = points;
        }

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
            return base.ToString() + "Card Points=" + points + " \r\n -- The other cards -- \r\n";
        }
    }
}
