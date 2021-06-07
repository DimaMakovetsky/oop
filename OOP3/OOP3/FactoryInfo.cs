using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    [Serializable]
    
    public class FactoryInfo
    {
        public string manufacturer { get; set; }
        public string model { get; set; }
        public FactoryInfo(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }
        public FactoryInfo()
        { }
    }
}
