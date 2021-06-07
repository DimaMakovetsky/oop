using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    [Serializable]
    public class Motorcycle:Transport
    {
        string frame;
        public Motorcycle(FactoryInfo info, double price, int mass, int horsePower, string frame) : base(info, price, mass, horsePower)
        {
            this.frame = frame;
        }
        public Motorcycle()
        { }
        public override string Frame{ get { return frame; } set { frame= value; } }
    }
}
