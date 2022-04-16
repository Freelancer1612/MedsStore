using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsOnline.General
{
    public class Response
    {
        public String Status { get; set; }

        public String Message{get; set;}


        public dynamic Result { get; set; }
    }
}
