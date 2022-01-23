using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTranslationService
{
    public interface IDictionary
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
