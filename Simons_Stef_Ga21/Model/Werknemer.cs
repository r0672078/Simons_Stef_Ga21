using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simons_Stef_Ga21.Model
{
    class Werknemer
    {
        public string werknemer_id { get; set; }

        public ICollection<Winkel> Winkels { get; set; }
    }
}
