using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normirovanie
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public District District { get; set; }
        public User()
        {

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
