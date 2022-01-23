using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MorseDictionary : IMorseDictionary, IDictionary
    {
        public MorseDictionary(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public DateTime Created { get; set; }

    }
}
