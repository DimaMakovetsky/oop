using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    [Serializable]
    public class Bicycle:Motorcycle
    {
        bool type;
        public Bicycle(FactoryInfo info, double price, int mass, int horsePower, string frame, bool type) : base(info, price, mass, horsePower, frame)
        {
            this.type = type;
        }
        public Bicycle()
        { }
        public override bool Type{ get { return type; } set { type= value; } }
    }
}
