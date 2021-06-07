using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    [Serializable]
    public class Boat:Transport
    {
        int cruiseSpeed;
        public Boat(FactoryInfo info, double price, int mass, int horsePower, int cruiseSpeed) : base(info, price, mass, horsePower)
        {
            this.cruiseSpeed = cruiseSpeed;
        }
        public Boat()
        { }
        public override int CruiseSpeed{ get { return cruiseSpeed; } set { cruiseSpeed= value; } }
    }
}
