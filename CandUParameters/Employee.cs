using System;
using System.Collections.Generic;
using System.Text;

namespace CandUParameters
{
    class Employee <T>
    {
        public int ID { get; set; }

        public object things { get; set; }

        public List<T> Things { get; set; }

    }
}
