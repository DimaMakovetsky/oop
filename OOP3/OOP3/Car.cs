using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP3
{
    [Serializable]
    [XmlInclude(typeof(Transport))]
    
    public class Car:Transport
    {
        public int doorAmount { get; set; }
        
        public Car(FactoryInfo info, double price, int mass, int horsePower, int doorAmount):base(info, price, mass, horsePower)
        {
            this.doorAmount = doorAmount;
        }
        public Car()
        { }
        public override int DoorAmount { get {return doorAmount; } set {doorAmount=value; } }
        
    }
}
