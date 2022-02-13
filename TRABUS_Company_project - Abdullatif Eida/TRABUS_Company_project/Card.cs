using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABUS_Company_project
{
    public abstract class Card
    {
        private int card_id;

        public int Card_id { get => card_id; set => card_id = value; }

        protected Card(int card_id)
        {
            this.card_id = card_id;
        }


        public abstract double transfer(int transfer);
        public abstract double metrobus(int metrobus_stops);
        public override string ToString()
        {
            return "Card Id= " + Card_id + " \r\n ";
        }
    }
}
