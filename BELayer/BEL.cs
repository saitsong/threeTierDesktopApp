using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BELayer
{
    public class BEL
    {
        public string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
}
