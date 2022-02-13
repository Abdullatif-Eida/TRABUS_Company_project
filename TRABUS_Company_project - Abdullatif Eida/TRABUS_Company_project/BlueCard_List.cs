using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABUS_Company_project
{
    class BlueCard_List:Card_List
    {
        public override void CreateCard_List()
        {
            Blue_Card blueCardlist1 = new Blue_Card(110 , 4547466, "Abdullatif" ,"full", 15);
            blueCardlist1.transfer(0);
            blueCardlist1.metrobus(5);
            blueCardlist1.transfer(1);
            blueCardlist1.transfer(2);

            Blue_Card blueCardlist3 = new Blue_Card(210, 234894, "Fadi", "teacher", 5);
            blueCardlist3.metrobus(5);
            blueCardlist3.transfer(0);

            Blue_Card blueCardlist2 = new Blue_Card(310, 6549841, "Zain", "student", 15);
            blueCardlist2.transfer(0);
            blueCardlist2.transfer(1);

            Cardlist.Add(blueCardlist1);
            Cardlist.Add(blueCardlist2);
            Cardlist.Add(blueCardlist3);
        }
    }
}
