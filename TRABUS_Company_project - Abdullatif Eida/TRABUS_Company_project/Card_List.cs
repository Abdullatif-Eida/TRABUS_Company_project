using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABUS_Company_project
{
    public abstract class Card_List
    {
        private List<Card> _cardlist = new List<Card>();
        public Card_List()
        {
            this.CreateCard_List();
        }
        public List<Card> Cardlist
        {
            get { return _cardlist; }
        }
        public abstract void CreateCard_List();
    }
}
