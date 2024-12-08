using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCRM
{
    public static class AppContext
    {
        public static LoggedInUser LoggedInMember { get; set; }

        public static LoggedInUser LoggedInAdmin { get; set; }
    }
}
