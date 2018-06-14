using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Marvel
    {
        public string Name { get; set; }
        public string  LastName { get; set; }
        public string HumorLevel { get; set; }
        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
