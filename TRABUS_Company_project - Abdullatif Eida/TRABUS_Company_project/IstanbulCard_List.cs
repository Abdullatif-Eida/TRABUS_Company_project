using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABUS_Company_project
{
    class IstanbulCard_List:Card_List
    {
        public override void CreateCard_List() 
        {
            Istanbul_Card istanbulCard1 = new Istanbul_Card(100, 998456, "full", 100);
            istanbulCard1.transfer(0);
            istanbulCard1.transfer(1);
            istanbulCard1.transfer(2);
            istanbulCard1.metrobus(12);
            istanbulCard1.transfer(3);
            istanbulCard1.transfer(4);

            Istanbul_Card istanbulCard2 = new Istanbul_Card(200, 696648, "student", 50);
            istanbulCard2.transfer(0);
            istanbulCard2.transfer(1);
            istanbulCard2.transfer(2);
            istanbulCard2.transfer(3);
            istanbulCard2.metrobus(20);

            Istanbul_Card istanbulCard3 = new Istanbul_Card(300, 48964165, "teacher", 200);
            istanbulCard3.metrobus(18);
            istanbulCard3.transfer(0);
            istanbulCard3.transfer(1);
            istanbulCard3.transfer(2);
            istanbulCard3.transfer(3);

            Cardlist.Add(istanbulCard1);
            Cardlist.Add(istanbulCard2);
            Cardlist.Add(istanbulCard3);
        }
    }
}
