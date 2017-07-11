using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;

namespace BALayer
{
    public class BAL
    {
        BEL beobj = new BEL();
        DAL daobj = new DAL();

        public int userdetails(BEL beobj)
        {
            return daobj.userinsert(beobj);
        }
    }
}
