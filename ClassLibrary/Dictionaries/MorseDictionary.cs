using ClassLibraryForTranslationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTranslationService
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
