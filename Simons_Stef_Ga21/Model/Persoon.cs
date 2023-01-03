using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simons_Stef_Ga21.Model
{
    class Persoon
    {
        public string persoon_id { get; set; }
        public string persoon_firstName { get; set; }
        public string persoon_familyName { get; set; }
        public string adress { get; set; }
        public string email { get; set; }
        public string gsm { get; set; }
        public bool geslacht { get; set; }
    }
}
