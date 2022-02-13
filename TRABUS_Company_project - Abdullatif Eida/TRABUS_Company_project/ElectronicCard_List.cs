using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABUS_Company_project
{
    class ElectronicCard_List:Card_List
    {
        public override void CreateCard_List()
        {
            Electronic_Card electronicCardlist1 = new Electronic_Card(120, 20);
            electronicCardlist1.transfer(0);
            electronicCardlist1.metrobus(22);

            Electronic_Card electronicCardlist2 = new Electronic_Card(220, 30);
            electronicCardlist2.transfer(0);
            electronicCardlist2.transfer(1);
            electronicCardlist2.transfer(2);
            electronicCardlist2.transfer(3);
            electronicCardlist2.transfer(4);
            electronicCardlist2.metrobus(5);

            Electronic_Card electronicCardlist3 = new Electronic_Card(320, 15);
            electronicCardlist3.transfer(0);
            electronicCardlist2.metrobus(2);
            electronicCardlist3.transfer(1);

            Cardlist.Add(electronicCardlist1);
            Cardlist.Add(electronicCardlist2);
            Cardlist.Add(electronicCardlist3);
        }
    }
}
