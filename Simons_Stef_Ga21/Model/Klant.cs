using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simons_Stef_Ga21.Model
{
    class Klant
    {
        public string klant_id { get; set; }

        public ICollection<Winkel> Winkels { get; set; }
    }
}
